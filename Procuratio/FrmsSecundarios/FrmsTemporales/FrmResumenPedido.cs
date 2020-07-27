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
using Procuratio.Reportes;
using System.Drawing.Printing;
using Negocio.Clases_por_tablas;
using Procuratio.ClsDeApoyo;
using Negocio.Clases_de_apoyo;

namespace Procuratio
{
    public partial class FrmResumenPedido : Form
    {
        #region Carga
        /// <summary>
        /// Muestra lo consumido por un pedido.
        /// </summary>
        /// <param name="_ID_Pedido">ID del pedido a mostrar.</param>
        /// <param name="_NumeroMesas">Mesas ocupadas.</param>
        /// <param name="_SoloMostrar">Con un valor true, el mozo no podra cerrar el pedido, solo imprimir verlo e imprimir 
        /// el ticket para el cliente.</param>
        public FrmResumenPedido(int _ID_Pedido, List<int> _NumeroMesas, bool _SoloMostrar)
        {
            InitializeComponent();

            ID_Pedido = _ID_Pedido;
            NumerosMesas = _NumeroMesas;
            SoloMostrar = _SoloMostrar;
            EsDelivery = false;
        }

        /// <summary>
        /// Muestra lo consumido por un delivery.
        /// </summary>
        /// <param name="_ID_Pedido">ID del delivery a mostrar.</param>
        /// el ticket para el cliente.</param>
        public FrmResumenPedido(int _ID_Pedido, int _ID_UsuarioQueConfirmaDelivery)
        {
            InitializeComponent();

            ID_Pedido = _ID_Pedido;
            ID_UsuarioQueConfirmaDelivery = _ID_UsuarioQueConfirmaDelivery;
            EsDelivery = true;
        }

        private void FrmResumenPedido_Load(object sender, EventArgs e)
        {
            CargarResumenPedido();

            if (EsDelivery)
            {
                PrepararParaDelivery();
            }
            else
            {
                CargarCMBMesas();

                if (SoloMostrar)
                {
                    txtPago.Enabled = false;
                    rbnIngreso.Enabled = false;
                    rbnEgreso.Enabled = false;
                    btnRegistrarPago.Enabled = false;
                    btnRegistrarPago.Visible = false;
                    rbnNoRealizarAumentoDescuento.Enabled = true;
                    rbnAumento.Enabled = true;
                    rbnDescuento.Enabled = true;
                    nudPorcentaje.Enabled = false;
                }
            }
        }

        private void PrepararParaDelivery()
        {
            cmbMesas.Visible = false;
            lblNumeroPedido.Location = new Point(cmbMesas.Location.X, cmbMesas.Location.Y);
            BloquearControlesParaDelivery();
        }

        private void BloquearControlesParaDelivery()
        {
            rbnEgreso.Enabled = false;
            rbnAumento.Enabled = false;
        }

        private void CargarResumenPedido()
        {
            double Total = 0;
            string InformacionDelError = string.Empty;

            ClsDetalles Detalles = new ClsDetalles();
            List<Detalle> DetalleDelPedido = Detalles.LeerListado(ID_Pedido, ClsDetalles.ETipoDeListado.PorIDPedido, ref InformacionDelError);

            if (DetalleDelPedido != null)
            {
                foreach (Detalle Elemento in DetalleDelPedido)
                {
                    int NumeroDeFila = dgvArticulosPedido.Rows.Add();

                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVResumenPedido.ID_Articulo].Value = Elemento.Articulo.ID_Articulo;
                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVResumenPedido.Articulo].Value = Elemento.Articulo.Nombre;
                    dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVResumenPedido.Cantidad].Value = Elemento.Cantidad;

