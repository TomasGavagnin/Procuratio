using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //libreria para manipular el form
using Negocio; //Referencia a mi capa de regocio para validar contraseña

namespace Procuratio
{
    public partial class FrmInicioSesion : Form
    {
        #region Codigo de carga
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            tmrPantallaCarga.Start();
            AbrirFrmPantallaDePresentacion.ShowDialog();
        }
        #endregion

        #region Variables
        FrmPantallaDePresentacion AbrirFrmPantallaDePresentacion = new FrmPantallaDePresentacion();
        private int Segundos = 0;

        private const string TextoVisualUsuario = "USUARIO", TextoVisualContraseña = "CONTRASEÑA";
        private ERespuestaBaseDeDatos InformacionDeLaExcepcion = ERespuestaBaseDeDatos.SinErrores;
        private ERespuestaDelInicio RespuestaDeSesion = ERespuestaDelInicio.DatosCorrectos;
        #endregion

        #region Codigo para agregarle la propiedad de mover a la barra personalizada
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hand, int wasg, int wparam, int iparam);

        private void Arrastre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Estilo de los contorles
        private void ColorFondoBotones_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;

            if (PictureBoxEnFoco.Name == picBTNCerrar.Name)
            {
                PictureBoxEnFoco.BackColor = Color.FromArgb(232, 17, 35);
            }
            else
            {
                PictureBoxEnFoco.BackColor = Color.Gray;
            }
        }

        private void ColorFondoBotones_MouseLeave(object sender, EventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;
            PictureBoxEnFoco.BackColor = Color.Transparent;
        }

        private void BorraTextoTXT_Enter(object sender, EventArgs e)
        {
            TextBox txtSeleccionado = (TextBox)sender;

            if (txtSeleccionado.Name == txtUsuario.Name)
            {
                if (txtSeleccionado.Text == TextoVisualUsuario) { txtSeleccionado.Text = string.Empty; }
            }
            else
            {
                if (txtSeleccionado.Text == TextoVisualContraseña)
                {
                    txtSeleccionado.Text = string.Empty;
                    txtContraseña.UseSystemPasswordChar = true;
                }
            }

            txtSeleccionado.ForeColor = Color.LightGray;
        }

        private void ColocaTextoTXT_Leave(object sender, EventArgs e)
        {
            TextBox txtSeleccionado = (TextBox)sender;

            if (txtSeleccionado.Name == txtUsuario.Name)
            {
                if (txtSeleccionado.Text == string.Empty) { txtSeleccionado.Text = TextoVisualUsuario; }
            }
            else
            {
                if (txtSeleccionado.Text == string.Empty)
                {
                    txtSeleccionado.Text = TextoVisualContraseña;
                    txtContraseña.UseSystemPasswordChar = false;
                }
            }

            txtSeleccionado.ForeColor = Color.DimGray;
        }

        private void picBTNMostrarContraseña_MouseMove(object sender, MouseEventArgs e) => txtContraseña.UseSystemPasswordChar = false;
        private void picBTNMostrarContraseña_MouseLeave(object sender, EventArgs e) { if (txtContraseña.Text != TextoVisualContraseña) { txtContraseña.UseSystemPasswordChar = true; } }

        private void LimpiarlblMensajeDeError(object sender, EventArgs e) { if (lblMensajeDeError.Visible == true) { lblMensajeDeError.Visible = false; } }
        #endregion

        //Metodo que se relaciona con el evento load 
        private void tmrPantallaCarga_Tick(object sender, EventArgs e)
        {
            Segundos++;

            if (Segundos >= 6)
            {
                AbrirFrmPantallaDePresentacion.Close();
                tmrPantallaCarga.Stop();
            }

            if (Segundos % 2 == 0) { AbrirFrmPantallaDePresentacion.S_lblCargando = "."; }
        }

        private void PresionaEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnIngresar_Click(sender, e);
                lblMensajeDeError.Select(); //Este metodo evita que se queden seleccionados los textbox, ya que si ingresa con
            }                               //enter y se cierra sesión, el textbox seleccionado no se borrará al hacer click
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            InformacionDeLaExcepcion = ERespuestaBaseDeDatos.SinErrores;
            RespuestaDeSesion = ERespuestaDelInicio.DatosCorrectos;

            RespuestaDeSesion = ClsInicioSesion.ComparaDatos(txtUsuario.Text.ToLower(), txtContraseña.Text, ref InformacionDeLaExcepcion);
            
            if (RespuestaDeSesion == ERespuestaDelInicio.DatosCorrectos)
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtUsuario.Text = TextoVisualUsuario;
                txtContraseña.Text = TextoVisualContraseña;
                
                Hide();

                FrmPrincipal AbrirFrmPrincipal = new FrmPrincipal();

                AbrirFrmPrincipal.FormClosed += CerrarSesion; //Cuando se cierra el formulario principal, se ejecuta el evento CerrarSesion

                AbrirFrmPrincipal.Show();
            }
            else
            {
                if (InformacionDeLaExcepcion != ERespuestaBaseDeDatos.SinErrores)
                {
                    switch (InformacionDeLaExcepcion)
                    {
                        case ERespuestaBaseDeDatos.ArgumentException:
                            MessageBox.Show($"ArgumentException: La cadena de conexión con la base de datos no " +
                                $"existe \r\n\r\nContacte con el programador para informar y corregir el " +
                                $"error", "ERROR CON LA BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case ERespuestaBaseDeDatos.SqlException:
                            MessageBox.Show($"SqlException: La sentencia para buscar la información es " +
                                $"invalida \r\n\r\nContacte con el programador para informar y corregir el " +
                                $"error", "ERROR CON LA BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case ERespuestaBaseDeDatos.Exception:
                            MessageBox.Show($"Exception: Posible error en la consulta \r\n\r\nContacte con el " +
                                $"programador para informar y corregir el error", "ERROR CON LA BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    switch (RespuestaDeSesion)
                    {
                        case ERespuestaDelInicio.UsuarioInexistente: { lblMensajeDeError.Text = "Usuario incorrecto"; break; }
                        case ERespuestaDelInicio.ClaveIncorrecta: { lblMensajeDeError.Text = "Contraseña incorrecta"; break; }
                        default: { lblMensajeDeError.Text = "Ocurrio un error inesperado al intentar comparar los datos para validar sesion"; break; }
                    }

                    lblMensajeDeError.Visible = true;
                }
            }
        }

        private void picBTNSalir_Click(object sender, EventArgs e) => Application.Exit();
        private void picBTNMinimizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        //Este evento se ejecutará cuando ocurra el evento FormClosing del FrmPrincipal
        private void CerrarSesion(object sender, FormClosedEventArgs e) => Show();
    }
}
