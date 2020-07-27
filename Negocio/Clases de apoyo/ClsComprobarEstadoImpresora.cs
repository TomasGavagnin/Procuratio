using System.Management;

namespace Negocio
{
    public static class ClsComprobarEstadoImpresora
    {
        /// <summary>
        ///Metodo para comprobar si una impresora esta online o offline
        /// </summary>
        /// <param name="_NombreImpresora">Nombre de la impresora a buscar.</param>
        public static bool ComprobarEstadoImpresora(string _NombreImpresora)
        {
            string NombreImpresoraActual = string.Empty;
            bool Conectada = false;

            //set the scope of this search to the local machine
            ManagementScope Escape = new ManagementScope(ManagementPath.DefaultPath);
            //connect to the machine
            Escape.Connect();

            //query for the ManagementObjectSearcher
            SelectQuery Consulta = new SelectQuery("select * from Win32_Printer");

            ManagementClass AdministradorDeImpresoras = new ManagementClass("Win32_Printer");

            ManagementObjectSearcher obj = new ManagementObjectSearcher(Escape, Consulta);

            //get each instance from the ManagementObjectSearcher object
            using (ManagementObjectCollection Impresoras = AdministradorDeImpresoras.GetInstances())
            {
                //now loop through each printer instance returned
                foreach (ManagementObject ImpresoraActual in Impresoras)
                {
                    //first make sure we got something back
                    if (ImpresoraActual != null)
                    {
                        //get the current printer name in the loop
                        NombreImpresoraActual = ImpresoraActual["Name"].ToString().ToLower();

                        //check if it matches the name provided
                        if (NombreImpresoraActual.Equals(_NombreImpresora.ToLower()))
                        {
                            //since we found a match check it's status
                            if (ImpresoraActual["WorkOffline"].ToString().ToLower().Equals("true") || ImpresoraActual["PrinterStatus"].Equals(7))
                            {
                                //Esta desconectada
                                Conectada = false;
                            }
                            else
                            {
                                //Esta conectada
                                Conectada = true;
                            }
                        }
                    }
                }
            }
            return Conectada;
        }
    }
}
