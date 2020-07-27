using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procuratio
{
    public partial class FrmMesas : Form
    {
        #region Codigo de Carga
        public FrmMesas()
        {
            InitializeComponent();
        }

        private void FrmMesas_Load(object sender, EventArgs e)
        {
            EstadoFormPrincipal = FormPrincipal.G_EstadoFormPrincipal;
            MenuVerticalContraido = FormPrincipal.G_MenuVerticalContraido;
        }
        #endregion

        #region Variables
        public enum NumerosDeTag
        {
            pnlContenedorMPB, pnlContenedorMPA, lblNumMesa, btnListaPedidos, picAgregarMesa, picEliminarMesa, picCambiarMesa,
            lblNombreMozo, lblEstadoPedido, lblTiempoDeEspera, picReloj, btnCambiarMozo, btnGuardarYEliminarMesa, btnEliminarMesa
        }

        private FrmPrincipal FormPrincipal = new FrmPrincipal();
        private FrmCrearMesa CrearMesa = new FrmCrearMesa();
        private FormWindowState EstadoFormPrincipal;
        private bool MenuVerticalContraido;
        private int[] NumeroDeMesas = new int[4]; //4 son las mesas maximas que se permiten juntar
        #endregion

        #region Codigo para darle estilo a los botones
        //Estilo de colores a los botones que funcionan como botones
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;
            BotonEnFoco.BackColor = Color.FromArgb(255, 127, 0);
        }

        private void btnEstiloBotones_Leave(object sender, EventArgs e)
        {
            Button BotonEnFoco = (Button)sender;
            BotonEnFoco.BackColor = Color.Transparent;
        }

        private void picBTNEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;
            PictureBoxEnFoco.BackColor = Color.FromArgb(25, 32, 40);
        }

        private void picBTNEstiloBotones_Leave(object sender, EventArgs e)
        {
            PictureBox PictureBoxEnFoco = (PictureBox)sender;
            PictureBoxEnFoco.BackColor = Color.Transparent;
        }
        #endregion

        private void BtnCrearMesaPB_Click(object sender, EventArgs e)
        {
            CrearMesa.ShowDialog();

            //TODO - asignar valores a numerodemesas desde el otro formulario

            //si mi array de numeros de mesas tiene como minimo un numero en la posicion 0 diferente de -1, significa que
            //el usuario cargó al menos una mesa para crear
            if (NumeroDeMesas[0] != -1)
            {
                CrearControles();
            }
        }

        /*
        |<-Tabla de asignacion de TAGS a controles->

        |0 => PanelContenedor de mesas planta baja
        |1 => PanelContenedor de mesas planta alta
        |2 => Labels con los respectivos numeros de mesas
        |3 => Boton de despliege de lista de pedidos de mesas
        |4 => PicBTN para agregar una mesa
        |5 => PicBTN para eliminar una mesa
        |6 => PicBTN para cambiar el numero de una mesa
        |7 => Label con el mozo que atiende la mesa
        |8 => Label con el estado del pedido
        |9 => (¿agregar?) Label con el tiempo de espera
        |10 => (¿agregar?) PictureBox Con una imagen cambiante de un reloj
        |11 => Boton para cambiar el mozo
        |12 => Boton para guardar y eliminar la mesa
        |13 => Boton para eliminar la mesa
        */

        //Cuando se ejecuta el evento de cerrar de
        private void CrearControles()
        {
            //Prop = PROPIEDADES
            Panel PanelContenedor = PropPanelContenedor();
            Label LabelNumeroMesa = PropLabelNumeroMesa();
            Button BotonListaPedidos = PropBotonListaPedidos();
            PictureBox PicBTNAgregarMesa = PropPicBTNAgregarMesa();
            PictureBox PicBTNEliminarMesa = PropPicBTNEliminarMesa();
            PictureBox PicBTNCambiarNumMesa = PropPicBTNCambiarNumMesa();
            Label LabelNombreMozo = PropLabelNombreMozo();
            Label EstadoPedido = PropEstadoPedido();
            Label TiempoDeEspera = PropTiempoDeEspera();
            PictureBox PictureboxReloj = PropPictureboxReloj();
            Button BotonCambiarMozo = PropBotonCambiarMozo();
            Button BotonGuardarYEliminarMesa = PropBotonGuardarYEliminarMesa();
            Button BotonEliminarMesa = PropBotonEliminarMesa();







        }

        private Panel PropPanelContenedor()
        {
            Panel PropiedadesPanel = new Panel();
            return PropiedadesPanel;
        }

        private Label PropLabelNumeroMesa()
        {
            Label PropiedadesLabel = new Label();
            return PropiedadesLabel;
        }

        private Button PropBotonListaPedidos()
        {
            Button PropiedadesBoton = new Button();
            return PropiedadesBoton;
        }

        private PictureBox PropPicBTNAgregarMesa()
        {
            PictureBox PropiedadesPictureBox = new PictureBox();
            return PropiedadesPictureBox;
        }

        private PictureBox PropPicBTNEliminarMesa()
        {
            PictureBox PropiedadesPictureBox = new PictureBox();
            return PropiedadesPictureBox;
        }

        private PictureBox PropPicBTNCambiarNumMesa()
        {
            PictureBox PropiedadesPictureBox = new PictureBox();
            return PropiedadesPictureBox;
        }

        private Label PropLabelNombreMozo()
        {
            Label PropiedadesLabel = new Label();
            return PropiedadesLabel;
        }

        private Label PropEstadoPedido()
        {
            Label PropiedadesLabel = new Label();
            return PropiedadesLabel;
        }

        private Label PropTiempoDeEspera()
        {
            Label PropiedadesLabel = new Label();
            return PropiedadesLabel;
        }

        private PictureBox PropPictureboxReloj()
        {
            PictureBox PropiedadesPictureBox = new PictureBox();
            return PropiedadesPictureBox;
        }

        private Button PropBotonCambiarMozo()
        {
            Button PropiedadesBoton = new Button();
            return PropiedadesBoton;
        }

        private Button PropBotonGuardarYEliminarMesa()
        {
            Button PropiedadesBoton = new Button();
            return PropiedadesBoton;
        }

        private Button PropBotonEliminarMesa()
        {
            Button PropiedadesBoton = new Button();
            return PropiedadesBoton;
        }



        #region Propiedades

        #endregion
    }
}
