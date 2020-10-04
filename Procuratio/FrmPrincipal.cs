using Datos;
using Negocio;
using Negocio.Clases_por_tablas;
using Procuratio.ClsDeApoyo;
using Procuratio.FrmGenerales;
using Procuratio.FrmsSecundarios;
using Procuratio.FrmsSecundarios.FrmEstadisticas;
using Procuratio.FrmsSecundarios.FrmsTemporales;
using Procuratio.FrmsSecundarios.FrmsTemporales.FrmCarta;
using System;
using System.Drawing;
using System.Runtime.InteropServices; //libreria para manipular el form
using System.Windows.Forms;

namespace Procuratio
{
    public partial class FrmPrincipal : Form
    {
        #region Codigo de carga
        private FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarLabels();
            PrepararFormularios();
            CargarConfiguraciones();
            PermisosUsuario();
            ComprobarVencimientos();

            pnlBarraDeArrastre.Select(); // Evitar bug visual al cargar el formulario
        }

        private void CargarLabels()
        {
            tslFecha.Text = DateTime.Now.ToLongDateString();
            tslHora.Text = DateTime.Now.ToShortTimeString();
            lblPerfil.Text = Convert.ToString((ClsPerfiles.EPerfiles)FrmInicioSesion.ObtenerInstancia().G_ID_PerfilUsuarioInicioSesion);
            lblUsuario.Text = FrmInicioSesion.ObtenerInstancia().G_NombreUsuarioInicioSesion;
        }

