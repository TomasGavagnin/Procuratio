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
using Procuratio.FrmsSecundarios.FrmsTemporales.FrmCaja;
using Procuratio.ClsDeApoyo;

namespace Procuratio
{
    public partial class FrmAgregarRegistro : Form
    {
        #region Carga
        public FrmAgregarRegistro()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        private int ID_Registro = -1;
        private int Acumulador = 0;
        private bool Invertir = true;
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

        private void SeleccionarRegistro_Click(object sender, EventArgs e)
        {
            using (FrmSeleccionarRegistro FormSeleccionarRegistros = new FrmSeleccionarRegistro())
            {
                FormSeleccionarRegistros.ShowDialog();

                if (FormSeleccionarRegistros.DialogResult == DialogResult.OK)
                {
                    txtMonto.Text = string.Empty;
                    txtDetalle.Text = string.Empty;
                    txtNombreRegistro.Visible = true;
                    pnlDecorativo3.Visible = true;
                    txtTipo.Visible = true;
                    pnlDecorativo5.Visible = true;

                    ID_Registro = FormSeleccionarRegistros.G_ID_Registro;

                    string InformacionDelError = string.Empty;

                    ClsTiposDeMontos TipoDeMontos = new ClsTiposDeMontos();
                    TipoDeMonto CargarMonto = TipoDeMontos.LeerPorNumero(ID_Registro, ref InformacionDelError);

                    if (CargarMonto != null)
                    {
                        txtNombreRegistro.Text = CargarMonto.Nombre;
                        txtTipo.Text = CargarMonto.TipoDeMovimiento.Nombre;
                    }
                    else if (InformacionDelError == string.Empty)
                    {
                        MessageBox.Show($"Ocurrio un fallo al cargar el monto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                    }
                }
            }
        }

        private void TxtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) || (txtMonto.Text == string.Empty && (e.KeyChar == 48 || e.KeyChar == 44)))
            {
                e.Handled = true;
            }

            if (txtMonto.Text.Contains(",") && e.KeyChar == 44) { e.Handled = true; }

            if (e.KeyChar == 13)
            {
                txtDetalle.Select();
                e.Handled = true;
            }
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32 || (txtDetalle.Text == string.Empty && e.KeyChar == 32)) { e.Handled = true; }
        }

        private void TxtMonto_TextChanged(object sender, EventArgs e) => txtMonto.Text = txtMonto.Text.TrimStart('0');

        private void BtnAgregarRegistro_Click(object sender, EventArgs e)
        {
            txtDetalle.Text = txtDetalle.Text.Trim();
            
            if (ID_Registro != -1 && txtMonto.Text != string.Empty && txtMonto.Text.Substring(0,1) != "," && txtMonto.Text.Substring(txtMonto.Text.Length - 1, 1) != ",")
            {
                using (FrmValidarUsuario FormValidarUsuario = new FrmValidarUsuario(FrmValidarUsuario.EFiltroUsuariosAutorizados.GerentesSubGerentes))
                {
                    FormValidarUsuario.ShowDialog();

                    if (FormValidarUsuario.DialogResult == DialogResult.OK)
                    {
                        if (txtDetalle.Text != string.Empty)
                        {
                            txtDetalle.Text = txtDetalle.Text.Substring(0, 1).ToUpper() + txtDetalle.Text.Remove(0, 1).ToLower();
                        }

                        string InformacionDelError = string.Empty;

                        ClsCajas Cajas = new ClsCajas();
                        Caja CrearRegistro = new Caja();

                        CrearRegistro.Fecha = DateTime.Today.Date;
                        CrearRegistro.Hora = TimeSpan.Parse(DateTime.Now.ToString(@"HH\:mm\:ss"));
                        CrearRegistro.Monto = Convert.ToDouble(txtMonto.Text);
                        CrearRegistro.Detalle = txtDetalle.Text;
                        CrearRegistro.ID_TipoDeMonto = ID_Registro;
                        CrearRegistro.ID_Pedido = null;

                        if (ID_Registro == (int)ClsTiposDeMontos.ETiposDeMontos.AperturaCaja)
                        {
                            CrearRegistro.ID_EstadoCaja = (int)ClsEstadosCajas.EEstadosCajas.CajaAbierta;
                        }
                        else
                        {
                            CrearRegistro.ID_EstadoCaja = (int)ClsEstadosCajas.EEstadosCajas.Activo;
                        }

                        CrearRegistro.ID_Usuario = FormValidarUsuario.G_ID_UsuarioQueValido;

                        if (Cajas.Crear(CrearRegistro, ref InformacionDelError) != 0)
                        {
                            if (CrearRegistro.ID_TipoDeMonto == (int)ClsTiposDeMontos.ETiposDeMontos.CierreCaja)
                            {
                                List<Caja> BuscarRegistroCajaAbierta = Cajas.LeerListado(ClsCajas.ETipoListado.CajaAbierta, ref InformacionDelError);

                                if (BuscarRegistroCajaAbierta != null)
                                {
                                    foreach (Caja Elemento in BuscarRegistroCajaAbierta)
                                    {
                                        Elemento.ID_EstadoCaja = (int)ClsEstadosCajas.EEstadosCajas.Activo;

                                        Cajas.Actualizar(Elemento, ref InformacionDelError);
                                    }
                                }
                                else if (InformacionDelError == string.Empty)
                                {
                                    MessageBox.Show("Fallo al listar los montos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }

                            DialogResult = DialogResult.OK;
                            Close();
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
                }
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion($"Debe cargar un registro con su monto correspondiente (verifique también que no tenga la " +
                    "coma del centavo al principio o al final).", ClsColores.Blanco, 250, 300))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        private void PicBTNInformacion_Click(object sender, EventArgs e)
        {
            using (FrmInformacion FormInformacion = new FrmInformacion($"Seleccione el boton [Buscar movimiento] para abrir la ventana que mostrara " +
                    $"todas las cuentas disponibles. Posteriormente seleccione en algunas de estas el boton [Enviar] para " +
                    $"que esta sea cargada en esta ventana.\r\n\r\nSi no encuentra el registro de 'Apertura de caja', significara que el programa " +
                    $"esta esperando el registro 'Cierre de caja'. Si el caso es el contrario, el programa estara esperando la creacion del " +
                    $"registro 'Apertura de caja'.\r\n\r\nSi en algun momento considera que hubo un error y desea corregir ese monto o movimiento mal especificado, " +
                    $"puede usar los movimientos de 'Cuenta de ajuste (ingreso)' o 'Cuenta de ajuste (egreso)'.", ClsColores.Blanco, 350, 500))
            {
                FormInformacion.ShowDialog();
            }
        }
    }
}
