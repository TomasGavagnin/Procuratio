using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.IO.Compression;
using Negocio;
using Datos;
using Negocio.Clases_por_tablas;
using System.Net.Mail;
using System.IO;

namespace Negocio
{
    public static class ClsGenerarBackUps
    {
        /// <summary>
        /// Metodo que genera un BackUp de la base de datos actual
        /// </summary>
        /// <param name="_CreacionCancelada">Indica si cancelo la seleccion de la ruta.</param>
        /// <param name="_InformacionDelError">Informa si hubo algun problema.</param>
        public static string GenerarBackUp(ref bool _CreacionCancelada, ref string _InformacionDelError)
        {
            SqlConnection Conexion = null;

            try
            {
                using (Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString()))
                {
                    string Ruta = string.Empty;

                    using (FolderBrowserDialog RutaIndicada = new FolderBrowserDialog())
                    {
                        RutaIndicada.Description = $"Seleccione una unidad C,D,etc. (una vez dentro en una de estas, puede seleccionar la carpeta " +
                            $"que deseé). Si selecciona otro tipo de ubicacion, se notificará el error.";
                        RutaIndicada.RootFolder = Environment.SpecialFolder.MyComputer;

                        if (RutaIndicada.ShowDialog() == DialogResult.OK && RutaIndicada.SelectedPath != string.Empty)
                        {
                            Ruta = $@"{RutaIndicada.SelectedPath}";

                            string InformacionDelError = string.Empty;
                        
                            ClsInformacionesRestaurantes InformacionesRestaurantes = new ClsInformacionesRestaurantes();
                            InformacionRestaurante BuscarDatosRestaurante = InformacionesRestaurantes.LeerPorNumero(1, ref InformacionDelError);

                            string NombreCopia = string.Empty;

                            if (BuscarDatosRestaurante != null)
                            {
                                NombreCopia = $"Copia de seguridad de {BuscarDatosRestaurante.Nombre} del {DateTime.Today.Date.ToShortDateString()} a las {DateTime.Now.ToString(@"HH\:mm\:ss")}";
                            }
                            else
                            {
                                NombreCopia = $"Copia de seguridad del {DateTime.Today.Date.ToShortDateString()} a las {DateTime.Now.ToString(@"HH\:mm\:ss")}";

                                MessageBox.Show("Ocurrio un error al buscar el nombre del restaurante para colocar su nombre en la copia de seguridad, " +
                                    "se creará la copia sin el mismo.");
                            }

                            NombreCopia = NombreCopia.Replace('/', '_');
                            NombreCopia = NombreCopia.Replace(':', '_');

                            string ComandoConsulta = $@"BACKUP DATABASE [BDRestaurante] TO  DISK = N'{Ruta}\{NombreCopia}.bak' WITH NOFORMAT, NOINIT,  NAME = N'BDRestaurante-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

                            SqlCommand Comando = new SqlCommand(ComandoConsulta, Conexion);

                            Conexion.Open();
                            Comando.ExecuteNonQuery();
                        }
                        else
                        {
                            _CreacionCancelada = true;
                        }

                        return Ruta;
                    }
                }
            }
            catch (Exception Error)
            {
                _InformacionDelError = $"OCURRIO UN ERROR INESPERADO AL INTENTAR LISTAR LA INFORMACIÓN: {Error.Message}\r\n\r\n" +
                $"ORIGEN DEL ERROR: {Error.StackTrace}\r\n\r\n" +
                $"OBJETO QUE GENERÓ EL ERROR: {Error.Data}\r\n\r\n\r\n" +
                $"ENVIE AL PROGRAMADOR UNA FOTO DE ESTE MENSAJE CON UNA DESCRIPCION DE LO QUE HIZO ANTES DE QUE SE GENERARÁ " +
                $"ESTE ERROR PARA QUE SEA ARREGLADO.";
                return string.Empty;
            }
            finally
            {
                if (Conexion != null) { Conexion.Close(); }
            }
        }
    }
}
