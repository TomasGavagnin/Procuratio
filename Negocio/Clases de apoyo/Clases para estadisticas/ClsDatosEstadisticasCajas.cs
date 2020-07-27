using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Negocio.Clases_por_tablas;

namespace Negocio.Clases_de_apoyo.Clases_para_estadisticas
{
    public class ClsDatosEstadisticasCajas
    {
        public DataTable GananciasPerdidasPorMes(int _Año, ref string _InformacionDelError)
        {
            SqlConnection Conexion = null;

            try
            {
                //Leo la Cadena de Conexión
                string CadenaDeConexion = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

                // Tabla que almacenara los resultados
                DataTable TablaDeDatosTemporal = new DataTable();
                DataTable TablaDeDatos = new DataTable();

                TablaDeDatosTemporal.Columns.Add("Monto", typeof(int));
                TablaDeDatosTemporal.Columns.Add("Mes", typeof(int));
                TablaDeDatosTemporal.Columns.Add("ID_TipoDeMovimiento", typeof(int));

                TablaDeDatos.Columns.Add("Monto", typeof(int));
                TablaDeDatos.Columns.Add("Mes", typeof(int));
                TablaDeDatos.Columns.Add("TipoDeMovimiento", typeof(string));

                // Conecto con la base de datos
                Conexion = new SqlConnection(CadenaDeConexion);

                SqlDataAdapter EjecutarConculta = new SqlDataAdapter("SP_GananciasYPerdidasPorMes", Conexion);

                Conexion.Open();

                EjecutarConculta.SelectCommand.CommandType = CommandType.StoredProcedure;
                EjecutarConculta.SelectCommand.Parameters.Add("@_Año", SqlDbType.Int).Value = _Año;

                EjecutarConculta.Fill(TablaDeDatosTemporal);

                foreach (DataRow Elemento in TablaDeDatosTemporal.Rows)
                {
                    if ((int)Elemento[2] == (int)ClsTiposDeMovimientos.ETipoDeMovimientos.Ingreso )
                    {
                        TablaDeDatos.Rows.Add(Elemento[0], Elemento[1], "Ingreso");
                    }
                    else
                    {
                        TablaDeDatos.Rows.Add(Elemento[0], Elemento[1], "Egreso");
                    }
                }

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
