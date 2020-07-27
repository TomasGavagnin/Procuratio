using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ClsPedidosXMesas : PedidoXMesa
    {
        public enum ETipoDeListado
        {
            EliminarPorID, CargarPorID, BuscarMesasYMozo
        }

        /// <summary>
        /// Busca todos los datos del registro en cuestion para ser mostrados.
        /// </summary>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public List<PedidoXMesa> LeerListado(ETipoDeListado _TipoDeListado, ref string _InformacionDelError, int _PedidoBuscar = 0)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeListado)
                    {
                        case ETipoDeListado.EliminarPorID: return BBDD.PedidoXMesa.Where(Identificador => Identificador.ID_Pedido == _PedidoBuscar).ToList();

                        case ETipoDeListado.CargarPorID: return BBDD.PedidoXMesa.Include("Mesa.Usuario").Include("Pedido").Where(Identificador => Identificador.Pedido.ID_EstadoPedido != (int)ClsEstadosPedidos.EEstadosPedidos.Eliminado
                        && Identificador.Pedido.ID_EstadoPedido != (int)ClsEstadosPedidos.EEstadosPedidos.Finalizado).ToList();

                        case ETipoDeListado.BuscarMesasYMozo:
                            return BBDD.PedidoXMesa.Include("Mesa.Usuario").Include("Pedido").Where(Identificador => Identificador.ID_Pedido == _PedidoBuscar).ToList();

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
        public PedidoXMesa LeerPorNumero(int _ID_PedidoBuscar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    return BBDD.PedidoXMesa.Include("Mesa.Usuario").Include("Pedido").First(Identificador => Identificador.ID_Pedido == _ID_PedidoBuscar);
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
        /// <param name="_PedidoXMesa">Objeto que contiene los datos del nuevo registro que se creará.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Crear(PedidoXMesa _PedidoXMesa, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    BBDD.PedidoXMesa.Add(_PedidoXMesa);
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
        /// <param name="_PedidoXMesa">Objeto que contiene los datos del registro al que se le van a actualizar los datos.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Actualizar(PedidoXMesa _PedidoXMesa, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    PedidoXMesa ObjetoActualizado = BBDD.PedidoXMesa.SingleOrDefault(Identificador => Identificador.ID_PedidoXMesa == _PedidoXMesa.ID_PedidoXMesa);

                    if (ObjetoActualizado != null)
                    {
                        ObjetoActualizado.ID_PedidoXMesa = _PedidoXMesa.ID_PedidoXMesa;
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
        /// <param name="_ID_PedidoXMesaEliminar">Registro que se eliminará.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Borrar(int _ID_PedidoXMesaEliminar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    PedidoXMesa ObjetoAEliminar = BBDD.PedidoXMesa.SingleOrDefault(Identificador => Identificador.ID_PedidoXMesa == _ID_PedidoXMesaEliminar);

                    if (ObjetoAEliminar != null)
                    {
                        BBDD.PedidoXMesa.Remove(ObjetoAEliminar);
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
