using Datos;
using Negocio;
using Procuratio.ClsDeApoyo;
using Procuratio.FrmsSecundarios.FrmsTemporales.FrmCarta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Procuratio
{
    public partial class FrmCarta : Form
    {
        #region Carga
        private FrmCarta()
        {
            InitializeComponent();
        }

        private void FrmCarta_Load(object sender, EventArgs e)
        {
            CargarCMBCategorias();
        }

        /// <summary>Carga el ComboBox con datos.</summary>
        private void CargarCMBCategorias()
        {
            string InformacionDelError = string.Empty;

            ClsCategoriasArticulos Categorias = new ClsCategoriasArticulos();
            List<CategoriaArticulo> ListarCategorias = Categorias.LeerListado(ClsCategoriasArticulos.ETipoListado.CategoriasActivas, ref InformacionDelError);

            if (ListarCategorias != null)
            {
                // Nombre de la columna que contiene el nombre
                cmbCategoria.DisplayMember = "Nombre";
                // Nombre de la columna que contiene el ID
                cmbCategoria.ValueMember = "ID_CategoriaArticulo";

                // Creo el item para listar todo
                ListarCategorias.Add(new CategoriaArticulo { ID_CategoriaArticulo = 0, Nombre = "Todas las categorias" });

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

        private void FrmCarta_Shown(object sender, EventArgs e)
        {
            FormularioCargado = true;
            CargarDGVCarta(ClsArticulos.ETipoListado.ArticulosActivosInactivos);
        }

        /// <summary>
        /// Bloquea las funcionalidades si se vencio la licencia
        /// </summary>
        public void BloquearPorVencimientoLicencia(bool _LicenciaExpirada)
        {
            btnSeleccionarTodo.Enabled = !_LicenciaExpirada;
            btnDesceleccionarTodo.Enabled = !_LicenciaExpirada;
            btnAplicarAumentoDescuento.Enabled = !_LicenciaExpirada;
            btnEliminarArtCat.Enabled = !_LicenciaExpirada;
            btnCrearArticulo.Enabled = !_LicenciaExpirada;
            BtnVerEditarCategorias.Enabled = !_LicenciaExpirada;
            dgvCarta.Enabled = !_LicenciaExpirada;
            grbAumentoDescuento.Enabled = !_LicenciaExpirada;
            nudPorcentaje.Enabled = !_LicenciaExpirada;
            txtCantidad.Enabled = !_LicenciaExpirada;
            GrbUsar.Enabled = !_LicenciaExpirada;
            chkAplicarACarta.Enabled = !_LicenciaExpirada;
            chkAplicarADelivery.Enabled = !_LicenciaExpirada;
            chkRedondearPrecio.Enabled = !_LicenciaExpirada;
        }
        #endregion

        #region Variables
        private static FrmCarta InstanciaForm;

        /// <summary>
        /// Enumera las columnas del DGV para poder ubicarlas y editar mas facilmente su posicion.
        /// </summary>
        private enum ENumColDGVCarta
        {
            ID_Articulo, Nombre, Descripcion, Categoria, PrecioCarta, PrecioDelivery, Seleccionar
        }

        private readonly string TEXTO_VISUAL_BUSCAR = "Buscar por nombre de articulo...";
        private bool FormularioCargado = false;
        private List<int> ArticulosDeCartaMarcados = new List<int>();
        private int UltimaFilaSeleccionada = -1;
        #endregion

        #region Estilo
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            if (BotonEnFoco.Name == btnDesceleccionarTodo.Name)
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

        #region Crear
        public void BtnCrearArticulo_Click(object sender, EventArgs e)
        {
            using (FrmArticulo FormCrearArticulo = new FrmArticulo())
            {
                FormCrearArticulo.ShowDialog();

                if (FormCrearArticulo.DialogResult == DialogResult.OK)
                {
                    CargarDGVCarta(ClsArticulos.ETipoListado.ArticulosActivosInactivos);
                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Articulo creado correctamente";
                }
            }
        }
        #endregion

        private void DgvCarta_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (e.RowIndex != -1 && !(DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn))
            {
                using (FrmArticulo FormModificaArticulo = new FrmArticulo((int)dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.ID_Articulo].Value))
                {
                    FormModificaArticulo.ShowDialog();

                    if (FormModificaArticulo.DialogResult == DialogResult.OK)
                    {
                        string InformacionDelError = string.Empty;

                        ClsArticulos Articulos = new ClsArticulos();
                        Articulo ActualizarArticulo = new Articulo();

                        ActualizarArticulo = Articulos.LeerPorNumero((int)dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.ID_Articulo].Value, ref InformacionDelError);

                        if (ActualizarArticulo != null)
                        {
                            dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.ID_Articulo].Value = ActualizarArticulo.ID_Articulo;
                            dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.Nombre].Value = ActualizarArticulo.Nombre;
                            dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.Descripcion].Value = ActualizarArticulo.Descripcion;
                            dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.Categoria].Value = ActualizarArticulo.CategoriaArticulo.Nombre;

                            if (ActualizarArticulo.Precio == null)
                            {
                                dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.PrecioCarta].Value = "NO TIENE";
                            }
                            else
                            {
                                dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.PrecioCarta].Value = ActualizarArticulo.Precio;
                            }

                            if (ActualizarArticulo.PrecioDelivery == null)
                            {
                                dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.PrecioDelivery].Value = "NO TIENE";
                            }
                            else
                            {
                                dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.PrecioDelivery].Value = ActualizarArticulo.PrecioDelivery;
                            }

                            dgvCarta.Sort(dgvCarta.Columns[(int)ENumColDGVCarta.Categoria], ListSortDirection.Ascending);

                            FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Articulo actualizado correctamente";
                        }
                        else if (InformacionDelError != string.Empty)
                        {
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        #region Filtros
        private void TxtBuscarPorNombre_TextChanged(object sender, EventArgs e) => CargarDGVCarta(ClsArticulos.ETipoListado.Filtro);
        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e) => CargarDGVCarta(ClsArticulos.ETipoListado.Filtro);
        #endregion

        private void BtnVerEditarCategorias_Click(object sender, EventArgs e)
        {
            using (FrmVerEditarCategorias FormVerEditarCategorias = new FrmVerEditarCategorias())
            {
                FormVerEditarCategorias.ShowDialog();
                CargarDGVCarta(ClsArticulos.ETipoListado.ArticulosActivosInactivos);

                FormularioCargado = false;
                CargarCMBCategorias();
                txtBuscarPorNombre.Text = TEXTO_VISUAL_BUSCAR;
                cmbCategoria.Text = "Todas las categorias";
                FormularioCargado = true;
            }
        }

        private void BtnEliminarArtCat_Click(object sender, EventArgs e)
        {
            using (FrmCambiarEstados FormElementosActivos = new FrmCambiarEstados())
            {
                FormElementosActivos.ShowDialog();

                //Actualizar la carta y DGV
                CargarDGVCarta(ClsArticulos.ETipoListado.ArticulosActivosInactivos);

                FormularioCargado = false;
                CargarCMBCategorias();
                FormularioCargado = true;
            }
        }

        private void DgvCarta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                int TotalDeFilas = dgvCarta.Rows.Count;

                // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                if (dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.Seleccionar].Value != null)
                {
                    if (!(bool)dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.Seleccionar].Value && e.RowIndex != UltimaFilaSeleccionada)
                    {
                        ClsColores.MarcarFilaDGV(dgvCarta, e.RowIndex, true);
                    }
                    else
                    {
                        ClsColores.MarcarFilaDGV(dgvCarta, e.RowIndex, false);
                    }
                }

                UltimaFilaSeleccionada = e.RowIndex;

                // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                if (dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.Seleccionar].Value != null)
                {
                    if (!(bool)dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.Seleccionar].Value)
                    {
                        ArticulosDeCartaMarcados.Add((int)dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.ID_Articulo].Value);
                    }
                    else
                    {
                        ArticulosDeCartaMarcados.RemoveAll(I => I == (int)dgvCarta.Rows[e.RowIndex].Cells[(int)ENumColDGVCarta.ID_Articulo].Value);
                    }
                }
            }
        }

        #region Controles para editar los precios
        private void BtnSeleccionarTodo_Click(object sender, EventArgs e) => CambiarCheckboxSeleccion(true);

        private void BtnDesceleccionarTodo_Click(object sender, EventArgs e) => CambiarCheckboxSeleccion(false);

        /// <summary>Marca o desmarca los checks en la columna seleccion.</summary>
        /// <param name="_EstadoDelCheck">Si se quiere marcar o desmarcar.</param>
        private void CambiarCheckboxSeleccion(bool _EstadoDelCheck)
        {
            for (int Indice = 0; Indice < dgvCarta.Rows.Count; Indice++)
            {
                dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.Seleccionar].Value = _EstadoDelCheck;

                if (dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.Seleccionar].Value != null)
                {
                    if ((bool)dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.Seleccionar].Value)
                    {
                        ArticulosDeCartaMarcados.Add((int)dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.ID_Articulo].Value);
                        ClsColores.MarcarFilaDGV(dgvCarta, Indice, true);
                    }
                    else
                    {
                        ArticulosDeCartaMarcados.RemoveAll(I => I == (int)dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.ID_Articulo].Value);
                        ClsColores.MarcarFilaDGV(dgvCarta, Indice, false);
                    }
                }
            }
        }

        private void RbnPorcentaje_Click(object sender, EventArgs e)
        {
            lblCantidad.Visible = false;
            txtCantidad.Visible = false;
            pnlDecorativo1.Visible = false;
            pnlDecorativo6.Visible = true;
            nudPorcentaje.Visible = true;
            lblPorcentaje.Visible = true;
        }

        private void RbnCantidad_Click(object sender, EventArgs e)
        {
            lblCantidad.Visible = true;
            txtCantidad.Visible = true;
            pnlDecorativo1.Visible = true;
            pnlDecorativo6.Visible = false;
            nudPorcentaje.Visible = false;
            lblPorcentaje.Visible = false;
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void BtnAplicarAumentoDescuento_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == string.Empty) { txtCantidad.Text = "0"; }

            CargarDGVCarta(ClsArticulos.ETipoListado.ArticulosActivosInactivos);

            ClsArticulos Articulos = new ClsArticulos();
            Articulo ActualizarPrecio = new Articulo();

            // Entrar solo si al menos el usuario marco un check para aplicarle aumento
            if (chkAplicarADelivery.Checked || chkAplicarACarta.Checked)
            {
                // TODO - Realizar un aumento/descuento a los articulos seleccionados en funcion del porcentaje y el RBN seleccioando
                for (int Indice = 0; Indice < dgvCarta.Rows.Count; Indice++)
                {
                    //Pregunto si la celda es diferente a null
                    if (dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.Seleccionar].Value != null)
                    {
                        //Casteo el check del objeto a booleano y pregunto si es true
                        if ((bool)dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.Seleccionar].Value)
                        {
                            string InformacionDelError = string.Empty;

                            ActualizarPrecio = Articulos.LeerPorNumero((int)dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.ID_Articulo].Value, ref InformacionDelError);

                            if (rbnAumento.Checked)
                            {
                                if (chkAplicarADelivery.Checked && !chkAplicarACarta.Checked)
                                {
                                    if (ActualizarPrecio.PrecioDelivery != null)
                                    {
                                        if (RbnPorcentaje.Checked)
                                        {
                                            ActualizarPrecio.PrecioDelivery += ActualizarPrecio.PrecioDelivery * (int)nudPorcentaje.Value / 100;
                                        }
                                        else
                                        {
                                            ActualizarPrecio.PrecioDelivery += Convert.ToInt32(txtCantidad.Text);
                                        }
                                    }
                                }
                                else if (!chkAplicarADelivery.Checked && chkAplicarACarta.Checked)
                                {
                                    if (ActualizarPrecio.Precio != null)
                                    {
                                        if (RbnPorcentaje.Checked)
                                        {
                                            ActualizarPrecio.Precio += ActualizarPrecio.Precio * (int)nudPorcentaje.Value / 100;
                                        }
                                        else
                                        {
                                            ActualizarPrecio.Precio += Convert.ToInt32(txtCantidad.Text);
                                        }
                                    }
                                }
                                else
                                {
                                    if (ActualizarPrecio.Precio != null)
                                    {
                                        if (RbnPorcentaje.Checked)
                                        {
                                            ActualizarPrecio.Precio += ActualizarPrecio.Precio * (int)nudPorcentaje.Value / 100;
                                        }
                                        else
                                        {
                                            ActualizarPrecio.Precio += Convert.ToInt32(txtCantidad.Text);
                                        }
                                    }

                                    if (ActualizarPrecio.PrecioDelivery != null)
                                    {
                                        if (RbnPorcentaje.Checked)
                                        {
                                            ActualizarPrecio.PrecioDelivery += ActualizarPrecio.PrecioDelivery * (int)nudPorcentaje.Value / 100;
                                        }
                                        else
                                        {
                                            ActualizarPrecio.PrecioDelivery += Convert.ToInt32(txtCantidad.Text);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (chkAplicarADelivery.Checked && !chkAplicarACarta.Checked)
                                {
                                    if (ActualizarPrecio.PrecioDelivery != null)
                                    {
                                        if (RbnPorcentaje.Checked)
                                        {
                                            ActualizarPrecio.PrecioDelivery -= ActualizarPrecio.PrecioDelivery * (int)nudPorcentaje.Value / 100;
                                        }
                                        else
                                        {
                                            ActualizarPrecio.PrecioDelivery -= Convert.ToInt32(txtCantidad.Text);
                                        }
                                    }
                                }
                                else if (!chkAplicarADelivery.Checked && chkAplicarACarta.Checked)
                                {
                                    if (ActualizarPrecio.Precio != null)
                                    {
                                        if (RbnPorcentaje.Checked)
                                        {
                                            ActualizarPrecio.Precio -= ActualizarPrecio.Precio * (int)nudPorcentaje.Value / 100;
                                        }
                                        else
                                        {
                                            ActualizarPrecio.Precio -= Convert.ToInt32(txtCantidad.Text);
                                        }
                                    }
                                }
                                else
                                {
                                    if (ActualizarPrecio.Precio != null)
                                    {
                                        if (RbnPorcentaje.Checked)
                                        {
                                            ActualizarPrecio.Precio -= ActualizarPrecio.Precio * (int)nudPorcentaje.Value / 100;
                                        }
                                        else
                                        {
                                            ActualizarPrecio.Precio -= Convert.ToInt32(txtCantidad.Text);
                                        }
                                    }

                                    if (ActualizarPrecio.PrecioDelivery != null)
                                    {
                                        if (RbnPorcentaje.Checked)
                                        {
                                            ActualizarPrecio.PrecioDelivery -= ActualizarPrecio.PrecioDelivery * (int)nudPorcentaje.Value / 100;
                                        }
                                        else
                                        {
                                            ActualizarPrecio.PrecioDelivery -= Convert.ToInt32(txtCantidad.Text);
                                        }
                                    }
                                }
                            }

                            if (chkAplicarADelivery.Checked && !chkAplicarACarta.Checked && chkRedondearPrecio.Checked)
                            {
                                if (ActualizarPrecio.PrecioDelivery != null)
                                {
                                    ActualizarPrecio.PrecioDelivery = Math.Floor((double)ActualizarPrecio.PrecioDelivery);

                                    if (ActualizarPrecio.PrecioDelivery % 5 != 0)
                                    {
                                        ActualizarPrecio.PrecioDelivery = ActualizarPrecio.PrecioDelivery + (5 - (ActualizarPrecio.PrecioDelivery % 5));
                                    }
                                }
                            }
                            else if (!chkAplicarADelivery.Checked && chkAplicarACarta.Checked && chkRedondearPrecio.Checked)
                            {
                                if (ActualizarPrecio.Precio != null)
                                {
                                    ActualizarPrecio.Precio = Math.Floor((double)ActualizarPrecio.Precio);

                                    if (ActualizarPrecio.Precio % 5 != 0)
                                    {
                                        ActualizarPrecio.Precio = ActualizarPrecio.Precio + (5 - (ActualizarPrecio.Precio % 5));
                                    }
                                }
                            }
                            else if (chkRedondearPrecio.Checked)
                            {
                                if (ActualizarPrecio.Precio != null)
                                {
                                    ActualizarPrecio.Precio = Math.Floor((double)ActualizarPrecio.Precio);

                                    if (ActualizarPrecio.Precio % 5 != 0)
                                    {
                                        ActualizarPrecio.Precio = ActualizarPrecio.Precio + (5 - (ActualizarPrecio.Precio % 5));
                                    }
                                }

                                if (ActualizarPrecio.PrecioDelivery != null)
                                {
                                    ActualizarPrecio.PrecioDelivery = Math.Floor((double)ActualizarPrecio.PrecioDelivery);

                                    if (ActualizarPrecio.PrecioDelivery % 5 != 0)
                                    {
                                        ActualizarPrecio.PrecioDelivery = ActualizarPrecio.PrecioDelivery + (5 - (ActualizarPrecio.PrecioDelivery % 5));
                                    }
                                }
                            }

                            bool PrecioPermitido = false;
                            bool PrecioMinimo = false;

                            if (ActualizarPrecio.Precio == null)
                            {
                                PrecioPermitido = true;
                            }
                            else
                            {
                                if (ActualizarPrecio.Precio >= 10 && ActualizarPrecio.Precio <= 999999)
                                {
                                    PrecioPermitido = true;
                                }
                                else if (ActualizarPrecio.Precio < 10)
                                {
                                    PrecioPermitido = false;
                                    PrecioMinimo = true;
                                }
                                else
                                {
                                    PrecioPermitido = false;
                                }
                            }

                            if (ActualizarPrecio.PrecioDelivery == null)
                            {
                                PrecioPermitido = true;
                            }
                            else
                            {
                                if (ActualizarPrecio.PrecioDelivery >= 10 && ActualizarPrecio.PrecioDelivery <= 999999)
                                {
                                    PrecioPermitido = true;
                                }
                                else if (ActualizarPrecio.PrecioDelivery < 10)
                                {
                                    PrecioPermitido = false;
                                    PrecioMinimo = true;
                                }
                                else
                                {
                                    PrecioPermitido = false;
                                }
                            }

                            if (PrecioPermitido)
                            {
                                if (ActualizarPrecio.Precio != null) { ActualizarPrecio.Precio = Math.Round((double)ActualizarPrecio.Precio, 2); }
                                if (ActualizarPrecio.PrecioDelivery != null) { ActualizarPrecio.PrecioDelivery = Math.Round((double)ActualizarPrecio.PrecioDelivery, 2); }

                                if (Articulos.Actualizar(ActualizarPrecio, ref InformacionDelError) != 0)
                                {
                                    if (ActualizarPrecio.Precio == null)
                                    {
                                        dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.PrecioCarta].Value = "NO TIENE";
                                    }
                                    else
                                    {
                                        dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.PrecioCarta].Value = ActualizarPrecio.Precio;
                                    }

                                    if (ActualizarPrecio.PrecioDelivery == null)
                                    {
                                        dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.PrecioDelivery].Value = "NO TIENE";
                                    }
                                    else
                                    {
                                        dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.PrecioDelivery].Value = ActualizarPrecio.PrecioDelivery;
                                    }
                                }
                                else if (InformacionDelError != string.Empty)
                                {
                                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar actualizar los precios");
                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else if (PrecioMinimo)
                            {
                                using (FrmInformacion FormInformacion = new FrmInformacion($"El articulo '{dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.Nombre].Value.ToString()}' (categoria '{dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.Categoria].Value.ToString()}') " +
                                        $"no se puede actualizar debido a que su precio seria inferior al minimo ($10 pesos).", ClsColores.Blanco, 350, 150))
                                {
                                    FormInformacion.ShowDialog();
                                }
                            }
                            else
                            {
                                using (FrmInformacion FormInformacion = new FrmInformacion($"El articulo '{dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.Nombre].Value.ToString()}' (categoria '{dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.Categoria].Value.ToString()}') " +
                                        $"no se puede actualizar debido a que su precio seria superior al maximo permitido (999999).", ClsColores.Blanco, 350, 150))
                                {
                                    FormInformacion.ShowDialog();
                                }
                            }
                            dgvCarta.Rows[Indice].Cells[(int)ENumColDGVCarta.Seleccionar].Value = false;
                        }
                    }
                }
                CambiarCheckboxSeleccion(false);
            }
        }
        #endregion

        #region Cargar DataGridView y ComboBox
        /// <summary>Carga la carta con todos los articulos activos (incluyendo a los que su categoria fue eliminada)</summary>
        private void CargarDGVCarta(ClsArticulos.ETipoListado _TipoDeListado)
        {
            if (FormularioCargado)
            {
                string NombreArticulo = string.Empty;

                int ID_CategoriaFiltro = 0;

                if (cmbCategoria.SelectedValue != null)
                {
                    CategoriaArticulo CategoriaSeleccionada = (CategoriaArticulo)cmbCategoria.SelectedItem;
                    ID_CategoriaFiltro = CategoriaSeleccionada.ID_CategoriaArticulo;
                }

                if (txtBuscarPorNombre.Text != TEXTO_VISUAL_BUSCAR) { NombreArticulo = txtBuscarPorNombre.Text; }

                dgvCarta.Rows.Clear();

                string InformacionDelError = string.Empty;

                ClsArticulos Articulos = new ClsArticulos();

                List<Articulo> ListarArticulosActivos = Articulos.LeerListado(_TipoDeListado, ref InformacionDelError, ClsArticulos.ETipoListado.ArticulosActivosInactivos, NombreArticulo, ID_CategoriaFiltro);

                if (ListarArticulosActivos != null)
                {
                    foreach (Articulo Elemento in ListarArticulosActivos)
                    {
                        int NumeroDeFila = dgvCarta.Rows.Add();

                        dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.ID_Articulo].Value = Elemento.ID_Articulo;
                        dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.Nombre].Value = Elemento.Nombre;
                        dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.Descripcion].Value = Elemento.Descripcion;
                        dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.Categoria].Value = Elemento.CategoriaArticulo.Nombre;

                        if (Elemento.Precio == null)
                        {
                            dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.PrecioCarta].Value = "NO TIENE";
                        }
                        else
                        {
                            dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.PrecioCarta].Value = Elemento.Precio;
                        }

                        if (Elemento.PrecioDelivery == null)
                        {
                            dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.PrecioDelivery].Value = "NO TIENE";
                        }
                        else
                        {
                            dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.PrecioDelivery].Value = Elemento.PrecioDelivery;
                        }

                        if (ArticulosDeCartaMarcados.Count > 0)
                        {
                            foreach (int ElementoSecundario in ArticulosDeCartaMarcados)
                            {
                                if (ElementoSecundario == Elemento.ID_Articulo)
                                {
                                    dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.Seleccionar].Value = true;
                                    ClsColores.MarcarFilaDGV(dgvCarta, NumeroDeFila, true);
                                    break;
                                }
                                else
                                {
                                    dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.Seleccionar].Value = false;
                                    ClsColores.MarcarFilaDGV(dgvCarta, NumeroDeFila, false);
                                }
                            }
                        }
                        else
                        {
                            dgvCarta.Rows[NumeroDeFila].Cells[(int)ENumColDGVCarta.Seleccionar].Value = false;
                            ClsColores.MarcarFilaDGV(dgvCarta, NumeroDeFila, false);
                        }
                    }
                }
                else if (InformacionDelError == string.Empty)
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al cargar los articulos");
                    MessageBox.Show($"Ocurrio un fallo al intentar cargar los articulos de la carta",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al cargar los articulos");
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            dgvCarta.ClearSelection();
        }
        #endregion

        /// <summary>
        /// Devuelve una unica instancia del formulario (Patron singleton)
        /// </summary>
        /// <returns></returns>
        public static FrmCarta ObtenerInstancia()
        {
            if (InstanciaForm == null) { InstanciaForm = new FrmCarta(); }

            return InstanciaForm;
        }

        #region Propiedades
        #endregion
    }
}
