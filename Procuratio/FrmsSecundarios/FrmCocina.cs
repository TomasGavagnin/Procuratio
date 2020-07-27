using Datos;
using Negocio;
using Negocio.Clases_de_apoyo;
using Negocio.Clases_por_tablas;
using Procuratio.ClsDeApoyo;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Procuratio
{
    public partial class FrmCocina : Form
    {
        #region Carga
        private FrmCocina()
        {
            InitializeComponent();
        }

        private void FrmCocina_Load(object sender, EventArgs e)
        {
            CargarDGVListarPedidos();
        }

        /// <summary>
        /// Bloquea las funcionalidades si se vencio la licencia.
        /// </summary>
        public void BloquearPorVencimientoLicencia(bool _LicenciaExpirada)
        {
            btnPedidoTerminado.Enabled = !_LicenciaExpirada;
            dgvListaPedidos.Enabled = !_LicenciaExpirada;
            dgvPlatosPorMesa.Enabled = !_LicenciaExpirada;
            ckbImprimirTicketDelivery.Enabled = !_LicenciaExpirada;
        }
        #endregion

        #region Variables
        private static FrmCocina InstanciaForm;

        /// <summary>
        /// Enumera las columnas del DGV para poder ubicarlas y editar mas facilmente su posicion.
        /// </summary>
        private enum ENumColDGVPlatosPorMesa
        {
            ID_Pedido, Articulo, Detalle, Cantidad
        }

        /// <summary>
        /// Enumera las columnas del DGV para poder ubicarlas y editar mas facilmente su posicion.
        /// </summary>
        private enum ENumColDGVListaPedidos
        {
            ID_Pedido, TiempoEspera, EsDelivery, Mozos, Mesas, Seleccionar
        }

        private int TiempoActualizar = 0;
        private int ID_PedidoImprimir = -1;
        private List<int> PedidosSeleccionados = new List<int>();
        private int UltimaFilaSeleccionada = -1;
        #endregion

        #region Estilo
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            if (BotonEnFoco.Name == btnPedidoTerminado.Name)
            {
                BotonEnFoco.BackColor = ClsColores.Verde;
            }
            else if (BotonEnFoco.Name == btnForzarActualizacion.Name)
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

        private void BtnPedidoTerminado_Click(object sender, EventArgs e)
        {
            tmrActualizaPedidos.Stop();

            int TotalDeFilas = dgvListaPedidos.Rows.Count;

            string InformacionDelError = string.Empty;

            ClsDetalles Detalles = new ClsDetalles();

            ClsPedidos Pedidos = new ClsPedidos();
            Pedido ActualizarPedido = new ClsPedidos();

            ClsDeliveries Delivery = new ClsDeliveries();
            Delivery ActualizarDelivery = new Delivery();

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                //Pregunto si la celda es diferente a null
                if (dgvListaPedidos.Rows[Indice].Cells[(int)ENumColDGVListaPedidos.Seleccionar].Value != null)
                {
                    //Casteo el check del objeto a booleano y pregunto si es true
                    if ((bool)dgvListaPedidos.Rows[Indice].Cells[(int)ENumColDGVListaPedidos.Seleccionar].Value)
                    {
                        InformacionDelError = string.Empty;

                        List<Detalle> ActualizarDetalle = Detalles.LeerListado((int)dgvListaPedidos.Rows[Indice].Cells[(int)ENumColDGVListaPedidos.ID_Pedido].Value, ClsDetalles.ETipoDeListado.ParaCocina, ref InformacionDelError);
                        ActualizarPedido = Pedidos.LeerPorNumero((int)dgvListaPedidos.Rows[Indice].Cells[(int)ENumColDGVListaPedidos.ID_Pedido].Value, ref InformacionDelError);

                        if (ActualizarDetalle != null && ActualizarPedido != null)
                        {
                            if (ActualizarPedido.ID_EstadoPedido == (int)ClsEstadosPedidos.EEstadosPedidos.EnProceso)
                            {
                                foreach (Detalle Elemento in ActualizarDetalle)
                                {
                                    if (Elemento.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.CantidadAumentada)
                                    {
                                        Elemento.Cantidad += Elemento.CantidadAgregada;
                                        Elemento.CantidadAgregada = 0;
                                    }

                                    Elemento.ID_EstadoDetalle = (int)ClsEstadoDetalle.EEstadoDetalle.YaCocinado;

                                    if (Detalles.Actualizar(Elemento, ref InformacionDelError) != 0)
                                    {
                                        dgvPlatosPorMesa.Rows.Clear();
                                        lblDetallesDelPedido.Text = string.Empty;
                                    }
                                    else if (InformacionDelError != string.Empty)
                                    {
                                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }

                                if (ActualizarPedido.ID_Delivery == null)
                                {
                                    ActualizarPedido.TiempoEspera = null;
                                }

                                if (ActualizarPedido.ID_Delivery == null)
                                {
                                    ActualizarPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.ParaEntrega;
                                }
                                else
                                {
                                    ActualizarPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.Entregado;

                                    ActualizarDelivery = Delivery.LeerPorNumero(ActualizarPedido.ID_Delivery, ref InformacionDelError);

                                    if (ActualizarDelivery != null)
                                    {
                                        ActualizarDelivery.ID_EstadoDelivery = (int)ClsEstadosDeliveries.EEstadosDeliveries.ParaEntrega;

                                        if (Delivery.Actualizar(ActualizarDelivery, ref InformacionDelError) != 0)
                                        {
                                            FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Delivery actualizado con exito";
                                        }
                                        else if (InformacionDelError == string.Empty)
                                        {
                                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al actualizar el delivery");
                                        }
                                        else
                                        {
                                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al actualizar el delivery");
                                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else if (InformacionDelError == string.Empty)
                                    {
                                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al actualizar el delivery");
                                    }
                                    else
                                    {
                                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al actualizar el delivery");
                                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }

                                if (Pedidos.Actualizar(ActualizarPedido, ref InformacionDelError) != 0)
                                {
                                    if (ActualizarPedido.ID_Delivery != null && ckbImprimirTicketDelivery.Checked)
                                    {
                                        ID_PedidoImprimir = ActualizarPedido.ID_Pedido;
                                        PtdImprimirTicket = new PrintDocument();

                                        if (ClsComprobarEstadoImpresora.ComprobarEstadoImpresora(PtdImprimirTicket.PrinterSettings.PrinterName))
                                        {
                                            PtdImprimirTicket.PrintPage += PrintPageEventHandler;
                                            PtdImprimirTicket.Print();
                                        }

                                        ID_PedidoImprimir = -1;
                                    }

                                    PedidosSeleccionados.RemoveAll(I => I == (int)dgvListaPedidos.Rows[Indice].Cells[(int)ENumColDGVListaPedidos.ID_Pedido].Value);

                                    lblMostrarNumeroPedido.Text = string.Empty;
                                    dgvPlatosPorMesa.Rows.Clear();
                                    dgvListaPedidos.Rows.Remove(dgvListaPedidos.Rows[Indice]);
                                    Indice -= 1;
                                    TotalDeFilas -= 1;

                                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Pedido actualizado";
                                }
                                else if (InformacionDelError != string.Empty)
                                {
                                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al actualizar el pedido");
                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                using (FrmInformacion FormInformacion = new FrmInformacion($"El pedido numero {ActualizarPedido.ID_Pedido}, no se indico como cocinado debido a " +
                                    $"que fue retirado de la lista desde otra computadora y no llego a quitarse de esta al momento de indicarlo como terminado. " +
                                    $"El pedido sera retirado de la lista al cerrar este mensaje (no se indicara como cocinado).", ClsColores.Blanco, 200, 400))
                                {
                                    FormInformacion.ShowDialog();
                                }

                                lblMostrarNumeroPedido.Text = string.Empty;
                                dgvPlatosPorMesa.Rows.Clear();
                                dgvListaPedidos.Rows.Remove(dgvListaPedidos.Rows[Indice]);
                                Indice -= 1;
                                TotalDeFilas -= 1;
                            }
                        }
                        else if (InformacionDelError == string.Empty)
                        {
                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al actualizar el pedido");
                        }
                        else
                        {
                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al actualizar el pedido");
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            dgvListaPedidos.ClearSelection();
            tmrActualizaPedidos.Start();
        }

        private void CargarDGVListarPedidos()
        {
            dgvListaPedidos.Rows.Clear();

            string InformacionDelError = string.Empty;

            ClsPedidos Pedidos = new ClsPedidos();
            List<Pedido> PedidosEnProceso = Pedidos.LeerListado(ClsPedidos.ETipoDeListado.PedidosEnProceso, ref InformacionDelError);

            if (PedidosEnProceso != null)
            {
                foreach (Pedido Elemento in PedidosEnProceso)
                {
                    int NumeroDeFila = dgvListaPedidos.Rows.Add();

                    dgvListaPedidos.Columns[(int)ENumColDGVListaPedidos.ID_Pedido].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvListaPedidos.Columns[(int)ENumColDGVListaPedidos.TiempoEspera].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvListaPedidos.Columns[(int)ENumColDGVListaPedidos.EsDelivery].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvListaPedidos.Columns[(int)ENumColDGVListaPedidos.Mozos].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvListaPedidos.Columns[(int)ENumColDGVListaPedidos.Mesas].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvListaPedidos.Columns[(int)ENumColDGVListaPedidos.Seleccionar].SortMode = DataGridViewColumnSortMode.NotSortable;

                    dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.ID_Pedido].Value = Elemento.ID_Pedido;

                    string[] Tiempo;
                    int Horas = 0;
                    int Minutos = 0;

                    if (Elemento.TiempoEspera.Value.Date == DateTime.Now.Date && (Horas < 24 && Minutos < 60))
                    {
                        Tiempo = (DateTime.Now.TimeOfDay - Elemento.TiempoEspera.Value.TimeOfDay).ToString(@"hh\:mm").Split(':');

                        Horas = Convert.ToInt32(Tiempo[0]);
                        Minutos = Convert.ToInt32(Tiempo[1]);

                        dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.TiempoEspera].Value = (DateTime.Now.TimeOfDay - Elemento.TiempoEspera.Value.TimeOfDay).ToString(@"hh\:mm");
                    }
                    else
                    {
                        // Hay un dia de diferencia solamente
                        if (Elemento.TiempoEspera.Value.Day == DateTime.Now.AddDays(-1).Day)
                        {
                            Tiempo = (new TimeSpan(24, 0, 0) - Elemento.TiempoEspera.Value.TimeOfDay).ToString(@"hh\:mm").Split(':');

                            Horas = Convert.ToInt32(Tiempo[0]) + DateTime.Now.Hour;
                            Minutos = Convert.ToInt32(Tiempo[1]) + DateTime.Now.Minute;

                            // Calcular aumento de hora
                            if (Minutos >= 60)
                            {
                                Horas += 1;
                                Minutos += (60 - Minutos);
                            }

                            // Este if evitara mostrar una hora mayor a 24 en caso de problemas con la sincronizacion del 
                            // reloj de la computadora
                            if (Horas < 24)
                            {
                                if (Minutos < 10)
                                {
                                    if (Horas < 10)
                                    {
                                        dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.TiempoEspera].Value = $"0{Horas}:0{Minutos}";
                                    }
                                    else
                                    {
                                        dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.TiempoEspera].Value = $"{Horas}:0{Minutos}";
                                    }
                                }
                                else
                                {
                                    if (Horas < 10)
                                    {
                                        dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.TiempoEspera].Value = $"0{Horas}:{Minutos}";
                                    }
                                    else
                                    {
                                        dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.TiempoEspera].Value = $"{Horas}:{Minutos}";
                                    }
                                }
                            }
                            else
                            {
                                dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.TiempoEspera].Value = "--:--";
                            }
                        }
                        else
                        {
                            dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.TiempoEspera].Value = "--:--";
                        }
                    }

                    if (Horas > 0 || Minutos > 40)
                    {
                        dgvListaPedidos.Rows[NumeroDeFila].DefaultCellStyle.BackColor = ClsColores.Rojo;
                    }
                    else if (Minutos >= 20)
                    {
                        dgvListaPedidos.Rows[NumeroDeFila].DefaultCellStyle.BackColor = ClsColores.NaranjaClaro;
                    }

                    string NombreMozo = string.Empty;

                    if (Elemento.ID_Delivery == null)
                    {
                        dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.EsDelivery].Value = "NO";

                        ClsPedidosXMesas PedidosXMesas = new ClsPedidosXMesas();
                        PedidoXMesa BuscarDatos = PedidosXMesas.LeerPorNumero(Elemento.ID_Pedido, ref InformacionDelError);

                        if (BuscarDatos != null)
                        {
                            NombreMozo = $"{BuscarDatos.Mesa.Usuario.Nombre} {BuscarDatos.Mesa.Usuario.Apellido}";
                        }
                    }
                    else
                    {
                        dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.EsDelivery].Value = "SI";
                    }

                    dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.Mozos].Value = NombreMozo;
                    dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.Mesas].Value = "Ver";
                    dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.Seleccionar].Value = false;

                    dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.Mesas].Style.SelectionBackColor = ClsColores.Transparente;
                    dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.Seleccionar].Style.SelectionBackColor = ClsColores.Transparente;

                    // Quitarle el color de toda la fila a estas casillas
                    dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.Mesas].Style.BackColor = ClsColores.GrisOscuroFondo;
                    dgvListaPedidos.Rows[NumeroDeFila].Cells[(int)ENumColDGVListaPedidos.Seleccionar].Style.BackColor = ClsColores.GrisOscuroFondo;

                    UltimaFilaSeleccionada = -1;

                    dgvListaPedidos.ClearSelection();
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al cargar el pedido");
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al cargar el pedido");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Comprobar si el pedido que estaba en pantalla sigue disponible al actualizar
            if (dgvPlatosPorMesa.Rows.Count > 0)
            {
                int PedidoCargado = (int)dgvPlatosPorMesa.Rows[0].Cells[(int)ENumColDGVPlatosPorMesa.ID_Pedido].Value;
                int TotalDeFilas = dgvListaPedidos.Rows.Count;
                bool PedidoNoEncontrado = true;

                for (int Indice = 0; Indice < TotalDeFilas; Indice++)
                {
                    if (PedidoCargado == (int)dgvListaPedidos.Rows[Indice].Cells[(int)ENumColDGVPlatosPorMesa.ID_Pedido].Value) { PedidoNoEncontrado = false; }
                }

                if (PedidoNoEncontrado)
                {
                    dgvPlatosPorMesa.Rows.Clear();
                    lblDetallesDelPedido.Text = string.Empty;
                }
                else
                {
                    // Encontro el pedido, lo actualizo
                    ActualizaInformacionPedido(PedidoCargado);
                }
            }

            PedidosCancelados();
        }

        /// <summary>
        /// Actualiza los pedidos que se encuentran marcados, para no ser perdidos al actualizarse la lista.
        /// </summary>
        private void PedidosCancelados()
        {
            int TotalDeFilas = dgvListaPedidos.Rows.Count;
            List<int> PedidosEliminar = new List<int>();

            foreach (int Elemento in PedidosSeleccionados)
            {
                bool PedidoEncontrado = false;

                for (int Indice = 0; Indice < TotalDeFilas; Indice++)
                {
                    //Pregunto si la celda es diferente a null
                    if (dgvListaPedidos.Rows[Indice].Cells[(int)ENumColDGVListaPedidos.Seleccionar].Value != null)
                    {
                        if ((int)dgvListaPedidos.Rows[Indice].Cells[(int)ENumColDGVListaPedidos.ID_Pedido].Value == Elemento)
                        {
                            PedidoEncontrado = true;
                            dgvListaPedidos.Rows[Indice].Cells[(int)ENumColDGVListaPedidos.Seleccionar].Value = true;
                            dgvListaPedidos.Rows[Indice].Cells[(int)ENumColDGVListaPedidos.Seleccionar].Style.BackColor = ClsColores.Azul;
                        }
                    }
                }

                // El pedido fue eliminado desde la ventana de pedidos.
                if (!PedidoEncontrado) { PedidosEliminar.Add(Elemento); }
            }

            foreach (int Elemento in PedidosEliminar) { PedidosSeleccionados.RemoveAll(I => I == Elemento); }
        }

        private void DgvListaPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DetectarBoton = (DataGridView)sender;

            if (!(DetectarBoton.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn) && !(DetectarBoton.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && e.RowIndex >= 0)
            {
                lblMostrarNumeroPedido.Text = Convert.ToString(dgvListaPedidos.Rows[e.RowIndex].Cells[(int)ENumColDGVListaPedidos.ID_Pedido].Value);

                ActualizaInformacionPedido((int)dgvListaPedidos.Rows[e.RowIndex].Cells[(int)ENumColDGVListaPedidos.ID_Pedido].Value);
            }
        }

        private void DgvListaPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && (string)dgvListaPedidos.Rows[e.RowIndex].Cells[(int)ENumColDGVListaPedidos.EsDelivery].Value == "NO")
            {
                using (FrmMesasReservadas FormMesasReservadas = new FrmMesasReservadas((int)dgvListaPedidos.Rows[e.RowIndex].Cells[(int)ENumColDGVListaPedidos.ID_Pedido].Value))
                {
                    FormMesasReservadas.ShowDialog();
                }
            }
            else if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
                {
                    // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                    if (dgvListaPedidos.Rows[e.RowIndex].Cells[(int)ENumColDGVListaPedidos.Seleccionar].Value != null)
                    {
                        if (!(bool)dgvListaPedidos.Rows[e.RowIndex].Cells[(int)ENumColDGVListaPedidos.Seleccionar].Value && e.RowIndex != UltimaFilaSeleccionada)
                        {
                            dgvListaPedidos.Rows[e.RowIndex].Cells[(int)ENumColDGVListaPedidos.Seleccionar].Style.BackColor = ClsColores.Azul;
                        }
                        else
                        {
                            dgvListaPedidos.Rows[e.RowIndex].Cells[(int)ENumColDGVListaPedidos.Seleccionar].Style.BackColor = ClsColores.GrisOscuroFondo;
                        }
                    }

                    dgvListaPedidos.ClearSelection();
                    UltimaFilaSeleccionada = e.RowIndex;
                }

                if (dgvListaPedidos.EndEdit())
                {
                    // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                    if (dgvListaPedidos.Rows[e.RowIndex].Cells[(int)ENumColDGVListaPedidos.Seleccionar].Value != null)
                    {
                        if ((bool)dgvListaPedidos.Rows[e.RowIndex].Cells[(int)ENumColDGVListaPedidos.Seleccionar].Value)
                        {
                            PedidosSeleccionados.RemoveAll(I => I == (int)dgvListaPedidos.Rows[e.RowIndex].Cells[(int)ENumColDGVListaPedidos.ID_Pedido].Value);
                            PedidosSeleccionados.Add((int)dgvListaPedidos.Rows[e.RowIndex].Cells[(int)ENumColDGVListaPedidos.ID_Pedido].Value);
                        }
                        else
                        {
                            PedidosSeleccionados.RemoveAll(I => I == (int)dgvListaPedidos.Rows[e.RowIndex].Cells[(int)ENumColDGVListaPedidos.ID_Pedido].Value);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Si el pedido no estaba cargado, lo carga, si ya estaba cargado, lo actualiza
        /// </summary>
        private void ActualizaInformacionPedido(int _ID_Pedido)
        {
            string InformacionDelError = string.Empty;

            ClsDetalles Detalles = new ClsDetalles();
            List<Detalle> PlatosSinCocinar = Detalles.LeerListado(_ID_Pedido, ClsDetalles.ETipoDeListado.ParaCocina, ref InformacionDelError);

            if (PlatosSinCocinar != null)
            {
                dgvPlatosPorMesa.Rows.Clear();

                string Nota = string.Empty;

                foreach (Detalle Elemento in PlatosSinCocinar)
                {
                    int NumeroDeFila = dgvPlatosPorMesa.Rows.Add();

                    dgvPlatosPorMesa.Rows[NumeroDeFila].Cells[(int)ENumColDGVPlatosPorMesa.ID_Pedido].Value = Elemento.Pedido.ID_Pedido;
                    dgvPlatosPorMesa.Rows[NumeroDeFila].Cells[(int)ENumColDGVPlatosPorMesa.Articulo].Value = Elemento.Articulo.Nombre;
                    dgvPlatosPorMesa.Rows[NumeroDeFila].Cells[(int)ENumColDGVPlatosPorMesa.Detalle].Value = Elemento.Articulo.Descripcion;

                    if (Elemento.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.NoCocinado)
                    {
                        dgvPlatosPorMesa.Rows[NumeroDeFila].Cells[(int)ENumColDGVPlatosPorMesa.Cantidad].Value = Elemento.Cantidad;
                    }
                    else
                    {
                        dgvPlatosPorMesa.Rows[NumeroDeFila].Cells[(int)ENumColDGVPlatosPorMesa.Cantidad].Value = Elemento.CantidadAgregada;
                    }

                    Nota = Elemento.Pedido.Nota;
                }

                lblDetallesDelPedido.Text = Nota.ToUpper();

                dgvPlatosPorMesa.ClearSelection();
            }
            else if (InformacionDelError == string.Empty)
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al cargar el pedido");
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al cargar el pedido");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PrintPageEventHandler(object sender, PrintPageEventArgs e)
        {
            string InformacionDelError = string.Empty;

            ClsImpresionTickets.PlatosRecienCocinados(ref e, ref InformacionDelError, ID_PedidoImprimir);

            if (InformacionDelError != string.Empty)
            {
                MessageBox.Show(InformacionDelError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TmrActualizaPedidos_Tick(object sender, EventArgs e)
        {
            TiempoActualizar++;

            if (TiempoActualizar >= 20)
            {
                CargarDGVListarPedidos();
                TiempoActualizar = 0;
            }
        }

        private void BtnForzarActualizacion_Click(object sender, EventArgs e) => CargarDGVListarPedidos();

        /// <summary>
        /// Devuelve una unica instancia del formulario (Patron singleton)
        /// </summary>
        /// <returns></returns>
        public static FrmCocina ObtenerInstancia()
        {
            if (InstanciaForm == null) { InstanciaForm = new FrmCocina(); }

            return InstanciaForm;
        }

        #region Propiedades
        #endregion
    }
}
