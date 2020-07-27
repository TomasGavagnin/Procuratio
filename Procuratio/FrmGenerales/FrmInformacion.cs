using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Procuratio.ClsDeApoyo;

namespace Procuratio
{
    public partial class FrmInformacion : Form
    {
        #region Carga
        /// <summary>
        /// Inicializa el formulario
        /// </summary>
        /// <param name="_Mensaje">Mensaje informativo a mostrar.</param>
        /// <param name="_ColorTexto">Color de las letras del texto (valor por defecto blanco).</param>
        /// <param name="_Alto">Alto del formulario.</param>
        /// <param name="_Ancho">Ancho del formulario.</param>
        public FrmInformacion(string _Mensaje, Color _ColorTexto, int _Alto, int _Ancho)
        {
            InitializeComponent();

            Mensaje = _Mensaje;
            ColorMensaje = _ColorTexto;

            lblMensaje.Text = _Mensaje;
            lblMensaje.ForeColor = _ColorTexto;

            Height = _Alto;
            Width = _Ancho;
        }
        #endregion

        #region Variables
        private string Mensaje = string.Empty;
        private Color ColorMensaje;
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
        #endregion
    }
}
