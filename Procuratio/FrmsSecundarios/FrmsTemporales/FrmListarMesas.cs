using Datos;
using Negocio;
using Procuratio.ClsDeApoyo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Procuratio.FrmsSecundarios.FrmsTemporales
{
    public partial class FrmListarMesas : Form
    {
        #region Carga
        /// <summary>
        /// Muestra el formulario solo con las mesas libres si se pasa un True como parametro.
        /// </summary>
        /// <param name="_MostrarDesocupadas"></param>
        public FrmListarMesas(bool _MostrarDesocupadas)
        {
            InitializeComponent();

            MostrarDesocupadas = _MostrarDesocupadas;
        }

        private void FrmMesasDisponibles_Load(object sender, EventArgs e)
        {
            TrabajaConPA();

            if (MostrarDesocupadas)
            {
                CargarDGVListarMesas(ClsMesas.ETipoDeListado.MesasDisponiblesPB);
            }
            else
            {
                CargarDGVListarMesas(ClsMesas.ETipoDeListado.MesasActivasPB);
            }
        }

        /// <summary>Bloquea el RBN de PA si marco desde configuracion que no trabaja con PA.</summary>
        private void TrabajaConPA()
        {
            string InformacionDelError = string.Empty;

            ClsConfiguraciones Configuraciones = new ClsConfiguraciones();
            Configuracion HabilitarPA = new Configuracion();

            HabilitarPA = Configuraciones.LeerPorNumero(1, ref InformacionDelError);

            if (HabilitarPA != null)
            {
                if (HabilitarPA.TrabajaConPlantaAlta == 1) { rbnPlantaAlta.Enabled = true; }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al comprobar si trabaja con planta alta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Variables
        /// <summary>
        /// Enumera las columnas del DGV para poder ubicarlas y editar mas facilmente su posicion.
        /// </summary>
        private enum ENumColDGVMesa
        {
            ID_Mesa, Numero, Capacidad
        }

        private bool MostrarDesocupadas = false;
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

        private void RbnPlantaBaja_CheckedChanged(object sender, EventArgs e)
        {
            if (MostrarDesocupadas)
            {
                CargarDGVListarMesas(ClsMesas.ETipoDeListado.MesasDisponiblesPB);
            }
            else
            {
                CargarDGVListarMesas(ClsMesas.ETipoDeListado.MesasActivasPB);
            }
        }

        private void RbnPlantaAlta_CheckedChanged(object sender, EventArgs e)
        {
            if (MostrarDesocupadas)
            {
                CargarDGVListarMesas(ClsMesas.ETipoDeListado.MesasDisponiblesPA);
            }
            else
            {
                CargarDGVListarMesas(ClsMesas.ETipoDeListado.MesasActivasPA);
            }
        }

        /// <summary>Carga el DGV.</summary>
        private void CargarDGVListarMesas(ClsMesas.ETipoDeListado _TipoDeListado)
        {
            dgvListarMesas.Rows.Clear();

            string InformacionDelError = string.Empty;

            ClsMesas Mesas = new ClsMesas();

            List<Mesa> ListarMesas = Mesas.LeerListado(_TipoDeListado, ref InformacionDelError);

            if (ListarMesas != null)
            {
                int CapacidadTotal = 0;

                foreach (Mesa Elemento in ListarMesas)
                {
                    int NumeroDeFila = dgvListarMesas.Rows.Add();

                    dgvListarMesas.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.ID_Mesa].Value = Elemento.ID_Mesa;
                    dgvListarMesas.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.Numero].Value = Elemento.Numero;
                    dgvListarMesas.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.Capacidad].Value = Elemento.Capacidad;

                    CapacidadTotal += Elemento.Capacidad;
                }
                dgvListarMesas.Sort(dgvListarMesas.Columns[(int)ENumColDGVMesa.Numero], ListSortDirection.Ascending);

                lblResultadoCapacidadTotal.Text = Convert.ToString(CapacidadTotal);
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al comprobar si trabaja con planta alta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        public bool S_MostrarDisponibles { set { MostrarDesocupadas = value; } }
        #endregion
    }
}