        private void PrepararFormularios()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                picBTNExpandir.Visible = false;
                picBTNReducir.Visible = true;
            }
            else
            {
                picBTNExpandir.Visible = true;
                picBTNReducir.Visible = false;
            }

            FORM_CLIENTE.PreparaFormParaPrincipal();
        }

        private void CargarConfiguraciones()
        {
            string InformacionDelError = string.Empty;

            ClsConfiguraciones Configuraciones = new ClsConfiguraciones();

            Configuracion RegistroLeido = Configuraciones.LeerPorNumero(1, ref InformacionDelError);

            if (RegistroLeido != null)
            {
                TiempoLimiteTranscurrido = RegistroLeido.TiempoFormAbierto;
            }
            else if (InformacionDelError != string.Empty)
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TiempoLimiteTranscurrido = 10;
            }
        }

        private void PermisosUsuario()
        {
            switch ((ClsPerfiles.EPerfiles)FrmInicioSesion.ObtenerInstancia().G_ID_PerfilUsuarioInicioSesion)
            {
                case ClsPerfiles.EPerfiles.Gerente:
                    {
                        // Permisos de gerente
                        break;
                    }
                case ClsPerfiles.EPerfiles.SubGerente:
                    {
                        // permisos de subgerente
                        break;
                    }
                case ClsPerfiles.EPerfiles.Mozo:
                    {
                        // permisos de mozo
                        break;
                    }
                case ClsPerfiles.EPerfiles.Chef:
                    {
                        // Permisos de chef
                        // El chef solo ve la cocina.
                        tsmAccesoRapido.Visible = false;
                        btnReservas.Visible = false;
                        btnMesas.Visible = false;
                        btnDelivery.Visible = false;
                        btnCarta.Visible = false;
                        btnCaja.Visible = false;
                        btnConfiguracion.Visible = false;
                        BtnClientes.Visible = false;
                        pnlContBotonesEstadisticas.Visible = false;
                        break;
                    }
                case ClsPerfiles.EPerfiles.Administrador:
                    {
                        // Permisos de administrador
                        btnReservas.Visible = true;
                        btnMesas.Visible = true;
                        btnCocina.Visible = true;
                        btnCarta.Visible = true;
                        btnCaja.Visible = true;
                        btnConfiguracion.Visible = true;

                        btnEstadisticas.Visible = true;
                        btnEstadisticas.Enabled = true;
                        btnDelivery.Visible = true;
                        btnDelivery.Enabled = true;
                        BtnStock.Visible = true;
                        BtnStock.Enabled = true;
                        break;
                    }
                default:
                    {
                        MessageBox.Show($"Fallo al cargar el usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                        break;
                    }
            }
        }

        private void ComprobarVencimientos()
        {
            bool MostrarMensaje = false;
            bool LicenciaExpirada = false;
            string MensajesDeAviso = string.Empty;
            int AnchoFormInformacion = 200;

            string InformacionDelError = string.Empty;

            ClsVencimientosFuncionalidades VencimientosFuncionalidades = new ClsVencimientosFuncionalidades();
            VencimientoFuncionalidades ComprobarVencimientos = VencimientosFuncionalidades.LeerPorNumero(1, ref InformacionDelError);

            if (ComprobarVencimientos != null)
            {
                if (FrmInicioSesion.ObtenerInstancia().G_ID_PerfilUsuarioInicioSesion != (int)ClsPerfiles.EPerfiles.Administrador)
                {
                    // Vencimiento general
                    if (ComprobarVencimientos.VencimientoGeneral.Date < DateTime.Now.Date)
                    {
                        LicenciaExpirada = true;

                        MostrarMensaje = true;
                        AnchoFormInformacion += 50;
                        MensajesDeAviso += $"Se vencieron las funcionalidades del sistema.\r\n\r\n";
                    }
                    else if (ComprobarVencimientos.VencimientoGeneral.Date >= DateTime.Now.Date && ComprobarVencimientos.VencimientoGeneral.Date <= DateTime.Now.Date.AddDays(7))
                    {
                        MostrarMensaje = true;
                        AnchoFormInformacion += 50;
                        MensajesDeAviso += $"Aviso: Se venceran las funciones de todo el programa " +
                            $"en {(ComprobarVencimientos.VencimientoGeneral.Date - DateTime.Now.Date).TotalDays} dias, al " +
                            $"cumplirse la fecha limite de uso (esto se realizara automaticamente). Contacte con el " +
                            $"programador para actualizar su fecha de vencimiento (no perdera los dias restantes que falten " +
                            $"para el vencimiento, estos seran acumulados).\r\n\r\n";
                    }

                    // Vencimiento especifico de funcionalidades del sistema
                    if (ComprobarVencimientos.VencimientoFunciones.Date < DateTime.Now.Date)
                    {
                        BtnEstadisticasCaja.Enabled = false;
                        BtnEstadisticasDelivery.Enabled = false;
                        BtnEstadisticasGenerales.Enabled = false;
                        BtnEstadisticasReservas.Enabled = false;
                        BtnEstadisticasCarta.Enabled = false;

                        if (ComprobarVencimientos.VencimientoFunciones.Date >= DateTime.Now.Date.AddDays(7))
                        {
                            MostrarMensaje = true;
                            AnchoFormInformacion += 50;
                            MensajesDeAviso += $"Se vencieron las funcionalidades especificas en el sistema (estadisticas).\r\n\r\n";
                        }
                    }
                    else if (ComprobarVencimientos.VencimientoFunciones.Date >= DateTime.Now.Date && ComprobarVencimientos.VencimientoFunciones.Date <= DateTime.Now.Date.AddDays(7))
                    {
                        MostrarMensaje = true;
                        AnchoFormInformacion += 50;
                        MensajesDeAviso += $"Se vencera las funciones especificas del programa (estadisticas)" +
                            $"en {(ComprobarVencimientos.VencimientoFunciones.Date - DateTime.Now.Date).TotalDays} dias.\r\n\r\n";
                    }

                    if (MostrarMensaje)
                    {
                        using (FrmInformacion FormInformacion = new FrmInformacion(MensajesDeAviso, ClsColores.Blanco, AnchoFormInformacion, 450))
                        {
                            FormInformacion.ShowDialog();
                        }
                    }
                }
                else
                {
                    BtnEstadisticasCaja.Enabled = true;
                    BtnEstadisticasDelivery.Enabled = true;
                    BtnEstadisticasGenerales.Enabled = true;
                    BtnEstadisticasReservas.Enabled = true;
                    BtnEstadisticasCarta.Enabled = true;
                }

                // Habilitar los botones de los forms si se reinicio el programa y la licencia se actualizo
                BloquearDesbloquearFuncionalidades(LicenciaExpirada);
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al leer los datos para compobar el vencimiento de las funciones " +
                    "del sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void BloquearDesbloquearFuncionalidades(bool _Bloquear)
        {
            FrmReservas.ObtenerInstancia().BloquearPorVencimientoLicencia(_Bloquear);
            FrmMesas.ObtenerInstancia().BloquearPorVencimientoLicencia(_Bloquear);
            FrmCarta.ObtenerInstancia().BloquearPorVencimientoLicencia(_Bloquear);
            FrmCaja.ObtenerInstancia().BloquearPorVencimientoLicencia(_Bloquear);
            FrmCocina.ObtenerInstancia().BloquearPorVencimientoLicencia(_Bloquear);
            FrmConfiguracion.ObtenerInstancia().BloquearPorVencimientoLicencia(_Bloquear);
            FrmDelivery.ObtenerInstancia().BloquearPorVencimientoLicencia(_Bloquear);
            FORM_CLIENTE.BloquearPorVencimientoLicencia(false);
            tsmAccesoRapido.Enabled = !_Bloquear;
            tsmHerramientas.Enabled = !_Bloquear;
        }
        #endregion

        #region Variables
        private static FrmPrincipal InstanciaForm;
        private readonly FrmCliente FORM_CLIENTE = new FrmCliente(FrmCliente.EMostrarOcultarColumnas.MostrarSeleccionar);

        private Form UltimoFormAbierto;
        private Button BotonPresionado;
        private Button BotonSubmenuPresionado;

        private int Horas = 0, Minutos = 0, Segundos = 0;
        private int MinutosTranscurridos = 0, TiempoLimiteTranscurrido = 10;
        private bool FormAccesoEspecialAbierto = false;
        private readonly TimeSpan PRIMERA_ADVERTENCIA = new TimeSpan(12, 00, 00);
        private readonly TimeSpan SEGUNDA_ADVERTENCIA = new TimeSpan(20, 00, 00);
        private readonly TimeSpan TIEMPO_LIMITE_CONEXION = new TimeSpan(24, 00, 00);

        private bool SeEstaMostrandoAdvertencia = false;
        private int SegundoDeInicioAdvertencia = -1;
        
        private readonly int MEDIDA_MENU_EXPANDIDO = 300, MEDIDA_MENU_CONTRAIDO = 85;
        private readonly int MEDIDA_ESTADISTICA_MENU_EXPANDIDO = 303, MEDIDA_ESTADISTICA_MENU_CONTRAIDO = 50;
        #endregion

        #region codigo para agregarle la propiedad de mover a la barra personalizada y el doble click
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hand, int wasg, int wparam, int iparam);

        private void pnlBarraDeArrastre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

            //Cambiar el icono que se muestra si se reduce la pantalla por apretar y arrastrar la barra (y no con el boton)
            if (WindowState == FormWindowState.Normal)
            {
                picBTNExpandir.Visible = true;
                picBTNReducir.Visible = false;
            }

            //Agrandar o reducir Form con doble click
            if (e.Button == MouseButtons.Left && e.Clicks == 2) { ExpandirReducir(); }
        }
        #endregion

        #region Codigo para darle estilo a los botones
        //Propiedad para los picturebox
        private void ColorFondoBotones_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;

            if (PictureBoxEnFoco.Name == picBTNDespliegaMenuVertical.Name)
            {
                PictureBoxEnFoco.BackColor = ClsColores.Gris;
            }
            else if (PictureBoxEnFoco.Name == picBTNCerrar.Name)
            {
                PictureBoxEnFoco.BackColor = ClsColores.Rojo;
            }
            else
            {
                PictureBoxEnFoco.BackColor = ClsColores.NaranjaClaro;
            }
        }

        private void ColorFondoBotones_MouseLeave(object sender, EventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;
            PictureBoxEnFoco.BackColor = ClsColores.Transparente;
        }

        //Propiedad para los botones
        private void ColorBotonesMenuVertical_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            BotonEnFoco.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);

            if (BotonEnFoco.Name == btnCerrarSesion.Name)
            {
                BotonEnFoco.BackColor = ClsColores.NaranjaClaro;
            }
            else if (BotonEnFoco.Name == btnConfiguracion.Name)
            {
                BotonEnFoco.BackColor = ClsColores.VioletaOscuro;
            }
            else if (BotonEnFoco.Name == BtnEstadisticasCarta.Name || BotonEnFoco.Name == BtnEstadisticasDelivery.Name || BotonEnFoco.Name == BtnEstadisticasGenerales.Name || BotonEnFoco.Name == BtnEstadisticasCaja.Name || BotonEnFoco.Name == BtnEstadisticasReservas.Name)
            {
                BotonEnFoco.BackColor = ClsColores.VerdeClaro;
            }
            else
            {
                BotonEnFoco.BackColor = ClsColores.Verde;
            }
        }

        private void ColorBotonesMenuVertical_MouseLeave(object sender, EventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            //Si el boton que esta en foco es diferente al que tiene asociado el evento del formulario que se encuentra en 
            //pantalla, cambiar la propiedad, sino, no entrar al IF
            if (BotonEnFoco != BotonPresionado && BotonEnFoco != BotonSubmenuPresionado) { BotonEnEstadoOriginal(BotonEnFoco); }
        }

        /// <summary>
        /// Vuelve el estado del boton que dejo de tener foco como deseleccionado con excepcion del boton del formulario abierto
        /// </summary>
        /// <param name="_CambiarEstilo">Boton que esta en foco (y no es el seleccionado).</param>
        private void BotonEnEstadoOriginal(Button _CambiarEstilo)
        {
            if (_CambiarEstilo != null)
            {
                _CambiarEstilo.ForeColor = Color.White;
                _CambiarEstilo.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                _CambiarEstilo.BackColor = ClsColores.Transparente;
            }
        }

        /// <summary>
        /// Selecciona el boton si el usuario ingreso los datos correctamente, pese a haber perdido foco el boton para
        /// seleccionarlo
        /// </summary>
        /// <param name="_BotonFormCritico">Boton del formulario critico que se abrió.</param>
        private void SeleccionarBotonFormCritico(Button _BotonFormCritico)
        {
            if (_BotonFormCritico.Name == btnConfiguracion.Name)
            {
                _BotonFormCritico.BackColor = ClsColores.VioletaOscuro;
            }
            else if (_BotonFormCritico.Name == BtnEstadisticasCarta.Name || _BotonFormCritico.Name == BtnEstadisticasDelivery.Name || _BotonFormCritico.Name == BtnEstadisticasGenerales.Name || _BotonFormCritico.Name == BtnEstadisticasCaja.Name || _BotonFormCritico.Name == BtnEstadisticasReservas.Name)
            {
                _BotonFormCritico.BackColor = ClsColores.VerdeClaro;
            }
            else
            {
                _BotonFormCritico.BackColor = ClsColores.Verde;
            }

            _BotonFormCritico.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
        }
        #endregion

        #region Codigo para darle las funciones BASICAS a los botones de estado del formulario (minimizar, salir, etc)
        private void picBTNCerrar_Click(object sender, EventArgs e)
        {
            FrmRespuesta RespuestaFormulario = new FrmRespuesta("¿Esta seguro que desea cerrar el programa?", FrmRespuesta.ETamaño.Pequeño, FrmRespuesta.ETipo.Si_No);

            if (RespuestaFormulario.DialogResult == DialogResult.Yes)
            {
                FrmInicioSesion.ObtenerInstancia().S_SeCierraLaAplicacion = true;
                Application.Exit();
            }
        }

        //Funcion delegada a un metodo debido a que es utilizado por otra parte del codigo (cuando el usuario arrastra el Frm)
        private void picBTNExpandirReducir_Click(object sender, EventArgs e) => ExpandirReducir();

        /// <summary>
        /// Cambia la propiedad FormWindowState del formulario al estado opuesto al que se encontraba y muestra los botones
        /// correspondientes para expandir o reducir
        /// </summary>
        private void ExpandirReducir()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                picBTNExpandir.Visible = true;
                picBTNReducir.Visible = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                picBTNExpandir.Visible = false;
                picBTNReducir.Visible = true;
            }
        }

        private void picBTNMinimizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        //Codigo de despliege de menu
        private void picBTNDespliegaMenuVertical_Click(object sender, EventArgs e) => DesplegarContraerMenuVertical();

        private void DesplegarContraerMenuVertical()
        {
            if (pnlContBotonesEstadisticas.Height == 303)
            {
                pnlContBotonesEstadisticas.Height = 50;
                pnlSeparadorEstadisticas.Visible = false;
            }

            if (pnlMenuVertical.Width == MEDIDA_MENU_EXPANDIDO)
            {
                OcultaMuestraTextoMenuContraido(true);

                pnlMenuVertical.Width = MEDIDA_MENU_CONTRAIDO;
                picBTNDespliegaMenuVertical.Dock = DockStyle.Fill;
            }
            else
            {
                OcultaMuestraTextoMenuContraido(false);

                pnlMenuVertical.Width = MEDIDA_MENU_EXPANDIDO;
                picBTNDespliegaMenuVertical.Dock = DockStyle.Right;

                if (BotonPresionado != null)
                {
                    if (BotonPresionado.Name == btnEstadisticas.Name) { pnlContBotonesEstadisticas.Height = 303; }
                }
            }
        }

        /// <summary>
        /// Ocultar todo el texto cuando se comprima el menu vertical para dejar solo los iconos visibles y llama al metodo que
        /// determina se debe mostrar el block de notas en el formulario de mesas
        /// </summary>
        /// <param name="_Contraido">Determina si debe ocultar o mostrar</param>
        private void OcultaMuestraTextoMenuContraido(bool _Contraido)
        {
            if (_Contraido)
            {
                btnReservas.Text = string.Empty;
                btnMesas.Text = string.Empty;
                btnDelivery.Text = string.Empty;
                btnCocina.Text = string.Empty;
                btnCarta.Text = string.Empty;
                btnCaja.Text = string.Empty;
                BtnStock.Text = string.Empty;
                btnConfiguracion.Text = string.Empty;
                btnEstadisticas.Text = string.Empty;
                btnCerrarSesion.Text = string.Empty;
                BtnClientes.Text = string.Empty;
                lblTituloUsuario.Visible = false;
                lblTituloPerfil.Visible = false;
                lblUsuario.Visible = false;
                lblPerfil.Visible = false;
            }
            else
            {
                btnReservas.Text = "Reservas";
                btnMesas.Text = "Mesas";
                btnCocina.Text = "Cocina";
                btnDelivery.Text = "Delivery";
                btnCarta.Text = "Carta";
                btnCaja.Text = "Caja";
                BtnStock.Text = "Stock";
                btnConfiguracion.Text = "Configuracion";
                btnEstadisticas.Text = "Estadisticas";
                btnCerrarSesion.Text = "Cerrar sesión actual";
                BtnClientes.Text = "Clientes";
                lblTituloUsuario.Visible = true;
                lblTituloPerfil.Visible = true;
                lblUsuario.Visible = true;
                lblPerfil.Visible = true;
            }
        }
        #endregion

        #region Gestor de formularios
        //Abrir u ocultar forms
        private void btnReservas_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmReservas.ObtenerInstancia(), sender);
        private void btnMesas_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmMesas.ObtenerInstancia(), sender);
        private void BtnCocina_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmCocina.ObtenerInstancia(), sender);
        private void BtnCarta_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmCarta.ObtenerInstancia(), sender);
        private void btnCaja_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmCaja.ObtenerInstancia(), sender);
        private void btnConfiguracion_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmConfiguracion.ObtenerInstancia(), sender);
        private void BtnDelivery_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmDelivery.ObtenerInstancia(), sender);
        private void BtnStock_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmStock.ObtenerInstancia(), sender);
        private void BtnClientes_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FORM_CLIENTE, sender);

        #region Codigo de gestion del submenu de estadisticas
        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == MEDIDA_MENU_CONTRAIDO) { DesplegarContraerMenuVertical(); }

            if (pnlContBotonesEstadisticas.Height == MEDIDA_ESTADISTICA_MENU_CONTRAIDO)
            {
                pnlContBotonesEstadisticas.Height = MEDIDA_ESTADISTICA_MENU_EXPANDIDO;
                pnlSeparadorEstadisticas.Visible = true;
            }
            else
            {
                // El cambio de la propiedad visible evita un bug visual de la scrollbar
                pnlContBotonesMenu.Visible = false;

                pnlContBotonesEstadisticas.Height = MEDIDA_ESTADISTICA_MENU_CONTRAIDO;
                pnlSeparadorEstadisticas.Visible = false;

                pnlContBotonesMenu.Visible = true;
            }
        }

        private void BtnEstadisticasCarta_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmEstadisticasCarta.ObtenerInstancia(), btnEstadisticas, sender);

        private void BtnEstadisticasDelivery_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmEstadisticasDelivery.ObtenerInstancia(), btnEstadisticas, sender);

        private void BtnEstadisticasGenerales_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmEstadisticasGenerales.ObtenerInstancia(), btnEstadisticas, sender);

        private void BtnEstadisticasMesas_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmEstadisticasCaja.ObtenerInstancia(), btnEstadisticas, sender);

        private void BtnEstadisticasReservas_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmEstadisticasReservas.ObtenerInstancia(), btnEstadisticas, sender);
        #endregion

        /// <summary>
        /// Prepara el objeto de tipo formulario para mostrarlo al usuario (validadndo tambien su autorizacion)
        /// </summary>
        /// <param name="_FormMostrar">Formulario que se mostrara.</param>
        /// <param name="_Boton">Propiedades del evento que llamó al metodo.</param>
        /// <param name="_SubBoton">Obtiene el boton del submenu que llamo al evento.</param>
        private void PreparaFormParaMostrar(Form _FormMostrar, object _Boton, object _SubBoton = null)
        {
            // 'AccesoAutorizado' determinara si el usuario ingreso una contraseña valida, si intento abrir un Form critico.
            bool AccesoAutorizado = true;

            // 'FormAccesoEspecialAbierto = true' le indicara al reloj, que debe incrementar la variable 'MinutosInactivos', para ocultar
            // el Form si este se mantuvo en pantalla por mas del tiempo indicado por el usuario, por defecto esta indicado que no se aumente, hasta
            // que detecte que se intenta abrir un Form critico
            FormAccesoEspecialAbierto = false;

            // Preguntar si el formulario que quiere abrir es critico.
            if (_FormMostrar == FrmCaja.ObtenerInstancia() || _FormMostrar == FrmConfiguracion.ObtenerInstancia() || _FormMostrar == FrmCarta.ObtenerInstancia() || _FormMostrar == FrmStock.ObtenerInstancia() || _FormMostrar == FrmEstadisticasCaja.ObtenerInstancia())
            {
                // En caso afirmativo, se pregunta si ya esta abierta para no volver a pedir contraseña (se resetea si cambia el
                // formulario o supera el limite de uno de estos activos).
                if (_FormMostrar != UltimoFormAbierto)
                {
                    using (FrmValidarUsuario FormValidarUsuario = new FrmValidarUsuario(FrmValidarUsuario.EFiltroUsuariosAutorizados.GerentesSubGerentes))
                    {
                        // Le doy foco a otro control para evitar el borde blanco en el boton.
                        pnlContDeFrmsSecundarios.Select();

                        FormValidarUsuario.ShowDialog();

                        if (FormValidarUsuario.DialogResult == DialogResult.OK)
                        {
                            FormAccesoEspecialAbierto = true;
                            MinutosTranscurridos = 0;
                        }
                        else
                        {
                            AccesoAutorizado = false;
                        }
                    }
                }
            }

            // If para evitar ejecutar repetidamente la carga de un formulario, si el que quiere abrir, ya esta en pantalla,
            // e impedir abrir los formularios especiales si no ingreso los datos de seguridad en forma correcta.
            if (_FormMostrar != UltimoFormAbierto && AccesoAutorizado)
            {
                SeleccionarBotonFormCritico((Button)_Boton);
                if (_SubBoton != null && BotonSubmenuPresionado != null || ((Button)_Boton).Name == btnEstadisticas.Name) { SeleccionarBotonFormCritico((Button)_SubBoton); }

                // Ocultar form viejo.
                if (UltimoFormAbierto != null)
                {
                    UltimoFormAbierto.Hide();
                    pnlContDeFrmsSecundarios.Controls.Remove(UltimoFormAbierto);
                }

                if (BotonPresionado != null && BotonPresionado != (Button)_Boton) { BotonEnEstadoOriginal(BotonPresionado); } // Deseleccionar boton viejo.
                if (BotonSubmenuPresionado != null) { BotonEnEstadoOriginal(BotonSubmenuPresionado); }

                MinutosTranscurridos = 0;

                BotonPresionado = (Button)_Boton; //Esto evitara que los eventos move y leave le cambien el estilo al boton en el codigo de estilo.

                if (_SubBoton != null)
                {
                    BotonSubmenuPresionado = (Button)_SubBoton;
                }
                else
                {
                    BotonSubmenuPresionado = null;
                }

                _FormMostrar.TopLevel = false;
                _FormMostrar.Dock = DockStyle.Fill;
                _FormMostrar.FormBorderStyle = FormBorderStyle.None;
                pnlContDeFrmsSecundarios.Controls.Add(_FormMostrar);

                _FormMostrar.Show();

                UltimoFormAbierto = _FormMostrar;

                if (BotonPresionado.Name != btnEstadisticas.Name && pnlContBotonesEstadisticas.Height == MEDIDA_ESTADISTICA_MENU_EXPANDIDO)
                {
                    // El cambio de la propiedad visible evita un bug visual de la scrollbar
                    pnlContBotonesMenu.Visible = false;

                    pnlContBotonesEstadisticas.Height = MEDIDA_ESTADISTICA_MENU_CONTRAIDO;
                    pnlSeparadorEstadisticas.Visible = false;

                    pnlContBotonesMenu.Visible = true;
                }
            }
        }

        private void TiempoTranscurridoExcedido()
        {
            if (UltimoFormAbierto != null) // Evitar posible Excepcion por objeto nulo (ya que se iguala a null este objeto si un 
            {                              // form Importante esta mucho tiempo activo).
                BotonEnEstadoOriginal(BotonPresionado);
                if (BotonSubmenuPresionado != null) { BotonEnEstadoOriginal(BotonSubmenuPresionado); }
                UltimoFormAbierto.Hide();
                pnlContDeFrmsSecundarios.Controls.Remove(UltimoFormAbierto);
            }

            UltimoFormAbierto = null;
            BotonPresionado = null;
            BotonSubmenuPresionado = null;
            FormAccesoEspecialAbierto = false;
            MinutosTranscurridos = 0;
        }
        #endregion

        private void tmrActualizarDatos_Tick(object sender, EventArgs e)
        {
            ActualizarReloj();
            ComprobarConexionMaxima();
            if (SeEstaMostrandoAdvertencia) { ActualizarAdvertencia(); }

            tslFecha.Text = DateTime.Now.ToLongDateString();
            tslHora.Text = DateTime.Now.ToShortTimeString();

            // Si los minutos transcurridos son mayores o iguales al establecido, ejecutar el metodo de reseteo de Forms 
            // (oculta los formularios criticos).
            if (MinutosTranscurridos >= TiempoLimiteTranscurrido) { TiempoTranscurridoExcedido(); }

            // Encoger menu lateral (cada 10 minutos)
            if (Minutos % 10 == 0 && Segundos == 0 && pnlMenuVertical.Width == MEDIDA_MENU_EXPANDIDO) { DesplegarContraerMenuVertical(); }
        }

        private void ActualizarReloj()
        {
            Segundos++;

            if (Segundos == 60)
            {
                Minutos++;

                // Si el Form abierto es critico, aumentar el tiempo.
                if (FormAccesoEspecialAbierto) { MinutosTranscurridos++; }

                if (Minutos == 60)
                {
                    Minutos = 0;
                    Horas++;
                }

                Segundos = 0;
            }

            if (Segundos >= 10)
            {
                if (Minutos < 10)
                {
                    if (Horas < 10)
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = 0{Horas}:0{Minutos}:{Segundos}";
                    }
                    else
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = {Horas}:0{Minutos}:{Segundos}";
                    }
                }
                else
                {
                    if (Horas < 10)
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = 0{Horas}:{Minutos}:{Segundos}";
                    }
                    else
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = {Horas}:{Minutos}:{Segundos}";
                    }
                }
            }
            else
            {
                if (Minutos < 10)
                {
                    if (Horas < 10)
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = 0{Horas}:0{Minutos}:0{Segundos}";
                    }
                    else
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = {Horas}:0{Minutos}:0{Segundos}";
                    }
                }
                else
                {
                    if (Horas < 10)
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = 0{Horas}:{Minutos}:0{Segundos}";
                    }
                    else
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = {Horas}:{Minutos}:0{Segundos}";
                    }
                }
            }
        }

        private void ComprobarConexionMaxima()
        {
            if (TimeSpan.Parse(tslTiempoConexion.Text.Substring(21, 8).Trim()) >= TIEMPO_LIMITE_CONEXION)
            {
                tmrActualizarDatos.Stop();

                tslTiempoConexion.ForeColor = ClsColores.Rojo;

                FrmInicioSesion.ObtenerInstancia().S_TiempoDeSesionExedido = true;

                Close();
            }
            else if (TimeSpan.Parse(tslTiempoConexion.Text.Substring(21, 8).Trim()) >= SEGUNDA_ADVERTENCIA)
            {
                tslTiempoConexion.ForeColor = ClsColores.NarajaRojo;
            }
            else if (TimeSpan.Parse(tslTiempoConexion.Text.Substring(21, 8).Trim()) >= PRIMERA_ADVERTENCIA)
            {
                tslTiempoConexion.ForeColor = ClsColores.AmarilloClaro;
            }
            else
            {
                tslTiempoConexion.ForeColor = ClsColores.Gris;
            }
        }

        /// <summary>
        /// Genera un mensaje resaltado en la parte inferior del menu principal en el caso de que se produsca un error 
        /// grave en alguna parte del programa (el metodo debe ser llamado en el bloque de codigo que informa el error 
        /// en la respectiva parte del programa desde donde se produjo).
        /// </summary>
        /// <param name="_Mensaje">Mensaje a mostrar. Debe ser breve para que no desplace el resto de informacion 
        /// como el tiempo de conexion, si supera los 40 caracteres, sera recortado.</param>
        public void MensajeAdvertencia(string _Mensaje)
        {
            if (_Mensaje.Length > 50) { _Mensaje = _Mensaje.Substring(0, 50); }

            tslResultadoOperacion.Text = _Mensaje;
            SeEstaMostrandoAdvertencia = true;
            SegundoDeInicioAdvertencia = Segundos - 1;
        }

        private void ActualizarAdvertencia()
        {
            if (Segundos % 2 == 0)
            {
                tslResultadoOperacion.ForeColor = ClsColores.Gainsboro;
                tslResultadoOperacion.BackColor = ClsColores.GrisOscuroFondo;
            }
            else
            {
                tslResultadoOperacion.ForeColor = ClsColores.Amarillo;
                tslResultadoOperacion.BackColor = ClsColores.Negro;
            }

            if (Segundos == SegundoDeInicioAdvertencia)
            {
                SeEstaMostrandoAdvertencia = false;
                tslResultadoOperacion.ForeColor = ClsColores.Gainsboro;
                tslResultadoOperacion.BackColor = ClsColores.GrisOscuroFondo;
                tslResultadoOperacion.Text = "Resultado del proceso";
            }
            else if (SegundoDeInicioAdvertencia == -1) //Actualizar los segundos a 0 si justo los segundos dieron como resultado -1
            {
                SegundoDeInicioAdvertencia = 0;
            }
        }

        #region Botones del MenuStrip

        #region Herramientas
        private void CalculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                prcCalculadora.Start();
                pnlBarraDeArrastre.Select(); //Selecciono este panel para que no se marque el boton con bordes blancos al 
            }                                //abrir la calculadora
            catch (Exception Error)
            {
                MessageBox.Show($"No se pudo abrir la aplicacion: {Error}", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void NotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmNotas Notas = new FrmNotas()) { Notas.ShowDialog(); }
        }
        #endregion

        #region Acceso rapido
        #region Reserva
        private void CrearReservaToolStripMenuItem_Click(object sender, EventArgs e) => FrmReservas.ObtenerInstancia().BtnCrearReserva_Click(sender, e);
        #endregion

        #region Mesas
        private void CrearMesaToolStripMenuItem_Click(object sender, EventArgs e) => FrmMesas.ObtenerInstancia().btnCrearPedido_Click(sender, e);

        private void VerMesasDisponiblesToolStripMenuItem_Click(object sender, EventArgs e) => FrmMesas.ObtenerInstancia().BtnVerMesasDisponibles_Click(sender, e);
        #endregion

        #region Delivery
        private void CrearDeliveryToolStripMenuItem_Click(object sender, EventArgs e) => FrmDelivery.ObtenerInstancia().BtnCrearDelivery_Click(sender, e);
        #endregion

        #region Carta
        private void CrearArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmValidarUsuario FormValidarUsuario = new FrmValidarUsuario(FrmValidarUsuario.EFiltroUsuariosAutorizados.GerentesSubGerentes))
            {
                FormValidarUsuario.ShowDialog();

                if (FormValidarUsuario.DialogResult == DialogResult.OK)
                {
                    FrmCarta.ObtenerInstancia().BtnCrearArticulo_Click(sender, e);
                }
            }
        }

        private void CrearCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmValidarUsuario FormValidarUsuario = new FrmValidarUsuario(FrmValidarUsuario.EFiltroUsuariosAutorizados.GerentesSubGerentes))
            {
                FormValidarUsuario.ShowDialog();
                
                if (FormValidarUsuario.DialogResult == DialogResult.OK)
                {
                    FrmVerEditarCategorias FormCrearEditarVerCategorias = new FrmVerEditarCategorias();
                    FormCrearEditarVerCategorias.ShowDialog();
                }
            }
        }
        #endregion

        #region Configuracion
        private void CrearCopiaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e) => FrmConfiguracion.ObtenerInstancia().BtnGenerarCopiaDeSeguridad_Click(sender, e);

        private void AdministrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmValidarUsuario FormValidarUsuario = new FrmValidarUsuario(FrmValidarUsuario.EFiltroUsuariosAutorizados.GerentesSubGerentes))
            {
                FormValidarUsuario.ShowDialog();

                if (FormValidarUsuario.DialogResult == DialogResult.OK)
                {
                    FrmConfiguracion.ObtenerInstancia().BtnAdministrarUsuarios_Click(sender, e);
                }
            }
        }

        private void InformacionDelRestaurantetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmValidarUsuario FormValidarUsuario = new FrmValidarUsuario(FrmValidarUsuario.EFiltroUsuariosAutorizados.GerentesSubGerentes))
            {
                FormValidarUsuario.ShowDialog();

                if (FormValidarUsuario.DialogResult == DialogResult.OK)
                {
                    FrmConfiguracion.ObtenerInstancia().BtnEditarInformacionRestaurante_Click(sender, e);
                }
            }
        }
        #endregion

        #region General
        private void CrearverClientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (FrmCliente FormCliente = new FrmCliente(FrmCliente.EMostrarOcultarColumnas.NoMostrarSeleccionarEnviar))
            {
                FormCliente.ShowDialog();
            }
        }

        private void VerMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfiguracion.ObtenerInstancia().BtnVerMesasDisponibles_Click(sender, e);
        }
        #endregion
        #endregion

        #region Acerca de
        private void TsmVerVencimientos_Click(object sender, EventArgs e)
        {
            string InformacionDelError = string.Empty;

            ClsVencimientosFuncionalidades VencimientosFuncionalidades = new ClsVencimientosFuncionalidades();
            VencimientoFuncionalidades ComprobarVencimientos = VencimientosFuncionalidades.LeerPorNumero(1, ref InformacionDelError);

            if (ComprobarVencimientos != null)
            {
                using (FrmInformacion FormInformacion = new FrmInformacion($"Vencimiento de todo el programa [ {ComprobarVencimientos.VencimientoGeneral.ToShortDateString()} ]\r\n\r\n" +
                        $"Vencimiento de funciones especificas (estadisticas) [ {ComprobarVencimientos.VencimientoFunciones.ToShortDateString()} ]", ClsColores.Blanco, 200, 600))
                {
                    FormInformacion.ShowDialog();
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al leer los datos para compobar el vencimiento de las funciones " +
                    "del sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TsmDesarrollador_Click(object sender, EventArgs e)
        {
            FrmPantallaDePresentacion.ObtenerInstancia().PreparaFrmParaMostrar();
            FrmPantallaDePresentacion.ObtenerInstancia().ShowDialog();
        }

        private void VerDetallesDeLaActualizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizaciones Actualizaciones = new FrmActualizaciones();
            Actualizaciones.ShowDialog();
        }
        #endregion
        #endregion

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmRespuesta RespuestaFormulario = new FrmRespuesta("¿Esta seguro que desea cerrar sesión?", FrmRespuesta.ETamaño.Pequeño, FrmRespuesta.ETipo.Si_No);

            if (RespuestaFormulario.DialogResult == DialogResult.Yes) { Close(); }
        }

        /// <summary>
        /// Devuelve una unica instancia del formulario (Patron singleton)
        /// </summary>
        /// <returns></returns>
        public static FrmPrincipal ObtenerInstancia()
        {
            if (InstanciaForm == null) { InstanciaForm = new FrmPrincipal(); }

            return InstanciaForm;
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Saco de pantalla cualquier formulario que pudiera haber quedado antes de sacar el principal
            if (UltimoFormAbierto != null)
            {
                UltimoFormAbierto.Hide();
                pnlContDeFrmsSecundarios.Controls.Remove(UltimoFormAbierto);
            }

            InstanciaForm = null;
        }

        #region Propiedades
        /// <summary>Actualiza la propiedad text del tlsResultadoOperacion.</summary>
        public string S_tslResultadoOperacion
        {
            set
            {
                string LimitarLargo = value;

                if (LimitarLargo.Length > 50) { LimitarLargo = LimitarLargo.Substring(0, 50); }

                if (!SeEstaMostrandoAdvertencia) { tslResultadoOperacion.Text = LimitarLargo; }
            }
        }

        /// <summary>Actualiza la variable que contiene el limite de tiempo transcurrido antes cerrar un formulario.</summary>
        public int S_TiempoLimiteTranscurrido { set { TiempoLimiteTranscurrido = value; } }
        #endregion
    }
}