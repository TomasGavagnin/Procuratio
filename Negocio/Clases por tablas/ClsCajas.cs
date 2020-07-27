using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ClsCajas : Caja
    {
        public enum ETipoListado
        {
            Filtrado, CajaAbierta
        }

        /// <summary>
        /// Busca todos los datos del registro en cuestion para ser mostrados.
        /// </summary>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        /// <param name="_TipoDeListado">Indica el tipo de listado que usara</param>
        /// <param name="_FechaDesde">Fecha de inicio desde que se buscara la coincidencia con el resto de filtros.</param>
        /// <param name="_FechaHasta">Fecha de fin donde que se buscara la coincidencia con el resto de filtros.</param>
        /// <param name="_ID_TipoDeMonto">Trae los montos que coincidan con lo pasado por parametro</param>
        /// <param name="_ID_Usuario">Trae los usuarios que coincidan con lo pasado por parametro</param>
        public List<Caja> LeerListado(ETipoListado _TipoDeListado, ref string _InformacionDelError, string _FechaDesde = "", string _FechaHasta = "", int _ID_TipoDeMonto = 0, int _ID_Usuario = 0, string _HoraInicio = "", string _HoraFin = "")
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeListado)
                    {
                        case ETipoListado.Filtrado:
                            {
                                List<Func<Caja, bool>> Predicado = new List<Func<Caja, bool>>();
                                List<Caja> ListaFiltrada = null;

                                TimeSpan HoraInicio = TimeSpan.Parse(_HoraInicio);
                                TimeSpan HoraFin = TimeSpan.Parse(_HoraFin).Add(new TimeSpan(0,1,0)); // agrego 1 minuto porque sino no me toma la fecha hasta por los segundos

                                if (HoraFin >= new TimeSpan(1, 0, 0, 0)) { HoraFin = TimeSpan.Parse(_HoraFin); }

                                if (_FechaDesde != string.Empty && _FechaHasta != string.Empty)
                                {
                                    DateTime FechaDesde = Convert.ToDateTime(_FechaDesde).Date;
                                    DateTime FechaHasta = Convert.ToDateTime(_FechaHasta).Date;

                                    ListaFiltrada = BBDD.Caja.Include("EstadoCaja").Include("TipoDeMonto").Include("Usuario").Where(Identificador => (Identificador.Fecha > FechaDesde || 
                                    (Identificador.Fecha == FechaDesde && Identificador.Hora >= HoraInicio))
                                    && (Identificador.Fecha < FechaHasta || (Identificador.Fecha == FechaHasta && Identificador.Hora <= HoraFin)) && Identificador.ID_EstadoCaja == (int)ClsEstadosCajas.EEstadosCajas.Activo || Identificador.ID_EstadoCaja == (int)ClsEstadosCajas.EEstadosCajas.CajaAbierta).ToList();
                                }
                                else if (_FechaDesde != string.Empty)
                                {
                                    DateTime FechaDesde = Convert.ToDateTime(_FechaDesde).Date;

                                    ListaFiltrada = BBDD.Caja.Include("EstadoCaja").Include("TipoDeMonto").Include("Usuario").Where(Identificador => Identificador.Fecha > FechaDesde ||
                                    (Identificador.Fecha == FechaDesde && Identificador.Hora >= HoraInicio) && Identificador.ID_EstadoCaja == (int)ClsEstadosCajas.EEstadosCajas.Activo || Identificador.ID_EstadoCaja == (int)ClsEstadosCajas.EEstadosCajas.CajaAbierta).ToList();
                                }
                                else if (_FechaHasta != string.Empty)
                                {
                                    DateTime FechaHasta = Convert.ToDateTime(_FechaHasta).Date;

                                    ListaFiltrada = BBDD.Caja.Include("EstadoCaja").Include("TipoDeMonto").Include("Usuario").Where(Identificador => Identificador.Fecha < FechaHasta || 
                                    (Identificador.Fecha == FechaHasta && Identificador.Hora <= HoraFin) && Identificador.ID_EstadoCaja == (int)ClsEstadosCajas.EEstadosCajas.Activo || Identificador.ID_EstadoCaja == (int)ClsEstadosCajas.EEstadosCajas.CajaAbierta).ToList();
                                }
                                else
                                {
                                    ListaFiltrada = BBDD.Caja.Include("EstadoCaja").Include("TipoDeMonto").Include("Usuario").Where(Identificador => Identificador.ID_EstadoCaja == (int)ClsEstadosCajas.EEstadosCajas.Activo || Identificador.ID_EstadoCaja == (int)ClsEstadosCajas.EEstadosCajas.CajaAbierta).ToList();
                                }

                                if (_ID_TipoDeMonto > 0)
                                {
                                    Predicado.Add(Identificador => Identificador.TipoDeMonto.ID_TipoDeMonto == _ID_TipoDeMonto);
                                }

                                if (_ID_Usuario > 0)
                                {
                                    Predicado.Add(Identificador => Identificador.Usuario.ID_Usuario == _ID_Usuario);
                                }

                                foreach (Func<Caja, bool> Elemento in Predicado)
                                {
                                    ListaFiltrada = ListaFiltrada.Where(Elemento).ToList();
                                }

                                return ListaFiltrada.OrderBy(Identificador => Identificador.Fecha).ThenBy(Identificador => Identificador.Hora).ToList();
                            }
                        case ETipoListado.CajaAbierta:
                            {
                                return BBDD.Caja.Include("TipoDeMonto").Where(Identificador => Identificador.ID_EstadoCaja == (int)ClsEstadosCajas.EEstadosCajas.CajaAbierta).ToList();
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
        /// <param name="_ID_CajaBuscar">ID del registro que se desea traer su informacion.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public Caja LeerPorNumero(int _ID_CajaBuscar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    return BBDD.Caja.SingleOrDefault(Identificador => Identificador.ID_Caja == _ID_CajaBuscar);
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
        /// <param name="_Caja">Objeto que contiene los datos del nuevo registro que se creará.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Crear(Caja _Caja, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    BBDD.Caja.Add(_Caja);
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
        /// <param name="_Caja">Objeto que contiene los datos del registro al que se le van a actualizar los datos.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Actualizar(Caja _Caja, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Caja ObjetoActualizado = BBDD.Caja.SingleOrDefault(Identificador => Identificador.ID_Caja == _Caja.ID_Caja);

                    if (ObjetoActualizado != null)
                    {
                        ObjetoActualizado.ID_Caja = _Caja.ID_Caja;
                        ObjetoActualizado.Fecha = _Caja.Fecha;
                        ObjetoActualizado.Hora = _Caja.Hora;
                        ObjetoActualizado.Monto = _Caja.Monto;
                        ObjetoActualizado.Detalle = _Caja.Detalle;
                        ObjetoActualizado.ID_Pedido = _Caja.ID_Pedido;
                        ObjetoActualizado.ID_TipoDeMonto = _Caja.ID_TipoDeMonto;
                        ObjetoActualizado.ID_EstadoCaja = _Caja.ID_EstadoCaja;
                        ObjetoActualizado.ID_Usuario = _Caja.ID_Usuario;

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
        /// <param name="_ID_CajaEliminar">Registro que se eliminará.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Borrar(int _ID_CajaEliminar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Caja ObjetoAEliminar = BBDD.Caja.SingleOrDefault(Identificador => Identificador.ID_Caja == _ID_CajaEliminar);

                    if (ObjetoAEliminar != null)
                    {
                        BBDD.Caja.Remove(ObjetoAEliminar); 
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
