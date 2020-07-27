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

namespace Procuratio
{
    public partial class FrmArticulo : Form
    {
        #region Carga
        /// <summary>
        /// Carga el formulario para crear un articulo.
        /// </summary>
        public FrmArticulo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el formulario para editar los datos de un articulos.
        /// </summary>
        /// <param name="_ID_Articulo">ID del articulo a editar.</param>
        public FrmArticulo(int _ID_Articulo)
        {
            InitializeComponent();

            ID_Articulo = _ID_Articulo;
        }

        private void FrmModificaArticulo_Load(object sender, EventArgs e)
        {
            // TODO - cargar los datos si selecciono editar articulo. Si selecciono crear articulo, solo cargar el combobox.
            CargarCategorias();
            if (ID_Articulo != -1) { CargarDatosEditarArticulo(); }
        }

        /// <summary>Carga el ComboBox de categorias.</summary>
        private void CargarCategorias()
        {
            string InformacionDelError = string.Empty;

            ClsCategoriasArticulos Categorias = new ClsCategoriasArticulos();
            List<CategoriaArticulo> ListarCategorias = Categorias.LeerListado(ClsCategoriasArticulos.ETipoListado.CategoriasActivas,ref InformacionDelError);

            if (ListarCategorias != null)
            {
                // Nombre de la columna que contiene el nombre
                cmbCategoria.DisplayMember = "Nombre";
                // Nombre de la columna que contiene el ID
                cmbCategoria.ValueMember = "ID_CategoriaArticulo";

                // Llenar el combo
                cmbCategoria.DataSource = ListarCategorias.ToList();
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al cargar las categorias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void CargarDatosEditarArticulo()
        {
            btnAceptar.Visible = false;
            btnGuardarCambios.Visible = true;

            string InformacionDelError = string.Empty;

            ClsArticulos Articulos = new ClsArticulos();
            Articulo ArticuloAEditar = new Articulo();

            ArticuloAEditar = Articulos.LeerPorNumero(ID_Articulo, ref InformacionDelError);

            if (ArticuloAEditar != null)
            {
                txtNombreArticulo.Text = ArticuloAEditar.Nombre;
                txtDescripcion.Text = ArticuloAEditar.Descripcion;
                cmbCategoria.SelectedValue = ArticuloAEditar.ID_CategoriaArticulo;
                txtPrecio.Text = Convert.ToString(ArticuloAEditar.Precio);
                txtPrecioDelivery.Text = Convert.ToString(ArticuloAEditar.PrecioDelivery);
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Error al intentar cargar el articulo a editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Variables
        private const string TextoVisualBuscar = "Buscar por nombre de articulo...", TextoVisualComboBox = "Categoria";
        private int ID_Articulo = -1;
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            bool DatosValidos = true;
            string RegistroDeErrores = string.Empty;
            int AnchoFormInformacion = 100;

            CategoriaArticulo CategoriaArticulo = null;

            txtNombreArticulo.Text = txtNombreArticulo.Text.Trim();
            txtDescripcion.Text = txtDescripcion.Text.Trim();
            txtPrecio.Text = txtPrecio.Text.Trim();

            if (txtNombreArticulo.Text.Length < 3)
            {
                DatosValidos = false;
                RegistroDeErrores += "El campo 'Nombre' debe tener como minimo 3 caracteres.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (txtPrecio.Text != string.Empty)
            {
                if (txtPrecio.Text.Substring(0, 1) == "," || txtPrecio.Text.Substring(txtPrecio.Text.Length - 1, 1) == "," || Convert.ToDouble(txtPrecio.Text) < 10)
                {
                    DatosValidos = false;
                    RegistroDeErrores += "El campo 'Precio' debe ser mayor a $10 (verifique tambien que no tenga la " +
                        "coma del centavo al principio o al final).\r\n\r\n";
                    AnchoFormInformacion += 50;
                }
            }

            if (txtPrecioDelivery.Text != string.Empty)
            {
                if (txtPrecioDelivery.Text.Substring(0, 1) == "," || txtPrecioDelivery.Text.Substring(txtPrecioDelivery.Text.Length - 1, 1) == "," || Convert.ToDouble(txtPrecioDelivery.Text) < 10)
                {
                    DatosValidos = false;
                    RegistroDeErrores += "El campo 'Precio delivery' debe ser mayor a $10 (verifique tambien que no tenga la " +
                        "coma del centavo al principio o al final).\r\n\r\n";
                    AnchoFormInformacion += 50;
                }
            }

            if (cmbCategoria.SelectedItem != null)
            {
                CategoriaArticulo = (CategoriaArticulo)cmbCategoria.SelectedItem;
            }
            else
            {
                DatosValidos = false;
                RegistroDeErrores += "Seleccione una categoria.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (VerificarArticuloRepetido(txtNombreArticulo.Text, ID_Articulo))
            {
                DatosValidos = false;
                RegistroDeErrores += "El nombre del articulo ya se encuentra en uso.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (txtPrecio.Text == string.Empty && txtPrecioDelivery.Text == string.Empty)
            {
                DatosValidos = false;
                RegistroDeErrores += "El articulo debe tener un precio para carta o delivery.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (DatosValidos)
            {
                txtNombreArticulo.Text = txtNombreArticulo.Text.Substring(0, 1).ToUpper() + txtNombreArticulo.Text.Remove(0, 1).ToLower();

                if (txtDescripcion.Text != string.Empty)
                {
                    txtDescripcion.Text = txtDescripcion.Text.Substring(0, 1).ToUpper() + txtDescripcion.Text.Remove(0, 1).ToLower();
                }

                string InformacionDelError = string.Empty;

                ClsArticulos Articulo = new ClsArticulos();
                Articulo CrearArticulo = new Articulo();

                if (txtPrecio.Text == string.Empty)
                {
                    CrearArticulo.Precio = null;
                }
                else
                {
                    CrearArticulo.Precio = Math.Round(Convert.ToDouble(txtPrecio.Text), 2);
                }

                if (txtPrecioDelivery.Text == string.Empty)
                {
                    CrearArticulo.PrecioDelivery = null;
                }
                else
                {
                    CrearArticulo.PrecioDelivery = Math.Round(Convert.ToDouble(txtPrecioDelivery.Text), 2);
                }

                CrearArticulo.Nombre = txtNombreArticulo.Text;
                CrearArticulo.Descripcion = txtDescripcion.Text;
                CrearArticulo.ID_EstadoArticulo = (int)ClsEstadosArticulos.EEstadosArticulos.Activo;
                CrearArticulo.ID_CategoriaArticulo = CategoriaArticulo.ID_CategoriaArticulo;

                if (Articulo.Crear(CrearArticulo, ref InformacionDelError) != 0)
                {
                    DialogResult = DialogResult.OK;
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

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            bool DatosValidos = true;
            string RegistroDeErrores = string.Empty;
            int AnchoFormInformacion = 100;

            CategoriaArticulo CategoriaArticulo = null;

            txtNombreArticulo.Text = txtNombreArticulo.Text.Trim();
            txtDescripcion.Text = txtDescripcion.Text.Trim();
            txtPrecio.Text = txtPrecio.Text.Trim();

            if (txtNombreArticulo.Text.Length < 3)
            {
                DatosValidos = false;
                RegistroDeErrores += "El campo 'Nombre' debe tener como minimo 3 caracteres.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (txtPrecio.Text != string.Empty)
            {
                if (txtPrecio.Text.Substring(0, 1) == "," || txtPrecio.Text.Substring(txtPrecio.Text.Length - 1, 1) == "," || Convert.ToDouble(txtPrecio.Text) < 10)
                {
                    DatosValidos = false;
                    RegistroDeErrores += "El campo 'Precio' debe ser mayor a $10 (verifique tambien que no tenga la " +
                        "coma del centavo al principio o al final).\r\n\r\n";
                    AnchoFormInformacion += 50;
                }
            }

            if (txtPrecioDelivery.Text != string.Empty)
            {
                if (txtPrecioDelivery.Text.Substring(0, 1) == "," || txtPrecioDelivery.Text.Substring(txtPrecioDelivery.Text.Length - 1, 1) == "," || Convert.ToDouble(txtPrecioDelivery.Text) < 10)
                {
                    DatosValidos = false;
                    RegistroDeErrores += "El campo 'Precio delivery' debe ser mayor a $10 (verifique tambien que no tenga la " +
                        "coma del centavo al principio o al final).\r\n\r\n";
                    AnchoFormInformacion += 50;
                }
            }

            if (cmbCategoria.SelectedItem != null)
            {
                CategoriaArticulo = (CategoriaArticulo)cmbCategoria.SelectedItem;
            }
            else
            {
                DatosValidos = false;
                RegistroDeErrores += "Seleccione una categoria.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (VerificarArticuloRepetido(txtNombreArticulo.Text, ID_Articulo))
            {
                DatosValidos = false;
                RegistroDeErrores += "El nombre del articulo ya se encuentra en uso.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (txtPrecio.Text == string.Empty && txtPrecioDelivery.Text == string.Empty)
            {
                DatosValidos = false;
                RegistroDeErrores += "El articulo debe tener un precio para carta o delivery.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (DatosValidos)
            {
                txtNombreArticulo.Text = txtNombreArticulo.Text.Substring(0, 1).ToUpper() + txtNombreArticulo.Text.Remove(0, 1).ToLower();

                if (txtDescripcion.Text != string.Empty)
                {
                    txtDescripcion.Text = txtDescripcion.Text.Substring(0, 1).ToUpper() + txtDescripcion.Text.Remove(0, 1).ToLower();
                }

                string InformacionDelError = string.Empty;

                ClsArticulos Articulo = new ClsArticulos();
                Articulo ActualizarArticulo = new Articulo();

                ActualizarArticulo.ID_Articulo = ID_Articulo;
                ActualizarArticulo.Nombre = txtNombreArticulo.Text;
                ActualizarArticulo.Descripcion = txtDescripcion.Text;

                if (txtPrecio.Text == string.Empty)
                {
                    ActualizarArticulo.Precio = null;
                }
                else
                {
                    ActualizarArticulo.Precio = Math.Round(Convert.ToDouble(txtPrecio.Text), 2);
                }

                if (txtPrecioDelivery.Text == string.Empty)
                {
                    ActualizarArticulo.PrecioDelivery = null;
                }
                else
                {
                    ActualizarArticulo.PrecioDelivery = Math.Round(Convert.ToDouble(txtPrecioDelivery.Text), 2);
                }

                ActualizarArticulo.ID_EstadoArticulo = (int)ClsEstadosArticulos.EEstadosArticulos.Activo;
                ActualizarArticulo.ID_CategoriaArticulo = CategoriaArticulo.ID_CategoriaArticulo;

                if (Articulo.Actualizar(ActualizarArticulo, ref InformacionDelError) != 0)
                {
                    DialogResult = DialogResult.OK;
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

        /// <summary>
        /// Verifica que el nombre del articulo no este en uso, devuelve true si encontro una coincidencia.
        /// </summary>
        /// <param name="_Nombre">Articulo que se va a buscar.</param>
        /// <param name="_ID_ArticuloActual">ID que se usa para ignorar el articulo que se esta editando.</param>
        /// <returns></returns>
        private bool VerificarArticuloRepetido(string _Nombre, int _ID_ArticuloActual)
        {
            string InformacionDelError = string.Empty;

            ClsArticulos Articulos = new ClsArticulos();
            List<Articulo> BuscarDatosRepetidos = Articulos.LeerListado(ClsArticulos.ETipoListado.AritulosRepetidos, ref InformacionDelError,ClsArticulos.ETipoListado.AritulosRepetidos, "", 0, _Nombre, _ID_ArticuloActual);

            if (BuscarDatosRepetidos != null)
            {
                if (BuscarDatosRepetidos.Count > 0) { return true; }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Fallo al verificar si el articulo estaba repetido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) || (txtPrecio.Text == string.Empty && (e.KeyChar == 48 || e.KeyChar == 44)))
            {
                e.Handled = true;
            }

            if (txtPrecio.Text.Contains(",") && e.KeyChar == 44) { e.Handled = true; }

            if (e.KeyChar == 13)
            {
                txtDescripcion.Select();
                e.Handled = true;
            }
        }

        private void TxtPrecioDelivery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) || (txtPrecioDelivery.Text == string.Empty && (e.KeyChar == 48 || e.KeyChar == 44)))
            {
                e.Handled = true;
            }

            if (txtPrecioDelivery.Text.Contains(",") && e.KeyChar == 44) { e.Handled = true; }

            if (e.KeyChar == 13)
            {
                txtDescripcion.Select();
                e.Handled = true;
            }
        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e) => txtPrecio.Text = txtPrecio.Text.TrimStart('0');
        private void TxtPrecioDelivery_TextChanged(object sender, EventArgs e) => txtPrecioDelivery.Text = txtPrecioDelivery.Text.TrimStart('0');

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        #endregion
    }
}
