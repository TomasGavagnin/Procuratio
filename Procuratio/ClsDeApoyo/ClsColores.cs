using System.Drawing;
using System.Windows.Forms;

namespace Procuratio.ClsDeApoyo
{
    public static class ClsColores
    {
        private static bool SeAdvirtioFuncionBeta = false;

        /// <summary>
        /// Color usado para botones que requieran un resaltado especial.
        /// </summary>
        public static readonly Color NaranjaOscuro = Color.FromArgb(180, 40, 0);

        /// <summary>
        /// Color usado para fondo de labels.
        /// </summary>
        public static readonly Color GrisClaro2 = Color.FromArgb(32, 42, 52);

        /// <summary>
        /// Color usado para botones generales.
        /// </summary>
        public static readonly Color NaranjaClaro = Color.FromArgb(255, 127, 0);

        /// <summary>
        /// Color usado para las casillas seleccionadas en los datagridview.
        /// </summary>
        public static readonly Color Azul = Color.FromArgb(0, 60, 70);

        /// <summary>
        /// Color usado para botones de filtrados e impresion.
        /// </summary>
        public static readonly Color VioletaClaro = Color.FromArgb(172, 160, 206);

        /// <summary>
        /// Color usado para botones de actualizacion especiales.
        /// </summary>
        public static readonly Color VioletaOscuro = Color.FromArgb(150, 110, 206);

        /// <summary>
        /// Color usado para botones de cancelacion o eliminacion.
        /// </summary>
        public static readonly Color Rojo = Color.FromArgb(232, 17, 35);
        
        /// <summary>
        /// Color usado para botones de confirmacion.
        /// </summary>
        public static readonly Color Verde = Color.FromArgb(124, 179, 104);

        /// <summary>
        /// Color usado para los sub botones del menu principal.
        /// </summary>
        public static readonly Color VerdeClaro = Color.FromArgb(100, 150, 50);

        /// <summary>
        /// Color usado para darle un ligero tono fris a un boton con fondo oscuro.
        /// </summary>
        public static readonly Color Gris = Color.Gray;

        /// <summary>
        /// Color blanco.
        /// </summary>
        public static readonly Color Blanco = Color.White;

        /// <summary>
        /// Color usado principalmente para indicar como con foco.
        /// </summary>
        public static readonly Color GrisClaro = Color.LightGray;

        /// <summary>
        /// Color usado principalmente para indicar como sin foco.
        /// </summary>
        public static readonly Color GrisOscuro = Color.DimGray;

        /// <summary>
        /// Quitarle el color de fondo.
        /// </summary>
        public static readonly Color Transparente = Color.Transparent;

        /// <summary>
        /// GrisClaro.
        /// </summary>
        public static readonly Color Gainsboro = Color.Gainsboro;

        /// <summary>
        /// Amarillo.
        /// </summary>
        public static readonly Color Amarillo = Color.Yellow;

        /// <summary>
        /// Amarillo claro.
        /// </summary>
        public static readonly Color AmarilloClaro = Color.FromArgb(255, 231, 147);

        /// <summary>
        /// Negro.
        /// </summary>
        public static readonly Color Negro = Color.Black;

        /// <summary>
        /// Negro.
        /// </summary>
        public static readonly Color GrisOscuroFondo = Color.FromArgb(21, 28, 36);

        /// <summary>
        /// Color usado para indicar funcion beta.
        /// </summary>
        private static readonly Color FuncionBeta = Color.FromArgb(200, 160, 60);

        /// <summary>
        /// NaranjaRojo.
        /// </summary>
        public static readonly Color NarajaRojo = Color.OrangeRed;

        /// <summary>
        /// Muestra un color diferente (y un mensaje de advertencia la primera vez que se lo ve), para 
        /// indicarle al usuario que esta por unas una funcion nueva, que podria presentar bugs.
        /// </summary>
        public static Color ColorFuncionBeta()
        {
            if (!SeAdvirtioFuncionBeta)
            {
                using (FrmInformacion FormInformacion = new FrmInformacion("Recuerde que las funciones del programa con el color de estas " +
                        "letras (de fondo de un boton o de las mismas letras), indican que es una nueva funcion que se esta testeando. Si encuentra algun " +
                        "error (tanto indicado por la aplicacion como uno que pueda ver pero que no se notifique), " +
                        "informelo al programador para ser solucionado lo mas pronto posible.", Blanco, 250, 400))
                {
                    FormInformacion.ShowDialog();
                }

                SeAdvirtioFuncionBeta = true;

                return Transparente;
            }

            return FuncionBeta;
        }

        /// <summary>
        /// Pinta la fila pasada por parametro de un datagridview.
        /// </summary>
        /// <param name="_DataGridView">DataGridView al que se le desea colorear una fila.</param>
        /// <param name="_Fila">La posicion de la fila.</param>
        /// <param name="_Pintar">Con un valor true, se indicara que se quiere pintar la fila, de lo contrario 
        /// pasar un false.</param>
        public static void MarcarFilaDGV(DataGridView _DataGridView, int _Fila, bool _Pintar)
        {
            if (_Pintar)
            {
                _DataGridView.Rows[_Fila].DefaultCellStyle.SelectionBackColor = Transparente;
                _DataGridView.Rows[_Fila].DefaultCellStyle.BackColor = Azul;
            }
            else
            {
                _DataGridView.Rows[_Fila].DefaultCellStyle.SelectionBackColor = Color.Brown;
                _DataGridView.Rows[_Fila].DefaultCellStyle.BackColor = GrisOscuroFondo;
            }
        }
    }
}
