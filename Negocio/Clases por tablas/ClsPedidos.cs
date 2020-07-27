using Datos;
using Negocio.Clases_por_tablas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class ClsPedidos : Pedido
    {
        public enum ETipoDeListado
        {
            PedidosEnProceso, FiltroDelivery, DeliveryNoEntregado, todos
        }

        /// <summary>
        /// Busca todos los datos del registro en cuestion para ser mostrados. Pasar los parametros opcionales
        /// que se requieran, los qeu no, pasar el valor por defecto.
        /// </summary>
        /// <param name="_TipoDeListado"></param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        /// <param name="_FechaDesde">Desde la fecha en que se buscara.</param>
        /// <param name="_FechaHasta">Hasta la fecha en que se buscara.</param>
        /// <param name="_NombreCliente">Nombre del cliente que se quiere buscar.</param>
        /// <param name="_EstadoDelivery">El estado del delivery que se necesite buscar.</param>
        /// <param name="_DeliveryEnCocinaNoEntregado">Pasar true si se quieren los deliveries entregados como los que no (no 
        /// necesita que se pase un "_EstadoDelivery" como parametro opcional).</param>
        public List<Pedido> LeerListado(ETipoDeListado _TipoDeListado, ref string _InformacionDelError, string _FechaDesde = "", string _FechaHasta = "", string _NombreCliente = "", int _EstadoDelivery = 0, bool _DeliveryEnCocinaNoEntregado = false)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeListado)
                    {
                        case ETipoDeListado.todos:
                            return BBDD.Pedido.ToList();
                        case ETipoDeListado.PedidosEnProceso:
                            {
                                return BBDD.Pedido.Include("Delivery.EstadoDelivery").Where(Identificador => Identificador.ID_EstadoPedido == (int)ClsEstadosPedidos.EEstadosPedidos.EnProceso)
                                .OrderBy(Identificador => Identificador.TiempoEspera).ToList();
                            }
                        case ETipoDeListado.DeliveryNoEntregado:
                            {
                                return BBDD.Pedido.Include("Cliente").Include("Delivery.EstadoDelivery").Where(Identificador => Identificador.ID_Delivery != null
                                && Identificador.Delivery.ID_EstadoDelivery == (int)ClsEstadosDeliveries.EEstadosDeliveries.ParaEntrega)
                                .OrderBy(Identificador => Identificador.Fecha)
                                .ThenBy(Identificador => Identificador.Hora).ToList();
                            }
                        case ETipoDeListado.FiltroDelivery:
                            {
                                List<Func<Pedido, bool>> Predicado = new List<Func<Pedido, bool>>();
                                List<Pedido> ListaFiltrada = null;

                                // Como pre filtro uso la fecha desde que generalmente esta disponible siempre, si no lo esta, realiza el filtrado sobre
                                // todos los registros (Siempre ignorando las reservas eliminadas)

                                if (_FechaDesde != string.Empty && _FechaHasta != string.Empty)
                                {
                                    DateTime FechaDesde = Convert.ToDateTime(_FechaDesde).Date;
                                    DateTime FechaHasta = Convert.ToDateTime(_FechaHasta).Date;

                                    ListaFiltrada = BBDD.Pedido.Include("Cliente").Include("Delivery.EstadoDelivery").Where(Identificador => Identificador.Fecha >= FechaDesde
                                    && Identificador.Fecha <= FechaHasta
                                    && Identificador.ID_Delivery != null).ToList();
                                }
                                else if (_FechaDesde != string.Empty)
                                {
                                    DateTime FechaDesde = Convert.ToDateTime(_FechaDesde).Date;

                                    ListaFiltrada = BBDD.Pedido.Include("Cliente").Include("Delivery.EstadoDelivery").Where(Identificador => Identificador.Fecha >= FechaDesde
                                    && Identificador.ID_Delivery != null).ToList();
                                }
                                else if (_FechaHasta != string.Empty)
                                {
                                    DateTime FechaHasta = Convert.ToDateTime(_FechaHasta).Date;

                                    ListaFiltrada = BBDD.Pedido.Include("Cliente").Include("Delivery.EstadoDelivery").Where(Identificador => Identificador.Fecha <= FechaHasta
                                    && Identificador.ID_Delivery != null).ToList();
                                }
                                else
                                {
                                    ListaFiltrada = BBDD.Pedido.Include("Cliente").Include("Delivery.EstadoDelivery").Where(Identificador => Identificador.ID_Delivery != null).ToList();
                                }

                                if (_NombreCliente != string.Empty)
                                {
                                    _NombreCliente = _NombreCliente.ToLower(); // Transformo el texto a filtrar 1 sola vez
                                    Predicado.Add(Identificador => Identificador.Cliente.Nombre.ToLower().StartsWith(_NombreCliente));
                                }

                                if (!_DeliveryEnCocinaNoEntregado)
                                {
                                    if (_EstadoDelivery > 0)
                                    {
                                        Predicado.Add(Identificador => Identificador.Delivery.ID_EstadoDelivery == _EstadoDelivery);
                                    }
                                }
                                else
                                {
                                    Predicado.Add(Identificador => Identificador.Delivery.ID_EstadoDelivery == (int)ClsEstadosDeliveries.EEstadosDeliveries.EnCocina
                                    || Identificador.Delivery.ID_EstadoDelivery == (int)ClsEstadosDeliveries.EEstadosDeliveries.ParaEntrega);
                                }

                                foreach (Func<Pedido, bool> Elemento in Predicado)
                                {
                                    ListaFiltrada = ListaFiltrada.Where(Elemento).ToList();
                                }

                                // Retornar la lista filtrada y ordenada
                                return ListaFiltrada.OrderBy(Identificador => Identificador.Fecha).ThenBy(Identificador => Identificador.Hora).ToList();
                            }

                        default: return null;
                    }
                }
                catch (Exception Error)
                {
                    _InformacionDelError = $"OCURRIO UN ERROR INESPERADO AL INTENTAR LISTAR LA INFORMACIÓN: {Error.Message}\r\n\r\n" +
                    $"ORIGEN DEL ERROR: {Error.StackTrace}\r\n\r\n" +
                    $"OBJETO QUE GENERÓ EL ERROR: {Error.Data}\r\n\r\n\r\n" +
                    $"ENVIE AL PROGRAMADOR UNA FOTO DE ESTE MENSAJE CON UNA DESCRIPCION DE LO QUE HIZO ANTES DE QUE SE GENERARÁ " +
                    $"ESTE ERROR PARA QUE SEA ARREGLADO.";
                    return null;
                }
            }
        }

        /// <summary>
        /// Busca y devuelve los datos del registro especificado mediente el ID proporcionado.
        /// </summary>
        /// <param name="_ID_PedidoBuscar">ID del registro que se desea traer su informacion.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public Pedido LeerPorNumero(int _ID_PedidoBuscar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    return BBDD.Pedido.Include("Cliente").Include("Delivery.EstadoDelivery").SingleOrDefault(Identificador => Identificador.ID_Pedido == _ID_PedidoBuscar);
                }
                catch (Exception Error)
                {
                    _InformacionDelError = $"OCURRIO UN ERROR INESPERADO AL INTENTAR LISTAR LA INFORMACIÓN: {Error.Message}\r\n\r\n" +
                    $"ORIGEN DEL ERROR: {Error.StackTrace}\r\n\r\n" +
                    $"OBJETO QUE GENERÓ EL ERROR: {Error.Data}\r\n\r\n\r\n" +
                    $"ENVIE AL PROGRAMADOR UNA FOTO DE ESTE MENSAJE CON UNA DESCRIPCION DE LO QUE HIZO ANTES DE QUE SE GENERARÁ " +
                    $"ESTE ERROR PARA QUE SEA ARREGLADO.";
                    return null;
                }
            }
        }

        /// <summary>
        /// Crea un nuevo registro a partir de los datos que contiene el objeto pasado por parametro.
        /// </summary>
        /// <param name="_Pedido">Objeto que contiene los datos del nuevo registro que se creará.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Crear(Pedido _Pedido, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    BBDD.Pedido.Add(_Pedido);
                    return BBDD.SaveChanges();
                }
                catch (Exception Error)
                {
                    _InformacionDelError = $"OCURRIO UN ERROR INESPERADO AL INTENTAR LISTAR LA INFORMACIÓN: {Error.Message}\r\n\r\n" +
                    $"ORIGEN DEL ERROR: {Error.StackTrace}\r\n\r\n" +
                    $"OBJETO QUE GENERÓ EL ERROR: {Error.Data}\r\n\r\n\r\n" +
                    $"ENVIE AL PROGRAMADOR UNA FOTO DE ESTE MENSAJE CON UNA DESCRIPCION DE LO QUE HIZO ANTES DE QUE SE GENERARÁ " +
                    $"ESTE ERROR PARA QUE SEA ARREGLADO.";
                    return 0;
                }
            }
        }

        /// <summary>
        /// Actualiza el registro mediente el ID que contiene el objeto proporcionado como parametro.
        /// </summary>
        /// <param name="_Pedido">Objeto que contiene los datos del registro al que se le van a actualizar los datos.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Actualizar(Pedido _Pedido, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Pedido ObjetoActualizado = BBDD.Pedido.SingleOrDefault(Identificador => Identificador.ID_Pedido == _Pedido.ID_Pedido);

                    if (ObjetoActualizado != null)
                    {
                        ObjetoActualizado.ID_Pedido = _Pedido.ID_Pedido;
                        ObjetoActualizado.Fecha = _Pedido.Fecha;
                        ObjetoActualizado.Hora = _Pedido.Hora;
                        ObjetoActualizado.CantidadPersonas = _Pedido.CantidadPersonas;
                        ObjetoActualizado.ID_EstadoPedido = _Pedido.ID_EstadoPedido;
                        ObjetoActualizado.ID_Cliente = _Pedido.ID_Cliente;
                        ObjetoActualizado.ID_Reserva = _Pedido.ID_Reserva;
                        ObjetoActualizado.Nota = _Pedido.Nota;
                        ObjetoActualizado.ID_Chef = _Pedido.ID_Chef;
                        ObjetoActualizado.TiempoEspera = _Pedido.TiempoEspera;
                        ObjetoActualizado.TotalPedido = _Pedido.TotalPedido;
                        ObjetoActualizado.ID_Mozo = _Pedido.ID_Mozo;

                        return BBDD.SaveChanges();
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (Exception Error)
                {
                    _InformacionDelError = $"OCURRIO UN ERROR INESPERADO AL INTENTAR LISTAR LA INFORMACIÓN: {Error.Message}\r\n\r\n" +
                    $"ORIGEN DEL ERROR: {Error.StackTrace}\r\n\r\n" +
                    $"OBJETO QUE GENERÓ EL ERROR: {Error.Data}\r\n\r\n\r\n" +
                    $"ENVIE AL PROGRAMADOR UNA FOTO DE ESTE MENSAJE CON UNA DESCRIPCION DE LO QUE HIZO ANTES DE QUE SE GENERARÁ " +
                    $"ESTE ERROR PARA QUE SEA ARREGLADO.";
                    return 0;
                }
            }

        }

        /// <summary>
        /// Busca el registro que contiene el ID pasado por parametro y lo elimina.
        /// </summary>
        /// <param name="_ID_PedidoEliminar">Registro que se eliminará.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Borrar(int _ID_PedidoEliminar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Pedido ObjetoAEliminar = BBDD.Pedido.SingleOrDefault(Identificador => Identificador.ID_Pedido == _ID_PedidoEliminar);

                    if (ObjetoAEliminar != null)
                    {
                        BBDD.Pedido.Remove(ObjetoAEliminar);
                        return BBDD.SaveChanges();
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (Exception Error)
                {
                    _InformacionDelError = $"OCURRIO UN ERROR INESPERADO AL INTENTAR LISTAR LA INFORMACIÓN: {Error.Message}\r\n\r\n" +
                    $"ORIGEN DEL ERROR: {Error.StackTrace}\r\n\r\n" +
                    $"OBJETO QUE GENERÓ EL ERROR: {Error.Data}\r\n\r\n\r\n" +
                    $"ENVIE AL PROGRAMADOR UNA FOTO DE ESTE MENSAJE CON UNA DESCRIPCION DE LO QUE HIZO ANTES DE QUE SE GENERARÁ " +
                    $"ESTE ERROR PARA QUE SEA ARREGLADO.";
                    return 0;
                }
            }
        }
    }
}
