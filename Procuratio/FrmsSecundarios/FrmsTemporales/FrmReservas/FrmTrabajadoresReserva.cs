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
    public partial class FrmTrabajadoresReserva : Form
    {
        #region Carga
        public FrmTrabajadoresReserva()
        {
            InitializeComponent();
        }

        private void FrmTrabajadoresReserva_Load(object sender, EventArgs e)
        {
            CargarCMBMozos();
            CargarCMBChefs();
        }

        private void CargarCMBMozos()
        {
            string InformacionDelError = string.Empty;

            ClsUsuarios ListarUsuarios = new ClsUsuarios();

            List<Usuario> CargarComboBoxUsuarios = ListarUsuarios.LeerListado(ClsUsuarios.ETipoListado.UsuariosParaMesas, ref InformacionDelError);

            if (CargarComboBoxUsuarios != null)
            {
                foreach (Usuario Elemento in CargarComboBoxUsuarios)
                {
                    Elemento.Nombre += $" {Elemento.Apellido}";
                }

                // Nombre de la columna que contiene el nombre
                cmbMozo.DisplayMember = "Nombre";
                // Nombre de la columna que contiene el ID
                cmbMozo.ValueMember = "ID_Usuario";

                // Llenar el combo
                cmbMozo.DataSource = CargarComboBoxUsuarios.ToList();
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Ocurrio un error al cargar los mozos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarCMBChefs()
        {
            string InformacionDelError = string.Empty;

            ClsUsuarios ListarChefs = new ClsUsuarios();

            List<Usuario> CargarComboBoxChefs = ListarChefs.LeerListado(ClsUsuarios.ETipoListado.UsuariosChef, ref InformacionDelError);

            if (CargarComboBoxChefs != null)
            {
                foreach (Usuario Elemento in CargarComboBoxChefs)
                {
                    Elemento.Nombre += $" {Elemento.Apellido}";
                }

                // Nombre de la columna que contiene el nombre
                cmbChef.DisplayMember = "Nombre";
                // Nombre de la columna que contiene el ID
                cmbChef.ValueMember = "ID_Usuario";

                // Llenar el combo
                cmbChef.DataSource = CargarComboBoxChefs.ToList();
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Ocurrio un error al cargar los mozos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Variables
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbMozo.SelectedValue != null && cmbChef.SelectedValue != null)
            {
                Usuario UsuarioSeleccionado = (Usuario)cmbMozo.SelectedItem;
                Usuario ChefSeleccionado = (Usuario)cmbChef.SelectedItem;

                FrmReservas.ObtenerInstancia().S_ID_Mozo = UsuarioSeleccionado.ID_Usuario;
                FrmReservas.ObtenerInstancia().S_ID_Chef = ChefSeleccionado.ID_Usuario;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion($"Es obligatorio asignar el mozo y chef a la mesa.", ClsColores.Blanco, 150, 300))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();
    }
}
