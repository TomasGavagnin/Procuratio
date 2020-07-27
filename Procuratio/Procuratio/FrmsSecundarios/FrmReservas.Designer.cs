namespace Procuratio
{
    partial class FrmReservas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContenedorCalendario = new System.Windows.Forms.Panel();
            this.btnSeleccionarMesas = new System.Windows.Forms.Button();
            this.pnlDecorativo8 = new System.Windows.Forms.Panel();
            this.mtbHorario = new System.Windows.Forms.MaskedTextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblMesaCliente = new System.Windows.Forms.Label();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnCrearReserva = new System.Windows.Forms.Button();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.pnlDecorativo6 = new System.Windows.Forms.Panel();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaSeleccionada = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlDecorativo5 = new System.Windows.Forms.Panel();
            this.pnlDecorativo4 = new System.Windows.Forms.Panel();
            this.nudCantidadPersonas = new System.Windows.Forms.NumericUpDown();
            this.pnlDecorativo3 = new System.Windows.Forms.Panel();
            this.pnlDecorativo2 = new System.Windows.Forms.Panel();
            this.pnlDecorativo1 = new System.Windows.Forms.Panel();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRegistroDeDatos = new System.Windows.Forms.Label();
            this.mclFechaReserva = new System.Windows.Forms.MonthCalendar();
            this.dgvDatosReservas = new System.Windows.Forms.DataGridView();
            this.dgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidadDePersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumeroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSeleccionDeFilas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEliminarElementos = new System.Windows.Forms.Button();
            this.btnEditarElemento = new System.Windows.Forms.Button();
            this.pnlContenedorCalendario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedorCalendario
            // 
            this.pnlContenedorCalendario.AutoScroll = true;
            this.pnlContenedorCalendario.Controls.Add(this.btnSeleccionarMesas);
            this.pnlContenedorCalendario.Controls.Add(this.pnlDecorativo8);
            this.pnlContenedorCalendario.Controls.Add(this.mtbHorario);
            this.pnlContenedorCalendario.Controls.Add(this.lblHorario);
            this.pnlContenedorCalendario.Controls.Add(this.lblMesaCliente);
            this.pnlContenedorCalendario.Controls.Add(this.btnCancelarReserva);
            this.pnlContenedorCalendario.Controls.Add(this.btnCrearReserva);
            this.pnlContenedorCalendario.Controls.Add(this.txtApellidoCliente);
            this.pnlContenedorCalendario.Controls.Add(this.pnlDecorativo6);
            this.pnlContenedorCalendario.Controls.Add(this.lblApellido);
            this.pnlContenedorCalendario.Controls.Add(this.lblFechaSeleccionada);
            this.pnlContenedorCalendario.Controls.Add(this.lblFecha);
            this.pnlContenedorCalendario.Controls.Add(this.pnlDecorativo5);
            this.pnlContenedorCalendario.Controls.Add(this.pnlDecorativo4);
            this.pnlContenedorCalendario.Controls.Add(this.nudCantidadPersonas);
            this.pnlContenedorCalendario.Controls.Add(this.pnlDecorativo3);
            this.pnlContenedorCalendario.Controls.Add(this.pnlDecorativo2);
            this.pnlContenedorCalendario.Controls.Add(this.pnlDecorativo1);
            this.pnlContenedorCalendario.Controls.Add(this.txtTelefonoCliente);
            this.pnlContenedorCalendario.Controls.Add(this.txtNombreCliente);
            this.pnlContenedorCalendario.Controls.Add(this.lblCantidadPersonas);
            this.pnlContenedorCalendario.Controls.Add(this.lblTelefono);
            this.pnlContenedorCalendario.Controls.Add(this.lblNombre);
            this.pnlContenedorCalendario.Controls.Add(this.lblRegistroDeDatos);
            this.pnlContenedorCalendario.Controls.Add(this.mclFechaReserva);
            this.pnlContenedorCalendario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContenedorCalendario.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorCalendario.Name = "pnlContenedorCalendario";
            this.pnlContenedorCalendario.Size = new System.Drawing.Size(935, 215);
            this.pnlContenedorCalendario.TabIndex = 2;
            // 
            // btnSeleccionarMesas
            // 
            this.btnSeleccionarMesas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSeleccionarMesas.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarMesas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSeleccionarMesas.FlatAppearance.BorderSize = 2;
            this.btnSeleccionarMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarMesas.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarMesas.Location = new System.Drawing.Point(442, 155);
            this.btnSeleccionarMesas.Name = "btnSeleccionarMesas";
            this.btnSeleccionarMesas.Size = new System.Drawing.Size(160, 50);
            this.btnSeleccionarMesas.TabIndex = 29;
            this.btnSeleccionarMesas.Text = "Seleccionar mesas";
            this.btnSeleccionarMesas.UseVisualStyleBackColor = false;
            this.btnSeleccionarMesas.Click += new System.EventHandler(this.btnSeleccionarMesas_Click);
            this.btnSeleccionarMesas.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnSeleccionarMesas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // pnlDecorativo8
            // 
            this.pnlDecorativo8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDecorativo8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo8.Location = new System.Drawing.Point(880, 55);
            this.pnlDecorativo8.Name = "pnlDecorativo8";
            this.pnlDecorativo8.Size = new System.Drawing.Size(44, 2);
            this.pnlDecorativo8.TabIndex = 6;
            // 
            // mtbHorario
            // 
            this.mtbHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.mtbHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbHorario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.mtbHorario.ForeColor = System.Drawing.Color.DarkGray;
            this.mtbHorario.Location = new System.Drawing.Point(880, 36);
            this.mtbHorario.Mask = "00:00";
            this.mtbHorario.Name = "mtbHorario";
            this.mtbHorario.Size = new System.Drawing.Size(44, 19);
            this.mtbHorario.TabIndex = 29;
            this.mtbHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbHorario.ValidatingType = typeof(System.DateTime);
            this.mtbHorario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbHorario_KeyPress);
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHorario.Location = new System.Drawing.Point(807, 36);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(70, 18);
            this.lblHorario.TabIndex = 31;
            this.lblHorario.Text = "Horario:";
            // 
            // lblMesaCliente
            // 
            this.lblMesaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMesaCliente.AutoSize = true;
            this.lblMesaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMesaCliente.Location = new System.Drawing.Point(281, 170);
            this.lblMesaCliente.Name = "lblMesaCliente";
            this.lblMesaCliente.Size = new System.Drawing.Size(156, 18);
            this.lblMesaCliente.TabIndex = 27;
            this.lblMesaCliente.Text = "Mesa/s reservada/s";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarReserva.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelarReserva.FlatAppearance.BorderSize = 2;
            this.btnCancelarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReserva.ForeColor = System.Drawing.Color.White;
            this.btnCancelarReserva.Location = new System.Drawing.Point(765, 174);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(160, 30);
            this.btnCancelarReserva.TabIndex = 26;
            this.btnCancelarReserva.Text = "Cancelar todo";
            this.btnCancelarReserva.UseVisualStyleBackColor = false;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            this.btnCancelarReserva.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCancelarReserva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnCrearReserva
            // 
            this.btnCrearReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearReserva.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrearReserva.FlatAppearance.BorderSize = 2;
            this.btnCrearReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReserva.ForeColor = System.Drawing.Color.White;
            this.btnCrearReserva.Location = new System.Drawing.Point(765, 139);
            this.btnCrearReserva.Name = "btnCrearReserva";
            this.btnCrearReserva.Size = new System.Drawing.Size(160, 30);
            this.btnCrearReserva.TabIndex = 3;
            this.btnCrearReserva.Text = "Crear";
            this.btnCrearReserva.UseVisualStyleBackColor = false;
            this.btnCrearReserva.Click += new System.EventHandler(this.btnCrearReserva_Click);
            this.btnCrearReserva.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCrearReserva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtApellidoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCliente.ForeColor = System.Drawing.Color.DarkGray;
            this.txtApellidoCliente.Location = new System.Drawing.Point(701, 66);
            this.txtApellidoCliente.MaxLength = 20;
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(224, 19);
            this.txtApellidoCliente.TabIndex = 25;
            this.txtApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // pnlDecorativo6
            // 
            this.pnlDecorativo6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDecorativo6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo6.Location = new System.Drawing.Point(701, 85);
            this.pnlDecorativo6.Name = "pnlDecorativo6";
            this.pnlDecorativo6.Size = new System.Drawing.Size(224, 2);
            this.pnlDecorativo6.TabIndex = 24;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblApellido.Location = new System.Drawing.Point(625, 65);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(72, 18);
            this.lblApellido.TabIndex = 25;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblFechaSeleccionada
            // 
            this.lblFechaSeleccionada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaSeleccionada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblFechaSeleccionada.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSeleccionada.ForeColor = System.Drawing.Color.DarkGray;
            this.lblFechaSeleccionada.Location = new System.Drawing.Point(442, 36);
            this.lblFechaSeleccionada.Name = "lblFechaSeleccionada";
            this.lblFechaSeleccionada.Size = new System.Drawing.Size(361, 19);
            this.lblFechaSeleccionada.TabIndex = 6;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFecha.Location = new System.Drawing.Point(380, 36);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 18);
            this.lblFecha.TabIndex = 24;
            this.lblFecha.Text = "Fecha:";
            // 
            // pnlDecorativo5
            // 
            this.pnlDecorativo5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDecorativo5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo5.Location = new System.Drawing.Point(442, 56);
            this.pnlDecorativo5.Name = "pnlDecorativo5";
            this.pnlDecorativo5.Size = new System.Drawing.Size(361, 2);
            this.pnlDecorativo5.TabIndex = 5;
            // 
            // pnlDecorativo4
            // 
            this.pnlDecorativo4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDecorativo4.Location = new System.Drawing.Point(0, 213);
            this.pnlDecorativo4.Name = "pnlDecorativo4";
            this.pnlDecorativo4.Size = new System.Drawing.Size(935, 2);
            this.pnlDecorativo4.TabIndex = 6;
            // 
            // nudCantidadPersonas
            // 
            this.nudCantidadPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.nudCantidadPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadPersonas.ForeColor = System.Drawing.Color.DarkGray;
            this.nudCantidadPersonas.Location = new System.Drawing.Point(442, 124);
            this.nudCantidadPersonas.Maximum = new decimal(new int[] {
            20,
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
            this.nudCantidadPersonas.TabIndex = 3;
            this.nudCantidadPersonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidadPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadPersonas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudCantidadPersonas_KeyPress);
            // 
            // pnlDecorativo3
            // 
            this.pnlDecorativo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo3.Location = new System.Drawing.Point(442, 144);
            this.pnlDecorativo3.Name = "pnlDecorativo3";
            this.pnlDecorativo3.Size = new System.Drawing.Size(55, 2);
            this.pnlDecorativo3.TabIndex = 5;
            // 
            // pnlDecorativo2
            // 
            this.pnlDecorativo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDecorativo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo2.Location = new System.Drawing.Point(441, 115);
            this.pnlDecorativo2.Name = "pnlDecorativo2";
            this.pnlDecorativo2.Size = new System.Drawing.Size(484, 2);
            this.pnlDecorativo2.TabIndex = 4;
            // 
            // pnlDecorativo1
            // 
            this.pnlDecorativo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo1.Location = new System.Drawing.Point(442, 85);
            this.pnlDecorativo1.Name = "pnlDecorativo1";
            this.pnlDecorativo1.Size = new System.Drawing.Size(180, 2);
            this.pnlDecorativo1.TabIndex = 3;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtTelefonoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCliente.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(441, 96);
            this.txtTelefonoCliente.MaxLength = 12;
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(484, 19);
            this.txtTelefonoCliente.TabIndex = 23;
            this.txtTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoCliente_KeyPress);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreCliente.Location = new System.Drawing.Point(442, 66);
            this.txtNombreCliente.MaxLength = 20;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(180, 19);
            this.txtNombreCliente.TabIndex = 4;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPersonas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidadPersonas.Location = new System.Drawing.Point(262, 124);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(177, 18);
            this.lblCantidadPersonas.TabIndex = 22;
            this.lblCantidadPersonas.Text = "Cantidad de personas:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTelefono.Location = new System.Drawing.Point(360, 95);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 18);
            this.lblTelefono.TabIndex = 21;
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
            this.lblNombre.Location = new System.Drawing.Point(372, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 18);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombe:";
            // 
            // lblRegistroDeDatos
            // 
            this.lblRegistroDeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblRegistroDeDatos.AutoSize = true;
            this.lblRegistroDeDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroDeDatos.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistroDeDatos.Location = new System.Drawing.Point(417, 9);
            this.lblRegistroDeDatos.Name = "lblRegistroDeDatos";
            this.lblRegistroDeDatos.Size = new System.Drawing.Size(396, 19);
            this.lblRegistroDeDatos.TabIndex = 20;
            this.lblRegistroDeDatos.Text = "COMPLETAR LOS CAMPOS PARA CREAR LA RESERVA";
            // 
            // mclFechaReserva
            // 
            this.mclFechaReserva.Location = new System.Drawing.Point(9, 10);
            this.mclFechaReserva.Name = "mclFechaReserva";
            this.mclFechaReserva.TabIndex = 0;
            this.mclFechaReserva.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mclFechaReserva_DateChanged);
            // 
            // dgvDatosReservas
            // 
            this.dgvDatosReservas.AllowUserToOrderColumns = true;
            this.dgvDatosReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosReservas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDatosReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvDatosReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatosReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosReservas.ColumnHeadersHeight = 45;
            this.dgvDatosReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatosReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFecha,
            this.dgvHora,
            this.dgvNombre,
            this.dgvApellido,
            this.dgvTelefono,
            this.dgvCantidadDePersonas,
            this.dgvNumeroMesa,
            this.dgvSeleccionDeFilas});
            this.dgvDatosReservas.EnableHeadersVisualStyles = false;
            this.dgvDatosReservas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDatosReservas.Location = new System.Drawing.Point(7, 221);
            this.dgvDatosReservas.Name = "dgvDatosReservas";
            this.dgvDatosReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosReservas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvDatosReservas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDatosReservas.Size = new System.Drawing.Size(747, 337);
            this.dgvDatosReservas.TabIndex = 3;
            // 
            // dgvFecha
            // 
            this.dgvFecha.Frozen = true;
            this.dgvFecha.HeaderText = "Fecha";
            this.dgvFecha.Name = "dgvFecha";
            this.dgvFecha.Width = 69;
            // 
            // dgvHora
            // 
            this.dgvHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHora.HeaderText = "Hora";
            this.dgvHora.Name = "dgvHora";
            // 
            // dgvNombre
            // 
            this.dgvNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.Name = "dgvNombre";
            // 
            // dgvApellido
            // 
            this.dgvApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvApellido.HeaderText = "Apellido";
            this.dgvApellido.Name = "dgvApellido";
            // 
            // dgvTelefono
            // 
            this.dgvTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTelefono.HeaderText = "Telefono";
            this.dgvTelefono.Name = "dgvTelefono";
            // 
            // dgvCantidadDePersonas
            // 
            this.dgvCantidadDePersonas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCantidadDePersonas.HeaderText = "Cantidad";
            this.dgvCantidadDePersonas.Name = "dgvCantidadDePersonas";
            // 
            // dgvNumeroMesa
            // 
            this.dgvNumeroMesa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNumeroMesa.HeaderText = "Numero/s de Mesa/s";
            this.dgvNumeroMesa.Name = "dgvNumeroMesa";
            // 
            // dgvSeleccionDeFilas
            // 
            this.dgvSeleccionDeFilas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSeleccionDeFilas.HeaderText = "Seleccionar";
            this.dgvSeleccionDeFilas.Name = "dgvSeleccionDeFilas";
            // 
            // btnEliminarElementos
            // 
            this.btnEliminarElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarElementos.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarElementos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarElementos.FlatAppearance.BorderSize = 2;
            this.btnEliminarElementos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarElementos.ForeColor = System.Drawing.Color.White;
            this.btnEliminarElementos.Location = new System.Drawing.Point(765, 507);
            this.btnEliminarElementos.Name = "btnEliminarElementos";
            this.btnEliminarElementos.Size = new System.Drawing.Size(160, 50);
            this.btnEliminarElementos.TabIndex = 27;
            this.btnEliminarElementos.Text = "Eliminar elementos seleccionados";
            this.btnEliminarElementos.UseVisualStyleBackColor = false;
            this.btnEliminarElementos.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnEliminarElementos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnEditarElemento
            // 
            this.btnEditarElemento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarElemento.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarElemento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarElemento.FlatAppearance.BorderSize = 2;
            this.btnEditarElemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarElemento.ForeColor = System.Drawing.Color.White;
            this.btnEditarElemento.Location = new System.Drawing.Point(765, 451);
            this.btnEditarElemento.Name = "btnEditarElemento";
            this.btnEditarElemento.Size = new System.Drawing.Size(160, 50);
            this.btnEditarElemento.TabIndex = 28;
            this.btnEditarElemento.Text = "Editar elemento seleccionado";
            this.btnEditarElemento.UseVisualStyleBackColor = false;
            this.btnEditarElemento.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnEditarElemento.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(935, 565);
            this.Controls.Add(this.btnEditarElemento);
            this.Controls.Add(this.btnEliminarElementos);
            this.Controls.Add(this.dgvDatosReservas);
            this.Controls.Add(this.pnlContenedorCalendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReservas";
            this.Text = "FrmReservascs";
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            this.pnlContenedorCalendario.ResumeLayout(false);
            this.pnlContenedorCalendario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContenedorCalendario;
        private System.Windows.Forms.Panel pnlDecorativo1;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.MonthCalendar mclFechaReserva;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRegistroDeDatos;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label lblCantidadPersonas;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Panel pnlDecorativo3;
        private System.Windows.Forms.Panel pnlDecorativo2;
        private System.Windows.Forms.NumericUpDown nudCantidadPersonas;
        private System.Windows.Forms.Panel pnlDecorativo4;
        private System.Windows.Forms.Label lblFechaSeleccionada;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlDecorativo5;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Panel pnlDecorativo6;
        private System.Windows.Forms.Button btnCrearReserva;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.DataGridView dgvDatosReservas;
        private System.Windows.Forms.Label lblMesaCliente;
        private System.Windows.Forms.Button btnEliminarElementos;
        private System.Windows.Forms.Button btnEditarElemento;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.MaskedTextBox mtbHorario;
        private System.Windows.Forms.Panel pnlDecorativo8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidadDePersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumeroMesa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvSeleccionDeFilas;
        private System.Windows.Forms.Button btnSeleccionarMesas;
    }
}