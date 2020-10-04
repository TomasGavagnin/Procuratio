using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio.Clases_por_tablas
{
    public class ClsClientesXPedidos : ClienteXPedido
    {
        public enum ETipoListado
        {
            /// <summary>
            /// Trae de la BBDD
            /// </summary>
            AsistenciasSuperadas,
            /// <summary>
            /// Trae de la BBDD
            /// </summary>
            BuscarParaEliminar,
            /// <summary>
            /// Trae de la BBDD
            /// </summary>
            ClientesPedido,
            /// <summary>
            /// Trae de la BBDD
            /// </summary>
            CantidadAsistencias
        }

        /// <summary>
        /// Busca todos los datos del registro en cuestion para ser mostrados.
        /// </summary>
        /// <param name="_TipoDeFiltro">Especifica el tipo de listado que se va a realizar.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        /// <param name="_ID_Cliente">Busca los datos de un cliente en especifico.</param>
        /// <param name="_ID_Pedido">Busca por el numero de pedido</param>
        public List<ClienteXPedido> LeerListado(ETipoListado _TipoDeFiltro, ref string _InformacionDelError, int _ID_Cliente = 0, int _ID_Pedido = 0)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeFiltro)
                    {
                        case ETipoListado.AsistenciasSuperadas:
                            {
                                return BBDD.ClienteXPedido.Include("EstadoClienteXPedido").Include("Pedido").Where(Identificador => Identificador.ID_Cliente == _ID_Cliente
                                && Identificador.Pedido.Fecha == DateTime.Today.Date && Identificador.Pedido.ID_EstadoPedido != (int)ClsEstadosPedidos.EEstadosPedidos.Eliminado).ToList();
                            }
                        case ETipoListado.BuscarParaEliminar:
                            {
                                return BBDD.ClienteXPedido.Where(Identificador => Identificador.ID_Pedido == _ID_Pedido).ToList();
                            }
                        case ETipoListado.ClientesPedido:
                            {
                                return BBDD.ClienteXPedido.Where(Identificador => Identificador.ID_Pedido == _ID_Pedido).ToList();
                            }
                        case ETipoListado.CantidadAsistencias:
                            {
                                return BBDD.ClienteXPedido.Include("Pedido").Where(Identificador => Identificador.ID_Cliente == _ID_Cliente
                                && Identificador.ID_EstadoClienteXPedido == (int)ClsEstadosClientesXPedidos.EEstadosClientesXPedidos.Disponible
                                && Identificador.Pedido.ID_EstadoPedido == (int)ClsEstadosPedidos.EEstadosPedidos.Finalizado).ToList();
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
        /// <param name="_ID_ClsClientesXPedidos">ID del registro que se desea traer su informacion.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public ClienteXPedido LeerPorNumero(int _ID_ClienteXPedido, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    return BBDD.ClienteXPedido.SingleOrDefault(Identificador => Identificador.ID_ClienteXPedido == _ID_ClienteXPedido);
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
        /// <param name="_EstadoClienteXPedido">Objeto que contiene los datos del nuevo registro que se creará.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Crear(ClienteXPedido _ClienteXPedido, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    BBDD.ClienteXPedido.Add(_ClienteXPedido);
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
        /// <param name="_ClienteXPedido">Objeto que contiene los datos del registro al que se le van a actualizar los datos.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Actualizar(ClienteXPedido _ClienteXPedido, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    ClienteXPedido ObjetoActualizado = BBDD.ClienteXPedido.SingleOrDefault(Identificador => Identificador.ID_ClienteXPedido == _ClienteXPedido.ID_ClienteXPedido);

                    if (ObjetoActualizado != null)
                    {
                        ObjetoActualizado.ID_ClienteXPedido = _ClienteXPedido.ID_ClienteXPedido;
                        ObjetoActualizado.ID_Cliente = _ClienteXPedido.ID_Cliente;
                        ObjetoActualizado.ID_Pedido = _ClienteXPedido.ID_Pedido;
                        ObjetoActualizado.ID_EstadoClienteXPedido = _ClienteXPedido.ID_EstadoClienteXPedido;

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
        /// <param name="_ID_ClienteXPedidoEliminar">Registro que se eliminará.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Borrar(int _ID_ClienteXPedidoEliminar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    ClienteXPedido ObjetoAEliminar = BBDD.ClienteXPedido.SingleOrDefault(Identificador => Identificador.ID_ClienteXPedido == _ID_ClienteXPedidoEliminar);

                    if (ObjetoAEliminar != null)
                    {
                        BBDD.ClienteXPedido.Remove(ObjetoAEliminar);
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
