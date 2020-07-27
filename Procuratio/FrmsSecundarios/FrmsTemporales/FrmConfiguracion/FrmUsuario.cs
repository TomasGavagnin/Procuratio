using Datos;
using Negocio;
using Procuratio.ClsDeApoyo;
using Procuratio.FrmGenerales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Procuratio
{
    public partial class FrmUsuario : Form
    {
        #region Carga
        /// <summary>
        /// Carga el formulario para crear un cliente.
        /// </summary>
        public FrmUsuario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el formulario para editar un cliente.
        /// </summary>
        /// <param name="_ID_Usuario">ID Del usuario a editar</param>
        /// <param name="_EstadoDelUsuario">Indica el estado del usuario que se esta editando para mantenerlo una vez finalizada 
        /// la edicion.</param>
        public FrmUsuario(int _ID_Usuario, bool _EstadoDelUsuario)
        {
            InitializeComponent();

            ID_Usuario = _ID_Usuario;
            EstadoDelUsuario = _EstadoDelUsuario;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CargarPerfiles();
            // Se cargo el Id de un usuario para su edicion (cargar datos y habilitar botones).
            if (ID_Usuario != -1) { CargaDatosEditarUsuario(); }
        }

        private void CargarPerfiles()
        {
            txtContraseña.UseSystemPasswordChar = true;

            string InformacionDelError = string.Empty;

            ClsPerfiles Perfiles = new ClsPerfiles();
            List<Perfil> ListarPerfiles = Perfiles.LeerListado(ref InformacionDelError);

            if (ListarPerfiles != null)
            {
                // Nombre de la columna que contiene el nombre
                cmbPerfil.DisplayMember = "Nombre";
                // Nombre de la columna que contiene el ID
                cmbPerfil.ValueMember = "ID_Perfil";

                // Llenar el combo
                cmbPerfil.DataSource = ListarPerfiles.ToList();

                cmbPerfil.SelectedValue = 2;
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al cargar los perfiles", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        public void CargaDatosEditarUsuario()
        {
            btnAceptar.Visible = false;
            btnGuardarCambios.Visible = true;

            Perfil PerfilSeleccionado = (Perfil)cmbPerfil.SelectedItem;

            string InformacionDelError = string.Empty;

            ClsUsuarios Usuarios = new ClsUsuarios();
            Usuario UsuarioAEditar = new Usuario();

            UsuarioAEditar = Usuarios.LeerPorNumero(ID_Usuario, ClsUsuarios.EUsuarioABuscar.PorID, ref InformacionDelError);

            if (UsuarioAEditar != null)
            {
                txtNick.Text = UsuarioAEditar.Nick;
                txtNombre.Text = UsuarioAEditar.Nombre;
                txtApellido.Text = UsuarioAEditar.Apellido;
                txtContraseña.Text = UsuarioAEditar.Contraseña;
                cmbPerfil.SelectedValue = UsuarioAEditar.ID_Perfil;

                if (UsuarioAEditar.ID_Perfil == (int)ClsPerfiles.EPerfiles.Gerente) { cmbPerfil.Enabled = false; }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Error al intentar cargar el usuario a editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }
        #endregion

        #region Variables
        private int ID_Usuario = -1;
        private bool EstadoDelUsuario = true;
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

        private void picBTNMostrarContraseña_MouseMove(object sender, MouseEventArgs e) => txtContraseña.UseSystemPasswordChar = false;

        private void picBTNMostrarContraseña_MouseLeave(object sender, EventArgs e) => txtContraseña.UseSystemPasswordChar = true;
        #endregion

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            // Validar los datos.
            bool DatosValidos = true;
            string RegistroDeErrores = string.Empty;
            int AnchoFormInformacion = 100;

            Perfil PerfilSeleccionado = (Perfil)cmbPerfil.SelectedItem;

            txtNick.Text = txtNick.Text.Trim();
            txtNombre.Text = txtNombre.Text.Trim();
            txtApellido.Text = txtApellido.Text.Trim();

            if (txtNick.Text.Length < 2)
            {
                DatosValidos = false;
                RegistroDeErrores += "El campo 'Nick' debe tener como minimo 2 caracteres.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (txtNombre.Text.Length < 3)
            {
                DatosValidos = false;
                RegistroDeErrores += "El campo 'Nombre' debe tener un minimo de 3 caracteres'.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (txtApellido.Text.Length < 3)
            {
                DatosValidos = false;
                RegistroDeErrores += "El campo 'Apellido' debe tener un minimo de 3 caracteres'.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (txtContraseña.Text.Length < 4)
            {
                DatosValidos = false;
                RegistroDeErrores += "El campo 'Contraseña' debe tener un minimo de 4 caracteres'.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (VerificarUsuarioRepetido(txtNombre.Text, txtContraseña.Text, ID_Usuario, txtApellido.Text))
            {
                DatosValidos = false;
                RegistroDeErrores += "Verifique que no exista otro usuario con el mismo nombre y apellido, si no " +
                    "esta repetido, intente con una contraseña diferente.\r\n\r\n";
                AnchoFormInformacion += 70;
            }

            if (DatosValidos)
            {
                // Si va a ser gerente el nuevo usuario, validarlo
                bool AutorizarEdicion = true;

                if (PerfilSeleccionado.ID_Perfil == (int)ClsPerfiles.EPerfiles.Gerente)
                {
                    AutorizarEdicion = false;

                    FrmRespuesta RespuestaFormulario = new FrmRespuesta($"¿Esta seguro que desea asignarle el perfil ´Gerente'? Una vez confirmado, no se puede editar el tipo de perfil ni eliminar el usuario (por seguridad, el sistema " +
                        "no permite que personas con este tipo sean eliminadas del sistema).", FrmRespuesta.ETamaño.Pequeño, FrmRespuesta.ETipo.Si_No);

                    if (RespuestaFormulario.DialogResult == DialogResult.Yes)
                    {
                        using (FrmValidarUsuario FormValidarUsuario = new FrmValidarUsuario(FrmValidarUsuario.EFiltroUsuariosAutorizados.Gerentes))
                        {
                            FormValidarUsuario.ShowDialog();

                            if (FormValidarUsuario.DialogResult == DialogResult.OK) { AutorizarEdicion = true; }
                        }
                    }
                }

                if (AutorizarEdicion)
                {
                    // Crear usuario
                    txtNick.Text = txtNick.Text.ToUpper();
                    txtNombre.Text = txtNombre.Text.Substring(0, 1).ToUpper() + txtNombre.Text.Remove(0, 1).ToLower();
                    txtApellido.Text = txtApellido.Text.Substring(0, 1).ToUpper() + txtApellido.Text.Remove(0, 1).ToLower();

                    string InformacionDelError = string.Empty;

                    ClsUsuarios Usuarios = new ClsUsuarios();
                    Usuario CrearUsuario = new Usuario();

                    CrearUsuario.Nick = txtNick.Text;
                    CrearUsuario.Nombre = txtNombre.Text;
                    CrearUsuario.Apellido = txtApellido.Text;
                    CrearUsuario.Contraseña = txtContraseña.Text;
                    CrearUsuario.ID_EstadoUsuario = (int)ClsEstadosUsuarios.EEstadosUsuarios.Activo;
                    CrearUsuario.ID_Perfil = PerfilSeleccionado.ID_Perfil;

                    if (Usuarios.Crear(CrearUsuario, ref InformacionDelError) != 0)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else if (InformacionDelError == string.Empty)
                    {
                        MessageBox.Show("Fallo al crear el usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion(RegistroDeErrores, ClsColores.Blanco, AnchoFormInformacion, 350))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            // Comprobar datos correctos
            bool DatosValidos = true;
            string RegistroDeErrores = string.Empty;
            int AnchoFormInformacion = 100;

            Perfil PerfilSeleccionado = (Perfil)cmbPerfil.SelectedItem;

            txtNick.Text = txtNick.Text.Trim();
            txtNombre.Text = txtNombre.Text.Trim();
            txtApellido.Text = txtApellido.Text.Trim();

            if (txtNick.Text.Length < 2)
            {
                DatosValidos = false;
                RegistroDeErrores += "El campo 'Nick' debe tener como minimo 2 caracteres.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (txtNombre.Text.Length < 3)
            {
                DatosValidos = false;
                RegistroDeErrores += "El campo 'Nombre' debe tener un minimo de 3 caracteres'.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (txtApellido.Text.Length < 3)
            {
                DatosValidos = false;
                RegistroDeErrores += "El campo 'Apellido' debe tener un minimo de 3 caracteres'.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (txtContraseña.Text.Length < 4)
            {
                DatosValidos = false;
                RegistroDeErrores += "El campo 'Contraseña' debe tener un minimo de 4 caracteres'.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (VerificarUsuarioRepetido(txtNombre.Text, txtContraseña.Text, ID_Usuario, txtApellido.Text))
            {
                DatosValidos = false;
                RegistroDeErrores += "Verifique que no exista otro usuario con el mismo nombre y apellido, si no " +
                    "esta repetido, intente con una contraseña diferente.\r\n\r\n";
                AnchoFormInformacion += 70;
            }

            if (DatosValidos)
            {
                // Si va a ser gerente el nuevo usuario, validarlo
                bool AutorizarEdicion = true;

                //Si el combo esta desalibilitado, significa que el perfil ya era gerente, por lo que no pide confirmacion
                if (PerfilSeleccionado.ID_Perfil == (int)ClsPerfiles.EPerfiles.Gerente && cmbPerfil.Enabled == true)
                {
                    AutorizarEdicion = false;

                    FrmRespuesta RespuestaFormulario = new FrmRespuesta($"¿Esta seguro que desea asignarle el perfil ´Gerente'? Una vez confirmado, no se puede editar el tipo de perfil ni eliminar el usuario (por seguridad, el sistema " +
                    "no permite que personas con este tipo sean eliminadas del sistema).", FrmRespuesta.ETamaño.Pequeño, FrmRespuesta.ETipo.Si_No);

                    if (RespuestaFormulario.DialogResult == DialogResult.Yes)
                    {
                        using (FrmValidarUsuario FormValidarUsuario = new FrmValidarUsuario(FrmValidarUsuario.EFiltroUsuariosAutorizados.Gerentes))
                        {
                            FormValidarUsuario.ShowDialog();

                            if (FormValidarUsuario.DialogResult == DialogResult.OK)
                            {
                                AutorizarEdicion = true;
                            }
                        }
                    }
                }

                if (AutorizarEdicion)
                {
                    txtNick.Text = txtNick.Text.ToUpper();
                    txtNombre.Text = txtNombre.Text.Substring(0, 1).ToUpper() + txtNombre.Text.Remove(0, 1).ToLower();
                    txtApellido.Text = txtApellido.Text.Substring(0, 1).ToUpper() + txtApellido.Text.Remove(0, 1).ToLower();

                    // Actualizar
                    string InformacionDelError = string.Empty;

                    ClsUsuarios Usuarios = new ClsUsuarios();
                    Usuario ActualizarUsuario = new Usuario();

                    ActualizarUsuario.ID_Usuario = ID_Usuario;
                    ActualizarUsuario.Nick = txtNick.Text;
                    ActualizarUsuario.Nombre = txtNombre.Text;
                    ActualizarUsuario.Apellido = txtApellido.Text;
                    ActualizarUsuario.Contraseña = txtContraseña.Text;
                    ActualizarUsuario.ID_Perfil = PerfilSeleccionado.ID_Perfil;

                    //Mantener el estado del usuario (ya que sin esto, se podria habilitar usuarios sin indicarlo
                    //necesariamente, se activarian al editar uno inactivo y guardar cambios).
                    if (EstadoDelUsuario)
                    {
                        ActualizarUsuario.ID_EstadoUsuario = (int)ClsEstadosUsuarios.EEstadosUsuarios.Activo;
                    }
                    else
                    {
                        ActualizarUsuario.ID_EstadoUsuario = (int)ClsEstadosUsuarios.EEstadosUsuarios.Inactivo;
                    }

                    // Impedir dar categoria gerente a un usuario eliminado
                    if (ActualizarUsuario.ID_EstadoUsuario == (int)ClsEstadosUsuarios.EEstadosUsuarios.Inactivo && PerfilSeleccionado.ID_Perfil == (int)ClsPerfiles.EPerfiles.Gerente)
                    {
                        using (FrmInformacion FormInformacion = new FrmInformacion($"No le puede dar el perfil 'gerente' a un usuario eliminado " +
                                $"(ya que un gerente no puede estar eliminado).", ClsColores.Blanco, 150, 300))
                        {
                            FormInformacion.ShowDialog();
                        }
                    }
                    else
                    {
                        if (Usuarios.Actualizar(ActualizarUsuario, ref InformacionDelError) != 0)
                        {
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else if (InformacionDelError != string.Empty)
                        {
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion(RegistroDeErrores, ClsColores.Blanco, AnchoFormInformacion, 350))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Busca nombre o contraseña de usuarios repetidas y devuelve true si encuentra alguna coincidencia.
        /// </summary>
        /// <param name="_Nombre">Nombre del usuario.</param>
        /// <param name="_Contraseña">Contraseña del usuario.</param>
        /// <param name="_ID_UsuarioActual">ID que se usa para ignorar el usuario actual que se esta editando.</param>
        private bool VerificarUsuarioRepetido(string _Nombre, string _Contraseña, int _ID_UsuarioActual, string _Apellido)
        {
            string InformacionDelError = string.Empty;

            ClsUsuarios Usuarios = new ClsUsuarios();
            List<Usuario> BuscarDatosRepetidos = Usuarios.LeerListado(ClsUsuarios.ETipoListado.DatosRepetidos, ref InformacionDelError, _Nombre, _Contraseña, _ID_UsuarioActual, _Apellido);

            if (BuscarDatosRepetidos != null)
            {
                if (BuscarDatosRepetidos.Count > 0) { return true; }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Fallo al verificar si el usuario estaba repetido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void TxtNick_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8) { e.Handled = true; }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8) { e.Handled = true; }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8) { e.Handled = true; }
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8) { e.Handled = true; }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        ///// <summary>Establece el ID del usuario a buscar para cargar sus datos y editarlos.</summary>
        //public int S_ID_Usuario { set { ID_Usuario = value; } }
        ///// <summary>Determina si el usuario es activo o inactivo para mantener su estado al editarlo.</summary>
        //public bool S_EstadoDelUsuario { set { EstadoDelUsuario = value; } }
        #endregion
    }
}
