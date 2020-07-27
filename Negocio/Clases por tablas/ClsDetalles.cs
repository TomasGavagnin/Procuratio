using Datos;
using Negocio.Clases_por_tablas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class ClsDetalles : Detalle
    {
        public enum ETipoDeBusqueda
        {
            PorIDPedido, PorPedidoYArticulo
        }

        public enum ETipoDeListado
        {
            PorIDPedido, ParaCocina, CategoriaEnUso, NoEntregados
        }

        /// <summary>
        /// Busca todos los datos del registro en cuestion para ser mostrados.
        /// </summary>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        /// <param name="_ID_CategoriaQueSeEditara">Busca si se esta usando la categoria que se editara.</param>
        public List<Detalle> LeerListado(int _ID_Pedido, ETipoDeListado _TipoDeFiltro, ref string _InformacionDelError, int _ID_CategoriaQueSeEditara = 0)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeFiltro)
                    {
                        case ETipoDeListado.PorIDPedido:
                            return BBDD.Detalle.Include("Articulo.CategoriaArticulo").Include("Pedido").Where(Identificador => Identificador.ID_Pedido == _ID_Pedido)
                            .OrderBy(Identificador => Identificador.Articulo.CategoriaArticulo.Nombre)
                            .ThenBy(Identificador => Identificador.Articulo.Nombre).ToList();

                        case ETipoDeListado.ParaCocina:
                            return BBDD.Detalle.Include("Articulo.CategoriaArticulo").Include("Pedido").Where(Identificador => Identificador.ID_Pedido == _ID_Pedido
&& (Identificador.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.NoCocinado || Identificador.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.CantidadAumentada)).ToList();

                        case ETipoDeListado.CategoriaEnUso:
                            return BBDD.Detalle.Include("Articulo.CategoriaArticulo").Include("Pedido").Where(Identificador => Identificador.Articulo.ID_CategoriaArticulo == _ID_CategoriaQueSeEditara
                            && Identificador.Pedido.ID_EstadoPedido != (int)ClsEstadosPedidos.EEstadosPedidos.Eliminado
                            && Identificador.Pedido.ID_EstadoPedido != (int)ClsEstadosPedidos.EEstadosPedidos.Finalizado).ToList();

                        case ETipoDeListado.NoEntregados:
                            return BBDD.Detalle.Include("Articulo.CategoriaArticulo").Include("Pedido").Where(Identificador => Identificador.ID_Pedido == _ID_Pedido
                            && Identificador.ID_ArticuloEntregado == (int)ClsArticulosEntregados.EArticuloEntregado.NoEntregado
                            && Identificador.Articulo.CategoriaArticulo.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.Si)
                            .OrderBy(Identificador => Identificador.Articulo.CategoriaArticulo.Nombre)
                            .ThenBy(Identificador => Identificador.Articulo.Nombre).ToList();

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
        /// <param name="_ID_Pedido">ID del registro que se desea traer su informacion.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public Detalle LeerPorNumero(int _ID_Pedido, ETipoDeBusqueda _TipoDeBusqueda, ref string _InformacionDelError, int _ID_Articulo = 0)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    // busca por el id del pedido
                    switch (_TipoDeBusqueda)
                    {
                        case ETipoDeBusqueda.PorIDPedido: return BBDD.Detalle.Include("Articulo.CategoriaArticulo").Include("Pedido").SingleOrDefault(Identificador => Identificador.ID_Pedido == _ID_Pedido);
                        case ETipoDeBusqueda.PorPedidoYArticulo:
                            return BBDD.Detalle.Include("Articulo.CategoriaArticulo").Include("Pedido").SingleOrDefault(Identificador => Identificador.ID_Pedido == _ID_Pedido
&& Identificador.ID_Articulo == _ID_Articulo);
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
        /// <param name="_Detalle">Objeto que contiene los datos del nuevo registro que se creará.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Crear(Detalle _Detalle, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    BBDD.Detalle.Add(_Detalle);
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
        /// <param name="_Detalle">Objeto que contiene los datos del registro al que se le van a actualizar los datos.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Actualizar(Detalle _Detalle, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Detalle ObjetoActualizado = BBDD.Detalle.SingleOrDefault(Identificador => Identificador.ID_Detalle == _Detalle.ID_Detalle);

                    if (ObjetoActualizado != null)
                    {
                        ObjetoActualizado.ID_Detalle = _Detalle.ID_Detalle;
                        ObjetoActualizado.ID_Pedido = _Detalle.ID_Pedido;
                        ObjetoActualizado.ID_Articulo = _Detalle.ID_Articulo;
                        ObjetoActualizado.ID_Chef = _Detalle.ID_Chef;
                        ObjetoActualizado.Cantidad = _Detalle.Cantidad;
                        ObjetoActualizado.Nota = _Detalle.Nota;
                        ObjetoActualizado.Precio = _Detalle.Precio;
                        ObjetoActualizado.ID_EstadoDetalle = _Detalle.ID_EstadoDetalle;
                        ObjetoActualizado.CantidadAgregada = _Detalle.CantidadAgregada;
                        ObjetoActualizado.ID_ArticuloEntregado = _Detalle.ID_ArticuloEntregado;

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
        /// <param name="_ID_DetalleEliminar">Registro que se eliminará.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Borrar(int _ID_DetalleEliminar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Detalle ObjetoAEliminar = BBDD.Detalle.SingleOrDefault(Identificador => Identificador.ID_Detalle == _ID_DetalleEliminar);

                    if (ObjetoAEliminar != null)
                    {
                        BBDD.Detalle.Remove(ObjetoAEliminar);
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
