using Datos;
using Negocio;
using Procuratio.ClsDeApoyo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Procuratio
{
    public partial class FrmCrearCategoria : Form
    {
        #region Carga
        /// <summary>
        /// Inicializa el formulario para crear una categoria.
        /// </summary>
        public FrmCrearCategoria()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa el formulario para editar una categoria.
        /// </summary>
        /// <param name="_ID_Categoria">ID categoria a editar.</param>
        public FrmCrearCategoria(int _ID_Categoria)
        {
            InitializeComponent();

            ID_Categoria = _ID_Categoria;
        }

        private void FrmCrearCategoria_Load(object sender, EventArgs e)
        {
            if (ID_Categoria != -1)
            {
                CargarCategoria();
            }
        }

        private void CargarCategoria()
        {
            btnAceptar.Visible = false;
            BtnGuardarCambios.Visible = true;

            string InformacionDelError = string.Empty;

            ClsCategoriasArticulos CategoriasArticulos = new ClsCategoriasArticulos();
            CategoriaArticulo CargarCategoria = CategoriasArticulos.LeerPorNumero(ID_Categoria, ref InformacionDelError);

            if (CargarCategoria != null)
            {
                txtNombreCategoria.Text = CargarCategoria.Nombre;

                if (CargarCategoria.ParaCocina == (int)ClsCategoriasArticulos.EParaCocina.Si)
                {
                    rbnCocinaNo.Checked = false;
                    rbnCocinaSi.Checked = true;
                }
                else
                {
                    rbnCocinaNo.Checked = true;
                    rbnCocinaSi.Checked = false;
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al cargar la categoria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }
        #endregion

        #region Variables
        private int Acumulador = 0;
        private bool Invertir = true;
        private int ID_Categoria = -1;
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

        private void TmrColor_Tick(object sender, EventArgs e)
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            bool DatosValidos = true;
            string RegistroDeErrores = string.Empty;
            int AnchoFormInformacion = 100;

            txtNombreCategoria.Text = txtNombreCategoria.Text.Trim();

            if (txtNombreCategoria.Text.Length < 3)
            {
                DatosValidos = false;
                RegistroDeErrores += "El campo 'Nombre' debe tener como minimo 3 caracteres.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (VerificarCategoriaRepetida(txtNombreCategoria.Text, ID_Categoria))
            {
                DatosValidos = false;
                RegistroDeErrores += "El nombre de la categoria ya esta en uso.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (DatosValidos)
            {
                txtNombreCategoria.Text = txtNombreCategoria.Text.Substring(0, 1).ToUpper() + txtNombreCategoria.Text.Remove(0, 1).ToLower();

                string InformacionDelError = string.Empty;

                ClsCategoriasArticulos CategoriasArticulos = new ClsCategoriasArticulos();
                CategoriaArticulo NuevaCategoria = new CategoriaArticulo();

                NuevaCategoria.Nombre = txtNombreCategoria.Text;
                NuevaCategoria.ID_EstadoCategoriaArticulo = (int)ClsEstadosCategoriasArticulos.EEstadosCategoriasArticulos.Activo;

                if (rbnCocinaSi.Checked)
                {
                    NuevaCategoria.ParaCocina = (int)ClsCategoriasArticulos.EParaCocina.Si;
                }
                else
                {
                    NuevaCategoria.ParaCocina = (int)ClsCategoriasArticulos.EParaCocina.No;
                }

                DialogResult Confirmar = DialogResult.Cancel;

                Confirmar = MessageBox.Show($"¿Estas seguro que quieres crear la categoria '{NuevaCategoria.Nombre}' con esa " +
                    $"seleccion de categoria para cocina (si/no)?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Confirmar == DialogResult.OK)
                {
                    if (CategoriasArticulos.Crear(NuevaCategoria, ref InformacionDelError) != 0)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else if (InformacionDelError == string.Empty)
                    {
                        MessageBox.Show("Fallo al crear la categoria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion(RegistroDeErrores, ClsColores.Blanco, AnchoFormInformacion, 300))
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

            txtNombreCategoria.Text = txtNombreCategoria.Text.Trim();

            if (txtNombreCategoria.Text.Length < 3)
            {
                DatosValidos = false;
                RegistroDeErrores += "El campo 'Nombre' debe tener como minimo 3 caracteres.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (VerificarCategoriaRepetida(txtNombreCategoria.Text, ID_Categoria))
            {
                DatosValidos = false;
                RegistroDeErrores += "El nombre de la categoria ya esta en uso.\r\n\r\n";
                AnchoFormInformacion += 50;
            }

            if (DatosValidos)
            {
                txtNombreCategoria.Text = txtNombreCategoria.Text.Substring(0, 1).ToUpper() + txtNombreCategoria.Text.Remove(0, 1).ToLower();

                string InformacionDelError = string.Empty;

                ClsCategoriasArticulos CategoriasArticulos = new ClsCategoriasArticulos();
                CategoriaArticulo ActualizarCategoria = CategoriasArticulos.LeerPorNumero(ID_Categoria, ref InformacionDelError);

                if (ActualizarCategoria != null)
                {
                    ActualizarCategoria.Nombre = txtNombreCategoria.Text;

                    if (rbnCocinaSi.Checked)
                    {
                        ActualizarCategoria.ParaCocina = (int)ClsCategoriasArticulos.EParaCocina.Si;
                    }
                    else
                    {
                        ActualizarCategoria.ParaCocina = (int)ClsCategoriasArticulos.EParaCocina.No;
                    }

                    ClsDetalles Detalles = new ClsDetalles();
                    List<Detalle> SeEstaUsuandoLaCategoria = Detalles.LeerListado(-1, ClsDetalles.ETipoDeListado.CategoriaEnUso, ref InformacionDelError, ID_Categoria);

                    if (SeEstaUsuandoLaCategoria.Count == 0)
                    {
                        if (CategoriasArticulos.Actualizar(ActualizarCategoria, ref InformacionDelError) != 0)
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
                        using (FrmInformacion FormInformacion = new FrmInformacion($"No se puede editar la categoria porque " +
                                $"se esta usando para algun pedido en este momento.", ClsColores.Blanco, 200, 300))
                        {
                            FormInformacion.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion(RegistroDeErrores, ClsColores.Blanco, AnchoFormInformacion, 300))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Verifica que el nombre del articulo no este en uso, devuelve true si encontro una coincidencia.
        /// </summary>
        /// <param name="_Nombre">Categoria que se va a buscar.</param>
        /// <param name="_ID_Categoria">ID que se usa para ignorar la categoria que se esta editando.</param>
        /// <returns></returns>
        private bool VerificarCategoriaRepetida(string _Nombre, int _ID_Categoria)
        {
            string InformacionDelError = string.Empty;

            ClsCategoriasArticulos CategoriasArticulos = new ClsCategoriasArticulos();
            List<CategoriaArticulo> BuscarDatosRepetidos = CategoriasArticulos.LeerListado(ClsCategoriasArticulos.ETipoListado.CategoriasRepetidas, ref InformacionDelError, _Nombre, _ID_Categoria);

            if (BuscarDatosRepetidos != null)
            {
                if (BuscarDatosRepetidos.Count > 0) { return true; }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Fallo al verificar si la categoria estaba repetida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void PicBTNInformacion_Click(object sender, EventArgs e)
        {
            using (FrmInformacion FormInformacion = new FrmInformacion($"La categoria que se creara, se le asignara un valor que indicara " +
                    $"si los articulos que incluya en la misma, se enviaran a cocina para que estos sean cocinados/preparados, " +
                    $"si indica que no iran a cocina, estos articulos seran directamente enviados al cliente ya que " +
                    $"no hay que cocinarlos (como gaseosas o sandwiches ya elaborados que se encuentran en heladeras). Tener en cuenta " +
                    $"que los articulos que se indiquen como cocinados desde cocina, ya no se podran eliminar desde la lista de pedidos " +
                    $"ya que se considera que los productos para elaborar el plato ya fueron usados y no se pueden recuperar.\r\n\r\nSi " +
                    $"tiene articulos que puedan ser iguales, pero algunos son elaborados por cocina y otros no, indicar por ejemplo, que " +
                    $"los sandwiches que sean elaborados por cocina, estaran en la categoria 'Sandwiches de cocina' y los que ya estan " +
                    $"elaborados y solo hay que buscarlos en una heladera, estaran en la categoria 'Sandwitches'.", ClsColores.Blanco, 400, 600))
            {
                FormInformacion.ShowDialog();
            }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        #endregion
    }
}