                    if (EsDelivery)
                    {
                        double PrecioDelivery = 0;

                        if (Elemento.Articulo.PrecioDelivery != null) { PrecioDelivery = (double)Elemento.Articulo.PrecioDelivery; }

                        dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVResumenPedido.PrecioUnitario].Value = PrecioDelivery;
                        dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVResumenPedido.Subtotal].Value = PrecioDelivery * Elemento.Cantidad;
                    }
                    else
                    {
                        double Precio = 0;

                        if (Elemento.Articulo.Precio != null) { Precio = (double)Elemento.Articulo.Precio; }

                        dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVResumenPedido.PrecioUnitario].Value = Precio;
                        dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVResumenPedido.Subtotal].Value = Precio * Elemento.Cantidad;
                    }

                    Total += Convert.ToDouble(dgvArticulosPedido.Rows[NumeroDeFila].Cells[(int)ENumColDGVResumenPedido.Subtotal].Value);
                }

                lblMostratTotal.Text = Convert.ToString(Total);
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al cargar el detalle del pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }

            lblNumeroPedido.Text += $" {ID_Pedido}";
        }

        private void CargarCMBMesas()
        {
            foreach (int Elemento in NumerosMesas) { cmbMesas.Items.Add(Elemento); }
        }
        #endregion

        #region Variables
        /// <summary>
        /// Enumera las columnas del DGV para poder ubicarlas y editar mas facilmente su posicion.
        /// </summary>
        private enum ENumColDGVResumenPedido
        {
            ID_Articulo, Articulo, Cantidad, PrecioUnitario, Subtotal
        }

        private int ID_UsuarioQueConfirmaDelivery = -1;
        private int ID_Pedido = -1;
        private bool SoloMostrar = false;
        private bool EsDelivery = false;
        private List<int> NumerosMesas = new List<int>();
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

            if (BotonEnFoco.Name == btnImprimirResumen.Name)
            {
                BotonEnFoco.BackColor = ClsColores.VioletaClaro;
            }
            else if (BotonEnFoco.Name == btnCerrarPreCuenta.Name)
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
        #endregion

        private void TxtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 || (txtPago.Text == string.Empty && e.KeyChar == 48)) { e.Handled = true; }
        }

        private void TxtPago_TextChanged(object sender, EventArgs e)
        {
            // TODO - Calcular vuelto en funcion del pago y el total
            if (txtPago.Text != string.Empty)
            {
                lblMostrarVuelto.Text = Convert.ToString(DarFormato(Convert.ToDouble(txtPago.Text) - Convert.ToDouble(lblMostratTotal.Text)));
            }
            else
            {
                lblMostrarVuelto.Text = "0";
            }
        }

        private void BtnRegistrarPago_Click(object sender, EventArgs e)
        {
            bool HuboError = false;

            string InformacionDelError = string.Empty;

            ClsCajas Cajas = new ClsCajas();
            Caja CrearRegistro = new Caja();
            Caja CrearSubRegistro = new Caja();

            // Creo el registro de la mesa
            CrearRegistro.Fecha = DateTime.Today.Date;
            CrearRegistro.Hora = TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss"));
            CrearRegistro.Monto = Convert.ToDouble(lblMostratTotal.Text);
            CrearRegistro.Detalle = string.Empty;
            CrearRegistro.ID_Pedido = ID_Pedido;

            if (EsDelivery)
            {
                CrearRegistro.ID_TipoDeMonto = (int)ClsTiposDeMontos.ETiposDeMontos.IngresoDelivery;
            }
            else
            {
                CrearRegistro.ID_TipoDeMonto = rbnIngreso.Checked ? (int)ClsTiposDeMontos.ETiposDeMontos.IngresoCierreDeMesa : (int)ClsTiposDeMontos.ETiposDeMontos.EgresoCierreDeMesa;
            }

            CrearRegistro.ID_EstadoCaja = (int)ClsEstadosCajas.EEstadosCajas.Activo;

            //buscar el usuario
            ClsPedidosXMesas PedidosXMesas = new ClsPedidosXMesas();
            PedidoXMesa BuscarMozo = new PedidoXMesa();

            BuscarMozo = PedidosXMesas.LeerPorNumero(ID_Pedido, ref InformacionDelError);
            
            if (BuscarMozo != null || ID_UsuarioQueConfirmaDelivery != -1)
            {
                if (ID_UsuarioQueConfirmaDelivery != -1)
                {
                    CrearRegistro.ID_Usuario = ID_UsuarioQueConfirmaDelivery;
                    CrearSubRegistro.ID_Usuario = ID_UsuarioQueConfirmaDelivery;
                }
                else
                {
                    CrearRegistro.ID_Usuario = BuscarMozo.Mesa.ID_Usuario;
                    CrearSubRegistro.ID_Usuario = BuscarMozo.Mesa.ID_Usuario;
                }

                // creo un registro de aumento/descuento si lo selecciono
                if (rbnDescuento.Checked)
                {
                    CrearSubRegistro.Fecha = DateTime.Today.Date;
                    CrearSubRegistro.Hora = TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss"));
                    CrearSubRegistro.Monto = Convert.ToDouble(lblMostrarTotalDescuento.Text);

                    if (EsDelivery)
                    {
                        CrearSubRegistro.Detalle = $"{nudPorcentaje.Value}% con " +
                        $"fecha {DateTime.Today.ToShortDateString()} a las " +
                        $"{TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss"))}";
                        CrearSubRegistro.ID_TipoDeMonto = (int)ClsTiposDeMontos.ETiposDeMontos.DescuentoDelivery;
                    }
                    else
                    {
                        CrearSubRegistro.Detalle = $"{nudPorcentaje.Value}% a la mesa con " +
                        $"fecha {DateTime.Today.ToShortDateString()} a las " +
                        $"{TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss"))}";
                        CrearSubRegistro.ID_TipoDeMonto = (int)ClsTiposDeMontos.ETiposDeMontos.DescuentoCierreDeMesa;
                    }

                    CrearSubRegistro.ID_Pedido = ID_Pedido;
                    CrearSubRegistro.ID_EstadoCaja = (int)ClsEstadosCajas.EEstadosCajas.Activo;
                }
                else if (rbnAumento.Checked)
                {
                    CrearSubRegistro.Fecha = DateTime.Today.Date;
                    CrearSubRegistro.Hora = TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss"));
                    CrearSubRegistro.Monto = Convert.ToDouble(lblMostrarTotalAumento.Text);
                    CrearSubRegistro.Detalle = $"{nudPorcentaje.Value}% a la mesa con " +
                        $"fecha {DateTime.Today.ToShortDateString()} a las " +
                        $"{TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss"))}";
                    CrearSubRegistro.ID_Pedido = ID_Pedido;
                    CrearSubRegistro.ID_TipoDeMonto = (int)ClsTiposDeMontos.ETiposDeMontos.AumentoCierreDeMesa;
                    CrearSubRegistro.ID_EstadoCaja = (int)ClsEstadosCajas.EEstadosCajas.Activo;
                }

                if (Cajas.Crear(CrearRegistro, ref InformacionDelError) != 0)
                {
                    if (rbnDescuento.Checked || rbnAumento.Checked)
                    {
                        if (Cajas.Crear(CrearSubRegistro, ref InformacionDelError) != 0)
                        {
                            HuboError = false;
                        }
                        else if (InformacionDelError == string.Empty)
                        {
                            MessageBox.Show($"Fallo al crear el registro de aumento/descuento en caja", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Cajas.Borrar(CrearRegistro.ID_Caja, ref InformacionDelError);
                            HuboError = true;
                        }
                        else
                        {
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Cajas.Borrar(CrearRegistro.ID_Caja, ref InformacionDelError);
                            HuboError = true;
                        }
                    }

                    if (!HuboError)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else if (InformacionDelError == string.Empty)
                {
                    MessageBox.Show($"Fallo al crear el registro en caja", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Fallo al buscar el mozo para crear el registro en caja", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RbnTipoMovimiento_Click(object sender, EventArgs e)
        {
            if (rbnIngreso.Checked)
            {
                rbnDescuento.Enabled = true;
                rbnAumento.Enabled = true;

                if (rbnNoRealizarAumentoDescuento.Checked)
                {
                    nudPorcentaje.Enabled = false;
                }
                else
                {
                    nudPorcentaje.Enabled = true;
                }
            }
            else if (rbnEgreso.Checked)
            {
                rbnNoRealizarAumentoDescuento.Checked = true;
                rbnDescuento.Enabled = false;
                rbnAumento.Enabled = false;
                nudPorcentaje.Enabled = false;
                nudPorcentaje.Value = 5;
                lblMostrarTotalDescuento.Text = "0";
                lblMostrarTotalAumento.Text = "0";
            }

            lblMostrarTotalDescuento.Text = Convert.ToString(RedondearPrecio(Convert.ToDouble(lblMostrarTotalDescuento.Text)));
            lblMostrarTotalAumento.Text = Convert.ToString(RedondearPrecio(Convert.ToDouble(lblMostrarTotalAumento.Text)));

            if (EsDelivery)
            {
                BloquearControlesParaDelivery();
            }
        }

        private void RbnAccionARealizar_Click(object sender, EventArgs e)
        {
            if (rbnNoRealizarAumentoDescuento.Checked)
            {
                nudPorcentaje.Enabled = false;
                lblMostrarTotalDescuento.Text = "0";
                lblMostrarTotalAumento.Text = "0";
                nudPorcentaje.Value = 5;
            }
            else if (rbnDescuento.Checked)
            {
                nudPorcentaje.Enabled = true;
                lblMostrarTotalDescuento.Text = Convert.ToString(DarFormato(Convert.ToDouble(lblMostratTotal.Text) * (int)nudPorcentaje.Value / 100));
                lblMostrarTotalAumento.Text = "0";
            }
            else if (rbnAumento.Checked)
            {
                nudPorcentaje.Enabled = true;
                lblMostrarTotalAumento.Text = Convert.ToString(DarFormato(Convert.ToDouble(lblMostratTotal.Text) * (int)nudPorcentaje.Value / 100));
                lblMostrarTotalDescuento.Text = "0";
            }

            lblMostrarTotalDescuento.Text = Convert.ToString(RedondearPrecio(Convert.ToDouble(lblMostrarTotalDescuento.Text)));
            lblMostrarTotalAumento.Text = Convert.ToString(RedondearPrecio(Convert.ToDouble(lblMostrarTotalAumento.Text)));

            if (EsDelivery)
            {
                BloquearControlesParaDelivery();
            }
        }

        private void NudPorcentaje_ValueChanged(object sender, EventArgs e)
        {
            if (rbnAumento.Checked)
            {
                lblMostrarTotalAumento.Text = Convert.ToString(DarFormato(Convert.ToDouble(lblMostratTotal.Text) * (int)nudPorcentaje.Value / 100));
            }
            else if (rbnDescuento.Checked)
            {
                lblMostrarTotalDescuento.Text = Convert.ToString(DarFormato(Convert.ToDouble(lblMostratTotal.Text) * (int)nudPorcentaje.Value / 100));
            }

            lblMostrarTotalDescuento.Text = Convert.ToString(RedondearPrecio(Convert.ToDouble(lblMostrarTotalDescuento.Text)));
            lblMostrarTotalAumento.Text = Convert.ToString(RedondearPrecio(Convert.ToDouble(lblMostrarTotalAumento.Text)));
        }

        private void ChkRedondearPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedondearPrecio.Checked)
            {
                if (rbnAumento.Checked)
                {
                    lblMostrarTotalAumento.Text = Convert.ToString(RedondearPrecio(Convert.ToDouble(lblMostrarTotalAumento.Text)));
                }
                else if (rbnDescuento.Checked)
                {
                    lblMostrarTotalDescuento.Text = Convert.ToString(RedondearPrecio(Convert.ToDouble(lblMostrarTotalDescuento.Text)));
                }
            }
            else
            {
                if (rbnAumento.Checked)
                {
                    lblMostrarTotalAumento.Text = Convert.ToString(DarFormato(Convert.ToDouble(lblMostratTotal.Text) * (int)nudPorcentaje.Value / 100));
                }
                else if (rbnDescuento.Checked)
                {
                    lblMostrarTotalDescuento.Text = Convert.ToString(DarFormato(Convert.ToDouble(lblMostratTotal.Text) * (int)nudPorcentaje.Value / 100));
                }
            }
        }

        /// <summary>
        /// Quita las comas decimales al total que se descontara/aumentara, y redondea en 0 o 5 el resultado
        /// </summary>
        private double RedondearPrecio(double _Redondear)
        {
            if (chkRedondearPrecio.Checked && _Redondear % 5 != 0)
            {
                Math.Floor(_Redondear);
                _Redondear = (_Redondear + (5 - (_Redondear % 5)));
            }

            return _Redondear;
        }

        private double DarFormato(double _Numero) => Math.Round(_Numero, 2);

        private void BtnImprimirTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulosPedido.Rows.Count > 0)
                {
                    PtdImprimirTicket = new PrintDocument();

                    if (ClsComprobarEstadoImpresora.ComprobarEstadoImpresora(PtdImprimirTicket.PrinterSettings.PrinterName))
                    {
                        PtdImprimirTicket.PrintPage += PrintPageEventHandler;
                        PtdImprimirTicket.Print();
                    }

                    if (SoloMostrar) { Close(); }
                }
                else
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion($"No hay ningun articulo cargado en el pedido.", ClsColores.Blanco, 200, 300))
                    {
                        FormInformacion.ShowDialog();
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show($"Ocurrio un error al intentar imprimir el ticket: {Error.Message}", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void PrintPageEventHandler(object sender, PrintPageEventArgs e)
        {
            string InformacionDelError = string.Empty;

            string[,] DatosPedido = new string[dgvArticulosPedido.Rows.Count, 3];

            int TotalDeFilas = dgvArticulosPedido.Rows.Count;

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                DatosPedido[Indice, 0] = Convert.ToString(dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVResumenPedido.Articulo].Value);
                DatosPedido[Indice, 1] = Convert.ToString(dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVResumenPedido.Cantidad].Value);
                DatosPedido[Indice, 2] = Convert.ToString($"${Math.Round(Convert.ToDouble(dgvArticulosPedido.Rows[Indice].Cells[(int)ENumColDGVResumenPedido.Subtotal].Value), 2)}");
            }

            ClsImpresionTickets.TicketResumenPedido(ref e, ID_Pedido, EsDelivery, DatosPedido, rbnDescuento.Checked, rbnAumento.Checked, lblMostratTotal.Text, lblMostrarTotalAumento.Text, lblMostrarTotalDescuento.Text, Convert.ToString(nudPorcentaje.Value), ref InformacionDelError);
        
            if (InformacionDelError != string.Empty)
            {
                MessageBox.Show(InformacionDelError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCerrarPreCuenta_Click(object sender, EventArgs e) => Close();

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        #endregion
    }
}
