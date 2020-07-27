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
    public partial class FrmPantallaDePresentacion : Form
    {
        #region Codigo de carga
        public FrmPantallaDePresentacion()
        {
            InitializeComponent();
        }
        #endregion

        public string S_lblCargando { set { lblCargando.Text += value;} }
    }
}
