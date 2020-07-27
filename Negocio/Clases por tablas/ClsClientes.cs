using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ClsClientes : Cliente
    {
        public enum EClienteBuscar
        {
            PorID, UltimoAgregado, Todos, DatosRepetidos, Filtro
        }

        /// <summary>
        /// Busca todos los datos del registro en cuestion para ser mostrados.
        /// </summary>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        /// <param name="_TipoDeFiltro">Trae los registros segun el filtro especificado.</param>
        /// <param name="_NombreCliente">Filtra la lista de clientes segun el texto pasado por parametro.</param>
        public List<Cliente> LeerListado(EClienteBuscar _TipoDeFiltro, ref string _InformacionDelError, string _NombreCliente = "", string _ApellidoCliente = "", string _TelefonoCliente = "", int _ID_Cliente = 0)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeFiltro)
                    {
                        case EClienteBuscar.Todos: return BBDD.Cliente.Where(Identificador => Identificador.ID_Cliente != 1).OrderBy(Identificador => Identificador.Nombre)
                                .ThenBy(Identificador => Identificador.Apellido).ToList();

                        case EClienteBuscar.Filtro:
                            {
                                _NombreCliente = _NombreCliente.ToLower();
                                _ApellidoCliente = _ApellidoCliente.ToLower();

                                List<Func<Cliente, bool>> Predicado = new List<Func<Cliente, bool>>();
                                List<Cliente> ListaFiltrada = BBDD.Cliente.Where(Identificador => Identificador.ID_Cliente != 1).ToList();

                                if (_NombreCliente != string.Empty)
                                {
                                    Predicado.Add(Identificador => Identificador.Nombre.ToLower().StartsWith(_NombreCliente));
                                }

                                if (_ApellidoCliente != string.Empty)
                                {
                                    Predicado.Add(Identificador => Identificador.Apellido.ToLower().StartsWith(_ApellidoCliente));
                                }

                                if (_TelefonoCliente != string.Empty)
                                {
                                    Predicado.Add(Identificador => Identificador.Telefono.ToString().Contains(_TelefonoCliente));
                                }

                                foreach (Func<Cliente, bool> Elemento in Predicado)
                                {
                                    ListaFiltrada = ListaFiltrada.Where(Elemento).ToList();
                                }

                                return ListaFiltrada.OrderBy(Identificador => Identificador.Nombre).ThenBy(Identificador => Identificador.Apellido).ToList();
                            }
                        case EClienteBuscar.DatosRepetidos:
                            {
                                _NombreCliente = _NombreCliente.ToLower();
                                _ApellidoCliente = _ApellidoCliente.ToLower();

                                return BBDD.Cliente.Where(Identificador => Identificador.Nombre.ToLower() == _NombreCliente 
                                && Identificador.Apellido.ToLower() == _ApellidoCliente
                                && Identificador.ID_Cliente != _ID_Cliente
                                && Identificador.ID_Cliente != 1).ToList();
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
        /// <param name="_ID_ClienteBuscar">ID del registro que se desea traer su informacion (pasar como parametro -1 si se 
        /// va a buscar usando un filtro diferente al de PorID).</param>
        /// <param name="_TipoDeRegistro">El registro que se buscara para devolver.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public Cliente LeerPorNumero(int _ID_ClienteBuscar, EClienteBuscar _TipoDeRegistro, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeRegistro)
                    {
                        case EClienteBuscar.PorID: return BBDD.Cliente.SingleOrDefault(Identificador => Identificador.ID_Cliente == _ID_ClienteBuscar);
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
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Crear(Cliente _Cliente, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    BBDD.Cliente.Add(_Cliente);
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
        /// <param name="_Cliente">Objeto que contiene los datos del registro al que se le van a actualizar los datos.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Actualizar(Cliente _Cliente, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Cliente ObjetoActualizado = BBDD.Cliente.SingleOrDefault(Identificador => Identificador.ID_Cliente == _Cliente.ID_Cliente);

                    if (ObjetoActualizado != null)
                    {
                        ObjetoActualizado.ID_Cliente = _Cliente.ID_Cliente;
                        ObjetoActualizado.Nombre = _Cliente.Nombre;
                        ObjetoActualizado.Apellido = _Cliente.Apellido;
                        ObjetoActualizado.Telefono = _Cliente.Telefono;
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
        /// <param name="_ID_ClienteEliminar">Registro que se eliminará.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Borrar(int _ID_ClienteEliminar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Cliente ObjetoAEliminar = BBDD.Cliente.SingleOrDefault(Identificador => Identificador.ID_Cliente == _ID_ClienteEliminar);

                    if (ObjetoAEliminar != null)
                    {
                        BBDD.Cliente.Remove(ObjetoAEliminar);
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
