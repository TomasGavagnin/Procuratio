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
using Negocio.Clases_por_tablas;
using Procuratio.ClsDeApoyo;

namespace Procuratio.FrmsSecundarios.FrmsTemporales.FrmClientes
{
    public partial class FrmListadoAsistenciasConsumidas : Form
    {
        #region Carga
        /// <summary>
        /// Muestra las asistencias que se consumieron.
        /// </summary>
        /// <param name="_ListaDeClientes">Lista de ID de clientes.</param>
        public FrmListadoAsistenciasConsumidas(List<int> _ListaDeClientes)
        {
            InitializeComponent();

            ListaDeClientes = _ListaDeClientes;
        }

        private void FrmListadoAsistenciasConsumidas_Load(object sender, EventArgs e)
        {
            CargarDGVClientes();
        }

        private void CargarDGVClientes()
        {
            string InformacionDelError = string.Empty;

            ClsClientes Clientes = new ClsClientes();
            Cliente ClienteActual = null;
            List<Cliente> ListarClientes = new List<Cliente>();

            ClsClientesXPedidos ClienteXPedidos = new ClsClientesXPedidos();
            List<ClienteXPedido> CantidadAsistenciasVigentes = null;

            foreach (int Elemento in ListaDeClientes)
            {
                ClienteActual = Clientes.LeerPorNumero(Elemento, ClsClientes.EClienteBuscar.PorID, ref InformacionDelError);

                if (ClienteActual != null) { ListarClientes.Add(ClienteActual); }

                ClienteActual = null;
            }

            if (ListarClientes != null)
            {
                foreach (Cliente Elemento in ListarClientes)
                {
                    int NumeroDeFila = dgvListarClientes.Rows.Add();

                    dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVClientes.ID_Cliente].Value = Elemento.ID_Cliente;
                    dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVClientes.Nombre].Value = Elemento.Nombre;
                    dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVClientes.Apellido].Value = Elemento.Apellido;
                    dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVClientes.Telefono].Value = Elemento.Telefono;

                    CantidadAsistenciasVigentes = ClienteXPedidos.LeerListado(ClsClientesXPedidos.ETipoListado.CantidadAsistencias, ref InformacionDelError, Elemento.ID_Cliente);

                    if (CantidadAsistenciasVigentes != null)
                    {
                        dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVClientes.AsistenciasAcumuladas].Value = CantidadAsistenciasVigentes.Count;
                    }
                    else
                    {
                        dgvListarClientes.Rows[NumeroDeFila].Cells[(int)ENumColDGVClientes.AsistenciasAcumuladas].Value = 0;
                    }
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al listar los clientes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Variables
        private enum ENumColDGVClientes
        {
            ID_Cliente, Nombre, Apellido, Telefono, AsistenciasAcumuladas
        }

        private List<int> ListaDeClientes = new List<int>();
        #endregion

        #region Codigo para darle estilo a los botones
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

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        public List<int> S_ListaDeClientes { set { ListaDeClientes = value; } } 
    }
}
