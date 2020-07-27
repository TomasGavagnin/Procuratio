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
using Datos;
using Negocio;
using Procuratio.ClsDeApoyo;

namespace Procuratio
{
    public partial class FrmValidarUsuario : Form
    {
        #region Carga
        /// <summary>
        /// Lista un conjunto de usuarios que tienen permitido el acceso basado en su perfil (no admite usuarios eliminados).
        /// </summary>
        /// <param name="_UsuariosAutorizados">Tipos de usuarios que seran autorizados.</param>
        public FrmValidarUsuario(EFiltroUsuariosAutorizados _UsuariosAutorizados)
        {
            InitializeComponent();

            UsuariosAutorizados = _UsuariosAutorizados;

            BuscarUsuariosAutorizados();
        }

        /// <summary>
        /// Autoriza un unico usuario (no admite usuarios eliminados).
        /// </summary>
        /// <param name="_UsuarioParticular">ID del usuario autirozado</param>
        public FrmValidarUsuario(int _UsuarioParticular)
        {
            InitializeComponent();

            ID_UsuarioParticular = _UsuarioParticular;

            BuscarUsuarioParticular();
        }

        /// <summary>
        /// Autoriza a un conjunto a perfiles, y a un usuario con un ID en especifico (no admite usuarios eliminados).
        /// </summary>
        /// <param name="_UsuariosAutorizados">Tipos de usuarios que seran autorizados.</param>
        /// <param name="_UsuarioParticular">ID del usuario autirozado.</param>
        public FrmValidarUsuario(EFiltroUsuariosAutorizadosYParticular _UsuariosAutorizados, int _UsuarioParticular)
        {
            InitializeComponent();

            ID_UsuarioParticular = _UsuarioParticular;
            UsuariosAutorizadosYParticular = _UsuariosAutorizados;

            BuscarUsuariosAutorizadosYParticular();
        }

        private void BuscarUsuariosAutorizados()
        {
            string InformacionDelError = string.Empty;

            string InformarUsuariosAutorizados = "(*) ";

            switch (UsuariosAutorizados)
            {
                case EFiltroUsuariosAutorizados.Gerentes:
                    {
                        ListarUsuariosAutorizados = Usuarios.LeerListado(ClsUsuarios.ETipoListado.UsuariosGerentes, ref InformacionDelError);
                        InformarUsuariosAutorizados += "Gerentes";
                        break;
                    }
                case EFiltroUsuariosAutorizados.GerentesSubGerentes:
                    {
                        ListarUsuariosAutorizados = Usuarios.LeerListado(ClsUsuarios.ETipoListado.UsuariosGerYSubGer, ref InformacionDelError);
                        InformarUsuariosAutorizados += "Gerentes y subgerentes";
                        break;
                    }
                case EFiltroUsuariosAutorizados.GerenteSubGerenteChef:
                    {
                        ListarUsuariosAutorizados = Usuarios.LeerListado(ClsUsuarios.ETipoListado.ChefGerenteSubgerente, ref InformacionDelError);
                        InformarUsuariosAutorizados += "Gerentes, subgerentes o chefs";
                        break;
                    }
                case EFiltroUsuariosAutorizados.Todos:
                    {
                        ListarUsuariosAutorizados = Usuarios.LeerListado(ClsUsuarios.ETipoListado.TodosLosUsuarios, ref InformacionDelError);
                        InformarUsuariosAutorizados += "Todos los usuarios";
                        break;
                    }
                case EFiltroUsuariosAutorizados.Desarrolladores:
                    {
                        ListarUsuariosAutorizados = Usuarios.LeerListado(ClsUsuarios.ETipoListado.Desarrollador, ref InformacionDelError);
                        InformarUsuariosAutorizados += "Desarrolladores";
                        break;
                    }
            }

            ComprobarResultado(InformacionDelError, InformarUsuariosAutorizados);
        }

        private void BuscarUsuariosAutorizadosYParticular()
        {
            string InformacionDelError = string.Empty;

            string InformarUsuariosAutorizados = "(*) ";

            switch (UsuariosAutorizadosYParticular)
            {
                case EFiltroUsuariosAutorizadosYParticular.GerenteSubGerenteMozoDueño:
                    {
                        ListarUsuariosAutorizados = Usuarios.LeerListado(ClsUsuarios.ETipoListado.GerenteSubGerenteMozoDueño, ref InformacionDelError, string.Empty, string.Empty, ID_UsuarioParticular);
                        InformarUsuariosAutorizados += "Gerentes, subgerentes o mozo dueño del usuario";
                        break;
                    }
            }

            ComprobarResultado(InformacionDelError, InformarUsuariosAutorizados);
        }

