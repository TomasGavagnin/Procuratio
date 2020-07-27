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

namespace Procuratio.FrmsSecundarios.FrmsTemporales.FrmConfiguracion
{
    public partial class FrmInformacionRestaurante : Form
    {
        #region Carga
        public FrmInformacionRestaurante()
        {
            InitializeComponent();
        }

        private void FrmInformacionRestaurante_Load(object sender, EventArgs e)
        {
            string InformacionDelError = string.Empty;

            ClsInformacionesRestaurantes InformacionesRestaurantes = new ClsInformacionesRestaurantes();
            InformacionRestaurante CargarDatos = InformacionesRestaurantes.LeerPorNumero(1, ref InformacionDelError);

            if (CargarDatos != null)
            {
                txtNombre.Text = CargarDatos.Nombre;
                TxtDireccion.Text = CargarDatos.Direccion;

                if (CargarDatos.Eslogan != null) { TxtEslogan.Text = CargarDatos.Eslogan.Trim(); }

                TxtTelefonoUno.Text = Convert.ToString(CargarDatos.TelefonoUno);
                
                if (CargarDatos.TelefonoDos != null) { TxtTelefonoDos.Text = Convert.ToString(CargarDatos.TelefonoDos); }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Error al intentar actualizar el articulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }
        #endregion

        #region Variables
        private int Acumulador = 0;
        private bool Invertir = true;
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

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            bool DatosValidos = true;
            string RegistroDeErrores = string.Empty;
            int AnchoFormInformacion = 100;

            TxtDireccion.Text = TxtDireccion.Text.Trim();

            if (TxtDireccion.Text.Length < 8)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe ingresar un minimo de 8 caracteres en la direccion.\r\n\r\n";
                AnchoFormInformacion += 50;
            }
            
            if (TxtEslogan.Text != string.Empty && (TxtEslogan.Text.Length > 24 || TxtEslogan.Text.Length < 22))
            {
                DatosValidos = false;
                RegistroDeErrores += "La longitud del eslogan debe ser de 22 a 24 caracteres para que se imprima " +
                    "correctamente en el ticket. Puede completar con guiones u otros simbolos hasta llegar a ese " +
                    "rango de cantidad, o deje este campo vacio para no usar eslogan..\r\n\r\n";
                AnchoFormInformacion += 150;
            }

            if (TxtTelefonoUno.Text.Length < 7)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe ingresar un minimo de 7 caracteres en el telefono uno.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (TxtTelefonoDos.Text != string.Empty && TxtTelefonoDos.Text.Length < 7)
            {
                DatosValidos = false;
                RegistroDeErrores += "Debe ingresar un minimo de 7 caracteres en el telefono dos, o no " +
                    "ingresar nada si no lo quiere incluir.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (DatosValidos)
            {
                string InformacionDelError = string.Empty;

                ClsInformacionesRestaurantes InformacionRestaurante = new ClsInformacionesRestaurantes();
                InformacionRestaurante ActualizarInformacion = new InformacionRestaurante();

                ActualizarInformacion.ID_InformacionRestaurante = 1;
                ActualizarInformacion.Nombre = txtNombre.Text.ToUpper();
                ActualizarInformacion.Direccion = TxtDireccion.Text;

                if (TxtEslogan.Text == string.Empty)
                {
                    ActualizarInformacion.Eslogan = null;
                }
                else
                {
                    TxtEslogan.Text = TxtEslogan.Text.Substring(0, 1).ToUpper() + TxtEslogan.Text.Remove(0, 1).ToLower();

                    ActualizarInformacion.Eslogan = TxtEslogan.Text;
                }

                ActualizarInformacion.TelefonoUno = Convert.ToInt64(TxtTelefonoUno.Text);

                if (TxtTelefonoDos.Text == string.Empty)
                {
                    ActualizarInformacion.TelefonoDos = null;
                }
                else
                {
                    ActualizarInformacion.TelefonoDos = Convert.ToInt64(TxtTelefonoDos.Text);
                }

                InformacionRestaurante.Actualizar(ActualizarInformacion, ref InformacionDelError);

                if (InformacionDelError == string.Empty)
                {
                    Close();
                }
                else if (InformacionDelError != string.Empty)
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion(RegistroDeErrores, ClsColores.Blanco, AnchoFormInformacion, 400))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }

        private void TxtTelefonoUno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TxtTelefonoDos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void PicBTNInformacion_Click(object sender, EventArgs e)
        {
            using (FrmInformacion FormInformacion = new FrmInformacion($"Si realiza impresiones en tickets " +
                    $"o impresoras en donde se encuentren datos del restaurante, estos seran tomados de lo que especifique en estos " +
                    $"campos.\r\n\r\nPor razones de espacio y estetica, se pide que tanto el eslogan, como los numeros de telefono, " +
                    $"tengan una determinada longitud.", ClsColores.Blanco, 300, 400))
            {
                FormInformacion.ShowDialog();
            }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();
    }
}
