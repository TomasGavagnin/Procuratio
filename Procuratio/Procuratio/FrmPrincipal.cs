using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices; //libreria para manipular el form

namespace Procuratio
{
    public partial class FrmPrincipal : Form
    {
        #region Codigo de carga
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            tslFecha.Text = DateTime.Now.ToLongDateString();
            tslHora.Text = DateTime.Now.ToShortTimeString();
        }
        #endregion

        #region Variables
        private Form UltimoFormAbierto;
        private FrmReservas FrmReservas = new FrmReservas();
        private FrmMesas FrmMesas = new FrmMesas();
        private FrmCaja FrmCaja = new FrmCaja();
        private FrmConfiguracion FrmConfiguracion = new FrmConfiguracion();
        private Button BotonPresionado;
        private int Horas = 0, Minutos = 0, Segundos = 0;
        private bool MenuVerticalContraido = true; 
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
                PictureBoxEnFoco.BackColor = Color.Gray;
            }
            else if (PictureBoxEnFoco.Name == picBTNCerrar.Name)
            {
                PictureBoxEnFoco.BackColor = Color.FromArgb(232, 17, 35);
            }
            else
            {
                PictureBoxEnFoco.BackColor = Color.FromArgb(255, 127, 0);
            }
        }

        private void ColorFondoBotones_MouseLeave(object sender, EventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;
            PictureBoxEnFoco.BackColor = Color.Transparent;
        }

        //Propiedad para los botones
        private void ColorBotonesMenuVertical_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            BotonEnFoco.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);

            if (BotonEnFoco.Name == btnCerrarSesion.Name)
            {
                BotonEnFoco.BackColor = Color.FromArgb(224, 94, 1);
            }
            else if (BotonEnFoco.Name == btnConfiguracion.Name)
            {
                BotonEnFoco.BackColor = Color.FromArgb(172, 160, 206);
            }
            else
            {
                BotonEnFoco.BackColor = Color.FromArgb(124, 179, 104);
            }
        }

        private void ColorBotonesMenuVertical_MouseLeave(object sender, EventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            //Si el boton que esta en foco es diferente al que tiene asociado el evento del formulario que se encuentra en 
            //pantalla, cambiar la propiedad, sino, no entrar al IF
            if (BotonEnFoco != BotonPresionado) { BotonEnEstadoOriginal(BotonEnFoco); }
        }

        private void BotonEnEstadoOriginal(Button _CambiarEstilo)
        {
            _CambiarEstilo.ForeColor = Color.White;
            _CambiarEstilo.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            _CambiarEstilo.BackColor = Color.Transparent;
        }
        #endregion

        #region Codigo para darle las funciones BASICAS a los botones de estado del formulario (minimizar, salir, etc)
        private void picBTNCerrar_Click(object sender, EventArgs e)
        {
            pnlContFrmPrincipal.Select(); //Selecciono este control para evitar bug visual (aparecen controles seleccionados)

            DialogResult Respuesta = MessageBox.Show("¿Está seguro que desea salir? Todo campo no guardado " +
                "se perderá\r\n\r\nUse el botón inferior izquierdo (cerrar sesión actual), si lo que quiere es cambiar " +
                "de usuario", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
            if (Respuesta == DialogResult.OK) { Application.Exit(); }
        }

        //Funcion delegada a un metodo debido a que es utilizado por otra parte del codigo (cuando el usuario arrastra el Frm)
        private void picBTNExpandirReducir_Click(object sender, EventArgs e) => ExpandirReducir();

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
        private void picBTNDespliegaMenuVertical_Click(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == 300)
            {
                OcultaMuestraTextoMenuContraido(true);

                pnlMenuVertical.Width = 85;
                picBTNDespliegaMenuVertical.Dock = DockStyle.Fill;
            }
            else
            {
                OcultaMuestraTextoMenuContraido(false);

                pnlMenuVertical.Width = 300;
                picBTNDespliegaMenuVertical.Dock = DockStyle.Right;
            }
        }

        //Este metodo ocultara Todo el texto cuando se comprima el menu vertical para dejar solo los iconos visibles
        private void OcultaMuestraTextoMenuContraido(bool _Contraido)
        {
            MenuVerticalContraido = _Contraido;

            if (_Contraido)
            {
                btnReservas.Text = string.Empty;
                btnMesas.Text = string.Empty;
                btnCaja.Text = string.Empty;
                btnConfiguracion.Text = string.Empty;
                btnCerrarSesion.Text = string.Empty;
                lblTituloNombreCompleto.Visible = false;
                lblTituloUsuario.Visible = false;
                lblNombre.Visible = false;
                lblUsuario.Visible = false;
            }
            else
            {
                btnReservas.Text = "Reservas";
                btnMesas.Text = "Mesas";
                btnCaja.Text = "Caja";
                btnConfiguracion.Text = "Configuracion";
                btnCerrarSesion.Text = "Cerrar sesión actual";
                lblTituloNombreCompleto.Visible = true;
                lblTituloUsuario.Visible = true;
                lblNombre.Visible = true;
                lblUsuario.Visible = true;
            }
        }
        #endregion

        #region Gestor de formularios
        //Abrir u ocultar forms
        private void btnReservas_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmReservas, sender);
        private void btnMesas_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmMesas, sender);
        private void btnCaja_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmCaja, sender);
        private void btnConfiguracion_Click(object sender, EventArgs e) => PreparaFormParaMostrar(FrmConfiguracion, sender);

        private void PreparaFormParaMostrar(Form _FormMostrar, object sender)
        {
            if (UltimoFormAbierto == null) { UltimoFormAbierto = _FormMostrar; } //Evitar que en el siguiente if de nullException

            //If para evitar ejecutar repetidamente la carga de un formulario, si el que quiere abrir, ya esta en pantalla
            if (_FormMostrar != UltimoFormAbierto)
            {
                UltimoFormAbierto.Hide(); //Ocultar form viejo
                if (BotonPresionado != null) { BotonEnEstadoOriginal(BotonPresionado); } //Deseleccionar boton viejo

                BotonPresionado = (Button)sender; //Esto evitara que los eventos move y leave le cambien el estilo al boton en el codigo de estilo

                _FormMostrar.TopLevel = false;
                _FormMostrar.Dock = DockStyle.Fill;
                _FormMostrar.FormBorderStyle = FormBorderStyle.None;
                pnlContDeFrmsSecundarios.Controls.Add(_FormMostrar);
                pnlContDeFrmsSecundarios.Tag = _FormMostrar;

                _FormMostrar.Show();

                UltimoFormAbierto = _FormMostrar;
            }
        }
        #endregion

        private void tmrActualizarDatos_Tick(object sender, EventArgs e)
        {
            #region Reloj tiempo de conexion
            Segundos++;

            if (Segundos >= 10)
            {
                if (Minutos < 10)
                {
                    if (Horas < 10)
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = 0{Convert.ToString(Horas)}:0{Convert.ToString(Minutos)}:{Convert.ToString(Segundos)}";
                    }
                    else
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = {Convert.ToString(Horas)}:0{Convert.ToString(Minutos)}:{Convert.ToString(Segundos)}";
                    }
                }
                else
                {
                    if (Horas < 10)
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = 0{Convert.ToString(Horas)}:{Convert.ToString(Minutos)}:{Convert.ToString(Segundos)}";
                    }
                    else
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = {Convert.ToString(Horas)}:{Convert.ToString(Minutos)}:{Convert.ToString(Segundos)}";
                    }
                }

                if (Segundos == 59)
                {
                    Minutos++;

                    if (Minutos == 60)
                    {
                        Minutos = 0;
                        Horas++;
                    }

                    Segundos = -1;
                }
            }
            else
            {
                if (Minutos < 10)
                {
                    if (Horas < 10)
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = 0{Convert.ToString(Horas)}:0{Convert.ToString(Minutos)}:0{Convert.ToString(Segundos)}";
                    }
                    else
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = {Convert.ToString(Horas)}:0{Convert.ToString(Minutos)}:0{Convert.ToString(Segundos)}";
                    }
                }
                else
                {
                    if (Horas < 10)
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = 0{Convert.ToString(Horas)}:{Convert.ToString(Minutos)}:0{Convert.ToString(Segundos)}";
                    }
                    else
                    {
                        tslTiempoConexion.Text = $"Tiempo de conexion = {Convert.ToString(Horas)}:{Convert.ToString(Minutos)}:0{Convert.ToString(Segundos)}";
                    }
                }
            }
            #endregion
            
            tslFecha.Text = DateTime.Now.ToLongDateString();
            tslHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta = MessageBox.Show("¿Esta seguro que desea cerrar sesión? Todo campo no guardado se perderá", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (Respuesta == DialogResult.OK) { Close(); }
        }

        #region Propiedades
        public FormWindowState G_EstadoFormPrincipal { get { return WindowState; } }
        public bool G_MenuVerticalContraido { get { return MenuVerticalContraido; } }
        #endregion
    }
}