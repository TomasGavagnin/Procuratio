using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;
using Negocio.Clases_de_apoyo;
using System.Collections;
using Procuratio.ClsDeApoyo;

namespace Procuratio.FrmsSecundarios.FrmEstadisticas
{
    public partial class FrmEstadisticasCarta : Form
    {
        #region Carga
        private FrmEstadisticasCarta()
        {
            InitializeComponent();
        }

        private void FrmEstadisticasCarta_Load(object sender, EventArgs e)
        {
            AsigarValoresPorDefecto();

            CargarChtArticulosMasVendidosCocina();
            CargarChtArticulosMasVendidosNoCocina();
            CargarChtArticulosMenosVendidosCocina();
            CargarChtArticulosMenosVendidosNoCocina();
            CargarChtArticulosMasVendidosCategoria();
            CargarChtArticulosMenosVendidosCategoria();
            CargarChtArticulosVendidosPorMes();
        }
        
        private void AsigarValoresPorDefecto()
        {
            dtpFechaDesde.Value = Convert.ToDateTime($@"01/{DateTime.Today.Month}/{DateTime.Today.Year}");
            dtpDechaHasta.Value = Convert.ToDateTime($@"{DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month)}/{DateTime.Today.Month}/{DateTime.Today.Year}");
            nudAño.Value = DateTime.Today.Year;

            ckbIncluirFechaDesde.Checked = true;
            ckbIncluirFechaHasta.Checked = true;
        }