        private void BuscarUsuarioParticular()
        {
            string InformacionDelError = string.Empty;

            string InformarUsuariosAutorizados = "(*) ";

            Usuario UsuarioEncontrado = Usuarios.LeerPorNumero(ID_UsuarioParticular, ClsUsuarios.EUsuarioABuscar.PorID, ref InformacionDelError);

            if (UsuarioEncontrado != null)
            {
                ListarUsuariosAutorizados.Add(UsuarioEncontrado);
                InformarUsuariosAutorizados += "Dueño del usuario que selecciono";
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Error al intentar cargar los datos para solicitar autorizacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }

            ComprobarResultado(InformacionDelError, InformarUsuariosAutorizados);
        }

        private void ComprobarResultado(string _InformacionDelError, string _InformarUsuariosAutorizados)
        {
            if (ListarUsuariosAutorizados != null)
            {
                lblUsuariosAutorizados.Text = _InformarUsuariosAutorizados;
            }
            else if (_InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Error al intentar cargar los datos para solicitar autorizacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show($"{_InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }
        #endregion

        #region Variables
        public enum EFiltroUsuariosAutorizados
        {
            Gerentes, GerentesSubGerentes, GerenteSubGerenteChef, Desarrolladores, Todos
        }

        public enum EFiltroUsuariosAutorizadosYParticular
        {
            GerenteSubGerenteMozoDueño
        }

        private const string TextoVisualContraseña = "CONTRASEÑA";
        private EFiltroUsuariosAutorizados UsuariosAutorizados;
        private EFiltroUsuariosAutorizadosYParticular UsuariosAutorizadosYParticular;
        private int ID_UsuarioParticular = -1;
        private ClsUsuarios Usuarios = new ClsUsuarios();
        private List<Usuario> ListarUsuariosAutorizados = new List<Usuario>();
        private int ID_UsuarioQueValido = -1;
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
            PictureBoxEnFoco.BackColor = ClsColores.Rojo;
        }

        private void ColorFondoBotones_MouseLeave(object sender, EventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;
            PictureBoxEnFoco.BackColor = ClsColores.Transparente;
        }

        private void BorraTextoTXT_Enter(object sender, EventArgs e)
        {
            lblMensajeDeError.Visible = false;

            TextBox txtSeleccionado = (TextBox)sender;

            if (txtSeleccionado.Text == TextoVisualContraseña)
            {
                txtSeleccionado.Text = string.Empty;
                txtContraseña.UseSystemPasswordChar = true;
            }

            txtSeleccionado.ForeColor = ClsColores.GrisClaro;
        }

        private void ColocaTextoTXT_Leave(object sender, EventArgs e)
        {
            TextBox txtSeleccionado = (TextBox)sender;

            if (txtSeleccionado.Text == string.Empty)
            {
                txtSeleccionado.Text = TextoVisualContraseña;
                txtContraseña.UseSystemPasswordChar = false;
            }

            txtSeleccionado.ForeColor = ClsColores.GrisOscuro;
        }

        private void picBTNMostrarContraseña_MouseMove(object sender, MouseEventArgs e) => txtContraseña.UseSystemPasswordChar = false;
        private void picBTNMostrarContraseña_MouseLeave(object sender, EventArgs e) { if (txtContraseña.Text != TextoVisualContraseña) { txtContraseña.UseSystemPasswordChar = true; } }

        private void LimpiarlblMensajeDeError(object sender, EventArgs e) { if (lblMensajeDeError.Visible == true) { lblMensajeDeError.Visible = false; } }
        #endregion

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnIngresar_Click(sender, e);
                e.Handled = true;
                lblMensajeDeError.Select(); //Este metodo evita que se queden seleccionados los textbox, ya que si ingresa con
            }                               //enter y se cierra sesión, el textbox seleccionado no se borrará al hacer click
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            foreach (Usuario Elemento in ListarUsuariosAutorizados)
            {
                if (txtContraseña.Text == Elemento.Contraseña)
                {
                    ID_UsuarioQueValido = Elemento.ID_Usuario;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }

            lblMensajeDeError.Visible = true;
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        public int G_ID_UsuarioQueValido { get { return ID_UsuarioQueValido; } }
        #endregion
    }
}
