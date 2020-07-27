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
    public partial class FrmGestionCliente : Form
    {
        #region Carga
        /// <summary>
        /// Inicializa el formulario para crear un cliente.
        /// </summary>
        public FrmGestionCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa el formulario para editar un cliente.
        /// </summary>
        /// <param name="_ID_Cliente">ID del cliente a editar.</param>
        public FrmGestionCliente(int _ID_Cliente)
        {
            InitializeComponent();

            ID_Cliente = _ID_Cliente;
        }

        private void FrmGestionCliente_Load(object sender, EventArgs e)
        {
            if (ID_Cliente != -1) { CargarCliente(); }
        }

        private void CargarCliente()
        {
            btnCrearCliente.Visible = false;
            btnGuardarCambios.Visible = true;

            string InformacionDelError = string.Empty;

            ClsClientes Clientes = new ClsClientes();
            Cliente BuscarCliente = new Cliente();

            BuscarCliente = Clientes.LeerPorNumero(ID_Cliente, ClsClientes.EClienteBuscar.PorID, ref InformacionDelError);

            if (BuscarCliente != null)
            {
                txtNombreCliente.Text = BuscarCliente.Nombre;
                txtApellidoCliente.Text = BuscarCliente.Apellido;
                txtTelefonoCliente.Text = Convert.ToString(BuscarCliente.Telefono);
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al crear el cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private int ID_Cliente = -1;
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

        private void TxtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8) { e.Handled = true; }
        }

        private void TxtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8) { e.Handled = true; }
        }

        private void TxtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8) { e.Handled = true; }
        }

        private void BtnCrearCliente_Click(object sender, EventArgs e)
        {
            bool DatosValidos = true;
            string RegistroDeErrores = string.Empty;
            int AnchoFormInformacion = 100;

            if (txtTelefonoCliente.Text == string.Empty) { txtTelefonoCliente.Text = "0"; }

            txtNombreCliente.Text = txtNombreCliente.Text.Trim();
            txtApellidoCliente.Text = txtApellidoCliente.Text.Trim();
            txtTelefonoCliente.Text = txtTelefonoCliente.Text.Trim();

            if (txtApellidoCliente.Text == string.Empty && txtNombreCliente.Text == string.Empty)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe cargar un nombre o apellido'.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (VerificarClienteRepetido(txtNombreCliente.Text, txtApellidoCliente.Text, txtTelefonoCliente.Text, ID_Cliente))
            {
                DatosValidos = false;
                RegistroDeErrores += "El nombre del cliente y su apellido, ya se encuentran en uso, intente con " +
                    "otros datos.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (DatosValidos)
            {
                if (txtNombreCliente.Text != string.Empty)
                {
                    txtNombreCliente.Text = txtNombreCliente.Text.Substring(0, 1).ToUpper() + txtNombreCliente.Text.Remove(0, 1).ToLower();
                }

                if (txtApellidoCliente.Text != string.Empty)
                {
                    txtApellidoCliente.Text = txtApellidoCliente.Text.Substring(0, 1).ToUpper() + txtApellidoCliente.Text.Remove(0, 1).ToLower();
                }

                string InformacionDelError = string.Empty;

                ClsClientes Clientes = new ClsClientes();
                Cliente CrearCliente = new Cliente();

                CrearCliente.Nombre = txtNombreCliente.Text;
                CrearCliente.Apellido = txtApellidoCliente.Text;
                CrearCliente.Telefono = Convert.ToInt64(txtTelefonoCliente.Text);

                if (Clientes.Crear(CrearCliente, ref InformacionDelError) != 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else if (InformacionDelError == string.Empty)
                {
                    MessageBox.Show("Fallo al crear el cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            bool DatosValidos = true;
            string RegistroDeErrores = string.Empty;
            int AnchoFormInformacion = 100;

            if (txtTelefonoCliente.Text == string.Empty) { txtTelefonoCliente.Text = "0"; }

            txtNombreCliente.Text = txtNombreCliente.Text.Trim();
            txtApellidoCliente.Text = txtApellidoCliente.Text.Trim();
            txtTelefonoCliente.Text = txtTelefonoCliente.Text.Trim();

            if (txtApellidoCliente.Text == string.Empty && txtNombreCliente.Text == string.Empty)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe cargar un nombre o apellido'.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (VerificarClienteRepetido(txtNombreCliente.Text, txtApellidoCliente.Text, txtTelefonoCliente.Text, ID_Cliente))
            {
                DatosValidos = false;
                RegistroDeErrores += "El nombre del cliente y su apellido ya se encuentran en uso, intente con " +
                                     "otros datos.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (DatosValidos)
            {
                if (txtNombreCliente.Text != string.Empty)
                {
                    txtNombreCliente.Text = txtNombreCliente.Text.Substring(0, 1).ToUpper() + txtNombreCliente.Text.Remove(0, 1).ToLower();
                }

                if (txtApellidoCliente.Text != string.Empty)
                {
                    txtApellidoCliente.Text = txtApellidoCliente.Text.Substring(0, 1).ToUpper() + txtApellidoCliente.Text.Remove(0, 1).ToLower();
                }

                string InformacionDelError = string.Empty;

                ClsClientes Clientes = new ClsClientes();
                Cliente CrearCliente = new Cliente();

                CrearCliente.ID_Cliente = ID_Cliente;
                CrearCliente.Nombre = txtNombreCliente.Text;
                CrearCliente.Apellido = txtApellidoCliente.Text;
                CrearCliente.Telefono = Convert.ToInt64(txtTelefonoCliente.Text);

                if (Clientes.Actualizar(CrearCliente, ref InformacionDelError) != 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else if (InformacionDelError != string.Empty)
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion(RegistroDeErrores, ClsColores.Blanco, AnchoFormInformacion, 300))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Busca si encuentra nombre o contraseña de usuario repetidos y devuelve true si encuentra algun resultado.
        /// </summary>
        /// <param name="_Nombre">Nombre del cliente.</param>
        /// <param name="_Apellido">Apellido del cliente.</param>
        /// <param name="_Telefono">Telefono del cliente</param>
        /// <param name="_ID_Cliente">ID que se usa para ignorar el cliente que se esta editando.</param>
        private bool VerificarClienteRepetido(string _Nombre, string _Apellido, string _Telefono, int _ID_Cliente)
        {
            string InformacionDelError = string.Empty;

            ClsClientes Clientes = new ClsClientes();
            List<Cliente> BuscarDatosRepetidos = Clientes.LeerListado(ClsClientes.EClienteBuscar.DatosRepetidos, ref InformacionDelError, _Nombre, _Apellido, _Telefono, _ID_Cliente);

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

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        #endregion
    }
}
