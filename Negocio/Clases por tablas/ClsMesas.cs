using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class ClsMesas : Mesa
    {
        public enum ETipoDeListado
        {
            Todo, MesasActivasPB, MesasActivasPA, PorID, PorNumeroDeMesa, PrimerMesaInactivaPB, PrimerMesaInactivaPA, MesasDisponiblesPB,
            MesasDisponiblesPA, MesasEditar, MesasOcupadas, MesasAOcuparLiberar
        }

        /// <summary>
        /// Busca todos los datos del registro en cuestion para ser mostrados.
        /// </summary>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        /// <param name="_TipoDeFiltro">Filtra la lista segun la enumeracion proporcionada.</param>
        ///         /// <param name="ID_Mesas">ID de mesas.</param>
        public List<Mesa> LeerListado(ETipoDeListado _TipoDeFiltro, ref string _InformacionDelError, List<int> _ID_Mesas = null)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeFiltro)
                    {
                        case ETipoDeListado.Todo: return BBDD.Mesa.ToList();

                        case ETipoDeListado.MesasActivasPB:
                            return BBDD.Mesa.Where(Identificador => Identificador.ID_EstadoMesa != (int)ClsEstadosMesas.EEstadosMesas.Inactivo
&& Identificador.Numero <= 99).ToList();

                        case ETipoDeListado.MesasActivasPA:
                            return BBDD.Mesa.Where(Identificador => Identificador.ID_EstadoMesa != (int)ClsEstadosMesas.EEstadosMesas.Inactivo
&& Identificador.Numero >= 100).ToList();

                        case ETipoDeListado.MesasDisponiblesPB:
                            return BBDD.Mesa.Where(Identificador => Identificador.ID_EstadoMesa == (int)ClsEstadosMesas.EEstadosMesas.Activo_Disponible
&& Identificador.Numero <= 99).ToList();

                        case ETipoDeListado.MesasDisponiblesPA:
                            return BBDD.Mesa.Where(Identificador => Identificador.ID_EstadoMesa == (int)ClsEstadosMesas.EEstadosMesas.Activo_Disponible
&& Identificador.Numero >= 100).ToList();

                        case ETipoDeListado.MesasOcupadas: return BBDD.Mesa.Include("Usuario").Where(Identificador => Identificador.ID_EstadoMesa == (int)ClsEstadosMesas.EEstadosMesas.Ocupada).ToList();

                        case ETipoDeListado.MesasAOcuparLiberar: return BBDD.Mesa.Where(Identificador => _ID_Mesas.Contains(Identificador.ID_Mesa)).ToList();

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
        /// <param name="_MesaBuscar">ID del registro que se desea traer su informacion (pasar como parametro -1
        /// si no se va a buscar por numero de mesa o ID.</param>
        /// <param name="_TipoDeFiltro">Busca una mesa en particular (La primer mesa inactiva de cada planta es para determinar
        ///  si se tiene que crear una mesa o cambiar el estado).</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public Mesa LeerPorNumero(int _MesaBuscar, ETipoDeListado _TipoDeFiltro, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeFiltro)
                    {
                        case ETipoDeListado.PorID: return BBDD.Mesa.SingleOrDefault(Identificador => Identificador.ID_Mesa == _MesaBuscar);
                        case ETipoDeListado.PorNumeroDeMesa: return BBDD.Mesa.SingleOrDefault(Identificador => Identificador.Numero == _MesaBuscar);
                        case ETipoDeListado.PrimerMesaInactivaPB:
                            return BBDD.Mesa.FirstOrDefault(Identificador => Identificador.ID_EstadoMesa == (int)ClsEstadosMesas.EEstadosMesas.Inactivo
&& Identificador.Numero <= 99);
                        case ETipoDeListado.PrimerMesaInactivaPA:
                            return BBDD.Mesa.FirstOrDefault(Identificador => Identificador.ID_EstadoMesa == (int)ClsEstadosMesas.EEstadosMesas.Inactivo
&& Identificador.Numero >= 100);
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
        /// Crea un nuevo registro a partir de los datos que contiene el objeto pasado por parametro.
        /// </summary>
        /// <param name="_Mesa">Objeto que contiene los datos del nuevo registro que se creará.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Crear(Mesa _Mesa, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    BBDD.Mesa.Add(_Mesa);
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
        /// <param name="_Mesa">Objeto que contiene los datos del registro al que se le van a actualizar los datos.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Actualizar(Mesa _Mesa, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Mesa ObjetoActualizado = BBDD.Mesa.SingleOrDefault(Identificador => Identificador.ID_Mesa == _Mesa.ID_Mesa);

                    if (ObjetoActualizado != null)
                    {
                        ObjetoActualizado.ID_Mesa = _Mesa.ID_Mesa;
                        ObjetoActualizado.Numero = _Mesa.Numero;
                        ObjetoActualizado.ID_EstadoMesa = _Mesa.ID_EstadoMesa;
                        ObjetoActualizado.Capacidad = _Mesa.Capacidad;
                        ObjetoActualizado.ID_Usuario = _Mesa.ID_Usuario;

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
        /// <param name="_ID_MesaEliminar">Registro que se eliminará.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Borrar(int _ID_MesaEliminar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Mesa ObjetoAEliminar = BBDD.Mesa.SingleOrDefault(Identificador => Identificador.ID_Mesa == _ID_MesaEliminar);

                    if (ObjetoAEliminar != null)
                    {
                        BBDD.Mesa.Remove(ObjetoAEliminar);
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
