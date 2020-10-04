using Datos;
using Negocio;
using Negocio.Clases_de_apoyo;
using Procuratio.ClsDeApoyo;
using Procuratio.FrmsSecundarios.FrmsTemporales.FrmConfiguracion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Procuratio
{
    public partial class FrmConfiguracion : Form
    {
        #region Carga
        private FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            CargarConfiguracion();
            MostrarMenuVencimientos();
            ComprobarVencimeinto();

            FormularioCargado = true;
        }

        private void ComprobarVencimeinto()
        {
            string InformacionDelError = string.Empty;

            ClsConfiguraciones Configuraciones = new ClsConfiguraciones();
            Configuracion LeerConfiguracion = new Configuracion();
            LeerConfiguracion = Configuraciones.LeerPorNumero(1, ref InformacionDelError);

            if (LeerConfiguracion != null)
            {

                // No cambiarle el estado a los rbn si se bloquearon por vencimiento de licencia (el rbn PA siempre deberia estar acivado)
                if (!SeVencioLicencia)
                {
                    if (LeerConfiguracion.TrabajaConPlantaAlta == 0)
                    {
                        lblCantidadMesasPATexto.Visible = false;
                        lblCantidadMesasPA.Visible = false;
                        rbnPlantaBaja.Checked = true;
                        rbnPlantaAlta.Enabled = false;
                        ckbSegundaPlanta.Checked = false;
                    }
                    else
                    {
                        lblCantidadMesasPATexto.Visible = true;
                        lblCantidadMesasPA.Visible = true;
                        rbnPlantaBaja.Checked = true;
                        rbnPlantaAlta.Enabled = true;
                        ckbSegundaPlanta.Checked = true;
                    }
                }
            }
        }

        private void CargarConfiguracion()
        {
            string InformacionDelError = string.Empty;

            ClsConfiguraciones Configuraciones = new ClsConfiguraciones();
            Configuracion LeerConfiguracion = new Configuracion();
            LeerConfiguracion = Configuraciones.LeerPorNumero(1, ref InformacionDelError);

            if (LeerConfiguracion != null)
            {
                int CantidadDeMesasPB = ListarMesasActivasPB();
                int CantidadDeMesasPA = ListarMesasActivasPA();

                nudAvisoEspera.Value = LeerConfiguracion.AvisoEspera;
                nudTiempoVentanaAbierta.Value = LeerConfiguracion.TiempoFormAbierto;

                nudNumeroDeMesaEditar.Maximum = CantidadDeMesasPB;

                nudCantidadMesasAEliminar.Maximum = CantidadDeMesasPB - 1; // Preserva como minimo una mesa

                if (CantidadDeMesasPB != -1 && CantidadDeMesasPA != -1)
                {
                    lblCantidadMesasPB.Text = Convert.ToString(CantidadDeMesasPB);
                    lblCantidadMesasPA.Text = Convert.ToString(CantidadDeMesasPA);

                    // El proximo numero de mesa esta dado por la cantidad total de mesas (en este caso planta baja) aumentado
                    // en 1 (si cambia de planta a configurar se actualizara al de mesas de PA)
                    lblNumeroNuevaMesa.Text = Convert.ToString(CantidadDeMesasPB + 1);

                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Configuracion cargada correctamente";
                }
                else
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al intentar cargar el numero de mesas por planta");
                    BloquearBotonesPorError();
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar cargar la configuracion");
                BloquearBotonesPorError();
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar cargar la configuracion");
                BloquearBotonesPorError();
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarMenuVencimientos()
        {
            if (FrmInicioSesion.ObtenerInstancia().G_ID_PerfilUsuarioInicioSesion == (int)ClsPerfiles.EPerfiles.Administrador)
            {
                btnActualizarVencimientos.Enabled = true;
                btnActualizarVencimientos.Visible = true;
            }
        }

        /// <summary>
        /// Bloquea las funcionalidades si se vencio la licencia
        /// </summary>
        public void BloquearPorVencimientoLicencia(bool _LicenciaExpirada)
        {
            ckbSegundaPlanta.Enabled = !_LicenciaExpirada;
            rbnPlantaAlta.Enabled = !_LicenciaExpirada;
            rbnPlantaBaja.Enabled = !_LicenciaExpirada;
            nudAvisoEspera.Enabled = !_LicenciaExpirada;
            nudTiempoVentanaAbierta.Enabled = !_LicenciaExpirada;
            btnCrearMesa.Enabled = !_LicenciaExpirada;
            btnAplicarNuevaCapacidad.Enabled = !_LicenciaExpirada;
            btnEliminar.Enabled = !_LicenciaExpirada;
            btnGenerarCopiaDeSeguridad.Enabled = !_LicenciaExpirada;
            btnAdministrarUsuarios.Enabled = !_LicenciaExpirada;
            BtnEditarInformacionRestaurante.Enabled = !_LicenciaExpirada;

            SeVencioLicencia = _LicenciaExpirada;
        }
        #endregion

        #region Variables
        private static FrmConfiguracion InstanciaForm;

        private int Acumulador = 0;
        private bool Invertir = true;
        private bool SeVencioLicencia = false;
        private bool FormularioCargado = false;
        #endregion

        #region Codigo para darle estilo a los botones
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            if (BotonEnFoco.Name == btnEliminar.Name)
            {
                BotonEnFoco.BackColor = ClsColores.Rojo;
            }
            else if (BotonEnFoco.Name == btnGenerarCopiaDeSeguridad.Name)
            {
                BotonEnFoco.BackColor = ClsColores.NaranjaOscuro;
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

            picBTNInformacionVentanas.BackColor = Color.FromArgb(21 + Acumulador, 28 + Acumulador, 36 + Acumulador);
        }
        #endregion

        private void CkbSegundaPlanta_CheckedChanged(object sender, EventArgs e)
        {
            string InformacionDelError = string.Empty;

            ClsConfiguraciones Configuraciones = new ClsConfiguraciones();
            Configuracion ActualizarConfiguracion = new Configuracion();
            ActualizarConfiguracion = Configuraciones.LeerPorNumero(1, ref InformacionDelError);

            if (ckbSegundaPlanta.Checked)
            {
                ActualizarConfiguracion.TrabajaConPlantaAlta = 1;
            }
            else
            {
                ActualizarConfiguracion.TrabajaConPlantaAlta = 0;
            }

            InformacionDelError = string.Empty;

            if (Configuraciones.Actualizar(ActualizarConfiguracion, ref InformacionDelError) != 0)
            {
                if (ActualizarConfiguracion.TrabajaConPlantaAlta == 0)
                {
                    lblCantidadMesasPATexto.Visible = false;
                    lblCantidadMesasPA.Visible = false;
                    rbnPlantaBaja.Checked = true;
                    rbnPlantaAlta.Enabled = false;
                }
                else
                {
                    lblCantidadMesasPATexto.Visible = true;
                    lblCantidadMesasPA.Visible = true;
                    rbnPlantaBaja.Checked = true;
                    rbnPlantaAlta.Enabled = true;
                }

                FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Preferencia de planta actualizada";
            }
            else if (InformacionDelError != string.Empty)
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar actualizar la Preferencia de planta");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RbnPlantaBaja_CheckedChanged(object sender, EventArgs e)
        {
            lblNumeroNuevaMesa.Text = Convert.ToString(Convert.ToInt32(lblCantidadMesasPB.Text) + 1);

            nudNumeroDeMesaEditar.Minimum = 1;
            nudNumeroDeMesaEditar.Maximum = Convert.ToInt32(lblCantidadMesasPB.Text);
            nudNumeroDeMesaEditar.Value = 1;

            nudCantidadMesasAEliminar.Value = 0;
            nudCantidadMesasAEliminar.Maximum = Convert.ToInt32(lblCantidadMesasPB.Text) - 1;
        }

        private void RbnPlantaAlta_CheckedChanged(object sender, EventArgs e)
        {
            lblNumeroNuevaMesa.Text = Convert.ToString(Convert.ToInt32(lblCantidadMesasPA.Text) + 100);

            nudNumeroDeMesaEditar.Minimum = 100;
            nudNumeroDeMesaEditar.Maximum = Convert.ToInt32(lblCantidadMesasPA.Text) + 99;
            nudNumeroDeMesaEditar.Value = 100;

            nudCantidadMesasAEliminar.Value = 0;
            nudCantidadMesasAEliminar.Maximum = Convert.ToInt32(lblCantidadMesasPA.Text) - 1;
        }

        private void NudAvisoEspera_ValueChanged(object sender, EventArgs e)
        {
            if (FormularioCargado)
            {
                string InformacionDelError = string.Empty;

                ClsConfiguraciones Configuraciones = new ClsConfiguraciones();

                Configuracion ActualizarConfiguracion = new Configuracion();
                ActualizarConfiguracion = Configuraciones.LeerPorNumero(1, ref InformacionDelError);
                ActualizarConfiguracion.AvisoEspera = (int)nudAvisoEspera.Value;

                if (Configuraciones.Actualizar(ActualizarConfiguracion, ref InformacionDelError) != 0)
                {
                    FrmMesas.ObtenerInstancia().S_AvisoEspera = (int)nudAvisoEspera.Value;
                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Tiempo aviso espera actualizado";
                }
                else if (InformacionDelError != string.Empty)
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar actualizar el tiempo aviso espera");
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void NudTiempoVentanaAbierta_ValueChanged(object sender, EventArgs e)
        {
            if (FormularioCargado)
            {
                string InformacionDelError = string.Empty;

                ClsConfiguraciones Configuraciones = new ClsConfiguraciones();

                Configuracion ActualizarConfiguracion = new Configuracion();
                ActualizarConfiguracion = Configuraciones.LeerPorNumero(1, ref InformacionDelError);
                ActualizarConfiguracion.TiempoFormAbierto = (int)nudTiempoVentanaAbierta.Value;

                if (Configuraciones.Actualizar(ActualizarConfiguracion, ref InformacionDelError) != 0)
                {
                    FrmPrincipal.ObtenerInstancia().S_TiempoLimiteTranscurrido = (int)nudTiempoVentanaAbierta.Value;
                }
                else if (InformacionDelError != string.Empty)
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar actualizar el tiempo");
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnCrearMesa_Click(object sender, EventArgs e)
        {
            int MesasPlantaBaja = Convert.ToInt32(lblCantidadMesasPB.Text);

            // Entrar si la mesa que se va a crear es menor a 99 o la mesa que va a crear sera de la PA
            if (MesasPlantaBaja < 99 || rbnPlantaAlta.Checked)
            {
                string InformacionDelError = string.Empty;

                ClsMesas Mesas = new ClsMesas();
                Mesa BuscarMesaInactiva = new Mesa();

                if (rbnPlantaBaja.Checked)
                {
                    BuscarMesaInactiva = Mesas.LeerPorNumero(-1, ClsMesas.ETipoDeListado.PrimerMesaInactivaPB, ref InformacionDelError);
                }
                else
                {
                    BuscarMesaInactiva = Mesas.LeerPorNumero(-1, ClsMesas.ETipoDeListado.PrimerMesaInactivaPA, ref InformacionDelError);
                }

                if (BuscarMesaInactiva != null) //encontro una mesa ya creada para actualizarle el estado y la capacidad
                {
                    BuscarMesaInactiva.ID_EstadoMesa = (int)ClsEstadosMesas.EEstadosMesas.Activo_Disponible;
                    BuscarMesaInactiva.Capacidad = (int)nudCapacidadNuevaMesa.Value;

                    if (Mesas.Actualizar(BuscarMesaInactiva, ref InformacionDelError) != 0)
                    {
                        ActualizarControles();
                        FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Mesa creada correctamente";
                    }
                    else if (InformacionDelError != string.Empty)
                    {
                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al crear la mesa");
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (InformacionDelError == string.Empty) // No se encontro una mesa inactiva ni se genero una excepcion
                {                                             // crear la mesa
                    BuscarMesaInactiva = new Mesa();

                    BuscarMesaInactiva.Numero = Convert.ToInt32(lblNumeroNuevaMesa.Text);
                    BuscarMesaInactiva.ID_EstadoMesa = (int)ClsEstadosMesas.EEstadosMesas.Activo_Disponible;
                    BuscarMesaInactiva.Capacidad = (int)nudCapacidadNuevaMesa.Value;
                    BuscarMesaInactiva.ID_Usuario = 1;

                    if (Mesas.Crear(BuscarMesaInactiva, ref InformacionDelError) != 0)
                    {
                        ActualizarControles();
                        FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Mesa creada correctamente";
                    }
                    else if (InformacionDelError == string.Empty)
                    {
                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al crear la mesa");
                    }
                    else
                    {
                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al crear la mesa");
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al crear la mesa");
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Alcanzo el limite de mesas en la PB";
            }
        }

        private void BtnAplicarNuevaCapacidad_Click(object sender, EventArgs e)
        {
            // TODO - Cambiar la capacidad de una mesa
            string InformacionDelError = string.Empty;

            ClsMesas Mesas = new ClsMesas();
            Mesa EditarCapacidadMesa = new Mesa();

            EditarCapacidadMesa = Mesas.LeerPorNumero((int)nudNumeroDeMesaEditar.Value, ClsMesas.ETipoDeListado.PorNumeroDeMesa, ref InformacionDelError);

            if (EditarCapacidadMesa != null)
            {
                if (EditarCapacidadMesa.Capacidad != (int)nudNuevaCapacidad.Value)
                {
                    EditarCapacidadMesa.Capacidad = (int)nudNuevaCapacidad.Value;

                    if (Mesas.Actualizar(EditarCapacidadMesa, ref InformacionDelError) != 0)
                    {
                        FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Capacidad de la mesa actualizada";
                    }
                    else if (InformacionDelError == string.Empty)
                    {
                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al actualizar la capacidad de la mesa");
                    }
                    else
                    {
                        FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al actualizar la capacidad de la mesa");
                        MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Seleccione una nueva capacidad";
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al buscar la mesa a editar");
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al buscar la mesa a editar");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (nudCantidadMesasAEliminar.Value > 0)
            {
                string InformacionDelError = string.Empty;

                ClsMesas Mesas = new ClsMesas();

                List<Mesa> MesasActivas;

                MesasActivas = Mesas.LeerListado(ClsMesas.ETipoDeListado.MesasOcupadas, ref InformacionDelError);

                if (MesasActivas != null)
                {
                    if (MesasActivas.Count == 0)
                    {
                        MesasActivas = null;

                        if (rbnPlantaBaja.Checked)
                        {
                            MesasActivas = Mesas.LeerListado(ClsMesas.ETipoDeListado.MesasActivasPB, ref InformacionDelError);
                        }
                        else
                        {
                            MesasActivas = Mesas.LeerListado(ClsMesas.ETipoDeListado.MesasActivasPA, ref InformacionDelError);
                        }

                        if (MesasActivas != null)
                        {
                            MesasActivas.Reverse();

                            int Contador = 0;

                            foreach (Mesa Elemento in MesasActivas)
                            {
                                Elemento.ID_EstadoMesa = (int)ClsEstadosMesas.EEstadosMesas.Inactivo;

                                if (Mesas.Actualizar(Elemento, ref InformacionDelError) != 0)
                                {
                                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Mesa/s eliminada/s";
                                }
                                else if (InformacionDelError == string.Empty)
                                {
                                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar eliminar la mesa");
                                    MessageBox.Show("Error al intentar eliminar la mesa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar eliminar la mesa");
                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                                Contador++;

                                if (Contador == nudCantidadMesasAEliminar.Value) { break; }
                            }

                            // Actualizo los NUD con los nuevos valores
                            ActualizarControles();

                            FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Mesa/s eliminada/s";
                        }
                        else if (InformacionDelError == string.Empty)
                        {
                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar eliminar la mesa");
                        }
                        else
                        {
                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar eliminar la mesa");
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        using (FrmInformacion FormInformacion = new FrmInformacion($"No puede eliminar mesas, el sistema se detectó que hay en uso actualmente para pedidos. Finalize " +
                                $"los mismo e intente nuevamente.", ClsColores.Blanco, 250, 300))
                        {
                            FormInformacion.ShowDialog();
                        }
                    }
                }
                else if (InformacionDelError != string.Empty)
                {
                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar eliminar la mesa");
                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void BtnVerMesasDisponibles_Click(object sender, EventArgs e)
        {
            using (FrmsSecundarios.FrmsTemporales.FrmListarMesas FormListarMesas = new FrmsSecundarios.FrmsTemporales.FrmListarMesas(false))
            {
                FormListarMesas.ShowDialog();
            }
        }

        public void BtnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            using (FrmAdministrarUsuarios FormAdministraUsuarios = new FrmAdministrarUsuarios())
            {
                FormAdministraUsuarios.ShowDialog();
            }
        }

        /// <summary>
        /// Busca las mesas pertenecientes a la planta baja, que estan en estado activo
        /// </summary>
        /// <returns>Cantidad de mesas que esten activas.</returns>
        private int ListarMesasActivasPB()
        {
            string InformacionDelError = string.Empty;

            ClsMesas Mesas = new ClsMesas();

            List<Mesa> ListarMesasPB = Mesas.LeerListado(ClsMesas.ETipoDeListado.MesasActivasPB, ref InformacionDelError);

            if (ListarMesasPB != null)
            {
                return ListarMesasPB.Count;
            }
            else if (InformacionDelError != string.Empty)
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar calcular las mesas de la PB");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return -1;
        }

        /// <summary>
        /// Busca las mesas pertenecientes a la planta alta, que estan en estado activo.
        /// </summary>
        /// <returns>Cantidad de mesas que esten activas.</returns>
        private int ListarMesasActivasPA()
        {
            string InformacionDelError = string.Empty;

            ClsMesas Mesas = new ClsMesas();

            List<Mesa> ListarMesasPA = Mesas.LeerListado(ClsMesas.ETipoDeListado.MesasActivasPA, ref InformacionDelError);

            if (ListarMesasPA != null)
            {
                return ListarMesasPA.Count;
            }
            else if (InformacionDelError != string.Empty)
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar calcular las mesas de la PA");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return -1;
        }

        /// <summary>
        ///  Actualiza los controles al crear o eliminar mesas.
        /// </summary>
        private void ActualizarControles()
        {
            if (rbnPlantaBaja.Checked)
            {
                int CantidadDeMesasPB = ListarMesasActivasPB();

                if (CantidadDeMesasPB != -1)
                {
                    lblCantidadMesasPB.Text = Convert.ToString(CantidadDeMesasPB);

                    lblNumeroNuevaMesa.Text = Convert.ToString(CantidadDeMesasPB + 1);

                    nudNumeroDeMesaEditar.Minimum = 1;
                    nudNumeroDeMesaEditar.Maximum = CantidadDeMesasPB;
                    nudNumeroDeMesaEditar.Value = 1;

                    nudCantidadMesasAEliminar.Value = 0;
                    nudCantidadMesasAEliminar.Maximum = CantidadDeMesasPB - 1;
                }
                else
                {
                    BloquearBotonesPorError();
                }
            }
            else
            {
                int CantidadDeMesasPA = ListarMesasActivasPA();

                if (CantidadDeMesasPA != -1)
                {
                    lblCantidadMesasPA.Text = Convert.ToString(CantidadDeMesasPA);

                    lblNumeroNuevaMesa.Text = Convert.ToString(CantidadDeMesasPA + 100);

                    nudNumeroDeMesaEditar.Minimum = 100;
                    nudNumeroDeMesaEditar.Maximum = CantidadDeMesasPA + 99;
                    nudNumeroDeMesaEditar.Value = 100;

                    nudCantidadMesasAEliminar.Value = 0;
                    nudCantidadMesasAEliminar.Maximum = CantidadDeMesasPA - 1;
                }
                else
                {
                    BloquearBotonesPorError();
                }
            }
        }

        /// <summary>
        /// Bloquea los botones relacionados con las mesas en caso de ocurrir un error.
        /// </summary>
        private void BloquearBotonesPorError()
        {
            btnCrearMesa.Enabled = false;
            btnAplicarNuevaCapacidad.Enabled = false;
            btnEliminar.Enabled = false;
        }

        public void BtnEditarInformacionRestaurante_Click(object sender, EventArgs e)
        {
            using (FrmInformacionRestaurante FormInformacionDelRestaurante = new FrmInformacionRestaurante())
            {
                FormInformacionDelRestaurante.ShowDialog();
            }
        }

        public void BtnGenerarCopiaDeSeguridad_Click(object sender, EventArgs e)
        {
            using (FrmValidarUsuario FormValidarUsuario = new FrmValidarUsuario(FrmValidarUsuario.EFiltroUsuariosAutorizados.Gerentes))
            {
                FormValidarUsuario.ShowDialog();

                if (FormValidarUsuario.DialogResult == DialogResult.OK)
                {
                    using (FrmRutaBackUp FormRutaBackUp = new FrmRutaBackUp())
                    {
                        string InformacionDelError = string.Empty;
                        bool CreacionCancelada = false;

                        string Ruta = ClsGenerarBackUps.GenerarBackUp(ref CreacionCancelada, ref InformacionDelError);

                        if (Ruta != string.Empty && InformacionDelError == string.Empty && !CreacionCancelada)
                        {
                            FormRutaBackUp.S_Ruta = Ruta;
                            FormRutaBackUp.ShowDialog();
                        }
                        else if (InformacionDelError != string.Empty)
                        {
                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un error al intentar generar la copia de seguridad");
                            MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!CreacionCancelada)
                        {
                            FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un error al intentar generar la copia de seguridad");
                            MessageBox.Show($"Ocurrio un error al intentar generar la copia de seguridad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void BtnTicketDePrueba_Click(object sender, EventArgs e)
        {
            PtdImprimirTicket = new PrintDocument();

            if (ClsComprobarEstadoImpresora.ComprobarEstadoImpresora(PtdImprimirTicket.PrinterSettings.PrinterName))
            {
                PtdImprimirTicket.PrintPage += PrintPageEventHandler;
                PtdImprimirTicket.Print();
            }
        }

        private void PrintPageEventHandler(object sender, PrintPageEventArgs e)
        {
            string InformacionDelError = string.Empty;

            ClsImpresionTickets.TicketDePrueba(ref e, ref InformacionDelError);

            if (InformacionDelError != string.Empty)
            {
                MessageBox.Show(InformacionDelError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Ocurrio un error al intentar impimir el ticket");
            }
        }

        private void BtnActualizarVencimientos_Click(object sender, EventArgs e)
        {
            using (FrmVencFunc VencimientosFuncionalidades = new FrmVencFunc())
            {
                VencimientosFuncionalidades.ShowDialog();
            }
        }

        private void PicBTNInformacionVentanas_Click(object sender, EventArgs e)
        {
            using (FrmInformacion FormInformacion = new FrmInformacion("Las ventanas en las que se aplicara esto (carta, caja, y configuracion), " +
                    "son consideradas importantes debido a la informacion que brindan y manejan, por lo que se requiere el acceso de un tipo de " +
                    "usuario en especifico para evitar una mala gestion de las partes escenciales del programa.\r\n\r\nPasado el tiempo " +
                    "asignado, se ocultara la ventana, para de esta forma forzar a que tenga que validar su usuario nuevamente y comprobar " +
                    "que tiene el perfil requerido.", ClsColores.Blanco, 300, 450))
            {
                FormInformacion.ShowDialog();
            }
        }

        /// <summary>
        /// Devuelve una unica instancia del formulario (Patron singleton)
        /// </summary>
        /// <returns></returns>
        public static FrmConfiguracion ObtenerInstancia()
        {
            if (InstanciaForm == null) { InstanciaForm = new FrmConfiguracion(); }

            return InstanciaForm;
        }

        #region Propiedades
        #endregion
    }
}
