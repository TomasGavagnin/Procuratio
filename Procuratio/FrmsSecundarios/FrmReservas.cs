using System;
using System.Drawing;
using System.Windows.Forms;
using Negocio;
using Datos;
using System.Collections.Generic;
using System.ComponentModel;
using Procuratio.Reportes;
using Procuratio.ClsDeApoyo;
using Procuratio.FrmGenerales;
using System.Threading.Tasks;

namespace Procuratio
{
    public partial class FrmReservas : Form
    {
        #region Codigo de carga
        private FrmReservas()
        {
            InitializeComponent();
        }

        private void FrmReservas_Load(object sender, EventArgs e)
        {
            CargarFiltroEstadosReservas();
            ReservasPendientesSinConfirmar();
        }

        private void CargarFiltroEstadosReservas()
        {
            string InformacionDelError = string.Empty;

            ClsEstadoReservas EstadosReservas = new ClsEstadoReservas();

            List<EstadoReserva> CargarComboBoxEstados = EstadosReservas.LeerListado(ref InformacionDelError);

            if (CargarComboBoxEstados != null)
            {
                // Creo el item para listar todo
                CargarComboBoxEstados.Add(new EstadoReserva { ID_EstadoReserva = 0, Nombre = "Todos los estados" });

                // Nombre de la columna que contiene el nombre
                cmbEstadoReserva.DisplayMember = "Nombre";
                // Nombre de la columna que contiene el ID
                cmbEstadoReserva.ValueMember = "ID_EstadoReserva";

                // Llenar el combo
                cmbEstadoReserva.DataSource = CargarComboBoxEstados;
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
            btnEliminarElementos.Enabled = !_LicenciaExpirada;
            btnNoVino.Enabled = !_LicenciaExpirada;
            btnConfirmarReserva.Enabled = !_LicenciaExpirada;
            btnImprimir.Enabled = !_LicenciaExpirada;
            btnCrearReserva.Enabled = !_LicenciaExpirada;
            dgvDatosReservas.Enabled = !_LicenciaExpirada;
        }
        #endregion

        #region Variables
        private static FrmReservas InstanciaForm;

        /// <summary>
        /// Enumera las columnas del DGV para poder ubicarlas y editar mas facilmente su posicion.
        /// </summary>
        private enum ENumColDGVDatosReservas
        {
            ID_Reserva, ID_Cliente, Fecha, Hora, Nombre, Apellido, Telefono, Cantidad, NumerosMesas,
            Estado, Seleccionar
        }

        private const string TextoVisualBuscar = "Buscar por nombre de cliente...";
        private const int TiempoMinimoNuevaReserva = 5; //Establece cuantos minutos mas puede hacer una reserva si la realiza el
                                                        //mismo dia a una hora cerca de la actual
        List<int> ListaDeMesasReserva = new List<int>();
        private int[,] NumeroDeMesas = new int[12, 2];
        private int ID_Mozo = -1;
        private int ID_Chef = -1;
        private int ID_Reserva = -1;
        private int ID_Cliente = -1;
        private int CantidadDePersonas = -1;
        private bool IgnorarEliminadas = true;
        private bool AplicaFiltro = false;
        private string TextoCombo = string.Empty;
        private int UltimaFilaSeleccionada = -1;
        #endregion

        #region Codigo para darle estilo a los botones
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            if (BotonEnFoco.Name == btnEliminarElementos.Name)
            {
                BotonEnFoco.BackColor = ClsColores.Rojo;
            }
            else if (BotonEnFoco.Name == btnConfirmarReserva.Name)
            {
                BotonEnFoco.BackColor = ClsColores.Verde;
            }
            else if (BotonEnFoco.Name == btnVerReservas.Name || BotonEnFoco.Name == btnAplicarFiltro.Name || BotonEnFoco.Name == btnImprimir.Name)
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

        private void TxtBuscarPorNombre_Enter(object sender, EventArgs e)
        {
            if (txtBuscarPorNombre.Text == TextoVisualBuscar) { txtBuscarPorNombre.Text = string.Empty; }
            txtBuscarPorNombre.ForeColor = ClsColores.GrisClaro;
        }

        private void TxtBuscarPorNombre_Leave(object sender, EventArgs e)
        {
            if (txtBuscarPorNombre.Text == string.Empty) { txtBuscarPorNombre.Text = TextoVisualBuscar; }
            txtBuscarPorNombre.ForeColor = ClsColores.GrisOscuro;
        }
        #endregion

        #region Gestion de reservas
        private void DgvDatosReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                using (FrmMesasReservadas FormMesasReservadas = new FrmMesasReservadas((int)dgvDatosReservas.Rows[e.RowIndex].Cells[(int)ENumColDGVDatosReservas.ID_Reserva].Value, Convert.ToDateTime(dgvDatosReservas.Rows[e.RowIndex].Cells[(int)ENumColDGVDatosReservas.Fecha].Value).Date))
                {
                    FormMesasReservadas.ShowDialog();
                }
            }

            if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                if (dgvDatosReservas.Rows[e.RowIndex].Cells[(int)ENumColDGVDatosReservas.Seleccionar].Value != null)
                {
                    if (!(bool)dgvDatosReservas.Rows[e.RowIndex].Cells[(int)ENumColDGVDatosReservas.Seleccionar].Value && e.RowIndex != UltimaFilaSeleccionada)
                    {
                        ClsColores.MarcarFilaDGV(dgvDatosReservas, e.RowIndex, true);
                    }
                    else
                    {
                        ClsColores.MarcarFilaDGV(dgvDatosReservas, e.RowIndex, false);
                    }
                }

