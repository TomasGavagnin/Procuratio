using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using Datos;
using Negocio;
using Negocio.Clases_por_tablas;
using System.Threading;
using Procuratio.ClsDeApoyo;

namespace Procuratio
{
    public partial class FrmCrearMesa : Form
    {
        #region Carga
        /// <summary>
        /// Carga el formulario para crear un pedido.
        /// </summary>
        public FrmCrearMesa()
        {
            InitializeComponent();

            //Cargo los combobox aca porque sino no me toma el primer valuemember al editar el pedido
            CargarCMBMozos();
            CargarCMBChefs();
        }

        /// <summary>
        /// Cargar el formulario para la edicion de un pedido.
        /// </summary>
        /// <param name="_ID_Pedido">ID del pedido.</param>
        /// <param name="_ID_Mozo">ID del mozo.</param>
        /// <param name="_ID_Chef">ID del chef</param>
        /// <param name="_MesasEditar">Mesas que usa el pedido.</param>
        /// <param name="_PlantaBaja">Planta de las mesas del pedido (true es planta baja).</param>
        public FrmCrearMesa(int _ID_Pedido, int _ID_Mozo, int _ID_Chef, List<int> _MesasEditar, bool _PlantaBaja)
        {
            InitializeComponent();

            ID_Pedido = _ID_Pedido;
            ID_Mozo = _ID_Mozo;
            ID_Chef = _ID_Chef;
            MesasEditar = _MesasEditar;
            PlantaBaja = _PlantaBaja;

            //Cargo los combobox aca porque sino no me toma el primer valuemember al editar el pedido
            CargarCMBMozos();
            CargarCMBChefs();
        }

        private void FrmCrearMesa_Load(object sender, EventArgs e)
        {
            CargarDGVCrearMesas(ClsMesas.ETipoDeListado.MesasDisponiblesPB);
            TrabajaConPA();

            if (ID_Mozo != -1)
            {
                cmbNombreMozo.SelectedValue = ID_Mozo;
            }
            else
            {
                cmbNombreMozo.Text = "Mozo";
            }

            if (ID_Chef != -1)
            {
                cmbNombreChef.SelectedValue = ID_Chef;
            }
            else
            {
                cmbNombreChef.Text = "Chef";
            }
        }

