using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class ClsCategoriasArticulos : CategoriaArticulo
    {
        public enum ETipoListado
        {
            Todo, CategoriasActivas, CategoriasInactivas, CategoriasRepetidas
        }

        public enum ECategoriaBuscar
        {
            PorID, UltimaAgregada
        }

        public enum EParaCocina
        {
            No, Si
        }

        /// <summary>
        /// Busca todos los datos del registro en cuestion para ser mostrados.
        /// </summary>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        /// <param name="_Nombre">Parametro opcional que se usa cuando se quiere verificar que la categoria no este en uso.</param>
        /// <param name="_TipoDeFiltro">Especifica la regla de filtrado segun el parametro pasado.</param>
        /// <param name="_ID_Categoria">Variable que se utiliza para ignorar la misma categoria que se esta editando.</param>
        public List<CategoriaArticulo> LeerListado(ETipoListado _TipoDeFiltro, ref string _InformacionDelError, string _Nombre = "", int _ID_Categoria = 0)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeFiltro)
                    {
                        case ETipoListado.Todo: return BBDD.CategoriaArticulo.OrderBy(Identificador => Identificador.Nombre).ToList();

                        case ETipoListado.CategoriasActivas: return BBDD.CategoriaArticulo.Where(Identificador => Identificador.ID_EstadoCategoriaArticulo == (int)ClsEstadosCategoriasArticulos.EEstadosCategoriasArticulos.Activo).OrderBy(Identificador => Identificador.Nombre).ToList();

                        case ETipoListado.CategoriasInactivas: return BBDD.CategoriaArticulo.Where(Identificador => Identificador.ID_EstadoCategoriaArticulo == (int)ClsEstadosCategoriasArticulos.EEstadosCategoriasArticulos.inactivo).OrderBy(Identificador => Identificador.Nombre).ToList();

                        case ETipoListado.CategoriasRepetidas:
                            _Nombre = _Nombre.ToLower();

                            return BBDD.CategoriaArticulo.Where(Identificador => Identificador.Nombre.ToLower() == _Nombre
                            && Identificador.ID_CategoriaArticulo != _ID_Categoria).OrderBy(Identificador => Identificador.Nombre).ToList();

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
        /// <param name="_ID_CategoriaArticuloBuscar">ID del registro que se desea traer su informacion.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public CategoriaArticulo LeerPorNumero(int _ID_CategoriaArticuloBuscar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    return BBDD.CategoriaArticulo.SingleOrDefault(Identificador => Identificador.ID_CategoriaArticulo == _ID_CategoriaArticuloBuscar);
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
        /// <param name="_CategoriaArticulo">Objeto que contiene los datos del nuevo registro que se creará.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Crear(CategoriaArticulo _CategoriaArticulo, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    BBDD.CategoriaArticulo.Add(_CategoriaArticulo);
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
        /// <param name="_CategoriaArticulo">Objeto que contiene los datos del registro al que se le van a actualizar los datos.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Actualizar(CategoriaArticulo _CategoriaArticulo, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    CategoriaArticulo ObjetoActualizado = BBDD.CategoriaArticulo.SingleOrDefault(Identificador => Identificador.ID_CategoriaArticulo == _CategoriaArticulo.ID_CategoriaArticulo);

                    if (ObjetoActualizado != null)
                    {
                        ObjetoActualizado.ID_CategoriaArticulo = _CategoriaArticulo.ID_CategoriaArticulo;
                        ObjetoActualizado.Nombre = _CategoriaArticulo.Nombre;
                        ObjetoActualizado.ID_EstadoCategoriaArticulo = _CategoriaArticulo.ID_EstadoCategoriaArticulo;
                        ObjetoActualizado.ParaCocina = _CategoriaArticulo.ParaCocina;

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
        /// <param name="_ID_CategoriaArticuloEliminar">Registro que se eliminará.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Borrar(int _ID_CategoriaArticuloEliminar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    CategoriaArticulo ObjetoAEliminar = BBDD.CategoriaArticulo.SingleOrDefault(Identificador => Identificador.ID_CategoriaArticulo == _ID_CategoriaArticuloEliminar);

                    if (ObjetoAEliminar != null)
                    {
                        BBDD.CategoriaArticulo.Remove(ObjetoAEliminar);
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
