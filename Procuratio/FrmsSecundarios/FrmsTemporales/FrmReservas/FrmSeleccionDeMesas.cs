using Datos;
using Negocio;
using Procuratio.ClsDeApoyo;
using Procuratio.FrmGenerales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Procuratio
{
    public partial class FrmSeleccionDeMesas : Form
    {
        #region Codigo de carga
        /// <summary>
        /// Instancia del formulario.
        /// </summary>
        /// <param name="_ID_Reserva">ID de la reserva.</param>
        /// <param name="_TotalPersonas">Cantidad dee personas que reservaran.</param>
        /// <param name="_FechaParaReservar">Fecha a reservar.</param>
        /// <param name="_FormAdministrarReservas">Formulario que solicita las mesas a reservar.</param>
        public FrmSeleccionDeMesas(int _ID_Reserva, int _TotalPersonas, DateTime _FechaParaReservar, FrmAdministrarReserva _FormAdministrarReservas)
        {
            InitializeComponent();

            ID_Reserva = _ID_Reserva;
            TotalPersonas = _TotalPersonas;
            FechaParaReservar = _FechaParaReservar;
            FormAdministrarReservas = _FormAdministrarReservas;
        }

        private void FrmSeleccionDeMesas_Load(object sender, EventArgs e)
        {
            // TODO - Cargar la seleccion de mesa en funcion de las mesas disponibles para reservar (marcar RBN PB y ocultar
            // GPB si selecciono que trabaja con PB)
            HabilitarPA();
            CargarDGVMesasDisponibles(ClsMesasXReservas.EMesasDisponibles.MesasDisponiblesPB);
            lblResultadoCantidadPersonas.Text = Convert.ToString(TotalPersonas);
        }

        /// <summary>Bloquea el RadioButton de la planta alta si indico desde configuracion que no trabajara con la misma.</summary>
        private void HabilitarPA()
        {
            string InformacionDelError = string.Empty;

            ClsConfiguraciones Configuraciones = new ClsConfiguraciones();
            Configuracion HabilitarPA = Configuraciones.LeerPorNumero(1, ref InformacionDelError);

            if (HabilitarPA != null)
            {
                if (HabilitarPA.TrabajaConPlantaAlta == 0) { rbnPlantaAlta.Enabled = false; }
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
        #endregion

        #region Variables
        /// <summary>
        /// Enumera las columnas del DGV para poder ubicarlas y editar mas facilmente su posicion.
        /// </summary>
        private enum ENumColDGVMesa
        {
            ID_Mesa, Numero, Capacidad, Seleccionar
        }

        FrmAdministrarReserva FormAdministrarReservas = null;
        private DateTime FechaParaReservar;
        private List<int> ListaDeMesasReserva = new List<int>();
        List<int> Numeracion = new List<int>();
        private int Acumulador = 0;
        private bool Invertir = true;
        private int TotalPersonas = 0;
        private int ID_Reserva = -1;
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
            if (rbnPlantaBaja.Checked) { CargarDGVMesasDisponibles(ClsMesasXReservas.EMesasDisponibles.MesasDisponiblesPB); }
        }

        private void RbnPlantaAlta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnPlantaAlta.Checked) { CargarDGVMesasDisponibles(ClsMesasXReservas.EMesasDisponibles.MesasDisponiblesPA); }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ListaDeMesasReserva.Clear();
            Numeracion.Clear();
            int TotalDeFilas = dgvSeleccionarMesaReserva.Rows.Count;

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                //Pregunto si la celda es diferente a null
                if (dgvSeleccionarMesaReserva.Rows[Indice].Cells[(int)ENumColDGVMesa.Seleccionar].Value != null)
                {
                    //Casteo el check del objeto a booleano y pregunto si es true
                    if ((bool)dgvSeleccionarMesaReserva.Rows[Indice].Cells[(int)ENumColDGVMesa.Seleccionar].Value)
                    {
                        ListaDeMesasReserva.Add((int)dgvSeleccionarMesaReserva.Rows[Indice].Cells[(int)ENumColDGVMesa.ID_Mesa].Value);
                        Numeracion.Add((int)dgvSeleccionarMesaReserva.Rows[Indice].Cells[(int)ENumColDGVMesa.Numero].Value);
                    }
                }
            }

            if (ListaDeMesasReserva.Count > 0)
            {
                if (ListaDeMesasReserva.Count <= 12)
                {
                    FrmRespuesta RespuestaFormulario;

                    if (Convert.ToInt32(lblResultadoCantidadPersonas.Text) > Convert.ToInt32(lblResultadoCapacidadTotal.Text))
                    {
                        RespuestaFormulario = new FrmRespuesta($"¿Esta seguro que desea crear la reserva con una capacidad menor a la del total de " +
                            "clientes?", FrmRespuesta.ETamaño.Pequeño, FrmRespuesta.ETipo.Si_No);
                    }
                    else
                    {
                        RespuestaFormulario = new FrmRespuesta();
                    }

                    if (RespuestaFormulario.DialogResult == DialogResult.Yes)
                    {
                        FormAdministrarReservas.S_ListaDeMesasReserva = ListaDeMesasReserva;
                        FormAdministrarReservas.S_Numeracion = Numeracion;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    using (FrmInformacion FormInformacion = new FrmInformacion("El maximo de mesas permitidas es 12.", ClsColores.Blanco, 150, 300))
                    {
                        FormInformacion.ShowDialog();
                    }
                }
            }
            else
            {
                using (FrmInformacion FormInformacion = new FrmInformacion("Debe seleccionar como minimo una mesa para crear la reserva.", ClsColores.Blanco, 150, 300))
                {
                    FormInformacion.ShowDialog();
                }
            }
        }

        private void CargarDGVMesasDisponibles(ClsMesasXReservas.EMesasDisponibles _TipoDeFiltro)
        {
            dgvSeleccionarMesaReserva.Rows.Clear();

            lblResultadoCapacidadTotal.Text = "0";

            string InformacionDelError = string.Empty;

            ClsMesasXReservas MesasXReservas = new ClsMesasXReservas();
            List<MesaXReserva> ListaMesasReservadas = MesasXReservas.LeerListado(_TipoDeFiltro, ref InformacionDelError, FechaParaReservar.Date);

            ClsMesas Mesas = new ClsMesas();
            List<Mesa> MesasDisponibles = null;

            // Trae la lista por planta
            if (_TipoDeFiltro == ClsMesasXReservas.EMesasDisponibles.MesasDisponiblesPB)
            {
                MesasDisponibles = Mesas.LeerListado(ClsMesas.ETipoDeListado.MesasActivasPB, ref InformacionDelError);
            }
            else
            {
                MesasDisponibles = Mesas.LeerListado(ClsMesas.ETipoDeListado.MesasActivasPA, ref InformacionDelError);
            }

            if (MesasDisponibles != null && ListaMesasReservadas != null)
            {
                // Recorro todas las mesas activas
                foreach (Mesa Elemento in MesasDisponibles)
                {
                    bool MesaNoReservada = true;

                    // Elimino de la lista las mesas que encuentre en la lista de las reservadas
                    foreach (MesaXReserva ElementoSecundario in ListaMesasReservadas)
                    {
                        if (Elemento.ID_Mesa == ElementoSecundario.ID_Mesa && ElementoSecundario.ID_Reserva != ID_Reserva)
                        {
                            MesaNoReservada = false;
                        }
                    }

                    if (MesaNoReservada)
                    {
                        bool MarcarMesaReservada = false;
                        int NumeroDeFila = dgvSeleccionarMesaReserva.Rows.Add();

                        dgvSeleccionarMesaReserva.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.ID_Mesa].Value = Elemento.ID_Mesa;
                        dgvSeleccionarMesaReserva.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.Numero].Value = Elemento.Numero;
                        dgvSeleccionarMesaReserva.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.Capacidad].Value = Elemento.Capacidad;

                        // Marca las mesas ya reservadas al editar una reserva
                        foreach (MesaXReserva ElementoSecundario in ListaMesasReservadas)
                        {
                            if (Elemento.ID_Mesa == ElementoSecundario.ID_Mesa)
                            {
                                MarcarMesaReservada = true;
                                lblResultadoCapacidadTotal.Text = Convert.ToString(Convert.ToInt32(lblResultadoCapacidadTotal.Text) + Elemento.Capacidad);
                            }
                        }

                        dgvSeleccionarMesaReserva.Rows[NumeroDeFila].Cells[(int)ENumColDGVMesa.Seleccionar].Value = MarcarMesaReservada;

                        if (MarcarMesaReservada)
                        {
                            ClsColores.MarcarFilaDGV(dgvSeleccionarMesaReserva, NumeroDeFila, true);
                        }
                        else
                        {
                            ClsColores.MarcarFilaDGV(dgvSeleccionarMesaReserva, NumeroDeFila, false);
                        }
                    }
                }

                UltimaFilaSeleccionada = -1;

                dgvSeleccionarMesaReserva.Sort(dgvSeleccionarMesaReserva.Columns[(int)ENumColDGVMesa.Numero], ListSortDirection.Ascending);
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show($"Ocurrio un fallo al cargar las mesas reservadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvSeleccionarMesaReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DetectarCheck = (DataGridView)sender;

            if (DetectarCheck.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                int TotalDeFilas = dgvSeleccionarMesaReserva.Rows.Count;
                int CapacidadTotal = 0;

                // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                if (dgvSeleccionarMesaReserva.Rows[e.RowIndex].Cells[(int)ENumColDGVMesa.Seleccionar].Value != null)
                {
                    if (!(bool)dgvSeleccionarMesaReserva.Rows[e.RowIndex].Cells[(int)ENumColDGVMesa.Seleccionar].Value && e.RowIndex != UltimaFilaSeleccionada)
                    {
                        ClsColores.MarcarFilaDGV(dgvSeleccionarMesaReserva, e.RowIndex, true);
                    }
                    else
                    {
                        ClsColores.MarcarFilaDGV(dgvSeleccionarMesaReserva, e.RowIndex, false);
                    }
                }

                dgvSeleccionarMesaReserva.ClearSelection();
                UltimaFilaSeleccionada = e.RowIndex;

                if (dgvSeleccionarMesaReserva.EndEdit())
                {
                    for (int Indice = 0; Indice < TotalDeFilas; Indice++)
                    {
                        //Pregunto si la celda es diferente a null
                        if (dgvSeleccionarMesaReserva.Rows[Indice].Cells[(int)ENumColDGVMesa.Seleccionar].Value != null)
                        {
                            //Casteo el check del objeto a booleano y pregunto si es true
                            if ((bool)dgvSeleccionarMesaReserva.Rows[Indice].Cells[(int)ENumColDGVMesa.Seleccionar].Value)
                            {
                                CapacidadTotal += (int)dgvSeleccionarMesaReserva.Rows[Indice].Cells[(int)ENumColDGVMesa.Capacidad].Value;
                            }
                        }
                    }

                    lblResultadoCapacidadTotal.Text = Convert.ToString(CapacidadTotal);
                }
            }
        }

        private void PicBTNInformacion_Click(object sender, EventArgs e)
        {
            using (FrmInformacion FormInformacion = new FrmInformacion($"Seleccione las mesas que se usaran para la reserva. Puede seleccionar mesas con una capacidad " +
                    $"menor a la del total de clientes que asistiran, solo se le advertira, pero debe seleccionar como minimo una mesa para " +
                    $"asignarle a la reserva.", ClsColores.Blanco, 300, 300))
            {
                FormInformacion.ShowDialog();
            }
        }

        private void picBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        #endregion
    }
}
