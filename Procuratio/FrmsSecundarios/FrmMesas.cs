using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using Negocio;
using Negocio.Clases_por_tablas;
using Datos;
using System.Data.Entity.Validation;
using Procuratio.ClsDeApoyo;
using Procuratio.FrmGenerales;

namespace Procuratio
{
    public partial class FrmMesas : Form
    {
        #region Codigo de Carga
        private FrmMesas()
        {
            InitializeComponent();
        }

        private void FrmMesas_Load(object sender, EventArgs e)
        {
            CargarAvisoEspera();
            CargarMesas();
            ActualizarConfiguracion();
            CargarCMBMozos();
            FormularioCargado = true;
        }

        private void ActualizarConfiguracion()
        {
            string InformacionDelError = string.Empty;

            ClsConfiguraciones Configuraciones = new ClsConfiguraciones();
            Configuracion Actualizar = new Configuracion();

            Actualizar = Configuraciones.LeerPorNumero(1, ref InformacionDelError);

            if (Actualizar != null)
            {
                if (Actualizar.TrabajaConPlantaAlta == 0)
                {
                    rbnPlantaBaja.Enabled = false;
                    rbnPlantaAlta.Enabled = false;
                }
                else
                {
                    rbnPlantaBaja.Enabled = true;
                    rbnPlantaAlta.Enabled = true;
                }

                AvisoEspera = Actualizar.AvisoEspera;
            }
            else if (InformacionDelError == string.Empty)
            {
                if (!MensajeDeErrorMostrado)
                {
                    MessageBox.Show("Fallo al actualizar las configuraciones", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (!MensajeDeErrorMostrado)
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Carga las mesas activas en caso de crearse una desde la pantalla de reservas, si hubo un corte de 
        /// luz o se esta usando el programa en otra computadora. Ademas habilita/deshabilita los botones al 
        /// ir actualizando el estado del pedido.
        /// </summary>
        private void CargarMesas()
        {
            // Reseteo las variables.
            ID_Mozo = -1;
            ID_Chef = -1;
            ID_Pedido = -1;
            
            // Instancio todo lo que voy a necesitar para realizar las actualizaciones
            string InformacionDelError = string.Empty;

            ClsPedidos Pedidos = new ClsPedidos();
            Pedido ActualizarPedido = new ClsPedidos();
        
            ClsPedidosXMesas PedidosXMesas = new ClsPedidosXMesas();
            List<PedidoXMesa> ListarPedidosActivos = PedidosXMesas.LeerListado(ClsPedidosXMesas.ETipoDeListado.CargarPorID, ref InformacionDelError);

            ClsUsuarios Usuarios = new ClsUsuarios();
            Usuario Mozo = new Usuario();

            List<int> PedidosYaCargados = new List<int>();

            Label LabelEstadoDelPedido = new Label();
            Label LabelTiempoEspera = new Label();
            Button BotonEliminarMesa = new Button();
            Button BotonCerrarMesa = new Button();
            Button BotonListaPedidos = new Button();
            Button BotonEditarMesa = new Button();

            int ID_PedidoActual = -1;

            // Buscar las mesas ya cargadas para ignorarlas en el ciclo de carga siguiente (Antes de indicar que se va a 
            // ignorar, actualizo el estado de esa mesa)
            foreach (Control PanelMesa in pnlContenedorMesas.Controls)
            {
                foreach (Control ControlMesaActual in PanelMesa.Controls)
                {
                    // Pregunto por null para ignorar los controles de ejemplo
                    if (ControlMesaActual.Tag != null)
                    {
                        if (ComparaTags(ControlMesaActual.Tag, ETagsControles.btnListaPedidos))
                        {
                            // Guardo el ID del pedido que usare para actualizar e ignorar la mesa
                            ID_PedidoActual = ValidaIDTags(ControlMesaActual.Tag, 0, 1);
                            PedidosYaCargados.Add(ID_PedidoActual);
                            BotonListaPedidos = (Button)ControlMesaActual;
                        }
                        else if (ComparaTags(ControlMesaActual.Tag, ETagsControles.btnEliminarMesa))
                        {
                            // Salvo el boton que actualizare segun el estado del pedido
                            BotonEliminarMesa = (Button)ControlMesaActual;
                        }
                        else if (ComparaTags(ControlMesaActual.Tag, ETagsControles.btnCerrarMesa))
                        {
                            // Salvo el boton que actualizare segun el estado del pedido
                            BotonCerrarMesa = (Button)ControlMesaActual;
                        }
                        else if (ComparaTags(ControlMesaActual.Tag, ETagsControles.lblEstadoPedido))
                        {
                            // Salvo el control que contiene el estado del pedido para despues modificarlo
                            LabelEstadoDelPedido = (Label)ControlMesaActual;
                        }
                        else if (ComparaTags(ControlMesaActual.Tag, ETagsControles.btnEditarMesa))
                        {
                            BotonEditarMesa = (Button)ControlMesaActual;
                        }
                        else if (ComparaTags(ControlMesaActual.Tag, ETagsControles.lblTiempoDeEspera))
                        {
                            LabelTiempoEspera = (Label)ControlMesaActual;
                        }
                    }
                }

                // Si encontro un pedido ya en pantalla, entro a realizar los cambios
                if (ID_PedidoActual != -1)
                {
                    ActualizarPedido = Pedidos.LeerPorNumero(ID_PedidoActual, ref InformacionDelError);

                    if (ActualizarPedido != null)
                    {
                        int[,] DatosTag = new int[1, 2];

                        DatosTag[0, 0] = (int)ETagsControles.lblEstadoPedido;
                        DatosTag[0, 1] = ActualizarPedido.ID_EstadoPedido;
                        LabelEstadoDelPedido.Tag = DatosTag;

                        switch ((ClsEstadosPedidos.EEstadosPedidos)ActualizarPedido.ID_EstadoPedido)
                        {
                            case ClsEstadosPedidos.EEstadosPedidos.Pendiente:
                                {
                                    LabelEstadoDelPedido.Text = Pendiente;
                                    LabelEstadoDelPedido.BackColor = Color.LightCoral;
                                    BotonEditarMesa.Enabled = true;
                                    BotonEliminarMesa.Enabled = true;
                                    BotonCerrarMesa.Enabled = false;
                                    BotonListaPedidos.Enabled = true;
                                    break;
                                }
                            case ClsEstadosPedidos.EEstadosPedidos.EnProceso:
                                {
                                    LabelEstadoDelPedido.Text = EnProceso;
                                    LabelEstadoDelPedido.BackColor = Color.Orange;
                                    BotonEditarMesa.Enabled = true;
                                    BotonEliminarMesa.Enabled = false;
                                    BotonCerrarMesa.Enabled = false;
                                    BotonListaPedidos.Enabled = true;
                                    break;
                                }
                            case ClsEstadosPedidos.EEstadosPedidos.ParaEntrega:
                                {
                                    LabelEstadoDelPedido.Text = ParaEntrega;
                                    LabelEstadoDelPedido.BackColor = Color.LightGreen;
                                    BotonEditarMesa.Enabled = true;
                                    BotonEliminarMesa.Enabled = false;
                                    BotonCerrarMesa.Enabled = false;
                                    BotonListaPedidos.Enabled = true;
                                    break;
                                }
                            case ClsEstadosPedidos.EEstadosPedidos.Entregado:
                                {
                                    LabelEstadoDelPedido.Text = Entregado;
                                    LabelEstadoDelPedido.BackColor = Color.YellowGreen;
                                    BotonEditarMesa.Enabled = true;
                                    BotonEliminarMesa.Enabled = false;
                                    BotonCerrarMesa.Enabled = false;
                                    BotonListaPedidos.Enabled = true;
                                    LabelTiempoEspera.Text = $"Espera = 00:00";
                                    LabelTiempoEspera.ForeColor = Color.White;
                                    LabelTiempoEspera.BackColor = Color.Transparent;
                                    break;
                                }
                            case ClsEstadosPedidos.EEstadosPedidos.EsperandoPago:
                                {
                                    LabelEstadoDelPedido.Text = EsperandoPago;
                                    LabelEstadoDelPedido.BackColor = Color.SeaGreen;
                                    BotonEliminarMesa.Enabled = false;
                                    BotonCerrarMesa.Enabled = true;
                                    BotonListaPedidos.Enabled = false;
                                    BotonEditarMesa.Enabled = false;
                                    LabelTiempoEspera.Text = $"Espera = 00:00";
                                    LabelTiempoEspera.ForeColor = Color.White;
                                    LabelTiempoEspera.BackColor = Color.Transparent;
                                    break;
                                }
                        }
                    }
                    else if (InformacionDelError == string.Empty)
                    {
                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al intentar actualizar el pedido");
                    }
                    else
                    {
                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al intentar actualizar el pedido");
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            
            if (ListarPedidosActivos != null)
            {
                // Cambio el estado del ID pedido para ignorarlo y solo cargar los que no esten en pantalla
                foreach (PedidoXMesa Elemento in ListarPedidosActivos)
                {
                    foreach (int IgnorarPedido in PedidosYaCargados)
                    {
                        if (Elemento.ID_Pedido == IgnorarPedido)
                        {
                            Elemento.ID_Pedido = -1;
                        }
                    }
                }
            }

            foreach (PedidoXMesa Elemento in ListarPedidosActivos)
            {
                if (Elemento.ID_Pedido != -1)
                {
                    // Limpio el array que contendra los ID y numeros de mesas
                    LimpiarArrayMesas();

                    // Datos del mozo
                    Mozo = Usuarios.LeerPorNumero(Elemento.Mesa.ID_Usuario, ClsUsuarios.EUsuarioABuscar.PorID, ref InformacionDelError);
                    ID_Mozo = Mozo.ID_Usuario;
                    NombreMozo = $"{Mozo.Nombre} {Mozo.Apellido}";

                    ID_Chef = Elemento.Pedido.ID_Chef;

                    // Asigno el pedido y su estado (a variables a nivel de clase)
                    ID_Pedido = Elemento.ID_Pedido;

                    ActualizarPedido = Pedidos.LeerPorNumero(ID_Pedido, ref InformacionDelError);
                    EstadoDelPedido = (ClsEstadosPedidos.EEstadosPedidos)ActualizarPedido.ID_EstadoPedido;

                    int Indice = 0;

                    foreach (PedidoXMesa ElementoSecundario in ListarPedidosActivos)
                    {
                        // Listo y agrupo todas las mesas del pedido actual.
                        if (ElementoSecundario.ID_Pedido == ID_Pedido)
                        {
                            NumeroDeMesas[Indice, 0] = ElementoSecundario.Mesa.ID_Mesa;
                            NumeroDeMesas[Indice, 1] = ElementoSecundario.Mesa.Numero;
                            Indice++;

                            // Marco el pedido con el valor -1 para no tenerlo en cuenta en las cargas de las proximas mesas.
                            ElementoSecundario.ID_Pedido = -1;
                        }
                    }

                    // Todo cargado, Armo las mesas y despues elimino todos los registos usados de la lista de este metodo
                    CrearControles();

                    LimpiarArrayMesas();
                }
            }

            ActualizaPorEdicionEnRed();

            EstadoDelPedido = ClsEstadosPedidos.EEstadosPedidos.Pendiente;
        }

        private void CargarAvisoEspera()
        {
            string InformacionDelError = string.Empty;

            ClsConfiguraciones Configuraciones = new ClsConfiguraciones();
            Configuracion CargarAvisoEspera = new Configuracion();

            CargarAvisoEspera = Configuraciones.LeerPorNumero(1, ref InformacionDelError);

            if (CargarAvisoEspera != null)
            {
                AvisoEspera = CargarAvisoEspera.AvisoEspera;
            }
            else if (InformacionDelError == string.Empty)
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al intentar cargar el block de notas");
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al intentar cargar el block de notas");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarCMBMozos()
        {
            string InformacionDelError = string.Empty;

            ClsUsuarios ListarUsuarios = new ClsUsuarios();

            List<Usuario> CargarComboBoxUsuarios = ListarUsuarios.LeerListado(ClsUsuarios.ETipoListado.UsuariosParaMesas, ref InformacionDelError);

            if (CargarComboBoxUsuarios != null)
            {
                CargarComboBoxUsuarios.Add(new Usuario { ID_Usuario = 0, Nombre = "Todos los mozos" });

                foreach (Usuario Elemento in CargarComboBoxUsuarios)
                {
                    Elemento.Nombre += $" {Elemento.Apellido}";
                }

                // Nombre de la columna que contiene el nombre
                cmbNombreMozo.DisplayMember = "Nombre";

                // Nombre de la columna que contiene el ID
                cmbNombreMozo.ValueMember = "ID_Usuario";

                // Llenar el combo
                cmbNombreMozo.DataSource = CargarComboBoxUsuarios;

                cmbNombreMozo.SelectedValue = 0;
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
            btnCrearPedido.Enabled = !_LicenciaExpirada;
            cmbNombreMozo.Enabled = !_LicenciaExpirada;
            txtBuscarMesa.Enabled = !_LicenciaExpirada;
            grbMostrar.Enabled = !_LicenciaExpirada;
        }
        #endregion

        #region Variables
        private static FrmMesas InstanciaForm;

        /*
        |<-Tabla de asignacion de TAGS a controles->

        |0  => PanelContenedor de mesas planta baja (SIN ID)
        |1  => PanelContenedor de mesas planta alta (SIN ID)
        |2  => Labels con los respectivos numeros de mesas (CADA LABEL CON EL ID CORRESPONDIENTE A SU MESA)
        |3  => Boton de despliege de lista de pedidos de mesas (ID DEL PEDIDO)
        |4  => Label con el mozo que atiende la mesa (ID DEL MOZO A CARGO DE LA MESA Y EL CHEF)
        |5  => Label con el estado del pedido (ID DEL ESTADO PEDIDO)
        |6  => Label con el tiempo de espera (SIN ID)
        |7  => (¿agregar?) PictureBox Con una imagen cambiante de un reloj (SIN ID)
        |8  => Boton para editar los numeros de mesas y el mozo a cargo (SIN ID)
        |9  => Boton para guardar y eliminar la mesa (SIN ID)
        |10 => Boton para eliminar la mesa (SIN ID)
        */

        private enum ETagsControles
        {
            pnlContenedorMPB, pnlContenedorMPA, lblNumMesa, btnListaPedidos,
            lblNombreMozo, lblEstadoPedido, lblTiempoDeEspera, picReloj, btnEditarMesa, btnCerrarMesa, btnEliminarMesa
        }

        private enum EEstadosPedido
        {
            NingunEstado, Pendiente, EnProceso, ParaEntrega, Entregado, EsperandoPago
        }

        private bool NoActualizarPorNumeroMesa = false;
        private int Actualizar = 0; // Actualiza y carga las mesas cada 10 segundos
        private int AvisoEspera = 20;
        private int Acumulador = 0; //Color ventana de informacion
        private bool Invertir = true; //Color ventana de informacion
        private bool MensajeDeErrorMostrado = false; // Esta variable mostrara una unica vez un mensaje de error en caso de que ocurra un fallo al comparar las Tags al buscar controles.
        private ClsEstadosPedidos.EEstadosPedidos EstadoDelPedido = ClsEstadosPedidos.EEstadosPedidos.Pendiente;
        private int ID_Mozo = -1;
        private int ID_Chef = -1;
        private int ID_Pedido = -1;
        private string NombreMozo = string.Empty;
        private int[,] NumeroDeMesas = new int[12, 2]; //12 son las mesas maximas que se permiten juntar (almacena el ID y el numero)

        private bool EjemploEliminado = false;
        private bool FormularioCargado = false;

        private List<int> ClientesDelPedido = new List<int>();
        private DialogResult CargoClientesAlPedido = DialogResult.Cancel;

        private readonly string Pendiente = "Pedido = Pendiente", EnProceso = "Pedido = En proceso", ParaEntrega = "Pedido = Para entrega", Entregado = "Pedido = Entregado", EsperandoPago = "Esperando el pago";
        #endregion

        #region Codigo para darle estilo a los botones
        //Estilo de colores a los botones que funcionan como botones
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            if (BotonEnFoco.Tag != null)
            {
                // Color para los controles dinamicos
                if (ComparaTags(BotonEnFoco.Tag, ETagsControles.btnEliminarMesa))
                {
                    BotonEnFoco.BackColor = ClsColores.Rojo;
                }
                else
                {
                    BotonEnFoco.BackColor = ClsColores.NaranjaClaro;
                }
            }
            else
            {
                // Color para los botones estaticos
                BotonEnFoco.BackColor = ClsColores.NaranjaClaro;
            }
        }

        private void btnEstiloBotones_Leave(object sender, EventArgs e)
        {
            Button BotonEnFoco = (Button)sender;
            BotonEnFoco.BackColor = ClsColores.Transparente;
        }

        private void TmrColor_Tick(object sender, EventArgs e)
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
            
            picBTNInformacion.BackColor = Color.FromArgb(32 + Acumulador, 42 + Acumulador, 52 + Acumulador);
        }
        #endregion

        #region Crear nueva mesa
        public void BtnVerMesasDisponibles_Click(object sender, EventArgs e)
        {
            using (FrmsSecundarios.FrmsTemporales.FrmListarMesas FormMesasDisponibles = new FrmsSecundarios.FrmsTemporales.FrmListarMesas(true))
            {
                FormMesasDisponibles.ShowDialog();
            }
        }

        public void btnCrearPedido_Click(object sender, EventArgs e)
        {
            LimpiarArrayMesas();
            ID_Mozo = -1;
            ID_Chef = -1;
            ID_Pedido = -1;

            using (FrmCrearMesa CrearMesa = new FrmCrearMesa())
            {
                CrearMesa.ShowDialog();

                if (CrearMesa.DialogResult == DialogResult.OK)
                {
                    // si mi array de numeros de mesas tiene como minimo un numero en la posicion 0 diferente de 0, significa que
                    // el usuario cargó al menos una mesa para crear (para mas seguridad, pero ya esta controlado en el otro formulario).
                    if (NumeroDeMesas[0, 0] != 0)
                    {
                        // Creo la mesa
                        MostrarTodo(); // Muestro todas las mesas independientemente de los filtros
                        OcuparMesas(); // Pongo el estado mesa de las nuevas mesas en ocupado
                        CrearPedido(); // Creo el pedido
                        CrearClientesXPedido(ID_Pedido); // Si cargo clientes, creo clientes por pedido.
                        CrearControles(); // Creo los controles
                    }
                    else
                    {
                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("No se encontraron mesas cargadas");
                    }
                }
            }

            LimpiarArrayMesas();
        }

        private void OcuparMesas()
        {
            List<int> ID_Mesas = new List<int>();

            int TotalFilas = NumeroDeMesas.GetLength(0);

            for (int Indice = 0; Indice < TotalFilas; Indice++)
            {
                // No hay mas mesas, salgo del ciclo
                if (NumeroDeMesas[Indice, 0] == 0) { break; }

                ID_Mesas.Add(NumeroDeMesas[Indice, 0]);
            }

            string InformacionDelError = string.Empty;

            ClsMesas Mesas = new ClsMesas();
            List<Mesa> BuscarMesasAOcupar = Mesas.LeerListado(ClsMesas.ETipoDeListado.MesasAOcuparLiberar, ref InformacionDelError, ID_Mesas);
            Mesa OcuparMesa = new Mesa();

            // Cambiar el estado a ocupadas.
            foreach (Mesa Elemento in BuscarMesasAOcupar)
            {
                OcuparMesa.ID_Mesa = Elemento.ID_Mesa;
                OcuparMesa.Numero = Elemento.Numero;
                OcuparMesa.ID_EstadoMesa = (int)ClsEstadosMesas.EEstadosMesas.Ocupada;
                OcuparMesa.ID_Usuario = ID_Mozo;
                OcuparMesa.Capacidad = Elemento.Capacidad;

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
            CrearPedido.CantidadPersonas = 0;
            CrearPedido.TotalPedido = 0;
            CrearPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.Pendiente;
            CrearPedido.ID_Cliente = 1;
            CrearPedido.ID_Reserva = null;
            CrearPedido.Nota = string.Empty;
            CrearPedido.ID_Chef = ID_Chef;
            CrearPedido.TiempoEspera = null;
            CrearPedido.ID_Delivery = null;
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

                ID_Pedido = CrearPedido.ID_Pedido;
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

        /// <summary>
        /// Genera los registos para guardar que clientes asistieron a un pedido en particular.
        /// </summary>
        private void CrearClientesXPedido(int _ID_PedidoActual)
        {
            string InformacionDelError = string.Empty;

            ClsClientesXPedidos ClientesXPedido = new ClsClientesXPedidos();
            List<ClienteXPedido> Eliminar = ClientesXPedido.LeerListado(ClsClientesXPedidos.ETipoListado.BuscarParaEliminar, ref InformacionDelError, 0, _ID_PedidoActual);

            ClienteXPedido CrearCliente = new ClienteXPedido();

            foreach (ClienteXPedido Elemento in Eliminar)
            {
                ClientesXPedido.Borrar(Elemento.ID_ClienteXPedido, ref InformacionDelError);
            }

            foreach (int Elemento in ClientesDelPedido)
            {
                CrearCliente.ID_Cliente = Elemento;
                CrearCliente.ID_Pedido = _ID_PedidoActual;
                CrearCliente.ID_EstadoClienteXPedido = (int)ClsEstadosClientesXPedidos.EEstadosClientesXPedidos.Disponible;
                ClientesXPedido.Crear(CrearCliente, ref InformacionDelError);
            }

            ClientesDelPedido.Clear();
            CargoClientesAlPedido = DialogResult.Cancel;
        }

        /// <summary>
        /// Asigna las propiedades a los controles y los inserta en el Panel contenedor de mesas
        /// </summary>
        private void CrearControles()
        {
            if (!EjemploEliminado) { EliminarMesaEjemplo(); }

            //Prop = PROPIEDADES
            Panel PanelContenedor = PropPanelContenedor();

            CrearLabelsNumerosMesas(PanelContenedor);

            Button BotonListaPedidos = PropBotonListaPedidos();
            Label LabelNombreMozo = PropLabelNombreMozo();
            Label LabelEstadoPedido = PropEstadoPedido(); 
            Label LabelTiempoDeEspera = PropTiempoDeEspera();
            Button BotonEditarMesa = PropBotonEditarMesa();
            Button BotonCerrarMesa = PropBotonCerrarMesa();
            Button BotonEliminarMesa = PropBotonEliminarMesa();

            pnlContenedorMesas.Controls.Add(PanelContenedor);

            PanelContenedor.Controls.Add(BotonListaPedidos);
            PanelContenedor.Controls.Add(LabelNombreMozo);
            PanelContenedor.Controls.Add(LabelEstadoPedido);
            PanelContenedor.Controls.Add(LabelTiempoDeEspera);
            PanelContenedor.Controls.Add(BotonEditarMesa);
            PanelContenedor.Controls.Add(BotonCerrarMesa);
            PanelContenedor.Controls.Add(BotonEliminarMesa);

            // Habilito los botones segun el estado del pedido de la mesa actual que se creo
            switch ((ClsEstadosPedidos.EEstadosPedidos)ValidaIDTags(LabelEstadoPedido.Tag, 0, 1))
            {
                case ClsEstadosPedidos.EEstadosPedidos.Pendiente:
                    {
                        BotonEliminarMesa.Enabled = true;
                        BotonCerrarMesa.Enabled = false;
                        break;
                    }
                case ClsEstadosPedidos.EEstadosPedidos.EnProceso:
                    {
                        BotonEliminarMesa.Enabled = false;
                        BotonCerrarMesa.Enabled = false;
                        break;
                    }
                case ClsEstadosPedidos.EEstadosPedidos.ParaEntrega:
                    {
                        BotonEliminarMesa.Enabled = false;
                        BotonCerrarMesa.Enabled = false;
                        break;
                    }
                case ClsEstadosPedidos.EEstadosPedidos.Entregado:
                    {
                        BotonEliminarMesa.Enabled = false;
                        BotonCerrarMesa.Enabled = false;
                        break;
                    }
                case ClsEstadosPedidos.EEstadosPedidos.EsperandoPago:
                    {
                        BotonEliminarMesa.Enabled = false;
                        BotonCerrarMesa.Enabled = true;
                        BotonListaPedidos.Enabled = false;
                        BotonEditarMesa.Enabled = false;
                        break;
                    }
                default:
                    {
                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al encontrar el estado del pedido");
                        break;
                    }
            }

            EstadoDelPedido = ClsEstadosPedidos.EEstadosPedidos.Pendiente; // Reinicio el estado al valor por defecto
        }

        /// <summary>
        /// Elimina la mesa de ejemplo del Panel contenedor de mesas
        /// </summary>
        private void EliminarMesaEjemplo()
        {
            EliminarControles(pnlEjemploMesa);
            EjemploEliminado = true;
        }

        /// <summary>
        /// Asigna las propiedades del Panel que contendra el resto de controles.
        /// </summary>
        private Panel PropPanelContenedor()
        {
            Panel PropiedadesPanel = new Panel();

            PropiedadesPanel.Dock = DockStyle.Top;
            PropiedadesPanel.Height = 110;
            PropiedadesPanel.Width = 500; //le doy un largo, pero con la propiedad dock ya toma el largo del control contenedor
            PropiedadesPanel.BackColor = ClsColores.Transparente;
            PropiedadesPanel.BorderStyle = BorderStyle.FixedSingle;

            int[,] DatosTag = new int[1, 2];

            if (NumeroDeMesas[0, 1] <= 99)
            {
                DatosTag[0, 0] = (int)ETagsControles.pnlContenedorMPB;
            }
            else
            {
                DatosTag[0, 0] = (int)ETagsControles.pnlContenedorMPA;
            }

            DatosTag[0, 1] = -1;

            PropiedadesPanel.Tag = DatosTag;

            ttpMensajesDeAyuda.SetToolTip(PropiedadesPanel, "Panel que contiene la informacion del pedido, como " +
                "por ejemplo las mesas, el estado del pedido, el mozo a cargo, etc");

            return PropiedadesPanel;
        }

        /// <summary>
        /// Crea lo controles que contendran los numeros de mesas, usando el array con las mesas que el usuario 
        /// selecciono, colocando estas mesas en el panel que se esta creando/editando.
        /// </summary>
        /// <param name="_PanelContenedor">Panel a agregar las labels.</param>
        private void CrearLabelsNumerosMesas(Panel _PanelContenedor)
        {
            int TotalFilas = NumeroDeMesas.GetLength(0);

            for (int Indice = 0, AumentaCoordenadaX = 7, AumentaCoordenadaY = 7; Indice < TotalFilas; Indice++, AumentaCoordenadaX += 50)
            {
                if (NumeroDeMesas[Indice, 0] == 0) { break; }

                if (Indice == 6)
                {
                    AumentaCoordenadaY += 34;
                    AumentaCoordenadaX = 7;
                }

                Label LabelNumeroMesa = PropLabelNumeroMesa(NumeroDeMesas[Indice, 0], NumeroDeMesas[Indice, 1], AumentaCoordenadaX, AumentaCoordenadaY);

                _PanelContenedor.Controls.Add(LabelNumeroMesa);
            }
        }

        /// <summary>
        /// Asigna las propiedades a las Labels que contendran los numeros de mesas
        /// </summary>
        /// <param name="_NumeroDeMesa">Contiene el numero a cargar en la Label.</param>
        /// <param name="_CoordenadaX">Coordenada X que se autoincrementa con cada numero de mesa para colocar la Label
        /// mas a la derecha.</param>
        /// <param name="_CoordenadaY">Determina la nueva posicion Y si edita la mesa.</param>
        private Label PropLabelNumeroMesa(int _ID_Mesa, int _NumeroDeMesa, int _CoordenadaX, int _CoordenadaY)
        {
            Label PropiedadesLabel = new Label();

            PropiedadesLabel.Location = new Point(_CoordenadaX, _CoordenadaY);
            PropiedadesLabel.Anchor = AnchorStyles.Top;
            PropiedadesLabel.Anchor = AnchorStyles.Left;
            PropiedadesLabel.Height = 26;
            PropiedadesLabel.Width = 45;
            PropiedadesLabel.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            PropiedadesLabel.BorderStyle = BorderStyle.FixedSingle;
            PropiedadesLabel.ForeColor = ClsColores.GrisClaro;
            PropiedadesLabel.BackColor = ClsColores.GrisClaro2;

            if (_NumeroDeMesa >= 100)
            {
                PropiedadesLabel.Text = Convert.ToString(_NumeroDeMesa);
            }
            else if (_NumeroDeMesa >= 10)
            {
                PropiedadesLabel.Text = Convert.ToString("0" + _NumeroDeMesa);
            }
            else
            {
                PropiedadesLabel.Text = Convert.ToString("00" + _NumeroDeMesa);
            }

            PropiedadesLabel.AutoSize = false;

            int[,] DatosTag = new int[1, 2];

            DatosTag[0, 0] = (int)ETagsControles.lblNumMesa;
            DatosTag[0, 1] = _ID_Mesa;

            PropiedadesLabel.Tag = DatosTag;

            ttpMensajesDeAyuda.SetToolTip(PropiedadesLabel, $"Representa la mesa n° {_NumeroDeMesa}");

            return PropiedadesLabel;
        }


        /// <summary>
        /// Asigna las propiedades al Button de la lista de pedidos
        /// </summary>
        private Button PropBotonListaPedidos()
        {
            Button PropiedadesBoton = new Button();

            PropiedadesBoton.Anchor = AnchorStyles.Top;
            PropiedadesBoton.Anchor = AnchorStyles.Left;

            int TotalFilas = NumeroDeMesas.GetLength(0);
            int TotalMesas = 0;

            for (int Indice = 0; Indice < TotalFilas; Indice++)
            {
                if (NumeroDeMesas[Indice, 0] == 0) { break; }
                TotalMesas++;
            }

            PropiedadesBoton = AsignarPosicionXYBotonPedido(PropiedadesBoton, TotalMesas);

            PropiedadesBoton.Width = 295;
            PropiedadesBoton.FlatStyle = FlatStyle.Flat;
            PropiedadesBoton.ForeColor = ClsColores.Blanco;
            PropiedadesBoton.BackColor = Color.Transparent;
            PropiedadesBoton.TextAlign = ContentAlignment.MiddleCenter;
            PropiedadesBoton.Text = "Abrir el pedido";

            int[,] DatosTag = new int[1, 2];
            int Pedido = ID_Pedido;

            DatosTag[0, 0] = (int)ETagsControles.btnListaPedidos;
            DatosTag[0, 1] = Pedido;
            PropiedadesBoton.Tag = DatosTag;

            PropiedadesBoton.Click += btnAbrirListaPedidos_Click;
            PropiedadesBoton.MouseMove += btnEstiloBotones_MouseMove;
            PropiedadesBoton.MouseLeave += btnEstiloBotones_Leave;

            ttpMensajesDeAyuda.SetToolTip(PropiedadesBoton, "Abre el menu para la gestion del pedido");

            return PropiedadesBoton;
        }

        /// <summary>
        /// Asigna la posicion X-Y al boton de lista de pedidos que puede cambiar si es editada la
        /// cantidad de mesas
        /// </summary>
        /// <param name="_Boton">Boton a asignar.</param>
        /// <param name="_TotalDeMesas">Cantidad de mesas del pedido.</param>
        /// <returns></returns>
        private Button AsignarPosicionXYBotonPedido(Button _Boton, int _TotalDeMesas)
        {
            if (_TotalDeMesas >= 7)
            {
                _Boton.Height = 30;
                _Boton.Location = new Point(7, 74);
                _Boton.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            }
            else
            {
                _Boton.Height = 65;
                _Boton.Location = new Point(7, 39);
                _Boton.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            }

            return _Boton;
        }

        /// <summary>
        /// Asigna las propiedades al Label encargado de contener el nombre del mozo a cargo de la mesa
        /// </summary>
        private Label PropLabelNombreMozo()
        {
            Label PropiedadesLabel = new Label();

            PropiedadesLabel.Location = new Point(358, 4);
            PropiedadesLabel.Anchor = AnchorStyles.Top;
            PropiedadesLabel.Anchor = AnchorStyles.Right;
            PropiedadesLabel.Anchor = AnchorStyles.Left;
            PropiedadesLabel.Height = 30;
            PropiedadesLabel.Width = 175;

            if (NombreMozo.Length > 20)
            {
                PropiedadesLabel.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            }
            else
            {
                PropiedadesLabel.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            }

            PropiedadesLabel.BorderStyle = BorderStyle.FixedSingle;
            PropiedadesLabel.ForeColor = ClsColores.GrisClaro;
            PropiedadesLabel.BackColor = ClsColores.GrisClaro2;
            PropiedadesLabel.TextAlign = ContentAlignment.MiddleCenter;
            PropiedadesLabel.Text = NombreMozo;
            PropiedadesLabel.AutoSize = false;

            int[,] DatosTag = new int[1, 3];
            int Mozo = ID_Mozo;
            int Chef = ID_Chef;
            
            DatosTag[0, 0] = (int)ETagsControles.lblNombreMozo;
            DatosTag[0, 1] = Mozo;
            DatosTag[0, 2] = Chef;
            PropiedadesLabel.Tag = DatosTag;

            ttpMensajesDeAyuda.SetToolTip(PropiedadesLabel, "Muestra el mozo que esta a cargo de este pedido");

            return PropiedadesLabel;
        }

        /// <summary>
        /// Asigna las propiedades al Label encargado de contener los diferentes estados del pedido
        /// </summary>
        private Label PropEstadoPedido()
        {
            Label PropiedadesLabel = new Label();

            PropiedadesLabel.Location = new Point(358, 39);
            PropiedadesLabel.Anchor = AnchorStyles.Top;
            PropiedadesLabel.Anchor = AnchorStyles.Right;
            PropiedadesLabel.Anchor = AnchorStyles.Left;
            PropiedadesLabel.Height = 30;
            PropiedadesLabel.Width = 175;
            PropiedadesLabel.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            PropiedadesLabel.BorderStyle = BorderStyle.FixedSingle;
            PropiedadesLabel.ForeColor = ClsColores.Negro;
            PropiedadesLabel.TextAlign = ContentAlignment.MiddleCenter;

            switch (EstadoDelPedido)
            {
                case ClsEstadosPedidos.EEstadosPedidos.Pendiente:
                    {
                        PropiedadesLabel.Text = Pendiente;
                        PropiedadesLabel.BackColor = Color.LightCoral;
                        break;
                    }
                case ClsEstadosPedidos.EEstadosPedidos.EnProceso:
                    {
                        PropiedadesLabel.Text = EnProceso;
                        PropiedadesLabel.BackColor = Color.Orange;
                        break;
                    }
                case ClsEstadosPedidos.EEstadosPedidos.ParaEntrega:
                    {
                        PropiedadesLabel.Text = ParaEntrega;
                        PropiedadesLabel.BackColor = Color.LightGreen;
                        break;
                    }
                case ClsEstadosPedidos.EEstadosPedidos.Entregado:
                    {
                        PropiedadesLabel.Text = Entregado;
                        PropiedadesLabel.BackColor = Color.YellowGreen;
                        break;
                    }
                case ClsEstadosPedidos.EEstadosPedidos.EsperandoPago:
                    {
                        PropiedadesLabel.Text = EsperandoPago;
                        PropiedadesLabel.BackColor = Color.SeaGreen;
                        break;
                    }
            }

            PropiedadesLabel.AutoSize = false;

            int[,] DatosTag = new int[1, 2];
            int ID_Estado = (int)EstadoDelPedido;

            DatosTag[0, 0] = (int)ETagsControles.lblEstadoPedido;
            DatosTag[0, 1] = ID_Estado;
            PropiedadesLabel.Tag = DatosTag;

            ttpMensajesDeAyuda.SetToolTip(PropiedadesLabel, "Indica los diferentes estados del pedido a medida " +
                "que se van agregando o quitando articulos al mismo");

            return PropiedadesLabel;
        }

        /// <summary>
        /// Asigna las propiedades al Label encargado de contener el tiempo de espera del pedido
        /// </summary>
        private Label PropTiempoDeEspera()
        {
            Label PropiedadesLabel = new Label();

            PropiedadesLabel.Location = new Point(358, 74);
            PropiedadesLabel.Anchor = AnchorStyles.Top;
            PropiedadesLabel.Anchor = AnchorStyles.Right;
            PropiedadesLabel.Anchor = AnchorStyles.Left;
            PropiedadesLabel.Height = 30;
            PropiedadesLabel.Width = 175;
            PropiedadesLabel.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            PropiedadesLabel.BorderStyle = BorderStyle.None;
            PropiedadesLabel.ForeColor = ClsColores.GrisClaro;
            PropiedadesLabel.BackColor = ClsColores.Transparente;
            PropiedadesLabel.TextAlign = ContentAlignment.MiddleLeft;
            PropiedadesLabel.Text = "Espera = 00:00";
            PropiedadesLabel.AutoSize = false;

            int[,] DatosTag = new int[1, 2];

            DatosTag[0, 0] = (int)ETagsControles.lblTiempoDeEspera;
            DatosTag[0, 1] = -1;
            PropiedadesLabel.Tag = DatosTag;

            ttpMensajesDeAyuda.SetToolTip(PropiedadesLabel, "Indica el tiempo de espera que lleva el pedido " +
                "desde que llegaron los clientes (o desde que se pidio un nuevo articulo)");

            return PropiedadesLabel;
        }

        /// <summary>
        /// Asigna las propiedades al Button encargado de cambiar el moozo a cargo de la mesa
        /// </summary>
        private Button PropBotonEditarMesa()
        {
            Button PropiedadesBoton = new Button();

            PropiedadesBoton.Location = new Point(543, 4);
            PropiedadesBoton.Anchor = AnchorStyles.Top;
            PropiedadesBoton.Anchor = AnchorStyles.Right;
            PropiedadesBoton.Anchor = AnchorStyles.Left;
            PropiedadesBoton.Height = 30;
            PropiedadesBoton.Width = 175;
            PropiedadesBoton.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            PropiedadesBoton.FlatStyle = FlatStyle.Flat;
            PropiedadesBoton.ForeColor = ClsColores.Blanco;
            PropiedadesBoton.BackColor = ClsColores.Transparente;
            PropiedadesBoton.TextAlign = ContentAlignment.MiddleCenter;
            PropiedadesBoton.Text = "Editar el pedido";

            int[,] DatosTag = new int[1, 2];

            DatosTag[0, 0] = (int)ETagsControles.btnEditarMesa;
            DatosTag[0, 1] = -1;
            PropiedadesBoton.Tag = DatosTag;

            PropiedadesBoton.MouseMove += btnEstiloBotones_MouseMove;
            PropiedadesBoton.MouseLeave += btnEstiloBotones_Leave;
            PropiedadesBoton.Click += btnEditarMesa_Click;

            ttpMensajesDeAyuda.SetToolTip(PropiedadesBoton, "Permite cambiar el mozo a cargo del pedido, el chef y las " +
                "mesas usadas");

            return PropiedadesBoton;
        }

        /// <summary>
        /// Asigna las propiedades al Button encargado de cerrar la mesa
        /// </summary>
        private Button PropBotonCerrarMesa()
        {
            Button PropiedadesBoton = new Button();

            PropiedadesBoton.Location = new Point(543, 39);
            PropiedadesBoton.Anchor = AnchorStyles.Top;
            PropiedadesBoton.Anchor = AnchorStyles.Right;
            PropiedadesBoton.Anchor = AnchorStyles.Left;
            PropiedadesBoton.Height = 30;
            PropiedadesBoton.Width = 175;
            PropiedadesBoton.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            PropiedadesBoton.FlatStyle = FlatStyle.Flat;
            PropiedadesBoton.ForeColor = ClsColores.Blanco;
            PropiedadesBoton.BackColor = ClsColores.Transparente;
            PropiedadesBoton.TextAlign = ContentAlignment.MiddleCenter;
            PropiedadesBoton.Text = "Cerrar el pedido";

            int[,] DatosTag = new int[1, 2];

            DatosTag[0, 0] = (int)ETagsControles.btnCerrarMesa;
            DatosTag[0, 1] = -1;
            PropiedadesBoton.Tag = DatosTag;

            PropiedadesBoton.MouseMove += btnEstiloBotones_MouseMove;
            PropiedadesBoton.MouseLeave += btnEstiloBotones_Leave;
            PropiedadesBoton.Click += btnCerrarMesa_Click;

            ttpMensajesDeAyuda.SetToolTip(PropiedadesBoton, "Finaliza el pedido, liberando las mesas una vez " +
                "registrado el cobro en la ventana que aparecera al presionar este boton");

            return PropiedadesBoton;
        }

        /// <summary>
        /// Asigna las propiedades al Button encargado de eliminar la mesa
        /// </summary>
        private Button PropBotonEliminarMesa()
        {
            Button PropiedadesBoton = new Button();

            PropiedadesBoton.Location = new Point(543, 74);
            PropiedadesBoton.Anchor = AnchorStyles.Top;
            PropiedadesBoton.Anchor = AnchorStyles.Right;
            PropiedadesBoton.Anchor = AnchorStyles.Left;
            PropiedadesBoton.Height = 30;
            PropiedadesBoton.Width = 175;
            PropiedadesBoton.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            PropiedadesBoton.FlatStyle = FlatStyle.Flat;
            PropiedadesBoton.ForeColor = ClsColores.Blanco;
            PropiedadesBoton.BackColor = ClsColores.Transparente;
            PropiedadesBoton.TextAlign = ContentAlignment.MiddleCenter;
            PropiedadesBoton.Text = "Eliminar el pedido";

            int[,] DatosTag = new int[1, 2];

            DatosTag[0, 0] = (int)ETagsControles.btnEliminarMesa;
            DatosTag[0, 1] = -1;
            PropiedadesBoton.Tag = DatosTag;

            PropiedadesBoton.MouseMove += btnEstiloBotones_MouseMove;
            PropiedadesBoton.MouseLeave += btnEstiloBotones_Leave;
            PropiedadesBoton.Click += btnEliminarMesa_Click;

            ttpMensajesDeAyuda.SetToolTip(PropiedadesBoton, "Elimina el pedido actual y libera las mesas");

            return PropiedadesBoton;
        }
        #endregion

        #region Eventos de los controles dinamicos
        private void btnAbrirListaPedidos_Click(object sender, EventArgs e)
        {
            if (!ActualizaPorEdicionEnRed())
            {
                CargarMesas();

                Control PanelSeleccionado = (Control)sender; // Obtengo control que llamo al evento
                Control PanelPadre = PanelSeleccionado.Parent; //Obtengo el control padre (el panel contenedor)

                int[,] DatosTag = new int[1, 2];

                int ID_PedidoActual = -1;
                int ID_EstadoPedidoActual = -1;
                int ID_ChefActual = -1;
                List<int> Mesas = new List<int>();

                // Busco los datos y controles que necesito
                foreach (Control ControlMesaSeleccionada in PanelPadre.Controls)
                {
                    if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.btnListaPedidos))
                    {
                        ID_PedidoActual = ValidaIDTags(ControlMesaSeleccionada.Tag, 0, 1);
                    }
                    else if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.lblNumMesa))
                    {
                        Mesas.Add(Convert.ToInt32(ControlMesaSeleccionada.Text.Trim().TrimStart('0')));
                    }
                    else if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.lblNombreMozo))
                    {
                        ID_ChefActual = ((int[,])ControlMesaSeleccionada.Tag)[0, 2];
                    }
                    else if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.lblEstadoPedido))
                    {
                        ID_EstadoPedidoActual = ValidaIDTags(ControlMesaSeleccionada.Tag, 0, 1);
                    }
                }

                // Si todo resulto correcto, los envio y muestro el formulario.
                if (ID_PedidoActual != -1 && ID_ChefActual != -1 && ID_EstadoPedidoActual != -1)
                {
                    using (FrmPedidosPorMesa FormPedidosPorMesa = new FrmPedidosPorMesa(ID_PedidoActual, ID_EstadoPedidoActual, ID_ChefActual, Mesas))
                    {
                        FormPedidosPorMesa.ShowDialog();

                        CargarMesas();
                    }
                }
                else
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion($"Ocurrio un error al abrir el pedido.", ClsColores.Blanco, 200, 300))
                    {
                        FormInformacion.ShowDialog();
                    }
                }
            }
        }

