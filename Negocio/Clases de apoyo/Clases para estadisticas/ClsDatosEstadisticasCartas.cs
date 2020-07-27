using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Negocio.Clases_de_apoyo
{
    public class ClsDatosEstadisticasCartas
    {
        /// <summary>
        /// Llena un DateTable para luego ser usado para graficas estadisticas.
        /// </summary>
        /// <param name="_FechaDesde">Indica la fecha de inicio desde la que se tendran en cuenta los datos 
        /// (con una cadena vacia no se tendra en cuenta).</param>
        /// <param name="_FechaHasta">Indica la fecha de fin desde la que se tendran en cuenta los datos 
        /// (con una cadena vacia no se tendra en cuenta).</param>
        /// <param name="_InformacionDelError"></param>
        /// <returns></returns>
        public DataTable ArticulosMasVendidosCarta(string _FechaDesde, string _FechaHasta, ClsCategoriasArticulos.EParaCocina _ParaCocina, ref string _InformacionDelError)
        {
            SqlConnection Conexion = null;

            try
            {
                //Leo la Cadena de Conexión
                string CadenaDeConexion = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

                // Tabla que almacenara los resultados
                DataTable TablaDeDatos = new DataTable();

                // Conecto con la base de datos
                Conexion = new SqlConnection(CadenaDeConexion);

                SqlDataAdapter EjecutarConculta = new SqlDataAdapter("SP_ArticulosMasVendidosCarta", Conexion);

                Conexion.Open();

                EjecutarConculta.SelectCommand.CommandType = CommandType.StoredProcedure;
                EjecutarConculta.SelectCommand.Parameters.Add("@_FechaDesde", SqlDbType.VarChar).Value = _FechaDesde;
                EjecutarConculta.SelectCommand.Parameters.Add("@_FechaHasta", SqlDbType.VarChar).Value = _FechaHasta;
                EjecutarConculta.SelectCommand.Parameters.Add("@_ParaCocina", SqlDbType.Int).Value = (int)_ParaCocina;

                EjecutarConculta.Fill(TablaDeDatos);

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

        /// <summary>
        /// Llena un DateTable para luego ser usado para graficas estadisticas.
        /// </summary>
        /// <param name="_FechaDesde">Indica la fecha de inicio desde la que se tendran en cuenta los datos 
        /// (con una cadena vacia no se tendra en cuenta).</param>
        /// <param name="_FechaHasta">Indica la fecha de fin desde la que se tendran en cuenta los datos 
        /// (con una cadena vacia no se tendra en cuenta).</param>
        /// <param name="_InformacionDelError"></param>
        /// <returns></returns>
        public DataTable ArticulosMenosVendidosCarta(string _FechaDesde, string _FechaHasta, ClsCategoriasArticulos.EParaCocina _ParaCocina, ref string _InformacionDelError)
        {
            SqlConnection Conexion = null;

            try
            {
                //Leo la Cadena de Conexión
                string CadenaDeConexion = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

                // Tabla que almacenara los resultados
                DataTable TablaDeDatos = new DataTable();

                // Conecto con la base de datos
                Conexion = new SqlConnection(CadenaDeConexion);

                SqlDataAdapter EjecutarConculta = new SqlDataAdapter("SP_ArticulosMenosVendidosCarta", Conexion);

                Conexion.Open();

                EjecutarConculta.SelectCommand.CommandType = CommandType.StoredProcedure;
                EjecutarConculta.SelectCommand.Parameters.Add("@_FechaDesde", SqlDbType.VarChar).Value = _FechaDesde;
                EjecutarConculta.SelectCommand.Parameters.Add("@_FechaHasta", SqlDbType.VarChar).Value = _FechaHasta;
                EjecutarConculta.SelectCommand.Parameters.Add("@_ParaCocina", SqlDbType.Int).Value = (int)_ParaCocina;

                EjecutarConculta.Fill(TablaDeDatos);

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

        public DataTable ArticulosMasVendidosCategoria(string _FechaDesde, string _FechaHasta, ref string _InformacionDelError)
        {
            SqlConnection Conexion = null;

            try
            {
                //Leo la Cadena de Conexión
                string CadenaDeConexion = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

                // Tabla que almacenara los resultados
                DataTable TablaDeDatos = new DataTable();

                // Conecto con la base de datos
                Conexion = new SqlConnection(CadenaDeConexion);

                SqlDataAdapter EjecutarConculta = new SqlDataAdapter("SP_ArticulosMasVendidosCategoriaCarta", Conexion);

                Conexion.Open();

                EjecutarConculta.SelectCommand.CommandType = CommandType.StoredProcedure;
                EjecutarConculta.SelectCommand.Parameters.Add("@_FechaDesde", SqlDbType.VarChar).Value = _FechaDesde;
                EjecutarConculta.SelectCommand.Parameters.Add("@_FechaHasta", SqlDbType.VarChar).Value = _FechaHasta;

                EjecutarConculta.Fill(TablaDeDatos);

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

        public DataTable ArticulosMenosVendidosCategoria(string _FechaDesde, string _FechaHasta, ref string _InformacionDelError)
        {
            SqlConnection Conexion = null;

            try
            {
                //Leo la Cadena de Conexión
                string CadenaDeConexion = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

                // Tabla que almacenara los resultados
                DataTable TablaDeDatos = new DataTable();

                // Conecto con la base de datos
                Conexion = new SqlConnection(CadenaDeConexion);

                SqlDataAdapter EjecutarConculta = new SqlDataAdapter("SP_ArticulosMenosVendidosCategoriaCarta", Conexion);

                Conexion.Open();

                EjecutarConculta.SelectCommand.CommandType = CommandType.StoredProcedure;
                EjecutarConculta.SelectCommand.Parameters.Add("@_FechaDesde", SqlDbType.VarChar).Value = _FechaDesde;
                EjecutarConculta.SelectCommand.Parameters.Add("@_FechaHasta", SqlDbType.VarChar).Value = _FechaHasta;

                EjecutarConculta.Fill(TablaDeDatos);

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

        public DataTable ArticulosVendidosPorMesCarta(int _Año, ref string _InformacionDelError)
        {
            SqlConnection Conexion = null;

            try
            {
                //Leo la Cadena de Conexión
                string CadenaDeConexion = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

                // Tabla que almacenara los resultados
                DataTable TablaDeDatos = new DataTable();

                // Conecto con la base de datos
                Conexion = new SqlConnection(CadenaDeConexion);

                SqlDataAdapter EjecutarConculta = new SqlDataAdapter("SP_ArticulosVendidosPorMesCarta", Conexion);

                Conexion.Open();

                EjecutarConculta.SelectCommand.CommandType = CommandType.StoredProcedure;
                EjecutarConculta.SelectCommand.Parameters.Add("@_Año", SqlDbType.Int).Value = _Año;

                EjecutarConculta.Fill(TablaDeDatos);

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
