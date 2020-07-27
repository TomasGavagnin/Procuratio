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
using Datos;
using Negocio;
using Procuratio.ClsDeApoyo;

namespace Procuratio.FrmsSecundarios.FrmsTemporales.FrmMesas
{
    public partial class FrmVerCocina : Form
    {
        #region Carga
        /// <summary>
        /// Muestran lo que tiene cocina en su pedido.
        /// </summary>
        /// <param name="_ID_Pedido">Pedido a mostrar.</param>
        public FrmVerCocina(int _ID_Pedido)
        {
            InitializeComponent();

            ID_Pedido = _ID_Pedido;
        }

        private void FrmVerCocina_Load(object sender, EventArgs e)
        {
            CargarDGVVerCocina();
        }

        private void CargarDGVVerCocina()
        {
            dgvVerCocina.Rows.Clear();

            string InformacionDelError = string.Empty;

            ClsDetalles Detalles = new ClsDetalles();
            List<Detalle> PlatosSinCocinar = Detalles.LeerListado(ID_Pedido, ClsDetalles.ETipoDeListado.ParaCocina, ref InformacionDelError);

            if (PlatosSinCocinar != null)
            {
                dgvVerCocina.Rows.Clear();

                string Nota = string.Empty;

                foreach (Detalle Elemento in PlatosSinCocinar)
                {
                    int NumeroDeFila = dgvVerCocina.Rows.Add();

                    dgvVerCocina.Rows[NumeroDeFila].Cells[0].Value = Elemento.Pedido.ID_Pedido;
                    dgvVerCocina.Rows[NumeroDeFila].Cells[1].Value = Elemento.Articulo.Nombre;
                    dgvVerCocina.Rows[NumeroDeFila].Cells[2].Value = Elemento.Articulo.Descripcion;

                    if (Elemento.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.NoCocinado)
                    {
                        dgvVerCocina.Rows[NumeroDeFila].Cells[3].Value = Elemento.Cantidad;
                    }
                    else
                    {
                        dgvVerCocina.Rows[NumeroDeFila].Cells[3].Value = Elemento.CantidadAgregada;
                    }

                    Nota = Elemento.Pedido.Nota;
                }

                lblDetallesDelPedido.Text = Nota;
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Fallo al cargar el pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Variables
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

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        #endregion
    }
}
