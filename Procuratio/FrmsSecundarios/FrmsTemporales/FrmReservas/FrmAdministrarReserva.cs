using Datos;
using Negocio;
using Procuratio.ClsDeApoyo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Procuratio
{
    public partial class FrmAdministrarReserva : Form
    {
        #region Carga
        public FrmAdministrarReserva()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los datos de una reserva ya creada
        /// </summary>
        /// <param name="_ID_Reserva"></param>
        /// <param name="_ID_Cliente"></param>
        /// <param name="_ListaDeMesasReserva"></param>
        /// <param name="_Numeracion"></param>
        public FrmAdministrarReserva(int _ID_Reserva, int _ID_Cliente, List<int> _ListaDeMesasReserva, List<int> _Numeracion)
        {
            InitializeComponent();

            ID_Reserva = _ID_Reserva;
            ID_Cliente = _ID_Cliente;
            ListaDeMesasReserva = _ListaDeMesasReserva;
            Numeracion = _Numeracion;
        }

        private void FrmEditarReserva_Load(object sender, EventArgs e)
        {
            CargarFormasDeContactos();

            if (ID_Cliente != -1 && ID_Reserva != -1)
            {
                btnGuardarCambios.Visible = true;
                btnCrearReserva.Visible = false;
                CargarDatosCliente();
                CargarDatosReserva();
            }
            else
            {
                OcultarControlesCliente(true);
            }
            DatosCargados = true;
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

        private void CargarDatosReserva()
        {
            string InformacionDelError = string.Empty;

            ClsReservas Reservas = new ClsReservas();
            Reserva CargarDatosReserva = new Reserva();

            CargarDatosReserva = Reservas.LeerPorNumero(ID_Reserva, ref InformacionDelError);

            if (CargarDatosReserva != null)
            {
                dtpFecha.Value = CargarDatosReserva.Fecha;
                mtbHorario.Text = Convert.ToString(CargarDatosReserva.Hora);
                cmbFormaContacto.SelectedValue = CargarDatosReserva.ID_ViaContacto;
                nudCantidadPersonas.Value = CargarDatosReserva.CantidadPersonas;
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

        private void CargarFormasDeContactos()
        {
            string InformacionDelError = string.Empty;

            ClsViasDeContactos ViasDeContactos = new ClsViasDeContactos();

            List<ViaDeContacto> CargarComboBoxContactos = ViasDeContactos.LeerListado(ref InformacionDelError);

            if (CargarComboBoxContactos != null)
            {
                // Nombre de la columna que contiene el nombre
                cmbFormaContacto.DisplayMember = "Nombre";
                // Nombre de la columna que contiene el ID
                cmbFormaContacto.ValueMember = "ID_ViaDeContacto";

                // Llenar el combo
                cmbFormaContacto.DataSource = CargarComboBoxContactos.ToList();
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Ocurrio un fallo al cargar las formas de contactos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Variables
        private int ID_Reserva = -1;
        private int ID_Cliente = -1;
        List<int> ListaDeMesasReserva = new List<int>();
        List<int> Numeracion = new List<int>();
        private readonly int TIEMPO_MINIMO_NUEVA_RESERVA = 5;
        private bool DatosCargados = false; // Evita que se vacie la lista de mesas si modifica la cantidad de personas, al estar cargando el formulario
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
        #endregion

        private void BtnCargarCliente_Click(object sender, EventArgs e)
        {
            using (FrmCliente FormCliente = new FrmCliente(FrmCliente.EMostrarOcultarColumnas.MostrarEnviar))
            {
                FormCliente.AsignarFormAdministrarReservas(this);
                FormCliente.ShowDialog();

                if (FormCliente.DialogResult == DialogResult.OK)
                {
                    CargarDatosCliente(); // Se actualizo la variable ID_Cliente para cargar el nuevo cliente
                }
            }
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today > dtpFecha.Value.Date)
            {
                dtpFecha.Value = DateTime.Today;

                using (FrmInformacion FormInformacion = new FrmInformacion("No puede seleccionar una fecha que ya paso para reservar.", ClsColores.Blanco, 100, 300))
                {
                    FormInformacion.ShowDialog();
                }
            }

            if (DatosCargados)
            {
                if (ListaDeMesasReserva.Count > 0)
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion("Fecha actualizada, debe elegir nuevamente las mesas.", ClsColores.Blanco, 100, 300))
                    {
                        FormInformacion.ShowDialog();
                    }
                }

                ListaDeMesasReserva.Clear();
            }
        }

        private void BtnSeleccionarMesas_Click(object sender, EventArgs e)
        {
            bool HoraValida = ValidarHora(false);

            if (HoraValida)
            {
                ListaDeMesasReserva.Clear();

                using (FrmSeleccionDeMesas FormSeleccionDeMesas = new FrmSeleccionDeMesas(ID_Reserva, (int)nudCantidadPersonas.Value, dtpFecha.Value, this))
                {
                    FormSeleccionDeMesas.ShowDialog();
                }
            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            //TODO - Conexion con la BBDD para validar datos y cargarlos o no
            // Validar los datos.
            bool DatosValidos = true;
            string RegistroDeErrores = string.Empty;
            int AnchoFormInformacion = 100;

            ViaDeContacto ContactoSeleccionado = (ViaDeContacto)cmbFormaContacto.SelectedItem;

            lblMostrarNombre.Text = lblMostrarNombre.Text.Trim();
            lblMostrarApellido.Text = lblMostrarApellido.Text.Trim();
            lblMostrarTelefono.Text = lblMostrarTelefono.Text.Trim();

            if (dtpFecha.Value < DateTime.Today)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe ingresar una fecha, y esta debe ser mayor o igual a la actual.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (!ValidarHora(true))
            {
                DatosValidos = false;
                RegistroDeErrores += "Cambie el campo hora a un horario valido.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (ContactoSeleccionado == null)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe cargar la forma en que se contacto el cliente.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (ListaDeMesasReserva.Count == 0)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe cargar alguna mesa para asignarle a la 'reserva'.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (ID_Cliente == -1)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe cargar un cliente.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (DatosValidos)
            {
                string InformacionDelError = string.Empty;

                ClsReservas Reservas = new ClsReservas();
                Reserva ActualizarReserva = new Reserva();

                ActualizarReserva.ID_Cliente = ID_Cliente;
                ActualizarReserva.ID_Reserva = ID_Reserva;
                ActualizarReserva.Fecha = Convert.ToDateTime(dtpFecha.Value.Date);
                ActualizarReserva.Hora = TimeSpan.Parse(mtbHorario.Text);
                ActualizarReserva.ID_ViaContacto = ContactoSeleccionado.ID_ViaDeContacto;
                ActualizarReserva.CantidadPersonas = (int)nudCantidadPersonas.Value;
                ActualizarReserva.ID_EstadoReserva = (int)ClsEstadoReservas.EEstadosReservas.Pendiente;

                Reservas.Actualizar(ActualizarReserva, ref InformacionDelError);

                ClsMesasXReservas MesasXReservas = new ClsMesasXReservas();
                MesaXReserva CargarMesasReserva = new MesaXReserva();

                List<MesaXReserva> Eliminar = MesasXReservas.LeerListado(ClsMesasXReservas.EMesasDisponibles.PorID, ref InformacionDelError, DateTime.Today.Date, ID_Reserva);

                foreach (MesaXReserva Elemento in Eliminar)
                {
                    MesasXReservas.Borrar(Elemento.ID_MesaXReserva, ref InformacionDelError);
                }

                CargarMesasReserva.ID_Reserva = ActualizarReserva.ID_Reserva;

                foreach (int Elemento in ListaDeMesasReserva)
                {
                    CargarMesasReserva.ID_Mesa = Elemento;
                    MesasXReservas.Crear(CargarMesasReserva, ref InformacionDelError);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion(RegistroDeErrores, ClsColores.Blanco, AnchoFormInformacion, 300))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }

        private void BtnCrearReserva_Click(object sender, EventArgs e)
        {
            // Validar los datos.
            bool DatosValidos = true;
            string RegistroDeErrores = string.Empty;
            int AnchoFormInformacion = 100;

            ViaDeContacto ContactoSeleccionado = (ViaDeContacto)cmbFormaContacto.SelectedItem;

            lblMostrarNombre.Text = lblMostrarNombre.Text.Trim();
            lblMostrarApellido.Text = lblMostrarApellido.Text.Trim();
            lblMostrarTelefono.Text = lblMostrarTelefono.Text.Trim();

            if (dtpFecha.Value < DateTime.Today)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe ingresar una fecha, y esta debe ser mayor o igual a la actual.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (!ValidarHora(true))
            {
                DatosValidos = false;
                RegistroDeErrores += "Cambie el campo hora a un horario valido.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (ContactoSeleccionado == null)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe cargar la forma en que se contacto el cliente.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (ListaDeMesasReserva.Count == 0)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe cargar alguna mesa para asignarle a la reserva.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            // No cargo un cliente
            if (ID_Cliente == -1)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe cargar un cliente.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (DatosValidos)
            {
                string InformacionDelError = string.Empty;

                ClsReservas Reservas = new ClsReservas();
                Reserva CrearReserva = new Reserva();

                CrearReserva.Fecha = Convert.ToDateTime(dtpFecha.Value.Date);
                CrearReserva.Hora = TimeSpan.Parse(mtbHorario.Text);
                CrearReserva.ID_ViaContacto = ContactoSeleccionado.ID_ViaDeContacto;
                CrearReserva.CantidadPersonas = (int)nudCantidadPersonas.Value;
                CrearReserva.ID_EstadoReserva = (int)ClsEstadoReservas.EEstadosReservas.Pendiente;
                CrearReserva.ID_Cliente = ID_Cliente;

                if (Reservas.Crear(CrearReserva, ref InformacionDelError) != 0)
                {
                    ClsMesasXReservas MesasXReservas = new ClsMesasXReservas();
                    MesaXReserva CargarMesasReserva = new MesaXReserva();

                    CargarMesasReserva.ID_Reserva = CrearReserva.ID_Reserva;

                    foreach (int Elemento in ListaDeMesasReserva)
                    {
                        CargarMesasReserva.ID_Mesa = Elemento;
                        MesasXReservas.Crear(CargarMesasReserva, ref InformacionDelError);
                    }

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else if (InformacionDelError == string.Empty)
                {
                    MessageBox.Show("Fallo al intentar crear la reserva", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void BtnVerMesasCargadas_Click(object sender, EventArgs e)
        {
            using (FrmMesasReservadas FormMesasReservadas = new FrmMesasReservadas(ListaDeMesasReserva))
            {
                FormMesasReservadas.ShowDialog();
            }
        }

        /// <summary>
        /// Valida la hora ingresada por el usuario (retorna true si es correcta, de lo contrario false).
        /// </summary>
        /// <param name="_GuardarCambios">Si es true, evita la advertencia de que debe completar el campo HORA.</param>
        private bool ValidarHora(bool _GuardarCambios)
        {
            if (mtbHorario.MaskCompleted)
            {
                string[] Horario = mtbHorario.Text.Split(':');

                if (Convert.ToInt32(Horario[0]) >= 24)
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion("Ingrese una hora valida.", ClsColores.Blanco, 200, 300))
                    {
                        FormInformacion.ShowDialog();
                    }
                    return false;
                }
                else if (Convert.ToInt32(Horario[1]) >= 60)
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion("Ingrese un minuto valido.", ClsColores.Blanco, 200, 300))
                    {
                        FormInformacion.ShowDialog();
                    }
                    return false;
                }
                else
                {
                    bool ValidarHoraDiaActual = true;

                    int HoraActual = Convert.ToInt32(DateTime.Now.ToString("HH"));
                    int MinutoActual = Convert.ToInt32(DateTime.Now.ToString("mm")) + TIEMPO_MINIMO_NUEVA_RESERVA;

                    // Validar como correcto un horario mayor a la hora actual si la reserva la anotará para el mismo dia
                    if (DateTime.Today == dtpFecha.Value.Date && Convert.ToInt32(Horario[0]) <= HoraActual)
                    {
                        if (Convert.ToInt32(Horario[1]) <= MinutoActual && Convert.ToInt32(Horario[0]) == HoraActual)
                        {
                            ValidarHoraDiaActual = false;
                        }
                        else if (Convert.ToInt32(Horario[1]) >= MinutoActual && Convert.ToInt32(Horario[0]) == HoraActual)
                        {
                            ValidarHoraDiaActual = true;
                        }
                        else
                        {
                            ValidarHoraDiaActual = false;
                        }
                    }

                    if (ValidarHoraDiaActual)
                    {
                        // Hora correcta
                        return true;
                    }
                    else
                    {
                        using (FrmInformacion FormInformacion = new FrmInformacion($"La hora de reserva debe por lo menos {TIEMPO_MINIMO_NUEVA_RESERVA}" +
                                $" minutos mayor " +
                                $"a la hora actual (ya que " +
                                $"reserva el mismo dia).", ClsColores.Blanco, 200, 300))
                        {
                            FormInformacion.ShowDialog();
                        }
                        return false;
                    }
                }
            }
            else
            {
                if (!_GuardarCambios)
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion("Debe completar el campo HORA.", ClsColores.Blanco, 200, 300))
                    {
                        FormInformacion.ShowDialog();
                    }
                }

                return false;
            }
        }

        private void NudCantidadPersonas_ValueChanged(object sender, EventArgs e)
        {
            if (DatosCargados)
            {
                if (ListaDeMesasReserva.Count > 0)
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion("Cantidad de personas actualizada, debe elegir nuevamente las mesas asignadas.", ClsColores.Blanco, 200, 300))
                    {
                        FormInformacion.ShowDialog();
                    }
                }

                ListaDeMesasReserva.Clear();
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

        private void DtpFecha_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        public List<int> S_ListaDeMesasReserva { set { ListaDeMesasReserva = value; } }
        public List<int> S_Numeracion { set { Numeracion = value; } }
        public int S_ID_Cliente { set { ID_Cliente = value; } }
        #endregion
    }
}