        private void TrabajaConPA()
        {
            string InformacionDelError = string.Empty;

            ClsConfiguraciones Configuraciones = new ClsConfiguraciones();
            Configuracion HabilitarPA = new Configuracion();

            HabilitarPA = Configuraciones.LeerPorNumero(1, ref InformacionDelError);

            if (HabilitarPA != null)
            {
                if (HabilitarPA.TrabajaConPlantaAlta == 1) { rbnPlantaAlta.Enabled = true; }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al comprobar si trabaja con planta alta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarCMBMozos()
        {
            string InformacionDelError = string.Empty;

            ClsUsuarios ListarUsuarios = new ClsUsuarios();

            List<Usuario> CargarComboBoxUsuarios = ListarUsuarios.LeerListado(ClsUsuarios.ETipoListado.UsuariosParaMesas, ref InformacionDelError);

            if (CargarComboBoxUsuarios != null)
            {
                foreach (Usuario Elemento in CargarComboBoxUsuarios)
                {
                    Elemento.Nombre += $" {Elemento.Apellido}";
                }

                // Nombre de la columna que contiene el nombre
                cmbNombreMozo.DisplayMember = "Nombre";
                // Nombre de la columna que contiene el ID
                cmbNombreMozo.ValueMember = "ID_Usuario";

                // Llenar el combo
                cmbNombreMozo.DataSource = CargarComboBoxUsuarios;
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Ocurrio un error al cargar los mozos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarCMBChefs()
        {
            string InformacionDelError = string.Empty;

            ClsUsuarios ListarChefs = new ClsUsuarios();

            List<Usuario> CargarComboBoxChefs = ListarChefs.LeerListado(ClsUsuarios.ETipoListado.UsuariosChef, ref InformacionDelError);

            if (CargarComboBoxChefs != null)
            {
                foreach (Usuario Elemento in CargarComboBoxChefs)
                {
                    Elemento.Nombre += $" {Elemento.Apellido}";
                }

                // Nombre de la columna que contiene el nombre
                cmbNombreChef.DisplayMember = "Nombre";
                // Nombre de la columna que contiene el ID
                cmbNombreChef.ValueMember = "ID_Usuario";

                // Llenar el combo
                cmbNombreChef.DataSource = CargarComboBoxChefs;
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Ocurrio un error al cargar los mozos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Variables
        private enum ENumColDGVMesa
        {
            ID_Mesa, Numero, Capacidad, Seleccionar
        }

        //private FrmMesas FormMesas;
        private int Acumulador = 0;
        private bool Invertir = true;
        private int[,] NumeroDeMesas = new int[12, 2];

        private List<int> MesasEditar = new List<int>();
        private List<int> ClientesDelPedido = new List<int>();
        private int ID_Mozo = -1;
        private int ID_Chef = -1;
        private int ID_Pedido = -1;
        private bool PlantaBaja = true;
        private int UltimaFilaSeleccionada = -1;
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

        private void RbnPlantaBaja_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnPlantaBaja.Checked) { CargarDGVCrearMesas(ClsMesas.ETipoDeListado.MesasDisponiblesPB); }
        }

        private void RbnPlantaAlta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnPlantaAlta.Checked) { CargarDGVCrearMesas(ClsMesas.ETipoDeListado.MesasDisponiblesPA); }
        }

        private void DgvCrearMesa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                int TotalDeFilas = dgvCrearMesa.Rows.Count;
                int CapacidadTotal = 0;

                // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                if (dgvCrearMesa.Rows[e.RowIndex].Cells[(int)ENumColDGVMesa.Seleccionar].Value != null)
                {
                    if (!(bool)dgvCrearMesa.Rows[e.RowIndex].Cells[(int)ENumColDGVMesa.Seleccionar].Value && e.RowIndex != UltimaFilaSeleccionada)
                    {
                        ClsColores.MarcarFilaDGV(dgvCrearMesa, e.RowIndex, true);
                    }
                    else
                    {
                        ClsColores.MarcarFilaDGV(dgvCrearMesa, e.RowIndex, false);
                    }
                }

                UltimaFilaSeleccionada = e.RowIndex;

                if (dgvCrearMesa.EndEdit())
                {
                    for (int Indice = 0; Indice < TotalDeFilas; Indice++)
                    {
                        //Pregunto si la celda es diferente a null
                        if (dgvCrearMesa.Rows[Indice].Cells[(int)ENumColDGVMesa.Seleccionar].Value != null)
                        {
                            //Casteo el check del objeto a booleano y pregunto si es true
                            if ((bool)dgvCrearMesa.Rows[Indice].Cells[(int)ENumColDGVMesa.Seleccionar].Value)
                            {
                                CapacidadTotal += (int)dgvCrearMesa.Rows[Indice].Cells[(int)ENumColDGVMesa.Capacidad].Value;
                            }
                        }
                    }
                    lblResultadoCapacidadTotal.Text = Convert.ToString(CapacidadTotal);
                }
            }
        }

