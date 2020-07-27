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

namespace Procuratio.Reportes
{
    public partial class FrmReportes : Form
    {
        #region Carga
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            MostrarInforme();
        }

        public void MostrarInforme()
        {
            switch (TipoDeReporte)
            {
                case ETipoDeReporte.Pedidos:
                    {
                        crvVisorReportes.ReportSource = Reporte;
                        break;
                    }
                case ETipoDeReporte.RegistrosCaja:
                    {
                        crvVisorReportes.ReportSource = ReporteMovimientos;
                        break;
                    }
                case ETipoDeReporte.Reservas:
                    {
                        crvVisorReportes.ReportSource = ReporteReserva;
                        break;
                    }
            }
        }
        #endregion

        #region Variables
        public enum ETipoDeReporte
        {
            Pedidos, Reservas, RegistrosCaja
        }

        private ETipoDeReporte TipoDeReporte;
        private RptReporteResumenPedido Reporte;
        private RptReporteReservas ReporteReserva;
        private RptReporteMovimientos ReporteMovimientos;
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

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        public ETipoDeReporte S_TipoDeReporte { set { TipoDeReporte = value; } }
        public RptReporteResumenPedido S_Reporte { set { Reporte = value; } }
        public RptReporteReservas S_ReporteReserva { set { ReporteReserva = value; } }
        public RptReporteMovimientos S_ReporteMovimientos { set { ReporteMovimientos = value; } }
        #endregion
    }
}
