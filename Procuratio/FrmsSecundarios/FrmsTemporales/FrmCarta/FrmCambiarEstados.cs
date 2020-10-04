using Datos;
using Negocio;
using Procuratio.ClsDeApoyo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Procuratio
{
    public partial class FrmCambiarEstados : Form
    {
        #region Carga
        public FrmCambiarEstados()
        {
            InitializeComponent();
        }

        private void FrmCambiarEstados_Load(object sender, EventArgs e)
        {
            CargarDGVCategorias(ClsCategoriasArticulos.ETipoListado.CategoriasActivas);
            CargarCMBCategorias();
        }

        private void FrmCambiarEstados_Shown(object sender, EventArgs e)
        {
            FormularioCargado = true;
            CargarDGVArticulos(ClsArticulos.ETipoListado.ArticulosActivosInactivos);
        }
        #endregion

        #region Variables
        private enum ENumColDGVEstadoArticulo
        {
            ID_Articulo, Nombre, Descripcion, Categoria, PrecioCarta, PrecioDelivery, Seleccionar
        }

        private enum ENumColDGVCategorias
        {
            ID_Categoria, Categoria, SeEnvianCocina, Seleccionar
        }

        private readonly string TEXTO_VISUAL_BUSCAR = "Buscar por nombre de articulo...", TEXTO_VISUAL_COMBOBOX = "Todas las categorias";
        private bool FormularioCargado = false;
        private int UltimaFilaSeleccionada = -1;
        private List<int> ArticulosDeCartaMarcados = new List<int>();
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

            if (BotonEnFoco.Name == btnEliminarElementos.Name)
            {
                BotonEnFoco.BackColor = ClsColores.Rojo;
            }
            else
            {
                BotonEnFoco.BackColor = ClsColores.NaranjaClaro;
            }
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

        private void TxtBuscarPorNombre_Enter(object sender, EventArgs e)
        {
            FormularioCargado = false;
            if (txtBuscarPorNombre.Text == TEXTO_VISUAL_BUSCAR) { txtBuscarPorNombre.Text = string.Empty; }
            txtBuscarPorNombre.ForeColor = ClsColores.GrisClaro;
            FormularioCargado = true;
        }

        private void TxtBuscarPorNombre_Leave(object sender, EventArgs e)
        {
            FormularioCargado = false;
            if (txtBuscarPorNombre.Text == string.Empty) { txtBuscarPorNombre.Text = TEXTO_VISUAL_BUSCAR; }
            txtBuscarPorNombre.ForeColor = ClsColores.GrisOscuro;
            FormularioCargado = true;
        }
        #endregion

        #region Filtros
        private void TxtBuscarPorNombre_TextChanged(object sender, EventArgs e) => AplicarFiltros();

        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e) => AplicarFiltros();

        /// <summary>Aplica los filtros por nombre y categoria.</summary>
        private void AplicarFiltros()
        {
            ClsArticulos.ETipoListado EstadoArticulosFiltrar = ClsArticulos.ETipoListado.ArticulosActivosInactivos;

            if (rbnElementosActivos.Checked)
            {
                EstadoArticulosFiltrar = ClsArticulos.ETipoListado.ArticulosActivosInactivos;
            }
            else
            {
                EstadoArticulosFiltrar = ClsArticulos.ETipoListado.ArticulosActivosInactivos;
            }

            CargarDGVArticulos(EstadoArticulosFiltrar);
        }
        #endregion

        #region Actualizar el estado de artiulos y categorias
        private void BtnRestaurarElementos_Click(object sender, EventArgs e)
        {
            ActualizarEstadoArticulo(ClsEstadosArticulos.EEstadosArticulos.Activo);
            ActualizarEstadoCategoria(ClsEstadosCategoriasArticulos.EEstadosCategoriasArticulos.Activo);
        }

        private void BtnEliminarElementos_Click(object sender, EventArgs e)
        {
            ActualizarEstadoArticulo(ClsEstadosArticulos.EEstadosArticulos.Inactivo);
            ActualizarEstadoCategoria(ClsEstadosCategoriasArticulos.EEstadosCategoriasArticulos.inactivo);
        }

        /// <summary>Actualiza el estado del articulo a activo/inactivo.</summary>
        /// <param name="_EstadoElemento">Enum que contrendra el numero del tipo de estado.</param>
        private void ActualizarEstadoArticulo(ClsEstadosArticulos.EEstadosArticulos _EstadoElemento)
        {
            ClsArticulos Articulo = new ClsArticulos();
            Articulo ActualizarArticulo = new Articulo();

            int TotalDeFilas = dgvEstadoArticulo.Rows.Count;

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                //Pregunto si la celda es diferente a null
                if (dgvEstadoArticulo.Rows[Indice].Cells[(int)ENumColDGVEstadoArticulo.Seleccionar].Value != null)
                {
                    //Casteo el check del objeto a booleano y pregunto si es true
                    if ((bool)dgvEstadoArticulo.Rows[Indice].Cells[(int)ENumColDGVEstadoArticulo.Seleccionar].Value)
                    {
                        string InformacionDelError = string.Empty;

                        ActualizarArticulo = Articulo.LeerPorNumero((int)dgvEstadoArticulo.Rows[Indice].Cells[(int)ENumColDGVEstadoArticulo.ID_Articulo].Value, ref InformacionDelError);

                        if (ActualizarArticulo != null)
                        {
                            ActualizarArticulo.ID_EstadoArticulo = (int)_EstadoElemento;

                            if (ActualizarArticulo.CategoriaArticulo.ID_EstadoCategoriaArticulo != (int)ClsEstadosCategoriasArticulos.EEstadosCategoriasArticulos.inactivo)
                            {
                                if (Articulo.Actualizar(ActualizarArticulo, ref InformacionDelError) != 0)
                                {
                                    dgvEstadoArticulo.Rows.Remove(dgvEstadoArticulo.Rows[Indice]);

                                    Indice -= 1;
                                    TotalDeFilas -= 1;

                                    UltimaFilaSeleccionada = -1;
                                }
                                else if (InformacionDelError != string.Empty)
                                {
                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                using (FrmInformacion FormInformacion = new FrmInformacion($"El articulo '{ActualizarArticulo.Nombre}' (categoria '{ActualizarArticulo.CategoriaArticulo.Nombre}') " +
                                        $"no se puede activar debido a que su categoria fue eliminada.", ClsColores.Blanco, 150, 350))
                                {
                                    FormInformacion.ShowDialog();
                                }
                            }
                        }
                        else if (InformacionDelError == string.Empty)
                        {
                            MessageBox.Show($"Error al intentar actualizar el articulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        /// <summary>Actualiza el estado de la categoria a activo/inactivo.</summary>
        /// <param name="_EstadoElemento">Enum que contrendra el numero del tipo de estado.</param>
        private void ActualizarEstadoCategoria(ClsEstadosCategoriasArticulos.EEstadosCategoriasArticulos _EstadoElemento)
        {
            bool ActualizoUnRegistro = false;

            ClsCategoriasArticulos Categoria = new ClsCategoriasArticulos();
            CategoriaArticulo ActualizarCategoria = new CategoriaArticulo();

            int TotalDeFilas = dgvEstadoCategoria.Rows.Count;

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                //Pregunto si la celda es diferente a null
                if (dgvEstadoCategoria.Rows[Indice].Cells[(int)ENumColDGVCategorias.Seleccionar].Value != null)
                {
                    //Casteo el check del objeto a booleano y pregunto si es true
                    if ((bool)dgvEstadoCategoria.Rows[Indice].Cells[(int)ENumColDGVCategorias.Seleccionar].Value)
                    {
                        string InformacionDelError = string.Empty;

                        ActualizarCategoria = Categoria.LeerPorNumero((int)dgvEstadoCategoria.Rows[Indice].Cells[(int)ENumColDGVCategorias.ID_Categoria].Value, ref InformacionDelError);
                        ActualizarCategoria.ID_EstadoCategoriaArticulo = (int)_EstadoElemento;

                        if (Categoria.Actualizar(ActualizarCategoria, ref InformacionDelError) != 0)
                        {
                            dgvEstadoCategoria.Rows.Remove(dgvEstadoCategoria.Rows[Indice]);
                            Indice -= 1;
                            TotalDeFilas -= 1;

                            ActualizoUnRegistro = true;

                            UltimaFilaSeleccionada = -1;
                        }
                        else if (InformacionDelError != string.Empty)
                        {
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }

            // Cargar los DGV y CMB solo si acutalizo un registro
            if (ActualizoUnRegistro)
            {
                if (_EstadoElemento == ClsEstadosCategoriasArticulos.EEstadosCategoriasArticulos.Activo)
                {
                    CargarDGVArticulos(ClsArticulos.ETipoListado.ArticulosActivosInactivos);
                }
                else
                {
                    CargarDGVArticulos(ClsArticulos.ETipoListado.ArticulosActivosInactivos);
                }

                FormularioCargado = false;
                CargarCMBCategorias();
                FormularioCargado = true;
            }
        }
        #endregion

        #region Mostrar los elementos del radiobutton seleccionado
        private void RbnElementosActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnElementosActivos.Checked)
            {
                CargarDGVArticulos(ClsArticulos.ETipoListado.ArticulosActivosInactivos);
                CargarDGVCategorias(ClsCategoriasArticulos.ETipoListado.CategoriasActivas);

                btnRestaurarElementos.Visible = false;
                btnEliminarElementos.Visible = true;
            }
        }

        private void RbnelementosInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnelementosInactivos.Checked)
            {
                CargarDGVArticulos(ClsArticulos.ETipoListado.ArticulosActivosInactivos);
                CargarDGVCategorias(ClsCategoriasArticulos.ETipoListado.CategoriasInactivas);

                btnRestaurarElementos.Visible = true;
                btnEliminarElementos.Visible = false;
            }
        }
        #endregion

        private void dgvEstadoArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                if (dgvEstadoArticulo.Rows[e.RowIndex].Cells[(int)ENumColDGVEstadoArticulo.Seleccionar].Value != null)
                {
                    if (!(bool)dgvEstadoArticulo.Rows[e.RowIndex].Cells[(int)ENumColDGVEstadoArticulo.Seleccionar].Value && e.RowIndex != UltimaFilaSeleccionada)
                    {
                        ClsColores.MarcarFilaDGV(dgvEstadoArticulo, e.RowIndex, true);
                    }
                    else
                    {
                        ClsColores.MarcarFilaDGV(dgvEstadoArticulo, e.RowIndex, false);
                    }
                }

                // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                if (dgvEstadoArticulo.Rows[e.RowIndex].Cells[(int)ENumColDGVEstadoArticulo.Seleccionar].Value != null)
                {
                    if (!(bool)dgvEstadoArticulo.Rows[e.RowIndex].Cells[(int)ENumColDGVEstadoArticulo.Seleccionar].Value && e.RowIndex != UltimaFilaSeleccionada)
                    {
                        ArticulosDeCartaMarcados.Add((int)dgvEstadoArticulo.Rows[e.RowIndex].Cells[(int)ENumColDGVEstadoArticulo.ID_Articulo].Value);
                    }
                    else
                    {
                        ArticulosDeCartaMarcados.RemoveAll(I => I == (int)dgvEstadoArticulo.Rows[e.RowIndex].Cells[(int)ENumColDGVEstadoArticulo.ID_Articulo].Value);
                    }
                }

                UltimaFilaSeleccionada = e.RowIndex;
            }
        }

        private void dgvEstadoCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                if (dgvEstadoCategoria.Rows[e.RowIndex].Cells[(int)ENumColDGVCategorias.Seleccionar].Value != null)
                {
                    if (!(bool)dgvEstadoCategoria.Rows[e.RowIndex].Cells[(int)ENumColDGVCategorias.Seleccionar].Value && e.RowIndex != UltimaFilaSeleccionada)
                    {
                        ClsColores.MarcarFilaDGV(dgvEstadoCategoria, e.RowIndex, true);
                    }
                    else
                    {
                        ClsColores.MarcarFilaDGV(dgvEstadoCategoria, e.RowIndex, false);
                    }
                }

                UltimaFilaSeleccionada = e.RowIndex;
            }
        }

        #region Actualizar grillas
        /// <summary>Carga los articulos activos/inactivos.</summary>
        private void CargarDGVArticulos(ClsArticulos.ETipoListado _TipoDeEstado)
        {
            if (FormularioCargado)
            {
                dgvEstadoArticulo.Rows.Clear();

                string NombreArticulo = string.Empty;

                int ID_CategoriaFiltro = 0;

                if (cmbCategoria.SelectedValue != null)
                {
                    CategoriaArticulo CategoriaSeleccionada = (CategoriaArticulo)cmbCategoria.SelectedItem;
                    ID_CategoriaFiltro = CategoriaSeleccionada.ID_CategoriaArticulo;
                }

                if (txtBuscarPorNombre.Text != TEXTO_VISUAL_COMBOBOX) { NombreArticulo = txtBuscarPorNombre.Text; }

                string InformacionDelError = string.Empty;

                ClsArticulos Articulos = new ClsArticulos();

                List<Articulo> ListarArticulosActivos = Articulos.LeerListado(ClsArticulos.ETipoListado.Filtro, ref InformacionDelError, _TipoDeEstado, NombreArticulo, ID_CategoriaFiltro);

                if (ListarArticulosActivos != null)
                {
                    foreach (Articulo Elemento in ListarArticulosActivos)
                    {
                        int NumeroDeFila = dgvEstadoArticulo.Rows.Add();

                        dgvEstadoArticulo.Rows[NumeroDeFila].Cells[(int)ENumColDGVEstadoArticulo.ID_Articulo].Value = Elemento.ID_Articulo;
                        dgvEstadoArticulo.Rows[NumeroDeFila].Cells[(int)ENumColDGVEstadoArticulo.Nombre].Value = Elemento.Nombre;
                        dgvEstadoArticulo.Rows[NumeroDeFila].Cells[(int)ENumColDGVEstadoArticulo.Descripcion].Value = Elemento.Descripcion;
                        dgvEstadoArticulo.Rows[NumeroDeFila].Cells[(int)ENumColDGVEstadoArticulo.Categoria].Value = Elemento.CategoriaArticulo.Nombre;

                        if (Elemento.Precio == null)
                        {
                            dgvEstadoArticulo.Rows[NumeroDeFila].Cells[(int)ENumColDGVEstadoArticulo.PrecioCarta].Value = "NO TIENE";
                        }
                        else
                        {
                            dgvEstadoArticulo.Rows[NumeroDeFila].Cells[(int)ENumColDGVEstadoArticulo.PrecioCarta].Value = Elemento.Precio;
                        }

                        if (Elemento.PrecioDelivery == null)
                        {
                            dgvEstadoArticulo.Rows[NumeroDeFila].Cells[(int)ENumColDGVEstadoArticulo.PrecioDelivery].Value = "NO TIENE";
                        }
                        else
                        {
                            dgvEstadoArticulo.Rows[NumeroDeFila].Cells[(int)ENumColDGVEstadoArticulo.PrecioDelivery].Value = Elemento.PrecioDelivery;
                        }

                        if (ArticulosDeCartaMarcados.Count > 0)
                        {
                            foreach (int ElementoSecundario in ArticulosDeCartaMarcados)
                            {
                                if (ElementoSecundario == Elemento.ID_Articulo)
                                {
                                    dgvEstadoArticulo.Rows[NumeroDeFila].Cells[(int)ENumColDGVEstadoArticulo.Seleccionar].Value = true;
                                    ClsColores.MarcarFilaDGV(dgvEstadoArticulo, NumeroDeFila, true);
                                    break;
                                }
                                else
                                {
                                    dgvEstadoArticulo.Rows[NumeroDeFila].Cells[(int)ENumColDGVEstadoArticulo.Seleccionar].Value = false;
                                    ClsColores.MarcarFilaDGV(dgvEstadoArticulo, NumeroDeFila, false);
                                }
                            }
                        }
                        else
                        {
                            dgvEstadoArticulo.Rows[NumeroDeFila].Cells[(int)ENumColDGVEstadoArticulo.Seleccionar].Value = false;
                            ClsColores.MarcarFilaDGV(dgvEstadoArticulo, NumeroDeFila, false);
                        }
                    }

                    UltimaFilaSeleccionada = -1;

                    dgvEstadoArticulo.Sort(dgvEstadoArticulo.Columns[(int)ENumColDGVEstadoArticulo.Categoria], ListSortDirection.Ascending);

                    dgvEstadoCategoria.ClearSelection();
                }
                else if (InformacionDelError == string.Empty)
                {
                    MessageBox.Show("Fallo al cargar los articulos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>Carga las categorias activas.</summary>
        private void CargarDGVCategorias(ClsCategoriasArticulos.ETipoListado _TipoDeEstado)
        {
            dgvEstadoCategoria.Rows.Clear();

            string InformacionDelError = string.Empty;

            ClsCategoriasArticulos Categorias = new ClsCategoriasArticulos();

            List<CategoriaArticulo> ListarCategorias = Categorias.LeerListado(_TipoDeEstado, ref InformacionDelError);

            if (ListarCategorias != null)
            {
                foreach (CategoriaArticulo Elemento in ListarCategorias)
                {
                    int NumeroDeFila = dgvEstadoCategoria.Rows.Add();

                    dgvEstadoCategoria.Rows[NumeroDeFila].Cells[(int)ENumColDGVCategorias.ID_Categoria].Value = Elemento.ID_CategoriaArticulo;
                    dgvEstadoCategoria.Rows[NumeroDeFila].Cells[(int)ENumColDGVCategorias.Categoria].Value = Elemento.Nombre;

                    if (Elemento.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.Si)
                    {
                        dgvEstadoCategoria.Rows[NumeroDeFila].Cells[(int)ENumColDGVCategorias.SeEnvianCocina].Value = "SI";
                    }
                    else
                    {
                        dgvEstadoCategoria.Rows[NumeroDeFila].Cells[(int)ENumColDGVCategorias.SeEnvianCocina].Value = "NO";
                    }

                    ClsColores.MarcarFilaDGV(dgvEstadoCategoria, NumeroDeFila, false);

                    dgvEstadoCategoria.Rows[NumeroDeFila].Cells[(int)ENumColDGVCategorias.Seleccionar].Value = false;
                }

                FormularioCargado = false;
                CargarCMBCategorias();
                FormularioCargado = true;
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
        #endregion

        /// <summary>Carga el ComboBox con datos.</summary>
        private void CargarCMBCategorias()
        {
            string InformacionDelError = string.Empty;

            ClsCategoriasArticulos Categorias = new ClsCategoriasArticulos();
            List<CategoriaArticulo> ListarCategorias = Categorias.LeerListado(ClsCategoriasArticulos.ETipoListado.CategoriasActivas, ref InformacionDelError);

            if (ListarCategorias != null)
            {
                // Creo el item para listar todo
                ListarCategorias.Add(new CategoriaArticulo { ID_CategoriaArticulo = 0, Nombre = TEXTO_VISUAL_COMBOBOX });

                // Nombre de la columna que contiene el nombre
                cmbCategoria.DisplayMember = "Nombre";
                // Nombre de la columna que contiene el ID
                cmbCategoria.ValueMember = "ID_CategoriaArticulo";

                // Llenar el combo
                cmbCategoria.DataSource = ListarCategorias.ToList();

                cmbCategoria.SelectedValue = 0;
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al cargar los perfiles", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades

        #endregion
    }
}
