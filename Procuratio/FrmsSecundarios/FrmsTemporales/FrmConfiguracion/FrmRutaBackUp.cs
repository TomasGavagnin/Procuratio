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
using Procuratio.ClsDeApoyo;

namespace Procuratio.FrmsSecundarios.FrmsTemporales.FrmConfiguracion
{
    public partial class FrmRutaBackUp : Form
    {
        #region Carga
        public FrmRutaBackUp()
        {
            InitializeComponent();
        }

        private void FrmRutaBackUp_Load(object sender, EventArgs e)
        {
            txtRuta.Text = Ruta;
        }
        #endregion

        #region Variables
        private string Ruta = string.Empty;
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

        private void BtnAceptar_Click(object sender, EventArgs e) => Close();

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        public string S_Ruta { set { Ruta = value; } }
        #endregion

        private void PicBTNInformacion_Click(object sender, EventArgs e)
        {
            using (FrmInformacion FormInformacion = new FrmInformacion($"En este cuadro de texto se muestra la ruta que indico para " +
                    $"crear la copia de seguridad de la base de datos. Seleccione todo el texto, luego click " +
                    $"derecho y seleccione la opcion 'Copiar'. Despues de eso, puede cerrar esta ventana con el " +
                    $"boton [Aceptar] o con la cruz de la ventana.\r\n\r\nUna vez tenga la ruta copiada, dirijase " +
                    $"al 'Escritorio' de su computadora (donde le aparecerá a la izquierda un listado de archivos). En " +
                    $"el buscador de archivos de este (parte superior), pegue la direccion que copio previamente (ruta " +
                    $"donde guardo la base de datos), para que este buscador lo lleve a donde creo la misma. Una vez allí, " +
                    $"Encontrara un archivo (con extencion .bak), que lo identificara facilmente por el nombre y la fecha " +
                    $"de creacion, como por ejemplo: 'Copia de seguridad del 12_11_2019 a las 12_00_00'. Ese archivo, es el " +
                    $"que debera arrastrar y pegarlo un una unidad de memoria externa segura (como un pendrive), con el fin " +
                    $"de evitar que alguien se lleve la copia de seguridad de su restaurante con todos sus datos en esta (Ya " +
                    $"que podria sacar la copia que dejo en la computadora)" +
                    $".\r\n\r\n" +
                    $"Se recomienda que se realize esta copia una vez al dia, al finalizar la jornada laboral, ademas de no eliminar " +
                    $"las copias de seguridad de dias anteriores. Si surge algun problema con la base de datos, se podra " +
                    $"restaurar a partir de la ultima copia de seguridad creada (si la crea uan vez al dia, se perderan " +
                    $"los datos de ese mismo dia, y no los de toda la semana, si la realizara semanalmente por ejemplo).", ClsColores.Blanco, 500, 700))
            {
                FormInformacion.ShowDialog();
            }
        }
    }
}
