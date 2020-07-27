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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRegistroDeDatos = new System.Windows.Forms.Label();
            this.dgvDatosReservas = new System.Windows.Forms.DataGridView();
            this.colID_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadDePersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroMesa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccionDeFilas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEliminarElementos = new System.Windows.Forms.Button();
            this.picLupa = new System.Windows.Forms.PictureBox();
            this.txtBuscarPorNombre = new System.Windows.Forms.TextBox();
            this.cmbEstadoReserva = new System.Windows.Forms.ComboBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpDechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblEstadoReserva = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblReservasHasta = new System.Windows.Forms.Label();
            this.btnCrearReserva = new System.Windows.Forms.Button();
            this.ckbIncluirFechaHasta = new System.Windows.Forms.CheckBox();
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.ckbIncluirFechaDesde = new System.Windows.Forms.CheckBox();
            this.btnConfirmarReserva = new System.Windows.Forms.Button();
            this.btnNoVino = new System.Windows.Forms.Button();
            this.btnVerReservas = new System.Windows.Forms.Button();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistroDeDatos
            // 
            this.lblRegistroDeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblRegistroDeDatos.AutoSize = true;
            this.lblRegistroDeDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroDeDatos.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistroDeDatos.Location = new System.Drawing.Point(371, 8);
            this.lblRegistroDeDatos.Name = "lblRegistroDeDatos";
            this.lblRegistroDeDatos.Size = new System.Drawing.Size(205, 19);
            this.lblRegistroDeDatos.TabIndex = 20;
            this.lblRegistroDeDatos.Text = "GESTION DE LAS RESERVAS";
            // 
            // dgvDatosReservas
            // 
            this.dgvDatosReservas.AllowUserToAddRows = false;
            this.dgvDatosReservas.AllowUserToDeleteRows = false;
            this.dgvDatosReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosReservas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDatosReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
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
            this.colID_Reserva,
            this.colID_Cliente,
            this.colFecha,
            this.colHora,
            this.colNombre,
            this.colApellido,
            this.colTelefono,
            this.colCantidadDePersonas,
            this.colNumeroMesa,
            this.ColEstado,
            this.colSeleccionDeFilas});
            this.dgvDatosReservas.EnableHeadersVisualStyles = false;
            this.dgvDatosReservas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDatosReservas.Location = new System.Drawing.Point(9, 99);
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
            this.dgvDatosReservas.Size = new System.Drawing.Size(747, 458);
            this.dgvDatosReservas.TabIndex = 3;
            this.dgvDatosReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatosReservas_CellContentClick);
            this.dgvDatosReservas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDatosReservas_CellMouseDoubleClick);
            // 
            // colID_Reserva
            // 
            this.colID_Reserva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colID_Reserva.HeaderText = "ID_Reserva";
            this.colID_Reserva.Name = "colID_Reserva";
            this.colID_Reserva.ReadOnly = true;
            this.colID_Reserva.Visible = false;
            this.colID_Reserva.Width = 104;
            // 
            // colID_Cliente
            // 
            this.colID_Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colID_Cliente.HeaderText = "ID_Cliente";
            this.colID_Cliente.Name = "colID_Cliente";
            this.colID_Cliente.ReadOnly = true;
            this.colID_Cliente.Visible = false;
            this.colID_Cliente.Width = 97;
            // 
            // colFecha
            // 
            this.colFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFecha.FillWeight = 80F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 90;
            // 
            // colHora
            // 
            this.colHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHora.FillWeight = 50F;
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            this.colHora.Width = 60;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.FillWeight = 80F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colApellido.FillWeight = 80F;
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTelefono.FillWeight = 90F;
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // colCantidadDePersonas
            // 
            this.colCantidadDePersonas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCantidadDePersonas.FillWeight = 60F;
            this.colCantidadDePersonas.HeaderText = "Cantidad";
            this.colCantidadDePersonas.Name = "colCantidadDePersonas";
            this.colCantidadDePersonas.ReadOnly = true;
            this.colCantidadDePersonas.Width = 63;
            // 
            // colNumeroMesa
            // 
            this.colNumeroMesa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNumeroMesa.FillWeight = 90F;
            this.colNumeroMesa.HeaderText = "Numero/s de Mesa/s";
            this.colNumeroMesa.Name = "colNumeroMesa";
            this.colNumeroMesa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNumeroMesa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colNumeroMesa.Width = 94;
            // 
            // ColEstado
            // 
            this.ColEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEstado.FillWeight = 80F;
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // colSeleccionDeFilas
            // 
            this.colSeleccionDeFilas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSeleccionDeFilas.FillWeight = 80F;
            this.colSeleccionDeFilas.HeaderText = "Seleccionar";
            this.colSeleccionDeFilas.Name = "colSeleccionDeFilas";
            this.colSeleccionDeFilas.Width = 91;
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
            this.btnEliminarElementos.Location = new System.Drawing.Point(765, 527);
            this.btnEliminarElementos.Name = "btnEliminarElementos";
            this.btnEliminarElementos.Size = new System.Drawing.Size(160, 30);
            this.btnEliminarElementos.TabIndex = 27;
            this.btnEliminarElementos.Text = "Eliminar Reserva";
            this.btnEliminarElementos.UseVisualStyleBackColor = false;
            this.btnEliminarElementos.Click += new System.EventHandler(this.BtnEliminarElementos_Click);
            this.btnEliminarElementos.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnEliminarElementos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // picLupa
            // 
            this.picLupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.picLupa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLupa.Image = global::Procuratio.Properties.Resources.Lupa;
            this.picLupa.Location = new System.Drawing.Point(9, 36);
            this.picLupa.Name = "picLupa";
            this.picLupa.Size = new System.Drawing.Size(29, 26);
            this.picLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLupa.TabIndex = 40;
            this.picLupa.TabStop = false;
            // 
            // txtBuscarPorNombre
            // 
            this.txtBuscarPorNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarPorNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtBuscarPorNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPorNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPorNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarPorNombre.Location = new System.Drawing.Point(37, 36);
            this.txtBuscarPorNombre.MaxLength = 100;
            this.txtBuscarPorNombre.Name = "txtBuscarPorNombre";
            this.txtBuscarPorNombre.Size = new System.Drawing.Size(339, 26);
            this.txtBuscarPorNombre.TabIndex = 39;
            this.txtBuscarPorNombre.Text = "Buscar por nombre de cliente...";
            this.ttpMensajesDeAyuda.SetToolTip(this.txtBuscarPorNombre, "Filtrar por nombre de cliente");
            this.txtBuscarPorNombre.Enter += new System.EventHandler(this.TxtBuscarPorNombre_Enter);
            this.txtBuscarPorNombre.Leave += new System.EventHandler(this.TxtBuscarPorNombre_Leave);
            // 
            // cmbEstadoReserva
            // 
            this.cmbEstadoReserva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstadoReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.cmbEstadoReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstadoReserva.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbEstadoReserva.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbEstadoReserva.FormattingEnabled = true;
            this.cmbEstadoReserva.Location = new System.Drawing.Point(139, 68);
            this.cmbEstadoReserva.Name = "cmbEstadoReserva";
            this.cmbEstadoReserva.Size = new System.Drawing.Size(237, 26);
            this.cmbEstadoReserva.TabIndex = 41;
            this.cmbEstadoReserva.Text = "Estado";
            this.ttpMensajesDeAyuda.SetToolTip(this.cmbEstadoReserva, "Filtrar por estado de la reserva");
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaDesde.Location = new System.Drawing.Point(453, 38);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(231, 20);
            this.dtpFechaDesde.TabIndex = 42;
            this.ttpMensajesDeAyuda.SetToolTip(this.dtpFechaDesde, "Filtrar indicando una fecha de inicio");
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.DtpFechaDesde_ValueChanged);
            this.dtpFechaDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpFechaDesde_KeyPress);
            // 
            // dtpDechaHasta
            // 
            this.dtpDechaHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDechaHasta.Location = new System.Drawing.Point(453, 72);
            this.dtpDechaHasta.Name = "dtpDechaHasta";
            this.dtpDechaHasta.Size = new System.Drawing.Size(231, 20);
            this.dtpDechaHasta.TabIndex = 43;
            this.ttpMensajesDeAyuda.SetToolTip(this.dtpDechaHasta, "Filtrar indicando una fecha de fin");
            this.dtpDechaHasta.ValueChanged += new System.EventHandler(this.DtpDechaHasta_ValueChanged);
            this.dtpDechaHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpDechaHasta_KeyPress_1);
            // 
            // lblEstadoReserva
            // 
            this.lblEstadoReserva.AutoSize = true;
            this.lblEstadoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoReserva.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstadoReserva.Location = new System.Drawing.Point(6, 72);
            this.lblEstadoReserva.Name = "lblEstadoReserva";
            this.lblEstadoReserva.Size = new System.Drawing.Size(127, 18);
            this.lblEstadoReserva.TabIndex = 44;
            this.lblEstadoReserva.Text = "Estado reserva:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaDesde.Location = new System.Drawing.Point(386, 38);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(61, 18);
            this.lblFechaDesde.TabIndex = 45;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblReservasHasta
            // 
            this.lblReservasHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReservasHasta.AutoSize = true;
            this.lblReservasHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservasHasta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblReservasHasta.Location = new System.Drawing.Point(390, 73);
            this.lblReservasHasta.Name = "lblReservasHasta";
            this.lblReservasHasta.Size = new System.Drawing.Size(57, 18);
            this.lblReservasHasta.TabIndex = 46;
            this.lblReservasHasta.Text = "Hasta:";
            // 
            // btnCrearReserva
            // 
            this.btnCrearReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearReserva.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrearReserva.FlatAppearance.BorderSize = 2;
            this.btnCrearReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReserva.ForeColor = System.Drawing.Color.White;
            this.btnCrearReserva.Location = new System.Drawing.Point(765, 211);
            this.btnCrearReserva.Name = "btnCrearReserva";
            this.btnCrearReserva.Size = new System.Drawing.Size(160, 50);
            this.btnCrearReserva.TabIndex = 48;
            this.btnCrearReserva.Text = "Crear reserva";
            this.btnCrearReserva.UseVisualStyleBackColor = false;
            this.btnCrearReserva.Click += new System.EventHandler(this.BtnCrearReserva_Click);
            this.btnCrearReserva.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCrearReserva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // ckbIncluirFechaHasta
            // 
            this.ckbIncluirFechaHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbIncluirFechaHasta.AutoSize = true;
            this.ckbIncluirFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckbIncluirFechaHasta.ForeColor = System.Drawing.Color.White;
            this.ckbIncluirFechaHasta.Location = new System.Drawing.Point(688, 71);
            this.ckbIncluirFechaHasta.Name = "ckbIncluirFechaHasta";
            this.ckbIncluirFechaHasta.Size = new System.Drawing.Size(72, 22);
            this.ckbIncluirFechaHasta.TabIndex = 49;
            this.ckbIncluirFechaHasta.Text = "Incluir";
            this.ttpMensajesDeAyuda.SetToolTip(this.ckbIncluirFechaHasta, "Si marca esta opcion, se tomara la fecha seleccionada como fin para el filtro, en" +
        " caso contrario, listara todas las reservas desde la fecha \"desde\" indicada en a" +
        "delante (si fue seleccionada)");
            this.ckbIncluirFechaHasta.UseVisualStyleBackColor = true;
            this.ckbIncluirFechaHasta.CheckedChanged += new System.EventHandler(this.CkbIncluirFechaHasta_CheckedChanged);
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnVerClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerClientes.FlatAppearance.BorderSize = 2;
            this.btnVerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClientes.ForeColor = System.Drawing.Color.White;
            this.btnVerClientes.Location = new System.Drawing.Point(765, 267);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Size = new System.Drawing.Size(160, 50);
            this.btnVerClientes.TabIndex = 50;
            this.btnVerClientes.Text = "Ver clientes";
            this.btnVerClientes.UseVisualStyleBackColor = false;
            this.btnVerClientes.Visible = false;
            this.btnVerClientes.Click += new System.EventHandler(this.BtnVerClientes_Click);
            this.btnVerClientes.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnVerClientes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // ckbIncluirFechaDesde
            // 
            this.ckbIncluirFechaDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbIncluirFechaDesde.AutoSize = true;
            this.ckbIncluirFechaDesde.Checked = true;
            this.ckbIncluirFechaDesde.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIncluirFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckbIncluirFechaDesde.ForeColor = System.Drawing.Color.White;
            this.ckbIncluirFechaDesde.Location = new System.Drawing.Point(688, 38);
            this.ckbIncluirFechaDesde.Name = "ckbIncluirFechaDesde";
            this.ckbIncluirFechaDesde.Size = new System.Drawing.Size(72, 22);
            this.ckbIncluirFechaDesde.TabIndex = 51;
            this.ckbIncluirFechaDesde.Text = "Incluir";
            this.ttpMensajesDeAyuda.SetToolTip(this.ckbIncluirFechaDesde, "Si marca esta opcion, se tomara la fecha seleccionada como inicio para el filtro," +
        " en caso contrario, listara todas las reservas hasta la fecha \"hasta\" indicada p" +
        "ara atras (si fue seleccionada)");
            this.ckbIncluirFechaDesde.UseVisualStyleBackColor = true;
            this.ckbIncluirFechaDesde.CheckedChanged += new System.EventHandler(this.CkbIncluirFechaDesde_CheckedChanged);
            // 
            // btnConfirmarReserva
            // 
            this.btnConfirmarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarReserva.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirmarReserva.FlatAppearance.BorderSize = 2;
            this.btnConfirmarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarReserva.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarReserva.Location = new System.Drawing.Point(765, 455);
            this.btnConfirmarReserva.Name = "btnConfirmarReserva";
            this.btnConfirmarReserva.Size = new System.Drawing.Size(160, 30);
            this.btnConfirmarReserva.TabIndex = 52;
            this.btnConfirmarReserva.Text = "Confirmar reserva";
            this.btnConfirmarReserva.UseVisualStyleBackColor = false;
            this.btnConfirmarReserva.Click += new System.EventHandler(this.BtnConfirmarReserva_Click);
            this.btnConfirmarReserva.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnConfirmarReserva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnNoVino
            // 
            this.btnNoVino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoVino.BackColor = System.Drawing.Color.Transparent;
            this.btnNoVino.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNoVino.FlatAppearance.BorderSize = 2;
            this.btnNoVino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoVino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoVino.ForeColor = System.Drawing.Color.White;
            this.btnNoVino.Location = new System.Drawing.Point(765, 491);
            this.btnNoVino.Name = "btnNoVino";
            this.btnNoVino.Size = new System.Drawing.Size(160, 30);
            this.btnNoVino.TabIndex = 53;
            this.btnNoVino.Text = "El cliente no vino";
            this.btnNoVino.UseVisualStyleBackColor = false;
            this.btnNoVino.Click += new System.EventHandler(this.BtnNoVino_Click);
            this.btnNoVino.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnNoVino.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnVerReservas
            // 
            this.btnVerReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerReservas.BackColor = System.Drawing.Color.Transparent;
            this.btnVerReservas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerReservas.FlatAppearance.BorderSize = 2;
            this.btnVerReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReservas.ForeColor = System.Drawing.Color.White;
            this.btnVerReservas.Location = new System.Drawing.Point(765, 155);
            this.btnVerReservas.Name = "btnVerReservas";
            this.btnVerReservas.Size = new System.Drawing.Size(160, 51);
            this.btnVerReservas.TabIndex = 54;
            this.btnVerReservas.Text = "Ver pendientes y sin confirmar de ayer en adelante";
            this.btnVerReservas.UseVisualStyleBackColor = false;
            this.btnVerReservas.Click += new System.EventHandler(this.BtnVerReservas_Click);
            this.btnVerReservas.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnVerReservas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicarFiltro.BackColor = System.Drawing.Color.Transparent;
            this.btnAplicarFiltro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAplicarFiltro.FlatAppearance.BorderSize = 2;
            this.btnAplicarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnAplicarFiltro.Location = new System.Drawing.Point(765, 99);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(160, 50);
            this.btnAplicarFiltro.TabIndex = 55;
            this.btnAplicarFiltro.Text = "Aplicar filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = false;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.BtnAplicarFiltro_Click);
            this.btnAplicarFiltro.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnAplicarFiltro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImprimir.FlatAppearance.BorderSize = 2;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(765, 323);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(160, 50);
            this.btnImprimir.TabIndex = 56;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnImprimir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(935, 565);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.btnVerReservas);
            this.Controls.Add(this.btnNoVino);
            this.Controls.Add(this.btnConfirmarReserva);
            this.Controls.Add(this.ckbIncluirFechaDesde);
            this.Controls.Add(this.btnVerClientes);
            this.Controls.Add(this.ckbIncluirFechaHasta);
            this.Controls.Add(this.btnCrearReserva);
            this.Controls.Add(this.lblReservasHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblEstadoReserva);
            this.Controls.Add(this.dtpDechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.cmbEstadoReserva);
            this.Controls.Add(this.picLupa);
            this.Controls.Add(this.txtBuscarPorNombre);
            this.Controls.Add(this.btnEliminarElementos);
            this.Controls.Add(this.dgvDatosReservas);
            this.Controls.Add(this.lblRegistroDeDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReservas";
            this.Text = "FrmReservascs";
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRegistroDeDatos;
        private System.Windows.Forms.DataGridView dgvDatosReservas;
        private System.Windows.Forms.Button btnEliminarElementos;
        private System.Windows.Forms.PictureBox picLupa;
        private System.Windows.Forms.TextBox txtBuscarPorNombre;
        private System.Windows.Forms.ComboBox cmbEstadoReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpDechaHasta;
        private System.Windows.Forms.Label lblEstadoReserva;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblReservasHasta;
        private System.Windows.Forms.Button btnCrearReserva;
        private System.Windows.Forms.CheckBox ckbIncluirFechaHasta;
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.CheckBox ckbIncluirFechaDesde;
        private System.Windows.Forms.Button btnConfirmarReserva;
        private System.Windows.Forms.Button btnNoVino;
        private System.Windows.Forms.Button btnVerReservas;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadDePersonas;
        private System.Windows.Forms.DataGridViewButtonColumn colNumeroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccionDeFilas;
    }
}