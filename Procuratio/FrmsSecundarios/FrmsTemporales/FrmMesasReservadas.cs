using Datos;
using Negocio;
using Procuratio.ClsDeApoyo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Procuratio
{
    public partial class FrmMesasReservadas : Form
    {
        #region Carga
        /// <summary>
        /// Muestra las mesas ocupadas por un pedido.
        /// </summary>
        /// <param name="_ID_Pedido">Pedido a listar sus mesas ocupadas.</param>
        public FrmMesasReservadas(int _ID_Pedido)
        {
            InitializeComponent();

            ID_Pedido = _ID_Pedido;
            EsReserva = false;
        }

        /// <summary>
        /// Muestra las mesas que se van a reservar.
        /// </summary>
        /// <param name="_ListaDeMesasReserva">Mesas que se selecciono.</param>
        public FrmMesasReservadas(List<int> _ListaDeMesasReserva)
        {
            InitializeComponent();

            ListaDeMesasReserva = _ListaDeMesasReserva;
            EsReserva = true;
        }

        public FrmMesasReservadas(int _ID_Reserva, DateTime _FechaReserva)
        {
            InitializeComponent();

            ID_Reserva = _ID_Reserva;
            FechaReserva = _FechaReserva;
            EsReserva = true;
        }

        private void FrmMesasReservadas_Load(object sender, EventArgs e)
        {
            // Los dos primeros ifs cargan el DGV con mesas de un pedido de reservas, el ultimo, carga las de un pedido normal
            if (ID_Reserva != -1 && EsReserva)
            {
                CargarDGVMesasReservadas();
            }
            else if (EsReserva)
            {
                CargarDGVMesasPreReservadas();
            }
            else
            {
                CargarMesasPedidoNormal();
            }
        }

        /// <summary>
        /// Lista las mesas de una reserva ya creada.
        /// </summary>
        private void CargarDGVMesasReservadas()
        {
            if (ID_Reserva != -1)
            {
                string InformacionDelError = string.Empty;

                ClsMesasXReservas Mesas = new ClsMesasXReservas();

                List<MesaXReserva> ListarMesas = Mesas.LeerListado(ClsMesasXReservas.EMesasDisponibles.MesasReservadas, ref InformacionDelError, FechaReserva, ID_Reserva);

                if (ListarMesas != null)
                {
                    int CapacidadTotal = 0;

                    foreach (MesaXReserva Elemento in ListarMesas)
                    {
                        int NumeroDeFila = dgvMesasReservadas.Rows.Add();

                        dgvMesasReservadas.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesas.ID_Mesa].Value = Elemento.ID_Mesa;
                        dgvMesasReservadas.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesas.Numero].Value = Elemento.Mesa.Numero;
                        dgvMesasReservadas.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesas.Capacidad].Value = Elemento.Mesa.Capacidad;

                        CapacidadTotal += Elemento.Mesa.Capacidad;
                    }
                    dgvMesasReservadas.Sort(dgvMesasReservadas.Columns[(int)ENumColDGVMesas.Numero], ListSortDirection.Ascending);

                    lblResultadoCapacidadTotal.Text = Convert.ToString(CapacidadTotal);
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
            else
            {
                MessageBox.Show($"No se encontro el codigo identificador de la reserva para realizar la carga", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        /// <summary>
        /// Lista las mesas que se estan por reservas al crear/editar una reserva.
        /// </summary>
        private void CargarDGVMesasPreReservadas()
        {
            int[,] ArrayMesas = new int[12, 2];
            int CapacidadTotal = 0;

            string InformacionDelError = string.Empty;

            ClsMesas Mesas = new ClsMesas();
            Mesa BuscarMesasCargadas = new Mesa();

            foreach (int Numero in ListaDeMesasReserva)
            {
                BuscarMesasCargadas = Mesas.LeerPorNumero(Numero, ClsMesas.ETipoDeListado.PorID, ref InformacionDelError);

                if (BuscarMesasCargadas != null)
                {
                    int NumeroDeFila = dgvMesasReservadas.Rows.Add();

                    dgvMesasReservadas.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesas.ID_Mesa].Value = BuscarMesasCargadas.ID_Mesa;
                    dgvMesasReservadas.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesas.Numero].Value = BuscarMesasCargadas.Numero;
                    dgvMesasReservadas.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesas.Capacidad].Value = BuscarMesasCargadas.Capacidad;

                    CapacidadTotal += BuscarMesasCargadas.Capacidad;
                }
                else if (InformacionDelError == string.Empty)
                {
                    MessageBox.Show("Fallo al comprobar si trabaja con planta alta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
                else
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
            }

            dgvMesasReservadas.Sort(dgvMesasReservadas.Columns[(int)ENumColDGVMesas.Numero], ListSortDirection.Ascending);

            lblResultadoCapacidadTotal.Text = Convert.ToString(CapacidadTotal);
        }

        private void CargarMesasPedidoNormal()
        {
            int CapacidadTotal = 0;

            string InformacionDelError = string.Empty;

            ClsPedidosXMesas PedidoXMesa = new ClsPedidosXMesas();
            List<PedidoXMesa> BuscarMesasDelPedido = new List<PedidoXMesa>();

            BuscarMesasDelPedido = PedidoXMesa.LeerListado(ClsPedidosXMesas.ETipoDeListado.BuscarMesasYMozo, ref InformacionDelError, ID_Pedido);

            if (BuscarMesasDelPedido != null)
            {
                foreach (PedidoXMesa Elemento in BuscarMesasDelPedido)
                {
                    int NumeroDeFila = dgvMesasReservadas.Rows.Add();

                    dgvMesasReservadas.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesas.ID_Mesa].Value = Elemento.Mesa.ID_Mesa;
                    dgvMesasReservadas.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesas.Numero].Value = Elemento.Mesa.Numero;
                    dgvMesasReservadas.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesas.Capacidad].Value = Elemento.Mesa.Capacidad;

                    CapacidadTotal += Elemento.Mesa.Capacidad;
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Ocurrio un fallo al listar las mesas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dgvMesasReservadas.Sort(dgvMesasReservadas.Columns[(int)ENumColDGVMesas.Numero], ListSortDirection.Ascending);

            lblResultadoCapacidadTotal.Text = Convert.ToString(CapacidadTotal);
        }
        #endregion

        #region Variables
        /// <summary>
        /// Enumera las columnas del DGV para poder ubicarlas y editar mas facilmente su posicion.
        /// </summary>
        private enum ENumColDGVMesas
        {
            ID_Mesa, Numero, Capacidad
        }

        private bool EsReserva = false;
        private int ID_Pedido = -1;
        private int ID_Reserva = -1;
        DateTime FechaReserva = DateTime.Today;

        List<int> ListaDeMesasReserva = new List<int>();
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
