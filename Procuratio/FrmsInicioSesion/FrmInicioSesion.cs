using Negocio;
using Datos;
using System;
using System.Drawing;
using System.Runtime.InteropServices; //libreria para manipular el form
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using Procuratio.Reportes;
using Procuratio.ClsDeApoyo;

namespace Procuratio
{
    public partial class FrmInicioSesion : Form
    {
        #region Codigo de carga
        private FrmInicioSesion()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        private static FrmInicioSesion InstanciaForm;

        private int ID_UsuarioInicioSesion = -1;
        private int ID_PerfilUsuarioInicioSesion = -1;
        private string NombreUsuarioInicioSesion = string.Empty;

        private int Segundos = 0;
        private bool SeCierraLaAplicacion = false;
        private bool TiempoDeSesionExedido = false;

        private readonly string TextoVisualUsuario = "NOMBRE", TextoVisualContraseña = "CONTRASEÑA";
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

        #region Estilo
        private void ColorFondoBotones_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;

            if (PictureBoxEnFoco.Name == picBTNCerrar.Name)
            {
                PictureBoxEnFoco.BackColor = ClsColores.Rojo;
            }
            else
            {
                PictureBoxEnFoco.BackColor = ClsColores.Gris;
            }
        }

        private void ColorFondoBotones_MouseLeave(object sender, EventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;
            PictureBoxEnFoco.BackColor = ClsColores.Transparente;
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

            txtSeleccionado.ForeColor = ClsColores.GrisClaro;
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

            txtSeleccionado.ForeColor = ClsColores.GrisOscuro;
        }

        private void picBTNMostrarContraseña_MouseMove(object sender, MouseEventArgs e) => txtContraseña.UseSystemPasswordChar = false;
        private void picBTNMostrarContraseña_MouseLeave(object sender, EventArgs e) { if (txtContraseña.Text != TextoVisualContraseña) { txtContraseña.UseSystemPasswordChar = true; } }

        private void LimpiarlblMensajeDeError(object sender, EventArgs e) { if (lblMensajeDeError.Visible == true) { lblMensajeDeError.Visible = false; } }
        #endregion

        //Metodo que se relaciona con el evento load 
        private void tmrPantallaCarga_Tick(object sender, EventArgs e)
        {
            Segundos++;

            if (Segundos >= 4)
            {
                FrmPantallaDePresentacion.ObtenerInstancia().Close();
                tmrPantallaCarga.Stop();
                Segundos = 0;
            }

            FrmPantallaDePresentacion.ObtenerInstancia().S_lblCargando = ".";
        }

        private void PresionaEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnIngresar_Click(sender, e);
                e.Handled = true;
                lblMensajeDeError.Select(); //Este metodo evita que se queden seleccionados los textbox, ya que si ingresa con
            }                               //enter y se cierra sesión, el textbox seleccionado no se borrará al hacer click
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string InformacionDelError = string.Empty;
            ClsUsuarios.ERespuestaDelInicio RespuestaDeSesion = ClsUsuarios.ERespuestaDelInicio.UsuarioYContraseñaIncorrecta;

            ClsUsuarios Usuarios = new ClsUsuarios();
            Usuario UsuarioIniciaSesion = Usuarios.LeerParaInicioSesion(txtUsuario.Text, txtContraseña.Text, ref RespuestaDeSesion, ref InformacionDelError);

            if (UsuarioIniciaSesion != null)
            {
                txtUsuario.Text = TextoVisualUsuario;
                txtContraseña.Text = TextoVisualContraseña;
                txtContraseña.UseSystemPasswordChar = false;

                Hide();

                FrmPrincipal FormPrincipal = FrmPrincipal.ObtenerInstancia();

                FormPrincipal.FormClosed += CerrarSesion; //Cuando se cierra el formulario principal, se ejecuta el evento CerrarSesion

                ID_UsuarioInicioSesion = UsuarioIniciaSesion.ID_Usuario;
                ID_PerfilUsuarioInicioSesion = UsuarioIniciaSesion.ID_Perfil;
                NombreUsuarioInicioSesion = $"{UsuarioIniciaSesion.Nombre} {UsuarioIniciaSesion.Apellido}";

                if (UsuarioIniciaSesion.ID_Perfil != (int)ClsPerfiles.EPerfiles.Administrador)
                {
                    tmrPantallaCarga.Start();
                    FrmPantallaDePresentacion.ObtenerInstancia().ShowDialog();
                }

                FormPrincipal.Show();
            }
            else if (InformacionDelError == string.Empty)
            {
                switch (RespuestaDeSesion)
                {
                    case ClsUsuarios.ERespuestaDelInicio.DadoDeBaja: lblMensajeDeError.Text = "Usuario dado de baja"; break;
                    case ClsUsuarios.ERespuestaDelInicio.UsuarioYContraseñaIncorrecta: lblMensajeDeError.Text = "Usuario y contraseña incorrectos"; break;
                    case ClsUsuarios.ERespuestaDelInicio.UsuarioIncorrecto: lblMensajeDeError.Text = "Usuario incorrecto"; break;
                    case ClsUsuarios.ERespuestaDelInicio.ClaveIncorrecta: lblMensajeDeError.Text = "Contraseña incorrecta"; break;
                    default: lblMensajeDeError.Text = "Ocurrio un error inesperado al intentar comparar los datos para validar sesión"; break;
                }

                lblMensajeDeError.Visible = true;
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void picBTNSalir_Click(object sender, EventArgs e) => Application.Exit();
        private void picBTNMinimizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        //Este evento se ejecutará cuando ocurra el evento FormClosing del FrmPrincipal (que se ejecuta desde el boton cerrar sesion)
        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            if (!SeCierraLaAplicacion) { Show(); }

            if (TiempoDeSesionExedido)
            {
                Hide();

                FrmInformacion FormInformacion = new FrmInformacion($"Alcanzo el tiempo de sesion maximo. El programa se cerró " +
                    $"intencionalmente para pedirle que inicie sesion nuevamente. Esto se hace con el objetivo " +
                    $"de reducir el consumo de recursos de su computadora en caso de que " +
                    $"quedara el programa abierto.", ClsColores.Blanco, 275, 525);

                FormInformacion.FormClosed += CerrarInformacion;

                FormInformacion.TopMost = true;
                FormInformacion.Show();

                TiempoDeSesionExedido = false;
            }

            ID_UsuarioInicioSesion = -1;
            ID_PerfilUsuarioInicioSesion = -1;
            NombreUsuarioInicioSesion = string.Empty;
        }

        /// <summary>
        /// Devuelve una unica instancia del formulario (Patron singleton)
        /// </summary>
        /// <returns></returns>
        public static FrmInicioSesion ObtenerInstancia()
        {
            if (InstanciaForm == null) { InstanciaForm = new FrmInicioSesion(); }

            return InstanciaForm;
        }

        private void CerrarInformacion(object sender, FormClosedEventArgs e) => Show();

        #region Propiedades
        public bool S_SeCierraLaAplicacion { set { SeCierraLaAplicacion = value; } }

        public bool S_TiempoDeSesionExedido { set { TiempoDeSesionExedido = value; } }

        public int G_ID_UsuarioInicioSesion { get { return ID_UsuarioInicioSesion; } }

        public int G_ID_PerfilUsuarioInicioSesion { get { return ID_PerfilUsuarioInicioSesion; } }

        public string G_NombreUsuarioInicioSesion { get { return NombreUsuarioInicioSesion; } }
        #endregion
    }
}
