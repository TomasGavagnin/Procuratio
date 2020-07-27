using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Datos;
using Negocio;
using Negocio.Clases_por_tablas;
using Procuratio.Reportes;
using Procuratio.ClsDeApoyo;
using Procuratio.FrmGenerales;

namespace Procuratio
{
    public partial class FrmCaja : Form
    {
        #region Codigo de carga
        private FrmCaja()
        {
            InitializeComponent();
        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {
            CargarFiltroTipoDeMontos();
            CargarFiltroUsuarios();
            MovimientosDeHoyEnAdelante();
        }

        private void CargarFiltroTipoDeMontos()
        {
            string InformacionDelError = string.Empty;

            ClsTiposDeMontos TipoDeMontos = new ClsTiposDeMontos();

            List<TipoDeMonto> CargarComboBoxTipoDeMontos = TipoDeMontos.LeerListado(ClsTiposDeMontos.ETipoDeListado.Todo, ref InformacionDelError);

            if (CargarComboBoxTipoDeMontos != null)
            {
                // Creo el item para listar todo
                CargarComboBoxTipoDeMontos.Add(new TipoDeMonto { ID_TipoDeMonto = 0, Nombre = "Todos los movimientos" });

                // Nombre de la columna que contiene el nombre
                cmbTipoDeMonto.DisplayMember = "Nombre";
                // Nombre de la columna que contiene el ID
                cmbTipoDeMonto.ValueMember = "ID_TipoDeMonto";

                // Llenar el combo
                cmbTipoDeMonto.DataSource = CargarComboBoxTipoDeMontos;

                cmbTipoDeMonto.SelectedValue = 0;
            }
            else if (InformacionDelError == string.Empty)
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un fallo al cargar el filtro de Tipo de cuenta");
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un fallo al cargar el filtro de Tipo de cuenta");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarFiltroUsuarios()
        {
            string InformacionDelError = string.Empty;

            ClsUsuarios Usuarios = new ClsUsuarios();

            List<Usuario> CargarComboBoxUsuarios = Usuarios.LeerListado(ClsUsuarios.ETipoListado.TodosLosUsuarios, ref InformacionDelError);

            if (CargarComboBoxUsuarios != null)
            {
                // Creo el item para listar todo
                CargarComboBoxUsuarios.Add(new Usuario { ID_Usuario = 0, Nombre = "Todos los usuarios" });

                foreach (Usuario Elemento in CargarComboBoxUsuarios)
                {
                    Elemento.Nombre += $" {Elemento.Apellido}";
                }

                // Nombre de la columna que contiene el nombre
                cmbUsuarios.DisplayMember = "Nombre";
                // Nombre de la columna que contiene el ID
                cmbUsuarios.ValueMember = "ID_Usuario";

                // Llenar el combo
                cmbUsuarios.DataSource = CargarComboBoxUsuarios;

                cmbUsuarios.SelectedValue = 0;
            }
            else if (InformacionDelError == string.Empty)
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un fallo al cargar el filtro de estados");
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un fallo al cargar el filtro de estados");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Bloquea las funcionalidades si se vencio la licencia
        /// </summary>
        public void BloquearPorVencimientoLicencia(bool _LicenciaExpirada)
        {
            btnImprimir.Enabled = !_LicenciaExpirada;
            btnAgregarRegistro.Enabled = !_LicenciaExpirada;
            dgvCaja.Enabled = !_LicenciaExpirada;
        }
        #endregion

        #region Variables
        private static FrmCaja InstanciaForm;

        /// <summary>
        /// Enumera las columnas del DGV para poder ubicarlas y editar mas facilmente su posicion.
        /// </summary>
        private enum ENumColDGVCaja
        {
            ID_Caja, ID_Pedido, Fecha, Hora, TipoCuenta, Ingreso, Egreso, Detalle, RegistroGeneradoPor
        }

        private string TextoComboMonto = string.Empty;
        #endregion

        #region Codigo para darle estilo a los botones
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            if (BotonEnFoco.Name == btnAplicarFiltro.Name || BotonEnFoco.Name == btnVerRegistrosDeHoy.Name 
                || BotonEnFoco.Name == btnImprimir.Name)
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

        private void BtnAgregarRegistro_Click(object sender, EventArgs e)
        {
            using (FrmAgregarRegistro FormAgregarRegistro = new FrmAgregarRegistro())
            {
                FormAgregarRegistro.ShowDialog();

                if (FormAgregarRegistro.DialogResult == DialogResult.OK)
                {
                    MovimientosDeHoyEnAdelante();
                }
            }
        }

        #region Filtro
        private void BtnVerRegistrosDeHoy_Click(object sender, EventArgs e) => MovimientosDeHoyEnAdelante();

        /// <summary>
        /// Lista los movimientos pendientes y sin confirmar a partir de la fecha actual.
        /// </summary>
        private void MovimientosDeHoyEnAdelante()
        {
            CargarFiltroUsuarios();

            cmbTipoDeMonto.SelectedValue = 0;
            cmbUsuarios.SelectedValue = 0;
            mtbHoraComienzo.Text = "0000";
            mtbHoraFin.Text = "2359";
            cmbTipoDeMonto.Text = "Cuentas de hoy";
            TextoComboMonto = cmbTipoDeMonto.Text;
            cmbUsuarios.Text = "Todos los usuarios";
            ckbIncluirFechaDesde.Checked = true;
            ckbIncluirFechaHasta.Checked = true;
            dtpFechaDesde.Enabled = true;
            dtpDechaHasta.Enabled = true;
            dtpFechaDesde.Value = DateTime.Today;
            dtpDechaHasta.Value = DateTime.Today;

            CargarDGVCaja(ClsCajas.ETipoListado.Filtrado);
        }

        private void BtnAplicarFiltro_Click(object sender, EventArgs e)
        {
            FrmRespuesta RespuestaFormulario;

            int ID_TipoDeMonto = 0;
            int ID_Usuario = 0;

            if (cmbTipoDeMonto.SelectedValue != null)
            {
                TipoDeMonto TipoDemontos = (TipoDeMonto)cmbTipoDeMonto.SelectedItem;
                ID_TipoDeMonto = TipoDemontos.ID_TipoDeMonto;
            }
            else
            {
                cmbTipoDeMonto.SelectedValue = 0;
            }

            if (cmbUsuarios.SelectedValue != null)
            {
                Usuario UsuarioSeleccionado = (Usuario)cmbUsuarios.SelectedItem;
                ID_Usuario = UsuarioSeleccionado.ID_Usuario;
            }
            else
            {
                cmbUsuarios.SelectedValue = 0;
            }

            if (!ckbIncluirFechaDesde.Checked && !ckbIncluirFechaHasta.Checked && ID_Usuario == 0 && ID_TipoDeMonto == 0)
            {
                RespuestaFormulario = new FrmRespuesta($"¿Estas seguro que quieres cargar la caja sin poner una 'fecha desde', 'Fecha hasta', un 'Usuario' y un 'Tipo de monto'? " +
                $"Esto podria demorar en funcion de la cantidad de datos ya que traeria todos los registros.", FrmRespuesta.ETamaño.Pequeño, FrmRespuesta.ETipo.Si_No);
            }
            else if (!ckbIncluirFechaDesde.Checked && ID_Usuario == 0 && ID_TipoDeMonto == 0)
            {
                RespuestaFormulario = new FrmRespuesta($"¿Estas seguro que quieres cargar la caja sin poner una 'fecha desde', un 'Usuario' y un 'Tipo de monto'? " +
                $"Esto podria demorar en funcion de la cantidad de datos ya que traeria todos los registros (hasta la 'fecha hasta' " +
                $"indicada).", FrmRespuesta.ETamaño.Pequeño, FrmRespuesta.ETipo.Si_No);
            }
            else
            {
                RespuestaFormulario = new FrmRespuesta();
            }

            if (RespuestaFormulario.DialogResult == DialogResult.Yes)
            {
                if (ID_TipoDeMonto == 0)
                {
                    cmbTipoDeMonto.Text = "Todos los montos";
                    TextoComboMonto = "Todos los montos";
                }

                if (ID_Usuario == 0) { cmbUsuarios.Text = "Todos los usuarios"; }

                CargarDGVCaja(ClsCajas.ETipoListado.Filtrado);
            }
        }

        private void DtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value > dtpDechaHasta.Value) { dtpDechaHasta.Value = dtpFechaDesde.Value; }
        }

        private void DtpDechaHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDechaHasta.Value < dtpFechaDesde.Value) { dtpFechaDesde.Value = dtpDechaHasta.Value; }
        }

