using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Negocio
{
    public enum ERespuestaDelInicio
    {
        DatosCorrectos, UsuarioInexistente, ClaveIncorrecta, ErrorBaseDeDatos, DadoDeBaja
    }

    public enum ERespuestaBaseDeDatos
    {
        SinErrores, ArgumentException, SqlException, Exception
    }

    public class ClsInicioSesion
    {
        public static ERespuestaDelInicio ComparaDatos(string _Usuario, string _Contraseña, ref ERespuestaBaseDeDatos InformacionDeLaExcepcion)
        {
            try
            {
                //Leo la Cadena de Conexión directamente porque archivo app.config no reconoce la clase ConfigurationMagagement
                string CadenaDeConexion = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

                //Crear la Conexión a la Base de Datos
                SqlConnection SQLConnection = new SqlConnection(CadenaDeConexion);
                SQLConnection.Open();

                //Crear la sentencia SQL
                string Consulta = "SELECT Nombre,Clave FROM Usuario";

                //Creo un objeto de tipo comando en el que le paso como parametro la consulta y la conexion abierta a la BBDD
                SqlCommand Comando = new SqlCommand(Consulta, SQLConnection);

                //Creo un objeto lector de datos basado en mi objeto "Comando"
                SqlDataReader LectorDeDatos = Comando.ExecuteReader();

                //Recorro lo datos de mi tabla
                while (LectorDeDatos.Read())
                {
                    if (LectorDeDatos["Nombre"].ToString().ToLower() == _Usuario && LectorDeDatos["Clave"].ToString() == _Contraseña)
                    {
                        SQLConnection.Close();
                        return ERespuestaDelInicio.DatosCorrectos;
                    }

                    if (LectorDeDatos["Nombre"].ToString().ToLower() != _Usuario)
                    {
                        SQLConnection.Close();
                        return ERespuestaDelInicio.UsuarioInexistente;
                    }

                    if (LectorDeDatos["Clave"].ToString() != _Contraseña)
                    {
                        SQLConnection.Close();
                        return ERespuestaDelInicio.ClaveIncorrecta; 
                    }
                }
            }
            catch (ArgumentException)
            {
                InformacionDeLaExcepcion = ERespuestaBaseDeDatos.ArgumentException;
            }
            catch (SqlException)
            {
                InformacionDeLaExcepcion = ERespuestaBaseDeDatos.SqlException;
            }
            catch (Exception)
            {
                InformacionDeLaExcepcion = ERespuestaBaseDeDatos.Exception;
            }
            
            return ERespuestaDelInicio.ErrorBaseDeDatos; //Esto para cambiar el estado inicial de correcto a uno correcto
        }                                                
    }
}
