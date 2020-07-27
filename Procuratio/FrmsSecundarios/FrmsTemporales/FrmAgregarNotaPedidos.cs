using Datos;
using Negocio;
using Procuratio.ClsDeApoyo;
using Procuratio.FrmsSecundarios.FrmsTemporales.FrmDelivery;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Procuratio
{
    public partial class FrmAgregarNotaPedidos : Form
    {
        #region Carga
        /// <summary>
        /// Inicializa el formulario para agregarle la nota a un pedido.
        /// </summary>
        /// <param name="_ID_Pedido">ID del pedido.</param>
        public FrmAgregarNotaPedidos(int _ID_Pedido)
        {
            InitializeComponent();

            ID_Pedido = _ID_Pedido;
        }

        /// <summary>
        /// Inicializa el formulario para agregarle la nota a un delivery.
        /// </summary>
        /// <param name="_ID_Pedido">ID del pedido.</param>
        /// <param name="_FormCrearEditarDelivery">Instancia del formulario que necesita reicibir los cambios.</param>
        public FrmAgregarNotaPedidos(int _ID_Pedido, FrmCrearEditarDelivery _FormCrearEditarDelivery)
        {
            InitializeComponent();

            ID_Pedido = _ID_Pedido;
            FormCrearEditarDelivery = _FormCrearEditarDelivery;
        }

        private void FrmAgregarNotaPedidos_Load(object sender, EventArgs e)
        {
            if (ID_Pedido != -1)
            {
                string InformacionDelError = string.Empty;

                ClsPedidos Pedidos = new ClsPedidos();
                Pedido LeerNota = new ClsPedidos();

                LeerNota = Pedidos.LeerPorNumero(ID_Pedido, ref InformacionDelError);

                if (LeerNota != null)
                {
                    txtNotaPedido.Text = LeerNota.Nota;
                }
                else if (InformacionDelError == string.Empty)
                {
                    MessageBox.Show($"Error al leer la nota", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region Variables
        private int ID_Pedido = -1;
        private int CuentaAtras = 60;
        private FrmCrearEditarDelivery FormCrearEditarDelivery = null;
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
        #endregion

        private void TxtNotaPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ActualizarNota();
            Close();
        }

        private void TmrCerrarNota_Tick(object sender, EventArgs e)
        {
            CuentaAtras--;
            lblTiempo.Text = Convert.ToString(CuentaAtras);

            if (CuentaAtras == 0)
            {
                //NotaPedido = txtNotaPedido.Text;
                ActualizarNota();
                Close();
            }
        }

        private void ActualizarNota()
        {
            if (ID_Pedido != -1)
            {
                string InformacionDelError = string.Empty;

                ClsPedidos Pedidos = new ClsPedidos();
                Pedido ActualizarNota = new Pedido();

                ActualizarNota = Pedidos.LeerPorNumero(ID_Pedido, ref InformacionDelError);

                if (ActualizarNota != null)
                {
                    ActualizarNota.Nota = txtNotaPedido.Text;

                    if (Pedidos.Actualizar(ActualizarNota, ref InformacionDelError) != 0)
                    {

                    }
                    else if (InformacionDelError != string.Empty)
                    {
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (InformacionDelError == string.Empty)
                {
                    MessageBox.Show($"Error al leer el pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                FormCrearEditarDelivery.S_NotaPedido = txtNotaPedido.Text;
            }
        }

        #region Propiedades
        #endregion
    }
}
