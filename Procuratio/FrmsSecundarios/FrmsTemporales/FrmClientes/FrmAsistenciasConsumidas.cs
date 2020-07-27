using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Procuratio.ClsDeApoyo;

namespace Procuratio.FrmsSecundarios.FrmsTemporales.FrmClientes
{
    public partial class FrmAsistenciasAConssumir : Form
    {
        #region Carga
        public FrmAsistenciasAConssumir()
        {
            InitializeComponent();
        }

        /// <summary>Inicializa la variable que contendra la instancia del formulario de administracion de reservas.</summary>
        /// <param name="_FormCliente">Instancia del formulario.</param>
        public void AsignarFormCliente(FrmCliente _FormCliente) => FormCliente = _FormCliente;
        #endregion

        #region Variables
        FrmCliente FormCliente = null;
        #endregion

        #region Codigo para darle estilo a los botones
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            FormCliente.S_AsistenciasAConsumir = (int)nudCantidadAConsumir.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();
    }
}
