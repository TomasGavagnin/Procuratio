using System.Windows.Forms;

namespace Procuratio.FrmsSecundarios.FrmsTemporales
{
    public partial class FrmStock : Form
    {
        #region Carga
        private FrmStock()
        {
            InitializeComponent();
        }

        #endregion

        #region Variables
        private static FrmStock InstanciaForm;
        #endregion

        /// <summary>
        /// Devuelve una unica instancia del formulario (Patron singleton)
        /// </summary>
        /// <returns></returns>
        public static FrmStock ObtenerInstancia()
        {
            if (InstanciaForm == null) { InstanciaForm = new FrmStock(); }

            return InstanciaForm;
        }
    }
}