        private void btnEditarMesa_Click(object sender, EventArgs e)
        {
            if (!ActualizaPorEdicionEnRed())
            {
                Control ControlSeleccionado = (Control)sender; // Obtengo control que llamo al evento
                Control PanelPadre = ControlSeleccionado.Parent; //Obtengo el control padre (el panel contenedor)

                Button PropBotonListaPedidos = new Button();
                int ID_PedidoActual = -1;
                int ID_MozoActual = -1;
                int ID_ChefActual = -1;
                int[,] DatosTag = new int[1, 2];
                List<int> MesasEditar = new List<int>();
                bool PlantaBaja = true;

                foreach (Control ControlMesaSeleccionada in PanelPadre.Controls)
                {
                    // Busco el id del pedido y las mesas correspondientes al mismo para agregarlas a la opcion de elegir
                    if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.lblNumMesa))
                    {
                        DatosTag = new int[1, 2];

                        DatosTag = (int[,])ControlMesaSeleccionada.Tag;

                        MesasEditar.Add(DatosTag[0, 1]);

                        if (Convert.ToInt32(ControlMesaSeleccionada.Text.Trim().TrimStart('0')) >= 100)
                        {
                            PlantaBaja = false;
                        }
                    }
                    else if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.btnListaPedidos))
                    {
                        ID_PedidoActual = ValidaIDTags(ControlMesaSeleccionada.Tag, 0, 1);
                    }
                    else if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.lblNombreMozo))
                    {
                        ID_MozoActual = ValidaIDTags(ControlMesaSeleccionada.Tag, 0, 1);
                        ID_ChefActual = ValidaIDTags(ControlMesaSeleccionada.Tag, 0, 2);
                    }
                }

                if (MesasEditar.Count > 0 && ID_PedidoActual != -1)
                {
                    using (FrmCrearMesa FormCrearMesa = new FrmCrearMesa(ID_PedidoActual, ID_MozoActual, ID_ChefActual, MesasEditar, PlantaBaja))
                    {
                        FormCrearMesa.ShowDialog();

                        if (FormCrearMesa.DialogResult == DialogResult.OK)
                        {
                            MostrarTodo();

                            string InformacionDelError = string.Empty;

                            List<int> ID_Mesas = new List<int>();

                            ClsMesas Mesas = new ClsMesas();
                            Mesa LiberarMesa = new Mesa();

                            // Elimino Y actualizo las mesas y mozos
                            foreach (Control ControlMesaSeleccionada in PanelPadre.Controls)
                            {
                                if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.lblNumMesa))
                                { 
                                    DatosTag = new int[1, 2];

                                    DatosTag = (int[,])ControlMesaSeleccionada.Tag;
                                    
                                    ID_Mesas.Add(DatosTag[0, 1]);
                                }
                                else if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.btnListaPedidos))
                                {
                                    PropBotonListaPedidos = (Button)ControlMesaSeleccionada;
                                }
                            }

                            // Libero las mesas
                            List<Mesa> BuscarMesasALiberar = Mesas.LeerListado(ClsMesas.ETipoDeListado.MesasAOcuparLiberar, ref InformacionDelError, ID_Mesas);

                            foreach (Mesa Elemento in BuscarMesasALiberar)
                            {
                                LiberarMesa.ID_Mesa = Elemento.ID_Mesa;
                                LiberarMesa.Numero = Elemento.Numero;
                                LiberarMesa.ID_EstadoMesa = (int)ClsEstadosMesas.EEstadosMesas.Activo_Disponible;
                                LiberarMesa.ID_Usuario = ID_Mozo;
                                LiberarMesa.Capacidad = Elemento.Capacidad;

                                Mesas.Actualizar(LiberarMesa, ref InformacionDelError);
                            }

                            DatosTag = new int[1, 2];

                            // Actualizo el enum de la planta
                            if (NumeroDeMesas[0, 1] <= 99)
                            {
                                DatosTag[0, 0] = (int)ETagsControles.pnlContenedorMPB;
                            }
                            else
                            {
                                DatosTag[0, 0] = (int)ETagsControles.pnlContenedorMPA;
                            }

                            DatosTag[0, 1] = -1;
                            PanelPadre.Tag = DatosTag;

                            //Elimino los controles viejos
                            ActualizarControlesEdicion(PanelPadre);

                            // Agrego el nuevo mozo
                            Label LabelNombreMozo = PropLabelNombreMozo();
                            PanelPadre.Controls.Add(LabelNombreMozo);

                            ClsPedidosXMesas PedidosXMesas = new ClsPedidosXMesas();
                            List<PedidoXMesa> Eliminar = PedidosXMesas.LeerListado(ClsPedidosXMesas.ETipoDeListado.EliminarPorID, ref InformacionDelError, ID_PedidoActual);

                            // Elimino las mesas en pedidoXMesa para despues crear las nuevas
                            foreach (PedidoXMesa Elemento in Eliminar)
                            {
                                PedidosXMesas.Borrar(Elemento.ID_PedidoXMesa, ref InformacionDelError);
                            }

                            OcuparMesas();

                            CrearLabelsNumerosMesas((Panel)PanelPadre);

                            int TotalMesas = 0;

                            for (int Indice = 0; Indice < NumeroDeMesas.GetLength(0); Indice++)
                            {
                                if (NumeroDeMesas[Indice, 0] == 0) { break; }
                                TotalMesas++;
                            }

                            PropBotonListaPedidos = AsignarPosicionXYBotonPedido(PropBotonListaPedidos, TotalMesas);

                            ClsPedidosXMesas PedidosXMesa = new ClsPedidosXMesas();
                            PedidoXMesa CrearPedidoXMesa = new PedidoXMesa();

                            for (int I = 0; I < TotalMesas; I++)
                            {
                                CrearPedidoXMesa.ID_Mesa = NumeroDeMesas[I, 0];
                                CrearPedidoXMesa.ID_Pedido = ID_PedidoActual;
                                PedidosXMesa.Crear(CrearPedidoXMesa, ref InformacionDelError);
                            }

                            InformacionDelError = string.Empty;

                            ClsPedidos Pedidos = new ClsPedidos();
                            Pedido ActualizarMozoYChef = Pedidos.LeerPorNumero(ID_PedidoActual, ref InformacionDelError);

                            if (ActualizarMozoYChef != null)
                            {
                                ActualizarMozoYChef.ID_Mozo = ID_Mozo;
                                ActualizarMozoYChef.ID_Chef = ID_Chef;
                                Pedidos.Actualizar(ActualizarMozoYChef, ref InformacionDelError);

                                if (CargoClientesAlPedido == DialogResult.OK) { CrearClientesXPedido(ID_PedidoActual); }
                            }
                            else if (InformacionDelError == string.Empty)
                            {
                                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia($"Error al intentar actualizar el mozo {ID_PedidoActual}");
                            }
                            else
                            {
                                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia($"Error al intentar actualizar el mozo {ID_PedidoActual}");
                                MessageBox.Show($"Error al intentar actualizar el mozo {ID_PedidoActual}: {InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            ClientesDelPedido.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fallo al cargar las mesas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Elimina los controles viejos antes de insertar los nuevos el editar.
        /// </summary>
        /// <param name="_Panel">Panel actual.</param>
        private void ActualizarControlesEdicion(Control _Panel)
        {
            foreach (Control ControlMesaSeleccionada in _Panel.Controls)
            {
                if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.lblNombreMozo) || ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.lblNumMesa))
                {
                    ControlMesaSeleccionada.Dispose();
                    ActualizarControlesEdicion(_Panel); // Metodo recursivo ya que saltea controles al eliminar uno, 
                }                                       // si no encuentra mas controles para eliminar, deja de llamarse
            }                                           // a si mismo
        }

        private void btnCerrarMesa_Click(object sender, EventArgs e)
        {
            if (!ActualizaPorEdicionEnRed())
            {
                Control ControlSeleccionado = (Control)sender; // Obtengo control que llamo al evento
                Control PanelPadre = ControlSeleccionado.Parent; //Obtengo el control padre (el panel contenedor)

                string InformacionDelError = string.Empty;

                List<int> ID_MesaLiberar = new List<int>();
                List<int> NumerosMesas = new List<int>();
                int ID_PedidoActual = -1;
                int ID_MozoMesa = -1;

                foreach (Control ControlMesaSeleccionada in PanelPadre.Controls)
                {
                    if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.lblNumMesa)) // Libera las mesas
                    {
                        // Salvo las mesas
                        ID_MesaLiberar.Add(ValidaIDTags(ControlMesaSeleccionada.Tag, 0, 1));
                        NumerosMesas.Add(Convert.ToInt32(ControlMesaSeleccionada.Text.Trim().TrimStart('0')));
                    }
                    else if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.btnListaPedidos))
                    {
                        // Salvo el id del pedido
                        ID_PedidoActual = ValidaIDTags(ControlMesaSeleccionada.Tag, 0, 1);
                    }
                    else if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.lblNombreMozo))
                    {
                        ID_MozoMesa = ValidaIDTags(ControlMesaSeleccionada.Tag, 0, 1);
                    }
                }

                if (ID_MesaLiberar.Count > 0 && ID_PedidoActual != -1 && ID_MozoMesa != -1)
                {
                    using (FrmValidarUsuario FormValidarUsuario = new FrmValidarUsuario(FrmValidarUsuario.EFiltroUsuariosAutorizadosYParticular.GerenteSubGerenteMozoDueño, ID_MozoMesa))
                    {
                        FormValidarUsuario.ShowDialog();

                        if (FormValidarUsuario.DialogResult == DialogResult.OK)
                        {
                            using (FrmResumenPedido FormResumenPedido = new FrmResumenPedido(ID_PedidoActual, NumerosMesas, false))
                            {
                                FormResumenPedido.ShowDialog();

                                if (FormResumenPedido.DialogResult == DialogResult.OK)
                                {
                                    ClsMesas Mesas = new ClsMesas();
                                    Mesa LiberarMesa = new Mesa();

                                    ClsPedidos Pedidos = new ClsPedidos();
                                    Pedido FinalizarPedido = new Pedido();

                                    // Libero las mesas
                                    foreach (int Elemento in ID_MesaLiberar)
                                    {
                                        LiberarMesa = Mesas.LeerPorNumero(Elemento, ClsMesas.ETipoDeListado.PorID, ref InformacionDelError);

                                        LiberarMesa.ID_EstadoMesa = (int)ClsEstadosMesas.EEstadosMesas.Activo_Disponible;

                                        if (Mesas.Actualizar(LiberarMesa, ref InformacionDelError) != 0)
                                        {

                                        }
                                        else if (InformacionDelError == string.Empty)
                                        {
                                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar eliminar una mesa");
                                        }
                                        else
                                        {
                                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar eliminar una mesa");
                                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }

                                        InformacionDelError = string.Empty;
                                    }

                                    // Guardo todo y finalizo el pedido
                                    FinalizarPedido = Pedidos.LeerPorNumero(ID_PedidoActual, ref InformacionDelError);

                                    FinalizarPedido.TiempoEspera = null;
                                    FinalizarPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.Finalizado;

                                    int TotalDelPedido = 0;

                                    ClsDetalles Detalles = new ClsDetalles();
                                    List<Detalle> CalcularTotal = Detalles.LeerListado(ID_PedidoActual, ClsDetalles.ETipoDeListado.PorIDPedido, ref InformacionDelError);

                                    if (CalcularTotal != null)
                                    {
                                        foreach (Detalle Elemento in CalcularTotal)
                                        {
                                            TotalDelPedido += Convert.ToInt32(Elemento.Cantidad * Elemento.Articulo.Precio);
                                        }
                                        FinalizarPedido.TotalPedido = TotalDelPedido;
                                    }
                                    else if (InformacionDelError == string.Empty)
                                    {
                                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar calcular el total del pedido");
                                    }
                                    else
                                    {
                                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar calcular el total del pedido");
                                        MessageBox.Show($"Error al intentar calcular el total del pedido {ID_PedidoActual}: {InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }

                                    if (Pedidos.Actualizar(FinalizarPedido, ref InformacionDelError) != 0)
                                    {
                                        FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Mesa cerrada con exito";
                                    }
                                    else if (InformacionDelError == string.Empty)
                                    {
                                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar cerrar la mesa numero {ID_PedidoActual}");
                                    }
                                    else
                                    {
                                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar cerrar la mesa numero {ID_PedidoActual}");
                                        MessageBox.Show($"Error al eliminar el pedido numero {ID_PedidoActual}: {InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }

                                    EliminarControles(PanelPadre);
                                }
                            }
                        }
                    }
                }
                else
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion($"Ocurrio un fallo intentando listar los datos de la mesa, intente nuevamente.", ClsColores.Blanco, 200, 350))
                    {
                        FormInformacion.ShowDialog();
                    }
                }
            }
        }

        private void btnEliminarMesa_Click(object sender, EventArgs e)
        {
            if (!ActualizaPorEdicionEnRed())
            {
                FrmRespuesta ResultadoFormulario = new FrmRespuesta($"¿Estas seguro que deseas eliminar el pedido?", FrmRespuesta.ETamaño.Pequeño, FrmRespuesta.ETipo.Si_No);

                if (ResultadoFormulario.DialogResult == DialogResult.Yes)
                {
                    Control ControlSeleccionado = (Control)sender; // Obtengo control que llamo al evento
                    Control PanelPadre = ControlSeleccionado.Parent; //Obtengo el control padre (el panel contenedor)

                    string InformacionDelError = string.Empty;

                    ClsMesas Mesas = new ClsMesas();
                    Mesa LiberarMesa = new Mesa();

                    ClsPedidos Pedidos = new ClsPedidos();
                    Pedido EliminarPedido = new Pedido();

                    int[,] DatosTag = new int[1, 2];

                    foreach (Control ControlMesaSeleccionada in PanelPadre.Controls)
                    {
                        if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.lblNumMesa)) // Libera las mesas
                        {
                            LiberarMesa = Mesas.LeerPorNumero(ValidaIDTags(ControlMesaSeleccionada.Tag, 0, 1), ClsMesas.ETipoDeListado.PorID, ref InformacionDelError);

                            LiberarMesa.ID_EstadoMesa = (int)ClsEstadosMesas.EEstadosMesas.Activo_Disponible;

                            if (Mesas.Actualizar(LiberarMesa, ref InformacionDelError) != 0)
                            {

                            }
                            else if (InformacionDelError == string.Empty)
                            {
                                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar eliminar una mesa");
                            }
                            else
                            {
                                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar eliminar una mesa");
                                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            InformacionDelError = string.Empty;
                        }
                        else if (ComparaTags(ControlMesaSeleccionada.Tag, ETagsControles.btnListaPedidos)) // Cambia el estado al pedido
                        {
                            EliminarPedido = Pedidos.LeerPorNumero(ValidaIDTags(ControlMesaSeleccionada.Tag, 0, 1), ref InformacionDelError);

                            EliminarPedido.TiempoEspera = null;
                            EliminarPedido.Nota = null;
                            EliminarPedido.ID_EstadoPedido = (int)ClsEstadosPedidos.EEstadosPedidos.Eliminado;

                            if (Pedidos.Actualizar(EliminarPedido, ref InformacionDelError) != 0)
                            {
                                FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Pedido eliminado con exito";
                            }
                            else if (InformacionDelError == string.Empty)
                            {
                                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar eliminar el pedido");
                            }
                            else
                            {
                                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar eliminar el pedido");
                                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            InformacionDelError = string.Empty;
                        }
                    }
                    EliminarControles(PanelPadre);
                }
            }
        }
        #endregion

        /// <summary>
        /// Elimina el control padre con sus hijos
        /// </summary>
        /// <param name="_PanelMesa">Panel (que representa una mesa) a eliminar</param>
        private void EliminarControles(Control _PanelMesa)
        {
            try
            {
                foreach (Control ControlMesa in _PanelMesa.Controls)
                {
                    ControlMesa.Dispose();
                    EliminarControles(_PanelMesa); // Metodo recursivo ya que saltea al eliminar un control, cuando no
                }                                  // encuentra nada mas para eliminar, se deja de llamar y sale.
                _PanelMesa.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocurrio un error inesperado al eliminar la mesa: {e.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Intento una eliminacion del panel en general
                try
                {
                    _PanelMesa.Dispose();
                }
                catch (Exception e2)
                {
                    MessageBox.Show($"Ocurrio un error inesperado al eliminar la mesa por segunda vez: {e2.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tmrActualizaDatos_Tick(object sender, EventArgs e)
        {
            ActualizaTiempoEspera();

            if (DateTime.Now.TimeOfDay.Seconds == 59)
            {
                FormularioCargado = false;
                ActualizarConfiguracion();
                FormularioCargado = true;
            }
        }

        /// <summary>
        /// Actualiza el tiempo de espera de las mesas
        /// </summary>
        private void ActualizaTiempoEspera()
        {
            foreach (Control PanelMesa in pnlContenedorMesas.Controls)
            {
                // Busco el estado de la reserva para para el tiempo de la mesa
                int ID_EstadoPedido = -1;

                foreach (Control BuscarEstado in PanelMesa.Controls)
                {
                    if (BuscarEstado.Tag == null) { break; }

                    if (ComparaTags(BuscarEstado.Tag, ETagsControles.lblEstadoPedido))
                    {
                        ID_EstadoPedido = ValidaIDTags(BuscarEstado.Tag, 0, 1);
                    }
                }

                // Codigo de seguridad
                if (ID_EstadoPedido != -1)
                {
                    if ((ClsEstadosPedidos.EEstadosPedidos)ID_EstadoPedido == ClsEstadosPedidos.EEstadosPedidos.Pendiente || (ClsEstadosPedidos.EEstadosPedidos)ID_EstadoPedido == ClsEstadosPedidos.EEstadosPedidos.EnProceso || (ClsEstadosPedidos.EEstadosPedidos)ID_EstadoPedido == ClsEstadosPedidos.EEstadosPedidos.ParaEntrega)
                    {
                        foreach (Control ControlMesaActual in PanelMesa.Controls)
                        {
                            // Salir del ciclo si la tag es null (Codigo de seguridad).
                            // Si devuelve true, busca en el siguiente contenedor (se presupone que se le asigno su
                            // Tag numerica a cada control dinamico de cada mesa).
                            if (ControlMesaActual.Tag == null) { break; }

                            if (ComparaTags(ControlMesaActual.Tag, ETagsControles.lblTiempoDeEspera))
                            {
                                string[] Tiempo = ControlMesaActual.Text.Remove(0, 8).Trim().Split(':');

                                int Minutos = Convert.ToInt32(Tiempo[0]);
                                int Segundos = Convert.ToInt32(Tiempo[1]);

                                //Salir del ciclo y no actualizar mas si el tiempo llega a la hora de espera
                                if (Minutos >= 59 && Segundos >= 59)
                                {
                                    ControlMesaActual.BackColor = ClsColores.Rojo;
                                    break; //la mesa llego al tiempo limite (1 hora de espera) dejar de calcular el tiempo
                                }
                                else if (Minutos >= AvisoEspera)
                                {
                                    ControlMesaActual.ForeColor = ClsColores.Negro;
                                    ControlMesaActual.BackColor = ClsColores.AmarilloClaro;
                                }
                                else
                                {
                                    ControlMesaActual.ForeColor = ClsColores.Blanco;
                                    ControlMesaActual.BackColor = ClsColores.Transparente;
                                }

                                Segundos++;

                                if (Segundos == 60)
                                {
                                    Minutos++;

                                    Segundos = 0;
                                }

                                if (Segundos >= 10)
                                {
                                    if (Minutos < 10)
                                    {
                                        ControlMesaActual.Text = $"Espera = 0{Minutos}:{Segundos}";
                                    }
                                    else
                                    {
                                        ControlMesaActual.Text = $"Espera = {Minutos}:{Segundos}";
                                    }
                                }
                                else
                                {
                                    if (Minutos < 10)
                                    {
                                        ControlMesaActual.Text = $"Espera = 0{Minutos}:0{Segundos}";
                                    }
                                    else
                                    {
                                        ControlMesaActual.Text = $"Espera = {Minutos}:0{Segundos}";
                                    }
                                }

                                break; //Label de tiempo encontrada y actualizada, dejar de buscar y avanzar a la siguiente mesa
                            }
                        }
                    }
                }
            }

            // Actualizo todas las mesas
            Actualizar++;

            if (Actualizar >= 10)
            {
                CargarMesas();
                ActualizarCMBMozo();
                Actualizar = 0;
            }
        }

        private void ActualizarCMBMozo()
        {
            if (cmbNombreMozo.Items.Count > 0)
            {
                FormularioCargado = false;

                int MozoSeleccionado = 0;
                bool MozoEncontrado = false;

                if ((Usuario)cmbNombreMozo.SelectedItem != null)
                {
                    MozoSeleccionado = ((Usuario)cmbNombreMozo.SelectedItem).ID_Usuario;
                }

                CargarCMBMozos();
                
                foreach (Usuario Elemento in cmbNombreMozo.Items)
                {
                    if (Elemento.ID_Usuario == MozoSeleccionado)
                    {
                        cmbNombreMozo.SelectedValue = MozoSeleccionado;
                        MozoEncontrado = true;
                        break;
                    }
                    else
                    {
                        MozoEncontrado = false;
                    }
                }

                if (!MozoEncontrado) { cmbNombreMozo.SelectedValue = MozoSeleccionado; }

                FormularioCargado = true;
            }
        }

        private void TxtBuscarMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8) { e.Handled = true; }
        }

        #region Filtros de las mesas (por RadioButtons, mozos y numeros de mesas
        private void TxtBuscarMesa_TextChanged(object sender, EventArgs e)
        {
            if (!NoActualizarPorNumeroMesa)
            {
                FormularioCargado = false;
                cmbNombreMozo.SelectedValue = 0;
                FormularioCargado = true;

                rbnTodo.Checked = true;
                rbnTodo.Checked = false;

                if (txtBuscarMesa.Text != string.Empty)
                {
                    foreach (Control PanelMesa in pnlContenedorMesas.Controls)
                    {
                        bool NumeroEncontrado = false;

                        foreach (Control ControlMesaActual in PanelMesa.Controls)
                        {
                            // Salir del ciclo si la tag es null (Codigo de seguridad).
                            // Si devuelve true, busca en el siguiente contenedor (se presupone que se le asigno su
                            // Tag numerica a cada control dinamico de cada mesa).
                            if (ControlMesaActual.Tag == null) { break; }

                            if (ComparaTags(ControlMesaActual.Tag, ETagsControles.lblNumMesa))
                            {
                                if (txtBuscarMesa.Text.TrimStart('0') == ControlMesaActual.Text.TrimStart('0'))
                                {
                                    NumeroEncontrado = true;
                                    break;
                                }
                            }
                        }

                        PanelMesa.Visible = NumeroEncontrado;
                    }
                }
                else
                {
                    MostrarTodo();
                }
            }
        }

        private void FiltroEstadoPedido_Click(object sender, EventArgs e)
        {
            FormularioCargado = false;
            cmbNombreMozo.SelectedValue = 0;
            FormularioCargado = true;

            NoActualizarPorNumeroMesa = true;
            txtBuscarMesa.Text = string.Empty;
            NoActualizarPorNumeroMesa = false;
            
            if (rbnTodo.Checked)
            {
                AplicarFiltroPorEstadoPedido(EEstadosPedido.NingunEstado);
            }
            else if (rbnPlantaBaja.Checked)
            {
                AplicarFiltroPorPlanta(ETagsControles.pnlContenedorMPB);
            }
            else if (rbnPlantaAlta.Checked)
            {
                AplicarFiltroPorPlanta(ETagsControles.pnlContenedorMPA);
            }
            else if (rbnPendiente.Checked)
            {
                AplicarFiltroPorEstadoPedido(EEstadosPedido.Pendiente);
            }
            else if (rbnEnProceso.Checked)
            {
                AplicarFiltroPorEstadoPedido(EEstadosPedido.EnProceso);
            }
            else if (rbnParaEntrega.Checked)
            {
                AplicarFiltroPorEstadoPedido(EEstadosPedido.ParaEntrega);
            }
            else if (rbnEntregado.Checked)
            {
                AplicarFiltroPorEstadoPedido(EEstadosPedido.Entregado);
            }
            else if (rbnEsperandoPago.Checked)
            {
                AplicarFiltroPorEstadoPedido(EEstadosPedido.EsperandoPago);
            }
        }

        /// <summary>
        /// Muestra las diferentes mesas segun el filtro (buscado en la Label estado pedido) seleccionado 
        /// </summary>
        private void AplicarFiltroPorEstadoPedido(EEstadosPedido _EstadoDelPedido)
        {
            // Si el estado del pedido es ningun estado, significa que hay que mostrar todo, por lo que se salta la
            // Busqueda y se muestran las mesas.
            if (_EstadoDelPedido != EEstadosPedido.NingunEstado)
            {
                foreach (Control PanelMesa in pnlContenedorMesas.Controls)
                {
                    bool EstadoEncontrado = false;

                    foreach (Control ControlMesaActual in PanelMesa.Controls)
                    {
                        // Salir del ciclo si la tag es null (Codigo de seguridad).
                        // Si devuelve true, busca en el siguiente contenedor (se presupone que se le asigno su
                        // Tag numerica a cada control dinamico de cada mesa).
                        if (ControlMesaActual.Tag == null) { break; }

                        if (ComparaTags(ControlMesaActual.Tag, ETagsControles.lblEstadoPedido))
                        {
                            int ID = ValidaIDTags(ControlMesaActual.Tag, 0, 1);

                            //Si el metodo retorno un ID valido, y este coincide con el ID que se esta buscando, entrar
                            if (ID != -1 && ID == (int)_EstadoDelPedido)
                            {
                                EstadoEncontrado = true;
                                break;
                            }
                        }
                    }

                    PanelMesa.Visible = EstadoEncontrado;
                }
            }
            else
            {
                MostrarTodo();
            }
        }

        /// <summary>
        /// Muestra las diferentes mesas segun el filtro (buscado en la tag de la planta) 
        /// </summary>
        private void AplicarFiltroPorPlanta(ETagsControles _Planta)
        {
            FormularioCargado = false;
            cmbNombreMozo.SelectedValue = 0;
            FormularioCargado = true;
            
            foreach (Control PanelMesa in pnlContenedorMesas.Controls)
            {
                // Si la tag del panel coincide con el de la planta que se esta buscando, mostrar el panel (y que este no sea le panel de ejemplo)
                if (PanelMesa.Tag != null)
                {
                    if (ComparaTags(PanelMesa.Tag, _Planta))
                    {
                        PanelMesa.Visible = true;
                    }
                    else
                    {
                        PanelMesa.Visible = false;
                    }
                }
                else
                {
                    PanelMesa.Visible = false;
                }
            }
        }

        /// <summary>
        /// Muestra las mesas en donde coincida el mozo a cargo
        /// </summary>
        private void CmbNombreMozo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormularioCargado)
            {
                NoActualizarPorNumeroMesa = true;
                txtBuscarMesa.Text = string.Empty;
                NoActualizarPorNumeroMesa = false;

                rbnTodo.Checked = true;
                rbnTodo.Checked = false;

                if (cmbNombreMozo.SelectedItem != null)
                {
                    Usuario UsuarioSeleccionado = (Usuario)cmbNombreMozo.SelectedItem;

                    // Selecciono todos los usuarios, saltar la busqueda y mostrar las mesas
                    if (UsuarioSeleccionado.ID_Usuario != 0)
                    {
                        foreach (Control PanelMesa in pnlContenedorMesas.Controls)
                        {
                            bool EstadoEncontrado = false;

                            foreach (Control ControlMesaActual in PanelMesa.Controls)
                            {
                                // Salir del ciclo si la tag es null (Codigo de seguridad).
                                // Si devuelve true, busca en el siguiente contenedor (se presupone que se le asigno su
                                // Tag numerica a cada control dinamico de cada mesa).
                                if (ControlMesaActual.Tag == null) { break; }

                                if (ComparaTags(ControlMesaActual.Tag, ETagsControles.lblNombreMozo))
                                {
                                    int ID = ValidaIDTags(ControlMesaActual.Tag, 0, 1);

                                    //Si el metodo retorno un ID valido, y este coincide con el ID que se esta buscando, entrar
                                    if (ID != -1 && ID == UsuarioSeleccionado.ID_Usuario)
                                    {
                                        EstadoEncontrado = true;
                                        break;
                                    }
                                }
                            }

                            PanelMesa.Visible = EstadoEncontrado;
                        }
                    }
                    else
                    {
                        MostrarTodo();
                    }
                }
            }
        }

        /// <summary>
        /// Resetea el filtro de estados del pedido para que muestre todas las mesas en caso de que el usuario seleccione mostrar todo desde otro filtro
        /// </summary>
        private void MostrarTodo()
        {
            foreach (Control PanelMesa in pnlContenedorMesas.Controls) { PanelMesa.Visible = true; }
        }
        #endregion

        /// <summary>
        /// Compara la tag actual del control proporcionado, con la que se esta buscando (encapsulado en un codigo de seguridad contra errores de casteo).
        /// </summary>
        /// <param name="_TagControlMesaActual">Control en el que se comparará si la tag que contiene es la que 
        /// se esta buscando.</param>
        /// <param name="_TagAComparar">Tag que se esta buscando.</param>
        private bool ComparaTags(object _TagControlMesaActual, ETagsControles _TagAComparar)
        {
            try
            {
                // Convierto el objeto tag a un array bidimensional y pregunto en la posicion donde esta almacenada el equivalente en int a la tag
                if (((int[,])_TagControlMesaActual)[0, 0] == (int)_TagAComparar) { return true; }
            }
            catch (Exception Error)
            {
                // Este booleano evitara que se genere un bulce de Mensajes de errores
                if (!MensajeDeErrorMostrado)
                {
                    MensajeDeErrorMostrado = true;
                    MessageBox.Show($"Ocurrió un error al realizar el proceso que tiene asignada la tag " +
                        $"{Convert.ToString((ETagsControles)((int[,])_TagControlMesaActual)[0, 0])}: " +
                        $"{Error.Message}.\r\n\r\nEste mensaje se mostrara una unica vez, pero seguira ocurriendo, contacte con el " +
                        $"programador.", "Busqueda fallida de un ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        /// <summary>
        /// Metodo que se encarga de validar de que lo que contiene la tag es una ID valido, si no hubo problemas, devuelve el ID que contiene
        /// la tag, en caso contrario retorna -1
        /// </summary>
        /// <param name="_Fila">Indica la fila de busqueda.</param>
        /// <param name="_Columna">Indica la columna de busqueda.</param>
        private int ValidaIDTags(object _TagControlMesaActual, int _Fila, int _Columna)
        {
            try
            {
                // si es true, el numero que contiene la tag es valido y lo retorno, en caso contrario retorno -1
                if (((int[,])_TagControlMesaActual)[_Fila, _Columna] > 0) { return ((int[,])_TagControlMesaActual)[_Fila, _Columna]; }
            }
            catch (Exception Error)
            {
                // Este booleano evitara que se genere un bulce de Mensajes de errores
                if (!MensajeDeErrorMostrado)
                {
                    MensajeDeErrorMostrado = true;
                    MessageBox.Show($"Ocurrió un error al realizar una busqueda de ID: " +
                        $"{Error.Message}.\r\n\r\nEste mensaje se mostrara una unica vez, pero seguira ocurriendo, contacte con el " +
                        $"programador.", "Busqueda fallida de un ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (!MensajeDeErrorMostrado)
            {
                MensajeDeErrorMostrado = true;
                MessageBox.Show($"Ocurrió un error al realizar el proceso de buscar un codigo de identificacion con un control, " +
                    $"contacte con el programador.", "Busqueda fallida de un ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1;
        }

        /// <summary>
        /// Actualiza los controles dinamicos si se detecta que no coinciden los IDs con los que trae desde la base de datos,
        /// debido a que se actualizo algo del pedido desde otra computadora (solo elimina los pedidos que 
        /// detecto como actualizados para luego actualizar la lista con los controles y sus ID actualizados).
        /// </summary>
        private bool ActualizaPorEdicionEnRed()
        {
            // Nota: busco todos los controles y no uno en especifico, para de esta forma reducir la cantidad 
            // de veces que se tendrian que eliminar y recargar los controles

            bool HuboActualizacion = false;
            int ID_PedidoActual;
            List<int> Mesas = new List<int>();

            Panel MesaActual = new Panel();
            Label LabelMozoActual = new Label();
            Label LabelEstadoPedido = new Label();

            string InformacionDelError = string.Empty;

            ClsPedidosXMesas PedidosXMesas = new ClsPedidosXMesas();

            foreach (Control PanelMesa in pnlContenedorMesas.Controls)
            {
                if (PanelMesa.Tag != null)
                {
                    ID_PedidoActual = -1;
                    InformacionDelError = string.Empty;
                    Mesas.Clear();

                    foreach (Control ControlMesaActual in PanelMesa.Controls)
                    {
                        if (ComparaTags(ControlMesaActual.Tag, ETagsControles.btnListaPedidos))
                        {
                            ID_PedidoActual = ValidaIDTags(ControlMesaActual.Tag, 0, 1);
                        }
                        else if (ComparaTags(ControlMesaActual.Tag, ETagsControles.lblNombreMozo))
                        {
                            LabelMozoActual = (Label)ControlMesaActual;
                        }
                        else if (ComparaTags(ControlMesaActual.Tag, ETagsControles.lblNumMesa))
                        {
                            Mesas.Add(ValidaIDTags(ControlMesaActual.Tag, 0, 1));
                        }
                        else if (ComparaTags(ControlMesaActual.Tag, ETagsControles.lblEstadoPedido))
                        {
                            LabelEstadoPedido = (Label)ControlMesaActual;
                        }
                    }

                    Mesas.RemoveAll(I => I == -1);

                    if (ID_PedidoActual != -1 && ValidaIDTags(LabelMozoActual.Tag, 0, 1) != -1 && ValidaIDTags(LabelMozoActual.Tag, 0, 2) != -1)
                    {
                        List<PedidoXMesa> BuscarCambios = PedidosXMesas.LeerListado(ClsPedidosXMesas.ETipoDeListado.BuscarMesasYMozo, ref InformacionDelError, ID_PedidoActual);

                        if (BuscarCambios != null)
                        {
                            bool SeActualizaronMesas = false;
                            bool SeActualizoMozo = false;
                            bool SeActualizoChef = false;
                            bool SeActualizoEstadoPedido = false;

                            //Buscar mozo, chef o estado del pedido cambiado
                            foreach (PedidoXMesa ElementoSecundario in BuscarCambios)
                            {
                                if (ElementoSecundario.Mesa.ID_Usuario != ValidaIDTags(LabelMozoActual.Tag, 0, 1))
                                {
                                    SeActualizoMozo = true;
                                    break;
                                }
                                else if (ElementoSecundario.Pedido.ID_Chef != ValidaIDTags(LabelMozoActual.Tag, 0, 2))
                                {
                                    SeActualizoChef = true;
                                    break;
                                }
                                else if (ElementoSecundario.Pedido.ID_EstadoPedido != ValidaIDTags(LabelEstadoPedido.Tag, 0, 1))
                                {
                                    SeActualizoEstadoPedido = true;
                                    break;
                                }
                            }

                            //Buscar mesa cambiada
                            foreach (int Elemento in Mesas)
                            {
                                foreach (PedidoXMesa ElementoSecundario in BuscarCambios)
                                {
                                    if (ElementoSecundario.Mesa.ID_Mesa == Elemento)
                                    {
                                        SeActualizaronMesas = false;
                                        break;
                                    }

                                    SeActualizaronMesas = true;
                                }

                                if (SeActualizaronMesas) { break; }
                            }

                            if (SeActualizaronMesas || SeActualizoMozo || SeActualizoChef || SeActualizoEstadoPedido)
                            {
                                EliminarControles(PanelMesa);
                                HuboActualizacion = true;
                            }
                        }
                    }
                }
            }

            if (HuboActualizacion) { CargarMesas(); }

            return HuboActualizacion;
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

        private void PicBTNInformacion_Click(object sender, EventArgs e)
        {
            using (FrmInformacion FormInformacion = new FrmInformacion($"Tener en cuenta que el tiempo de espera dependera del momento en que se creo el pedido, " +
                    $"por lo que siempre puede ser mas del que se esta mostrando. Si el programa se cierra, " +
                    $"estos contadores volveran a 0 nuevamente. Tambien se reinicia cada vez que se " +
                    $"modifica el pedido para cocina.\r\n\r\n\r\n" +

                    $"Todo = Lista todas las mesas (independientemente del estado que tengan).\r\n\r\n" +

                    $"Planta baja = Lista las mesas con numeraciones del 1 al 99 (esta opcion se desabilita si desde configuracion se marca " +
                    $"que no se va a trabajar con planta alta).\r\n\r\n" +

                    $"Planta alta = Lista las mesas con numeraciones del 100 en adelante (esta opcion se desabilita si desde configuracion se marca " +
                    $"que no se va a trabajar con planta alta).\r\n\r\n" +

                    $"Pendiente = Lista las mesas que ya se les entrego la carta y estan esperando a realizar el primer pedido.\r\n\r\n" +

                    $"En proceso = Lista las mesas que se envio el pedido a cocina para su elaboracion (desde cocina deben indicar el pedido como " +
                    $"termiando para que este se cambie a 'Para entrega').\r\n\r\n" +

                    $"Para entrega = Lista las mesas en las que el pedido fue terminado desde cocina o solo se pidieron articulos que no " +
                    $"necesitan de esta, para que sea controlado por el mozo que este completo (que coincida la cantidad de articulos que busco " +
                    $"con lo que se pidio).\r\n\r\n" +

                    $"Entregado = Lista las mesas en las que el mozo indico que el pedido fue entregado (marcar esta opcion " +
                    $"directamente desde la ventana de los pedidos de la mesa si el cliente no va a pedir nada de cocina con el boton [Pedido entregado]).\r\n\r\n" +

                    $"Esperando pago = Lista las mesas que desde el menu de pedidos de la mesa, se genero la pre cuenta para " +
                    $"cerrarla (El mozo" +
                    $" debe cerrar la mesa una vez recibido el pago).", ClsColores.Blanco, 600, 800))
            {
                FormInformacion.ShowDialog();

                TmrColor.Stop();
                picBTNInformacion.BackColor = ClsColores.Transparente;
            }
        }

        /// <summary>
        /// Devuelve una unica instancia del formulario (Patron singleton)
        /// </summary>
        /// <returns></returns>
        public static FrmMesas ObtenerInstancia()
        {
            if (InstanciaForm == null) { InstanciaForm = new FrmMesas(); }

            return InstanciaForm;
        }

        #region Propiedades
        /// <summary>Asigna los ID y numeros de mesa para ser agregados a la mesa.</summary>
        public int[,] S_NumeroDeMesas { set { NumeroDeMesas = value; } }

        /// <summary>Asigna el ID del mozo que se encargara de atender la mesa.</summary>
        public int S_IDDelMozo { set { ID_Mozo = value; } }

        /// <summary>Asigna el nombre del mozo que se encargara de atender la mesa.</summary>
        public string S_NombreDelMozo { set { NombreMozo = value; } }

        /// <summary>Asigna el ID del chef que se encargara del pedido de la mesa.</summary>
        public int S_IDDelChef { set { ID_Chef = value; } }

        /// <summary>Cambia los minutos en los que se avisara una espera larga por un pedido de mesa.</summary>
        public int S_AvisoEspera { set { AvisoEspera = value; } }

        /// <summary>
        /// Indica que clientes asistieron a un pedido
        /// </summary>
        public List<int> S_ClientesDelPedido { set { ClientesDelPedido = value; } }

        /// <summary>
        /// Indica que debe continuar con la actualizacion de los clientes del pedido
        /// </summary>
        public DialogResult S_CargoClientesAlPedido { set { CargoClientesAlPedido = value; } }
        #endregion
    }
}
