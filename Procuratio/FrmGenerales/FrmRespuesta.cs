using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Procuratio.ClsDeApoyo;

namespace Procuratio.FrmGenerales
{
    public partial class FrmRespuesta : Form
    {
        #region Carga
        /// <summary>
        /// Inicializa el formulario sin mostrarlo, estableciendo su propiedad DialogResult como Yes.
        /// </summary>
        public FrmRespuesta()
        {
            InitializeComponent();

            DialogResult = DialogResult.Yes;
        }

        /// <summary>
        /// Muestra un formulario para pedirle al usuario una respuesta. El formulario detectara si los 
        /// parametros de tamaño son acordes para mostrar todo el contenido correctamente, si no es asi, 
        /// este modificara sus dimensiones finales. Ese formulario se muestra en pantalla por si mismo, 
        /// no es necesario invicarlo desde donde se lo llame.
        /// </summary>
        /// <param name="_Mensaje">Mensaje que se mostrara.</param>
        /// <param name="_Tamaño">Tamaño en funcion del largo del mensaje.</param>
        /// <param name="_Tipo">Botones que se mostrarán.</param>
        public FrmRespuesta(string _Mensaje, ETamaño _Tamaño, ETipo _Tipo)
        {
            InitializeComponent();

            lblMensaje.Text = _Mensaje;
            Mensaje = _Mensaje;

            AjustaTamaño(_Mensaje, ref _Tamaño, _Tipo);
            PreparaBotones(_Tipo);
            PreparaTamaño(_Tamaño);

            ShowDialog();
        }

        /// <summary>
        /// Ajusta el tamaño del formulario, si el texto que se quiere mostrar es mas grande del que 
        /// puede contener o si el fomulario es de tamaño pequeño y se quiere mostrar 3 botones.
        /// </summary>
        /// <param name="_Mensaje">Mensaje que se quiere mostrar</param>
        /// <param name="_Tamaño">Tamaña que se le queire asignar que cambiara al finalizar el metodo 
        /// si este no es el indicado.</param>
        /// <param name="_Tipo">Tipo de formulario de respuesta que se quiere mostrar.</param>
        private void AjustaTamaño(string _Mensaje, ref ETamaño _Tamaño, ETipo _Tipo)
        {
            // Evitar un formulario demasiado pequeño
            if (_Tipo == ETipo.Si_No_Cancelar && _Tamaño == ETamaño.Pequeño) { _Tamaño = ETamaño.Mediano; }

            if (_Mensaje.Length > 250 && _Mensaje.Length <= 400)
            {
                _Tamaño = ETamaño.Mediano;
            }
            else if (_Mensaje.Length > 500)
            {
                _Tamaño = ETamaño.Grande;
            }
        }

        /// <summary>
        /// Ajusta la posicion X - Y de los botones
        /// </summary>
        /// <param name="_Tipo">Botones que se desearan mostrar.</param>
        private void PreparaBotones(ETipo _Tipo)
        {
            switch (_Tipo)
            {
                case ETipo.Si_No:
                    {
                        btnSi.Visible = true;
                        BtnNo.Visible = true;
                        BtnCancelar.Visible = false;
                        break;
                    }
                case ETipo.Si_No_Cancelar:
                    {
                        btnSi.Visible = true;
                        BtnNo.Visible = true;
                        BtnCancelar.Visible = true;
                        break;
                    }
            }
        }

        /// <summary>
        /// Asigna el tamaño del formulario.
        /// </summary>
        /// <param name="_Tamaño">Tamaño que se asignara.</param>
        private void PreparaTamaño(ETamaño _Tamaño)
        {
            switch (_Tamaño)
            {
                case ETamaño.Pequeño:
                    {
                        Height = 200;
                        Width = 470;

                        HeighForm = 200;
                        WidthForm = 470;
                        break;
                    }
                case ETamaño.Mediano:
                    {
                        Height = 250;
                        Width = 520;

                        HeighForm = 250;
                        WidthForm = 520;
                        break;
                    }
                case ETamaño.Grande:
                    {
                        Height = 400;
                        Width = 570;

                        HeighForm = 400;
                        WidthForm = 570;
                        break;
                    }
            }
        }

        private void FrmRespuesta_Load(object sender, EventArgs e)
        {
            pnlBarraDeArrastre.Select(); // Evita un big visual al cargar el formulario.
        }
        #endregion

        #region Estilo
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            if (BotonEnFoco.Name == BtnNo.Name || BotonEnFoco.Name == BtnCancelar.Name)
            {
                BotonEnFoco.BackColor = ClsColores.Rojo;
            }
            else
            {
                BotonEnFoco.BackColor = ClsColores.VerdeClaro;
            }
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

        #region Variables
        public enum ETamaño
        {
            /// <summary>Width = 470, height = 200.</summary>
            Pequeño,

            /// <summary>Width = 520, height = 250.</summary>
            Mediano,

            /// <summary>Width = 570, height = 300.</summary>
            Grande
        }

        public enum ETipo
        {
            Si_No, Si_No_Cancelar
        }

        private int HeighForm = 0, WidthForm = 0;
        private string Mensaje = string.Empty;
        #endregion

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void BtnSi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        #region Propiedades

        #endregion
    }
}
