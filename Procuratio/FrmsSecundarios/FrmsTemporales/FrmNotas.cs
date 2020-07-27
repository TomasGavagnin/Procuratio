using Procuratio.ClsDeApoyo;
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

namespace Procuratio.FrmsSecundarios.FrmsTemporales
{
    public partial class FrmNotas : Form
    {
        #region Carga
        public FrmNotas()
        {
            InitializeComponent();
        }

        private void FrmNotas_Load(object sender, EventArgs e)
        {
            CargarBlockDeNotas();
        }

        private void CargarBlockDeNotas()
        {
            string InformacionDelError = string.Empty;

            ClsBlockDeNotas BlockDeNotas = new ClsBlockDeNotas();
            BlockDeNota RegistroLeido = new BlockDeNota();

            RegistroLeido = BlockDeNotas.LeerPorNumero(1, ref InformacionDelError);

            if (RegistroLeido != null)
            {
                txtBlockDeNotas.Text = RegistroLeido.TextoBlockNota;
            }
            else if (InformacionDelError == string.Empty)
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al intentar cargar el block de notas");
            }
            else
            {
                FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Fallo al intentar cargar el block de notas");
                MessageBox.Show($"{InformacionDelError}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
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

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();

        private void FrmNotas_FormClosing(object sender, FormClosingEventArgs e)
        {
            string InformacionDelError = string.Empty;

            ClsBlockDeNotas BlockDeNotas = new ClsBlockDeNotas();

            BlockDeNota GuardarBlockDeNota = new BlockDeNota();
            GuardarBlockDeNota.ID_BlockDeNota = 1;
            GuardarBlockDeNota.TextoBlockNota = txtBlockDeNotas.Text;

            if (BlockDeNotas.LeerPorNumero(1, ref InformacionDelError).TextoBlockNota != txtBlockDeNotas.Text)
            {
                InformacionDelError = string.Empty;

                if (BlockDeNotas.Actualizar(GuardarBlockDeNota, ref InformacionDelError) != 0)
                {
                    FrmPrincipal.ObtenerInstancia().S_tslResultadoOperacion = "Block de notas actualizado";
                }
                else if (InformacionDelError != string.Empty)
                {
                    e.Cancel = true;

                    DialogResult Respuesta = DialogResult.No;

                    FrmPrincipal.ObtenerInstancia().MensajeAdvertencia("Error al intentar actualizar el block de notas");
                    MessageBox.Show($"Ocurrio el siguiente fallo al guardar los cambios en las notas: " +
                        $"{InformacionDelError}.\r\n\r\nQuieres cerrar de todas formas la ventana? (los cambios no se " +
                        $"guardaran)", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (Respuesta == DialogResult.Yes) { e.Cancel = false; }
                }
            }
        }
    }
}