        private void CkbIncluirFechaDesde_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbIncluirFechaDesde.Checked)
            {
                dtpFechaDesde.Enabled = true;
                mtbHoraComienzo.Enabled = true;
            }
            else
            {
                dtpFechaDesde.Enabled = false;
                mtbHoraComienzo.Enabled = false;
            }
            mtbHoraComienzo.Text = "0000";
        }

        private void CkbIncluirFechaHasta_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbIncluirFechaHasta.Checked)
            {
                dtpDechaHasta.Enabled = true;
                mtbHoraFin.Enabled = true;
            }
            else
            {
                dtpDechaHasta.Enabled = false;
                mtbHoraFin.Enabled = false;
            }
            mtbHoraFin.Text = "2359";
        }
        #endregion

        private void DgvDatosReservas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView DetectarBoton = (DataGridView)sender;

            if (!(DetectarBoton.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && e.RowIndex >= 0)
            {
                if (Convert.ToString(dgvCaja.Rows[e.RowIndex].Cells[(int)ENumColDGVCaja.ID_Pedido].Value) != string.Empty)
                {
                    using (FrmsSecundarios.FrmsTemporales.FrmCarta.MostrarPedidoFianlizado FormMostrarPedidoFianlizado = new FrmsSecundarios.FrmsTemporales.FrmCarta.MostrarPedidoFianlizado(Convert.ToInt32(dgvCaja.Rows[e.RowIndex].Cells[(int)ENumColDGVCaja.ID_Pedido].Value)))
                    {
                        FormMostrarPedidoFianlizado.ShowDialog();
                    }
                }
                else
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion($"La columna seleccionada no corresponde a un pedido y por lo tanto no se puede ver " +
                            $"ningun detalle del mismo.", ClsColores.Blanco, 200, 400))
                    {
                        FormInformacion.ShowDialog();
                    }
                }
            }
        }

        private void DtpFechaDesde_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void DtpDechaHasta_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void CargarDGVCaja(ClsCajas.ETipoListado _TipoDeListado)
        {
            if (ValidarHora(false, mtbHoraComienzo) && ValidarHora(false, mtbHoraFin))
            {
                dgvCaja.Rows.Clear();

                string InformacionDelError = string.Empty;

                // Inicio preparacion de filtros ----
                int ID_Monto = 0;
                int ID_Usuario = 0;

                if (cmbTipoDeMonto.SelectedValue != null)
                {
                    TipoDeMonto EstadoReservaSeleccionado = (TipoDeMonto)cmbTipoDeMonto.SelectedItem;
                    ID_Monto = EstadoReservaSeleccionado.ID_TipoDeMonto;
                }
                else
                {
                    cmbTipoDeMonto.SelectedValue = 0;
                }
                

                if (cmbUsuarios.SelectedValue != null)
                {
                    Usuario EstadoReservaSeleccionado = (Usuario)cmbUsuarios.SelectedItem;
                    ID_Usuario = EstadoReservaSeleccionado.ID_Usuario;
                }
                else
                {
                    cmbUsuarios.SelectedValue = 0;
                }

                string FechaDesde = Convert.ToString(dtpFechaDesde.Value.Date);
                string FechaHasta = Convert.ToString(dtpDechaHasta.Value.Date);

                if (!ckbIncluirFechaDesde.Checked) { FechaDesde = string.Empty; }
                if (!ckbIncluirFechaHasta.Checked) { FechaHasta = string.Empty; }
                // Fin preparacion de filtros ----

                ClsCajas Cajas = new ClsCajas();

                List<Caja> CargarDGVCaja = Cajas.LeerListado(_TipoDeListado, ref InformacionDelError, FechaDesde, FechaHasta, ID_Monto, ID_Usuario, mtbHoraComienzo.Text, mtbHoraFin.Text);

                if (CargarDGVCaja != null)
                {
                    double TotalIngreso = 0;
                    double TotalEgreso = 0;

                    foreach (Caja Elemento in CargarDGVCaja)
                    {
                        int NumeroDeFila = dgvCaja.Rows.Add();

                        dgvCaja.Columns[(int)ENumColDGVCaja.ID_Caja].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgvCaja.Columns[(int)ENumColDGVCaja.ID_Pedido].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgvCaja.Columns[(int)ENumColDGVCaja.Fecha].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgvCaja.Columns[(int)ENumColDGVCaja.Hora].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgvCaja.Columns[(int)ENumColDGVCaja.TipoCuenta].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgvCaja.Columns[(int)ENumColDGVCaja.Ingreso].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgvCaja.Columns[(int)ENumColDGVCaja.Egreso].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgvCaja.Columns[(int)ENumColDGVCaja.Detalle].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgvCaja.Columns[(int)ENumColDGVCaja.RegistroGeneradoPor].SortMode = DataGridViewColumnSortMode.NotSortable;

                        dgvCaja.Rows[NumeroDeFila].Cells[(int)ENumColDGVCaja.ID_Caja].Value = Elemento.ID_Caja;

                        if (Elemento.ID_Pedido == null)
                        {
                            dgvCaja.Rows[NumeroDeFila].Cells[(int)ENumColDGVCaja.ID_Pedido].Value = string.Empty;
                        }
                        else
                        {
                            dgvCaja.Rows[NumeroDeFila].Cells[(int)ENumColDGVCaja.ID_Pedido].Value = Elemento.ID_Pedido;
                        }

                        dgvCaja.Rows[NumeroDeFila].Cells[(int)ENumColDGVCaja.Fecha].Value = Elemento.Fecha.ToShortDateString();
                        dgvCaja.Rows[NumeroDeFila].Cells[(int)ENumColDGVCaja.Hora].Value = Elemento.Hora.ToString(@"hh\:mm");
                        dgvCaja.Rows[NumeroDeFila].Cells[(int)ENumColDGVCaja.TipoCuenta].Value = Elemento.TipoDeMonto.Nombre;

                        switch ((ClsTiposDeMovimientos.ETipoDeMovimientos)Elemento.TipoDeMonto.ID_TipoDeMovimiento)
                        {
                            case ClsTiposDeMovimientos.ETipoDeMovimientos.Ingreso:
                                {
                                    dgvCaja.Rows[NumeroDeFila].Cells[(int)ENumColDGVCaja.Ingreso].Value = Elemento.Monto;
                                    dgvCaja.Rows[NumeroDeFila].Cells[(int)ENumColDGVCaja.Egreso].Value = string.Empty;
                                    TotalIngreso += Elemento.Monto;
                                    break;
                                }
                            case ClsTiposDeMovimientos.ETipoDeMovimientos.Egreso:
                                {
                                    dgvCaja.Rows[NumeroDeFila].Cells[(int)ENumColDGVCaja.Ingreso].Value = string.Empty;
                                    dgvCaja.Rows[NumeroDeFila].Cells[(int)ENumColDGVCaja.Egreso].Value = Elemento.Monto;
                                    TotalEgreso += Elemento.Monto;
                                    break;
                                }
                        }

                        dgvCaja.Rows[NumeroDeFila].Cells[(int)ENumColDGVCaja.Detalle].Value = Elemento.Detalle;
                        dgvCaja.Rows[NumeroDeFila].Cells[(int)ENumColDGVCaja.RegistroGeneradoPor].Value = $"{Elemento.Usuario.Nombre} {Elemento.Usuario.Apellido}";
                    }
                    lblResultadoIngresos.Text = Convert.ToString(TotalIngreso);
                    lblResultadoEgresos.Text = Convert.ToString(TotalEgreso);
                    lblResultadoDiferencia.Text = Convert.ToString(TotalIngreso - TotalEgreso);
                }
                else if (InformacionDelError == string.Empty)
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un fallo al cargar la lista");
                }
                else
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un fallo al cargar la lista");
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Valida la hora ingresada por el usuario (retorna true si es correcta, de lo contrario false).
        /// </summary>
        /// <param name="_GuardarCambios">Si es true, evita la advertencia de que debe completar el campo HORA.</param>
        private bool ValidarHora(bool _GuardarCambios, MaskedTextBox _MtbValidar)
        {
            if (_MtbValidar.MaskCompleted)
            {
                string[] Horario = _MtbValidar.Text.Split(':');

                if (Convert.ToInt32(Horario[0]) >= 24)
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion("Ingrese una hora valida.", ClsColores.Blanco, 100, 300))
                    {
                        FormInformacion.ShowDialog();
                    }
                    return false;
                }
                else if (Convert.ToInt32(Horario[1]) >= 60)
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion("Ingrese un minuto valido.", ClsColores.Blanco, 100, 300))
                    {
                        FormInformacion.ShowDialog();
                    }
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (!_GuardarCambios)
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion("Debe completar el campo HORA.", ClsColores.Blanco, 100, 300))
                    {
                        FormInformacion.ShowDialog();
                    }
                }

                return false;
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvCaja.Rows.Count > 0)
            {
                string InformacionDelError = string.Empty;

                ClsCajas Mesas = new ClsCajas();
                List<Caja> ListarMesas = new List<Caja>();

                using (FrmReportes FormReporteMovimientos = new FrmReportes())
                {
                    // creo el data source
                    dstTablasDeDatos MiDataSource = new dstTablasDeDatos();

                    // Recorro el datagridview y lleno mi tabla del dataset
                    foreach (DataGridViewRow Elemento in dgvCaja.Rows)
                    {
                        // Creo la fila de la tabla
                        dstTablasDeDatos.DtResumenMovimientosRow ArmarReporte = MiDataSource.DtResumenMovimientos.NewDtResumenMovimientosRow();

                        // La lleno
                        ArmarReporte.Fecha = Convert.ToDateTime(Elemento.Cells["colFecha"].Value);
                        ArmarReporte.Hora = Elemento.Cells["colHora"].Value.ToString();
                        ArmarReporte.TipoDeCuenta = Elemento.Cells["ColTipoDeCuenta"].Value.ToString();
                        ArmarReporte.Ingresos = Elemento.Cells["colIngreso"].Value.ToString();
                        ArmarReporte.Egresos = Elemento.Cells["colEgreso"].Value.ToString();
                        ArmarReporte.Detalle = Elemento.Cells["colDetalle"].Value.ToString();
                        ArmarReporte.RegistroGeneradoPor = Elemento.Cells["ColNombreUsuario"].Value.ToString();

                        // Agrego la fila al data source
                        MiDataSource.DtResumenMovimientos.AddDtResumenMovimientosRow(ArmarReporte);
                    }

                    // Creo un objeto con el reporte que voy a llenar y le asigno el datasource a SU datasource
                    RptReporteMovimientos Reporte = new RptReporteMovimientos();
                    Reporte.SetDataSource(MiDataSource);

                    string FechaDesde = dtpFechaDesde.Value.ToShortDateString();
                    string FechaHasta = dtpDechaHasta.Value.ToShortDateString();

                    if (!ckbIncluirFechaDesde.Checked) { FechaDesde = "Sin fecha desde"; }
                    if (!ckbIncluirFechaHasta.Checked) { FechaHasta = "Sin fecha hasta"; }

                    string TextoTipoDeMonto = string.Empty;
                    string TextoNombreUsuario = string.Empty;

                    if (cmbTipoDeMonto.SelectedValue != null)
                    {
                        TipoDeMonto TipoDeMontoSeleccionado = (TipoDeMonto)cmbTipoDeMonto.SelectedItem;
                        TextoTipoDeMonto = TipoDeMontoSeleccionado.Nombre;

                        if (TipoDeMontoSeleccionado.ID_TipoDeMonto == 0)
                        {
                            TextoTipoDeMonto = TextoComboMonto;
                        }
                    }
                    else
                    {
                        TextoTipoDeMonto = "ERROR";
                    }

                    if (cmbUsuarios.SelectedValue != null)
                    {
                        Usuario UsuarioSeleccionado = (Usuario)cmbUsuarios.SelectedItem;
                        TextoNombreUsuario = UsuarioSeleccionado.Nombre;
                    }
                    else
                    {
                        TextoNombreUsuario = "ERROR";
                    }

                    Reporte.SetParameterValue("FechaDesde", FechaDesde);
                    Reporte.SetParameterValue("FechaHasta", FechaHasta);
                    Reporte.SetParameterValue("Usuario", TextoNombreUsuario);
                    Reporte.SetParameterValue("TipoDeMonto", TextoTipoDeMonto);

                    FormReporteMovimientos.S_ReporteMovimientos = Reporte;
                    FormReporteMovimientos.S_TipoDeReporte = FrmReportes.ETipoDeReporte.RegistrosCaja;
                    FormReporteMovimientos.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Devuelve una unica instancia del formulario (Patron singleton)
        /// </summary>
        /// <returns></returns>
        public static FrmCaja ObtenerInstancia()
        {
            if (InstanciaForm == null) { InstanciaForm = new FrmCaja(); }

            return InstanciaForm;
        }

        #region Propiedades
        #endregion
    }
}
