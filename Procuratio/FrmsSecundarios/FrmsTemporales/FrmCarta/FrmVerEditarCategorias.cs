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

namespace Procuratio.FrmsSecundarios.FrmsTemporales.FrmCarta
{
    public partial class FrmVerEditarCategorias : Form
    {
        #region Carga
        public FrmVerEditarCategorias()
        {
            InitializeComponent();
        }

        private void FrmVerEditarCategorias_Load(object sender, EventArgs e)
        {
            CargarDGVCategorias();
        }
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

        #region Variables
        private enum ENumColDGVCategorias
        {
            ID_Categoria, Categoria, SeEnvianCocina
        }
        #endregion

        private void DgvEstadoCategoria_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                using (FrmCrearCategoria FormModificaCategoria = new FrmCrearCategoria((int)dgvCategorias.Rows[e.RowIndex].Cells[(int)ENumColDGVCategorias.ID_Categoria].Value))
                {
                    FormModificaCategoria.ShowDialog();

                    if (FormModificaCategoria.DialogResult == DialogResult.OK)
                    {
                        string InformacionDelError = string.Empty;

                        ClsCategoriasArticulos CategoriasArticulos = new ClsCategoriasArticulos();
                        CategoriaArticulo ActualizarCategoria = CategoriasArticulos.LeerPorNumero((int)dgvCategorias.Rows[e.RowIndex].Cells[(int)ENumColDGVCategorias.Categoria].Value, ref InformacionDelError);

                        if (ActualizarCategoria != null)
                        {
                            dgvCategorias.Rows[e.RowIndex].Cells[(int)ENumColDGVCategorias.Categoria].Value = ActualizarCategoria.Nombre;

                            if (ActualizarCategoria.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.Si)
                            {
                                dgvCategorias.Rows[e.RowIndex].Cells[(int)ENumColDGVCategorias.SeEnvianCocina].Value = "SI";
                            }
                            else
                            {
                                dgvCategorias.Rows[e.RowIndex].Cells[(int)ENumColDGVCategorias.SeEnvianCocina].Value = "NO";
                            }

                            dgvCategorias.Sort(dgvCategorias.Columns[(int)ENumColDGVCategorias.Categoria], ListSortDirection.Ascending);
                        }
                        else if (InformacionDelError != string.Empty)
                        {
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void CargarDGVCategorias()
        {
            dgvCategorias.Rows.Clear();

            string InformacionDelError = string.Empty;

            ClsCategoriasArticulos Categorias = new ClsCategoriasArticulos();

            List<CategoriaArticulo> ListarCategorias = Categorias.LeerListado(ClsCategoriasArticulos.ETipoListado.CategoriasActivas, ref InformacionDelError);

            if (ListarCategorias != null)
            {
                foreach (CategoriaArticulo Elemento in ListarCategorias)
                {
                    int NumeroDeFila = dgvCategorias.Rows.Add();

                    dgvCategorias.Rows[NumeroDeFila].Cells[(int)ENumColDGVCategorias.ID_Categoria].Value = Elemento.ID_CategoriaArticulo;
                    dgvCategorias.Rows[NumeroDeFila].Cells[(int)ENumColDGVCategorias.Categoria].Value = Elemento.Nombre;

                    if (Elemento.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.Si)
                    {
                        dgvCategorias.Rows[NumeroDeFila].Cells[(int)ENumColDGVCategorias.SeEnvianCocina].Value = "SI";
                    }
                    else
                    {
                        dgvCategorias.Rows[NumeroDeFila].Cells[(int)ENumColDGVCategorias.SeEnvianCocina].Value = "NO";
                    }
                }
                dgvCategorias.Sort(dgvCategorias.Columns[(int)ENumColDGVCategorias.Categoria], ListSortDirection.Ascending);
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al cargar las categorias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCrearCategoria_Click(object sender, EventArgs e)
        {
            using (FrmCrearCategoria FormCrearCategoria = new FrmCrearCategoria())
            {
                FormCrearCategoria.ShowDialog();
            }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades

        #endregion
    }
}
