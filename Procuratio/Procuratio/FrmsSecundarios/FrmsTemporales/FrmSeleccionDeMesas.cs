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
    public partial class FrmSeleccionDeMesas : Form
    {
        #region Codigo de carga
        public FrmSeleccionDeMesas()
        {
            InitializeComponent();
        }

        private void FrmSeleccionDeMesas_Load(object sender, EventArgs e) => tmrColor.Enabled = true;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //TODO - Codigo de carga de mesas
            Close();
        }

        private void picBTNCerrar_Click(object sender, EventArgs e) => Close();

        private void PicBTNInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Las mesas que se muestran disponibles, estan basadas en" +
                " la FECHA y HORA seleccionada. No se mostraran mesas que esten reservadas" +
                " 2 horas antes o despues, ya que se consideran como ocupadas", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmSeleccionDeMesas_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrColor.Enabled = false;
            Acumulador = 0;
            picBTNInformacion.BackColor = Color.FromArgb(224, 94, 1);
        }
    }
}
