using Negocio.Clases_de_apoyo.Clases_para_estadisticas;
using Procuratio.ClsDeApoyo;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Procuratio.FrmsSecundarios.FrmEstadisticas
{
    public partial class FrmEstadisticasCaja : Form
    {
        #region Carga
        private FrmEstadisticasCaja()
        {
            InitializeComponent();
        }

        private void FrmEstadisticasMesa_Load(object sender, EventArgs e)
        {
            AsigarValoresPorDefecto();

            CargarChtGananciasPerdidasPorMes();
        }

        private void AsigarValoresPorDefecto()
        {
            dtpFechaDesde.Value = Convert.ToDateTime($@"01/{DateTime.Today.Month}/{DateTime.Today.Year}");
            dtpDechaHasta.Value = Convert.ToDateTime($@"{DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month)}/{DateTime.Today.Month}/{DateTime.Today.Year}");
            nudAñoGananciasPerdidas.Value = DateTime.Today.Year;

            ckbIncluirFechaDesde.Checked = true;
            ckbIncluirFechaHasta.Checked = true;
        }

        private void CargarChtGananciasPerdidasPorMes()
        {
            DataTable TablaDeDatos = new DataTable();
            string InformacionDelError = string.Empty;

            ClsDatosEstadisticasCajas DatosEstadisticasCaja = new ClsDatosEstadisticasCajas();
            TablaDeDatos = DatosEstadisticasCaja.GananciasPerdidasPorMes((int)nudAñoGananciasPerdidas.Value, ref InformacionDelError);

            lblGananciasPerdidasPorMes.Text = $"PEDIDOS COMPLETADOS POR MES (AÑO {(int)nudAñoGananciasPerdidas.Value})";

            if (InformacionDelError == string.Empty)
            {
                if (TablaDeDatos.Rows.Count > 0)
                {
                    ChtGananciasPorMes.Series.Clear();
                    ChtGananciasPorMes.ResetAutoValues();

                    ChtGananciasPorMes.Visible = true;
                    PicGananciasPerdidasMes.Visible = false;

                    ChtGananciasPorMes.DataBindCrossTable(TablaDeDatos.AsDataView(), "TipoDeMovimiento", "Mes", "Monto", null);

                    //Busco cada seria le aplico propiedades
                    foreach (Series Elemento in ChtGananciasPorMes.Series)
                    {
                        Elemento.ChartType = SeriesChartType.Column;
                        Elemento.MarkerSize = 7;
                        //Elemento.MarkerStyle = MarkerStyle.Circle;
                        Elemento.LabelForeColor = Color.Gold;
                        Elemento.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        Elemento.IsValueShownAsLabel = true;
                    }
                }
                else
                {
                    ChtGananciasPorMes.Visible = false;
                    PicGananciasPerdidasMes.Visible = true;
                }
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al cargar el grafico");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Variables
        private static FrmEstadisticasCaja InstanciaForm;
        #endregion

        #region Estilo
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            if (BotonEnFoco.Name == btnAplicarFiltro.Name || BotonEnFoco.Name == btnAplicarValoresPorDefecto.Name)
            {
                BotonEnFoco.BackColor = ClsColores.VioletaClaro;
            }
            else
            {
                BotonEnFoco.BackColor = ClsColores.NaranjaClaro;
            }
        }

        private void btnEstiloBotones_Leave(object sender, EventArgs e)
        {
            Button BotonEnFoco = (Button)sender;
            BotonEnFoco.BackColor = ClsColores.Transparente;
        }
        #endregion

        private void DtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value > dtpDechaHasta.Value) { dtpDechaHasta.Value = dtpFechaDesde.Value; }
        }

        private void DtpDechaHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDechaHasta.Value < dtpFechaDesde.Value) { dtpFechaDesde.Value = dtpDechaHasta.Value; }
        }

        private void CkbIncluirFechaDesde_CheckedChanged(object sender, EventArgs e) => dtpFechaDesde.Enabled = ckbIncluirFechaDesde.Checked ? true : false;

        private void CkbIncluirFechaHasta_CheckedChanged(object sender, EventArgs e) => dtpDechaHasta.Enabled = ckbIncluirFechaHasta.Checked ? true : false;

        private void BtnAplicarFiltro_Click(object sender, EventArgs e)
        {
            CargarChtGananciasPerdidasPorMes();
        }

        private void BtnAplicarValoresPorDefecto_Click(object sender, EventArgs e)
        {
            AsigarValoresPorDefecto();

            CargarChtGananciasPerdidasPorMes();
        }

        /// <summary>
        /// Devuelve una unica instancia del formulario (Patron singleton)
        /// </summary>
        /// <returns></returns>
        public static FrmEstadisticasCaja ObtenerInstancia()
        {
            if (InstanciaForm == null) { InstanciaForm = new FrmEstadisticasCaja(); }

            return InstanciaForm;
        }
    }
}
