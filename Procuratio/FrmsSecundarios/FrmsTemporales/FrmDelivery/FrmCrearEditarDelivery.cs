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
using System.Runtime.InteropServices;
using Negocio.Clases_por_tablas;
using Procuratio.ClsDeApoyo;

namespace Procuratio.FrmsSecundarios.FrmsTemporales.FrmDelivery
{
    public partial class FrmCrearEditarDelivery : Form
    {
        #region Carga
        /// <summary>
        /// Inicializa el formulario.
        /// </summary>
        public FrmCrearEditarDelivery()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa el formulario para editar un delivery ya creado.
        /// </summary>
        /// <param name="_ID_Cliente">ID del cliente.</param>
        /// <param name="_ID_Pedido">ID del pedido.</param>
        /// <param name="_ID_Chef">ID del chef.</param>
        public FrmCrearEditarDelivery(int _ID_Cliente, int _ID_Pedido, int _ID_Chef)
        {
            InitializeComponent();

            ID_Cliente = _ID_Cliente;
            ID_Pedido = _ID_Pedido;
            ID_Chef = _ID_Chef;
        }

        /// <summary>
        /// Inicializa el formulario para editar el pedido de un delivery.
        /// </summary>
        /// <param name="_ID_Pedido">ID del pedido.</param>
        /// <param name="_ID_Chef">ID del chef.</param>
        public FrmCrearEditarDelivery(int _ID_Pedido, int _ID_Chef)
        {
            InitializeComponent();

            ID_Pedido = _ID_Pedido;
            ID_Chef = _ID_Chef;
        }

        private void FrmCrearEditarDelivery_Load(object sender, EventArgs e)
        {
            if (ID_Cliente != -1)
            {
                btnGuardarCambios.Visible = true;
                btnCrearDelivery.Visible = false;
                CargarDatosCliente();
                CargarDatosDelivery();
            }
            else
            {
                OcultarControlesCliente(true);
            }

            CargarCMBChefs();
        }

