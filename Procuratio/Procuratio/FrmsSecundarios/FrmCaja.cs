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
    public partial class FrmCaja : Form
    {
        #region Codigo de carga
        public FrmCaja()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        #endregion

        #region Codigo para darle estilo a los botones
        private void btnEstiloBotones_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            if (BotonEnFoco.Name == btnEliminarElementos.Name)
            {
                BotonEnFoco.BackColor = Color.FromArgb(232, 17, 35);
            }
            else
            {
                BotonEnFoco.BackColor = Color.FromArgb(255, 127, 0);
            }
        }

        private void btnEstiloBotones_Leave(object sender, EventArgs e)
        {
            Button BotonEnFoco = (Button)sender;
            BotonEnFoco.BackColor = Color.Transparent;
        }
        #endregion
    }
}
