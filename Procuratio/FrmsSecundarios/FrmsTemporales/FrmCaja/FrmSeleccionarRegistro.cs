using Datos;
using Negocio;
using Procuratio.ClsDeApoyo;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Procuratio.FrmsSecundarios.FrmsTemporales.FrmCaja
{
    public partial class FrmSeleccionarRegistro : Form
    {
        #region Carga
        public FrmSeleccionarRegistro()
        {
            InitializeComponent();
        }

        private void FrmSeleccionarRegistro_Load(object sender, EventArgs e)
        {
            CargarDGVListarCliente();
        }
        #endregion

        #region Variables
        private enum ENumColDGVRegistro
        {
            ID_Cuenta, Nombre, Tipo, EnviarCuenta
        }

        private int ID_Registro = -1;
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

        private void DgvSeleccionarRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DetectarBoton = (DataGridView)sender;

            if (DetectarBoton.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                ID_Registro = (int)dgvListarRegistros.Rows[e.RowIndex].Cells[(int)ENumColDGVRegistro.ID_Cuenta].Value;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CargarDGVListarCliente()
        {
            string InformacionDelError = string.Empty;

            ClsTiposDeMontos TipoDeMonto = new ClsTiposDeMontos();
            List<TipoDeMonto> ListarMontos = TipoDeMonto.LeerListado(ClsTiposDeMontos.ETipoDeListado.CrearRegistro, ref InformacionDelError);

            ClsCajas Cajas = new ClsCajas();
            List<Caja> BuscarCajaAbierta = Cajas.LeerListado(ClsCajas.ETipoListado.CajaAbierta, ref InformacionDelError);

            if (ListarMontos != null && BuscarCajaAbierta != null)
            {
                bool OcultatCierreAperturaCaja = false;

                foreach (TipoDeMonto Elemento in ListarMontos)
                {
                    OcultatCierreAperturaCaja = false;

                    if (BuscarCajaAbierta.Count > 0 && Elemento.ID_TipoDeMonto == (int)ClsTiposDeMontos.ETiposDeMontos.AperturaCaja)
                    {
                        OcultatCierreAperturaCaja = true;
                    }
                    else if (BuscarCajaAbierta.Count == 0 && Elemento.ID_TipoDeMonto == (int)ClsTiposDeMontos.ETiposDeMontos.CierreCaja)
                    {
                        OcultatCierreAperturaCaja = true;
                    }

                    if (!OcultatCierreAperturaCaja)
                    {
                        int NumeroDeFila = dgvListarRegistros.Rows.Add();

                        dgvListarRegistros.Rows[NumeroDeFila].Cells[(int)ENumColDGVRegistro.ID_Cuenta].Value = Elemento.ID_TipoDeMonto;
                        dgvListarRegistros.Rows[NumeroDeFila].Cells[(int)ENumColDGVRegistro.Nombre].Value = Elemento.Nombre;
                        dgvListarRegistros.Rows[NumeroDeFila].Cells[(int)ENumColDGVRegistro.Tipo].Value = Elemento.TipoDeMovimiento.Nombre;
                        dgvListarRegistros.Rows[NumeroDeFila].Cells[(int)ENumColDGVRegistro.EnviarCuenta].Value = "Enviar";
                    }
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al listar los montos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        public int G_ID_Registro { get { return ID_Registro; } }
    }
}