        private void BtnCargarClientes_Click(object sender, EventArgs e)
        {
            using (FrmCliente FormCliente = new FrmCliente(FrmCliente.EMostrarOcultarColumnas.MostrarSeleccionarConBarraArrastre))
            {
                FormCliente.S_ID_Pedido = ID_Pedido;
                FormCliente.AsignarFormCrearMesa(this);
                FormCliente.ShowDialog();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int TotalDeFilas = dgvCrearMesa.Rows.Count;
            bool CantidadDeMesasExcedida = false;
            int TotalFilasArray = NumeroDeMesas.GetLength(0);

            // Limpiar el array.
            for (int I = 0; I < TotalFilasArray; I++)
            {
                for (int J = 0; J < NumeroDeMesas.Rank; J++)
                {
                    NumeroDeMesas[I, J] = 0;
                }
            }

            // IndiceArray me mantiene el indice real de asignacion
            for (int Indice = 0, IndiceArray = 0; Indice < TotalDeFilas; Indice++)
            {
                //Pregunto si la celda es diferente a null
                if (dgvCrearMesa.Rows[Indice].Cells[(int)ENumColDGVMesa.Seleccionar].Value != null)
                {
                    //Casteo el check del objeto a booleano y pregunto si es true
                    if ((bool)dgvCrearMesa.Rows[Indice].Cells[(int)ENumColDGVMesa.Seleccionar].Value)
                    {
                        // Verificar que no exceda el limite de mesas permitidas (12)
                        if (IndiceArray == 12)
                        {
                            CantidadDeMesasExcedida = true;
                            break;
                        }

                        // Cargo el ID.
                        NumeroDeMesas[IndiceArray, 0] = (int)dgvCrearMesa.Rows[Indice].Cells[(int)ENumColDGVMesa.ID_Mesa].Value;
                        // Cargo el numero
                        NumeroDeMesas[IndiceArray, 1] = (int)dgvCrearMesa.Rows[Indice].Cells[(int)ENumColDGVMesa.Numero].Value;

                        IndiceArray++;
                    }
                }
            }

            // Un numero diferente a 0 en la primera posicion, indica que por lo menos se cargo 1 ID en el array (1 mesa)
            if (NumeroDeMesas[0, 0] > 0)
            {
                if (!CantidadDeMesasExcedida)
                {
                    if (cmbNombreMozo.SelectedValue != null && cmbNombreChef.SelectedValue != null)
                    {
                        FrmMesas.ObtenerInstancia().S_NumeroDeMesas = NumeroDeMesas;
                        Usuario UsuarioSeleccionado = (Usuario)cmbNombreMozo.SelectedItem;
                        Usuario ChefSeleccionado = (Usuario)cmbNombreChef.SelectedItem;

                        FrmMesas.ObtenerInstancia().S_IDDelMozo = UsuarioSeleccionado.ID_Usuario;
                        FrmMesas.ObtenerInstancia().S_IDDelChef = ChefSeleccionado.ID_Usuario;
                        FrmMesas.ObtenerInstancia().S_NombreDelMozo = $"{UsuarioSeleccionado.Nombre}";
                        FrmMesas.ObtenerInstancia().S_ClientesDelPedido = ClientesDelPedido;

                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        using (FrmInformacion FormInformacion = new FrmInformacion($"Es obligatorio asignar el mozo y chef a la mesa.", ClsColores.Blanco, 150, 300))
                        {
                            FormInformacion.ShowDialog();
                        }
                    }
                }
                else
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion($"El maximo permitido de mesas juntas es 12.", ClsColores.Blanco, 200, 300))
                    {
                        FormInformacion.ShowDialog();
                    }
                }
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion($"Debe seleccionar como minimo una mesa (maximo 12 mesas juntas).", ClsColores.Blanco, 150, 300))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }

