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
using Negocio.Clases_por_tablas;
using Procuratio.FrmsSecundarios.FrmsTemporales.FrmDelivery;
using System.Threading;
using Procuratio.FrmsSecundarios.FrmsTemporales.FrmClientes;
using Procuratio.ClsDeApoyo;

namespace Procuratio
{
    public partial class FrmCliente : Form
    {
        #region Carga
        public FrmCliente(EMostrarOcultarColumnas _ColumnasMostrar)
        {
            InitializeComponent();

            MostrarOcultarColumnas(_ColumnasMostrar);
        }

        private void MostrarOcultarColumnas(EMostrarOcultarColumnas _ColumnasMostrar)
        {
            switch (_ColumnasMostrar)
            {
                case EMostrarOcultarColumnas.NoMostrarSeleccionarEnviar:
                    {
                        dgvListarClientes.Columns[(int)ENumColDGVCliente.EnviarCliente].Visible = false;
                        dgvListarClientes.Columns[(int)ENumColDGVCliente.Seleccionar].Visible = false;

                        btnCargarClientes.Visible = false;
                        btnMostrarClientesSeleccionados.Visible = false;
                        btnCancelarSeleccion.Visible = false;
                        lblTotalClientes.Visible = false;
                        lblResultadoTotalClientes.Visible = false;
                        break;
                    }
                case EMostrarOcultarColumnas.MostrarEnviar:
                    {
                        dgvListarClientes.Columns[(int)ENumColDGVCliente.EnviarCliente].Visible = true;
                        dgvListarClientes.Columns[(int)ENumColDGVCliente.Seleccionar].Visible = false;
                        break;
                    }
                case EMostrarOcultarColumnas.MostrarSeleccionar:
                    {
                        dgvListarClientes.Columns[(int)ENumColDGVCliente.EnviarCliente].Visible = false;
                        dgvListarClientes.Columns[(int)ENumColDGVCliente.Seleccionar].Visible = true;

                        btnCargarClientes.Visible = false;
                        btnMostrarClientesSeleccionados.Visible = true;
                        btnCancelarSeleccion.Visible = true;
                        lblTotalClientes.Visible = true;
                        lblResultadoTotalClientes.Visible = true;
                        break;
                    }
                case EMostrarOcultarColumnas.MostrarSeleccionarConBarraArrastre:
                    {
                        dgvListarClientes.Columns[(int)ENumColDGVCliente.EnviarCliente].Visible = false;
                        dgvListarClientes.Columns[(int)ENumColDGVCliente.Seleccionar].Visible = true;

                        btnMostrarClientesSeleccionados.Visible = true;
                        btnCancelarSeleccion.Visible = true;
                        lblTotalClientes.Visible = true;
                        lblResultadoTotalClientes.Visible = true;
                        btnCargarClientes.Visible = true;
                        break;
                    }
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CargarClientesDelPedido();

            FormularioCargado = true;

            CargarDGVClientes(ClsClientes.EClienteBuscar.Todos);
        }

        private void CargarClientesDelPedido()
        {
            string InformacionDelError = string.Empty;

            ClsClientesXPedidos ClientesXPedidos = new ClsClientesXPedidos();
            List<ClienteXPedido> SeleccionarClientes = ClientesXPedidos.LeerListado(ClsClientesXPedidos.ETipoListado.ClientesPedido, ref InformacionDelError, 0, ID_Pedido);

            if (SeleccionarClientes != null)
            {
                foreach (ClienteXPedido Elemento in SeleccionarClientes) { ClientesDelPedido.Add(Elemento.ID_Cliente); }
            }
        }

        /// <summary>Inicializa la variable que contendra la instancia del formulario de administracion de reservas.</summary>
        /// <param name="_FormAdministrarReservas">Instancia del formulario.</param>
        public void AsignarFormAdministrarReservas(FrmAdministrarReserva _FormAdministrarReservas) => FormAdministrarReservas = _FormAdministrarReservas;

        /// <summary>Inicializa la variable que contendra la instancia del formulario de administracion de reservas.</summary>
        /// <param name="_FormCrearEditarDelivery">Instancia del formulario.</param>
        public void AsignarFormCrearDelivery(FrmCrearEditarDelivery _FormCrearEditarDelivery) => FormCrearEditarDelivery = _FormCrearEditarDelivery;

        /// <summary>Inicializa la variable que contendra la instancia del formulario de administracion de reservas.</summary>
        /// <param name="_FormCrearMesa">Instancia del formulario.</param>
        public void AsignarFormCrearMesa(FrmCrearMesa _FormCrearMesa) => FormCrearMesa = _FormCrearMesa;

        /// <summary>
        /// Prepara el formulario para ser mostrado dentro del principal
        /// </summary>
        public void PreparaFormParaPrincipal()
        {
            pnlBarraDeArrastre.Visible = false;
            BtnUsarAsistencias.Visible = true;
        }

        public void BloquearPorVencimientoLicencia(bool _LicenciaExpirada)
        {
            btnCrearCliente.Enabled = !_LicenciaExpirada;
            btnMostrarClientesSeleccionados.Enabled = !_LicenciaExpirada;
            BtnUsarAsistencias.Enabled = !_LicenciaExpirada;
            btnCargarClientes.Enabled = !_LicenciaExpirada;
            btnCancelarSeleccion.Enabled = !_LicenciaExpirada;
            dgvListarClientes.Enabled = !_LicenciaExpirada;
        }
        #endregion

        #region Variables
        /// <summary>
        /// Enumera las columnas del DGV para poder ubicarlas y editar mas facilmente su posicion.
        /// </summary>
        private enum ENumColDGVCliente
        {
            ID_Cliente, Nombre, Apellido, Telefono, AsistenciasAcumuladas, EnviarCliente, Seleccionar
        }

        public enum EMostrarOcultarColumnas
        {
            NoMostrarSeleccionarEnviar, MostrarEnviar, MostrarSeleccionar, MostrarSeleccionarConBarraArrastre
        }

        private FrmAdministrarReserva FormAdministrarReservas = null;
        private FrmCrearEditarDelivery FormCrearEditarDelivery = null;
        private FrmCrearMesa FormCrearMesa = null;
        private readonly string TextoVisualBuscar = "Buscar por nombre de cliente...", TextoVisualApellido = "Buscar por apellido de cliente...", TextoVisualTelefono = "Buscar por telefono de cliente...";
        private List<int> ClientesDelPedido = new List<int>();
        private int ID_Pedido = -1;
        private bool FormularioCargado = false;
        private bool MostrarClientesSeleccionados = false;
        private int AsistenciasAConsumir = 0;
        private int UltimaFilaSeleccionada = -1;
        #endregion

        #region Codigo para darle estilo a los botones
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            if (BotonEnFoco.Name == btnCancelarSeleccion.Name)
            {
                BotonEnFoco.BackColor = ClsColores.Rojo;
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

        private void TxtBuscarPorApellido_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarPorApellido.Text == TextoVisualApellido) { TxtBuscarPorApellido.Text = string.Empty; }
            TxtBuscarPorApellido.ForeColor = ClsColores.GrisClaro;
        }

