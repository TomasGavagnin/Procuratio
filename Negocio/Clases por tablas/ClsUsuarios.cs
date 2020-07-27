using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ClsUsuarios : Usuario
    {
        public enum ETipoListado
        {
            UsuariosActivos, UsuariosInactivos, UsuariosGerentes, UsuariosGerYSubGer,
            UsuariosParaMesas, UsuariosChef, ChefGerenteSubgerente, DatosRepetidos, GerenteSubGerenteMozoDueño, Desarrollador,
            TodosLosUsuarios
        }

        public enum EUsuarioABuscar
        {
            PorID, UltimoAgregardo, InicioSesion
        }

        public enum ERespuestaDelInicio
        {
            DatosCorrectos, UsuarioYContraseñaIncorrecta, UsuarioIncorrecto, ClaveIncorrecta, DadoDeBaja
        }

        /// <summary>
        /// Busca todos los datos del registro en cuestion para ser mostrados.
        /// </summary>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        /// <param name="_TipoDeFiltro">Filtra la lista segun la enumeracion proporcionada.</param>
        /// <param name="_Nombre">Parametro opcional para detrminar si ya hay un nombre en uso al editar o crear un usuario.</param>
        /// <param name="_Contraseña">Parametro opcional para detrminar si ya hay una contraseña en uso al editar o crear un usuario</param>
        /// <param name="_ID_UsuarioActual">Parametro opcional que se usa para ignorar el usuario que se esta editando cuando se quiere buscar 
        /// repetidos.</param>
        public List<Usuario> LeerListado(ETipoListado _TipoDeFiltro, ref string _InformacionDelError, string _Nombre = "", string _Contraseña = "", int _ID_UsuarioActual = 0, string _Apellido = "")
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeFiltro)
                    {
                        case ETipoListado.UsuariosActivos: return BBDD.Usuario.Include("Perfil").Where(Identificador => Identificador.ID_EstadoUsuario == (int)ClsEstadosUsuarios.EEstadosUsuarios.Activo
                        && Identificador.ID_Perfil != (int)ClsPerfiles.EPerfiles.Administrador).ToList();

                        case ETipoListado.UsuariosInactivos: return BBDD.Usuario.Include("Perfil").Where(Identificador => Identificador.ID_EstadoUsuario == (int)ClsEstadosUsuarios.EEstadosUsuarios.Inactivo
                        && Identificador.ID_Perfil != (int)ClsPerfiles.EPerfiles.Administrador).ToList();

                        case ETipoListado.UsuariosGerYSubGer: return BBDD.Usuario.Where(Identificador => Identificador.ID_Perfil == (int)ClsPerfiles.EPerfiles.Gerente 
                        || Identificador.ID_Perfil == (int)ClsPerfiles.EPerfiles.SubGerente
                        || Identificador.ID_Perfil == (int)ClsPerfiles.EPerfiles.Administrador
                        && Identificador.ID_EstadoUsuario == (int)ClsEstadosUsuarios.EEstadosUsuarios.Activo).ToList();

                        case ETipoListado.UsuariosGerentes: return BBDD.Usuario.Where(Identificador => Identificador.ID_Perfil == (int)ClsPerfiles.EPerfiles.Gerente
                        || Identificador.ID_Perfil == (int)ClsPerfiles.EPerfiles.Administrador
                        && Identificador.ID_EstadoUsuario == (int)ClsEstadosUsuarios.EEstadosUsuarios.Activo).ToList();

                        case ETipoListado.UsuariosParaMesas: return BBDD.Usuario.Where(Identificador => Identificador.ID_Perfil != (int)ClsPerfiles.EPerfiles.Chef 
                        && Identificador.ID_EstadoUsuario == (int)ClsEstadosUsuarios.EEstadosUsuarios.Activo
                        && Identificador.ID_Usuario != 1).ToList();

                        case ETipoListado.UsuariosChef: return BBDD.Usuario.Include("Perfil").Where(Identificador => Identificador.ID_Perfil == (int)ClsPerfiles.EPerfiles.Chef
                        && Identificador.ID_EstadoUsuario == (int)ClsEstadosUsuarios.EEstadosUsuarios.Activo).ToList();

                        case ETipoListado.ChefGerenteSubgerente:  return BBDD.Usuario.Include("Perfil").Where(Identificador => Identificador.ID_Perfil == (int)ClsPerfiles.EPerfiles.Chef
                        || Identificador.ID_Perfil == (int)ClsPerfiles.EPerfiles.Gerente 
                        || Identificador.ID_Perfil == (int)ClsPerfiles.EPerfiles.SubGerente
                        || Identificador.ID_Perfil == (int)ClsPerfiles.EPerfiles.Administrador
                        && Identificador.ID_EstadoUsuario == (int)ClsEstadosUsuarios.EEstadosUsuarios.Activo).ToList();

                        case ETipoListado.GerenteSubGerenteMozoDueño: return BBDD.Usuario.Include("Perfil").Where(Identificador => Identificador.ID_Usuario == _ID_UsuarioActual
                        || Identificador.ID_Perfil == (int)ClsPerfiles.EPerfiles.Gerente
                        || Identificador.ID_Perfil == (int)ClsPerfiles.EPerfiles.SubGerente
                        || Identificador.ID_Perfil == (int)ClsPerfiles.EPerfiles.Administrador
                        && Identificador.ID_EstadoUsuario == (int)ClsEstadosUsuarios.EEstadosUsuarios.Activo).ToList();

                        case ETipoListado.Desarrollador: return BBDD.Usuario.Include("Perfil").Where(Identificador => Identificador.ID_Perfil == (int)ClsPerfiles.EPerfiles.Administrador
                        && Identificador.ID_EstadoUsuario == (int)ClsEstadosUsuarios.EEstadosUsuarios.Activo).ToList();

                        case ETipoListado.DatosRepetidos:
                        _Nombre = _Nombre.ToLower();
                        _Apellido = _Apellido.ToLower();
                        _Contraseña = _Contraseña.ToLower();

                        return BBDD.Usuario.Include("Perfil").Where(Identificador => ((Identificador.Nombre.ToLower() == _Nombre 
                        && Identificador.Apellido.ToLower() == _Apellido)
                        || Identificador.Contraseña.ToLower() == _Contraseña) 
                        && Identificador.ID_Usuario != _ID_UsuarioActual).ToList();

                        case ETipoListado.TodosLosUsuarios: return BBDD.Usuario.Include("Perfil").Where(Identificador => Identificador.ID_EstadoUsuario == (int)ClsEstadosUsuarios.EEstadosUsuarios.Activo 
                        && Identificador.ID_Perfil != (int)ClsPerfiles.EPerfiles.Administrador).ToList();

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
        /// <param name="_ID_UsuarioBuscar">ID del registro que se desea traer su informacion.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        ///<param name="_TipoDeFiltro">Indica cual es el usuario que se desea encontrar.</param>
        ///<param name="_Nombre">Parametro que se utiliza para validar usuario junto con el parametro contraseña.</param>
        ///<param name="_Contraseña">Parametro que se utiliza para validar usuario junto con el parametro nombre.</param>
        public Usuario LeerPorNumero(int _ID_UsuarioBuscar, EUsuarioABuscar _TipoDeFiltro, ref string _InformacionDelError, string _Nombre = "", string _Contraseña = "")
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    switch (_TipoDeFiltro)
                    {
                        case EUsuarioABuscar.PorID: return BBDD.Usuario.Include("Perfil").SingleOrDefault(Identificador => Identificador.ID_Usuario == _ID_UsuarioBuscar);

                        case EUsuarioABuscar.UltimoAgregardo: return BBDD.Usuario.Include("Perfil").OrderByDescending(Identificador => Identificador.ID_Usuario).First();

                        case EUsuarioABuscar.InicioSesion:
                            {
                                _Nombre = _Nombre.ToLower();

                                return BBDD.Usuario.Include("Perfil").SingleOrDefault(Identificador => Identificador.Nombre.ToLower() == _Nombre 
                                && Identificador.Contraseña == _Contraseña);
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

        ///<param name="_Nombre">Parametro que se utiliza para validar usuario junto con el parametro contraseña.</param>
        ///<param name="_Contraseña">Parametro que se utiliza para validar usuario junto con el parametro nombre.</param>
        public Usuario LeerParaInicioSesion(string _Nombre, string _Contraseña, ref ERespuestaDelInicio _RespuestaDeInicio, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    _Nombre = _Nombre.ToLower();

                    Usuario CoincidenciaEncontrada = BBDD.Usuario.Include("Perfil").FirstOrDefault(Identificador => Identificador.Nombre.ToLower() == _Nombre
                    || Identificador.Contraseña == _Contraseña);

                    if (CoincidenciaEncontrada != null)
                    {
                        if (CoincidenciaEncontrada.ID_EstadoUsuario == (int)ClsEstadosUsuarios.EEstadosUsuarios.Inactivo)
                        {
                            _RespuestaDeInicio = ERespuestaDelInicio.DadoDeBaja;
                        }
                        else if (CoincidenciaEncontrada.Nombre.ToLower() == _Nombre && CoincidenciaEncontrada.Contraseña != _Contraseña)
                        {
                            _RespuestaDeInicio = ERespuestaDelInicio.ClaveIncorrecta;
                        }
                        else if (CoincidenciaEncontrada.Nombre.ToLower() != _Nombre && CoincidenciaEncontrada.Contraseña == _Contraseña)
                        {
                            _RespuestaDeInicio = ERespuestaDelInicio.UsuarioIncorrecto;
                        }
                    }
                    else
                    {
                        _RespuestaDeInicio = ERespuestaDelInicio.UsuarioYContraseñaIncorrecta;
                    }

                    return BBDD.Usuario.Include("Perfil").SingleOrDefault(Identificador => Identificador.Nombre.ToLower() == _Nombre
                    && Identificador.Contraseña == _Contraseña);
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
        /// <param name="_Usuario">Objeto que contiene los datos del nuevo registro que se creará.</param>
        ///<param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Crear(Usuario _Usuario, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    BBDD.Usuario.Add(_Usuario);
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
        /// <param name="_Usuario">Objeto que contiene los datos del registro al que se le van a actualizar los datos.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Actualizar(Usuario _Usuario, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Usuario ObjetoActualizado = BBDD.Usuario.Include("Perfil").SingleOrDefault(Identificador => Identificador.ID_Usuario == _Usuario.ID_Usuario);

                    if (ObjetoActualizado != null)
                    {
                        ObjetoActualizado.ID_Usuario = _Usuario.ID_Usuario;
                        ObjetoActualizado.Nick = _Usuario.Nick;
                        ObjetoActualizado.Nombre = _Usuario.Nombre;
                        ObjetoActualizado.Apellido = _Usuario.Apellido;
                        ObjetoActualizado.Contraseña = _Usuario.Contraseña;
                        ObjetoActualizado.ID_Perfil = _Usuario.ID_Perfil;
                        ObjetoActualizado.ID_EstadoUsuario = _Usuario.ID_EstadoUsuario;

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
        /// <param name="_ID_UsuarioEliminar">Registro que se eliminará.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public int Borrar(int _ID_UsuarioEliminar, ref string _InformacionDelError)
        {
            using (BDRestauranteEntities BBDD = new BDRestauranteEntities())
            {
                try
                {
                    Usuario ObjetoAEliminar = BBDD.Usuario.SingleOrDefault(Identificador => Identificador.ID_Usuario == _ID_UsuarioEliminar);

                    if (ObjetoAEliminar != null)
                    {
                        BBDD.Usuario.Remove(ObjetoAEliminar);
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