        private void CargarDGVCrearMesas(ClsMesas.ETipoDeListado _TipoDeListado)
        {
            dgvCrearMesa.Rows.Clear();
            lblResultadoCapacidadTotal.Text = "0";

            string InformacionDelError = string.Empty;

            ClsMesas Mesas = new ClsMesas();
            List<Mesa> CargarMesasDisponibles = Mesas.LeerListado(_TipoDeListado, ref InformacionDelError);

            if (CargarMesasDisponibles != null)
            {
                bool MesasOcupadasCargadas = false;

                foreach (Mesa Elemento in CargarMesasDisponibles)
                {
                    int NumeroDeFila = dgvCrearMesa.Rows.Add();

                    dgvCrearMesa.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.ID_Mesa].Value = Elemento.ID_Mesa;
                    dgvCrearMesa.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.Numero].Value = Elemento.Numero;
                    dgvCrearMesa.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.Capacidad].Value = Elemento.Capacidad;
                    dgvCrearMesa.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.Seleccionar].Value = false;

                    if (MesasEditar.Count > 0 && !MesasOcupadasCargadas)
                    {
                        if (ClsMesas.ETipoDeListado.MesasDisponiblesPB == _TipoDeListado && PlantaBaja)
                        {
                            CargarMesasViejas();
                        }
                        else if (ClsMesas.ETipoDeListado.MesasDisponiblesPA == _TipoDeListado && !PlantaBaja)
                        {
                            CargarMesasViejas();
                        }
                        MesasOcupadasCargadas = true;
                    }
                }

                if (CargarMesasDisponibles.Count == 0)
                {
                    if (MesasEditar.Count > 0 && !MesasOcupadasCargadas)
                    {
                        if (ClsMesas.ETipoDeListado.MesasDisponiblesPB == _TipoDeListado && PlantaBaja)
                        {
                            CargarMesasViejas();
                        }
                        else if (ClsMesas.ETipoDeListado.MesasDisponiblesPA == _TipoDeListado && !PlantaBaja)
                        {
                            CargarMesasViejas();
                        }
                    }
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Ocurrio un fallo al cargar el filtro de estados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dgvCrearMesa.Sort(dgvCrearMesa.Columns[(int)ENumColDGVMesa.Numero], ListSortDirection.Ascending);
        }

        /// <summary>
        /// Carga las mesas que estan en estado ocupado de la mesa que va a editar
        /// </summary>
        private void CargarMesasViejas()
        {
            foreach (int Elemento in MesasEditar)
            {
                string InformacionDelError = string.Empty;

                ClsMesas Mesas = new ClsMesas();
                Mesa CargarMesasViejas = Mesas.LeerPorNumero(Elemento, ClsMesas.ETipoDeListado.PorID, ref InformacionDelError);

                if (CargarMesasViejas != null)
                {
                    int NumeroDeFila = dgvCrearMesa.Rows.Add();

                    dgvCrearMesa.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.ID_Mesa].Value = CargarMesasViejas.ID_Mesa;
                    dgvCrearMesa.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.Numero].Value = CargarMesasViejas.Numero;
                    dgvCrearMesa.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.Capacidad].Value = CargarMesasViejas.Capacidad;
                    dgvCrearMesa.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.Seleccionar].Value = true;

                    ClsColores.MarcarFilaDGV(dgvCrearMesa, NumeroDeFila, true);

                    lblResultadoCapacidadTotal.Text = Convert.ToString(Convert.ToInt32(lblResultadoCapacidadTotal.Text) + CargarMesasViejas.Capacidad);
                }
                else if (InformacionDelError == string.Empty)
                {
                    MessageBox.Show("Ocurrio un fallo al cargar el filtro de estados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            dgvCrearMesa.Sort(dgvCrearMesa.Columns[(int)ENumColDGVMesa.Numero], ListSortDirection.Ascending);
        }

        private void PicBTNInformacion_Click(object sender, EventArgs e)
        {
            using (FrmInformacion FormInformacion = new FrmInformacion("Las mesas que se muestran disponibles, son las que no estan ocupadas " +
                    "en este momento.\r\n\r\nSolo puede juntar un maximo de 12 mesas (y todas estas deben pertenecer a la misma " +
                    "planta).\r\n\r\nPuede cargar los clientes que asistieron a este pedido que esta creando/editando, para poder " +
                    "saber en un futuro que clientes asistieron a los diferentes pedidos en un periodo de tiempo, con el objetivo de " +
                    "realizar promociones mas personalizadas.", ClsColores.Blanco, 350, 500))
            {
                FormInformacion.ShowDialog();
            }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        /// <summary>
        /// Indica que clientes asistieron a un pedido
        /// </summary>
        public List<int> S_ClientesDelPedido { set { ClientesDelPedido = value; } }
        #endregion
    }
}
