namespace Procuratio
{
    partial class FrmAdministrarReserva
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
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlDecorativo3 = new System.Windows.Forms.Panel();
            this.nudCantidadPersonas = new System.Windows.Forms.NumericUpDown();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.lblMesaCliente = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.mtbHorario = new System.Windows.Forms.MaskedTextBox();
            this.pnlDecorativo8 = new System.Windows.Forms.Panel();
            this.btnSeleccionarMesas = new System.Windows.Forms.Button();
            this.lblFormaContacto = new System.Windows.Forms.Label();
            this.cmbFormaContacto = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCargarCliente = new System.Windows.Forms.Button();
            this.lblDatosDelCliente = new System.Windows.Forms.Label();
            this.lblDatosDeLaReserva = new System.Windows.Forms.Label();
            this.pnlContFrm = new System.Windows.Forms.Panel();
            this.btnCrearReserva = new System.Windows.Forms.Button();
            this.pnlContDatosCliente = new System.Windows.Forms.Panel();
            this.pnlContDatosReserva = new System.Windows.Forms.Panel();
            this.btnVerMesasCargadas = new System.Windows.Forms.Button();
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.lblMostrarTelefono = new System.Windows.Forms.Label();
            this.lblMostrarApellido = new System.Windows.Forms.Label();
            this.lblMostrarNombre = new System.Windows.Forms.Label();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPersonas)).BeginInit();
            this.pnlContFrm.SuspendLayout();
            this.pnlContDatosCliente.SuspendLayout();
            this.pnlContDatosReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraDeArrastre
            // 
            this.pnlBarraDeArrastre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            this.pnlBarraDeArrastre.Controls.Add(this.lblTituloFrm);
            this.pnlBarraDeArrastre.Controls.Add(this.picBTNCerrar);
            this.pnlBarraDeArrastre.Controls.Add(this.picLogo);
            this.pnlBarraDeArrastre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraDeArrastre.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraDeArrastre.Name = "pnlBarraDeArrastre";
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(1052, 30);
            this.pnlBarraDeArrastre.TabIndex = 2;
            this.pnlBarraDeArrastre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // lblTituloFrm
            // 
            this.lblTituloFrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTituloFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloFrm.Location = new System.Drawing.Point(41, 0);
            this.lblTituloFrm.Name = "lblTituloFrm";
            this.lblTituloFrm.Size = new System.Drawing.Size(167, 30);
            this.lblTituloFrm.TabIndex = 11;
            this.lblTituloFrm.Text = "Datos de la reserva";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar;
            this.picBTNCerrar.Location = new System.Drawing.Point(1011, 0);
            this.picBTNCerrar.Name = "picBTNCerrar";
            this.picBTNCerrar.Size = new System.Drawing.Size(41, 30);
            this.picBTNCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNCerrar.TabIndex = 3;
            this.picBTNCerrar.TabStop = false;
            this.picBTNCerrar.Click += new System.EventHandler(this.PicBTNCerrar_Click);
            this.picBTNCerrar.MouseLeave += new System.EventHandler(this.ColorFondoBotones_MouseLeave);
            this.picBTNCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorFondoBotones_MouseMove);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Image = global::Procuratio.Properties.Resources.Icono_2;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(41, 30);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // pnlDecorativo3
            // 
            this.pnlDecorativo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo3.Location = new System.Drawing.Point(194, 140);
            this.pnlDecorativo3.Name = "pnlDecorativo3";
            this.pnlDecorativo3.Size = new System.Drawing.Size(55, 2);
            this.pnlDecorativo3.TabIndex = 41;
            // 
            // nudCantidadPersonas
            // 
            this.nudCantidadPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.nudCantidadPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadPersonas.ForeColor = System.Drawing.Color.DarkGray;
            this.nudCantidadPersonas.Location = new System.Drawing.Point(194, 120);
            this.nudCantidadPersonas.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudCantidadPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadPersonas.Name = "nudCantidadPersonas";
            this.nudCantidadPersonas.ReadOnly = true;
            this.nudCantidadPersonas.Size = new System.Drawing.Size(55, 20);
            this.nudCantidadPersonas.TabIndex = 37;
            this.nudCantidadPersonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpMensajesDeAyuda.SetToolTip(this.nudCantidadPersonas, "Cantidad de personas que asistiran a la reserva");
            this.nudCantidadPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadPersonas.ValueChanged += new System.EventHandler(this.NudCantidadPersonas_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFecha.Location = new System.Drawing.Point(127, 38);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 18);
            this.lblFecha.TabIndex = 51;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPersonas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidadPersonas.Location = new System.Drawing.Point(9, 120);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(177, 18);
            this.lblCantidadPersonas.TabIndex = 48;
            this.lblCantidadPersonas.Text = "Cantidad de personas:";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblApellido.Location = new System.Drawing.Point(11, 78);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(72, 18);
            this.lblApellido.TabIndex = 53;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTelefono.Location = new System.Drawing.Point(5, 108);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 18);
            this.lblTelefono.TabIndex = 47;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(12, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 18);
            this.lblNombre.TabIndex = 45;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarCambios.FlatAppearance.BorderSize = 2;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(885, 205);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(160, 50);
            this.btnGuardarCambios.TabIndex = 38;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Visible = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.BtnGuardarCambios_Click);
            this.btnGuardarCambios.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnGuardarCambios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblMesaCliente
            // 
            this.lblMesaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMesaCliente.AutoSize = true;
            this.lblMesaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMesaCliente.Location = new System.Drawing.Point(30, 169);
            this.lblMesaCliente.Name = "lblMesaCliente";
            this.lblMesaCliente.Size = new System.Drawing.Size(156, 18);
            this.lblMesaCliente.TabIndex = 55;
            this.lblMesaCliente.Text = "Mesa/s reservada/s";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHorario.Location = new System.Drawing.Point(458, 39);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(70, 18);
            this.lblHorario.TabIndex = 58;
            this.lblHorario.Text = "Horario:";
            // 
            // mtbHorario
            // 
            this.mtbHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.mtbHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbHorario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.mtbHorario.ForeColor = System.Drawing.Color.DarkGray;
            this.mtbHorario.Location = new System.Drawing.Point(531, 39);
            this.mtbHorario.Mask = "00:00";
            this.mtbHorario.Name = "mtbHorario";
            this.mtbHorario.Size = new System.Drawing.Size(44, 19);
            this.mtbHorario.TabIndex = 56;
            this.mtbHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpMensajesDeAyuda.SetToolTip(this.mtbHorario, "Hora en que se asignara la reserva");
            this.mtbHorario.ValidatingType = typeof(System.DateTime);
            // 
            // pnlDecorativo8
            // 
            this.pnlDecorativo8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo8.Location = new System.Drawing.Point(531, 58);
            this.pnlDecorativo8.Name = "pnlDecorativo8";
            this.pnlDecorativo8.Size = new System.Drawing.Size(44, 2);
            this.pnlDecorativo8.TabIndex = 43;
            // 
            // btnSeleccionarMesas
            // 
            this.btnSeleccionarMesas.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarMesas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSeleccionarMesas.FlatAppearance.BorderSize = 2;
            this.btnSeleccionarMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarMesas.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarMesas.Location = new System.Drawing.Point(194, 154);
            this.btnSeleccionarMesas.Name = "btnSeleccionarMesas";
            this.btnSeleccionarMesas.Size = new System.Drawing.Size(160, 50);
            this.btnSeleccionarMesas.TabIndex = 57;
            this.btnSeleccionarMesas.Text = "Seleccionar mesas";
            this.btnSeleccionarMesas.UseVisualStyleBackColor = false;
            this.btnSeleccionarMesas.Click += new System.EventHandler(this.BtnSeleccionarMesas_Click);
            this.btnSeleccionarMesas.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnSeleccionarMesas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblFormaContacto
            // 
            this.lblFormaContacto.AutoSize = true;
            this.lblFormaContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaContacto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFormaContacto.Location = new System.Drawing.Point(30, 78);
            this.lblFormaContacto.Name = "lblFormaContacto";
            this.lblFormaContacto.Size = new System.Drawing.Size(156, 18);
            this.lblFormaContacto.TabIndex = 59;
            this.lblFormaContacto.Text = "Forma de contacto:";
            // 
            // cmbFormaContacto
            // 
            this.cmbFormaContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.cmbFormaContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFormaContacto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbFormaContacto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbFormaContacto.FormattingEnabled = true;
            this.cmbFormaContacto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbFormaContacto.Location = new System.Drawing.Point(194, 76);
            this.cmbFormaContacto.Name = "cmbFormaContacto";
            this.cmbFormaContacto.Size = new System.Drawing.Size(258, 26);
            this.cmbFormaContacto.TabIndex = 60;
            this.ttpMensajesDeAyuda.SetToolTip(this.cmbFormaContacto, "Forma de contacto en que el cliente se comunico con el local");
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(194, 39);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(258, 20);
            this.dtpFecha.TabIndex = 61;
            this.ttpMensajesDeAyuda.SetToolTip(this.dtpFecha, "Fecha en que se asignara la reserva");
            this.dtpFecha.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            this.dtpFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpFecha_KeyPress);
            // 
            // btnCargarCliente
            // 
            this.btnCargarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCargarCliente.FlatAppearance.BorderSize = 2;
            this.btnCargarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCargarCliente.Location = new System.Drawing.Point(63, 154);
            this.btnCargarCliente.Name = "btnCargarCliente";
            this.btnCargarCliente.Size = new System.Drawing.Size(160, 50);
            this.btnCargarCliente.TabIndex = 62;
            this.btnCargarCliente.Text = "Buscar y cargar cliente";
            this.btnCargarCliente.UseVisualStyleBackColor = false;
            this.btnCargarCliente.Click += new System.EventHandler(this.BtnCargarCliente_Click);
            this.btnCargarCliente.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCargarCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblDatosDelCliente
            // 
            this.lblDatosDelCliente.AutoSize = true;
            this.lblDatosDelCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblDatosDelCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosDelCliente.ForeColor = System.Drawing.Color.Gray;
            this.lblDatosDelCliente.Location = new System.Drawing.Point(67, 8);
            this.lblDatosDelCliente.Name = "lblDatosDelCliente";
            this.lblDatosDelCliente.Size = new System.Drawing.Size(152, 19);
            this.lblDatosDelCliente.TabIndex = 63;
            this.lblDatosDelCliente.Text = "DATOS DEL CLIENTE";
            // 
            // lblDatosDeLaReserva
            // 
            this.lblDatosDeLaReserva.AutoSize = true;
            this.lblDatosDeLaReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblDatosDeLaReserva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosDeLaReserva.ForeColor = System.Drawing.Color.Gray;
            this.lblDatosDeLaReserva.Location = new System.Drawing.Point(168, 8);
            this.lblDatosDeLaReserva.Name = "lblDatosDeLaReserva";
            this.lblDatosDeLaReserva.Size = new System.Drawing.Size(175, 19);
            this.lblDatosDeLaReserva.TabIndex = 64;
            this.lblDatosDeLaReserva.Text = "DATOS DE LA RESERVA";
            // 
            // pnlContFrm
            // 
            this.pnlContFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContFrm.Controls.Add(this.btnCrearReserva);
            this.pnlContFrm.Controls.Add(this.pnlContDatosCliente);
            this.pnlContFrm.Controls.Add(this.pnlContDatosReserva);
            this.pnlContFrm.Controls.Add(this.btnGuardarCambios);
            this.pnlContFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContFrm.Name = "pnlContFrm";
            this.pnlContFrm.Size = new System.Drawing.Size(1054, 268);
            this.pnlContFrm.TabIndex = 0;
            // 
            // btnCrearReserva
            // 
            this.btnCrearReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearReserva.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrearReserva.FlatAppearance.BorderSize = 2;
            this.btnCrearReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReserva.ForeColor = System.Drawing.Color.White;
            this.btnCrearReserva.Location = new System.Drawing.Point(885, 205);
            this.btnCrearReserva.Name = "btnCrearReserva";
            this.btnCrearReserva.Size = new System.Drawing.Size(160, 50);
            this.btnCrearReserva.TabIndex = 65;
            this.btnCrearReserva.Text = "Crear reserva";
            this.btnCrearReserva.UseVisualStyleBackColor = false;
            this.btnCrearReserva.Click += new System.EventHandler(this.BtnCrearReserva_Click);
            this.btnCrearReserva.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCrearReserva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // pnlContDatosCliente
            // 
            this.pnlContDatosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlContDatosCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContDatosCliente.Controls.Add(this.lblMostrarTelefono);
            this.pnlContDatosCliente.Controls.Add(this.lblMostrarApellido);
            this.pnlContDatosCliente.Controls.Add(this.lblMostrarNombre);
            this.pnlContDatosCliente.Controls.Add(this.lblDatosDelCliente);
            this.pnlContDatosCliente.Controls.Add(this.btnCargarCliente);
            this.pnlContDatosCliente.Controls.Add(this.lblNombre);
            this.pnlContDatosCliente.Controls.Add(this.lblTelefono);
            this.pnlContDatosCliente.Controls.Add(this.lblApellido);
            this.pnlContDatosCliente.Location = new System.Drawing.Point(11, 42);
            this.pnlContDatosCliente.Name = "pnlContDatosCliente";
            this.pnlContDatosCliente.Size = new System.Drawing.Size(282, 213);
            this.pnlContDatosCliente.TabIndex = 66;
            // 
            // pnlContDatosReserva
            // 
            this.pnlContDatosReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContDatosReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContDatosReserva.Controls.Add(this.btnVerMesasCargadas);
            this.pnlContDatosReserva.Controls.Add(this.btnSeleccionarMesas);
            this.pnlContDatosReserva.Controls.Add(this.lblDatosDeLaReserva);
            this.pnlContDatosReserva.Controls.Add(this.pnlDecorativo3);
            this.pnlContDatosReserva.Controls.Add(this.nudCantidadPersonas);
            this.pnlContDatosReserva.Controls.Add(this.lblFecha);
            this.pnlContDatosReserva.Controls.Add(this.dtpFecha);
            this.pnlContDatosReserva.Controls.Add(this.lblCantidadPersonas);
            this.pnlContDatosReserva.Controls.Add(this.cmbFormaContacto);
            this.pnlContDatosReserva.Controls.Add(this.lblFormaContacto);
            this.pnlContDatosReserva.Controls.Add(this.lblMesaCliente);
            this.pnlContDatosReserva.Controls.Add(this.lblHorario);
            this.pnlContDatosReserva.Controls.Add(this.pnlDecorativo8);
            this.pnlContDatosReserva.Controls.Add(this.mtbHorario);
            this.pnlContDatosReserva.Location = new System.Drawing.Point(289, 42);
            this.pnlContDatosReserva.Name = "pnlContDatosReserva";
            this.pnlContDatosReserva.Size = new System.Drawing.Size(588, 213);
            this.pnlContDatosReserva.TabIndex = 67;
            // 
            // btnVerMesasCargadas
            // 
            this.btnVerMesasCargadas.BackColor = System.Drawing.Color.Transparent;
            this.btnVerMesasCargadas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerMesasCargadas.FlatAppearance.BorderSize = 2;
            this.btnVerMesasCargadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMesasCargadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMesasCargadas.ForeColor = System.Drawing.Color.White;
            this.btnVerMesasCargadas.Location = new System.Drawing.Point(360, 154);
            this.btnVerMesasCargadas.Name = "btnVerMesasCargadas";
            this.btnVerMesasCargadas.Size = new System.Drawing.Size(160, 50);
            this.btnVerMesasCargadas.TabIndex = 66;
            this.btnVerMesasCargadas.Text = "Ver las mesas asignadas";
            this.btnVerMesasCargadas.UseVisualStyleBackColor = false;
            this.btnVerMesasCargadas.Click += new System.EventHandler(this.BtnVerMesasCargadas_Click);
            this.btnVerMesasCargadas.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnVerMesasCargadas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblMostrarTelefono
            // 
            this.lblMostrarTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMostrarTelefono.AutoSize = true;
            this.lblMostrarTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarTelefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMostrarTelefono.Location = new System.Drawing.Point(82, 108);
            this.lblMostrarTelefono.Name = "lblMostrarTelefono";
            this.lblMostrarTelefono.Size = new System.Drawing.Size(74, 18);
            this.lblMostrarTelefono.TabIndex = 78;
            this.lblMostrarTelefono.Text = "Telefono";
            this.lblMostrarTelefono.Visible = false;
            // 
            // lblMostrarApellido
            // 
            this.lblMostrarApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMostrarApellido.AutoSize = true;
            this.lblMostrarApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarApellido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMostrarApellido.Location = new System.Drawing.Point(82, 78);
            this.lblMostrarApellido.Name = "lblMostrarApellido";
            this.lblMostrarApellido.Size = new System.Drawing.Size(67, 18);
            this.lblMostrarApellido.TabIndex = 77;
            this.lblMostrarApellido.Text = "Apellido";
            this.lblMostrarApellido.Visible = false;
            // 
            // lblMostrarNombre
            // 
            this.lblMostrarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMostrarNombre.AutoSize = true;
            this.lblMostrarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMostrarNombre.Location = new System.Drawing.Point(81, 47);
            this.lblMostrarNombre.Name = "lblMostrarNombre";
            this.lblMostrarNombre.Size = new System.Drawing.Size(68, 18);
            this.lblMostrarNombre.TabIndex = 76;
            this.lblMostrarNombre.Text = "Nombre";
            this.lblMostrarNombre.Visible = false;
            // 
            // FrmAdministrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1054, 268);
            this.Controls.Add(this.pnlContFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarReserva";
            this.Load += new System.EventHandler(this.FrmEditarReserva_Load);
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPersonas)).EndInit();
            this.pnlContFrm.ResumeLayout(false);
            this.pnlContDatosCliente.ResumeLayout(false);
            this.pnlContDatosCliente.PerformLayout();
            this.pnlContDatosReserva.ResumeLayout(false);
            this.pnlContDatosReserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlDecorativo3;
        private System.Windows.Forms.NumericUpDown nudCantidadPersonas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantidadPersonas;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label lblMesaCliente;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.MaskedTextBox mtbHorario;
        private System.Windows.Forms.Panel pnlDecorativo8;
        private System.Windows.Forms.Button btnSeleccionarMesas;
        private System.Windows.Forms.Label lblFormaContacto;
        private System.Windows.Forms.ComboBox cmbFormaContacto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCargarCliente;
        private System.Windows.Forms.Label lblDatosDelCliente;
        private System.Windows.Forms.Label lblDatosDeLaReserva;
        private System.Windows.Forms.Panel pnlContFrm;
        private System.Windows.Forms.Button btnCrearReserva;
        private System.Windows.Forms.Panel pnlContDatosCliente;
        private System.Windows.Forms.Panel pnlContDatosReserva;
        private System.Windows.Forms.Button btnVerMesasCargadas;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Label lblTituloFrm;
        private System.Windows.Forms.Label lblMostrarTelefono;
        private System.Windows.Forms.Label lblMostrarApellido;
        private System.Windows.Forms.Label lblMostrarNombre;
    }
}