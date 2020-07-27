using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Procuratio.ClsDeApoyo;

namespace Procuratio.FrmsSecundarios.FrmsTemporales.FrmCarta
{
    public partial class MostrarPedidoFianlizado : Form
    {
        #region Carga
        public MostrarPedidoFianlizado(int _ID_Pedido)
        {
            InitializeComponent();

            ID_Pedido = _ID_Pedido;
        }

        private void MostrarPedidoFianlizado_Load(object sender, EventArgs e)
        {
            CargarDGVdgvArticulosPedido();
        }
        #endregion

        #region Variables
        private enum ENumColDGVArticulosPedido
        {
            ID_Articulo, Articulo, Cantidad
        }

        private int ID_Pedido = -1;
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

        private void CargarDGVdgvArticulosPedido()
        {
            string InformacionDelError = string.Empty;

            ClsDetalles Detalle = new ClsDetalles();
            List<Detalle> ListarArticulos = Detalle.LeerListado(ID_Pedido, ClsDetalles.ETipoDeListado.PorIDPedido, ref InformacionDelError);

            if (ListarArticulos != null)
            {
                double? TotalPedido = 0;

                foreach (Detalle Elemento in ListarArticulos)
                {
                    int NumeroDeFila = dgvArticulosPedido.Rows.Add();

                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosPedido.ID_Articulo].Value = Elemento.Articulo.ID_Articulo;
                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosPedido.Articulo].Value = Elemento.Articulo.Nombre;
                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVArticulosPedido.Cantidad].Value = Elemento.Cantidad;

                    TotalPedido = Elemento.Pedido.TotalPedido;
                }
                lblResultadoTotal.Text = Convert.ToString(TotalPedido);
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Fallo al listar los articulos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        #endregion
    }
}