                UltimaFilaSeleccionada = e.RowIndex;
            }
        }

        public void BtnCrearReserva_Click(object sender, EventArgs e)
        {
            using (FrmAdministrarReserva FormAdministrarReserva = new FrmAdministrarReserva())
            {
                FormAdministrarReserva.ShowDialog();

                if (FormAdministrarReserva.DialogResult == DialogResult.OK)
                {
                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Reserva creada con exito";
                    ReservasPendientesSinConfirmar();
                }
            }
        }

        [Obsolete]
        private void BtnVerClientes_Click(object sender, EventArgs e)
        {
            using (FrmCliente FormCliente = new FrmCliente(FrmCliente.EMostrarOcultarColumnas.MostrarEnviar))
            {
                FormCliente.ShowDialog();
            }
        }

        private void BtnVerReservas_Click(object sender, EventArgs e) => ReservasPendientesSinConfirmar();

        /// <summary>
        /// Lista todas las reservas pendientes y sin confirmar.
        /// </summary>
        private void ReservasPendientesSinConfirmar()
        {
            txtBuscarPorNombre.Text = TextoVisualBuscar;
            cmbEstadoReserva.SelectedValue = 0;
            cmbEstadoReserva.Text = "Pendientes y sin confirmar";
            TextoCombo = "Pendientes y sin confirmar";
            ckbIncluirFechaDesde.Checked = true;
            ckbIncluirFechaHasta.Checked = false;
            dtpFechaDesde.Enabled = true;
            dtpDechaHasta.Enabled = false;
            dtpFechaDesde.Value = DateTime.Today.AddDays(-1);
            dtpDechaHasta.Value = DateTime.Today;
            AplicaFiltro = true;
            IgnorarEliminadas = true;
            
            CargarDGVReservas(ClsReservas.ETipoDeFiltro.Filtro);
        }

        private void DgvDatosReservas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (!(DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && !(DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn) && e.RowIndex >= 0)
            {
                string InformacionDelError = string.Empty;

                ClsReservas Reservas = new ClsReservas();
                Reserva ComprobarEstado = Reservas.LeerPorNumero((int)dgvDatosReservas.Rows[e.RowIndex].Cells[(int)ENumColDGVDatosReservas.ID_Reserva].Value, ref InformacionDelError);

                if (ComprobarEstado != null)
                {
                    if (ComprobarEstado.ID_EstadoReserva != (int)ClsEstadoReservas.EEstadosReservas.Eliminada)
                    {
                        bool PuedeEditar = true;

                        // La fecha es menor o igual a la actual
                        if (Convert.ToDateTime(dgvDatosReservas.Rows[e.RowIndex].Cells[(int)ENumColDGVDatosReservas.Fecha].Value).Date <= DateTime.Today.Date)
                        {
                            PuedeEditar = false;

                            // Si la reserva es el dia actual y la hora es menor a la actual tambien, anular la edicion, pero, si la fecha
                            // es igual a la actual, permitir la edicion (la hora no expiro)
                            if (Convert.ToDateTime(dgvDatosReservas.Rows[e.RowIndex].Cells[(int)ENumColDGVDatosReservas.Fecha].Value).Date == DateTime.Today.Date && TimeSpan.Parse(dgvDatosReservas.Rows[e.RowIndex].Cells[(int)ENumColDGVDatosReservas.Hora].Value.ToString()) < TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss")))
                            {
                                PuedeEditar = false;
                            }
                            else if (Convert.ToDateTime(dgvDatosReservas.Rows[e.RowIndex].Cells[(int)ENumColDGVDatosReservas.Fecha].Value).Date == DateTime.Today.Date)
                            {
                                // Puede editar ya que el dia es igual, al actual, pero la hora no se cumplio
                                PuedeEditar = true;
                            }
                        }

                        if (PuedeEditar && ComprobarEstado.ID_EstadoReserva != (int)ClsEstadoReservas.EEstadosReservas.Completada && ComprobarEstado.ID_EstadoReserva != (int)ClsEstadoReservas.EEstadosReservas.NoVino)
                        {
                            ClsMesasXReservas Mesas = new ClsMesasXReservas();

                            List<MesaXReserva> ListarMesasReservadas = Mesas.LeerListado(ClsMesasXReservas.EMesasDisponibles.MesasReservadas, ref InformacionDelError, Convert.ToDateTime(dgvDatosReservas.Rows[e.RowIndex].Cells[(int)ENumColDGVDatosReservas.Fecha].Value).Date, (int)dgvDatosReservas.Rows[e.RowIndex].Cells[(int)ENumColDGVDatosReservas.ID_Reserva].Value);

                            if (ListarMesasReservadas != null)
                            {
                                List<int> DarFormatoNumero = new List<int>();
                                List<int> DarFormatoIDMesa = new List<int>();

                                foreach (MesaXReserva Elemento in ListarMesasReservadas)
                                {
                                    DarFormatoIDMesa.Add(Elemento.Mesa.ID_Mesa);
                                    DarFormatoNumero.Add(Elemento.Mesa.Numero);
                                }

                                using (FrmAdministrarReserva FormEditarReserva = new FrmAdministrarReserva((int)dgvDatosReservas.Rows[e.RowIndex].Cells[(int)ENumColDGVDatosReservas.ID_Reserva].Value,
                                    (int)dgvDatosReservas.Rows[e.RowIndex].Cells[(int)ENumColDGVDatosReservas.ID_Cliente].Value, DarFormatoIDMesa, DarFormatoNumero))
                                {
                                    FormEditarReserva.ShowDialog();

                                    if (FormEditarReserva.DialogResult == DialogResult.OK)
                                    {
                                        FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Reserva actualizada con exito";
                                        ReservasPendientesSinConfirmar();
                                    }
                                }
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
                        else
                        {
                            FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Operacion invalida";
                            using (FrmInformacion FormInformacion = new FrmInformacion("No puede editar una reserva que expiro o se confirmo su estado.", ClsColores.Blanco, 150, 300))
                            {
                                FormInformacion.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Operacion invalida";
                        using (FrmInformacion FormInformacion = new FrmInformacion("No puede editar o cambiarle el estado a una reserva eliminada.", ClsColores.Blanco, 150, 300))
                        {
                            FormInformacion.ShowDialog();
                        }
                    }
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
        }

        private void BtnNoVino_Click(object sender, EventArgs e)
        {
            ClsReservas Reserva = new ClsReservas();
            Reserva NoVino = new Reserva();

            int TotalDeFilas = dgvDatosReservas.Rows.Count;

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                //Pregunto si la celda es diferente a null
                if (dgvDatosReservas.Rows[Indice].Cells[(int)ENumColDGVDatosReservas.Seleccionar].Value != null)
                {
                    //Casteo el check del objeto a booleano y pregunto si es true
                    if ((bool)dgvDatosReservas.Rows[Indice].Cells[(int)ENumColDGVDatosReservas.Seleccionar].Value)
                    {
                        string InformacionDelError = string.Empty;

                        NoVino = Reserva.LeerPorNumero((int)dgvDatosReservas.Rows[Indice].Cells[(int)ENumColDGVDatosReservas.ID_Reserva].Value, ref InformacionDelError);

                        if (NoVino != null)
                        {
                            if (NoVino.ID_EstadoReserva != (int)ClsEstadoReservas.EEstadosReservas.NoVino)
                            {
                                bool FechaHoraCumplida = false;

                                // Permitirle confirmarla si falta 1 hora o menos para que se cumpla la reserva
                                if (NoVino.Fecha.Date == DateTime.Today.Date && NoVino.Hora <= TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss")))
                                {
                                    FechaHoraCumplida = true;
                                }

                                if (NoVino.Fecha.Date < DateTime.Today.Date || FechaHoraCumplida && (NoVino.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.Pendiente || NoVino.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.SinConfirmar) && NoVino.ID_EstadoReserva != (int)ClsEstadoReservas.EEstadosReservas.Completada)
                                {
                                    NoVino.ID_EstadoReserva = (int)ClsEstadoReservas.EEstadosReservas.NoVino;

                                    if (Reserva.Actualizar(NoVino, ref InformacionDelError) != 0)
                                    {
                                        dgvDatosReservas.Rows.Remove(dgvDatosReservas.Rows[Indice]);
                                        Indice -= 1;
                                        TotalDeFilas -= 1;
                                    }
                                    else if (InformacionDelError != string.Empty)
                                    {
                                        FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Error al intentar confirmar la reserva";
                                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else if (!(NoVino.Fecha.Date <= DateTime.Today.Date))
                                {
                                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Operacion invalida";
                                    using (FrmInformacion FormInformacion = new FrmInformacion($"No puede indicar que el cliente de la reserva con fecha {NoVino.Fecha.Date.ToShortDateString()} a las " +
                                            $"{NoVino.Hora.ToString(@"hh\:mm")}, con nombre {NoVino.Cliente.Nombre} {NoVino.Cliente.Apellido} " +
                                            $"no vino (se puede " +
                                            $"indicar el dia que esta asignada o despues).", ClsColores.Blanco, 200, 400))
                                    {
                                        FormInformacion.ShowDialog();
                                    }
                                }
                                else if (NoVino.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.Completada)
                                {
                                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Operacion invalida";
                                    using (FrmInformacion FormInformacion = new FrmInformacion($"No puede indicar que el cliente de la reserva con fecha {NoVino.Fecha.Date.ToShortDateString()} a las " +
                                            $"{NoVino.Hora.ToString(@"hh\:mm")}, con nombre {NoVino.Cliente.Nombre} {NoVino.Cliente.Apellido} " +
                                            $"no vino, debido a que ya se la confirmo como completada.", ClsColores.Blanco, 200, 400))
                                    {
                                        FormInformacion.ShowDialog();
                                    }
                                }
                                else
                                {
                                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Operacion invalida";
                                    using (FrmInformacion FormInformacion = new FrmInformacion("No puede editar o cambiarle el estado a una reserva eliminada.", ClsColores.Blanco, 150, 300))
                                    {
                                        FormInformacion.ShowDialog();
                                    }
                                }
                            }
                        }
                        else if (InformacionDelError == string.Empty)
                        {
                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar confirmar la reserva");
                        }
                        else
                        {
                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar confirmar la reserva");
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void BtnEliminarElementos_Click(object sender, EventArgs e)
        {
            ClsReservas Reserva = new ClsReservas();
            Reserva EliminarReserva = new Reserva();

            int TotalDeFilas = dgvDatosReservas.Rows.Count;

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                //Pregunto si la celda es diferente a null
                if (dgvDatosReservas.Rows[Indice].Cells[(int)ENumColDGVDatosReservas.Seleccionar].Value != null)
                {
                    //Casteo el check del objeto a booleano y pregunto si es true
                    if ((bool)dgvDatosReservas.Rows[Indice].Cells[(int)ENumColDGVDatosReservas.Seleccionar].Value)
                    {
                        string InformacionDelError = string.Empty;

                        EliminarReserva = Reserva.LeerPorNumero((int)dgvDatosReservas.Rows[Indice].Cells[(int)ENumColDGVDatosReservas.ID_Reserva].Value, ref InformacionDelError);

                        if (EliminarReserva.ID_EstadoReserva != (int)ClsEstadoReservas.EEstadosReservas.Completada && EliminarReserva.ID_EstadoReserva != (int)ClsEstadoReservas.EEstadosReservas.NoVino && EliminarReserva.ID_EstadoReserva != (int)ClsEstadoReservas.EEstadosReservas.Eliminada)
                        {
                            EliminarReserva.ID_EstadoReserva = (int)ClsEstadoReservas.EEstadosReservas.Eliminada;

                            if (Reserva.Actualizar(EliminarReserva, ref InformacionDelError) != 0)
                            {
                                dgvDatosReservas.Rows.Remove(dgvDatosReservas.Rows[Indice]);
                                Indice -= 1;
                                TotalDeFilas -= 1;
                            }
                            else if (InformacionDelError != string.Empty)
                            {
                                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar eliminar la reserva");
                                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else if (EliminarReserva.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.Completada || EliminarReserva.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.NoVino)
                        {
                            FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Operacion invalida";

                            using (FrmInformacion FormInformacion = new FrmInformacion($"No puede eliminar la reserva con fecha {EliminarReserva.Fecha.Date.ToShortDateString()} a las " +
                                    $"{EliminarReserva.Hora.ToString(@"hh\:mm")}, del cliente {EliminarReserva.Cliente.Nombre} {EliminarReserva.Cliente.Apellido} " +
                                    $"ya que esta tiene un estado final (que no se puede borrar).", ClsColores.Blanco, 200, 400))
                            {
                                FormInformacion.ShowDialog();
                            }
                        }
                        else
                        {
                            FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Operacion invalida";
                            using (FrmInformacion FormInformacion = new FrmInformacion("No puede editar o cambiarle el estado a una reserva eliminada.", ClsColores.Blanco, 150, 300))
                            {
                                FormInformacion.ShowDialog();
                            }
                        }
                    }
                }
            }
        }

        private void BtnConfirmarReserva_Click(object sender, EventArgs e)
        {
            ClsReservas Reservas = new ClsReservas();
            Reserva ConfirmarReseva = new Reserva();

            int TotalDeFilas = dgvDatosReservas.Rows.Count;

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                //Pregunto si la celda es diferente a null
                if (dgvDatosReservas.Rows[Indice].Cells[(int)ENumColDGVDatosReservas.Seleccionar].Value != null)
                {
                    //Casteo el check del objeto a booleano y pregunto si es true
                    if ((bool)dgvDatosReservas.Rows[Indice].Cells[(int)ENumColDGVDatosReservas.Seleccionar].Value)
                    {
                        string InformacionDelError = string.Empty;

                        ConfirmarReseva = Reservas.LeerPorNumero((int)dgvDatosReservas.Rows[Indice].Cells[(int)ENumColDGVDatosReservas.ID_Reserva].Value, ref InformacionDelError);

                        if (ConfirmarReseva != null)
                        {
                            // Por true = No puede completar de "no vino" a "completada" si  paso mas de dos // Por false = Continua
                            if (ConfirmarReseva.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.NoVino && ConfirmarReseva.Fecha.Date.AddDays(2) <= DateTime.Today.Date)
                            {
                                FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Operacion invalida";
                                using (FrmInformacion FormInformacion = new FrmInformacion($"No puede indicar que el cliente de la reserva con fecha {ConfirmarReseva.Fecha.Date.ToShortDateString()} a las " +
                                        $"{ConfirmarReseva.Hora.ToString(@"hh\:mm")}, con nombre {ConfirmarReseva.Cliente.Nombre} {ConfirmarReseva.Cliente.Apellido} " +
                                        $"es una reserva completada ya que supero dos dias desde la fecha en que le indico el estado de 'no vino'.", ClsColores.Blanco, 200, 400))
                                {
                                    FormInformacion.ShowDialog();
                                }
                            }
                            else if (ConfirmarReseva.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.Eliminada)
                            {
                                FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Operacion invalida";
                                using (FrmInformacion FormInformacion = new FrmInformacion("No puede editar o cambiarle el estado a una reserva eliminada.", ClsColores.Blanco, 150, 300))
                                {
                                    FormInformacion.ShowDialog();
                                }
                            }
                            else
                            {
                                // Por true = Continua // Por false = Falta mas de un dia (o mas de 1 hora) para que se complete o ya fue confirmada
                                if (ConfirmarReseva.ID_EstadoReserva != (int)ClsEstadoReservas.EEstadosReservas.Completada && ConfirmarReseva.Fecha.Date <= DateTime.Today.Date)
                                {
                                    bool FaltaMasDeUnaHota = false;

                                    // Permitirle confirmarla si falta 1 hora o menos para que se cumpla la reserva
                                    if (ConfirmarReseva.Fecha.Date == DateTime.Today.Date && ConfirmarReseva.Hora > TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss")).Add(TimeSpan.Parse("01:00:00")))
                                    {
                                        FaltaMasDeUnaHota = true;
                                    }

                                    if (!FaltaMasDeUnaHota)
                                    {
                                        ConfirmarReseva.ID_EstadoReserva = (int)ClsEstadoReservas.EEstadosReservas.Completada;

                                        // Crear mesa si la hora en la que se cumplio la reserva es menor a 2 horas, superado ese tiempo, marcarla como confirmada pero 
                                        // no crear la mesa.
                                        if (ConfirmarReseva.Fecha.Date > DateTime.Today.Date || (ConfirmarReseva.Fecha.Date == DateTime.Today.Date && ConfirmarReseva.Hora.Add(TimeSpan.Parse("02:00:00")) > TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss"))))
                                        {
                                            // Verificar que las mesas no esten ocupadas o eliminadas
                                            ClsMesasXReservas MesasXReserva = new ClsMesasXReservas();
                                            List<MesaXReserva> ListarMesas = MesasXReserva.LeerListado(ClsMesasXReservas.EMesasDisponibles.MesasReservadas, ref InformacionDelError, Convert.ToDateTime(dgvDatosReservas.Rows[Indice].Cells[(int)ENumColDGVDatosReservas.Fecha].Value).Date, (int)dgvDatosReservas.Rows[Indice].Cells[(int)ENumColDGVDatosReservas.ID_Reserva].Value);

                                            ClsMesas Mesas = new ClsMesas();
                                            List<Mesa> BuscarMesaOcupada = Mesas.LeerListado(ClsMesas.ETipoDeListado.Todo, ref InformacionDelError);

                                            if (ListarMesas != null && BuscarMesaOcupada != null)
                                            {
                                                bool MesaOcupadaEliminada = false;
                                                int IndiceArray = 0;
                                                LimpiarArrayMesas();

                                                foreach (MesaXReserva MesaAOcupar in ListarMesas)
                                                {
                                                    foreach (Mesa LaMesaEstaOcupada in BuscarMesaOcupada)
                                                    {
                                                        if (LaMesaEstaOcupada.ID_Mesa == MesaAOcupar.ID_Mesa && (LaMesaEstaOcupada.ID_EstadoMesa == (int)ClsEstadosMesas.EEstadosMesas.Ocupada || LaMesaEstaOcupada.ID_EstadoMesa == (int)ClsEstadosMesas.EEstadosMesas.Inactivo))
                                                        {
                                                            MesaOcupadaEliminada = true;
                                                        }
                                                    }

                                                    // Cargo el ID.
                                                    NumeroDeMesas[IndiceArray, 0] = MesaAOcupar.Mesa.ID_Mesa;
                                                    // Cargo el numero
                                                    NumeroDeMesas[IndiceArray, 1] = MesaAOcupar.Mesa.Numero;

                                                    IndiceArray++;
                                                }

                                                if (!MesaOcupadaEliminada)
                                                {
                                                    ID_Mozo = -1;
                                                    ID_Chef = -1;
                                                    ID_Reserva = -1;
                                                    ID_Cliente = -1;

                                                    using (FrmTrabajadoresReserva FormTrabajadoresReserva = new FrmTrabajadoresReserva())
                                                    {
                                                        FormTrabajadoresReserva.ShowDialog();

                                                        if (FormTrabajadoresReserva.DialogResult == DialogResult.OK && ID_Mozo != -1 && ID_Chef != -1)
                                                        {
                                                            if (Reservas.Actualizar(ConfirmarReseva, ref InformacionDelError) != 0)
                                                            {
                                                                ID_Reserva = ConfirmarReseva.ID_Reserva;
                                                                ID_Cliente = ConfirmarReseva.ID_Cliente;
                                                                
                                                                CantidadDePersonas = ConfirmarReseva.CantidadPersonas;
                                                                CrearMesaReserva();

                                                                dgvDatosReservas.Rows.Remove(dgvDatosReservas.Rows[Indice]);
                                                                Indice -= 1;
                                                                TotalDeFilas -= 1;
                                                            }
                                                            else if (InformacionDelError == string.Empty)
                                                            {
                                                                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar confirmar la reserva");
                                                            }
                                                            else
                                                            {
                                                                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar confirmar la reserva");
                                                                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Operacion invalida";
                                                            using (FrmInformacion FormInformacion = new FrmInformacion($"No selecciono ningun mozo o chef, confirmacion de la reserva cancelada.", ClsColores.Blanco, 200, 400))
                                                            {
                                                                FormInformacion.ShowDialog();
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Operacion invalida";
                                                    using (FrmInformacion FormInformacion = new FrmInformacion($"No puede confirmar la reserva con fecha {ConfirmarReseva.Fecha.Date.ToShortDateString()} a las " +
                                                            $"{ConfirmarReseva.Hora.ToString(@"hh\:mm")}, del cliente {ConfirmarReseva.Cliente.Nombre} {ConfirmarReseva.Cliente.Apellido} " +
                                                            $"ya que se detecto que alguna de las mesas que usa la reserva esta ocupada en este momento (o fue eliminada).", ClsColores.Blanco, 200, 400))
                                                    {
                                                        FormInformacion.ShowDialog();
                                                    }
                                                }
                                            }
                                            else if (InformacionDelError == string.Empty)
                                            {
                                                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar confirmar la reserva");
                                            }
                                            else
                                            {
                                                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar confirmar la reserva");
                                                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            if (Reservas.Actualizar(ConfirmarReseva, ref InformacionDelError) != 0)
                                            {
                                                dgvDatosReservas.Rows.Remove(dgvDatosReservas.Rows[Indice]);
                                                Indice -= 1;
                                                TotalDeFilas -= 1;

                                                using (FrmInformacion FormInformacion = new FrmInformacion($"La reserva con fecha {ConfirmarReseva.Fecha.Date.ToShortDateString()} a las " +
                                                        $"{ConfirmarReseva.Hora.ToString(@"hh\:mm")}, del cliente {ConfirmarReseva.Cliente.Nombre} {ConfirmarReseva.Cliente.Apellido} " +
                                                        $"se actualizo como confirmada, pero no se creara la mesa debido a que la fecha en que se cumplio supero las 2 horas de espera de confirmacion " +
                                                        $"(que comienza cuando se completa el dia y la hora).", ClsColores.Blanco, 200, 400))
                                                {
                                                    FormInformacion.ShowDialog();
                                                }
                                            }
                                            else if (InformacionDelError == string.Empty)
                                            {
                                                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar confirmar la reserva");
                                            }
                                            else
                                            {
                                                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar confirmar la reserva");
                                                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Operacion invalida";
                                        using (FrmInformacion FormInformacion = new FrmInformacion($"Las reservas se pueden confirmar cuando falte menos de 1 hora para que se cumplan.", ClsColores.Blanco, 200, 400))
                                        {
                                            FormInformacion.ShowDialog();
                                        }
                                    }
                                }
                                else if (!(ConfirmarReseva.Fecha.Date <= DateTime.Today.Date))
                                {
                                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Operacion invalida";
                                    using (FrmInformacion FormInformacion = new FrmInformacion($"No puede confirmar la reserva con fecha {ConfirmarReseva.Fecha.Date.ToShortDateString()} a las " +
                                            $"{ConfirmarReseva.Hora.ToString(@"hh\:mm")}, del cliente {ConfirmarReseva.Cliente.Nombre} {ConfirmarReseva.Cliente.Apellido} " +
                                            $"ya que esta es mayor al dia actual (se puede " +
                                            $"confirmar el dia que esta asignada o despues).", ClsColores.Blanco, 200, 400))
                                    {
                                        FormInformacion.ShowDialog();
                                    }
                                }
                                else
                                {
                                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Operacion invalida";
                                    using (FrmInformacion FormInformacion = new FrmInformacion($"No puede confirmar la reserva con fecha {ConfirmarReseva.Fecha.Date.ToShortDateString()} a las " +
                                            $"{ConfirmarReseva.Hora.ToString(@"hh\:mm")} del cliente {ConfirmarReseva.Cliente.Nombre} {ConfirmarReseva.Cliente.Apellido} " +
                                            $"porque ya fue confirmada.", ClsColores.Blanco, 200, 400))
                                    {
                                        FormInformacion.ShowDialog();
                                    }
                                }
                            }
                        }
                        else if (InformacionDelError == string.Empty)
                        {
                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar confirmar la reserva");
                        }
                        else
                        {
                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar confirmar la reserva");
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        /// <summary>Crea las mesas segun los datos de la reserva.</summary>
        private void CrearMesaReserva()
        {
            OcuparMesas();
            CrearPedido();
        }

        private void OcuparMesas()
        {
            string InformacionDelError = string.Empty;

            ClsMesas Mesas = new ClsMesas();
            Mesa OcuparMesa = new Mesa();

            // Cambiar el estado a ocupadas.
            int TotalFilas = NumeroDeMesas.GetLength(0);

            // TODO - Asignar cada mesa a un pedido con un foreach y el id del usuario a las mesas?
            for (int Indice = 0; Indice < TotalFilas; Indice++)
            {
                // No hay mas mesas, salgo del ciclo
                if (NumeroDeMesas[Indice, 0] == 0) { break; }

                // Busco la mesa por su ID
                OcuparMesa = Mesas.LeerPorNumero(NumeroDeMesas[Indice, 0], ClsMesas.ETipoDeListado.PorID, ref InformacionDelError);
                // Le pongo estado ocupada y la actualizo
                OcuparMesa.ID_EstadoMesa = (int)ClsEstadosMesas.EEstadosMesas.Ocupada;
                OcuparMesa.ID_Usuario = ID_Mozo;
                Mesas.Actualizar(OcuparMesa, ref InformacionDelError);
            }
        }

        private void CrearPedido()
        {
            string InformacionDelError = string.Empty;

            ClsPedidos Pedidos = new ClsPedidos();
            Pedido CrearPedido = new Pedido();

            CrearPedido.Fecha = DateTime.Today.Date;
            CrearPedido.Hora = TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss"));
            CrearPedido.CantidadPersonas = CantidadDePersonas;
            CrearPedido.TotalPedido = 0;
            CrearPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.Pendiente;
            CrearPedido.ID_Cliente = ID_Cliente;
            CrearPedido.ID_Reserva = ID_Reserva;
            CrearPedido.Nota = string.Empty;
            CrearPedido.ID_Chef = ID_Chef;
            CrearPedido.TiempoEspera = null;
            CrearPedido.ID_Mozo = ID_Mozo;

            if (Pedidos.Crear(CrearPedido, ref InformacionDelError) != 0)
            {
                int TotalFilas = NumeroDeMesas.GetLength(0);

                ClsPedidosXMesas PedidosXMesa = new ClsPedidosXMesas();
                PedidoXMesa CrearPedidoXMesa = new PedidoXMesa();

                for (int I = 0; I < TotalFilas; I++)
                {
                    CrearPedidoXMesa.ID_Mesa = NumeroDeMesas[I, 0];
                    CrearPedidoXMesa.ID_Pedido = CrearPedido.ID_Pedido;
                    PedidosXMesa.Crear(CrearPedidoXMesa, ref InformacionDelError);
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al intentar crear el pedido");
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al intentar crear el pedido");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarArrayMesas()
        {
            int TotalFilas = NumeroDeMesas.GetLength(0);

            for (int I = 0; I < TotalFilas; I++)
            {
                for (int J = 0; J < NumeroDeMesas.Rank; J++)
                {
                    NumeroDeMesas[I, J] = 0;
                }
            }
        }
        #endregion

        #region Filtros
        private void BtnAplicarFiltro_Click(object sender, EventArgs e)
        {
            FrmRespuesta ResultadoFormulario = null;

            int ID_EstadoReserva = 0;

            if (cmbEstadoReserva.SelectedValue != null)
            {
                EstadoReserva EstadoReservaSeleccionado = (EstadoReserva)cmbEstadoReserva.SelectedItem;
                ID_EstadoReserva = EstadoReservaSeleccionado.ID_EstadoReserva;
            }

            if (!ckbIncluirFechaDesde.Checked && !ckbIncluirFechaHasta.Checked && txtBuscarPorNombre.Text == TextoVisualBuscar && ID_EstadoReserva == 0)
            {
                ResultadoFormulario = new FrmRespuesta($"¿Estas seguro que quieres cargar las reservas sin poner una 'fecha desde', una 'fecha hasta', un 'nombre' y un 'estado de reserva'? " +
                $"Esto podria demorar en funcion de la cantidad de datos ya que traeria todos los registros.", FrmRespuesta.ETamaño.Pequeño, FrmRespuesta.ETipo.Si_No);
            }
            else if (!ckbIncluirFechaDesde.Checked && txtBuscarPorNombre.Text == TextoVisualBuscar && ID_EstadoReserva == 0)
            {
                ResultadoFormulario = new FrmRespuesta($"¿Estas seguro que quieres cargar las reservas sin poner una 'fecha desde', un 'nombre' y un 'estado de reserva'? " +
                $"Esto podria demorar en funcion de la cantidad de datos ya que traeria todos los registros (hasta la 'fecha hasta' " +
                $"indicada).", FrmRespuesta.ETamaño.Pequeño, FrmRespuesta.ETipo.Si_No_Cancelar);
            }
            else
            {
                ResultadoFormulario = new FrmRespuesta();
            }

            if (ResultadoFormulario.DialogResult == DialogResult.Yes)
            {
                if (ID_EstadoReserva == 0)
                {
                    cmbEstadoReserva.Text = "Todos los estados";
                    TextoCombo = "Todos los estados";
                }

                btnAplicarFiltro.Enabled = false;
                btnVerReservas.Enabled = false;
                btnImprimir.Enabled = false;

                IgnorarEliminadas = false;
                CargarDGVReservas(ClsReservas.ETipoDeFiltro.Filtro);

                btnAplicarFiltro.Enabled = true;
                btnVerReservas.Enabled = true;
                btnImprimir.Enabled = true;
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

        private void CkbIncluirFechaDesde_CheckedChanged(object sender, EventArgs e) => dtpFechaDesde.Enabled = ckbIncluirFechaDesde.Checked ? true : false;

        private void CkbIncluirFechaHasta_CheckedChanged(object sender, EventArgs e) => dtpDechaHasta.Enabled = ckbIncluirFechaHasta.Checked ? true : false;
        #endregion

        private void CargarDGVReservas(ClsReservas.ETipoDeFiltro _TipoDeListado)
        {
            dgvDatosReservas.Rows.Clear();
            ActualizarReservasExpiradas();

            string InformacionDelError = string.Empty;

            // Inicio preparacion de filtros ----
            string NombreCliente = string.Empty;

            int ID_EstadoReserva = 0;

            if (cmbEstadoReserva.SelectedValue != null)
            {
                EstadoReserva EstadoReservaSeleccionado = (EstadoReserva)cmbEstadoReserva.SelectedItem;
                ID_EstadoReserva = EstadoReservaSeleccionado.ID_EstadoReserva;
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Fallo al intentar leer un filtro";
                MessageBox.Show($"Ocurrio un fallo al intentar leer el estado de la reserva para el filtro, no se tendra " +
                    $"en cuenta este filtro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtBuscarPorNombre.Text != TextoVisualBuscar) { NombreCliente = txtBuscarPorNombre.Text; }

            string FechaDesde = Convert.ToString(dtpFechaDesde.Value.Date);
            string FechaHasta = Convert.ToString(dtpDechaHasta.Value.Date);

            if (!ckbIncluirFechaDesde.Checked) { FechaDesde = string.Empty; }
            if (!ckbIncluirFechaHasta.Checked) { FechaHasta = string.Empty; }
            // Fin preparacion de filtros ----

            ClsReservas Reservas = new ClsReservas();

            List<Reserva> CargarDGVReserva = Reservas.LeerListado(_TipoDeListado, ref InformacionDelError, FechaDesde, FechaHasta, NombreCliente, ID_EstadoReserva, AplicaFiltro);

            if (CargarDGVReserva != null)
            {
                foreach (Reserva Elemento in CargarDGVReserva)
                {
                    bool Mostrar = true;

                    if (IgnorarEliminadas && Elemento.ID_EstadoReserva == (int)ClsEstadoReservas.EEstadosReservas.Eliminada)
                    {
                        Mostrar = false;
                    }

                    if (Mostrar)
                    {
                        int NumeroDeFila = dgvDatosReservas.Rows.Add();

                        dgvDatosReservas.Rows[NumeroDeFila].Cells[(int)ENumColDGVDatosReservas.ID_Reserva].Value = Elemento.ID_Reserva;
                        dgvDatosReservas.Rows[NumeroDeFila].Cells[(int)ENumColDGVDatosReservas.ID_Cliente].Value = Elemento.ID_Cliente;
                        dgvDatosReservas.Rows[NumeroDeFila].Cells[(int)ENumColDGVDatosReservas.Fecha].Value = Elemento.Fecha.ToShortDateString();
                        dgvDatosReservas.Rows[NumeroDeFila].Cells[(int)ENumColDGVDatosReservas.Hora].Value = Elemento.Hora.ToString(@"hh\:mm");
                        dgvDatosReservas.Rows[NumeroDeFila].Cells[(int)ENumColDGVDatosReservas.Nombre].Value = Elemento.Cliente.Nombre;
                        dgvDatosReservas.Rows[NumeroDeFila].Cells[(int)ENumColDGVDatosReservas.Apellido].Value = Elemento.Cliente.Apellido;
                        dgvDatosReservas.Rows[NumeroDeFila].Cells[(int)ENumColDGVDatosReservas.Telefono].Value = Convert.ToString(Elemento.Cliente.Telefono);
                        dgvDatosReservas.Rows[NumeroDeFila].Cells[(int)ENumColDGVDatosReservas.Cantidad].Value = Elemento.CantidadPersonas;
                        dgvDatosReservas.Rows[NumeroDeFila].Cells[(int)ENumColDGVDatosReservas.NumerosMesas].Value = "Ver";
                        dgvDatosReservas.Rows[NumeroDeFila].Cells[(int)ENumColDGVDatosReservas.Estado].Value = Elemento.EstadoReserva.Nombre;
                        dgvDatosReservas.Rows[NumeroDeFila].Cells[(int)ENumColDGVDatosReservas.Seleccionar].Value = false;
                    }

                    UltimaFilaSeleccionada = -1;
                }
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

            AplicaFiltro = false;

            dgvDatosReservas.ClearSelection();
        }

        /// <summary>
        /// Busca reservas cuya fecha y hora sean menor a la actual para actualizar su estado a sin confirmar
        /// </summary>
        private void ActualizarReservasExpiradas()
        {
            string InformacionDelError = string.Empty;

            ClsReservas Reservas = new ClsReservas();
            List<Reserva> ActualizarEstado = Reservas.LeerListado(ClsReservas.ETipoDeFiltro.ReservasExpiradas, ref InformacionDelError);

            if (ActualizarEstado != null)
            {
                foreach (Reserva Elemento in ActualizarEstado)
                {
                    // Si entra el if, es porque la fecha es menor a la actual. Si entra a la pregunta del else, es para determinar si la hora
                    // tambien es menor a la actual, en ese caso, tanto el dia como la hora corresponden a una reserva expirada, de no ser asi
                    // la hora en la que expira todavia no se cumplio (pero si esta en el dia en que lo hará).
                    if (Elemento.Fecha.Date < DateTime.Today.Date)
                    {
                        Elemento.ID_EstadoReserva = (int)ClsEstadoReservas.EEstadosReservas.SinConfirmar;
                        Reservas.Actualizar(Elemento, ref InformacionDelError);
                    }
                    else if (Elemento.Hora <= TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss")))
                    {
                        Elemento.ID_EstadoReserva = (int)ClsEstadoReservas.EEstadosReservas.SinConfirmar;
                        Reservas.Actualizar(Elemento, ref InformacionDelError);
                    }
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un fallo al actualizar las reservas");
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un fallo al actualizar las reservas");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        [Obsolete]
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvDatosReservas.Rows.Count > 0)
            {
                string InformacionDelError = string.Empty;

                ClsMesasXReservas Mesas = new ClsMesasXReservas();
                List<MesaXReserva> ListaMesas = new List<MesaXReserva>();

                using (FrmReportes FormReporteResumenPedido = new FrmReportes())
                {
                    // creo el data source
                    dstTablasDeDatos MiDataSource = new dstTablasDeDatos();

                    // Recorro el datagridview y lleno mi tabla del dataset
                    foreach (DataGridViewRow Elemento in dgvDatosReservas.Rows)
                    {
                        // Creo la fila de la tabla
                        dstTablasDeDatos.DtResumenReservasRow ArmarReporte = MiDataSource.DtResumenReservas.NewDtResumenReservasRow();

                        // La lleno
                        ArmarReporte.ID_Reserva = Convert.ToInt32(Elemento.Cells["colID_Reserva"].Value);
                        ArmarReporte.ID_Cliente = Convert.ToInt32(Elemento.Cells["colID_Cliente"].Value);
                        ArmarReporte.Fecha = Convert.ToDateTime(Elemento.Cells["colFecha"].Value);
                        ArmarReporte.Hora = Elemento.Cells["colHora"].Value.ToString();
                        ArmarReporte.Nombre = Elemento.Cells["colNombre"].Value.ToString();
                        ArmarReporte.Apellido = Elemento.Cells["colApellido"].Value.ToString();
                        ArmarReporte.Telefono = Elemento.Cells["colTelefono"].Value.ToString();
                        ArmarReporte.Cantidad = Elemento.Cells["colCantidadDePersonas"].Value.ToString();

                        InformacionDelError = string.Empty;

                        ListaMesas = Mesas.LeerListado(ClsMesasXReservas.EMesasDisponibles.MesasReservadas, ref InformacionDelError, Convert.ToDateTime(Elemento.Cells["colFecha"].Value).Date, (int)Elemento.Cells["colID_Reserva"].Value);

                        if (ListaMesas != null)
                        {
                            string ArmarMesas = string.Empty;

                            foreach (MesaXReserva ElementoSecundario in ListaMesas)
                            {
                                ArmarMesas += ElementoSecundario.Mesa.Numero + "-";
                            }
                            ArmarReporte.Mesas = ArmarMesas.Remove(ArmarMesas.Length - 1, 1);
                        }
                        else if (InformacionDelError == string.Empty)
                        {
                            MessageBox.Show("Fallo al comprobar si trabaja con planta alta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }

                        ArmarReporte.Estado = Elemento.Cells["ColEstado"].Value.ToString();

                        // Agrego la fila al data source
                        MiDataSource.DtResumenReservas.AddDtResumenReservasRow(ArmarReporte);
                    }

                    // Creo un objeto con el reporte que voy a llenar y le asigno el datasource a SU datasource
                    RptReporteReservas Reporte = new RptReporteReservas();
                    Reporte.SetDataSource(MiDataSource);

                    string FechaDesde = dtpFechaDesde.Value.ToShortDateString();
                    string FechaHasta = dtpDechaHasta.Value.ToShortDateString();

                    if (!ckbIncluirFechaDesde.Checked) { FechaDesde = "Sin fecha desde"; }
                    if (!ckbIncluirFechaHasta.Checked) { FechaHasta = "Sin fecha hasta"; }

                    string NombreCliente = "Sin nombre de cliente";

                    if (txtBuscarPorNombre.Text != TextoVisualBuscar) { NombreCliente = txtBuscarPorNombre.Text; }

                    string TextoEstadoReserva = string.Empty;

                    if (cmbEstadoReserva.SelectedValue != null)
                    {
                        EstadoReserva EstadoReservaSeleccionado = (EstadoReserva)cmbEstadoReserva.SelectedItem;
                        TextoEstadoReserva = EstadoReservaSeleccionado.Nombre;

                        if (EstadoReservaSeleccionado.ID_EstadoReserva == 0)
                        {
                            TextoEstadoReserva = TextoCombo;
                        }
                    }
                    else
                    {
                        TextoEstadoReserva = "ERROR";
                    }

                    Reporte.SetParameterValue("FechaDesde", FechaDesde);
                    Reporte.SetParameterValue("FechaHasta", FechaHasta);
                    Reporte.SetParameterValue("NombreCliente", NombreCliente);
                    Reporte.SetParameterValue("EstadoReserva", TextoEstadoReserva);

                    FormReporteResumenPedido.S_ReporteReserva = Reporte;
                    FormReporteResumenPedido.S_TipoDeReporte = FrmReportes.ETipoDeReporte.Reservas;

                    DialogResult Confirmar = DialogResult.Cancel;

                    Confirmar = MessageBox.Show("¿Desea imprimir la lista de resumenes detallada?", "Tipo de formato", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (Confirmar == DialogResult.Yes)
                    {
                        // TODO - Detallada
                        Reporte.ReportDefinition.Sections["HeaderSectionDetallado"].SectionFormat.EnableSuppress = false;
                        Reporte.ReportDefinition.Sections["HeaderSectionResumido"].SectionFormat.EnableSuppress = true;
                        Reporte.ReportDefinition.Sections["Detalles"].SectionFormat.EnableSuppress = false;

                        FormReporteResumenPedido.ShowDialog();
                    }
                    else if (Confirmar == DialogResult.No)
                    {
                        // TODO - Resumida
                        Reporte.ReportDefinition.Sections["HeaderSectionDetallado"].SectionFormat.EnableSuppress = true;
                        Reporte.ReportDefinition.Sections["HeaderSectionResumido"].SectionFormat.EnableSuppress = false;
                        Reporte.ReportDefinition.Sections["Detalles"].SectionFormat.EnableSuppress = true;
                        Reporte.ReportDefinition.Sections["DivisorDeGrupos"].SectionFormat.EnableSuppress = true;

                        Reporte.ReportDefinition.ReportObjects["Fecha"].ObjectFormat.EnableSuppress = true;
                        Reporte.ReportDefinition.ReportObjects["Cantidad"].ObjectFormat.EnableSuppress = true;

                        FormReporteResumenPedido.ShowDialog();
                    }
                }
            }
        }

        private void DtpFechaDesde_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;
        private void DtpDechaHasta_KeyPress_1(object sender, KeyPressEventArgs e) => e.Handled = true;

        /// <summary>
        /// Devuelve una unica instancia del formulario (Patron singleton)
        /// </summary>
        /// <returns></returns>
        public static FrmReservas ObtenerInstancia()
        {
            if (InstanciaForm == null) { InstanciaForm = new FrmReservas(); }

            return InstanciaForm;
        }

        #region Propiedades
        public int S_ID_Mozo { set { ID_Mozo = value; } }

        public int S_ID_Chef { set { ID_Chef = value; } }

        #endregion
    }
}

