namespace Procuratio
{
    partial class FrmMesas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRegistroDeDatos = new System.Windows.Forms.Label();
            this.btnVerMesasDisponibles = new System.Windows.Forms.Button();
            this.btnCrearPedido = new System.Windows.Forms.Button();
            this.pnlContenedorMesas = new System.Windows.Forms.Panel();
            this.pnlEjemploMesa = new System.Windows.Forms.Panel();
            this.lblEJVistaPrevia = new System.Windows.Forms.Label();
            this.btnEJAbrirListaPedidos = new System.Windows.Forms.Button();
            this.lblEJNumeromesa2 = new System.Windows.Forms.Label();
            this.lblEJTiempoEspera = new System.Windows.Forms.Label();
            this.btnEJCambiarMozo = new System.Windows.Forms.Button();
            this.lblEJEstadoDelPedido = new System.Windows.Forms.Label();
            this.btnEJCerrarMesa = new System.Windows.Forms.Button();
            this.btnEJEliminarMesa = new System.Windows.Forms.Button();
            this.lblEJNombreMozo = new System.Windows.Forms.Label();
            this.lblEJNumeromesa1 = new System.Windows.Forms.Label();
            this.tmrActualizaDatos = new System.Windows.Forms.Timer(this.components);
            this.lblBuscarMesa = new System.Windows.Forms.Label();
            this.txtBuscarMesa = new System.Windows.Forms.TextBox();
            this.pnlDecorativo1 = new System.Windows.Forms.Panel();
            this.grbMostrar = new System.Windows.Forms.GroupBox();
            this.rbnPlantaBaja = new System.Windows.Forms.RadioButton();
            this.rbnPlantaAlta = new System.Windows.Forms.RadioButton();
            this.picBTNInformacion = new System.Windows.Forms.PictureBox();
            this.rbnParaEntrega = new System.Windows.Forms.RadioButton();
            this.rbnEsperandoPago = new System.Windows.Forms.RadioButton();
            this.rbnEntregado = new System.Windows.Forms.RadioButton();
            this.rbnEnProceso = new System.Windows.Forms.RadioButton();
            this.rbnPendiente = new System.Windows.Forms.RadioButton();
            this.rbnTodo = new System.Windows.Forms.RadioButton();
            this.TmrColor = new System.Windows.Forms.Timer(this.components);
            this.cmbNombreMozo = new System.Windows.Forms.ComboBox();
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.pnlContenedorMesas.SuspendLayout();
            this.pnlEjemploMesa.SuspendLayout();
            this.grbMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistroDeDatos
            // 
            this.lblRegistroDeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblRegistroDeDatos.AutoSize = true;
            this.lblRegistroDeDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblRegistroDeDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroDeDatos.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistroDeDatos.Location = new System.Drawing.Point(300, 9);
            this.lblRegistroDeDatos.Name = "lblRegistroDeDatos";
            this.lblRegistroDeDatos.Size = new System.Drawing.Size(318, 19);
            this.lblRegistroDeDatos.TabIndex = 21;
            this.lblRegistroDeDatos.Text = "GESTION DE LAS MESAS DEL RESTAURANTE";
            // 
            // btnVerMesasDisponibles
            // 
            this.btnVerMesasDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerMesasDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.btnVerMesasDisponibles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerMesasDisponibles.FlatAppearance.BorderSize = 2;
            this.btnVerMesasDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMesasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMesasDisponibles.ForeColor = System.Drawing.Color.White;
            this.btnVerMesasDisponibles.Location = new System.Drawing.Point(767, 94);
            this.btnVerMesasDisponibles.Name = "btnVerMesasDisponibles";
            this.btnVerMesasDisponibles.Size = new System.Drawing.Size(160, 50);
            this.btnVerMesasDisponibles.TabIndex = 32;
            this.btnVerMesasDisponibles.Text = "Ver las mesas disponibles";
            this.btnVerMesasDisponibles.UseVisualStyleBackColor = false;
            this.btnVerMesasDisponibles.Click += new System.EventHandler(this.BtnVerMesasDisponibles_Click);
            this.btnVerMesasDisponibles.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnVerMesasDisponibles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearPedido.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrearPedido.FlatAppearance.BorderSize = 2;
            this.btnCrearPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPedido.ForeColor = System.Drawing.Color.White;
            this.btnCrearPedido.Location = new System.Drawing.Point(767, 38);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(160, 50);
            this.btnCrearPedido.TabIndex = 29;
            this.btnCrearPedido.Text = "Crear nuevo pedido";
            this.btnCrearPedido.UseVisualStyleBackColor = false;
            this.btnCrearPedido.Click += new System.EventHandler(this.btnCrearPedido_Click);
            this.btnCrearPedido.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCrearPedido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // pnlContenedorMesas
            // 
            this.pnlContenedorMesas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlContenedorMesas.AutoScroll = true;
            this.pnlContenedorMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pnlContenedorMesas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorMesas.Controls.Add(this.pnlEjemploMesa);
            this.pnlContenedorMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContenedorMesas.Location = new System.Drawing.Point(10, 38);
            this.pnlContenedorMesas.Name = "pnlContenedorMesas";
            this.pnlContenedorMesas.Size = new System.Drawing.Size(750, 515);
            this.pnlContenedorMesas.TabIndex = 24;
            // 
            // pnlEjemploMesa
            // 
            this.pnlEjemploMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pnlEjemploMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEjemploMesa.Controls.Add(this.lblEJVistaPrevia);
            this.pnlEjemploMesa.Controls.Add(this.btnEJAbrirListaPedidos);
            this.pnlEjemploMesa.Controls.Add(this.lblEJNumeromesa2);
            this.pnlEjemploMesa.Controls.Add(this.lblEJTiempoEspera);
            this.pnlEjemploMesa.Controls.Add(this.btnEJCambiarMozo);
            this.pnlEjemploMesa.Controls.Add(this.lblEJEstadoDelPedido);
            this.pnlEjemploMesa.Controls.Add(this.btnEJCerrarMesa);
            this.pnlEjemploMesa.Controls.Add(this.btnEJEliminarMesa);
            this.pnlEjemploMesa.Controls.Add(this.lblEJNombreMozo);
            this.pnlEjemploMesa.Controls.Add(this.lblEJNumeromesa1);
            this.pnlEjemploMesa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEjemploMesa.Location = new System.Drawing.Point(0, 0);
            this.pnlEjemploMesa.Name = "pnlEjemploMesa";
            this.pnlEjemploMesa.Size = new System.Drawing.Size(748, 110);
            this.pnlEjemploMesa.TabIndex = 0;
            // 
            // lblEJVistaPrevia
            // 
            this.lblEJVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEJVistaPrevia.AutoSize = true;
            this.lblEJVistaPrevia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblEJVistaPrevia.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEJVistaPrevia.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblEJVistaPrevia.Location = new System.Drawing.Point(108, 6);
            this.lblEJVistaPrevia.Name = "lblEJVistaPrevia";
            this.lblEJVistaPrevia.Size = new System.Drawing.Size(242, 23);
            this.lblEJVistaPrevia.TabIndex = 22;
            this.lblEJVistaPrevia.Text = "(VISTA PREVIA DE AYUDA)";
            // 
            // btnEJAbrirListaPedidos
            // 
            this.btnEJAbrirListaPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnEJAbrirListaPedidos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEJAbrirListaPedidos.FlatAppearance.BorderSize = 2;
            this.btnEJAbrirListaPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEJAbrirListaPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEJAbrirListaPedidos.ForeColor = System.Drawing.Color.White;
            this.btnEJAbrirListaPedidos.Location = new System.Drawing.Point(8, 39);
            this.btnEJAbrirListaPedidos.Name = "btnEJAbrirListaPedidos";
            this.btnEJAbrirListaPedidos.Size = new System.Drawing.Size(298, 65);
            this.btnEJAbrirListaPedidos.TabIndex = 33;
            this.btnEJAbrirListaPedidos.Text = "Abrir pedido";
            this.ttpMensajesDeAyuda.SetToolTip(this.btnEJAbrirListaPedidos, "Abre la pantalla para editar/ver el pedido de la/s mesa/s");
            this.btnEJAbrirListaPedidos.UseVisualStyleBackColor = false;
            // 
            // lblEJNumeromesa2
            // 
            this.lblEJNumeromesa2.AutoSize = true;
            this.lblEJNumeromesa2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblEJNumeromesa2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEJNumeromesa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEJNumeromesa2.ForeColor = System.Drawing.Color.LightGray;
            this.lblEJNumeromesa2.Location = new System.Drawing.Point(58, 7);
            this.lblEJNumeromesa2.Name = "lblEJNumeromesa2";
            this.lblEJNumeromesa2.Size = new System.Drawing.Size(45, 26);
            this.lblEJNumeromesa2.TabIndex = 1;
            this.lblEJNumeromesa2.Text = "002";
            this.lblEJNumeromesa2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpMensajesDeAyuda.SetToolTip(this.lblEJNumeromesa2, "Representa la mesa N° 2");
            // 
            // lblEJTiempoEspera
            // 
            this.lblEJTiempoEspera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEJTiempoEspera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblEJTiempoEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEJTiempoEspera.ForeColor = System.Drawing.Color.White;
            this.lblEJTiempoEspera.Location = new System.Drawing.Point(358, 74);
            this.lblEJTiempoEspera.Name = "lblEJTiempoEspera";
            this.lblEJTiempoEspera.Size = new System.Drawing.Size(175, 30);
            this.lblEJTiempoEspera.TabIndex = 35;
            this.lblEJTiempoEspera.Text = "Espera = 00:00";
            this.lblEJTiempoEspera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttpMensajesDeAyuda.SetToolTip(this.lblEJTiempoEspera, "Muestra el tiempo de espera de la mesa");
            // 
            // btnEJCambiarMozo
            // 
            this.btnEJCambiarMozo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEJCambiarMozo.BackColor = System.Drawing.Color.Transparent;
            this.btnEJCambiarMozo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEJCambiarMozo.FlatAppearance.BorderSize = 2;
            this.btnEJCambiarMozo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEJCambiarMozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEJCambiarMozo.ForeColor = System.Drawing.Color.White;
            this.btnEJCambiarMozo.Location = new System.Drawing.Point(543, 4);
            this.btnEJCambiarMozo.Name = "btnEJCambiarMozo";
            this.btnEJCambiarMozo.Size = new System.Drawing.Size(175, 30);
            this.btnEJCambiarMozo.TabIndex = 34;
            this.btnEJCambiarMozo.Text = "Editar pedido";
            this.ttpMensajesDeAyuda.SetToolTip(this.btnEJCambiarMozo, "Permite editar el pedido, agregando mesas, cambiando el mozo o el chef");
            this.btnEJCambiarMozo.UseVisualStyleBackColor = false;
            // 
            // lblEJEstadoDelPedido
            // 
            this.lblEJEstadoDelPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEJEstadoDelPedido.BackColor = System.Drawing.Color.Silver;
            this.lblEJEstadoDelPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEJEstadoDelPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEJEstadoDelPedido.ForeColor = System.Drawing.Color.Black;
            this.lblEJEstadoDelPedido.Location = new System.Drawing.Point(358, 39);
            this.lblEJEstadoDelPedido.Name = "lblEJEstadoDelPedido";
            this.lblEJEstadoDelPedido.Size = new System.Drawing.Size(175, 30);
            this.lblEJEstadoDelPedido.TabIndex = 33;
            this.lblEJEstadoDelPedido.Text = "Estado del pedido";
            this.lblEJEstadoDelPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpMensajesDeAyuda.SetToolTip(this.lblEJEstadoDelPedido, "Indica los diferentes estados del pedido a medida que se agregan o quitan articul" +
        "os al pedido");
            // 
            // btnEJCerrarMesa
            // 
            this.btnEJCerrarMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEJCerrarMesa.BackColor = System.Drawing.Color.Transparent;
            this.btnEJCerrarMesa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEJCerrarMesa.FlatAppearance.BorderSize = 2;
            this.btnEJCerrarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEJCerrarMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEJCerrarMesa.ForeColor = System.Drawing.Color.White;
            this.btnEJCerrarMesa.Location = new System.Drawing.Point(543, 39);
            this.btnEJCerrarMesa.Name = "btnEJCerrarMesa";
            this.btnEJCerrarMesa.Size = new System.Drawing.Size(175, 30);
            this.btnEJCerrarMesa.TabIndex = 28;
            this.btnEJCerrarMesa.Text = "Cerrar pedido";
            this.ttpMensajesDeAyuda.SetToolTip(this.btnEJCerrarMesa, "Se habilita cuando el pedido fue marcado como \"Esperando pago\" para registrar el " +
        "pago del pedido");
            this.btnEJCerrarMesa.UseVisualStyleBackColor = false;
            // 
            // btnEJEliminarMesa
            // 
            this.btnEJEliminarMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEJEliminarMesa.BackColor = System.Drawing.Color.Transparent;
            this.btnEJEliminarMesa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEJEliminarMesa.FlatAppearance.BorderSize = 2;
            this.btnEJEliminarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEJEliminarMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEJEliminarMesa.ForeColor = System.Drawing.Color.White;
            this.btnEJEliminarMesa.Location = new System.Drawing.Point(543, 74);
            this.btnEJEliminarMesa.Name = "btnEJEliminarMesa";
            this.btnEJEliminarMesa.Size = new System.Drawing.Size(175, 30);
            this.btnEJEliminarMesa.TabIndex = 27;
            this.btnEJEliminarMesa.Text = "Eliminar pedido";
            this.ttpMensajesDeAyuda.SetToolTip(this.btnEJEliminarMesa, "Elimina el pedido actual");
            this.btnEJEliminarMesa.UseVisualStyleBackColor = false;
            // 
            // lblEJNombreMozo
            // 
            this.lblEJNombreMozo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEJNombreMozo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblEJNombreMozo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEJNombreMozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEJNombreMozo.ForeColor = System.Drawing.Color.LightGray;
            this.lblEJNombreMozo.Location = new System.Drawing.Point(358, 4);
            this.lblEJNombreMozo.Name = "lblEJNombreMozo";
            this.lblEJNombreMozo.Size = new System.Drawing.Size(175, 30);
            this.lblEJNombreMozo.TabIndex = 2;
            this.lblEJNombreMozo.Text = "Nombre Mozo";
            this.lblEJNombreMozo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpMensajesDeAyuda.SetToolTip(this.lblEJNombreMozo, "Indica el mozo que esta atendiendo la/s mesa/s");
            // 
            // lblEJNumeromesa1
            // 
            this.lblEJNumeromesa1.AutoSize = true;
            this.lblEJNumeromesa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblEJNumeromesa1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEJNumeromesa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEJNumeromesa1.ForeColor = System.Drawing.Color.LightGray;
            this.lblEJNumeromesa1.Location = new System.Drawing.Point(8, 7);
            this.lblEJNumeromesa1.Name = "lblEJNumeromesa1";
            this.lblEJNumeromesa1.Size = new System.Drawing.Size(45, 26);
            this.lblEJNumeromesa1.TabIndex = 0;
            this.lblEJNumeromesa1.Text = "001";
            this.lblEJNumeromesa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpMensajesDeAyuda.SetToolTip(this.lblEJNumeromesa1, "Representa la mesa N° 1");
            // 
            // tmrActualizaDatos
            // 
            this.tmrActualizaDatos.Enabled = true;
            this.tmrActualizaDatos.Interval = 1000;
            this.tmrActualizaDatos.Tick += new System.EventHandler(this.tmrActualizaDatos_Tick);
            // 
            // lblBuscarMesa
            // 
            this.lblBuscarMesa.AutoSize = true;
            this.lblBuscarMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarMesa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBuscarMesa.Location = new System.Drawing.Point(766, 157);
            this.lblBuscarMesa.Name = "lblBuscarMesa";
            this.lblBuscarMesa.Size = new System.Drawing.Size(112, 18);
            this.lblBuscarMesa.TabIndex = 33;
            this.lblBuscarMesa.Text = "Buscar mesa:";
            // 
            // txtBuscarMesa
            // 
            this.txtBuscarMesa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtBuscarMesa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarMesa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMesa.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscarMesa.Location = new System.Drawing.Point(876, 157);
            this.txtBuscarMesa.MaxLength = 3;
            this.txtBuscarMesa.Name = "txtBuscarMesa";
            this.txtBuscarMesa.ShortcutsEnabled = false;
            this.txtBuscarMesa.Size = new System.Drawing.Size(51, 19);
            this.txtBuscarMesa.TabIndex = 35;
            this.txtBuscarMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpMensajesDeAyuda.SetToolTip(this.txtBuscarMesa, "Filtrar por numero de mesa");
            this.txtBuscarMesa.TextChanged += new System.EventHandler(this.TxtBuscarMesa_TextChanged);
            this.txtBuscarMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarMesa_KeyPress);
            // 
            // pnlDecorativo1
            // 
            this.pnlDecorativo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDecorativo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo1.Location = new System.Drawing.Point(876, 176);
            this.pnlDecorativo1.Name = "pnlDecorativo1";
            this.pnlDecorativo1.Size = new System.Drawing.Size(51, 2);
            this.pnlDecorativo1.TabIndex = 34;
            // 
            // grbMostrar
            // 
            this.grbMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbMostrar.Controls.Add(this.rbnPlantaBaja);
            this.grbMostrar.Controls.Add(this.rbnPlantaAlta);
            this.grbMostrar.Controls.Add(this.picBTNInformacion);
            this.grbMostrar.Controls.Add(this.rbnParaEntrega);
            this.grbMostrar.Controls.Add(this.rbnEsperandoPago);
            this.grbMostrar.Controls.Add(this.rbnEntregado);
            this.grbMostrar.Controls.Add(this.rbnEnProceso);
            this.grbMostrar.Controls.Add(this.rbnPendiente);
            this.grbMostrar.Controls.Add(this.rbnTodo);
            this.grbMostrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grbMostrar.ForeColor = System.Drawing.Color.Gray;
            this.grbMostrar.Location = new System.Drawing.Point(769, 221);
            this.grbMostrar.Name = "grbMostrar";
            this.grbMostrar.Size = new System.Drawing.Size(158, 229);
            this.grbMostrar.TabIndex = 40;
            this.grbMostrar.TabStop = false;
            this.grbMostrar.Text = "Mostrar";
            // 
            // rbnPlantaBaja
            // 
            this.rbnPlantaBaja.AutoSize = true;
            this.rbnPlantaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnPlantaBaja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnPlantaBaja.Location = new System.Drawing.Point(6, 49);
            this.rbnPlantaBaja.Name = "rbnPlantaBaja";
            this.rbnPlantaBaja.Size = new System.Drawing.Size(109, 22);
            this.rbnPlantaBaja.TabIndex = 46;
            this.rbnPlantaBaja.Text = "Planta baja";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnPlantaBaja, "Filtrar viendo las mesas de la planta baja");
            this.rbnPlantaBaja.UseVisualStyleBackColor = true;
            this.rbnPlantaBaja.Click += new System.EventHandler(this.FiltroEstadoPedido_Click);
            // 
            // rbnPlantaAlta
            // 
            this.rbnPlantaAlta.AutoSize = true;
            this.rbnPlantaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnPlantaAlta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnPlantaAlta.Location = new System.Drawing.Point(6, 73);
            this.rbnPlantaAlta.Name = "rbnPlantaAlta";
            this.rbnPlantaAlta.Size = new System.Drawing.Size(105, 22);
            this.rbnPlantaAlta.TabIndex = 45;
            this.rbnPlantaAlta.Text = "Planta alta";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnPlantaAlta, "Filtrar viendo las mesas de la planta alta");
            this.rbnPlantaAlta.UseVisualStyleBackColor = true;
            this.rbnPlantaAlta.Click += new System.EventHandler(this.FiltroEstadoPedido_Click);
            // 
            // picBTNInformacion
            // 
            this.picBTNInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBTNInformacion.Image = global::Procuratio.Properties.Resources._3017955_48;
            this.picBTNInformacion.Location = new System.Drawing.Point(115, 12);
            this.picBTNInformacion.Name = "picBTNInformacion";
            this.picBTNInformacion.Size = new System.Drawing.Size(41, 30);
            this.picBTNInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNInformacion.TabIndex = 3;
            this.picBTNInformacion.TabStop = false;
            this.picBTNInformacion.Click += new System.EventHandler(this.PicBTNInformacion_Click);
            // 
            // rbnParaEntrega
            // 
            this.rbnParaEntrega.AutoSize = true;
            this.rbnParaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnParaEntrega.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnParaEntrega.Location = new System.Drawing.Point(6, 146);
            this.rbnParaEntrega.Name = "rbnParaEntrega";
            this.rbnParaEntrega.Size = new System.Drawing.Size(122, 22);
            this.rbnParaEntrega.TabIndex = 44;
            this.rbnParaEntrega.Text = "Para entrega";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnParaEntrega, "Filtrar viendo las mesas con estado del pedido \"Para entrega\"");
            this.rbnParaEntrega.UseVisualStyleBackColor = true;
            this.rbnParaEntrega.Click += new System.EventHandler(this.FiltroEstadoPedido_Click);
            // 
            // rbnEsperandoPago
            // 
            this.rbnEsperandoPago.AutoSize = true;
            this.rbnEsperandoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEsperandoPago.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnEsperandoPago.Location = new System.Drawing.Point(6, 197);
            this.rbnEsperandoPago.Name = "rbnEsperandoPago";
            this.rbnEsperandoPago.Size = new System.Drawing.Size(142, 20);
            this.rbnEsperandoPago.TabIndex = 43;
            this.rbnEsperandoPago.Text = "Esperando pago";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnEsperandoPago, "Filtrar viendo las mesas con estado del pedido \"Esperando pago\"");
            this.rbnEsperandoPago.UseVisualStyleBackColor = true;
            this.rbnEsperandoPago.Click += new System.EventHandler(this.FiltroEstadoPedido_Click);
            // 
            // rbnEntregado
            // 
            this.rbnEntregado.AutoSize = true;
            this.rbnEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnEntregado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnEntregado.Location = new System.Drawing.Point(6, 171);
            this.rbnEntregado.Name = "rbnEntregado";
            this.rbnEntregado.Size = new System.Drawing.Size(103, 22);
            this.rbnEntregado.TabIndex = 42;
            this.rbnEntregado.Text = "Entregado";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnEntregado, "Filtrar viendo las mesas con estado del pedido \"Entregado\"");
            this.rbnEntregado.UseVisualStyleBackColor = true;
            this.rbnEntregado.Click += new System.EventHandler(this.FiltroEstadoPedido_Click);
            // 
            // rbnEnProceso
            // 
            this.rbnEnProceso.AutoSize = true;
            this.rbnEnProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnEnProceso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnEnProceso.Location = new System.Drawing.Point(6, 122);
            this.rbnEnProceso.Name = "rbnEnProceso";
            this.rbnEnProceso.Size = new System.Drawing.Size(113, 22);
            this.rbnEnProceso.TabIndex = 41;
            this.rbnEnProceso.Text = "En proceso";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnEnProceso, "Filtrar viendo las mesas con estado del pedido \"En proceso\"");
            this.rbnEnProceso.UseVisualStyleBackColor = true;
            this.rbnEnProceso.Click += new System.EventHandler(this.FiltroEstadoPedido_Click);
            // 
            // rbnPendiente
            // 
            this.rbnPendiente.AutoSize = true;
            this.rbnPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnPendiente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnPendiente.Location = new System.Drawing.Point(6, 97);
            this.rbnPendiente.Name = "rbnPendiente";
            this.rbnPendiente.Size = new System.Drawing.Size(100, 22);
            this.rbnPendiente.TabIndex = 33;
            this.rbnPendiente.Text = "Pendiente";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnPendiente, "Filtrar viendo las mesas con estado del pedido \"Pendiente\"");
            this.rbnPendiente.UseVisualStyleBackColor = true;
            this.rbnPendiente.Click += new System.EventHandler(this.FiltroEstadoPedido_Click);
            // 
            // rbnTodo
            // 
            this.rbnTodo.AutoSize = true;
            this.rbnTodo.Checked = true;
            this.rbnTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnTodo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnTodo.Location = new System.Drawing.Point(6, 25);
            this.rbnTodo.Name = "rbnTodo";
            this.rbnTodo.Size = new System.Drawing.Size(65, 22);
            this.rbnTodo.TabIndex = 32;
            this.rbnTodo.TabStop = true;
            this.rbnTodo.Text = "Todo";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnTodo, "Filtrar viendo todas las mesas");
            this.rbnTodo.UseVisualStyleBackColor = true;
            this.rbnTodo.Click += new System.EventHandler(this.FiltroEstadoPedido_Click);
            // 
            // TmrColor
            // 
            this.TmrColor.Enabled = true;
            this.TmrColor.Tick += new System.EventHandler(this.TmrColor_Tick);
            // 
            // cmbNombreMozo
            // 
            this.cmbNombreMozo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNombreMozo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.cmbNombreMozo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNombreMozo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbNombreMozo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbNombreMozo.FormattingEnabled = true;
            this.cmbNombreMozo.Location = new System.Drawing.Point(769, 188);
            this.cmbNombreMozo.Name = "cmbNombreMozo";
            this.cmbNombreMozo.Size = new System.Drawing.Size(158, 26);
            this.cmbNombreMozo.TabIndex = 34;
            this.cmbNombreMozo.Text = "Buscar por mozo";
            this.ttpMensajesDeAyuda.SetToolTip(this.cmbNombreMozo, "Filtrar por nombre de mozo");
            this.cmbNombreMozo.SelectedIndexChanged += new System.EventHandler(this.CmbNombreMozo_SelectedIndexChanged);
            // 
            // FrmMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(935, 565);
            this.Controls.Add(this.cmbNombreMozo);
            this.Controls.Add(this.grbMostrar);
            this.Controls.Add(this.txtBuscarMesa);
            this.Controls.Add(this.pnlDecorativo1);
            this.Controls.Add(this.lblBuscarMesa);
            this.Controls.Add(this.btnVerMesasDisponibles);
            this.Controls.Add(this.btnCrearPedido);
            this.Controls.Add(this.pnlContenedorMesas);
            this.Controls.Add(this.lblRegistroDeDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMesas";
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.FrmMesas_Load);
            this.pnlContenedorMesas.ResumeLayout(false);
            this.pnlEjemploMesa.ResumeLayout(false);
            this.pnlEjemploMesa.PerformLayout();
            this.grbMostrar.ResumeLayout(false);
            this.grbMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRegistroDeDatos;
        private System.Windows.Forms.Panel pnlContenedorMesas;
        private System.Windows.Forms.Button btnCrearPedido;
        private System.Windows.Forms.Panel pnlEjemploMesa;
        private System.Windows.Forms.Label lblEJNombreMozo;
        private System.Windows.Forms.Button btnEJCerrarMesa;
        private System.Windows.Forms.Button btnEJEliminarMesa;
        private System.Windows.Forms.Label lblEJNumeromesa1;
        private System.Windows.Forms.Button btnVerMesasDisponibles;
        private System.Windows.Forms.Button btnEJCambiarMozo;
        private System.Windows.Forms.Label lblEJEstadoDelPedido;
        private System.Windows.Forms.Label lblEJTiempoEspera;
        private System.Windows.Forms.Label lblEJNumeromesa2;
        private System.Windows.Forms.Button btnEJAbrirListaPedidos;
        private System.Windows.Forms.Timer tmrActualizaDatos;
        private System.Windows.Forms.Label lblBuscarMesa;
        private System.Windows.Forms.TextBox txtBuscarMesa;
        private System.Windows.Forms.Panel pnlDecorativo1;
        private System.Windows.Forms.Label lblEJVistaPrevia;
        private System.Windows.Forms.GroupBox grbMostrar;
        private System.Windows.Forms.RadioButton rbnEnProceso;
        private System.Windows.Forms.RadioButton rbnPendiente;
        private System.Windows.Forms.RadioButton rbnTodo;
        private System.Windows.Forms.RadioButton rbnEntregado;
        private System.Windows.Forms.RadioButton rbnEsperandoPago;
        private System.Windows.Forms.RadioButton rbnParaEntrega;
        private System.Windows.Forms.PictureBox picBTNInformacion;
        private System.Windows.Forms.Timer TmrColor;
        private System.Windows.Forms.ComboBox cmbNombreMozo;
        private System.Windows.Forms.RadioButton rbnPlantaBaja;
        private System.Windows.Forms.RadioButton rbnPlantaAlta;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
    }
}