namespace Procuratio.FrmsSecundarios.FrmsTemporales.FrmDelivery
{
    partial class FrmCrearEditarDelivery
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
            this.PnlContFrm = new System.Windows.Forms.Panel();
            this.btnCrearDelivery = new System.Windows.Forms.Button();
            this.pnlContDatosCliente = new System.Windows.Forms.Panel();
            this.lblMostrarTelefono = new System.Windows.Forms.Label();
            this.lblMostrarApellido = new System.Windows.Forms.Label();
            this.lblMostrarNombre = new System.Windows.Forms.Label();
            this.lblDatosDelCliente = new System.Windows.Forms.Label();
            this.btnCargarCliente = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.pnlContDatosReserva = new System.Windows.Forms.Panel();
            this.lblChef = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbNombreChef = new System.Windows.Forms.ComboBox();
            this.ckbRetiraEnElLocal = new System.Windows.Forms.CheckBox();
            this.txtTelefonoCadete = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVerEditarPedido = new System.Windows.Forms.Button();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblTelefonoCadete = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDatosDeLaReserva = new System.Windows.Forms.Label();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picBTNInformacion = new System.Windows.Forms.PictureBox();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.tmrColor = new System.Windows.Forms.Timer(this.components);
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.PnlContFrm.SuspendLayout();
            this.pnlContDatosCliente.SuspendLayout();
            this.pnlContDatosReserva.SuspendLayout();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlContFrm
            // 
            this.PnlContFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlContFrm.Controls.Add(this.btnCrearDelivery);
            this.PnlContFrm.Controls.Add(this.pnlContDatosCliente);
            this.PnlContFrm.Controls.Add(this.pnlContDatosReserva);
            this.PnlContFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.PnlContFrm.Controls.Add(this.btnGuardarCambios);
            this.PnlContFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContFrm.Location = new System.Drawing.Point(0, 0);
            this.PnlContFrm.Name = "PnlContFrm";
            this.PnlContFrm.Size = new System.Drawing.Size(1024, 320);
            this.PnlContFrm.TabIndex = 0;
            // 
            // btnCrearDelivery
            // 
            this.btnCrearDelivery.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearDelivery.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrearDelivery.FlatAppearance.BorderSize = 2;
            this.btnCrearDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearDelivery.ForeColor = System.Drawing.Color.White;
            this.btnCrearDelivery.Location = new System.Drawing.Point(855, 260);
            this.btnCrearDelivery.Name = "btnCrearDelivery";
            this.btnCrearDelivery.Size = new System.Drawing.Size(160, 50);
            this.btnCrearDelivery.TabIndex = 69;
            this.btnCrearDelivery.Text = "Crear delivery";
            this.btnCrearDelivery.UseVisualStyleBackColor = false;
            this.btnCrearDelivery.Click += new System.EventHandler(this.BtnCrearDelivery_Click);
            this.btnCrearDelivery.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCrearDelivery.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
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
            this.pnlContDatosCliente.Location = new System.Drawing.Point(14, 45);
            this.pnlContDatosCliente.Name = "pnlContDatosCliente";
            this.pnlContDatosCliente.Size = new System.Drawing.Size(282, 266);
            this.pnlContDatosCliente.TabIndex = 70;
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
            this.lblMostrarTelefono.TabIndex = 75;
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
            this.lblMostrarApellido.TabIndex = 74;
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
            this.lblMostrarNombre.TabIndex = 73;
            this.lblMostrarNombre.Text = "Nombre";
            this.lblMostrarNombre.Visible = false;
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
            // btnCargarCliente
            // 
            this.btnCargarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCargarCliente.FlatAppearance.BorderSize = 2;
            this.btnCargarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCargarCliente.Location = new System.Drawing.Point(63, 207);
            this.btnCargarCliente.Name = "btnCargarCliente";
            this.btnCargarCliente.Size = new System.Drawing.Size(160, 50);
            this.btnCargarCliente.TabIndex = 62;
            this.btnCargarCliente.Text = "Buscar y cargar cliente";
            this.btnCargarCliente.UseVisualStyleBackColor = false;
            this.btnCargarCliente.Click += new System.EventHandler(this.BtnCargarCliente_Click);
            this.btnCargarCliente.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCargarCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
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
            // pnlContDatosReserva
            // 
            this.pnlContDatosReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContDatosReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContDatosReserva.Controls.Add(this.lblChef);
            this.pnlContDatosReserva.Controls.Add(this.txtDireccion);
            this.pnlContDatosReserva.Controls.Add(this.cmbNombreChef);
            this.pnlContDatosReserva.Controls.Add(this.ckbRetiraEnElLocal);
            this.pnlContDatosReserva.Controls.Add(this.txtTelefonoCadete);
            this.pnlContDatosReserva.Controls.Add(this.panel1);
            this.pnlContDatosReserva.Controls.Add(this.btnVerEditarPedido);
            this.pnlContDatosReserva.Controls.Add(this.lblPedido);
            this.pnlContDatosReserva.Controls.Add(this.lblTelefonoCadete);
            this.pnlContDatosReserva.Controls.Add(this.lblDireccion);
            this.pnlContDatosReserva.Controls.Add(this.lblDatosDeLaReserva);
            this.pnlContDatosReserva.Location = new System.Drawing.Point(292, 45);
            this.pnlContDatosReserva.Name = "pnlContDatosReserva";
            this.pnlContDatosReserva.Size = new System.Drawing.Size(552, 266);
            this.pnlContDatosReserva.TabIndex = 71;
            // 
            // lblChef
            // 
            this.lblChef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChef.AutoSize = true;
            this.lblChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChef.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblChef.Location = new System.Drawing.Point(214, 142);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(48, 18);
            this.lblChef.TabIndex = 77;
            this.lblChef.Text = "Chef:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDireccion.Location = new System.Drawing.Point(266, 65);
            this.txtDireccion.MaxLength = 30;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(270, 64);
            this.txtDireccion.TabIndex = 69;
            this.txtDireccion.Text = "Se retira en el local";
            this.ttpMensajesDeAyuda.SetToolTip(this.txtDireccion, "Direccion a donde se deberá enviar el pedido");
            // 
            // cmbNombreChef
            // 
            this.cmbNombreChef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNombreChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.cmbNombreChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNombreChef.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbNombreChef.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbNombreChef.FormattingEnabled = true;
            this.cmbNombreChef.Location = new System.Drawing.Point(266, 139);
            this.cmbNombreChef.Name = "cmbNombreChef";
            this.cmbNombreChef.Size = new System.Drawing.Size(270, 26);
            this.cmbNombreChef.TabIndex = 76;
            this.cmbNombreChef.Text = "Nombre del chef";
            this.ttpMensajesDeAyuda.SetToolTip(this.cmbNombreChef, "Chef que preparara el pedido");
            // 
            // ckbRetiraEnElLocal
            // 
            this.ckbRetiraEnElLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbRetiraEnElLocal.AutoSize = true;
            this.ckbRetiraEnElLocal.Checked = true;
            this.ckbRetiraEnElLocal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbRetiraEnElLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckbRetiraEnElLocal.ForeColor = System.Drawing.Color.White;
            this.ckbRetiraEnElLocal.Location = new System.Drawing.Point(266, 37);
            this.ckbRetiraEnElLocal.Name = "ckbRetiraEnElLocal";
            this.ckbRetiraEnElLocal.Size = new System.Drawing.Size(227, 22);
            this.ckbRetiraEnElLocal.TabIndex = 75;
            this.ckbRetiraEnElLocal.Text = "Retira el pedido en el local";
            this.ttpMensajesDeAyuda.SetToolTip(this.ckbRetiraEnElLocal, "Si marca esta opcion, no debera especificar la direccion de envio ya que se retir" +
        "ará en el local el pedido");
            this.ckbRetiraEnElLocal.UseVisualStyleBackColor = true;
            this.ckbRetiraEnElLocal.CheckedChanged += new System.EventHandler(this.CkbRetiraEnElLocal_CheckedChanged);
            // 
            // txtTelefonoCadete
            // 
            this.txtTelefonoCadete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtTelefonoCadete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonoCadete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCadete.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTelefonoCadete.Location = new System.Drawing.Point(266, 174);
            this.txtTelefonoCadete.MaxLength = 20;
            this.txtTelefonoCadete.Name = "txtTelefonoCadete";
            this.txtTelefonoCadete.Size = new System.Drawing.Size(270, 19);
            this.txtTelefonoCadete.TabIndex = 74;
            this.ttpMensajesDeAyuda.SetToolTip(this.txtTelefonoCadete, "Telefono del cadete opcional para una rapida llamada si ocurre un problema con el" +
        " envio");
            this.txtTelefonoCadete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoCadete_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(266, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 2);
            this.panel1.TabIndex = 73;
            // 
            // btnVerEditarPedido
            // 
            this.btnVerEditarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnVerEditarPedido.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerEditarPedido.FlatAppearance.BorderSize = 2;
            this.btnVerEditarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEditarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEditarPedido.ForeColor = System.Drawing.Color.White;
            this.btnVerEditarPedido.Location = new System.Drawing.Point(264, 206);
            this.btnVerEditarPedido.Name = "btnVerEditarPedido";
            this.btnVerEditarPedido.Size = new System.Drawing.Size(160, 50);
            this.btnVerEditarPedido.TabIndex = 68;
            this.btnVerEditarPedido.Text = "Ver y/o editar el pedido";
            this.btnVerEditarPedido.UseVisualStyleBackColor = false;
            this.btnVerEditarPedido.Click += new System.EventHandler(this.BtnVerEditarPedido_Click);
            this.btnVerEditarPedido.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnVerEditarPedido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblPedido
            // 
            this.lblPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPedido.Location = new System.Drawing.Point(198, 221);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(60, 18);
            this.lblPedido.TabIndex = 67;
            this.lblPedido.Text = "Pedido";
            // 
            // lblTelefonoCadete
            // 
            this.lblTelefonoCadete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefonoCadete.AutoSize = true;
            this.lblTelefonoCadete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCadete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTelefonoCadete.Location = new System.Drawing.Point(20, 174);
            this.lblTelefonoCadete.Name = "lblTelefonoCadete";
            this.lblTelefonoCadete.Size = new System.Drawing.Size(242, 18);
            this.lblTelefonoCadete.TabIndex = 65;
            this.lblTelefonoCadete.Text = "Telefono del cadete (opcional):";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDireccion.Location = new System.Drawing.Point(103, 65);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(157, 18);
            this.lblDireccion.TabIndex = 64;
            this.lblDireccion.Text = "Direccion del envio:";
            // 
            // lblDatosDeLaReserva
            // 
            this.lblDatosDeLaReserva.AutoSize = true;
            this.lblDatosDeLaReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblDatosDeLaReserva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosDeLaReserva.ForeColor = System.Drawing.Color.Gray;
            this.lblDatosDeLaReserva.Location = new System.Drawing.Point(168, 8);
            this.lblDatosDeLaReserva.Name = "lblDatosDeLaReserva";
            this.lblDatosDeLaReserva.Size = new System.Drawing.Size(162, 19);
            this.lblDatosDeLaReserva.TabIndex = 64;
            this.lblDatosDeLaReserva.Text = "DATOS DEL DELIVERY";
            // 
            // pnlBarraDeArrastre
            // 
            this.pnlBarraDeArrastre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            this.pnlBarraDeArrastre.Controls.Add(this.lblTituloFrm);
            this.pnlBarraDeArrastre.Controls.Add(this.picBTNInformacion);
            this.pnlBarraDeArrastre.Controls.Add(this.picBTNCerrar);
            this.pnlBarraDeArrastre.Controls.Add(this.picLogo);
            this.pnlBarraDeArrastre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraDeArrastre.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraDeArrastre.Name = "pnlBarraDeArrastre";
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(1022, 30);
            this.pnlBarraDeArrastre.TabIndex = 1;
            this.pnlBarraDeArrastre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // lblTituloFrm
            // 
            this.lblTituloFrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTituloFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloFrm.Location = new System.Drawing.Point(41, 0);
            this.lblTituloFrm.Name = "lblTituloFrm";
            this.lblTituloFrm.Size = new System.Drawing.Size(371, 30);
            this.lblTituloFrm.TabIndex = 11;
            this.lblTituloFrm.Text = "Datos del delivery";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picBTNInformacion
            // 
            this.picBTNInformacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNInformacion.Image = global::Procuratio.Properties.Resources._3017955_48;
            this.picBTNInformacion.Location = new System.Drawing.Point(940, 0);
            this.picBTNInformacion.Name = "picBTNInformacion";
            this.picBTNInformacion.Size = new System.Drawing.Size(41, 30);
            this.picBTNInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNInformacion.TabIndex = 2;
            this.picBTNInformacion.TabStop = false;
            this.picBTNInformacion.Click += new System.EventHandler(this.PicBTNInformacion_Click);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar;
            this.picBTNCerrar.Location = new System.Drawing.Point(981, 0);
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
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarCambios.FlatAppearance.BorderSize = 2;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(855, 259);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(160, 50);
            this.btnGuardarCambios.TabIndex = 68;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Visible = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.BtnGuardarCambios_Click);
            this.btnGuardarCambios.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnGuardarCambios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // tmrColor
            // 
            this.tmrColor.Enabled = true;
            this.tmrColor.Tick += new System.EventHandler(this.tmrColor_Tick);
            // 
            // FrmCrearEditarDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1024, 320);
            this.Controls.Add(this.PnlContFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearEditarDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearDelivery";
            this.Load += new System.EventHandler(this.FrmCrearEditarDelivery_Load);
            this.PnlContFrm.ResumeLayout(false);
            this.pnlContDatosCliente.ResumeLayout(false);
            this.pnlContDatosCliente.PerformLayout();
            this.pnlContDatosReserva.ResumeLayout(false);
            this.pnlContDatosReserva.PerformLayout();
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlContFrm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.Label lblTituloFrm;
        private System.Windows.Forms.PictureBox picBTNInformacion;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnCrearDelivery;
        private System.Windows.Forms.Panel pnlContDatosCliente;
        private System.Windows.Forms.Label lblDatosDelCliente;
        private System.Windows.Forms.Button btnCargarCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel pnlContDatosReserva;
        private System.Windows.Forms.Label lblDatosDeLaReserva;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label lblTelefonoCadete;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnVerEditarPedido;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefonoCadete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbRetiraEnElLocal;
        private System.Windows.Forms.ComboBox cmbNombreChef;
        private System.Windows.Forms.Timer tmrColor;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.Label lblMostrarTelefono;
        private System.Windows.Forms.Label lblMostrarApellido;
        private System.Windows.Forms.Label lblMostrarNombre;
    }
}