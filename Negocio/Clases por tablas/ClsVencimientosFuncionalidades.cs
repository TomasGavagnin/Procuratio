using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio.Clases_por_tablas
{
    public class ClsVencimientosFuncionalidades : VencimientoFuncionalidades
    {
        /// <summary>
        /// Busca todos los datos del registro en cuestion para ser mostrados.
        /// </summary>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public List<VencimientoFuncionalidades> LeerListado(ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    return BBDD.VencimientoFuncionalidades.ToList();
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
        /// <param name="_ID_VencimientoFuncionalidades">ID del registro que se desea traer su informacion.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public VencimientoFuncionalidades LeerPorNumero(int _ID_VencimientoFuncionalidades, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    return BBDD.VencimientoFuncionalidades.SingleOrDefault(Identificador => Identificador.ID_VencimientoFuncionalidades == _ID_VencimientoFuncionalidades);
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
        /// <param name="_VencimientoFuncionalidades">Objeto que contiene los datos del nuevo registro que se creará.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Crear(VencimientoFuncionalidades _VencimientoFuncionalidades, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    BBDD.VencimientoFuncionalidades.Add(_VencimientoFuncionalidades);
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
        /// <param name="_VencimientoFuncionalidades">Objeto que contiene los datos del registro al que se le van a actualizar los datos.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Actualizar(VencimientoFuncionalidades _VencimientoFuncionalidades, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    VencimientoFuncionalidades ObjetoActualizado = BBDD.VencimientoFuncionalidades.SingleOrDefault(Identificador => Identificador.ID_VencimientoFuncionalidades == _VencimientoFuncionalidades.ID_VencimientoFuncionalidades);

                    if (ObjetoActualizado != null)
                    {
                        ObjetoActualizado.ID_VencimientoFuncionalidades = _VencimientoFuncionalidades.ID_VencimientoFuncionalidades;
                        ObjetoActualizado.VencimientoGeneral = _VencimientoFuncionalidades.VencimientoGeneral;
                        ObjetoActualizado.VencimientoFunciones = _VencimientoFuncionalidades.VencimientoFunciones;

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
        /// <param name="_ID_VencimientoFuncionalidades">Registro que se eliminará.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Borrar(int _ID_VencimientoFuncionalidades, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    VencimientoFuncionalidades ObjetoAEliminar = BBDD.VencimientoFuncionalidades.SingleOrDefault(Identificador => Identificador.ID_VencimientoFuncionalidades == _ID_VencimientoFuncionalidades);

                    if (ObjetoAEliminar != null)
                    {
                        BBDD.VencimientoFuncionalidades.Remove(ObjetoAEliminar);
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