        private void TxtBuscarPorApellido_Leave(object sender, EventArgs e)
        {
            if (TxtBuscarPorApellido.Text == string.Empty) { TxtBuscarPorApellido.Text = TextoVisualApellido; }
            TxtBuscarPorApellido.ForeColor = ClsColores.GrisOscuro;
        }

        private void TxtBuscarPorTelefono_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarPorTelefono.Text == TextoVisualTelefono) { TxtBuscarPorTelefono.Text = string.Empty; }
            TxtBuscarPorTelefono.ForeColor = ClsColores.GrisClaro;
        }

        private void TxtBuscarPorTelefono_Leave(object sender, EventArgs e)
        {
            if (TxtBuscarPorTelefono.Text == string.Empty) { TxtBuscarPorTelefono.Text = TextoVisualTelefono; }
            TxtBuscarPorTelefono.ForeColor = ClsColores.GrisOscuro;
        }
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

        //Filtro
        private void TxtBuscarPorNombre_TextChanged(object sender, EventArgs e) => CargarDGVClientes(ClsClientes.EClienteBuscar.Filtro);
        private void TxtBuscarPorApellido_TextChanged(object sender, EventArgs e) => CargarDGVClientes(ClsClientes.EClienteBuscar.Filtro);
        private void TxtBuscarPorTelefono_TextChanged(object sender, EventArgs e) => CargarDGVClientes(ClsClientes.EClienteBuscar.Filtro);
        
        private void BtnCrearCliente_Click(object sender, EventArgs e)
        {
            using (FrmGestionCliente CrearCliente = new FrmGestionCliente())
            {
                CrearCliente.ShowDialog();

                if (CrearCliente.DialogResult == DialogResult.OK)
                {
                    LimpiarFiltros();

                    CargarDGVClientes(ClsClientes.EClienteBuscar.Todos);

                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Cliente creado con exito";
                }
            }
        }

        private void DgvListarClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView DetectarCheck = (DataGridView)sender;

            if (e.RowIndex != -1 && !(DetectarCheck.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn))
            {
                using (FrmGestionCliente EditarCliente = new FrmGestionCliente((int)dgvListarClientes.Rows[e.RowIndex].Cells[(int)ENumColDGVCliente.ID_Cliente].Value))
                {
                    EditarCliente.ShowDialog();

                    if (EditarCliente.DialogResult == DialogResult.OK)
                    {
                        CargarDGVClientes(ClsClientes.EClienteBuscar.Filtro);
                    }
                }
            }
        }

        // Enviar un cliente
        private void DgvListarClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewButtonColumn && !(DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn) && e.RowIndex >= 0)
            {
                if (FormAdministrarReservas != null)
                {
                    FormAdministrarReservas.S_ID_Cliente = (int)dgvListarClientes.Rows[e.RowIndex].Cells[(int)ENumColDGVCliente.ID_Cliente].Value;
                }
                else
                {
                    FormCrearEditarDelivery.S_ID_Cliente = (int)dgvListarClientes.Rows[e.RowIndex].Cells[(int)ENumColDGVCliente.ID_Cliente].Value;
                }

                DialogResult = DialogResult.OK;
                Close(); 
            }
        }

        //Enviar varios clientes
        private void BtnCargarClientes_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();

            CargarDGVClientes(ClsClientes.EClienteBuscar.Todos);

            int TotalDeFilas = dgvListarClientes.Rows.Count;
            List<int> EnviarClientes = new List<int>();
            bool OperacionInvalida = false;

            string InformacionDelError = string.Empty;

            ClsClientesXPedidos ClientesXPedido = new ClsClientesXPedidos();
            List<ClienteXPedido> BuscarRepeticiones = null;

            // IndiceArray me mantiene el indice real de asignacion
            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                //Pregunto si la celda es diferente a null
                if (dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.Seleccionar].Value != null)
                {
                    //Casteo el check del objeto a booleano y pregunto si es true
                    if ((bool)dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.Seleccionar].Value)
                    {
                        BuscarRepeticiones = ClientesXPedido.LeerListado(ClsClientesXPedidos.ETipoListado.AsistenciasSuperadas, ref InformacionDelError, (int)dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.ID_Cliente].Value);

                        if (BuscarRepeticiones != null)
                        {
                            if (BuscarRepeticiones.Count < 2)
                            {
                                EnviarClientes.Add((int)dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.ID_Cliente].Value);
                            }
                            else
                            {
                                OperacionInvalida = true;
                                dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.Seleccionar].Value = false;

                                using (FrmInformacion FormInformacion = new FrmInformacion($"Se detecto que el cliente {(string)dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.Nombre].Value} {(string)dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.Apellido].Value} " +
                                        $"(telefono {Convert.ToString(dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.Telefono].Value)}) ya fue " +
                                        $"cargado en 2 pedidos el dia de hoy.", ClsColores.Blanco, 200, 300))
                                {
                                    FormInformacion.ShowDialog();
                                }
                            }
                        }
                        else if (InformacionDelError == string.Empty)
                        {
                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al listar los clientes");
                            MessageBox.Show("Fallo al listar los clientes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            OperacionInvalida = true;
                        }
                        else
                        {
                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al listar los clientes");
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            OperacionInvalida = true;
                        }
                    }
                }
            }

            if (!OperacionInvalida)
            {
                FormCrearMesa.S_ClientesDelPedido = EnviarClientes;

                FrmMesas.ObtenerInstancia().S_CargoClientesAlPedido = DialogResult.OK;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                EnviarClientes.Clear();
            }
        }

        private void BtnCargarLista_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();

            CargarDGVClientes(ClsClientes.EClienteBuscar.Todos);
        }

        private void BtnCancelarSeleccion_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();

            CargarDGVClientes(ClsClientes.EClienteBuscar.Todos);
            DesmarcarClientes();
        }

        private void LimpiarFiltros()
        {
            FormularioCargado = false;
            txtBuscarPorNombre.Text = TextoVisualBuscar;
            TxtBuscarPorApellido.Text = TextoVisualApellido;
            TxtBuscarPorTelefono.Text = TextoVisualTelefono;
            FormularioCargado = true;
        }

        private void DesmarcarClientes()
        {
            int TotalDeFilas = dgvListarClientes.Rows.Count;
            ClientesDelPedido.Clear();

            // IndiceArray me mantiene el indice real de asignacion
            for (int Indice = 0; Indice < TotalDeFilas; Indice++) 
            { 
                dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.Seleccionar].Value = false;
                ClsColores.MarcarFilaDGV(dgvListarClientes, Indice, false);
            }

            lblResultadoTotalClientes.Text = "0";
        }

        private void DgvListarClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
                {
                    // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                    if (dgvListarClientes.Rows[e.RowIndex].Cells[(int)ENumColDGVCliente.Seleccionar].Value != null)
                    {
                        if (!(bool)dgvListarClientes.Rows[e.RowIndex].Cells[(int)ENumColDGVCliente.Seleccionar].Value && e.RowIndex != UltimaFilaSeleccionada)
                        {
                            ClsColores.MarcarFilaDGV(dgvListarClientes, e.RowIndex, true);
                        }
                        else
                        {
                            ClsColores.MarcarFilaDGV(dgvListarClientes, e.RowIndex, false);
                        }
                    }

                    UltimaFilaSeleccionada = e.RowIndex;
                }

                if (dgvListarClientes.EndEdit())
                {
                    int TotalDeFilas = dgvListarClientes.Rows.Count;

                    // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                    if (dgvListarClientes.Rows[e.RowIndex].Cells[(int)ENumColDGVCliente.Seleccionar].Value != null)
                    {
                        if ((bool)dgvListarClientes.Rows[e.RowIndex].Cells[(int)ENumColDGVCliente.Seleccionar].Value)
                        {
                            ClientesDelPedido.RemoveAll(I => I == (int)dgvListarClientes.Rows[e.RowIndex].Cells[(int)ENumColDGVCliente.ID_Cliente].Value);
                            ClientesDelPedido.Add((int)dgvListarClientes.Rows[e.RowIndex].Cells[(int)ENumColDGVCliente.ID_Cliente].Value);
                        }
                        else
                        {
                            ClientesDelPedido.RemoveAll(I => I == (int)dgvListarClientes.Rows[e.RowIndex].Cells[(int)ENumColDGVCliente.ID_Cliente].Value);
                        }
                    }
                    
                    lblResultadoTotalClientes.Text = Convert.ToString(ClientesDelPedido.Count);
                }
            }
        }

        private void BtnMostrarClientesSeleccionados_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();

            MostrarClientesSeleccionados = true;
            CargarDGVClientes(ClsClientes.EClienteBuscar.Todos);
            MostrarClientesSeleccionados = false;
        }

        private void BtnUsarAsistencias_Click(object sender, EventArgs e)
        {
            using (FrmAsistenciasAConssumir CantidadDeAsistenciasAConsumir = new FrmAsistenciasAConssumir())
            {
                CargarDGVClientes(ClsClientes.EClienteBuscar.Todos);
                int TotalDeFilas = dgvListarClientes.Rows.Count;
                bool SeSeleccionoAlgunCliente = false;

                // IndiceArray me mantiene el indice real de asignacion
                for (int Indice = 0; Indice < TotalDeFilas; Indice++)
                {
                    //Pregunto si la celda es diferente a null
                    if (dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.Seleccionar].Value != null)
                    {
                        //Casteo el check del objeto a booleano y pregunto si es true
                        if ((bool)dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.Seleccionar].Value)
                        {
                            SeSeleccionoAlgunCliente = true;
                        }
                    }
                }

                if (SeSeleccionoAlgunCliente)
                {
                    CantidadDeAsistenciasAConsumir.AsignarFormCliente(this);
                    CantidadDeAsistenciasAConsumir.ShowDialog();

                    if (CantidadDeAsistenciasAConsumir.DialogResult == DialogResult.OK)
                    {
                        bool SuperoLaCantidad = false;
                        List<int> ID_ClientesAConsumir = new List<int>();

                        // IndiceArray me mantiene el indice real de asignacion
                        for (int Indice = 0; Indice < TotalDeFilas; Indice++)
                        {
                            //Pregunto si la celda es diferente a null
                            if (dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.Seleccionar].Value != null)
                            {
                                //Casteo el check del objeto a booleano y pregunto si es true
                                if ((bool)dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.Seleccionar].Value)
                                {
                                    if ((int)dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.AsistenciasAcumuladas].Value < AsistenciasAConsumir)
                                    {
                                        SuperoLaCantidad = true;

                                        using (FrmInformacion FormInformacion = new FrmInformacion($"El cliente {Convert.ToString(dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.Nombre].Value)} {Convert.ToString(dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.Apellido].Value)} " +
                                                $"con {Convert.ToString(dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.AsistenciasAcumuladas].Value)} asistencias, no alcanza la " +
                                                $"cantidad indicada ({Convert.ToString(AsistenciasAConsumir)} asistencia/s).", ClsColores.Blanco, 200, 300))
                                        {
                                            FormInformacion.ShowDialog();
                                        }
                                    }
                                    else
                                    {
                                        ID_ClientesAConsumir.Add((int)dgvListarClientes.Rows[Indice].Cells[(int)ENumColDGVCliente.ID_Cliente].Value);
                                    }
                                }
                            }
                        }

                        if (!SuperoLaCantidad && ID_ClientesAConsumir.Count > 0)
                        {
                            string InformacionDelError = string.Empty;

                            ClsClientesXPedidos ClienteXPedido = new ClsClientesXPedidos();
                            List<ClienteXPedido> ListaDeAsisteciasVigentes = null;

                            foreach (int Elemento in ID_ClientesAConsumir)
                            {
                                ListaDeAsisteciasVigentes = ClienteXPedido.LeerListado(ClsClientesXPedidos.ETipoListado.CantidadAsistencias, ref InformacionDelError, Elemento);

                                if (ListaDeAsisteciasVigentes != null)
                                {
                                    int ContadorCantidadConsumida = 0;

                                    foreach (ClienteXPedido ElementoSecundario in ListaDeAsisteciasVigentes)
                                    {
                                        if (ContadorCantidadConsumida == AsistenciasAConsumir) { break; }

                                        ElementoSecundario.ID_EstadoClienteXPedido = (int)ClsEstadosClientesXPedidos.EEstadosClientesXPedidos.Usado;

                                        if (ClienteXPedido.Actualizar(ElementoSecundario, ref InformacionDelError) > 0)
                                        {

                                        }
                                        else if (InformacionDelError == string.Empty)
                                        {
                                            MessageBox.Show("Fallo al actualizar un cliente para consumir la/s asistencia/s", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        else
                                        {
                                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }

                                        ContadorCantidadConsumida++;
                                    }
                                }
                                else if (InformacionDelError == string.Empty)
                                {
                                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al listar un cliente para consumir la/s asistencia/s");
                                    MessageBox.Show("Fallo al listar un cliente para consumir la/s asistencia/s", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al listar un cliente para consumir la/s asistencia/s");
                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }

                            DesmarcarClientes();

                            using (FrmListadoAsistenciasConsumidas FormListadoAsistenciasConsumidas = new FrmListadoAsistenciasConsumidas(ID_ClientesAConsumir))
                            {
                                FormListadoAsistenciasConsumidas.ShowDialog();

                                CargarDGVClientes(ClsClientes.EClienteBuscar.Todos);
                            }
                        }

                        AsistenciasAConsumir = 0;
                    }
                }
                else
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion($"Debe seleccionar al menos un cliente.", ClsColores.Blanco, 200, 300))
                    {

                        FormInformacion.ShowDialog();
                    }
                }
            }
        }

        private void CargarDGVClientes(ClsClientes.EClienteBuscar _TipoDeListado)
        {
            if (FormularioCargado)
            {
                string NombreCliente = string.Empty;
                string ApellidoCliente = string.Empty;
                string TelefonoCliente = string.Empty;

                if (txtBuscarPorNombre.Text != TextoVisualBuscar) { NombreCliente = txtBuscarPorNombre.Text; }
                if (TxtBuscarPorApellido.Text != TextoVisualApellido) { ApellidoCliente = TxtBuscarPorApellido.Text; }
                if (TxtBuscarPorTelefono.Text != TextoVisualTelefono) { TelefonoCliente = TxtBuscarPorTelefono.Text; }

                dgvListarClientes.Rows.Clear();

                string InformacionDelError = string.Empty;

                ClsClientes Clientes = new ClsClientes();

                List<Cliente> ListarClientes = Clientes.LeerListado(_TipoDeListado, ref InformacionDelError, NombreCliente, ApellidoCliente, TelefonoCliente);

                ClsClientesXPedidos ClienteXPedidos = new ClsClientesXPedidos();
                List<ClienteXPedido> CantidadAsistenciasVigentes = null;

                if (ListarClientes != null)
                {
                    foreach (Cliente Elemento in ListarClientes)
                    {
                        int NumeroDeFila = dgvListarClientes.Rows.Add();

                        dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVCliente.ID_Cliente].Value = Elemento.ID_Cliente;
                        dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVCliente.Nombre].Value = Elemento.Nombre;
                        dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVCliente.Apellido].Value = Elemento.Apellido;
                        dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVCliente.Telefono].Value = Elemento.Telefono;

                        CantidadAsistenciasVigentes = ClienteXPedidos.LeerListado(ClsClientesXPedidos.ETipoListado.CantidadAsistencias, ref InformacionDelError, Elemento.ID_Cliente);

                        if (CantidadAsistenciasVigentes != null)
                        {
                            dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVCliente.AsistenciasAcumuladas].Value = CantidadAsistenciasVigentes.Count;
                        }
                        else
                        {
                            dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVCliente.AsistenciasAcumuladas].Value = 0;
                        }

                        dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVCliente.EnviarCliente].Value = "Enviar";
                        dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVCliente.Seleccionar].Value = false;

                        foreach (int ElementoSecundario in ClientesDelPedido)
                        {
                            if (Elemento.ID_Cliente == ElementoSecundario)
                            {
                                dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVCliente.Seleccionar].Value = true;
                                ClsColores.MarcarFilaDGV(dgvListarClientes, NumeroDeFila, true);
                                break;
                            }
                        }

                        if ((bool)dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVCliente.Seleccionar].Value == false && MostrarClientesSeleccionados)
                        {
                            dgvListarClientes.Rows.Remove(dgvListarClientes.Rows[NumeroDeFila]);
                        }
                    }

                    UltimaFilaSeleccionada = -1;

                    if (MostrarClientesSeleccionados && dgvListarClientes.Rows.Count == 0)
                    {
                        MostrarClientesSeleccionados = false;

                        CargarDGVClientes(ClsClientes.EClienteBuscar.Todos);

                        using (FrmInformacion FormInformacion = new FrmInformacion($"No se encontro ningun cliente seleccionado, lista " +
                                $"cargada nuevamente.", ClsColores.Blanco, 200, 300))
                        {
                            FormInformacion.ShowDialog();
                        }
                    }

                    lblResultadoTotalClientes.Text = Convert.ToString(ClientesDelPedido.Count);
                }
                else if (InformacionDelError == string.Empty)
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al listar los clientes");
                    MessageBox.Show("Fallo al listar los clientes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al listar los clientes");
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            dgvListarClientes.ClearSelection();
        }

        private void TxtBuscarPorTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        /// <summary>
        /// Marcar los clientes ya cargados en un  ClienteXPedido
        /// </summary>
        public int S_ID_Pedido { set { ID_Pedido = value; } }

        /// <summary>
        /// Indica las asistencias acumuladas que se descontaran
        /// </summary>
        public int S_AsistenciasAConsumir { set { AsistenciasAConsumir = value; } }
        #endregion
    }
}
