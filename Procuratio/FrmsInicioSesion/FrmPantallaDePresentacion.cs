using Negocio; //Referencia a mi capa de regocio para validar contraseña
using System;
using System.Drawing;
using System.Runtime.InteropServices; //libreria para manipular el form
using System.Windows.Forms;
using Procuratio.ClsDeApoyo;

namespace Procuratio
{
    public partial class FrmPantallaDePresentacion : Form
    {
        #region Codigo de carga
        private FrmPantallaDePresentacion()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        private static FrmPantallaDePresentacion InstanciaForm;
        private bool AplicacionCargando = true;
        private readonly string MensajeDeCarga = "CARGANDO";
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

        #region Codigo para agregarle la propiedad de mover a la barra personalizada
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hand, int wasg, int wparam, int iparam);

        private void Arrastre_MouseDown(object sender, MouseEventArgs e)
        {
            if (!AplicacionCargando)
            {
                ReleaseCapture();
                SendMessage(Handle, 0x112, 0xf012, 0);
            }
        }
        #endregion

        public void PreparaFrmParaMostrar()
        {
            Cursor = Cursors.Default;
            lblCargando.Visible = false;
            picBTNCerrar.Visible = true;
            AplicacionCargando = false;
        }

        /// <summary>
        /// Devuelve una unica instancia del formulario (Patron singleton)
        /// </summary>
        /// <returns></returns>
        public static FrmPantallaDePresentacion ObtenerInstancia()
        {
            if (InstanciaForm == null) { InstanciaForm = new FrmPantallaDePresentacion(); }

            return InstanciaForm;
        }

        private void PicBTNCerrar_Click(object sender, System.EventArgs e) => Close();

        private void FrmPantallaDePresentacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cursor = Cursors.AppStarting;
            lblCargando.Visible = true;
            picBTNCerrar.Visible = false;
            AplicacionCargando = true;
            lblCargando.Text = MensajeDeCarga;
        }

        #region Propiedades
        public string S_lblCargando { set { lblCargando.Text += value; } }
        #endregion
    }
}
