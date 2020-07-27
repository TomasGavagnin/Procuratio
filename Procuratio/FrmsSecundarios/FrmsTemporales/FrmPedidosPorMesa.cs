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
using Procuratio.FrmsSecundarios.FrmsTemporales.FrmMesas;
using Negocio.Clases_por_tablas;
using Procuratio.FrmsSecundarios.FrmsTemporales.FrmDelivery;
using System.Drawing.Printing;
using Procuratio.ClsDeApoyo;
using Procuratio.FrmGenerales;
using Negocio.Clases_de_apoyo;

namespace Procuratio
{
    public partial class FrmPedidosPorMesa : Form
    {
        #region Carga
        /// <summary>
        /// Lista el pedido de un pedido normal.
        /// </summary>
        /// <param name="_ID_Pedido">ID del pedido.</param>
        /// <param name="_ID_EstadoPedido">ID del estado que tiene.</param>
        /// <param name="_ID_Chef">ID del chef del pedido.</param>
        /// <param name="_MesasDelPedido">Mesas que usa el pedido.</param>
        public FrmPedidosPorMesa(int _ID_Pedido, int _ID_EstadoPedido, int _ID_Chef, List<int> _MesasDelPedido)
        {
            InitializeComponent();

            ID_Pedido = _ID_Pedido;
            ID_EstadoPedido = _ID_EstadoPedido;
            ID_Chef = _ID_Chef;
            MesasDelPedido = _MesasDelPedido;
        }

        /// <summary>
        /// Lista el pedido de un delivery.
        /// </summary>
        /// <param name="_ID_Pedido">ID del pedido.</param>
        /// <param name="_ID_Chef">ID del chef.</param>
        public FrmPedidosPorMesa(int _ID_Pedido, int _ID_Chef, FrmCrearEditarDelivery _FormCrearEditarDelivery)
        {
            InitializeComponent();

            ID_Pedido = _ID_Pedido;
            ID_Chef = _ID_Chef;
            FormCrearEditarDelivery = _FormCrearEditarDelivery;
        }

        private void FrmPedidosPorMesa_Load(object sender, EventArgs e)
        {
            CargarCMBCategorias();

            if (FormCrearEditarDelivery == null)
            {
                lblPedido.Text += Convert.ToString(ID_Pedido);
                CargarCMBMesas();
                CargarDGVDetallesDelPedido(ClsDetalles.ETipoDeListado.PorIDPedido);
                ComprobarEstadoPedido();
            }
            else
            {
                PreparaFormParaDelivery();

                if (ID_Pedido != -1)
                {
                    CargarDGVDetallesDelPedido(ClsDetalles.ETipoDeListado.PorIDPedido);
                    lblPedido.Text += Convert.ToString(ID_Pedido);
                }
                else
                {
                    btnImprimirTicket.Visible = false;
                }
            }
        }

        private void PreparaFormParaDelivery()
        {
            lblEstadoDelPedido.Visible = false;
            cmbMesas.Visible = false;
            PicBTNHabilitaEdicionEspecial.Visible = false;
            lblPedido.Location = new Point(12, 40);
            btnPedidoRecibido.Visible = false;
            btnPreCuenta.Visible = false;
            btnMostrarCocina.Location = new Point(btnPedidoRecibido.Location.X, btnPedidoRecibido.Location.Y);
            btnImprimirTicket.Location = new Point(btnPreCuenta.Location.X, btnPreCuenta.Location.Y);
            btnImprimirTicket.Enabled = HabilitaBotones;

            if (ID_Pedido == -1)
            {
                PicBTNActualizarLista.Enabled = false;
                btnMostrarCocina.Enabled = false;
                lblPedido.Visible = false;
            }
            else
            {
                btnMostrarCocina.Enabled = HabilitaBotones;
            }
        }

        /// <summary>Carga el ComboBox con datos.</summary>
        private void CargarCMBCategorias()
        {
            string InformacionDelError = string.Empty;

            ClsCategoriasArticulos Categorias = new ClsCategoriasArticulos();
            List<CategoriaArticulo> ListarCategorias = Categorias.LeerListado(ClsCategoriasArticulos.ETipoListado.CategoriasActivas, ref InformacionDelError);

            if (ListarCategorias != null)
            {
                // Nombre de la columna que contiene el nombre
                cmbCategoria.DisplayMember = "Nombre";
                // Nombre de la columna que contiene el ID
                cmbCategoria.ValueMember = "ID_CategoriaArticulo";

                // Creo el item para listar todo
                ListarCategorias.Add(new CategoriaArticulo { ID_CategoriaArticulo = 0, Nombre = "Todas las categorias" });
                
                // Llenar el combo
                cmbCategoria.DataSource = ListarCategorias.ToList();

                cmbCategoria.SelectedValue = 0;
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al cargar los perfiles", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        /// <summary>
        /// Habilita o deshabilita el botones en funcion del estado del pedido al cargar el formulario
        /// </summary>
        private void ComprobarEstadoPedido()
        {
            if (FormCrearEditarDelivery == null)
            {
                switch ((ClsEstadosPedidos.EEstadosPedidos)ID_EstadoPedido)
                {
                    case ClsEstadosPedidos.EEstadosPedidos.Pendiente:
                        {
                            btnPedidoRecibido.Enabled = false;
                            btnPreCuenta.Enabled = false;
                            btnMostrarCocina.Enabled = false;
                            break;
                        }
                    case ClsEstadosPedidos.EEstadosPedidos.EnProceso:
                        {
                            btnPedidoRecibido.Enabled = false;
                            btnPreCuenta.Enabled = false;
                            btnMostrarCocina.Enabled = true;
                            break;
                        }
                    case ClsEstadosPedidos.EEstadosPedidos.ParaEntrega:
                        {
                            btnPedidoRecibido.Enabled = true;
                            btnPreCuenta.Enabled = false;
                            btnAñadirArticulos.Enabled = false;
                            btnEnviarPedido.Enabled = false;
                            btnAumentaUnidad.Enabled = false;
                            btnDisminuyeUnidad.Enabled = false;
                            btnEliminarPedido.Enabled = false;
                            btnMostrarCocina.Enabled = false;
                            PicBTNHabilitaEdicionEspecial.Enabled = false;
                            break;
                        }
                    case ClsEstadosPedidos.EEstadosPedidos.Entregado:
                        {
                            btnPedidoRecibido.Enabled = false;
                            btnPreCuenta.Enabled = true;
                            btnMostrarCocina.Enabled = false;
                            break;
                        }
                    case ClsEstadosPedidos.EEstadosPedidos.EsperandoPago:
                        {
                            // No deberia entrar aca (Codigo de seguridad para bloquear botones)
                            btnPedidoRecibido.Enabled = false;
                            btnPreCuenta.Enabled = true;
                            btnAumentaUnidad.Enabled = false;
                            btnDisminuyeUnidad.Enabled = false;
                            btnEliminarPedido.Enabled = false;
                            btnEnviarPedido.Enabled = false;
                            btnAñadirArticulos.Enabled = false;
                            btnMostrarCocina.Enabled = false;
                            PicBTNActualizarLista.Enabled = false;
                            PicBTNHabilitaEdicionEspecial.Enabled = false;
                            break;
                        }
                }

                ActualizaLabelEstadoPedido((ClsEstadosPedidos.EEstadosPedidos)ID_EstadoPedido);
            }
        }

        private void FrmPedidosPorMesa_Shown(object sender, EventArgs e)
        {
            FormularioCargado = true;
            CargarDGVCarta(ClsArticulos.ETipoListado.ArticulosActivos);
        }

        private void CargarCMBMesas()
        {
            foreach (int Elemento in MesasDelPedido) { cmbMesas.Items.Add(Elemento); }
        }

        public void BloquearPorDeliveryEntregado()
        {
            btnEnviarPedido.Enabled = false;
            btnAñadirArticulos.Enabled = false;
            btnAumentaUnidad.Enabled = false;
            btnDisminuyeUnidad.Enabled = false;
            btnResetearSeleccionCarta.Enabled = false;
            btnMostrarCocina.Enabled = false;
            btnEliminarPedido.Enabled = false;
            txtBuscarPorNombre.Enabled = false;
            cmbCategoria.Enabled = false;
            PicBTNActualizarLista.Enabled = false;
            PicBTNHabilitaEdicionEspecial.Enabled = false;
            dgvArticulosPedido.Enabled = false;
            dgvCarta.Enabled = false;

            HabilitaBotones = false;
        }

        /// <summary>Inicializa la variable que contendra la instancia del formulario principal.</summary>
        /// <param name="_FormCrearEditarDelivery">Instancia del formulario principal.</param>
        public void AsignarFormCrearEditarDelivery(FrmCrearEditarDelivery _FormCrearEditarDelivery) => FormCrearEditarDelivery = _FormCrearEditarDelivery;
        #endregion

        #region Variables
        /// <summary>
        /// Enumera las columnas del DGV para poder ubicarlas y editar mas facilmente su posicion.
        /// </summary>
        private enum ENumColDGVArticulosDelPedido
        {
            ID_Articulo, Articulo, Cantidad, PrecioUnitario, Subtotal, Enviado, Seleccionar
        }

        /// <summary>
        /// Enumera las columnas del DGV para poder ubicarlas y editar mas facilmente su posicion.
        /// </summary>
        private enum ENumColDGVCarta
        {
            ID_Articulo, Nombre, Descripcion, Categoria, Precio, Seleccionar
        }

        private const string Pendiente = "Pedido = Pendiente", EnProceso = "Pedido = En proceso", ParaEntrega = "Pedido = Para entrega", Entregado = "Pedido = Entregado", EsperandoPago = "Esperando el pago";
        private const string TextoVisualBuscar = "Buscar por nombre de articulo...";
        private int Acumulador = 0;
        private bool Invertir = true;
        private bool FormularioCargado = false;
        private bool HabilitaBotones = true; // Bloquea los botones si el pedido ya finalizo (o se elimino)
        private List<int> MesasDelPedido = new List<int>();
        private List<int> ArticulosDeCartaMarcados = new List<int>();
        private int ID_Pedido = -1;
        private int ID_EstadoPedido = -1;
        private int ID_Chef = -1;
        private bool HabilitarEdicionEspecial = false;
        private int UltimaFilaSeleccionada = -1;

        FrmCrearEditarDelivery FormCrearEditarDelivery = null;
        #endregion

        #region Estilo
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            if (BotonEnFoco.Name == btnDisminuyeUnidad.Name || BotonEnFoco.Name == btnEliminarPedido.Name || BotonEnFoco.Name == btnResetearSeleccionCarta.Name)
            {
                BotonEnFoco.BackColor = ClsColores.Rojo;
            }
            else if (BotonEnFoco.Name == btnImprimirTicket.Name)
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

        private void ColorFondoBotones_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;

            if (PictureBoxEnFoco.Name == PicBTNActualizarLista.Name)
            {
                PictureBoxEnFoco.BackColor = ClsColores.VioletaOscuro;
            }
            else if (PictureBoxEnFoco.Name == PicBTNHabilitaEdicionEspecial.Name)
            {
                PictureBoxEnFoco.BackColor = ClsColores.NaranjaClaro;
            }
            else
            {
                PictureBoxEnFoco.BackColor = ClsColores.Rojo;
            }
        }

        private void ColorFondoBotones_MouseLeave(object sender, EventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;

            if (PictureBoxEnFoco.Name == PicBTNHabilitaEdicionEspecial.Name)
            {
                if (!HabilitarEdicionEspecial)
                {
                    PictureBoxEnFoco.BackColor = ClsColores.Transparente;
                }
            }
            else
            {
                PictureBoxEnFoco.BackColor = ClsColores.Transparente;
            }
        }

        private void TxtBuscarPorNombre_Enter(object sender, EventArgs e)
        {
            FormularioCargado = false;
            if (txtBuscarPorNombre.Text == TextoVisualBuscar) { txtBuscarPorNombre.Text = string.Empty; }
            txtBuscarPorNombre.ForeColor = ClsColores.GrisClaro;
            FormularioCargado = true;
        }

        private void TxtBuscarPorNombre_Leave(object sender, EventArgs e)
        {
            FormularioCargado = false;
            if (txtBuscarPorNombre.Text == string.Empty) { txtBuscarPorNombre.Text = TextoVisualBuscar; }
            txtBuscarPorNombre.ForeColor = ClsColores.GrisOscuro;
            FormularioCargado = true;
        }

        private void tmrColor_Tick(object sender, EventArgs e)
        {
            if (Acumulador >= 65)
            {
                Invertir = false;
            }
            else if (Acumulador <= 0)
            {
                Invertir = true;
            }

            if (Invertir)
            {
                Acumulador += 5;
            }
            else
            {
                Acumulador -= 5;
            }

            picBTNInformacion.BackColor = Color.FromArgb(224, 94 + Acumulador, 1);
        }
        #endregion

        #region Filtro
        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e) => CargarDGVCarta(ClsArticulos.ETipoListado.Filtro);

