using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procuratio
{
    public partial class FrmReservas : Form
    {
        #region Codigo de carga
        public FrmReservas()
        {
            InitializeComponent();
        }

        private void FrmReservas_Load(object sender, EventArgs e)
        {
            mclFechaReserva.SelectionStart = DateTime.Today;
            lblFechaSeleccionada.Text = DateTime.Today.ToShortDateString();
        }
        #endregion

        #region Variables
        DateTime FechaSeleccionada;
        FrmSeleccionDeMesas SeleccionDeMesas = new FrmSeleccionDeMesas();
        #endregion

        #region Codigo para darle estilo a los botones
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            if (BotonEnFoco.Name == btnEliminarElementos.Name || BotonEnFoco.Name == btnCancelarReserva.Name)
            {
                BotonEnFoco.BackColor = Color.FromArgb(232, 17, 35);
            }
            else
            {
                BotonEnFoco.BackColor = Color.FromArgb(255, 127, 0);
            }
        }

        private void btnEstiloBotones_Leave(object sender, EventArgs e)
        {
            Button BotonEnFoco = (Button)sender;
            BotonEnFoco.BackColor = Color.Transparent;
        }
        #endregion

        #region Codigo para cambiar el control seleccionado con teclas
        private void mtbHorario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { txtNombreCliente.Select(); }
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { txtApellidoCliente.Select(); }

            SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { txtTelefonoCliente.Select(); }

            SoloLetras(e);
        }

        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { nudCantidadPersonas.Select(); }

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8) { e.Handled = true; }
        }

        private void nudCantidadPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void SoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8) { e.Handled = true; }
        }
        #endregion

        private void mclFechaReserva_DateChanged(object sender, DateRangeEventArgs e)
        {
            FechaSeleccionada = mclFechaReserva.SelectionStart;

            if (DateTime.Today > FechaSeleccionada)
            {
                mclFechaReserva.SelectionStart = DateTime.Today;
                lblFechaSeleccionada.Text = DateTime.Today.ToShortDateString();

                MessageBox.Show("No puede seleccionar una fecha que ya paso para reservar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblFechaSeleccionada.Text = FechaSeleccionada.ToShortDateString();
                mtbHorario.Select();
            }
        }

        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            //TODO - Conexion con la BBDD para validar datos y cargarlos o no
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            mclFechaReserva.SelectionStart = DateTime.Today;
            lblFechaSeleccionada.Text = DateTime.Today.ToShortDateString();
            txtNombreCliente.Text = string.Empty;
            txtApellidoCliente.Text = string.Empty;
            txtTelefonoCliente.Text = string.Empty;
            nudCantidadPersonas.Value = 1;
        }

        private void btnSeleccionarMesas_Click(object sender, EventArgs e)
        {
            if (mtbHorario.MaskCompleted)
            {
                SeleccionDeMesas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe completar el campo HORA antes de poder seleccionar una mesa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
