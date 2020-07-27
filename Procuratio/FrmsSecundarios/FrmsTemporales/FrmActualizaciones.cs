using Procuratio.ClsDeApoyo;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Procuratio.FrmsSecundarios.FrmsTemporales
{
    public partial class FrmActualizaciones : Form
    {
        #region Carga
        public FrmActualizaciones()
        {
            InitializeComponent();
        }

        private void FrmActualizaciones_Load(object sender, EventArgs e)
        {
            pnlBarraDeArrastre.Select(); // Evitar bug visual al cargar el formulario
        }
        #endregion

        #region Variables
        private Button BotonPresionado;
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

        #region Codigo para darle estilo a los botones
        //Propiedad para los picturebox
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

        //Propiedad para los botones
        private void ColorBotonesMenuVertical_MouseMove(object sender, MouseEventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            BotonEnFoco.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
            BotonEnFoco.BackColor = ClsColores.Verde;
            BotonEnFoco.FlatAppearance.BorderSize = 3;
        }

        private void ColorBotonesMenuVertical_MouseLeave(object sender, EventArgs e)
        {
            Button BotonEnFoco = (Button)sender;

            //Si el boton que esta en foco es diferente al que tiene asociado el evento del formulario que se encuentra en 
            //pantalla, cambiar la propiedad, sino, no entrar al IF
            if (BotonEnFoco != BotonPresionado) { BotonEnEstadoOriginal(BotonEnFoco); }
        }

        /// <summary>
        /// Vuelve el estado del boton que dejo de tener foco como deseleccionado con excepcion del boton del formulario abierto
        /// </summary>
        /// <param name="_CambiarEstilo">Boton que esta en foco (y no es el seleccionado).</param>
        private void BotonEnEstadoOriginal(Button _CambiarEstilo)
        {
            if (_CambiarEstilo != null)
            {
                _CambiarEstilo.ForeColor = Color.White;
                _CambiarEstilo.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                _CambiarEstilo.BackColor = ClsColores.Transparente;
                _CambiarEstilo.FlatAppearance.BorderSize = 1;
            }
        }
        #endregion

        #region Botones
        private void BtnFebrero2020_Click(object sender, EventArgs e)
        {
            PreparaBotonesYTexto(
                    $"█ Ahora se detecta si todavia debe cerrar la caja antes de poder abrirla nuevamente. Tambien se " +
                    $"detecta si quiere cerrar una caja cuando nunca la abrio.\r\n\r\n" +
                    $"█ Ya no es mas obligatorio cargar todos los campos para crear/editar un cliente, se le pedira " +
                    $"como minimo que ingrese un nombre o apellido (Pero no se pueden repetir clientes).\r\n\r\n" +
                    $"█ Puede ingresar los clientes que asistieron a los diferentes pedidos con el fin de ofrecer promociones y descuentos " +
                    $"personalizados al saber la frecuencia de asistencia de los mismos al local.\r\n\r\n" +
                    $"█ Nueva sección de estadisticas, las cuales le permitira saber cuales son los clientes que mas asisten " +
                    $"al local (si los carga al crear los pedidos), clientes que mas reservaron, informacion sobre la carta (articulo " +
                    $"mas vendido, menos vendido, promedio de precios, etc), y mucho mas.\r\n\r\n" +
                    $"█ Ahora puede decidir si quiere imprimir o no un ticket, cuando desde la ventana de cocina se marca " +
                    $"un pedido de delivery como finalizado (al marcar la casilla de preferencia). Ademas, " +
                    $"desde la lista de los pedidos en proceso, puede ver las mesas a las que " +
                    $"corresponde ese pedido.\r\n\r\n" +
                    $"█ En la pantalla de edicion de los precios de carta (tanto para las mesas como para delivery) " +
                    $"ahora puede indicar un monto para aplicar un aumento/descuento a los precios, en lugar de " +
                    $"usar un procentaje.\r\n\r\n" +
                    $"█ Mejoras de rendimiento.\r\n\r\n" +
                    $"█ Correccion de errores menores.", sender);
        }

        private void Marzo2020_Click(object sender, EventArgs e)
        {
            PreparaBotonesYTexto(
                    $"█ Al marcar pedidos en la ventana de cocina, estos no de desmarcaran al actualizarse la lista (si estos " +
                    $"continuan en la misma y estaban marcados).\r\n\r\n" +
                    $"█ Ahora se muestra un pequeño menu de carga al iniciar el programa por primera " +
                    $"vez.\r\n\r\n" +
                    $"█ El programa detectara cuando haya un tiempo de conexion largo, por lo que con el " +
                    $"objetivo principal de reducir el consumo de recursos, este se cerrará y mostrará el " +
                    $"menu de inicio de sesion (solo si " +
                    $"detecta 24 horas seguidas de conexion).\r\n\r\n" +
                    $"█ Se mejoro el menu inferior de resultados de operaciones, mostrando mas mensajes, y " +
                    $"mostrando un mensaje resaltado en caso de que lo que se quiera advertir es un error grave " +
                    $"del sistema al intentar realizar lo solicitado para que lo informe al programador y repare el mismo.\r\n\r\n" +
                    $"█ Mejoras de rendimiento.\r\n\r\n" +
                    $"█ Correccion de errores menores.", sender);
        }

        private void BtnAbril2020_Click(object sender, EventArgs e)
        {
            PreparaBotonesYTexto($"█ Nuevo menu de actualizaciones.\r\n\r\n" +
                $"█ Se mejoro la primera busqueda de algun elemento en todos los filtros que buscan " +
                $"alguna palabra para ser mostrada en la grilla (Pedidos por mesa, carta y activacion o " +
                $"eliminacion de elementos de la carta).\r\n\r\n" +
                $"█ Nueva ventana para solicitar confirmaciones.\r\n\r\n" +
                $"█ Se agrego un block de notas que puede ser accedido seleccionando el boton (que se " +
                $"encuentra en la barra superior de la ventana general de la aplicacion) [Herramientas] y " +
                $"luego [Block de notas]. Los cambios seran guardados al cerrar la ventana.\r\n\r\n" +
                $"█ Se modificaron los elementos que muestran los numeros de mesas y los nombres de " +
                $"los mozos con colores oscuros, para molestar menos a la vista en ambientes que tambien lo sean.\r\n\r\n" +
                $"█ Ahora la ventana principal comenzara en su tamaño maximo al iniciar el programa. Ademas, cada " +
                $"cierto tiempo se contraera el menu de botones a su tamaño minimo para que de esta forma" +
                $" se aproveche el maximo de la pantalla.\r\n\r\n" +
                $"█ Cuando seleccione una celda de una cuadrilla, esta cambiara de color para poder ser vista " +
                $"mas facilmente como marcada.\r\n\r\n" +
                $"█ Se mejoro el orden de las listas de busqueda de articulos por categorias.\r\n\r\n" +
                $"█ Mejoras en la estructura interna de todo el programa para aumentar la velocidad de respuesta " +
                $"en diferentes partes (como por ejemplo crear o editar mesas).\r\n\r\n" +
                $"█ Correccion de errores menores.\r\n\r\n", sender);
        }
        #endregion

        /// <summary>
        /// Mantiene seleccionado el boton presionado y muestra el texto.
        /// </summary>
        /// <param name="_Texto">Datos de la actualizacion</param>
        /// <param name="_Boton">Boton que se presiono</param>
        private void PreparaBotonesYTexto(string _Texto, object _Boton)
        {
            if (BotonPresionado != null) { BotonEnEstadoOriginal(BotonPresionado); } // Deseleccionar boton viejo.

            BotonPresionado = (Button)_Boton; //Esto evitara que los eventos move y leave le cambien el estilo al boton en el codigo de estilo.

            TxtContTexto.Text = _Texto;
        }

        private void PicBTNCerrar_Click(object sender, EventArgs e) => Close();
    }
}
