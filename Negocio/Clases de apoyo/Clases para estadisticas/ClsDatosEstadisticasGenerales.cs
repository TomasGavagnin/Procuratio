using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Negocio.Clases_de_apoyo
{
    public class ClsDatosEstadisticasGenerales
    {
        public DataTable VentasPorMozoPorMes(int _Año, ref string _InformacionDelError)
        {
            SqlConnection Conexion = null;

            try
            {
                //Leo la Cadena de Conexión
                string CadenaDeConexion = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

                // Tabla que almacenara los resultados
                DataTable TablaDeDatos = new DataTable();

                TablaDeDatos.Columns.Add("Nombre", typeof(string));
                TablaDeDatos.Columns.Add("Apellido", typeof(string));
                TablaDeDatos.Columns.Add("Mes", typeof(int));
                TablaDeDatos.Columns.Add("Total", typeof(int));

                // Conecto con la base de datos
                Conexion = new SqlConnection(CadenaDeConexion);

                SqlDataAdapter EjecutarConculta = new SqlDataAdapter("SP_VentasPorMozoPorMes", Conexion);

                Conexion.Open();

                EjecutarConculta.SelectCommand.CommandType = CommandType.StoredProcedure;
                EjecutarConculta.SelectCommand.Parameters.Add("@_Año", SqlDbType.Int).Value = _Año;

                EjecutarConculta.Fill(TablaDeDatos);

                foreach (DataRow Elemento in TablaDeDatos.Rows)
                {
                    Elemento[0] = $"{Elemento[0]} {Elemento[1]}";
                }

                TablaDeDatos.Columns.RemoveAt(1);

                Conexion.Close();

                return TablaDeDatos;
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
            finally
            {
                if (Conexion != null) { Conexion.Close(); }
            }
        }
    }
}
