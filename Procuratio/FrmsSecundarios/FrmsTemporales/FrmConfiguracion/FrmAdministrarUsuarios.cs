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
using Procuratio.ClsDeApoyo;

namespace Procuratio
{
    public partial class FrmAdministrarUsuarios : Form
    {
        #region Carga
        public FrmAdministrarUsuarios()
        {
            InitializeComponent();
        }

        private void FrmAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            CargarDGVUsuarios(ClsUsuarios.ETipoListado.UsuariosActivos);
        }
        #endregion

        #region Variables
        private enum ENumColDGVUsuarios
        {
            ID_Usuario, Nick, Nombre, Apellido, Perfil, Seleccionar
        }

        private int Acumulador = 0;
        private bool Invertir = true;
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
            
            if (BotonEnFoco.Name == btnEliminarUsuarios.Name)
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

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            using (FrmUsuario FormCrearUsuario = new FrmUsuario())
            {
                FormCrearUsuario.ShowDialog();

                if (FormCrearUsuario.DialogResult == DialogResult.OK)
                {
                    string InformacionDelError = string.Empty;

                    ClsUsuarios Usuarios = new ClsUsuarios();
                    Usuario AgregarNuevoUsuario = new Usuario();

                    AgregarNuevoUsuario = Usuarios.LeerPorNumero(-1, ClsUsuarios.EUsuarioABuscar.UltimoAgregardo, ref InformacionDelError);

                    if (AgregarNuevoUsuario != null)
                    {
                        int NumeroDeFila = dgvDatosUsuarios.Rows.Add();

                        dgvDatosUsuarios.Rows[NumeroDeFila].Cells[(int)ENumColDGVUsuarios.ID_Usuario].Value = AgregarNuevoUsuario.ID_Usuario;
                        dgvDatosUsuarios.Rows[NumeroDeFila].Cells[(int)ENumColDGVUsuarios.Nick].Value = AgregarNuevoUsuario.Nick;
                        dgvDatosUsuarios.Rows[NumeroDeFila].Cells[(int)ENumColDGVUsuarios.Nombre].Value = AgregarNuevoUsuario.Nombre;
                        dgvDatosUsuarios.Rows[NumeroDeFila].Cells[(int)ENumColDGVUsuarios.Apellido].Value = AgregarNuevoUsuario.Apellido;
                        dgvDatosUsuarios.Rows[NumeroDeFila].Cells[(int)ENumColDGVUsuarios.Perfil].Value = AgregarNuevoUsuario.Perfil.Nombre;
                        dgvDatosUsuarios.Rows[NumeroDeFila].Cells[(int)ENumColDGVUsuarios.Seleccionar].Value = false;

                        dgvDatosUsuarios.Sort(dgvDatosUsuarios.Columns[(int)ENumColDGVUsuarios.Perfil], ListSortDirection.Descending);
                    }
                }
            }
        }

        private void dgvDatosUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                // invierto el estado del check seleccionado debido a que no se actualiza en el momento de marcarlo.
                if (dgvDatosUsuarios.Rows[e.RowIndex].Cells[(int)ENumColDGVUsuarios.Seleccionar].Value != null)
                {
                    if (!(bool)dgvDatosUsuarios.Rows[e.RowIndex].Cells[(int)ENumColDGVUsuarios.Seleccionar].Value && e.RowIndex != UltimaFilaSeleccionada)
                    {
                        ClsColores.MarcarFilaDGV(dgvDatosUsuarios, e.RowIndex, true);
                    }
                    else
                    {
                        ClsColores.MarcarFilaDGV(dgvDatosUsuarios, e.RowIndex, false);
                    }
                }

                UltimaFilaSeleccionada = e.RowIndex;
            }
        }

        private void DgvDatosUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView DetectarTipoCasilla = (DataGridView)sender;

            if (e.RowIndex != -1 && !(DetectarTipoCasilla.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn))
            {
                using (FrmValidarUsuario VerificarDueñoUsuario = new FrmValidarUsuario((int)dgvDatosUsuarios.Rows[e.RowIndex].Cells[(int)ENumColDGVUsuarios.ID_Usuario].Value))
                {
                    if (FrmInicioSesion.ObtenerInstancia().G_ID_UsuarioInicioSesion != (int)ClsPerfiles.EPerfiles.Administrador)
                    {
                        VerificarDueñoUsuario.ShowDialog();
                    }
                    else
                    {
                        VerificarDueñoUsuario.DialogResult = DialogResult.OK;
                    }

                    if (VerificarDueñoUsuario.DialogResult == DialogResult.OK)
                    {
                        using (FrmUsuario FormCargarUsuario = new FrmUsuario((int)dgvDatosUsuarios.Rows[e.RowIndex].Cells[(int)ENumColDGVUsuarios.ID_Usuario].Value, rbnUsuariosActivos.Checked))
                        {
                            FormCargarUsuario.ShowDialog();

                            if (FormCargarUsuario.DialogResult == DialogResult.OK)
                            {
                                string InformacionDelError = string.Empty;

                                ClsUsuarios Usuarios = new ClsUsuarios();
                                Usuario ActualizarEdicion = new Usuario();

                                ActualizarEdicion = Usuarios.LeerPorNumero((int)dgvDatosUsuarios.Rows[e.RowIndex].Cells[(int)ENumColDGVUsuarios.ID_Usuario].Value, ClsUsuarios.EUsuarioABuscar.PorID, ref InformacionDelError);

                                if (ActualizarEdicion != null)
                                {
                                    dgvDatosUsuarios.Rows[e.RowIndex].Cells[(int)ENumColDGVUsuarios.ID_Usuario].Value = ActualizarEdicion.ID_Usuario;
                                    dgvDatosUsuarios.Rows[e.RowIndex].Cells[(int)ENumColDGVUsuarios.Nick].Value = ActualizarEdicion.Nick;
                                    dgvDatosUsuarios.Rows[e.RowIndex].Cells[(int)ENumColDGVUsuarios.Nombre].Value = ActualizarEdicion.Nombre;
                                    dgvDatosUsuarios.Rows[e.RowIndex].Cells[(int)ENumColDGVUsuarios.Apellido].Value = ActualizarEdicion.Apellido;
                                    dgvDatosUsuarios.Rows[e.RowIndex].Cells[(int)ENumColDGVUsuarios.Perfil].Value = ActualizarEdicion.Perfil.Nombre;

                                    dgvDatosUsuarios.Sort(dgvDatosUsuarios.Columns[(int)ENumColDGVUsuarios.Perfil], ListSortDirection.Descending);
                                }
                                else
                                {
                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                                UltimaFilaSeleccionada = -1;
                            }
                        }
                    }
                }
            }
        }

        private void BtnRestaurarUsuario_Click(object sender, EventArgs e) => ActualizarEstadoUsuario(ClsEstadosUsuarios.EEstadosUsuarios.Activo);
        private void BtnEliminarUsuarios_Click(object sender, EventArgs e) => ActualizarEstadoUsuario(ClsEstadosUsuarios.EEstadosUsuarios.Inactivo);

        /// <summary>Actualiza el estado del usuario a activo/inactivo.</summary>
        /// <param name="_EstadoUsuario">Enum que contrendra el numero del tipo de estado.</param>
        private void ActualizarEstadoUsuario(ClsEstadosUsuarios.EEstadosUsuarios _EstadoUsuario)
        {
            ClsUsuarios Usuarios = new ClsUsuarios();
            Usuario ActualizarUsuario = new Usuario();

            int TotalDeFilas = dgvDatosUsuarios.Rows.Count;

            for (int Indice = 0; Indice < TotalDeFilas; Indice++)
            {
                //Pregunto si la celda es diferente a null
                if (dgvDatosUsuarios.Rows[Indice].Cells[(int)ENumColDGVUsuarios.Seleccionar].Value != null)
                {
                    //Casteo el check del objeto a booleano y pregunto si es true
                    if ((bool)dgvDatosUsuarios.Rows[Indice].Cells[(int)ENumColDGVUsuarios.Seleccionar].Value)
                    {
                        string InformacionDelError = string.Empty;

                        // Verificacion de que el usuario no este asignado a una mesa actualmente
                        bool UsuarioConMesaAsignada = false;

                        if (_EstadoUsuario == ClsEstadosUsuarios.EEstadosUsuarios.Inactivo)
                        {
                            UsuarioConMesaAsignada = BuscarUsuariosAtendiendoMesa(Indice);
                        }

                        ActualizarUsuario = Usuarios.LeerPorNumero((int)dgvDatosUsuarios.Rows[Indice].Cells[(int)ENumColDGVUsuarios.ID_Usuario].Value, ClsUsuarios.EUsuarioABuscar.PorID, ref InformacionDelError);
                        ActualizarUsuario.ID_EstadoUsuario = (int)_EstadoUsuario;

                        if (!UsuarioConMesaAsignada)
                        {
                            //impedir eliminar perfiles gerentes 
                            if (ActualizarUsuario.ID_Perfil != (int)ClsPerfiles.EPerfiles.Gerente)
                            {
                                if (Usuarios.Actualizar(ActualizarUsuario, ref InformacionDelError) != 0)
                                {
                                    dgvDatosUsuarios.Rows.Remove(dgvDatosUsuarios.Rows[Indice]);
                                    Indice -= 1;
                                    TotalDeFilas -= 1;
                                }
                                else if (InformacionDelError == string.Empty)
                                {
                                    MessageBox.Show($"Error al intentar eliminar el usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                using (FrmInformacion FormInformacion = new FrmInformacion($"El usuario '{ActualizarUsuario.Nombre}' no se puede eliminar ya que es un gerente.", ClsColores.Blanco, 150, 300))
                                {
                                    FormInformacion.ShowDialog();
                                }
                            }
                        }
                        else
                        {
                            using (FrmInformacion FormInformacion = new FrmInformacion($"El usuario '{ActualizarUsuario.Nombre} {ActualizarUsuario.Apellido}' no se puede eliminar ya que " +
                                    $"se detecto que esta asignado a una mesa, cambie el usuario que desea eliminar por otro mozo en la " +
                                    $"pantalla de mesas e intente nuevamente.", ClsColores.Blanco, 200, 350))
                            {
                                FormInformacion.ShowDialog();
                            }
                        }
                    }
                }
            }
        }

        private void RbnUsuariosActivos_CheckedChanged(object sender, EventArgs e)
        {
            btnEliminarUsuarios.Visible = true;
            btnRestaurarUsuario.Visible = false;

            CargarDGVUsuarios(ClsUsuarios.ETipoListado.UsuariosActivos);
        }

        private void RbnUsuariosInactivos_CheckedChanged(object sender, EventArgs e)
        {
            btnEliminarUsuarios.Visible = false;
            btnRestaurarUsuario.Visible = true;

            CargarDGVUsuarios(ClsUsuarios.ETipoListado.UsuariosInactivos);
        }

        /// <summary>Carga el DGV.</summary>
        private void CargarDGVUsuarios(ClsUsuarios.ETipoListado _TipoDeEstado)
        {
            dgvDatosUsuarios.Rows.Clear();

            string InformacionDelError = string.Empty;

            ClsUsuarios Usuarios = new ClsUsuarios();

            List<Usuario> ListaUsuarios = Usuarios.LeerListado(_TipoDeEstado, ref InformacionDelError);

            if (ListaUsuarios != null)
            {
                foreach (Usuario Elemento in ListaUsuarios)
                {
                    int NumeroDeFila = dgvDatosUsuarios.Rows.Add();

                    dgvDatosUsuarios.Rows[NumeroDeFila].Cells[(int)ENumColDGVUsuarios.ID_Usuario].Value = Elemento.ID_Usuario;
                    dgvDatosUsuarios.Rows[NumeroDeFila].Cells[(int)ENumColDGVUsuarios.Nick].Value = Elemento.Nick;
                    dgvDatosUsuarios.Rows[NumeroDeFila].Cells[(int)ENumColDGVUsuarios.Nombre].Value = Elemento.Nombre;
                    dgvDatosUsuarios.Rows[NumeroDeFila].Cells[(int)ENumColDGVUsuarios.Apellido].Value = Elemento.Apellido;
                    dgvDatosUsuarios.Rows[NumeroDeFila].Cells[(int)ENumColDGVUsuarios.Perfil].Value = Elemento.Perfil.Nombre;
                    dgvDatosUsuarios.Rows[NumeroDeFila].Cells[(int)ENumColDGVUsuarios.Seleccionar].Value = false;
                }

                UltimaFilaSeleccionada = -1;

                dgvDatosUsuarios.Sort(dgvDatosUsuarios.Columns[(int)ENumColDGVUsuarios.Perfil], ListSortDirection.Descending);
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al cargar los usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool BuscarUsuariosAtendiendoMesa(int _Indice)
        {
            string InformacionDelError = string.Empty;

            ClsMesas Mesas = new ClsMesas();
            List<Mesa> BuscarUsuariosConMesaAsignada = Mesas.LeerListado(ClsMesas.ETipoDeListado.MesasOcupadas, ref InformacionDelError); ;

            if (BuscarUsuariosConMesaAsignada != null)
            {
                foreach (Mesa Elemento in BuscarUsuariosConMesaAsignada)
                {
                    if (Elemento.ID_Usuario == (int)dgvDatosUsuarios.Rows[_Indice].Cells[(int)ENumColDGVUsuarios.ID_Usuario].Value) { return true; }
                }
            }
            else if (InformacionDelError == string.Empty)
            {
                MessageBox.Show("Fallo al buscar si usuarios que esten atendiendo mesas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            using (FrmInformacion FormInformacion = new FrmInformacion("Has doble click en un " +
                    "usuario en especifico si quieres editarlo (el dueño del mismo debe verificar que esta presente, colocando su " +
                    "contraseña), para que pueda asegurarse de que un tercero no sepa sus datos (los cuales debe saberlo solo él " +
                    "por motivos de seguridad).\r\n\r\n" +
                    "De esta forma solo el mozo dueño de su usuario puede " +
                    "cerrar una mesa, o un subgerente crear un nuevo registro en caja (esto debido a que queda asociado el usuario " +
                    "que hizo la accion, y de esta forma saber quien hizo cada cosa).\r\n\r\nTener en cuenta que " +
                    "no se pueden eliminar los usuarios que tengan el " +
                    "perfil de 'gerente', y solo validando con la contraseña de uno que si lo es, puede asignarle este perfil a otro usuario.\r\n\r\n" +
                    "No se permite la eliminacion de usuarios que esten trabajando en una mesa al momento de marcarlos " +
                    "como eliminados. Si desea eliminar ese usuario, cambie todas las mesas en donde este trabajando, " +
                    "por otro mozo.", ClsColores.Blanco, 500, 700))
            {
                FormInformacion.ShowDialog();
            }
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        #region Propiedades
        #endregion
    }
}
