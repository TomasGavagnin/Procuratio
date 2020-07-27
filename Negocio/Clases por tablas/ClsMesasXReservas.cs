using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ClsMesasXReservas : MesaXReserva
    {
        public enum EMesasDisponibles
        {
            MesasDisponiblesPA, MesasDisponiblesPB, MesasReservadas, PorID
        }

        /// <summary>
        /// Busca todos los datos del registro en cuestion para ser mostrados.
        /// </summary>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        /// <param name="_TipoDeListado">Lista las mesas disponibles para reservas segun la planta.</param>
        /// <param name="_FechaReservar">Establecera las mesas disponibles del dia que se quiere reservar.</param>
        public List<MesaXReserva> LeerListado(EMesasDisponibles _TipoDeListado, ref string _InformacionDelError, DateTime _FechaReservar, int _ID_Reserva = 0)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeListado)
                    {
                        case EMesasDisponibles.PorID: return BBDD.MesaXReserva.Where(Identificador => Identificador.ID_Reserva == _ID_Reserva).ToList();

                        case EMesasDisponibles.MesasReservadas:
                            return BBDD.MesaXReserva.Include("Reserva").Include("Mesa").Where(Identificador => Identificador.Reserva.ID_Reserva == _ID_Reserva).ToList();
                        case EMesasDisponibles.MesasDisponiblesPB:

                            return BBDD.MesaXReserva.Include("Reserva").Include("Mesa").Where(Identificador => Identificador.Reserva.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.Pendiente
                            && Identificador.Reserva.Fecha == _FechaReservar).ToList();

                        case EMesasDisponibles.MesasDisponiblesPA:
                            return BBDD.MesaXReserva.Include("Reserva").Where(Identificador => Identificador.Reserva.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.Pendiente
                            && Identificador.Reserva.Fecha == _FechaReservar).ToList();
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
        /// <param name="_ID_MesaXReservaBuscar">ID del registro que se desea traer su informacion.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public MesaXReserva LeerPorNumero(int _ID_MesaXReservaBuscar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    return BBDD.MesaXReserva.SingleOrDefault(Identificador => Identificador.ID_MesaXReserva == _ID_MesaXReservaBuscar);
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
        /// <param name="_MesaXReserva">Objeto que contiene los datos del nuevo registro que se creará.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Crear(MesaXReserva _MesaXReserva, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    BBDD.MesaXReserva.Add(_MesaXReserva);
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
        /// <param name="_MesaXReserva">Objeto que contiene los datos del registro al que se le van a actualizar los datos.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Actualizar(MesaXReserva _MesaXReserva, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    MesaXReserva ObjetoActualizado = BBDD.MesaXReserva.SingleOrDefault(Identificador => Identificador.ID_MesaXReserva == _MesaXReserva.ID_MesaXReserva);

                    if (ObjetoActualizado != null)
                    {
                        ObjetoActualizado.ID_MesaXReserva = _MesaXReserva.ID_MesaXReserva;
                        //ObjetoActualizado.Nombre = cliente.Nombre;
                        //ObjetoActualizado.Direccion = cliente.Direccion;
                        //ObjetoActualizado.Id_Localidad = cliente.Id_Localidad;
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
        /// <param name="_ID_MesaXReservaEliminar">Registro que se eliminará.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Borrar(int _ID_MesaXReservaEliminar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    MesaXReserva ObjetoAEliminar = BBDD.MesaXReserva.SingleOrDefault(Identificador => Identificador.ID_MesaXReserva == _ID_MesaXReservaEliminar);

                    if (ObjetoAEliminar != null)
                    {
                        BBDD.MesaXReserva.Remove(ObjetoAEliminar);
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
