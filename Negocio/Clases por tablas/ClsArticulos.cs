using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class ClsArticulos : Articulo
    {
        public enum ETipoListado
        {
            /// <summary>
            /// Trae de la BBDD los articulos que coincidan con el estado del articulo pasado como parametro. Necesita 
            /// como parametro el enum con el estado del articulo a buscar
            /// </summary>
            ArticulosActivosInactivos = 1,
            /// <summary>
            /// Trae de la BBDD los articulos que coincidan con los datos pasados por parametro. Necesita los parametros opcionales (si 
            /// no se usa alguno, pasar su valor por defecto)
            /// </summary>
            Filtro,
            /// <summary>
            /// Trae de la BBDD todos los articulos que coincidan con el NOMBRE del parametro pasado, ignorando el que tiene el 
            /// ID tambien pasado por parametro (si es un articulo que se esta editando). Necesita el ID del articulo y el NOMBRE
            /// </summary>
            AritulosRepetidos
        }

        /// <summary>
        /// Busca todos los datos del registro en cuestion para ser mostrados.
        /// </summary>
        /// <param name="_TipoDeFiltro">Especifica el tipo de listado que se va a realizar.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        /// <param name="_EstadoArticuloBuscar">Parametro opcional que se establece si se va a aplicar el filtro sobre los articulos 
        /// activos o inactivos.</param>
        /// <param name="_TextoFilto">Parametro opcional que se establece para hacer un filtrado por nombre.</param>
        /// <param name="_CategoriaFiltro">Parametro opcional que se establece para hacer un filtrado por categoria.</param>
        /// <param name="_Nombre">Parametro opcional que se usa cuando se quiere verificar que el articulo no este en uso.</param>
        /// <param name="_ID_Articulo">Parametro opcional que se usa para ignorar el articulo que se esta editando cuando se quiere buscar 
        /// repetidos.</param>
        public List<Articulo> LeerListado(ETipoListado _TipoDeFiltro, ref string _InformacionDelError, ETipoListado _EstadoArticuloBuscar = ETipoListado.ArticulosActivosInactivos, string _TextoFilto = "", int _CategoriaFiltro = 0, string _Nombre = "", int _ID_Articulo = 0)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeFiltro)
                    {
                        case ETipoListado.ArticulosActivosInactivos:
                            return BBDD.Articulo.Include("CategoriaArticulo").Where(Identificador => Identificador.ID_EstadoArticulo == (int)_EstadoArticuloBuscar
                            && Identificador.CategoriaArticulo.ID_EstadoCategoriaArticulo == (int)_EstadoArticuloBuscar).OrderBy(Identificador => Identificador.CategoriaArticulo.Nombre).ThenBy(Identificador => Identificador.Nombre).ToList();
                        case ETipoListado.AritulosRepetidos:
                            _Nombre = _Nombre.ToLower();
                            return BBDD.Articulo.Include("CategoriaArticulo").Where(Identificador => Identificador.Nombre.ToLower() == _Nombre
                            && Identificador.ID_Articulo != _ID_Articulo).OrderBy(Identificador => Identificador.CategoriaArticulo.Nombre).ThenBy(Identificador => Identificador.Nombre).ToList();

                        case ETipoListado.Filtro:
                            {
                                List<Func<Articulo, bool>> Predicado = new List<Func<Articulo, bool>>();
                                List<Articulo> ListaFiltrada = null;

                                // En este caso armo un predicado por defecto (o todos los articulos activos o todos los inactivos)
                                if ((int)_EstadoArticuloBuscar == (int)ETipoListado.ArticulosActivosInactivos)
                                {
                                    ListaFiltrada = BBDD.Articulo.Include("CategoriaArticulo").Where(Identificador => Identificador.ID_EstadoArticulo == (int)_EstadoArticuloBuscar
                                    && Identificador.CategoriaArticulo.ID_EstadoCategoriaArticulo == (int)_EstadoArticuloBuscar).ToList();
                                }
                                else
                                {
                                    ListaFiltrada = BBDD.Articulo.Include("CategoriaArticulo").Where(Identificador => Identificador.ID_EstadoArticulo == (int)_EstadoArticuloBuscar
                                    || Identificador.CategoriaArticulo.ID_EstadoCategoriaArticulo == (int)_EstadoArticuloBuscar).ToList();
                                }

                                // Agregar predicado de filtro por texto si hay
                                if (_TextoFilto != string.Empty)
                                {
                                    _TextoFilto = _TextoFilto.ToLower(); // Transformo el texto a filtrar 1 sola vez
                                    Predicado.Add(Identificador => Identificador.Nombre.ToLower().Contains(_TextoFilto));
                                }

                                // Agregar predicado de filtro por categoria si hay
                                if (_CategoriaFiltro > 0)
                                {
                                    Predicado.Add(Identificador => Identificador.CategoriaArticulo.ID_CategoriaArticulo == _CategoriaFiltro);
                                }

                                foreach (Func<Articulo, bool> Elemento in Predicado)
                                {
                                    ListaFiltrada = ListaFiltrada.Where(Elemento).ToList();
                                }

                                // Retornar la lista
                                return ListaFiltrada.OrderBy(Identificador => Identificador.CategoriaArticulo.Nombre).ThenBy(Identificador => Identificador.Nombre).ToList();
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
        /// <param name="_ID_ArticuloBuscar">ID del registro que se desea traer su informacion.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public Articulo LeerPorNumero(int _ID_ArticuloBuscar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    return BBDD.Articulo.Include("CategoriaArticulo").SingleOrDefault(Identificador => Identificador.ID_Articulo == _ID_ArticuloBuscar);
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
        /// <param name="_Articulo">Objeto que contiene los datos del nuevo registro que se creará.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Crear(Articulo _Articulo, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    BBDD.Articulo.Add(_Articulo);
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
        /// <param name="_Articulo">Objeto que contiene los datos del registro al que se le van a actualizar los datos.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Actualizar(Articulo _Articulo, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Articulo ObjetoActualizado = BBDD.Articulo.SingleOrDefault(Identificador => Identificador.ID_Articulo == _Articulo.ID_Articulo);

                    if (ObjetoActualizado != null)
                    {
                        ObjetoActualizado.ID_Articulo = _Articulo.ID_Articulo;
                        ObjetoActualizado.Nombre = _Articulo.Nombre;
                        ObjetoActualizado.Descripcion = _Articulo.Descripcion;
                        ObjetoActualizado.Precio = _Articulo.Precio;
                        ObjetoActualizado.ID_EstadoArticulo = _Articulo.ID_EstadoArticulo;
                        ObjetoActualizado.ID_CategoriaArticulo = _Articulo.ID_CategoriaArticulo;
                        ObjetoActualizado.PrecioDelivery = _Articulo.PrecioDelivery;

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
        /// <param name="_ID_ArticuloEliminar">Registro que se eliminará.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Borrar(int _ID_ArticuloEliminar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Articulo ObjetoAEliminar = BBDD.Articulo.SingleOrDefault(Identificador => Identificador.ID_Articulo == _ID_ArticuloEliminar);

                    if (ObjetoAEliminar != null)
                    {
                        BBDD.Articulo.Remove(ObjetoAEliminar);
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