        private void CargarChtArticulosMasVendidosCocina()
        {
            ArrayList NombreArticulo = new ArrayList();
            ArrayList CantidadArticulos = new ArrayList();
            DataTable TablaDeDatos = new DataTable();
            string InformacionDelError = string.Empty;

            string FechaDesde = Convert.ToString(dtpFechaDesde.Value.Date);
            string FechaHasta = Convert.ToString(dtpDechaHasta.Value.Date);

            if (!ckbIncluirFechaDesde.Checked) { FechaDesde = string.Empty; }
            if (!ckbIncluirFechaHasta.Checked) { FechaHasta = string.Empty; }

            ClsDatosEstadisticasCartas DatosEstadisticasCarta = new ClsDatosEstadisticasCartas();
            TablaDeDatos = DatosEstadisticasCarta.ArticulosMasVendidosCarta(FechaDesde, FechaHasta, ClsCategoriasArticulos.EParaCocina.Si, ref InformacionDelError);

            if (InformacionDelError == string.Empty)
            {
                if (TablaDeDatos.Rows.Count > 0)
                {
                    ChtArticulosMasVendidosCocina.Visible = true;
                    PicArticulosMasVendidosCocina.Visible = false;

                    foreach (DataRow Elemento in TablaDeDatos.Rows)
                    {
                        NombreArticulo.Add(Elemento[0].ToString());
                        CantidadArticulos.Add(Elemento[1].ToString());
                    }

                    ChtArticulosMasVendidosCocina.Series[0].Points.DataBindXY(NombreArticulo, CantidadArticulos);
                }
                else
                {
                    ChtArticulosMasVendidosCocina.Visible = false;
                    PicArticulosMasVendidosCocina.Visible = true;
                }
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al cargar el grafico");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarChtArticulosMasVendidosNoCocina()
        {
            ArrayList NombreArticulo = new ArrayList();
            ArrayList CantidadArticulos = new ArrayList();
            DataTable TablaDeDatos = new DataTable();
            string InformacionDelError = string.Empty;

            string FechaDesde = Convert.ToString(dtpFechaDesde.Value.Date);
            string FechaHasta = Convert.ToString(dtpDechaHasta.Value.Date);

            if (!ckbIncluirFechaDesde.Checked) { FechaDesde = string.Empty; }
            if (!ckbIncluirFechaHasta.Checked) { FechaHasta = string.Empty; }

            ClsDatosEstadisticasCartas DatosEstadisticasCarta = new ClsDatosEstadisticasCartas();
            TablaDeDatos = DatosEstadisticasCarta.ArticulosMasVendidosCarta(FechaDesde, FechaHasta, ClsCategoriasArticulos.EParaCocina.No, ref InformacionDelError);

            if (InformacionDelError == string.Empty)
            {
                if (TablaDeDatos.Rows.Count > 0)
                {
                    ChtArticulosMasVendidosNoCocina.Visible = true;
                    PicArticulosMasVendidosNoCocina.Visible = false;

                    foreach (DataRow Elemento in TablaDeDatos.Rows)
                    {
                        NombreArticulo.Add(Elemento[0].ToString());
                        CantidadArticulos.Add(Elemento[1].ToString());
                    }

                    ChtArticulosMasVendidosNoCocina.Series[0].Points.DataBindXY(NombreArticulo, CantidadArticulos);
                }
                else
                {
                    ChtArticulosMasVendidosNoCocina.Visible = false;
                    PicArticulosMasVendidosNoCocina.Visible = true;
                }
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al cargar el grafico");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarChtArticulosMenosVendidosCocina()
        {
            ArrayList NombreArticulo = new ArrayList();
            ArrayList CantidadArticulos = new ArrayList();
            DataTable TablaDeDatos = new DataTable();
            string InformacionDelError = string.Empty;

            string FechaDesde = Convert.ToString(dtpFechaDesde.Value.Date);
            string FechaHasta = Convert.ToString(dtpDechaHasta.Value.Date);

            if (!ckbIncluirFechaDesde.Checked) { FechaDesde = string.Empty; }
            if (!ckbIncluirFechaHasta.Checked) { FechaHasta = string.Empty; }

            ClsDatosEstadisticasCartas DatosEstadisticasCarta = new ClsDatosEstadisticasCartas();
            TablaDeDatos = DatosEstadisticasCarta.ArticulosMenosVendidosCarta(FechaDesde, FechaHasta, ClsCategoriasArticulos.EParaCocina.Si, ref InformacionDelError);

            if (InformacionDelError == string.Empty)
            {
                if (TablaDeDatos.Rows.Count > 0)
                {
                    ChtArticulosMenosVendidosCocina.Visible = true;
                    PicArticulosMenosVendidosCocina.Visible = false;

                    foreach (DataRow Elemento in TablaDeDatos.Rows)
                    {
                        NombreArticulo.Add(Elemento[0].ToString());
                        CantidadArticulos.Add(Elemento[1].ToString());
                    }

                    ChtArticulosMenosVendidosCocina.Series[0].Points.DataBindXY(NombreArticulo, CantidadArticulos);
                }
                else
                {
                    ChtArticulosMenosVendidosCocina.Visible = false;
                    PicArticulosMenosVendidosCocina.Visible = true;
                }
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al cargar el grafico");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarChtArticulosMenosVendidosNoCocina()
        {
            ArrayList NombreArticulo = new ArrayList();
            ArrayList CantidadArticulos = new ArrayList();
            DataTable TablaDeDatos = new DataTable();
            string InformacionDelError = string.Empty;

            string FechaDesde = Convert.ToString(dtpFechaDesde.Value.Date);
            string FechaHasta = Convert.ToString(dtpDechaHasta.Value.Date);

            if (!ckbIncluirFechaDesde.Checked) { FechaDesde = string.Empty; }
            if (!ckbIncluirFechaHasta.Checked) { FechaHasta = string.Empty; }

            ClsDatosEstadisticasCartas DatosEstadisticasCarta = new ClsDatosEstadisticasCartas();
            TablaDeDatos = DatosEstadisticasCarta.ArticulosMenosVendidosCarta(FechaDesde, FechaHasta, ClsCategoriasArticulos.EParaCocina.No, ref InformacionDelError);

            if (InformacionDelError == string.Empty)
            {
                if (TablaDeDatos.Rows.Count > 0)
                {
                    ChtArticulosMenosVendidosNoCocina.Visible = true;
                    PicArticulosMenosVendidosNoCocina.Visible = false;

                    foreach (DataRow Elemento in TablaDeDatos.Rows)
                    {
                        NombreArticulo.Add(Elemento[0].ToString());
                        CantidadArticulos.Add(Elemento[1].ToString());
                    }

                    ChtArticulosMenosVendidosNoCocina.Series[0].Points.DataBindXY(NombreArticulo, CantidadArticulos);
                }
                else
                {
                    ChtArticulosMenosVendidosNoCocina.Visible = false;
                    PicArticulosMenosVendidosNoCocina.Visible = true;
                }
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al cargar el grafico");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarChtArticulosMasVendidosCategoria()
        {
            ArrayList NombreCategoria = new ArrayList();
            ArrayList CantidadArticulos = new ArrayList();
            DataTable TablaDeDatos = new DataTable();
            string InformacionDelError = string.Empty;

            string FechaDesde = Convert.ToString(dtpFechaDesde.Value.Date);
            string FechaHasta = Convert.ToString(dtpDechaHasta.Value.Date);

            if (!ckbIncluirFechaDesde.Checked) { FechaDesde = string.Empty; }
            if (!ckbIncluirFechaHasta.Checked) { FechaHasta = string.Empty; }

            ClsDatosEstadisticasCartas DatosEstadisticasCarta = new ClsDatosEstadisticasCartas();
            TablaDeDatos = DatosEstadisticasCarta.ArticulosMasVendidosCategoria(FechaDesde, FechaHasta, ref InformacionDelError);

            if (InformacionDelError == string.Empty)
            {
                if (TablaDeDatos.Rows.Count > 0)
                {
                    ChtArticulosMasVendidosPorCategoria.Visible = true;
                    PicArticulosMasVendidosPorCategoria.Visible = false;

                    foreach (DataRow Elemento in TablaDeDatos.Rows)
                    {
                        NombreCategoria.Add(Elemento[0].ToString());
                        CantidadArticulos.Add(Elemento[1]);
                    }

                    ChtArticulosMasVendidosPorCategoria.Series[0].Points.DataBindXY(NombreCategoria, CantidadArticulos);
                }
                else
                {
                    ChtArticulosMasVendidosPorCategoria.Visible = false;
                    PicArticulosMasVendidosPorCategoria.Visible = true;
                }
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al cargar el grafico");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarChtArticulosMenosVendidosCategoria()
        {
            ArrayList NombreCategoria = new ArrayList();
            ArrayList CantidadArticulos = new ArrayList();
            DataTable TablaDeDatos = new DataTable();
            string InformacionDelError = string.Empty;

            string FechaDesde = Convert.ToString(dtpFechaDesde.Value.Date);
            string FechaHasta = Convert.ToString(dtpDechaHasta.Value.Date);

            if (!ckbIncluirFechaDesde.Checked) { FechaDesde = string.Empty; }
            if (!ckbIncluirFechaHasta.Checked) { FechaHasta = string.Empty; }

            ClsDatosEstadisticasCartas DatosEstadisticasCarta = new ClsDatosEstadisticasCartas();
            TablaDeDatos = DatosEstadisticasCarta.ArticulosMenosVendidosCategoria(FechaDesde, FechaHasta, ref InformacionDelError);

            if (InformacionDelError == string.Empty)
            {
                if (TablaDeDatos.Rows.Count > 0)
                {
                    ChtArticulosMenosVendidosPorCategoria.Visible = true;
                    PicArticulosMenosVendidosPorCategoria.Visible = false;

                    NombreCategoria.Reverse();
                    CantidadArticulos.Reverse();

                    foreach (DataRow Elemento in TablaDeDatos.Rows)
                    {
                        NombreCategoria.Add(Elemento[0].ToString());
                        CantidadArticulos.Add(Elemento[1]);
                    }
                    
                    ChtArticulosMenosVendidosPorCategoria.Series[0].Points.DataBindXY(NombreCategoria, CantidadArticulos);
                }
                else
                {
                    ChtArticulosMenosVendidosPorCategoria.Visible = false;
                    PicArticulosMenosVendidosPorCategoria.Visible = true;
                }
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al cargar el grafico");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarChtArticulosVendidosPorMes()
        {
            ArrayList NombreCategoria = new ArrayList();
            ArrayList CantidadArticulos = new ArrayList();
            DataTable TablaDeDatos = new DataTable();
            string InformacionDelError = string.Empty;

            ClsDatosEstadisticasCartas DatosEstadisticasCarta = new ClsDatosEstadisticasCartas();
            TablaDeDatos = DatosEstadisticasCarta.ArticulosVendidosPorMesCarta((int)nudAño.Value, ref InformacionDelError);

            lblArticulosVendidosPorMes.Text = $"ARTICULOS VENDIDOS POR MES (AÑO {Convert.ToString(nudAño.Value)})";

            if (InformacionDelError == string.Empty)
            {
                if (TablaDeDatos.Rows.Count > 0)
                {
                    ChtArticulosVendidosPorMes.Visible = true;
                    PicArticulosVendidosPorMes.Visible = false;

                    foreach (DataRow Elemento in TablaDeDatos.Rows)
                    {
                        switch (Elemento[0])
                        {
                            case 1: NombreCategoria.Add("Enero"); break;
                            case 2: NombreCategoria.Add("Febrero"); break;
                            case 3: NombreCategoria.Add("Marzo"); break;
                            case 4: NombreCategoria.Add("Abril"); break;
                            case 5: NombreCategoria.Add("Mayo"); break;
                            case 6: NombreCategoria.Add("Junio"); break;
                            case 7: NombreCategoria.Add("Julio"); break;
                            case 8: NombreCategoria.Add("Agosto"); break;
                            case 9: NombreCategoria.Add("Septiembre"); break;
                            case 10: NombreCategoria.Add("Octubre"); break;
                            case 11: NombreCategoria.Add("Noviembre"); break;
                            case 12: NombreCategoria.Add("Diciembre"); break;
                        }

                        CantidadArticulos.Add(Elemento[1]);
                    }

                    ChtArticulosVendidosPorMes.Series[0].Points.DataBindXY(NombreCategoria, CantidadArticulos);
                }
                else
                {
                    ChtArticulosVendidosPorMes.Visible = false;
                    PicArticulosVendidosPorMes.Visible = true;
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
        private static FrmEstadisticasCarta InstanciaForm;
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
            BotonEnFoco.BackColor = Color.Transparent;
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
            CargarChtArticulosMasVendidosCocina();
            CargarChtArticulosMasVendidosNoCocina();
            CargarChtArticulosMenosVendidosCocina();
            CargarChtArticulosMenosVendidosNoCocina();
            CargarChtArticulosMasVendidosCategoria();
            CargarChtArticulosMenosVendidosCategoria();
            CargarChtArticulosVendidosPorMes();
        }

        private void BtnAplicarValoresPorDefecto_Click(object sender, EventArgs e)
        {
            AsigarValoresPorDefecto();

            CargarChtArticulosMasVendidosCocina();
            CargarChtArticulosMasVendidosNoCocina();
            CargarChtArticulosMenosVendidosCocina();
            CargarChtArticulosMenosVendidosNoCocina();
            CargarChtArticulosMasVendidosCategoria();
            CargarChtArticulosMenosVendidosCategoria();
            CargarChtArticulosVendidosPorMes();
        }

        /// <summary>
        /// Devuelve una unica instancia del formulario (Patron singleton)
        /// </summary>
        /// <returns></returns>
        public static FrmEstadisticasCarta ObtenerInstancia()
        {
            if (InstanciaForm == null) { InstanciaForm = new FrmEstadisticasCarta(); }

            return InstanciaForm;
        }
    }
}
