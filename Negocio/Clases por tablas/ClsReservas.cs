using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class ClsReservas : Reserva
    {
        public enum ETipoDeFiltro
        {
            ReservasActivas, ReservasExpiradas, Filtro
        }

        /// <summary>
        /// Busca todos los datos del registro en cuestion para ser mostrados.
        /// </summary>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        /// <param name="_FechaDesde">Fecha de inicio desde que se buscara la coincidencia con el resto de filtros.</param>
        /// <param name="_FechaHasta">Fecha de fin donde se buscara la coincidencia con el resto de filtros.</param>
        /// <param name="_NombreCliente">Busca el nombre de un cliente.</param>
        /// <param name="_EstadoReserva">Lista las reservas que coincidan con el estado indicado.</param>
        /// <param name="_AplicaFiltro">Indica si carga solo un tipo de estado de reserva, o carga las pendientes y 
        /// sin confirmar tambien (a partir del dia actual).</param>
        public List<Reserva> LeerListado(ETipoDeFiltro _TipoDeFiltro, ref string _InformacionDelError, string _FechaDesde = "", string _FechaHasta = "", string _NombreCliente = "", int _EstadoReserva = 0, bool _AplicaFiltro = false)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeFiltro)
                    {
                        case ETipoDeFiltro.ReservasActivas:
                            return BBDD.Reserva.Include("Cliente").Include("EstadoReserva").Where(Identificador => Identificador.Fecha >= DateTime.Today
&& (Identificador.ID_EstadoReserva != (int)ClsEstadoReservas.EEstadosReservas.Eliminada
|| Identificador.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.SinConfirmar)).ToList();

                        case ETipoDeFiltro.ReservasExpiradas:
                            return BBDD.Reserva.Include("Cliente").Include("EstadoReserva").Where(Identificador => Identificador.Fecha <= DateTime.Today
&& (Identificador.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.Pendiente
|| Identificador.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.SinConfirmar)).ToList();

                        case ETipoDeFiltro.Filtro:
                            {
                                List<Func<Reserva, bool>> Predicado = new List<Func<Reserva, bool>>();
                                List<Reserva> ListaFiltrada = null;

                                // Como pre filtro uso la fecha desde que generalmente esta disponible siempre, si no lo esta, realiza el filtrado sobre
                                // todos los registros

                                if (_FechaDesde != string.Empty && _FechaHasta != string.Empty)
                                {
                                    DateTime FechaDesde = Convert.ToDateTime(_FechaDesde).Date;
                                    DateTime FechaHasta = Convert.ToDateTime(_FechaHasta).Date;

                                    ListaFiltrada = BBDD.Reserva.Include("Cliente").Include("EstadoReserva").Where(Identificador => Identificador.Fecha >= FechaDesde
                                    && Identificador.Fecha <= FechaHasta).ToList();
                                }
                                else if (_FechaDesde != string.Empty)
                                {
                                    DateTime FechaDesde = Convert.ToDateTime(_FechaDesde).Date;

                                    ListaFiltrada = BBDD.Reserva.Include("Cliente").Include("EstadoReserva").Where(Identificador => Identificador.Fecha >= FechaDesde).ToList();
                                }
                                else if (_FechaHasta != string.Empty)
                                {
                                    DateTime FechaHasta = Convert.ToDateTime(_FechaHasta).Date;

                                    ListaFiltrada = BBDD.Reserva.Include("Cliente").Include("EstadoReserva").Where(Identificador => Identificador.Fecha <= FechaHasta).ToList();
                                }
                                else
                                {
                                    ListaFiltrada = BBDD.Reserva.Include("Cliente").Include("EstadoReserva").ToList();
                                }

                                if (_NombreCliente != string.Empty)
                                {
                                    _NombreCliente = _NombreCliente.ToLower(); // Transformo el texto a filtrar 1 sola vez
                                    Predicado.Add(Identificador => Identificador.Cliente.Nombre.ToLower().StartsWith(_NombreCliente));
                                }

                                if (_EstadoReserva > 0 || _AplicaFiltro)
                                {
                                    if (_AplicaFiltro)
                                    {
                                        Predicado.Add(Identificador => Identificador.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.Pendiente
                                        || Identificador.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.SinConfirmar);
                                    }
                                    else
                                    {
                                        Predicado.Add(Identificador => Identificador.ID_EstadoReserva == _EstadoReserva);
                                    }
                                }

                                foreach (Func<Reserva, bool> Elemento in Predicado)
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
        /// <param name="_ID_ReservaBuscar">ID del registro que se desea traer su informacion.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public Reserva LeerPorNumero(int _ID_ReservaBuscar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    return BBDD.Reserva.Include("Cliente").Include("EstadoReserva").SingleOrDefault(Identificador => Identificador.ID_Reserva == _ID_ReservaBuscar);
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
        /// <param name="_Reserva">Objeto que contiene los datos del nuevo registro que se creará.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Crear(Reserva _Reserva, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    BBDD.Reserva.Add(_Reserva);
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
        /// <param name="_Reserva">Objeto que contiene los datos del registro al que se le van a actualizar los datos.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Actualizar(Reserva _Reserva, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Reserva ObjetoActualizado = BBDD.Reserva.SingleOrDefault(Identificador => Identificador.ID_Reserva == _Reserva.ID_Reserva);

                    if (ObjetoActualizado != null)
                    {
                        ObjetoActualizado.ID_Reserva = _Reserva.ID_Reserva;
                        ObjetoActualizado.ID_Cliente = _Reserva.ID_Cliente;
                        ObjetoActualizado.Fecha = _Reserva.Fecha;
                        ObjetoActualizado.Hora = _Reserva.Hora;
                        ObjetoActualizado.CantidadPersonas = _Reserva.CantidadPersonas;
                        ObjetoActualizado.ID_ViaContacto = _Reserva.ID_ViaContacto;
                        ObjetoActualizado.ID_EstadoReserva = _Reserva.ID_EstadoReserva;

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
        /// <param name="_ID_ReservaEliminar">Registro que se eliminará.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Borrar(int _ID_ReservaEliminar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Reserva ObjetoAEliminar = BBDD.Reserva.SingleOrDefault(Identificador => Identificador.ID_Reserva == _ID_ReservaEliminar);

                    if (ObjetoAEliminar != null)
                    {
                        BBDD.Reserva.Remove(ObjetoAEliminar);
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