        private void TxtBuscarPorNombre_TextChanged(object sender, EventArgs e) => CargarDGVCarta(ClsArticulos.ETipoListado.Filtro);
        #endregion

        private void DgvCarta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                int TotalDeFilas = dgvCarta.Rows.Count;

                // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                if (dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.Seleccionar].Value != null)
                {
                    if (!(bool)dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.Seleccionar].Value && e.RowIndex != UltimaFilaSeleccionada)
                    {
                        ClsColores.MarcarFilaDGV(dgvCarta, e.RowIndex, true);
                    }
                    else
                    {
                        ClsColores.MarcarFilaDGV(dgvCarta, e.RowIndex, false);
                    }
                }

                // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                if (dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.Seleccionar].Value != null)
                {
                    if (!(bool)dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.Seleccionar].Value && e.RowIndex != UltimaFilaSeleccionada)
                    {
                        ArticulosDeCartaMarcados.Add((int)dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.ID_Articulo].Value);
                    }
                    else
                    {
                        ArticulosDeCartaMarcados.RemoveAll(I => I == (int)dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.ID_Articulo].Value);
                    }
                }

                UltimaFilaSeleccionada = e.RowIndex;
            }
        }

        private void dgvArticulosPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                if (dgvArticulosPedido.Rows[e.RowIndex].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value != null)
                {
                    if (!(bool)dgvArticulosPedido.Rows[e.RowIndex].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value && e.RowIndex != UltimaFilaSeleccionada)
                    {
                        ClsColores.MarcarFilaDGV(dgvArticulosPedido, e.RowIndex, true);
                    }
                    else
                    {
                        ClsColores.MarcarFilaDGV(dgvArticulosPedido, e.RowIndex, false);
                    }
                }

                UltimaFilaSeleccionada = e.RowIndex;
            }
        }

        private void BtnAñadirArticulos_Click(object sender, EventArgs e)
        {
            // Al actualizar el txt se activa el filtro de buscar por nombre
            FormularioCargado = false;
            txtBuscarPorNombre.Text = TextoVisualBuscar;
            cmbCategoria.SelectedValue = 0;
            FormularioCargado = true;

            CargarDGVCarta(ClsArticulos.ETipoListado.ArticulosActivos);

            int TotalDeFilas = dgvCarta.Rows.Count;
            int TotalDeFilasSecundarias = dgvArticulosPedido.Rows.Count;

            ClsArticulos Articulos = new ClsArticulos();
            Articulo ArticuloActual = new Articulo();

            ClsDetalles Detalles = new ClsDetalles();
            Detalle AñadirArticulos = new Detalle();

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                //Pregunto si la celda es diferente a null
                if (dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.Seleccionar].Value != null)
                {
                    //Casteo el check del objeto a booleano y pregunto si es true
                    if ((bool)dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.Seleccionar].Value)
                    {
                        string InformacionDelError = string.Empty;
                        bool ArticuloYaAñadido = false;

                        ArticuloActual = Articulos.LeerPorNumero((int)dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.ID_Articulo].Value, ref InformacionDelError);

                        if (ArticuloActual != null)
                        {
                            // Busco si el articulo ya fue añadido al pedido para no agregarlo.
                            for (int IndiceSecundario = 0; IndiceSecundario < TotalDeFilasSecundarias; IndiceSecundario++)
                            {
                                if ((int)dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.ID_Articulo].Value == (int)dgvArticulosPedido.Rows[IndiceSecundario].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value)
                                {
                                    ArticuloYaAñadido = true;
                                }
                            }

                            if (!ArticuloYaAñadido)
                            {
                                int NumeroDeFila = dgvArticulosPedido.Rows.Add();

                                dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value = ArticuloActual.ID_Articulo;
                                dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Articulo].Value = ArticuloActual.Nombre;
                                dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value = 1;

                                if (FormCrearEditarDelivery == null)
                                {
                                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.PrecioUnitario].Value = ArticuloActual.Precio;
                                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Subtotal].Value = ArticuloActual.Precio;
                                }
                                else
                                {
                                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.PrecioUnitario].Value = ArticuloActual.PrecioDelivery;
                                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Subtotal].Value = ArticuloActual.PrecioDelivery;
                                }

                                // 0 indica que no son enviados a cocina 
                                if (ArticuloActual.CategoriaArticulo.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.Si)
                                {
                                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value = "NO";
                                }
                                else
                                {
                                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value = "- -";
                                }
                                
                                dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value = false;
                            }
                            else
                            {
                                using (FrmInformacion FormInformacion = new FrmInformacion($"El articulo '{ArticuloActual.Nombre}' no se agregara al pedido porque " +
                                        $"este ya se encuentra en el mismo, si quiere cambiar la cantidad, use los botones [+] para agregar " +
                                        $"y [-] para sacar.", ClsColores.Blanco, 200, 350))
                                {
                                    FormInformacion.ShowDialog();
                                }
                            }
                        }
                        else if (InformacionDelError == string.Empty)
                        {
                            MessageBox.Show($"Error al añadir los articulos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        ClsColores.MarcarFilaDGV(dgvCarta, Indice, false);

                        dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.Seleccionar].Value = false; // Descelecciono el articulo
                    }
                }
            }

            UltimaFilaSeleccionada = -1;

            DesmarcarArticulosPedido();
            ActualizarTotal();
        }

        private void BtnResetearSeleccionCarta_Click(object sender, EventArgs e)
        {
            ArticulosDeCartaMarcados.Clear();
            FormularioCargado = false;
            txtBuscarPorNombre.Text = TextoVisualBuscar;
            cmbCategoria.SelectedItem = 0;
            FormularioCargado = true;
            CargarDGVCarta(ClsArticulos.ETipoListado.ArticulosActivos);
        }

        private void BtnAumentaUnidad_Click(object sender, EventArgs e) => ActualizaCantidad(true);

        private void BtnDisminuyeUnidad_Click(object sender, EventArgs e) => ActualizaCantidad(false);

        private void BtnEliminarPedido_Click(object sender, EventArgs e)
        {
            int TotalDeFilas = dgvArticulosPedido.Rows.Count;

            string InformacionDelError = string.Empty;

            ClsDetalles Detalles = new ClsDetalles();
            Detalle EliminarDetalle = new Detalle();

            ClsArticulos Articulos = new ClsArticulos();
            Articulo VerificarSiEsCocina = new Articulo();

            bool SeElimino = false;
            bool HuboError = false;

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                //Pregunto si la celda es diferente a null
                if (dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value != null)
                {
                    //Casteo el check del objeto a booleano y pregunto si es true
                    if ((bool)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value)
                    {
                        EliminarDetalle = Detalles.LeerPorNumero(ID_Pedido, ClsDetalles.ETipoDeBusqueda.PorPedidoYArticulo, ref InformacionDelError, (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value);

                        if (EliminarDetalle != null)
                        {
                            VerificarSiEsCocina = Articulos.LeerPorNumero((int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value, ref InformacionDelError);

                            if (VerificarSiEsCocina != null)
                            {
                                if ((EliminarDetalle.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.NoCocinado || VerificarSiEsCocina.CategoriaArticulo.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.No) || HabilitarEdicionEspecial)
                                {
                                    if (dgvArticulosPedido.Rows.Count == 1 && FormCrearEditarDelivery != null)
                                    {
                                        using (FrmInformacion FormInformacion = new FrmInformacion($"No se puede eliminar el articulo {EliminarDetalle.Articulo.Nombre} " +
                                                $"debido a que el delivery quedaria vacio.", ClsColores.Blanco, 150, 300))
                                        {
                                            FormInformacion.ShowDialog();
                                        }
                                    }
                                    else
                                    {
                                        bool MinimoUnArticuloEnCocina = true;
                                        bool EliminaDeCocina = false;

                                        if (FormCrearEditarDelivery != null)
                                        {
                                            int SubTotalDeFilas = dgvArticulosPedido.Rows.Count;
                                            int ArticulosParaCocina = 0;

                                            for (int IndiceDos = 0; IndiceDos < SubTotalDeFilas; IndiceDos++)
                                            {
                                                VerificarSiEsCocina = Articulos.LeerPorNumero((int)dgvArticulosPedido.Rows[IndiceDos].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value, ref InformacionDelError);
                                                
                                                // minimo un articulo para cocina en delivery
                                                if (VerificarSiEsCocina.CategoriaArticulo.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.Si)
                                                {
                                                    ArticulosParaCocina++;

                                                    // Esto verificara que lo que quiere eliminar no es de cocina quedando un articulo
                                                    if ((bool)dgvArticulosPedido.Rows[IndiceDos].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value == true)
                                                    {
                                                        EliminaDeCocina = (bool)dgvArticulosPedido.Rows[IndiceDos].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value;
                                                    }
                                                }
                                            }

                                            if (ArticulosParaCocina == 1 && EliminaDeCocina)
                                            {
                                                MinimoUnArticuloEnCocina = false;

                                                using (FrmInformacion FormInformacion = new FrmInformacion($"No puede eliminar mas articulos de cocina ya que tiene que " +
                                                        $"haber como minimo uno en cocina.", ClsColores.Blanco, 150, 300))
                                                {
                                                    FormInformacion.ShowDialog();
                                                }
                                            }
                                        }

                                        if (MinimoUnArticuloEnCocina)
                                        {
                                            if (Detalles.Borrar(EliminarDetalle.ID_Detalle, ref InformacionDelError) != 0)
                                            {
                                                dgvArticulosPedido.Rows.Remove(dgvArticulosPedido.Rows[Indice]);
                                                Indice -= 1;
                                                TotalDeFilas -= 1;

                                                SeElimino = true;
                                            }
                                            else if (InformacionDelError == string.Empty)
                                            {
                                                MessageBox.Show("Fallo al eliminar el pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                HuboError = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                HuboError = true;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    using (FrmInformacion FormInformacion = new FrmInformacion($"El articulo '{EliminarDetalle.Articulo.Nombre}' no se puede eliminar " +
                                            $"porque ya fue cocinado.", ClsColores.Blanco, 150, 300))
                                    {
                                        FormInformacion.ShowDialog();
                                    }
                                    dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value = false;
                                }
                            }
                            else if (InformacionDelError == string.Empty)
                            {
                                MessageBox.Show("Fallo al comprobar si habia platos ya cocinados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                HuboError = true;
                            }
                            else
                            {
                                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                HuboError = true;
                            }
                        }
                        else if (InformacionDelError == string.Empty)
                        {
                            dgvArticulosPedido.Rows.Remove(dgvArticulosPedido.Rows[Indice]);
                            Indice -= 1;
                            TotalDeFilas -= 1;

                            SeElimino = true;
                        }
                        else if (InformacionDelError != string.Empty)
                        {
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            HuboError = true;
                        }
                    }
                }
            }

            if (SeElimino && !HuboError && ID_Pedido != -1)
            {
                if (dgvArticulosPedido.Rows.Count == 0)
                {
                    InformacionDelError = string.Empty;

                    ClsPedidos Pedidos = new ClsPedidos();
                    Pedido ActualizarPedido = new Pedido();

                    ActualizarPedido = Pedidos.LeerPorNumero(ID_Pedido, ref InformacionDelError);

                    if (ActualizarPedido != null)
                    {
                        ActualizarPedido.TiempoEspera = null;
                        ActualizarPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.Pendiente;

                        if (ActualizarPedido.ID_Delivery == null)
                        {
                            if (Pedidos.Actualizar(ActualizarPedido, ref InformacionDelError) != 0)
                            {
                                ActualizaLabelEstadoPedido((ClsEstadosPedidos.EEstadosPedidos)ActualizarPedido.ID_EstadoPedido);

                                btnPedidoRecibido.Enabled = false;
                                btnPreCuenta.Enabled = false;
                                btnEnviarPedido.Enabled = true;
                                btnAñadirArticulos.Enabled = true;
                            }
                            else if (InformacionDelError != string.Empty)
                            {
                                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else if (InformacionDelError == string.Empty)
                    {
                        MessageBox.Show("Fallo al actualizar el pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    bool HayArticulosParaCocina = false;
                    TotalDeFilas = dgvArticulosPedido.Rows.Count;

                    for (int Indice = 0; Indice < TotalDeFilas; Indice++)
                    {
                        VerificarSiEsCocina = Articulos.LeerPorNumero((int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value, ref InformacionDelError);
                        EliminarDetalle = Detalles.LeerPorNumero(ID_Pedido, ClsDetalles.ETipoDeBusqueda.PorPedidoYArticulo, ref InformacionDelError, (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value);

                        if (VerificarSiEsCocina != null && EliminarDetalle != null)
                        {
                            if (VerificarSiEsCocina.CategoriaArticulo.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.Si && (EliminarDetalle.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.NoCocinado || EliminarDetalle.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.CantidadAumentada))
                            {
                                HayArticulosParaCocina = true;
                            }
                        }
                        else
                        {
                            // se eliminaron articulos que todavia no estaban cargados
                            HayArticulosParaCocina = true;
                            break;
                        }
                    }

                    if (!HayArticulosParaCocina)
                    {
                        ClsPedidos Pedidos = new ClsPedidos();
                        Pedido ActualizarPedido = new Pedido();

                        ActualizarPedido = Pedidos.LeerPorNumero(ID_Pedido, ref InformacionDelError);

                        if (ActualizarPedido != null)
                        {
                            ActualizarPedido.TiempoEspera = null;
                            ActualizarPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.Entregado;

                            if (ActualizarPedido.ID_Delivery == null)
                            {
                                if (Pedidos.Actualizar(ActualizarPedido, ref InformacionDelError) != 0)
                                {
                                    ActualizaLabelEstadoPedido((ClsEstadosPedidos.EEstadosPedidos)ActualizarPedido.ID_EstadoPedido);

                                    btnPedidoRecibido.Enabled = false;
                                    btnPreCuenta.Enabled = true;
                                    btnAñadirArticulos.Enabled = true;
                                    btnEnviarPedido.Enabled = true;
                                    btnAumentaUnidad.Enabled = true;
                                    btnDisminuyeUnidad.Enabled = true;
                                    btnEliminarPedido.Enabled = true;
                                }
                                else if (InformacionDelError != string.Empty)
                                {
                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        else if (InformacionDelError == string.Empty)
                        {
                            MessageBox.Show("Fallo al actualizar el pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }

            DesmarcarArticulosPedido();
            ActualizarTotal();
        }

        /// <summary>
        /// Aumenta o disminuye la cantidad de articulos
        /// </summary>
        /// <param name="_TipoDeCuenta">Si es true, aumentara las unidades.</param>
        private void ActualizaCantidad(bool _TipoDeCuenta)
        {
            int TotalDeFilas = dgvArticulosPedido.Rows.Count;
            
            string InformacionDelError = string.Empty;

            ClsDetalles Detalles = new ClsDetalles();
            Detalle PlatoYaCocinado = new Detalle();

            ClsArticulos Articulos = new ClsArticulos();
            Articulo VerificarSiEsCocina = new Articulo();

            bool EstadoDetalleActualizado = false;

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                InformacionDelError = string.Empty;

                //Pregunto si la celda es diferente a null
                if (dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value != null)
                {
                    //Casteo el check del objeto a booleano y pregunto si es true
                    if ((bool)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value)
                    {
                        int Resultado = 0;

                        if (_TipoDeCuenta)
                        {
                            Resultado = Convert.ToInt32(dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value) + 1;

                            if (Resultado <= 100)
                            {
                                dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value = Resultado;

                                if (Convert.ToString(dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value) == "SI")
                                {
                                    dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value = "NO";
                                }
                            }
                            else
                            {
                                using (FrmInformacion FormInformacion = new FrmInformacion($"Cantidad maxima de articulos alcanzada.", ClsColores.Blanco, 150, 300))
                                {
                                    FormInformacion.ShowDialog();
                                }
                                dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value = false;
                                ClsColores.MarcarFilaDGV(dgvArticulosPedido, Indice, false);
                            }
                        }
                        else
                        {
                            Resultado = Convert.ToInt32(dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value) - 1;

                            PlatoYaCocinado = Detalles.LeerPorNumero(ID_Pedido, ClsDetalles.ETipoDeBusqueda.PorPedidoYArticulo, ref InformacionDelError, (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value);

                            if (PlatoYaCocinado != null)
                            {
                                VerificarSiEsCocina = Articulos.LeerPorNumero((int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value, ref InformacionDelError);

                                // Habilitar la edicion si es un plato no cocinado, no es para cocina, o tiene el estado cantidad aumentada
                                if ((PlatoYaCocinado.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.NoCocinado || VerificarSiEsCocina.CategoriaArticulo.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.No) || (PlatoYaCocinado.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.CantidadAumentada) || HabilitarEdicionEspecial)
                                {
                                    if (Resultado >= 1)
                                    {
                                        if (PlatoYaCocinado.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.CantidadAumentada)
                                        {
                                            PlatoYaCocinado.CantidadAgregada--;

                                            if (PlatoYaCocinado.CantidadAgregada == 0)
                                            {
                                                PlatoYaCocinado.ID_EstadoDetalle = (int)ClsEstadoDetalle.EEstadoDetalle.YaCocinado;
                                                PlatoYaCocinado.ID_ArticuloEntregado = (int)ClsArticulosEntregados.EArticuloEntregado.Entregado;

                                                if (Detalles.Actualizar(PlatoYaCocinado, ref InformacionDelError) != 0)
                                                {
                                                    EstadoDetalleActualizado = true;

                                                    if (Convert.ToString(dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value) == "NO")
                                                    {
                                                        dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value = "SI";
                                                    }
                                                }
                                                else if(InformacionDelError != string.Empty)
                                                {
                                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    Close();
                                                }
                                            }
                                            else
                                            {
                                                PlatoYaCocinado.ID_ArticuloEntregado = (int)ClsArticulosEntregados.EArticuloEntregado.NoEntregado;

                                                if (Detalles.Actualizar(PlatoYaCocinado, ref InformacionDelError) != 0)
                                                {
                                                    if (Convert.ToString(dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value) == "SI")
                                                    {
                                                        dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value = "NO";
                                                    }
                                                }
                                                else if (InformacionDelError != string.Empty)
                                                {
                                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    Close();
                                                }
                                            }
                                        }

                                        dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value = Resultado;
                                    }
                                    else
                                    {
                                        using (FrmInformacion FormInformacion = new FrmInformacion($"Cantidad minima de articulos alcanzada.", ClsColores.Blanco, 150, 300))
                                        {
                                            FormInformacion.ShowDialog();
                                        }
                                        dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value = false;
                                        ClsColores.MarcarFilaDGV(dgvArticulosPedido, Indice, false);
                                    }
                                }
                                else
                                {
                                    using (FrmInformacion FormInformacion = new FrmInformacion($"El " +
                                            $"articulo '{PlatoYaCocinado.Articulo.Nombre}' ya fue cocinado, " +
                                            $"por lo que no se puede disminuir mas la cantidad. Seleccione el " +
                                            $"boton [Actualizar pedido] y aumente hasta las unidades deseadas nuevamente.", ClsColores.Blanco, 150, 400))
                                    {
                                        FormInformacion.ShowDialog();
                                    }
                                    dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value = false;
                                    ClsColores.MarcarFilaDGV(dgvArticulosPedido, Indice, false);
                                }
                            }
                            else if (PlatoYaCocinado == null && InformacionDelError == string.Empty) // Es un detalle que fue fue creado, se puede modificar aca
                            {
                                if (Resultado >= 1)
                                {
                                    dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value = Resultado;

                                    if (Convert.ToString(dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value) == "SI")
                                    {
                                        dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value = "NO";
                                    }
                                }
                                else
                                {
                                    using (FrmInformacion FormInformacion = new FrmInformacion($"Cantidad minima de articulos alcanzada.", ClsColores.Blanco, 150, 300))
                                    {
                                        FormInformacion.ShowDialog();
                                    }

                                    dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value = false;
                                    ClsColores.MarcarFilaDGV(dgvArticulosPedido, Indice, false);
                                }
                            }
                            else if (InformacionDelError != string.Empty)
                            {
                                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                InformacionDelError = string.Empty;
                            }
                        }
                    }
                }
            }

            if (EstadoDetalleActualizado)
            {
                bool HayArticulosEnCocina = false;

                // Verificar si quedan articulos en cocina, si no hay mas, actualizar el estado del pedido
                for (int Indice = 0; Indice < TotalDeFilas; Indice++)
                {
                    InformacionDelError = string.Empty;

                    PlatoYaCocinado = Detalles.LeerPorNumero(ID_Pedido, ClsDetalles.ETipoDeBusqueda.PorPedidoYArticulo, ref InformacionDelError, (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value);

                    if (PlatoYaCocinado != null)
                    {
                        if (PlatoYaCocinado.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.NoCocinado || PlatoYaCocinado.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.CantidadAumentada)
                        {
                            HayArticulosEnCocina = true;
                        }
                    }
                    else if (InformacionDelError == string.Empty)
                    {
                        MessageBox.Show("Fallo al actualizar el pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                    }
                }

                // Si no encontro articulo en cocina, actualizar el estado del pedido
                if (!HayArticulosEnCocina)
                {
                    ClsPedidos Pedidos = new ClsPedidos();
                    Pedido ActualizarPedido = new ClsPedidos();

                    ActualizarPedido = Pedidos.LeerPorNumero(ID_Pedido, ref InformacionDelError);

                    if (ActualizarPedido != null)
                    {
                        ActualizarPedido.TiempoEspera = null;
                        ActualizarPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.Entregado;
                        btnPreCuenta.Enabled = true;

                        ActualizaLabelEstadoPedido((ClsEstadosPedidos.EEstadosPedidos)ActualizarPedido.ID_EstadoPedido);

                        Pedidos.Actualizar(ActualizarPedido, ref InformacionDelError);
                    }
                    else if (InformacionDelError == string.Empty)
                    {
                        MessageBox.Show("Fallo al actualizar el pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                    }
                }
            }

            ActualizarTotal();
        }
        
        private void BtnEnviarPedido_Click(object sender, EventArgs e)
        {
            if (dgvArticulosPedido.Rows.Count > 0)
            {
                if (FormCrearEditarDelivery == null)
                {
                    PedidoParaMesa();
                }
                else
                {
                    PedidoParaDelivery();
                }

                DesmarcarArticulosPedido();
                ActualizarTotal();
            }
        }

        private void PedidoParaMesa()
        {
            string InformacionDelError = string.Empty;
            string NotaDelPedido = string.Empty;

            using (FrmAgregarNotaPedidos FormAgregarNotaPedido = new FrmAgregarNotaPedidos(ID_Pedido))
            {
                FormAgregarNotaPedido.ShowDialog();
            }

            InformacionDelError = string.Empty;

            ClsDetalles Detalles = new ClsDetalles();
            Detalle CrearDetalle = new Detalle();

            ClsArticulos Articulos = new ClsArticulos();
            Articulo ArticuloParaCocina = new Articulo();

            ClsPedidos Pedidos = new ClsPedidos();
            Pedido ActualizarPedido = new ClsPedidos();

            int TotalDeFilas = dgvArticulosPedido.Rows.Count;

            bool SeAñadieronArticulos = false;
            bool SeEnviaronACocina = false;
            bool HayArticulosEnCocina = false;

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                InformacionDelError = string.Empty;

                CrearDetalle = Detalles.LeerPorNumero(ID_Pedido, ClsDetalles.ETipoDeBusqueda.PorPedidoYArticulo, ref InformacionDelError, (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value);

                if (CrearDetalle == null && InformacionDelError == string.Empty)
                {
                    SeAñadieronArticulos = true;

                    CrearDetalle = new Detalle();

                    CrearDetalle.ID_Pedido = ID_Pedido;
                    CrearDetalle.ID_Articulo = (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value;
                    CrearDetalle.ID_Chef = ID_Chef;
                    CrearDetalle.Cantidad = (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value;
                    CrearDetalle.Nota = null;
                    CrearDetalle.Precio = null;
                    CrearDetalle.ID_EstadoDetalle = (int)ClsEstadoDetalle.EEstadoDetalle.NoCocinado;
                    CrearDetalle.CantidadAgregada = 0;
                    CrearDetalle.ID_ArticuloEntregado = (int)ClsArticulosEntregados.EArticuloEntregado.NoEntregado;

                    Detalles.Crear(CrearDetalle, ref InformacionDelError);

                    if (InformacionDelError == string.Empty)
                    {
                        ArticuloParaCocina = Articulos.LeerPorNumero((int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value, ref InformacionDelError);

                        if (ArticuloParaCocina != null)
                        {
                            if (ArticuloParaCocina.CategoriaArticulo.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.Si)
                            {
                                ActualizarPedido = Pedidos.LeerPorNumero(ID_Pedido, ref InformacionDelError);

                                if (ActualizarPedido != null)
                                {
                                    if (ActualizarPedido.TiempoEspera == null)
                                    {
                                        ActualizarPedido.TiempoEspera = DateTime.Now;
                                    }

                                    ActualizarPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.EnProceso;

                                    ActualizaLabelEstadoPedido((ClsEstadosPedidos.EEstadosPedidos)ActualizarPedido.ID_EstadoPedido);

                                    Pedidos.Actualizar(ActualizarPedido, ref InformacionDelError);

                                    dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value = "SI";
                                    SeEnviaronACocina = true;
                                    btnPreCuenta.Enabled = false;
                                    btnPedidoRecibido.Enabled = false;
                                }
                                else if (InformacionDelError == string.Empty)
                                {
                                    MessageBox.Show("Fallo al actualizar el pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    Close();
                                }
                            }
                            else
                            {
                                CrearDetalle.ID_EstadoDetalle = (int)ClsEstadoDetalle.EEstadoDetalle.YaCocinado;
                                Detalles.Actualizar(CrearDetalle, ref InformacionDelError);
                            }
                        }
                    }
                }
                else if (InformacionDelError == string.Empty && CrearDetalle != null)
                {
                    // Poner el estado para entrega asi sabe que tiene que buscar los articulos agregados
                    if (CrearDetalle.Cantidad < (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value)
                    {
                        SeAñadieronArticulos = true;
                        CrearDetalle.ID_ArticuloEntregado = (int)ClsArticulosEntregados.EArticuloEntregado.NoEntregado;
                    }

                    //Indica si hay articulos en preparacion
                    if (CrearDetalle.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.NoCocinado || CrearDetalle.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.CantidadAumentada)
                    {
                        HayArticulosEnCocina = true;
                    }

                    CrearDetalle.ID_Articulo = (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value;

                    ArticuloParaCocina = Articulos.LeerPorNumero((int)dgvArticulosPedido.Rows[Indice].Cells[0].Value, ref InformacionDelError);

                    // Si es un articulo para cocina que se aumento su cantidad, mandarlo a cocina nuevamente pero modificando el estado
                    // del detalle y la nueva cantidad en otra columna
                    if ((CrearDetalle.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.YaCocinado || CrearDetalle.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.CantidadAumentada) && CrearDetalle.Cantidad < (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value && ArticuloParaCocina.CategoriaArticulo.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.Si)
                    {
                        CrearDetalle.ID_EstadoDetalle = (int)ClsEstadoDetalle.EEstadoDetalle.CantidadAumentada;
                        CrearDetalle.CantidadAgregada = Convert.ToInt32(dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value) - CrearDetalle.Cantidad;
                        CrearDetalle.ID_ArticuloEntregado = (int)ClsArticulosEntregados.EArticuloEntregado.NoEntregado;

                        btnPreCuenta.Enabled = false;

                        ActualizarPedido = Pedidos.LeerPorNumero(ID_Pedido, ref InformacionDelError);

                        if (ActualizarPedido.TiempoEspera == null)
                        {
                            ActualizarPedido.TiempoEspera = DateTime.Now;
                        }

                        ActualizarPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.EnProceso;

                        ActualizaLabelEstadoPedido((ClsEstadosPedidos.EEstadosPedidos)ActualizarPedido.ID_EstadoPedido);

                        Pedidos.Actualizar(ActualizarPedido, ref InformacionDelError);

                        HayArticulosEnCocina = true;
                    }
                    else
                    {
                        CrearDetalle.Cantidad = (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value;
                    }

                    if (ArticuloParaCocina.CategoriaArticulo.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.Si)
                    {
                        dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value = "SI";
                    }

                    CrearDetalle.Precio = null;

                    Detalles.Actualizar(CrearDetalle, ref InformacionDelError);
                }
                else if (InformacionDelError != string.Empty)
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                InformacionDelError = string.Empty;
                
                if (dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value != null)
                {
                    dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value = false;
                }

                ClsColores.MarcarFilaDGV(dgvArticulosPedido, Indice, false);
            }

            // Si se añadieron articulos pero ninguno se envio a cocina, poner un estado a los botones, sino, otro.
            if (SeAñadieronArticulos && !SeEnviaronACocina && !HayArticulosEnCocina)
            {
                InformacionDelError = string.Empty;

                ActualizarPedido = Pedidos.LeerPorNumero(ID_Pedido, ref InformacionDelError);

                if (ActualizarPedido != null)
                {
                    ActualizarPedido.TiempoEspera = null;
                    ActualizarPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.ParaEntrega;

                    if (Pedidos.Actualizar(ActualizarPedido, ref InformacionDelError) != 0)
                    {
                        ActualizaLabelEstadoPedido((ClsEstadosPedidos.EEstadosPedidos)ActualizarPedido.ID_EstadoPedido);

                        btnPedidoRecibido.Enabled = true;
                        btnPreCuenta.Enabled = false;
                        btnAñadirArticulos.Enabled = false;
                        btnEnviarPedido.Enabled = false;
                        btnAumentaUnidad.Enabled = false;
                        btnDisminuyeUnidad.Enabled = false;
                        btnEliminarPedido.Enabled = false;
                    }
                    else if (InformacionDelError != string.Empty)
                    {
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (InformacionDelError == string.Empty)
                {
                    MessageBox.Show("Fallo al actualizar el pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnPedidoRecibido.Enabled = true;
                btnPreCuenta.Enabled = false;
            }

            // Volver al estado originar si habilito la edicion especial
            if (HabilitarEdicionEspecial)
            {
                HabilitarEdicionEspecial = false;
                PicBTNHabilitaEdicionEspecial.BackColor = Color.Transparent;

                btnAumentaUnidad.Enabled = true;
                btnAñadirArticulos.Enabled = true;
            }

            if (ActualizarPedido != null) { ActualizarPedido.Nota = NotaDelPedido; }
        }

        private void PedidoParaDelivery()
        {
            int TotalDeFilas = dgvArticulosPedido.Rows.Count;
            string InformacionDelError = string.Empty;

            using (FrmAgregarNotaPedidos FormAgregarNotaPedido = new FrmAgregarNotaPedidos(ID_Pedido, FormCrearEditarDelivery))
            {
                FormAgregarNotaPedido.ShowDialog();
            }

            if (ID_Pedido == -1)
            {
                List<int> EnviarIDArticulos = new List<int>();
                List<int> EnviarCantidadArticulos = new List<int>();

                for (int Indice = 0; Indice < TotalDeFilas; Indice++)
                {
                    EnviarIDArticulos.Add((int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value);
                    EnviarCantidadArticulos.Add((int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value);
                }

                FormCrearEditarDelivery.S_ID_Articulos = EnviarIDArticulos;
                FormCrearEditarDelivery.S_ID_CantidadPorArticulo = EnviarCantidadArticulos;

                Close();
            }
            else
            {
                ClsDetalles Detalles = new ClsDetalles();
                Detalle CrearDetalle = new Detalle();

                ClsArticulos Articulos = new ClsArticulos();

                for (int Indice = 0; Indice < TotalDeFilas; Indice++)
                {
                    InformacionDelError = string.Empty;

                    CrearDetalle = Detalles.LeerPorNumero(ID_Pedido, ClsDetalles.ETipoDeBusqueda.PorPedidoYArticulo, ref InformacionDelError, (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value);

                    if (CrearDetalle == null && InformacionDelError == string.Empty)
                    {
                        CrearDetalle = new Detalle();

                        CrearDetalle.ID_Pedido = ID_Pedido;
                        CrearDetalle.ID_Articulo = (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value;
                        CrearDetalle.ID_Chef = ID_Chef;
                        CrearDetalle.Cantidad = (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value;
                        CrearDetalle.Nota = null;
                        CrearDetalle.Precio = null;

                        if ((int)ClsCategoriasArticulos.EParaCocina.Si == Articulos.LeerPorNumero((int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value, ref InformacionDelError).CategoriaArticulo.ParaCocina)
                        {
                            CrearDetalle.ID_EstadoDetalle = (int)ClsEstadoDetalle.EEstadoDetalle.NoCocinado;
                        }
                        else
                        {
                            CrearDetalle.ID_EstadoDetalle = (int)ClsEstadoDetalle.EEstadoDetalle.YaCocinado;
                        }

                        CrearDetalle.CantidadAgregada = 0;
                        CrearDetalle.ID_ArticuloEntregado = (int)ClsArticulosEntregados.EArticuloEntregado.NoEntregado;

                        Detalles.Crear(CrearDetalle, ref InformacionDelError);

                        if (InformacionDelError == string.Empty)
                        {
                            // 0 indica que no son enviados a cocina 
                            if (CrearDetalle.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.NoCocinado)
                            {
                                dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value = "SI";
                            }
                        }
                    }
                    else if (InformacionDelError == string.Empty && CrearDetalle != null)
                    {
                        CrearDetalle.Cantidad = (int)dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value;

                        Detalles.Actualizar(CrearDetalle, ref InformacionDelError);

                        if (InformacionDelError == string.Empty)
                        {
                            // 0 indica que no son enviados a cocina 
                            if (CrearDetalle.Articulo.CategoriaArticulo.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.Si)
                            {
                                dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value = "SI";
                            }
                            else
                            {
                                dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value = "- -";
                            }
                        }
                    }
                    else if (InformacionDelError != string.Empty)
                    {
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                DesmarcarArticulosPedido();
            }
        }

        private void BtnPedidoRecibido_Click(object sender, EventArgs e)
        {
            CargarDGVDetallesDelPedido(ClsDetalles.ETipoDeListado.PorIDPedido);

            string InformacionDelError = string.Empty;

            ClsPedidos Pedidos = new ClsPedidos();
            Pedido ActualizarPedido = new ClsPedidos();

            ActualizarPedido = Pedidos.LeerPorNumero(ID_Pedido, ref InformacionDelError);

            if (ActualizarPedido != null)
            {
                ActualizarPedido.TiempoEspera = null;
                ActualizarPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.Entregado;

                if (Pedidos.Actualizar(ActualizarPedido, ref InformacionDelError) != 0)
                {
                    ActualizaLabelEstadoPedido((ClsEstadosPedidos.EEstadosPedidos)ActualizarPedido.ID_EstadoPedido);

                    btnPedidoRecibido.Enabled = false;
                    btnPreCuenta.Enabled = true;
                    btnAñadirArticulos.Enabled = true;
                    btnEnviarPedido.Enabled = true;
                    btnAumentaUnidad.Enabled = true;
                    btnDisminuyeUnidad.Enabled = true;
                    btnEliminarPedido.Enabled = true;
                    PicBTNHabilitaEdicionEspecial.Enabled = true;

                    ClsDetalles Detalles = new ClsDetalles();
                    List<Detalle> ActualizarAEntregado = Detalles.LeerListado(ID_Pedido, ClsDetalles.ETipoDeListado.PorIDPedido, ref InformacionDelError);

                    if (ActualizarAEntregado != null)
                    {
                        int TotalDeFilas = dgvArticulosPedido.Rows.Count;

                        foreach (Detalle Elemento in ActualizarAEntregado)
                        {
                            Elemento.ID_ArticuloEntregado = (int)ClsArticulosEntregados.EArticuloEntregado.Entregado;

                            if (Detalles.Actualizar(Elemento, ref InformacionDelError) != 0)
                            {

                            }
                            else if (InformacionDelError != string.Empty)
                            {
                                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else if (InformacionDelError == string.Empty)
                    {
                        MessageBox.Show("Fallo al actualizar el articulo a 'Entregado'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (InformacionDelError != string.Empty)
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al actualizar el pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnPreCuenta_Click(object sender, EventArgs e)
        {
            CargarDGVDetallesDelPedido(ClsDetalles.ETipoDeListado.PorIDPedido);

            FrmRespuesta RespuestaFormulario = new FrmRespuesta($"¿Esta seguro que desea cerrar la mesa para cobrar? " +
                $"No podra editar mas el pedido.", FrmRespuesta.ETamaño.Pequeño, FrmRespuesta.ETipo.Si_No);

            if (RespuestaFormulario.DialogResult == DialogResult.Yes)
            {
                string InformacionDelError = string.Empty;

                ClsPedidos Pedidos = new ClsPedidos();
                Pedido ActualizarPedido = new ClsPedidos();

                ActualizarPedido = Pedidos.LeerPorNumero(ID_Pedido, ref InformacionDelError);

                if (ActualizarPedido != null)
                {
                    ActualizarPedido.TiempoEspera = null;
                    ActualizarPedido.Nota = null;
                    ActualizarPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.EsperandoPago;

                    if (Pedidos.Actualizar(ActualizarPedido, ref InformacionDelError) != 0)
                    {
                        ActualizaLabelEstadoPedido((ClsEstadosPedidos.EEstadosPedidos)ActualizarPedido.ID_EstadoPedido);

                        using (FrmResumenPedido FormResumenPedido = new FrmResumenPedido(ID_Pedido, MesasDelPedido, true))
                        {
                            FormResumenPedido.ShowDialog();
                        }

                        Close();
                    }
                    else if (InformacionDelError != string.Empty)
                    {
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (InformacionDelError == string.Empty)
                {
                    MessageBox.Show("Fallo al actualizar el pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>Muestra el total del pedido.</summary>
        private void ActualizarTotal()
        {
            double MontoTotal = 0;
            int TotalFilas = dgvArticulosPedido.Rows.Count;

            for (int Indice = 0; Indice < TotalFilas; Indice++)
            {
                dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Subtotal].Value = Convert.ToDouble(dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value) * Convert.ToDouble(dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.PrecioUnitario].Value);
                MontoTotal += Convert.ToDouble(dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Subtotal].Value);
            }

            lblMostratTotal.Text = Convert.ToString(MontoTotal);
        }

        #region Cargar DataGridView
        /// <summary>Carga la carta con todos los articulos activos (incluyendo a los que su categoria fue eliminada)</summary>
        private void CargarDGVCarta(ClsArticulos.ETipoListado _TipoDeListado)
        {
            if (FormularioCargado)
            {
                string NombreArticulo = string.Empty;

                int ID_CategoriaFiltro = 0;

                if (cmbCategoria.SelectedValue != null)
                {
                    CategoriaArticulo CategoriaSeleccionada = (CategoriaArticulo)cmbCategoria.SelectedItem;
                    ID_CategoriaFiltro = CategoriaSeleccionada.ID_CategoriaArticulo;
                }

                if (txtBuscarPorNombre.Text != TextoVisualBuscar) { NombreArticulo = txtBuscarPorNombre.Text; }

                dgvCarta.Rows.Clear();

                string InformacionDelError = string.Empty;

                ClsArticulos Articulos = new ClsArticulos();

                List<Articulo> ListarArticulosActivos = Articulos.LeerListado(_TipoDeListado, ref InformacionDelError, ClsArticulos.ETipoListado.ArticulosActivos, NombreArticulo, ID_CategoriaFiltro);

                if (ListarArticulosActivos != null)
                {
                    foreach (Articulo Elemento in ListarArticulosActivos)
                    {
                        if ((Elemento.Precio != null && FormCrearEditarDelivery == null) || (Elemento.PrecioDelivery != null && FormCrearEditarDelivery != null))
                        {
                            int NumeroDeFila = dgvCarta.Rows.Add();

                            dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.ID_Articulo].Value = Elemento.ID_Articulo;
                            dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.Nombre].Value = Elemento.Nombre;
                            dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.Descripcion].Value = Elemento.Descripcion;
                            dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.Categoria].Value = Elemento.CategoriaArticulo.Nombre;

                            if (FormCrearEditarDelivery == null)
                            {
                                dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.Precio].Value = Elemento.Precio;
                            }
                            else
                            {
                                dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.Precio].Value = Elemento.PrecioDelivery;
                            }

                            if (ArticulosDeCartaMarcados.Count > 0)
                            {
                                foreach (int ElementoSecundario in ArticulosDeCartaMarcados)
                                {
                                    if (ElementoSecundario == Elemento.ID_Articulo)
                                    {
                                        dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.Seleccionar].Value = true;
                                        ClsColores.MarcarFilaDGV(dgvCarta, NumeroDeFila, true);
                                        break;
                                    }
                                    else
                                    {
                                        dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.Seleccionar].Value = false;
                                        ClsColores.MarcarFilaDGV(dgvCarta, NumeroDeFila, false);
                                    }
                                }
                            }
                            else
                            {
                                dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.Seleccionar].Value = false;
                                ClsColores.MarcarFilaDGV(dgvCarta, NumeroDeFila, false);
                            }
                        }
                    }
                }
                else if (InformacionDelError == string.Empty)
                {
                    MessageBox.Show("Fallo al cargar los articulos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            dgvCarta.ClearSelection();
        }

        /// <summary>Carga el detalle del pedido actual.</summary>
        private void CargarDGVDetallesDelPedido(ClsDetalles.ETipoDeListado _TipoDeListado)
        {
            dgvArticulosPedido.Rows.Clear();

            string InformacionDelError = string.Empty;

            ClsDetalles Detalles = new ClsDetalles();
            List<Detalle> DetalleDelPedido = Detalles.LeerListado(ID_Pedido, _TipoDeListado, ref InformacionDelError);

            ClsArticulos Articulos = new ClsArticulos();
            Articulo VerificarCocina = new Articulo();

            if (DetalleDelPedido != null)
            {
                foreach (Detalle Elemento in DetalleDelPedido)
                {
                    int NumeroDeFila = dgvArticulosPedido.Rows.Add();

                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.ID_Articulo].Value = Elemento.Articulo.ID_Articulo;
                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Articulo].Value = Elemento.Articulo.Nombre;

                    // Solo mostrar las cantidades agregadas si es un listado de articulos sin enviar.
                    switch (_TipoDeListado)
                    {
                        case ClsDetalles.ETipoDeListado.PorIDPedido: dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value = Elemento.Cantidad + Elemento.CantidadAgregada; break;
                        case ClsDetalles.ETipoDeListado.NoEntregados: dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Cantidad].Value = Elemento.CantidadAgregada; break;
                    }

                    // Pregunto por null en los precios, ya que si el usuario elimino el precio de un plato que 
                    // estaba siendo usado, se evita el error de intentar calcular el precio total si este ahora es nulo
                    if (FormCrearEditarDelivery == null)
                    {
                        double Precio = 0;

                        if (Elemento.Articulo.Precio != null) { Precio = (double)Elemento.Articulo.Precio; }

                        dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.PrecioUnitario].Value = Precio;
                        dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Subtotal].Value = Precio * Elemento.Cantidad;
                    }
                    else
                    {
                        double PrecioDelivery = 0;

                        if (Elemento.Articulo.PrecioDelivery != null) { PrecioDelivery = (double)Elemento.Articulo.PrecioDelivery; }

                        dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.PrecioUnitario].Value = PrecioDelivery;
                        dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Subtotal].Value = PrecioDelivery * Elemento.Cantidad;
                    }

                    VerificarCocina = Articulos.LeerPorNumero(Elemento.ID_Articulo, ref InformacionDelError);

                    if (VerificarCocina != null)
                    {
                        // 0 indica que no son enviados a cocina 
                        if (VerificarCocina.CategoriaArticulo.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.Si)
                        {
                            dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value = "SI";
                        }
                        else
                        {
                            dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Enviado].Value = "- -";
                        }
                    }
                    else if (InformacionDelError == string.Empty)
                    {
                        MessageBox.Show("Fallo al cargar el detalle del pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                    }

                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value = false;
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al cargar el detalle del pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }

            ActualizarTotal();
        }

        private void PicBTNHabilitaEdicionEspecial_Click(object sender, EventArgs e)
        {
            if (!HabilitarEdicionEspecial)
            {
                using (FrmValidarUsuario FormValidarUsuario = new FrmValidarUsuario(FrmValidarUsuario.EFiltroUsuariosAutorizados.GerentesSubGerentes))
                {
                    FormValidarUsuario.ShowDialog();

                    if (FormValidarUsuario.DialogResult == DialogResult.OK)
                    {
                        HabilitarEdicionEspecial = true;
                        PicBTNHabilitaEdicionEspecial.BackColor = ClsColores.NaranjaClaro;

                        btnAumentaUnidad.Enabled = false;
                        btnAñadirArticulos.Enabled = false;
                    }
                }
            }
            else
            {
                HabilitarEdicionEspecial = false;
                PicBTNHabilitaEdicionEspecial.BackColor = ClsColores.Transparente;

                btnAumentaUnidad.Enabled = true;
                btnAñadirArticulos.Enabled = true;
            }
        }

        private void PicBTNActualizarLista_Click(object sender, EventArgs e) => CargarDGVDetallesDelPedido(ClsDetalles.ETipoDeListado.PorIDPedido);
        #endregion

        private void ActualizaLabelEstadoPedido(ClsEstadosPedidos.EEstadosPedidos _EstadoPedido)
        {
            switch (_EstadoPedido)
            {
                case ClsEstadosPedidos.EEstadosPedidos.Pendiente:
                    {
                        lblEstadoDelPedido.Text = Pendiente;
                        lblEstadoDelPedido.BackColor = Color.LightCoral;
                        btnMostrarCocina.Enabled = false;
                        break;
                    }
                case ClsEstadosPedidos.EEstadosPedidos.EnProceso:
                    {
                        lblEstadoDelPedido.Text = EnProceso;
                        lblEstadoDelPedido.BackColor = Color.Orange;
                        btnMostrarCocina.Enabled = true;
                        break;
                    }
                case ClsEstadosPedidos.EEstadosPedidos.ParaEntrega:
                    {
                        lblEstadoDelPedido.Text = ParaEntrega;
                        lblEstadoDelPedido.BackColor = Color.LightGreen;
                        btnMostrarCocina.Enabled = false;
                        break;
                    }
                case ClsEstadosPedidos.EEstadosPedidos.Entregado:
                    {
                        lblEstadoDelPedido.Text = Entregado;
                        lblEstadoDelPedido.BackColor = Color.YellowGreen;
                        btnMostrarCocina.Enabled = false;
                        break;
                    }
                case ClsEstadosPedidos.EEstadosPedidos.EsperandoPago:
                    {
                        // (No deberia entrar aca)
                        lblEstadoDelPedido.Text = EsperandoPago;
                        lblEstadoDelPedido.BackColor = Color.SeaGreen;
                        btnMostrarCocina.Enabled = false;
                        break;
                    }
            }
        }

        private void BtnMostrarCocina_Click(object sender, EventArgs e)
        {
            using (FrmVerCocina FormVerCocina = new FrmVerCocina(ID_Pedido))
            {
                FormVerCocina.ShowDialog();
            }
        }

        /// <summary>
        /// Desmarca todos los articulos del pedido y limpia el list con los articulos marcados.
        /// </summary>
        private void DesmarcarArticulosPedido()
        {
            int TotalDeFilas = dgvArticulosPedido.Rows.Count;

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                if (dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value != null)
                {
                    dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVArticulosDelPedido.Seleccionar].Value = false;
                    ClsColores.MarcarFilaDGV(dgvArticulosPedido, Indice, false);
                }
            }

            ArticulosDeCartaMarcados.Clear();
        }

        private void BtnImprimirTicket_Click(object sender, EventArgs e)
        {
            if (ID_Pedido != -1)
            {
                if (dgvArticulosPedido.Rows.Count > 0)
                {
                    PtdImprimirTicket = new PrintDocument();

                    if (ClsComprobarEstadoImpresora.ComprobarEstadoImpresora(PtdImprimirTicket.PrinterSettings.PrinterName))
                    {
                        PtdImprimirTicket.PrintPage += PrintPageEventHandler;
                        PtdImprimirTicket.Print();
                    }
                }
                else
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion($"No hay ningun articulo cargado en el pedido.", ClsColores.Blanco, 200, 300))
                    {
                        FormInformacion.ShowDialog();
                    }
                }
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion($"No se pudo encontrar el pedido, verifique que este creado " +
                        $"e intente nuevamente.", ClsColores.Blanco, 200, 300))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }

        private void PrintPageEventHandler(object sender, PrintPageEventArgs e)
        {
            string InformacionDelError = string.Empty;

            ClsDetalles Detalles = new ClsDetalles();
            List<Detalle> PlatosSinCocinar = Detalles.LeerListado(ID_Pedido, ClsDetalles.ETipoDeListado.ParaCocina, ref InformacionDelError);

            if (PlatosSinCocinar != null)
            {
                if (PlatosSinCocinar.Count > 0)
                {
                    ClsImpresionTickets.TicketParaCocina(ref e, ID_Pedido, PlatosSinCocinar, ref InformacionDelError);

                    if (InformacionDelError != string.Empty)
                    {
                        MessageBox.Show(InformacionDelError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion($"No se detecto ningun articulo para cocina.", ClsColores.Blanco, 200, 300))
                    {
                        FormInformacion.ShowDialog();
                    }
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Fallo al cargar el pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PicBTNInformacion_Click(object sender, EventArgs e)
        {
            if (FormCrearEditarDelivery == null)
            {
                using (FrmInformacion FormInformacion = new FrmInformacion($"En la lista de la derecha, se encuentran los articulos para realizar el pedido, seleccione uno " +
                        $"o varios de estos marcandolos en el check (seleccionar) y posteriormente presione el boton [Añadir articulos seleccionados al pedido] " +
                        $"para que se añadan a la lista izquierda, una vez agregados, use los checks de esta lista para marcar estos articulos, y utilize el " +
                        $"boton [+] para añadir mas unidades, [-] para quitar, y [X] para eliminar.\r\n\r\nCuando el pedido este listo, seleccione [Confirmar cambios] " +
                        $"para registrar el pedido (si no lo hace se perdera lo modificado).\r\n\r\nCuando confirme el pedido, si incluyo en este articulos para " +
                        $"ser elaborados en cocina, el pedido se marcara como 'En proceso' hasta que desde cocina lo marque como 'Para entrega', una vez " +
                        $"finalizado el pedido. El mozo debe controlar que este todo correcto y marcar el boton [Pedido recibido] para cambiarle el estado al mismo " +
                        $"de 'Pedido para entrega' a 'Pedido entregado'.\r\n\r\nSi elimina todos los articulos (vacia toda la lista con los " +
                        $"pedidos), la mesa volvera a tener el estado 'Pedido pendiente'.\r\n\r\nSi solo agrego al pedido articulos que no son para cocina, o agrego " +
                        $"nuevos a un pedido ya realizado (y ninguno es para cocina tambien), el pedido se pondra directamente como 'Para entrega', para que el mozo " +
                        $"busque los articulos, controle que esten todos y marque el pedido como 'Pedido entregado'.\r\n\r\nAdemas de los botones [+], [-] y [X], tiene " +
                        $"otros 2 botones mas que son para resetear el pedido (dejando solo los articulos que fueron confirmados), o si hubo un error en los articulos " +
                        $"y desea eliminar o bajar las unidades de uno que ya fue cocinado, puede habilitar la edicion del pedido usando el boton con el icono del candado " +
                        $"(que se habilita cuando un usuario autorizado ingresa su contraseña).\r\n\r\n" +
                        $"Cuando el pedido este terminado, debe seleccionar el boton [Pre cuenta], una vez que confirme que desea terminar el pedido, el mismo " +
                        $"se cambiara a 'Esperando pago' y se mostrara un primer resumen (puede imprimir el pedido o cerrar la venana).\r\n\r\nPuede imprimir el " +
                        $"pedido en cualquier momento con el boton [Imprimir ticket con los articulos actuales], y tambien puede ver " +
                        $"desde esta pantalla lo que le llega a cocina del pedido con [Ver lo que cocina tiene de este pedido].", ClsColores.Blanco, 650, 1000))
                {
                    FormInformacion.ShowDialog();
                }
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion($"En la lista de la derecha, se encuentran los articulos para realizar el pedido, seleccione uno " +
                        $"o varios de estos marcandolos en el check (seleccionar) y posteriormente presione el boton [Añadir articulos seleccionados al pedido] " +
                        $"para que se añadan a la lista izquierda, una vez agregados, use los checks de esta lista para marcar estos articulos, y utilize el " +
                        $"boton [+] para añadir mas unidades, [-] para quitar, y [X] para eliminar.\r\n\r\nCuando el pedido este listo, seleccione [Confirmar cambios] " +
                        $"para registrar el pedido (si no lo hace se perdera lo modificado).\r\n\r\nAdemas de los botones [+], [-] y [X], tiene " +
                        $"otros boton mas que es para resetear el pedido (dejando solo los articulos que fueron confirmados).\r\n\r\nPuede imprimir el " +
                        $"pedido en cualquier momento con el boton [Imprimir ticket con los articulos actuales], y tambien puede ver " +
                        $"desde esta pantalla lo que le llega a cocina del pedido con [Ver lo que cocina tiene de este pedido].", ClsColores.Blanco, 350, 900))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        [Obsolete]
        private void Button1_Click(object sender, EventArgs e)
        {
            CargarDGVDetallesDelPedido(ClsDetalles.ETipoDeListado.NoEntregados);
        }

        #region Propiedades
        #endregion
    }
}
