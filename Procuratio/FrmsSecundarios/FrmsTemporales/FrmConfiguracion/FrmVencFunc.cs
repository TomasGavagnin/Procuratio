using Datos;
using Negocio.Clases_por_tablas;
using Procuratio.ClsDeApoyo;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Procuratio.FrmsSecundarios.FrmsTemporales.FrmConfiguracion
{
    public partial class FrmVencFunc : Form
    {
        #region Carga
        public FrmVencFunc()
        {
            InitializeComponent();
        }

        private void FrmVencimientoFuncionalidades_Load(object sender, EventArgs e)
        {
            string InformacionDelError = string.Empty;

            ClsVencimientosFuncionalidades VencimientosFuncionalidades = new ClsVencimientosFuncionalidades();
            VencimientoFuncionalidades CargarFechas = VencimientosFuncionalidades.LeerPorNumero(1, ref InformacionDelError);

            if (CargarFechas != null)
            {
                dtpVencimientoGeneral.Value = CargarFechas.VencimientoGeneral.Date;
                dtpVencimientoFuncionesEspecificas.Value = CargarFechas.VencimientoFunciones.Date;
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al leer los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }
        #endregion

        #region codigo para agregarle la propiedad de mover a la barra personalizada
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hand, int wasg, int wparam, int iparam);

        private void pnlBarraDeArrastre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Estilo
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;
            BotonEnFoco.BackColor = ClsColores.NaranjaClaro;
        }

        private void btnEstiloBotones_Leave(object sender, EventArgs e)
        {
            Button BotonEnFoco = (Button)sender;
            BotonEnFoco.BackColor = ClsColores.Transparente;
        }

        private void ColorFondoBotones_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;
            PictureBoxEnFoco.BackColor = ClsColores.Rojo;
        }

        private void ColorFondoBotones_MouseLeave(object sender, EventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;
            PictureBoxEnFoco.BackColor = ClsColores.Transparente;
        }
        #endregion


        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (dtpVencimientoGeneral.Value.Date >= dtpVencimientoFuncionesEspecificas.Value.Date)
            {
                using (FrmValidarUsuario FormValidarUsuario = new FrmValidarUsuario(FrmValidarUsuario.EFiltroUsuariosAutorizados.Desarrolladores))
                {
                    FormValidarUsuario.ShowDialog();

                    if (FormValidarUsuario.DialogResult == DialogResult.OK)
                    {
                        string InformacionDelError = string.Empty;

                        ClsVencimientosFuncionalidades VencimientoFuncionalidades = new ClsVencimientosFuncionalidades();
                        VencimientoFuncionalidades ActualizarFechas = VencimientoFuncionalidades.LeerPorNumero(1, ref InformacionDelError);

                        if (ActualizarFechas != null)
                        {
                            ActualizarFechas.VencimientoGeneral = dtpVencimientoGeneral.Value.Date;
                            ActualizarFechas.VencimientoFunciones = dtpVencimientoFuncionesEspecificas.Value.Date;

                            if (VencimientoFuncionalidades.Actualizar(ActualizarFechas, ref InformacionDelError) != 0)
                            {
                                using (FrmInformacion FormInformacion = new FrmInformacion($"Se actualizaron las fechas de vencimiento con exito:\r\n\r\n" +
                                        $"Fecha de vencimiento general = {ActualizarFechas.VencimientoGeneral.ToShortDateString()}\r\n\r\n" +
                                        $"Fecha de vencimiento de funciones especificas = {ActualizarFechas.VencimientoFunciones.ToShortDateString()}", ClsColores.Blanco, 200, 500))
                                {
                                    FormInformacion.ShowDialog();
                                }
                                Close();
                            }
                            else if (InformacionDelError != string.Empty)
                            {
                                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else if (InformacionDelError == string.Empty)
                        {
                            MessageBox.Show("Fallo al leer los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        using (FrmInformacion FormInformacion = new FrmInformacion("Usuario no autorizado, actualizacion de vencimientos cancelada.", ClsColores.Blanco, 150, 300))
                        {
                            FormInformacion.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion("La fecha de vencimiento de las funciones generales no puede ser menor " +
                        "a la de las funciones especificas.", ClsColores.Blanco, 150, 300))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }
        #endregion
    }
}
