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
using Negocio.Clases_por_tablas;
using Procuratio.FrmsSecundarios.FrmsTemporales.FrmDelivery;
using Procuratio.ClsDeApoyo;
using Procuratio.FrmGenerales;

namespace Procuratio.FrmsSecundarios
{
    public partial class FrmDelivery : Form
    {
        #region Carga
        private FrmDelivery()
        {
            InitializeComponent();
        }

        private void FrmDelivery_Load(object sender, EventArgs e)
        {
            CargarCMBEstadosDelivery();
            DeliveryPendientes();
        }

        private void CargarCMBEstadosDelivery()
        {
            string InformacionDelError = string.Empty;

            ClsEstadosDeliveries EstadosDeliveries = new ClsEstadosDeliveries();

            List<EstadoDelivery> CargarComboBoxEstados = EstadosDeliveries.LeerListado(ref InformacionDelError);

            if (CargarComboBoxEstados != null)
            {
                CargarComboBoxEstados.Add(new EstadoDelivery { ID_EstadoDelivery = 0, Nombre = "Todos los estados" });

                // Nombre de la columna que contiene el nombre
                cmbEstadoEnvio.DisplayMember = "Nombre";

                // Nombre de la columna que contiene el ID
                cmbEstadoEnvio.ValueMember = "ID_EstadoDelivery";

                // Llenar el combo
                cmbEstadoEnvio.DataSource = CargarComboBoxEstados;

                cmbEstadoEnvio.Text = "Chef";
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

        /// <summary>
        /// Bloquea las funcionalidades si se vencio la licencia
        /// </summary>
        public void BloquearPorVencimientoLicencia(bool _LicenciaExpirada)
        {
            btnCrearDelivery.Enabled = !_LicenciaExpirada;
            btnDeliveryEntregado.Enabled = !_LicenciaExpirada;
            btnDeliveryNoRecibido.Enabled = !_LicenciaExpirada;
            btnEliminarElementos.Enabled = !_LicenciaExpirada;
            dgvDelivery.Enabled = !_LicenciaExpirada;
        }
        #endregion

        #region Variables
        private static FrmDelivery InstanciaForm;

        /// <summary>
        /// Enumera las columnas del DGV para poder ubicarlas y editar mas facilmente su posicion.
        /// </summary>
        private enum ENumColDGVDelivery
        {
            ID_Delivery, ID_Pedido, Fecha, Hora, Nombre, Apellido, Telefono, TelefonoCadete, DireccionDeDestino, Pedido,
            Estado, Seleccionar
        }

        private readonly string TextoVisualBuscar = "Buscar por nombre de cliente...";
        private int UltimaFilaSeleccionada = -1;
        private int Segundos = 0, Minutos = 0;
        private const int ActualizarDatos = 5;
        #endregion

        #region Estilo
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            if (BotonEnFoco.Name == btnEliminarElementos.Name)
            {
                BotonEnFoco.BackColor = ClsColores.Rojo;
            }
            else if (BotonEnFoco.Name == btnDeliveryEntregado.Name)
            {
                BotonEnFoco.BackColor = ClsColores.Verde;
            }
            else if (BotonEnFoco.Name == btnVerDeliveriesNoEntregados.Name || BotonEnFoco.Name == btnAplicarFiltro.Name)
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

        public void BtnCrearDelivery_Click(object sender, EventArgs e)
        {
            using (FrmCrearEditarDelivery FormCrearEditarDelivery = new FrmCrearEditarDelivery())
            {
                FormCrearEditarDelivery.ShowDialog();
                DeliveryPendientes();
            }
        }

        private void BtnAplicarFiltro_Click(object sender, EventArgs e)
        {
            Segundos = 0;
            Minutos = 0;
        
            FrmRespuesta RespuestaFormulario; 

            int ID_EstadoEnvio = 0;

            if (cmbEstadoEnvio.SelectedValue != null)
            {
                EstadoDelivery EstadoDeliverySeleccionado = (EstadoDelivery)cmbEstadoEnvio.SelectedItem;
                ID_EstadoEnvio = EstadoDeliverySeleccionado.ID_EstadoDelivery;
                if (EstadoDeliverySeleccionado.ID_EstadoDelivery == 0) { cmbEstadoEnvio.Text = "Todos los estados"; }
            }
            else
            {
                cmbEstadoEnvio.SelectedValue = 0;
            }

            if (!ckbIncluirFechaDesde.Checked && !ckbIncluirFechaHasta.Checked && ID_EstadoEnvio == 0)
            {
                RespuestaFormulario = new FrmRespuesta($"¿Estas seguro que quieres cargar los deliveries sin poner una 'fecha desde', 'fecha hasta', 'nombre del cliente', y un 'EstadoEnvio' ? " +
                $"Esto podria demorar en funcion de la cantidad de datos ya que traeria todos los registros.", FrmRespuesta.ETamaño.Pequeño, FrmRespuesta.ETipo.Si_No);
            }
            else if (!ckbIncluirFechaDesde.Checked && ID_EstadoEnvio == 0)
            {
                RespuestaFormulario = new FrmRespuesta($"¿Estas seguro que quieres cargar los deliveries sin poner una 'fecha desde', y un 'nombre del cliente'? " +
                $"Esto podria demorar en funcion de la cantidad de datos ya que traeria todos los registros (hasta la 'fecha hasta' " +
                $"indicada).", FrmRespuesta.ETamaño.Pequeño, FrmRespuesta.ETipo.Si_No);
            }
            else
            {
                RespuestaFormulario = new FrmRespuesta();
            }

            if (RespuestaFormulario.DialogResult == DialogResult.Yes)
            {
                CargarDGVDelivery(ClsPedidos.ETipoDeListado.FiltroDelivery);
            }
        }

        private void BtnVerDeliveriesNoEntregados_Click(object sender, EventArgs e) => DeliveryPendientes();

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

        private void DeliveryPendientes()
        {
            Segundos = 0;
            Minutos = 0;
            
            txtBuscarPorNombre.Text = TextoVisualBuscar;
            cmbEstadoEnvio.SelectedValue = 0;
            cmbEstadoEnvio.Text = "En cocina y no entregados";
            ckbIncluirFechaDesde.Checked = true;
            ckbIncluirFechaHasta.Checked = false;
            dtpFechaDesde.Enabled = true;
            dtpDechaHasta.Enabled = false;
            dtpFechaDesde.Value = DateTime.Today.AddDays(-1);
            dtpDechaHasta.Value = DateTime.Today;

            CargarDGVDelivery(ClsPedidos.ETipoDeListado.FiltroDelivery, true);
        }

        private void DgvDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string InformacionDelError = string.Empty;

                ClsPedidos Pedidos = new ClsPedidos();
                Pedido InformacionDelPedido = new Pedido();

                InformacionDelPedido = Pedidos.LeerPorNumero((int)dgvDelivery.Rows[e.RowIndex].Cells[(int)ENumColDGVDelivery.ID_Pedido].Value, ref InformacionDelError);

                if (InformacionDelPedido != null)
                {
                    using (FrmPedidosPorMesa FormPedidosPorMesa = new FrmPedidosPorMesa((int)dgvDelivery.Rows[e.RowIndex].Cells[(int)ENumColDGVDelivery.ID_Pedido].Value, InformacionDelPedido.ID_Chef, new FrmCrearEditarDelivery()))
                    {
                        if (InformacionDelPedido.Delivery.ID_EstadoDelivery != (int)ClsEstadosDeliveries.EEstadosDeliveries.EnCocina)
                        {
                            FormPedidosPorMesa.BloquearPorDeliveryEntregado();
                        }

                        FormPedidosPorMesa.ShowDialog();
                    }
                }
                else if (InformacionDelError == string.Empty)
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un fallo al buscar el delivery");
                    MessageBox.Show($"Ocurrio un fallo al buscar el chef", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un fallo al buscar el delivery");
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                if (dgvDelivery.Rows[e.RowIndex].Cells[(int)ENumColDGVDelivery.Seleccionar].Value != null)
                {
                    if (!(bool)dgvDelivery.Rows[e.RowIndex].Cells[(int)ENumColDGVDelivery.Seleccionar].Value && e.RowIndex != UltimaFilaSeleccionada)
                    {
                        ClsColores.MarcarFilaDGV(dgvDelivery, e.RowIndex, true);
                    }
                    else
                    {
                        ClsColores.MarcarFilaDGV(dgvDelivery, e.RowIndex, false);
                    }
                }

                UltimaFilaSeleccionada = e.RowIndex;
            }
        }

        private void DgvDelivery_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (!(DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && !(DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn) && e.RowIndex >= 0)
            {
                string InformacionDelError = string.Empty;

                ClsPedidos Pedidos = new ClsPedidos();
                Pedido InformacionDelPedido = new Pedido();

                InformacionDelPedido = Pedidos.LeerPorNumero((int)dgvDelivery.Rows[e.RowIndex].Cells[(int)ENumColDGVDelivery.ID_Pedido].Value, ref InformacionDelError);

                if (InformacionDelPedido != null)
                {
                    using (FrmCrearEditarDelivery FormCrearEditarDelivery = new FrmCrearEditarDelivery((int)dgvDelivery.Rows[e.RowIndex].Cells[(int)ENumColDGVDelivery.ID_Delivery].Value, (int)dgvDelivery.Rows[e.RowIndex].Cells[(int)ENumColDGVDelivery.ID_Pedido].Value, InformacionDelPedido.ID_Chef))
                    {
                        if (InformacionDelPedido.ID_EstadoPedido != (int)ClsEstadosPedidos.EEstadosPedidos.Entregado)
                        {
                            if (InformacionDelPedido.Delivery.ID_EstadoDelivery == (int)ClsEstadosDeliveries.EEstadosDeliveries.EnCocina)
                            {
                                FormCrearEditarDelivery.ShowDialog();
                                DeliveryPendientes();
                            }
                            else
                            {
                                using (FrmInformacion FormInformacion = new FrmInformacion($"No puede editar el delivery con fecha {InformacionDelPedido.Fecha.ToShortDateString()} " +
                                        $"a las {InformacionDelPedido.Hora.ToString(@"hh\:mm")} del cliente {InformacionDelPedido.Cliente.Nombre} {InformacionDelPedido.Cliente.Apellido} " +
                                        $"porque ya fue confirmado su estado o fue eliminado.", ClsColores.Blanco, 300, 350))
                                {
                                    FormInformacion.ShowDialog();
                                }
                            }
                        }
                        else
                        {
                            using (FrmInformacion FormInformacion = new FrmInformacion($"No puede editar el delivery con fecha {InformacionDelPedido.Fecha.ToShortDateString()} " +
                                    $"a las {InformacionDelPedido.Hora.ToString(@"hh\:mm")} del cliente {InformacionDelPedido.Cliente.Nombre} {InformacionDelPedido.Cliente.Apellido} " +
                                    $"porque ya fue indicado como finalizado desde cocina.", ClsColores.Blanco, 300, 350))
                            {
                                FormInformacion.ShowDialog();
                            }
                        }
                    }
                }
                else if (InformacionDelError == string.Empty)
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un fallo al buscar el pedido");
                    MessageBox.Show($"Ocurrio un fallo al buscar el pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un fallo al buscar el pedido");
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnEliminarElementos_Click(object sender, EventArgs e)
        {
            int TotalDeFilas = dgvDelivery.Rows.Count;

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                //Pregunto si la celda es diferente a null
                if (dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.Seleccionar].Value != null)
                {
                    //Casteo el check del objeto a booleano y pregunto si es true
                    if ((bool)dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.Seleccionar].Value)
                    {
                        string InformacionDelError = string.Empty;

                        ClsPedidos Pedidos = new ClsPedidos();
                        Pedido VerDelivery = new Pedido();

                        VerDelivery = Pedidos.LeerPorNumero((int)dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.ID_Pedido].Value, ref InformacionDelError);

                        if (VerDelivery != null)
                        {
                            if (VerDelivery.Delivery.ID_EstadoDelivery == (int)ClsEstadosDeliveries.EEstadosDeliveries.EnCocina)
                            {
                                ClsDeliveries Delivery = new ClsDeliveries();
                                Delivery ActualizarDelivery = Delivery.LeerPorNumero(VerDelivery.ID_Delivery, ref InformacionDelError);

                                ActualizarDelivery.ID_EstadoDelivery = (int)ClsEstadosDeliveries.EEstadosDeliveries.Eliminado;
                                VerDelivery.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.Eliminado;
                                VerDelivery.TiempoEspera = null;

                                if (Pedidos.Actualizar(VerDelivery, ref InformacionDelError) != 0)
                                {
                                    if (Delivery.Actualizar(ActualizarDelivery, ref InformacionDelError) != 0)
                                    {
                                        FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Pedido y delivery eliminado";
                                        dgvDelivery.Rows.Remove(dgvDelivery.Rows[Indice]);
                                        Indice -= 1;
                                        TotalDeFilas -= 1;
                                    }
                                }
                                else if (InformacionDelError != string.Empty)
                                {
                                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al eliminar el delivery");
                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                using (FrmInformacion FormInformacion = new FrmInformacion($"No puede editar o eliminar el delivery " +
                                        $"porque ya fue confirmado su estado o fue eliminado.", ClsColores.Blanco, 250, 300))
                                {
                                    FormInformacion.ShowDialog();
                                }
                            }
                        }
                        else if (InformacionDelError == string.Empty)
                        {
                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al eliminar el delivery");
                            MessageBox.Show("Ocurrio un fallo al eliminar el delivery", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al eliminar el delivery");
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void BtnDeliveryNoRecibido_Click(object sender, EventArgs e)
        {
            FrmRespuesta FormRespuesta = new FrmRespuesta($"¿Esta seguro que quiere marcar el pedido del delivery como 'Fallido'? Si selecciona 'si', " +
                $"se creara un registro del mismo como perdida en caja", FrmRespuesta.ETamaño.Mediano, FrmRespuesta.ETipo.Si_No);

            if (FormRespuesta.DialogResult == DialogResult.Yes)
            {
                int TotalDeFilas = dgvDelivery.Rows.Count;

                ClsPedidos Pedidos = new ClsPedidos();
                Pedido VerDelivery = new Pedido();

                ClsDeliveries Deliveries = new ClsDeliveries();
                Delivery ActualizarDelivery = null;

                ClsCajas Cajas = new ClsCajas();
                Caja CrearRegistro = null;

                ClsDetalles Detalle = new ClsDetalles();
                List<Detalle> CalcularPerdida = new List<Detalle>();

                using (FrmValidarUsuario FormValidarUsuario = new FrmValidarUsuario(FrmValidarUsuario.EFiltroUsuariosAutorizados.Todos))
                {
                    FormValidarUsuario.ShowDialog();

                    if (FormValidarUsuario.DialogResult == DialogResult.OK)
                    {
                        for (int Indice = 0; Indice < TotalDeFilas; Indice++)
                        {
                            //Pregunto si la celda es diferente a null
                            if (dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.Seleccionar].Value != null)
                            {
                                //Casteo el check del objeto a booleano y pregunto si es true
                                if ((bool)dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.Seleccionar].Value)
                                {
                                    string InformacionDelError = string.Empty;

                                    ClsDetalles Detalles = new ClsDetalles();
                                    List<Detalle> BuscarArticuloSinCocinar = Detalles.LeerListado((int)dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.ID_Pedido].Value, (int)ClsDetalles.ETipoDeListado.PorIDPedido, ref InformacionDelError);

                                    bool FaltanCocinar = false;

                                    if (BuscarArticuloSinCocinar != null)
                                    {
                                        foreach (Detalle Elemento in BuscarArticuloSinCocinar)
                                        {
                                            if (Elemento.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.NoCocinado)
                                            {
                                                FaltanCocinar = true;
                                                break;
                                            }
                                        }

                                        VerDelivery = Pedidos.LeerPorNumero((int)dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.ID_Pedido].Value, ref InformacionDelError);

                                        if (VerDelivery != null)
                                        {
                                            if (!FaltanCocinar)
                                            {
                                                double TotalPerdido = 0;

                                                CalcularPerdida = Detalle.LeerListado((int)dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.ID_Pedido].Value, ClsDetalles.ETipoDeListado.PorIDPedido, ref InformacionDelError);

                                                foreach (Detalle Elemento in CalcularPerdida)
                                                {
                                                    if (Elemento.Articulo.PrecioDelivery != null)
                                                    {
                                                        TotalPerdido += Elemento.Cantidad * (double)Elemento.Articulo.PrecioDelivery;
                                                    }
                                                }

                                                if (VerDelivery.Delivery.ID_EstadoDelivery == (int)ClsEstadosDeliveries.EEstadosDeliveries.ParaEntrega)
                                                {
                                                    ActualizarDelivery = Deliveries.LeerPorNumero(VerDelivery.Delivery.ID_Delivery, ref InformacionDelError);
                                                    ActualizarDelivery.ID_EstadoDelivery = (int)ClsEstadosDeliveries.EEstadosDeliveries.NoEntregado;
                                                    Deliveries.Actualizar(ActualizarDelivery, ref InformacionDelError);

                                                    VerDelivery.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.Finalizado;
                                                    VerDelivery.TiempoEspera = null;

                                                    int TotalDelPedido = 0;

                                                    List<Detalle> CalcularTotal = Detalles.LeerListado((int)dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.ID_Pedido].Value, ClsDetalles.ETipoDeListado.PorIDPedido, ref InformacionDelError);

                                                    if (CalcularTotal != null)
                                                    {
                                                        foreach (Detalle Elemento in CalcularTotal)
                                                        {
                                                            TotalDelPedido += Convert.ToInt32(Elemento.Cantidad * Elemento.Articulo.Precio);
                                                        }
                                                        VerDelivery.TotalPedido = TotalDelPedido;
                                                    }
                                                    else if (InformacionDelError == string.Empty)
                                                    {
                                                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar calcular el total del pedido");
                                                    }
                                                    else
                                                    {
                                                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar calcular el total del pedido");
                                                        MessageBox.Show($"Error al intentar calcular el total del pedido {(int)dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.ID_Pedido].Value}: {InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    }

                                                    if (Pedidos.Actualizar(VerDelivery, ref InformacionDelError) != 0)
                                                    {
                                                        FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Pedido y delivery actualizado";

                                                        CrearRegistro = new Caja();

                                                        CrearRegistro.ID_Usuario = FormValidarUsuario.G_ID_UsuarioQueValido;
                                                        CrearRegistro.Fecha = DateTime.Today.Date;
                                                        CrearRegistro.Hora = TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss"));
                                                        CrearRegistro.Monto = TotalPerdido;
                                                        CrearRegistro.Detalle = "Perdida por delivery no entregado";
                                                        CrearRegistro.ID_Pedido = VerDelivery.ID_Pedido;
                                                        CrearRegistro.ID_TipoDeMonto = (int)ClsTiposDeMontos.ETiposDeMontos.EgresoDelivery;
                                                        CrearRegistro.ID_EstadoCaja = (int)ClsEstadosCajas.EEstadosCajas.Activo;

                                                        if (Cajas.Crear(CrearRegistro, ref InformacionDelError) != 0)
                                                        {
                                                            dgvDelivery.Rows.Remove(dgvDelivery.Rows[Indice]);
                                                            Indice -= 1;
                                                            TotalDeFilas -= 1;
                                                        }
                                                        else if (InformacionDelError == string.Empty)
                                                        {
                                                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al crear el registro de perdida en caja");
                                                            MessageBox.Show($"Fallo al crear el registro de perdida en caja", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        }
                                                        else
                                                        {
                                                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al crear el registro de perdida en caja");
                                                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        }
                                                    }
                                                    else if (InformacionDelError != string.Empty)
                                                    {
                                                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al marcar el delivery como no recibido");
                                                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    }
                                                }
                                                else
                                                {
                                                    using (FrmInformacion FormInformacion = new FrmInformacion($"No puede editar o eliminar el delivery de {VerDelivery.Cliente.Nombre} {VerDelivery.Cliente.Apellido} " +
                                                            $"porque ya fue confirmado su estado o fue eliminado.", ClsColores.Blanco, 250, 300))
                                                    {
                                                        FormInformacion.ShowDialog();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                using (FrmInformacion FormInformacion = new FrmInformacion($"No puede marcar como 'No entregado' el delivery de {VerDelivery.Cliente.Nombre} {VerDelivery.Cliente.Apellido} porque falta que " +
                                                        $"cocina marque los platos del pedido como finalizados (solo se puede marcar esta opcion si " +
                                                        $"ya fueron cocinados los platos y nadie pago el delivery).", ClsColores.Blanco, 250, 300))
                                                {
                                                    FormInformacion.ShowDialog();
                                                }
                                            }
                                        }
                                        else if (InformacionDelError == string.Empty)
                                        {
                                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al marcar el delivery como no recibido");
                                            MessageBox.Show("Ocurrio un fallo al marcar el delivery como no recibido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        else
                                        {
                                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al marcar el delivery como no recibido");
                                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    
        private void BtnDeliveryEntregado_Click(object sender, EventArgs e)
        {
            using (FrmValidarUsuario FormValidarUsuario = new FrmValidarUsuario(FrmValidarUsuario.EFiltroUsuariosAutorizados.Todos))
            {
                FormValidarUsuario.ShowDialog();

                if (FormValidarUsuario.DialogResult == DialogResult.OK)
                {
                    int TotalDeFilas = dgvDelivery.Rows.Count;

                    for (int Indice = 0; Indice < TotalDeFilas; Indice++)
                    {
                        //Pregunto si la celda es diferente a null
                        if (dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.Seleccionar].Value != null)
                        {
                            //Casteo el check del objeto a booleano y pregunto si es true
                            if ((bool)dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.Seleccionar].Value)
                            {
                                string InformacionDelError = string.Empty;

                                ClsPedidos Pedidos = new ClsPedidos();
                                Pedido VerDelivery = Pedidos.LeerPorNumero((int)dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.ID_Delivery].Value, ref InformacionDelError);

                                ClsDetalles Detalles = new ClsDetalles();

                                if (VerDelivery != null)
                                {
                                    if (VerDelivery.Delivery.ID_EstadoDelivery == (int)ClsEstadosDeliveries.EEstadosDeliveries.ParaEntrega)
                                    {
                                        using (FrmResumenPedido FormResumenDePedido = new FrmResumenPedido((int)dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.ID_Pedido].Value, FormValidarUsuario.G_ID_UsuarioQueValido))
                                        {
                                            FormResumenDePedido.ShowDialog();

                                            if (FormResumenDePedido.DialogResult == DialogResult.OK)
                                            {
                                                int TotalDelPedido = 0;

                                                List<Detalle> CalcularTotal = Detalles.LeerListado((int)dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.ID_Pedido].Value, ClsDetalles.ETipoDeListado.PorIDPedido, ref InformacionDelError);

                                                if (CalcularTotal != null)
                                                {
                                                    foreach (Detalle Elemento in CalcularTotal)
                                                    {
                                                        TotalDelPedido += Convert.ToInt32(Elemento.Cantidad * Elemento.Articulo.Precio);
                                                    }
                                                    VerDelivery.TotalPedido = TotalDelPedido;
                                                }
                                                else if (InformacionDelError == string.Empty)
                                                {
                                                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar calcular el total del pedido");
                                                }
                                                else
                                                {
                                                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar calcular el total del pedido");
                                                    MessageBox.Show($"Error al intentar calcular el total del pedido {(int)dgvDelivery.Rows[Indice].Cells[(int)ENumColDGVDelivery.ID_Pedido].Value}: {InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }

                                                VerDelivery.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.Finalizado;
                                                VerDelivery.TiempoEspera = null;

                                                if (Pedidos.Actualizar(VerDelivery, ref InformacionDelError) != 0)
                                                {
                                                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Pedido y delivery finalizado";

                                                    ClsDeliveries Deliveries = new ClsDeliveries();
                                                    Delivery ActualizarDelivery = new Delivery();

                                                    ActualizarDelivery = Deliveries.LeerPorNumero(VerDelivery.Delivery.ID_Delivery, ref InformacionDelError);

                                                    ActualizarDelivery.ID_EstadoDelivery = (int)ClsEstadosDeliveries.EEstadosDeliveries.Entregado;

                                                    Deliveries.Actualizar(ActualizarDelivery, ref InformacionDelError);
                                                    dgvDelivery.Rows.Remove(dgvDelivery.Rows[Indice]);
                                                    Indice -= 1;
                                                    TotalDeFilas -= 1;
                                                }
                                                else if (InformacionDelError != string.Empty)
                                                {
                                                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al finalizar el delivery");
                                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        using (FrmInformacion FormInformacion = new FrmInformacion($"No puede editar o eliminar el delivery de {VerDelivery.Cliente.Nombre} {VerDelivery.Cliente.Apellido} " +
                                                $"porque ya fue confirmado su estado (eliminado, entregado, etc) o este todavia se encuentra en cocina.", ClsColores.Blanco, 250, 300))
                                        {
                                            FormInformacion.ShowDialog();
                                        }
                                    }
                                }
                                else if (InformacionDelError == string.Empty)
                                {
                                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al buscar platos sin cocinar");
                                    MessageBox.Show("Ocurrio un fallo al buscar platos sin cocinar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al buscar platos sin cocinar");
                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Carga el DGV
        /// </summary>
        /// <param name="_TipoDeListado">Indica el tipo de listado que se cargara.</param>
        /// <param name="_DeliveryEnCocinaYNoEntregado">Si es true, listara los deliveries en cocina y no entregados del dia 
        /// anterior en adelante.</param>
        private void CargarDGVDelivery(ClsPedidos.ETipoDeListado _TipoDeListado, bool _DeliveryEnCocinaYNoEntregado = false)
        {
            dgvDelivery.Rows.Clear();

            string InformacionDelError = string.Empty;

            // Inicio preparacion de filtros ----
            string NombreCliente = string.Empty;

            int ID_EstadoDelivery = 0;

            if (cmbEstadoEnvio.SelectedValue != null)
            {
                EstadoDelivery EstadoDeliverySeleccionado = (EstadoDelivery)cmbEstadoEnvio.SelectedItem;
                ID_EstadoDelivery = EstadoDeliverySeleccionado.ID_EstadoDelivery;
            }

            if (txtBuscarPorNombre.Text != TextoVisualBuscar) { NombreCliente = txtBuscarPorNombre.Text; }

            string FechaDesde = Convert.ToString(dtpFechaDesde.Value.Date);
            string FechaHasta = Convert.ToString(dtpDechaHasta.Value.Date);

            if (!ckbIncluirFechaDesde.Checked) { FechaDesde = string.Empty; }
            if (!ckbIncluirFechaHasta.Checked) { FechaHasta = string.Empty; }
            // Fin preparacion de filtros ----

            ClsPedidos Pedidos = new ClsPedidos();

            List<Pedido> CargarDGVDelivery = Pedidos.LeerListado(_TipoDeListado, ref InformacionDelError, FechaDesde,FechaHasta, NombreCliente, ID_EstadoDelivery, _DeliveryEnCocinaYNoEntregado);

            if (CargarDGVDelivery != null)
            {
                foreach (Pedido Elemento in CargarDGVDelivery)
                {
                    int NumeroDeFila = dgvDelivery.Rows.Add();

                    dgvDelivery.Columns[(int)ENumColDGVDelivery.ID_Delivery].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDelivery.Columns[(int)ENumColDGVDelivery.ID_Pedido].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDelivery.Columns[(int)ENumColDGVDelivery.Fecha].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDelivery.Columns[(int)ENumColDGVDelivery.Hora].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDelivery.Columns[(int)ENumColDGVDelivery.Nombre].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDelivery.Columns[(int)ENumColDGVDelivery.Apellido].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDelivery.Columns[(int)ENumColDGVDelivery.Telefono].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDelivery.Columns[(int)ENumColDGVDelivery.TelefonoCadete].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDelivery.Columns[(int)ENumColDGVDelivery.DireccionDeDestino].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDelivery.Columns[(int)ENumColDGVDelivery.Pedido].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDelivery.Columns[(int)ENumColDGVDelivery.Estado].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDelivery.Columns[(int)ENumColDGVDelivery.Seleccionar].SortMode = DataGridViewColumnSortMode.NotSortable;

                    dgvDelivery.Rows[NumeroDeFila].Cells[(int)ENumColDGVDelivery.ID_Delivery].Value = Elemento.ID_Cliente;
                    dgvDelivery.Rows[NumeroDeFila].Cells[(int)ENumColDGVDelivery.ID_Pedido].Value = Elemento.ID_Pedido;
                    dgvDelivery.Rows[NumeroDeFila].Cells[(int)ENumColDGVDelivery.Fecha].Value = Elemento.Fecha.ToShortDateString();
                    dgvDelivery.Rows[NumeroDeFila].Cells[(int)ENumColDGVDelivery.Hora].Value = Elemento.Hora.ToString(@"hh\:mm");
                    dgvDelivery.Rows[NumeroDeFila].Cells[(int)ENumColDGVDelivery.Nombre].Value = Elemento.Cliente.Nombre;
                    dgvDelivery.Rows[NumeroDeFila].Cells[(int)ENumColDGVDelivery.Apellido].Value = Elemento.Cliente.Apellido;
                    dgvDelivery.Rows[NumeroDeFila].Cells[(int)ENumColDGVDelivery.Telefono].Value = Convert.ToString(Elemento.Cliente.Telefono);
                   
                    if (Elemento.Delivery.Telefono == null)
                    {
                        dgvDelivery.Rows[NumeroDeFila].Cells[(int)ENumColDGVDelivery.TelefonoCadete].Value = string.Empty;
                    }
                    else
                    {
                        dgvDelivery.Rows[NumeroDeFila].Cells[(int)ENumColDGVDelivery.TelefonoCadete].Value = Convert.ToString(Elemento.Delivery.Telefono);
                    }

                    if (Elemento.Delivery.Destino == null)
                    {
                        dgvDelivery.Rows[NumeroDeFila].Cells[(int)ENumColDGVDelivery.DireccionDeDestino].Value = ClsDeliveries.DireccionPorDefecto;
                    }
                    else
                    {
                        dgvDelivery.Rows[NumeroDeFila].Cells[(int)ENumColDGVDelivery.DireccionDeDestino].Value = Elemento.Delivery.Destino;
                    }

                    dgvDelivery.Rows[NumeroDeFila].Cells[(int)ENumColDGVDelivery.Pedido].Value = "Ver";
                    dgvDelivery.Rows[NumeroDeFila].Cells[(int)ENumColDGVDelivery.Estado].Value = Elemento.Delivery.EstadoDelivery.Nombre;
                    dgvDelivery.Rows[NumeroDeFila].Cells[(int)ENumColDGVDelivery.Seleccionar].Value = false;
                }

                dgvDelivery.ClearSelection();

                UltimaFilaSeleccionada = -1;
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

        private void tmrActualizaDatos_Tick(object sender, EventArgs e)
        {
            ActualizaReloj();

            if (Minutos == ActualizarDatos)
            {
                DeliveryPendientes();
            }
        }

        private void ActualizaReloj()
        {
            Segundos++;

            if (Segundos == 60)
            {
                Minutos++;

                Segundos = 0;
            }
        }

        /// <summary>
        /// Devuelve una unica instancia del formulario (Patron singleton)
        /// </summary>
        /// <returns></returns>
        public static FrmDelivery ObtenerInstancia()
        {
            if (InstanciaForm == null) { InstanciaForm = new FrmDelivery(); }

            return InstanciaForm;
        }

        #region Propiedades
        #endregion
    }
}