        private void CargarDatosCliente()
        {
            string InformacionDelError = string.Empty;

            ClsClientes Clientes = new ClsClientes();
            Cliente CargarCliente = new Cliente();

            CargarCliente = Clientes.LeerPorNumero(ID_Cliente, ClsClientes.EClienteBuscar.PorID, ref InformacionDelError);

            if (CargarCliente != null)
            {
                lblMostrarNombre.Text = CargarCliente.Nombre;
                lblMostrarApellido.Text = CargarCliente.Apellido;
                lblMostrarTelefono.Text = Convert.ToString(CargarCliente.Telefono);
                OcultarControlesCliente(false);
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Ocurrio un fallo al cargar el cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarDatosDelivery()
        {
            string InformacionDelError = string.Empty;

            ClsPedidos Pedidos = new ClsPedidos();
            Pedido CargarDelivery = new Pedido();

            CargarDelivery = Pedidos.LeerPorNumero(ID_Pedido, ref InformacionDelError);

            if (CargarDelivery != null)
            {
                if (CargarDelivery.Delivery.Destino == null)
                {
                    ckbRetiraEnElLocal.Checked = true;
                    txtDireccion.Text = "Se retira en el local";
                }
                else
                {
                    ckbRetiraEnElLocal.Checked = false;
                    txtDireccion.Text = CargarDelivery.Delivery.Destino;
                }

                txtTelefonoCadete.Text = Convert.ToString(CargarDelivery.Delivery.Telefono);
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Ocurrio un fallo al cargar el delivery", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarCMBChefs()
        {
            string InformacionDelError = string.Empty;

            ClsUsuarios ListarChefs = new ClsUsuarios();

            List<Usuario> CargarComboBoxChefs = ListarChefs.LeerListado(ClsUsuarios.ETipoListado.UsuariosChef, ref InformacionDelError);

            if (CargarComboBoxChefs != null)
            {
                foreach (Usuario Elemento in CargarComboBoxChefs)
                {
                    Elemento.Nombre += $" {Elemento.Apellido}";
                }

                // Nombre de la columna que contiene el nombre
                cmbNombreChef.DisplayMember = "Nombre";
                // Nombre de la columna que contiene el ID
                cmbNombreChef.ValueMember = "ID_Usuario";

                // Llenar el combo
                cmbNombreChef.DataSource = CargarComboBoxChefs;

                cmbNombreChef.Text = "Chef";
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
        #endregion

        #region Variables
        private int ID_Chef = -1;
        private int ID_Pedido = -1;
        private int ID_Cliente = -1;
        private int Acumulador = 0;
        private bool Invertir = true;
        private List<int> ID_Articulos = new List<int>();
        private List<int> CantidadPorArticulo = new List<int>();
        private string NotaPedido = string.Empty;
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
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;
            BotonEnFoco.BackColor = ClsColores.NaranjaClaro;
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

        private void CkbRetiraEnElLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRetiraEnElLocal.Checked)
            {
                txtDireccion.Enabled = false;
                txtDireccion.Text = ClsDeliveries.DireccionPorDefecto;
            }
            else
            {
                txtDireccion.Enabled = true;
                txtDireccion.Text = string.Empty;
            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            // Validar los datos.
            bool DatosValidos = true;
            string RegistroDeErrores = string.Empty;
            int AnchoFormInformacion = 100;

            if (ID_Cliente == -1)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe ingresar un cliente.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (!ckbRetiraEnElLocal.Checked && txtDireccion.Text.Length < 6)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe ingresar un minimo de 6 caracteres en la direccion.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (cmbNombreChef.SelectedItem != null)
            {
                ID_Chef = ((Usuario)cmbNombreChef.SelectedItem).ID_Usuario;
            }
            else
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe ingresar un chef a cargo del pedido.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (DatosValidos)
            {
                txtDireccion.Text = txtDireccion.Text.Substring(0, 1).ToUpper() + txtDireccion.Text.Remove(0, 1).ToLower();

                string InformacionDelError = string.Empty;

                ClsDeliveries Deliveries = new ClsDeliveries();
                Delivery GuardarCambiosDelivery = new Delivery();

                ClsPedidos Pedidos = new ClsPedidos();
                Pedido GuardarCambioPedido = new Pedido();

                GuardarCambioPedido = Pedidos.LeerPorNumero(ID_Pedido, ref InformacionDelError);

                if (GuardarCambioPedido != null && GuardarCambioPedido.ID_Delivery != null)
                {
                    GuardarCambiosDelivery = Deliveries.LeerPorNumero(GuardarCambioPedido.ID_Delivery, ref InformacionDelError);

                    if (GuardarCambiosDelivery != null)
                    {
                        GuardarCambioPedido.ID_Cliente = ID_Cliente;
                        GuardarCambioPedido.ID_Chef = ID_Chef;
                        Pedidos.Actualizar(GuardarCambioPedido, ref InformacionDelError);

                        if (txtTelefonoCadete.Text == string.Empty)
                        {
                            GuardarCambiosDelivery.Telefono = null;
                        }
                        else
                        {
                            GuardarCambiosDelivery.Telefono = Convert.ToInt64(txtTelefonoCadete.Text);
                        }

                        if (ckbRetiraEnElLocal.Checked)
                        {
                            GuardarCambiosDelivery.Destino = null;
                        }
                        else
                        {
                            GuardarCambiosDelivery.Destino = txtDireccion.Text;
                        }

                        Deliveries.Actualizar(GuardarCambiosDelivery, ref InformacionDelError);

                        Close();
                    }
                    else if (InformacionDelError == string.Empty)
                    {
                        MessageBox.Show("Ocurrio un fallo al buscar el delivery", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (InformacionDelError == string.Empty)
                {
                    MessageBox.Show("Ocurrio un fallo al buscar el pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion(RegistroDeErrores, ClsColores.Blanco, AnchoFormInformacion, 300))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }

        private void BtnCrearDelivery_Click(object sender, EventArgs e)
        {
            // Validar los datos.
            bool DatosValidos = true;
            string RegistroDeErrores = string.Empty;
            int AnchoFormInformacion = 100;

            if (ID_Cliente == -1)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe ingresar un cliente.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (ID_Articulos.Count == 0 || CantidadPorArticulo.Count == 0)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe ingresar un articulo.\r\n\r\n";
                AnchoFormInformacion += 50;
            }
            else if (!VerificarSiHayEnCocina())
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe ingresar un articulo que sea para elaborar en cocina.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (!ckbRetiraEnElLocal.Checked && txtDireccion.Text.Length < 6)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe ingresar un minimo de 6 caracteres en la direccion.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (cmbNombreChef.SelectedItem != null)
            {
                ID_Chef = ((Usuario)cmbNombreChef.SelectedItem).ID_Usuario;
            }
            else
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe ingresar un chef a cargo del pedido.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (DatosValidos)
            {
                txtDireccion.Text = txtDireccion.Text.Substring(0, 1).ToUpper() + txtDireccion.Text.Remove(0, 1).ToLower();

                string InformacionDelError = string.Empty;

                ClsDeliveries Deliveries = new ClsDeliveries();
                Delivery CrearDelivery = new Delivery();

                if (txtTelefonoCadete.Text == string.Empty)
                {
                    CrearDelivery.Telefono = null;
                }
                else
                {
                    CrearDelivery.Telefono = Convert.ToInt64(txtTelefonoCadete.Text);
                }

                CrearDelivery.ID_EstadoDelivery = (int)ClsEstadosDeliveries.EEstadosDeliveries.EnCocina;
                
                if (ckbRetiraEnElLocal.Checked)
                {
                    CrearDelivery.Destino = null;
                }
                else
                {
                    CrearDelivery.Destino = txtDireccion.Text;
                }

                if (Deliveries.Crear(CrearDelivery, ref InformacionDelError) != 0)
                {
                    CrearPedido(CrearDelivery.ID_Delivery);
                }
                else if (InformacionDelError == string.Empty)
                {
                    MessageBox.Show("Fallo al intentar crear el delivery", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion(RegistroDeErrores, ClsColores.Blanco, AnchoFormInformacion, 300))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }

        private void CrearPedido(int _ID_Delivery)
        {
            string InformacionDelError = string.Empty;

            ClsPedidos Pedidos = new ClsPedidos();
            Pedido CrearPedido = new Pedido();

            CrearPedido.Fecha = DateTime.Today.Date;
            CrearPedido.Hora = TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss"));
            CrearPedido.CantidadPersonas = 0;
            CrearPedido.TotalPedido = 0;
            CrearPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.EnProceso;
            CrearPedido.ID_Cliente = ID_Cliente;
            CrearPedido.ID_Reserva = null;
            CrearPedido.Nota = NotaPedido;
            CrearPedido.ID_Chef = ID_Chef;
            CrearPedido.TiempoEspera = DateTime.Now;
            CrearPedido.ID_Delivery = _ID_Delivery;
            CrearPedido.ID_Mozo = null;

            if (Pedidos.Crear(CrearPedido, ref InformacionDelError) != 0)
            {
                CrearDetalle(CrearPedido.ID_Pedido, _ID_Delivery);
            }
            else if (InformacionDelError != string.Empty)
            {
                ClsDeliveries Deliveries = new ClsDeliveries();
                Delivery EliminarDelivery = new Delivery();

                Deliveries.Borrar(_ID_Delivery, ref InformacionDelError);

                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CrearDetalle(int _ID_Pedido, int _ID_Delivery)
        {
            string InformacionDelError = string.Empty;

            ClsDetalles Detalles = new ClsDetalles();
            Detalle CrearDetalle = new Detalle();

            ClsArticulos Articulos = new ClsArticulos();

            int TotalDeArticulos = ID_Articulos.Count;

            bool HuboError = false;

            for (int Contador = 0; Contador < TotalDeArticulos; Contador++)
            {
                CrearDetalle.ID_Pedido = _ID_Pedido;
                CrearDetalle.ID_Articulo = ID_Articulos.First();
                CrearDetalle.ID_Chef = ID_Chef;
                CrearDetalle.Cantidad = CantidadPorArticulo.First();
                CrearDetalle.Nota = null;
                CrearDetalle.Precio = null;

                if ((int)ClsCategoriasArticulos.EParaCocina.Si == Articulos.LeerPorNumero(ID_Articulos.First(), ref InformacionDelError).CategoriaArticulo.ParaCocina)
                {
                    CrearDetalle.ID_EstadoDetalle = (int)ClsEstadoDetalle.EEstadoDetalle.NoCocinado;
                }
                else
                {
                    CrearDetalle.ID_EstadoDetalle = (int)ClsEstadoDetalle.EEstadoDetalle.YaCocinado;
                }

                CrearDetalle.CantidadAgregada = 0;
                CrearDetalle.ID_ArticuloEntregado = (int)ClsArticulosEntregados.EArticuloEntregado.NoEntregado;

                if (Detalles.Crear(CrearDetalle, ref InformacionDelError) != 0)
                {
                    ID_Articulos.Remove(ID_Articulos.First());
                    CantidadPorArticulo.Remove(CantidadPorArticulo.First());
                }
                else if (InformacionDelError != string.Empty)
                {
                    HuboError = true;

                    ClsDeliveries Deliveries = new ClsDeliveries();
                    Delivery EliminarDelivery = new Delivery();

                    ClsPedidos Pedidos = new ClsPedidos();
                    Pedido BorrarPedido = new Pedido();

                    List<Detalle> EliminarDetalle = Detalles.LeerListado(_ID_Pedido, ClsDetalles.ETipoDeListado.PorIDPedido, ref InformacionDelError);

                    Deliveries.Borrar(_ID_Delivery, ref InformacionDelError);
                    Pedidos.Borrar(_ID_Pedido, ref InformacionDelError);

                    if (EliminarDetalle != null)
                    {
                        foreach (Detalle Elemento in EliminarDetalle)
                        {
                            Detalles.Borrar(Elemento.ID_Detalle, ref InformacionDelError);
                        }
                    }

                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    break;
                }
            }

            // No hubo error en la creacion de los detalles, confirmar y cerrar.
            if (!HuboError)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        /// Busca que por lo menos haya un articulo en cocina para el envio.
        /// </summary>
        /// <returns></returns>
        private bool VerificarSiHayEnCocina()
        {
            string InformacionDelError = string.Empty;

            ClsArticulos Articulos = new ClsArticulos();
            Articulo ArticuloParaCocina = new Articulo();

            foreach (int Elemento in ID_Articulos)
            {
                ArticuloParaCocina = Articulos.LeerPorNumero(Elemento, ref InformacionDelError);

                if (ArticuloParaCocina != null)
                {
                    if (ArticuloParaCocina.CategoriaArticulo.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.Si)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void BtnVerEditarPedido_Click(object sender, EventArgs e)
        {
            using (FrmPedidosPorMesa FormPedidosPorMesa = new FrmPedidosPorMesa(ID_Pedido, ID_Chef, this))
            {
                if (ID_Pedido == -1)
                {
                    ID_Articulos.Clear();
                    CantidadPorArticulo.Clear();
                }

                FormPedidosPorMesa.ShowDialog();
            }
        }

        private void BtnCargarCliente_Click(object sender, EventArgs e)
        {
            using (FrmCliente FormCliente = new FrmCliente(FrmCliente.EMostrarOcultarColumnas.MostrarEnviar))
            {
                FormCliente.AsignarFormCrearDelivery(this);
                FormCliente.ShowDialog();

                if (FormCliente.DialogResult == DialogResult.OK)
                {
                    CargarDatosCliente(); // Se actualizo la variable ID_Cliente para cargar el nuevo cliente
                }
            }
        }

        /// <summary>
        /// Muestra u oculta los controles que contienen los datos del cliente en funcion de si hay o no datos cargados
        /// </summary>
        /// <param name="_Ocultar">True incica que se quieren ocultar.</param>
        private void OcultarControlesCliente(bool _Ocultar)
        {
            lblMostrarNombre.Visible = !_Ocultar;
            lblMostrarApellido.Visible = !_Ocultar;
            lblMostrarTelefono.Visible = !_Ocultar;
        }

        private void TxtTelefonoCadete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void PicBTNInformacion_Click(object sender, EventArgs e)
        {
            using (FrmInformacion FormInformacion = new FrmInformacion($"Para crear un pedido de delivery (el orden de la carga es indistinto), " +
                    $" especifique el cliente " +
                    $"que lo realiza usando el boton [Buscar y cargar cliente], luego la direccion de envio (debera " +
                    $"especificarla si no se retira en el local, en caso contrario marque el check), a continuacion " +
                    $"el chef que preparará el pedido, opcionalmente el telefono del cadete que enviara el pedido" +
                    $" y finalmente cargue el pedido seleccionando el boton [ver y/o " +
                    $"editar el pedido]. Una vez cargado todo, seleccione [Crear delivery].", ClsColores.Blanco, 250, 500))
            {
                FormInformacion.ShowDialog();
            }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        public int S_ID_Cliente { set { ID_Cliente = value; } }

        public List<int> S_ID_Articulos { set { ID_Articulos = value; } }
        public List<int> S_ID_CantidadPorArticulo { set { CantidadPorArticulo = value; } }

        public string S_NotaPedido { set { NotaPedido = value; } }
        #endregion
    }
}
