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

namespace Procuratio
{
    public partial class FrmCrearMesa : Form
    {
        #region Carga
        public FrmCrearMesa()
        {
            InitializeComponent();
        }

        private void FrmCrearMesa_Load(object sender, EventArgs e) => tmrColor.Enabled = true;
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

            if (BotonEnFoco.Name == btnAceptar.Name)
            {
                BotonEnFoco.BackColor = Color.FromArgb(224, 94, 1);
            }
        }

        private void btnEstiloBotones_Leave(object sender, EventArgs e)
        {
            Button BotonEnFoco = (Button)sender;
            BotonEnFoco.BackColor = Color.Transparent;
        }

        private void ColorFondoBotones_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;

            if (PictureBoxEnFoco.Name == picBTNCerrar.Name)
            {
                PictureBoxEnFoco.BackColor = Color.FromArgb(232, 17, 35);
            }
        }

        private void ColorFondoBotones_MouseLeave(object sender, EventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;
            PictureBoxEnFoco.BackColor = Color.Transparent;
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

        private void PicBTNInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Las mesas que se muestran disponibles, son las que no estan ocupadas en este momento.\r\n\r\n" +
                "Si desea eliminar una mesa, seleccione el numero y seleccione ELIMINAR MESA.\r\n\r\n" +
                "Solo puede juntar un maximo de 4 mesas (y todas estas deben pertenecer a la misma planta)","Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        private void FrmCrearMesa_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrColor.Enabled = false;
            Acumulador = 0;
            picBTNInformacion.BackColor = Color.FromArgb(224, 94, 1);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
