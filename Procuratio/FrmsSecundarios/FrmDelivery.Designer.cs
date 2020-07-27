namespace Procuratio.FrmsSecundarios
{
    partial class FrmDelivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.dgvDelivery = new System.Windows.Forms.DataGridView();
            this.colID_Delivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ID_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefonoCadete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDireccionDeDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPedido = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccionDeFilas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.ckbIncluirFechaDesde = new System.Windows.Forms.CheckBox();
            this.ckbIncluirFechaHasta = new System.Windows.Forms.CheckBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblEstadoDelivery = new System.Windows.Forms.Label();
            this.dtpDechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.cmbEstadoEnvio = new System.Windows.Forms.ComboBox();
            this.txtBuscarPorNombre = new System.Windows.Forms.TextBox();
            this.picLupa = new System.Windows.Forms.PictureBox();
            this.btnVerDeliveriesNoEntregados = new System.Windows.Forms.Button();
            this.btnCrearDelivery = new System.Windows.Forms.Button();
            this.btnDeliveryNoRecibido = new System.Windows.Forms.Button();
            this.btnDeliveryEntregado = new System.Windows.Forms.Button();
            this.btnEliminarElementos = new System.Windows.Forms.Button();
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.tmrActualizaDatos = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDelivery
            // 
            this.lblDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblDelivery.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.ForeColor = System.Drawing.Color.Gray;
            this.lblDelivery.Location = new System.Drawing.Point(458, 11);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(77, 19);
            this.lblDelivery.TabIndex = 32;
            this.lblDelivery.Text = "DELIVERY";
            // 
            // dgvDelivery
            // 
            this.dgvDelivery.AllowUserToAddRows = false;
            this.dgvDelivery.AllowUserToDeleteRows = false;
            this.dgvDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDelivery.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDelivery.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvDelivery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDelivery.ColumnHeadersHeight = 45;
            this.dgvDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID_Delivery,
            this.Col_ID_Pedido,
            this.ColFecha,
            this.ColHora,
            this.ColNombreCliente,
            this.ColApellidoCliente,
            this.ColTelefonoCliente,
            this.ColTelefonoCadete,
            this.ColDireccionDeDestino,
            this.ColPedido,
            this.ColEstado,
            this.colSeleccionDeFilas});
            this.dgvDelivery.EnableHeadersVisualStyles = false;
            this.dgvDelivery.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDelivery.Location = new System.Drawing.Point(10, 100);
            this.dgvDelivery.Name = "dgvDelivery";
            this.dgvDelivery.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelivery.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDelivery.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvDelivery.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDelivery.Size = new System.Drawing.Size(750, 464);
            this.dgvDelivery.TabIndex = 33;
            this.dgvDelivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDelivery_CellContentClick);
            this.dgvDelivery.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDelivery_CellMouseDoubleClick);
            // 
            // colID_Delivery
            // 
            this.colID_Delivery.HeaderText = "ID_Delivery";
            this.colID_Delivery.Name = "colID_Delivery";
            this.colID_Delivery.ReadOnly = true;
            this.colID_Delivery.Visible = false;
            // 
            // Col_ID_Pedido
            // 
            this.Col_ID_Pedido.HeaderText = "ID_Pedido";
            this.Col_ID_Pedido.Name = "Col_ID_Pedido";
            this.Col_ID_Pedido.ReadOnly = true;
            this.Col_ID_Pedido.Visible = false;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            this.ColFecha.Width = 90;
            // 
            // ColHora
            // 
            this.ColHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColHora.HeaderText = "Hora";
            this.ColHora.Name = "ColHora";
            this.ColHora.ReadOnly = true;
            this.ColHora.Width = 60;
            // 
            // ColNombreCliente
            // 
            this.ColNombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombreCliente.HeaderText = "Nombre";
            this.ColNombreCliente.Name = "ColNombreCliente";
            this.ColNombreCliente.ReadOnly = true;
            // 
            // ColApellidoCliente
            // 
            this.ColApellidoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColApellidoCliente.HeaderText = "Apellido";
            this.ColApellidoCliente.Name = "ColApellidoCliente";
            this.ColApellidoCliente.ReadOnly = true;
            // 
            // ColTelefonoCliente
            // 
            this.ColTelefonoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTelefonoCliente.HeaderText = "Telefono";
            this.ColTelefonoCliente.Name = "ColTelefonoCliente";
            this.ColTelefonoCliente.ReadOnly = true;
            // 
            // ColTelefonoCadete
            // 
            this.ColTelefonoCadete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTelefonoCadete.FillWeight = 85F;
            this.ColTelefonoCadete.HeaderText = "Telefono cadete";
            this.ColTelefonoCadete.Name = "ColTelefonoCadete";
            this.ColTelefonoCadete.ReadOnly = true;
            // 
            // ColDireccionDeDestino
            // 
            this.ColDireccionDeDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDireccionDeDestino.HeaderText = "Direccion de destino";
            this.ColDireccionDeDestino.Name = "ColDireccionDeDestino";
            this.ColDireccionDeDestino.ReadOnly = true;
            // 
            // ColPedido
            // 
            this.ColPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColPedido.HeaderText = "Pedido";
            this.ColPedido.Name = "ColPedido";
            this.ColPedido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColPedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColPedido.Width = 60;
            // 
            // ColEstado
            // 
            this.ColEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // colSeleccionDeFilas
            // 
            this.colSeleccionDeFilas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSeleccionDeFilas.FillWeight = 90F;
            this.colSeleccionDeFilas.HeaderText = "Seleccionar";
            this.colSeleccionDeFilas.Name = "colSeleccionDeFilas";
            this.colSeleccionDeFilas.Width = 90;
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
            this.btnAplicarFiltro.Location = new System.Drawing.Point(766, 100);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(160, 50);
            this.btnAplicarFiltro.TabIndex = 67;
            this.btnAplicarFiltro.Text = "Aplicar filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = false;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.BtnAplicarFiltro_Click);
            this.btnAplicarFiltro.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnAplicarFiltro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
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
            this.ckbIncluirFechaDesde.TabIndex = 76;
            this.ckbIncluirFechaDesde.Text = "Incluir";
            this.ttpMensajesDeAyuda.SetToolTip(this.ckbIncluirFechaDesde, "Si marca esta opcion, se tomara la fecha seleccionada como inicio para el filtro," +
        " en caso contrario, listara todas las reservas hasta la fecha \"hasta\" indicada p" +
        "ara atras (si fue seleccionada)");
            this.ckbIncluirFechaDesde.UseVisualStyleBackColor = true;
            this.ckbIncluirFechaDesde.CheckedChanged += new System.EventHandler(this.CkbIncluirFechaDesde_CheckedChanged);
            // 
            // ckbIncluirFechaHasta
            // 
            this.ckbIncluirFechaHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbIncluirFechaHasta.AutoSize = true;
            this.ckbIncluirFechaHasta.Checked = true;
            this.ckbIncluirFechaHasta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIncluirFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckbIncluirFechaHasta.ForeColor = System.Drawing.Color.White;
            this.ckbIncluirFechaHasta.Location = new System.Drawing.Point(688, 71);
            this.ckbIncluirFechaHasta.Name = "ckbIncluirFechaHasta";
            this.ckbIncluirFechaHasta.Size = new System.Drawing.Size(72, 22);
            this.ckbIncluirFechaHasta.TabIndex = 75;
            this.ckbIncluirFechaHasta.Text = "Incluir";
            this.ttpMensajesDeAyuda.SetToolTip(this.ckbIncluirFechaHasta, "Si marca esta opcion, se tomara la fecha seleccionada como fin para el filtro, en" +
        " caso contrario, listara todas las reservas desde la fecha \"desde\" indicada en a" +
        "delante (si fue seleccionada)");
            this.ckbIncluirFechaHasta.UseVisualStyleBackColor = true;
            this.ckbIncluirFechaHasta.CheckedChanged += new System.EventHandler(this.CkbIncluirFechaHasta_CheckedChanged);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaHasta.Location = new System.Drawing.Point(390, 73);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(57, 18);
            this.lblFechaHasta.TabIndex = 74;
            this.lblFechaHasta.Text = "Hasta:";
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
            this.lblFechaDesde.TabIndex = 73;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblEstadoDelivery
            // 
            this.lblEstadoDelivery.AutoSize = true;
            this.lblEstadoDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoDelivery.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstadoDelivery.Location = new System.Drawing.Point(6, 72);
            this.lblEstadoDelivery.Name = "lblEstadoDelivery";
            this.lblEstadoDelivery.Size = new System.Drawing.Size(138, 18);
            this.lblEstadoDelivery.TabIndex = 72;
            this.lblEstadoDelivery.Text = "Estado del envio:";
            // 
            // dtpDechaHasta
            // 
            this.dtpDechaHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDechaHasta.Location = new System.Drawing.Point(453, 72);
            this.dtpDechaHasta.Name = "dtpDechaHasta";
            this.dtpDechaHasta.Size = new System.Drawing.Size(231, 20);
            this.dtpDechaHasta.TabIndex = 71;
            this.ttpMensajesDeAyuda.SetToolTip(this.dtpDechaHasta, "Filtrar indicando una fecha de fin");
            this.dtpDechaHasta.ValueChanged += new System.EventHandler(this.DtpDechaHasta_ValueChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaDesde.Location = new System.Drawing.Point(453, 38);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(231, 20);
            this.dtpFechaDesde.TabIndex = 70;
            this.ttpMensajesDeAyuda.SetToolTip(this.dtpFechaDesde, "Filtrar indicando una fecha de inicio");
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.DtpFechaDesde_ValueChanged);
            // 
            // cmbEstadoEnvio
            // 
            this.cmbEstadoEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstadoEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.cmbEstadoEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstadoEnvio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbEstadoEnvio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbEstadoEnvio.FormattingEnabled = true;
            this.cmbEstadoEnvio.Location = new System.Drawing.Point(150, 68);
            this.cmbEstadoEnvio.Name = "cmbEstadoEnvio";
            this.cmbEstadoEnvio.Size = new System.Drawing.Size(226, 26);
            this.cmbEstadoEnvio.TabIndex = 69;
            this.cmbEstadoEnvio.Text = "Estado";
            this.ttpMensajesDeAyuda.SetToolTip(this.cmbEstadoEnvio, "Filtra por un estado en particular (o todos los estado si se lo indica)");
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
            this.txtBuscarPorNombre.TabIndex = 68;
            this.txtBuscarPorNombre.Text = "Buscar por nombre de cliente...";
            this.ttpMensajesDeAyuda.SetToolTip(this.txtBuscarPorNombre, "Filtra por el nombre de un cliente");
            this.txtBuscarPorNombre.Enter += new System.EventHandler(this.TxtBuscarPorNombre_Enter);
            this.txtBuscarPorNombre.Leave += new System.EventHandler(this.TxtBuscarPorNombre_Leave);
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
            this.picLupa.TabIndex = 77;
            this.picLupa.TabStop = false;
            // 
            // btnVerDeliveriesNoEntregados
            // 
            this.btnVerDeliveriesNoEntregados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerDeliveriesNoEntregados.BackColor = System.Drawing.Color.Transparent;
            this.btnVerDeliveriesNoEntregados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerDeliveriesNoEntregados.FlatAppearance.BorderSize = 2;
            this.btnVerDeliveriesNoEntregados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDeliveriesNoEntregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDeliveriesNoEntregados.ForeColor = System.Drawing.Color.White;
            this.btnVerDeliveriesNoEntregados.Location = new System.Drawing.Point(766, 156);
            this.btnVerDeliveriesNoEntregados.Name = "btnVerDeliveriesNoEntregados";
            this.btnVerDeliveriesNoEntregados.Size = new System.Drawing.Size(160, 51);
            this.btnVerDeliveriesNoEntregados.TabIndex = 78;
            this.btnVerDeliveriesNoEntregados.Text = "Ver deliveries no entregados de ayer en adelante";
            this.btnVerDeliveriesNoEntregados.UseVisualStyleBackColor = false;
            this.btnVerDeliveriesNoEntregados.Click += new System.EventHandler(this.BtnVerDeliveriesNoEntregados_Click);
            this.btnVerDeliveriesNoEntregados.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnVerDeliveriesNoEntregados.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnCrearDelivery
            // 
            this.btnCrearDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearDelivery.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearDelivery.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrearDelivery.FlatAppearance.BorderSize = 2;
            this.btnCrearDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearDelivery.ForeColor = System.Drawing.Color.White;
            this.btnCrearDelivery.Location = new System.Drawing.Point(766, 212);
            this.btnCrearDelivery.Name = "btnCrearDelivery";
            this.btnCrearDelivery.Size = new System.Drawing.Size(160, 50);
            this.btnCrearDelivery.TabIndex = 79;
            this.btnCrearDelivery.Text = "Crear delivery";
            this.btnCrearDelivery.UseVisualStyleBackColor = false;
            this.btnCrearDelivery.Click += new System.EventHandler(this.BtnCrearDelivery_Click);
            this.btnCrearDelivery.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCrearDelivery.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnDeliveryNoRecibido
            // 
            this.btnDeliveryNoRecibido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeliveryNoRecibido.BackColor = System.Drawing.Color.Transparent;
            this.btnDeliveryNoRecibido.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeliveryNoRecibido.FlatAppearance.BorderSize = 2;
            this.btnDeliveryNoRecibido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliveryNoRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliveryNoRecibido.ForeColor = System.Drawing.Color.White;
            this.btnDeliveryNoRecibido.Location = new System.Drawing.Point(766, 498);
            this.btnDeliveryNoRecibido.Name = "btnDeliveryNoRecibido";
            this.btnDeliveryNoRecibido.Size = new System.Drawing.Size(160, 30);
            this.btnDeliveryNoRecibido.TabIndex = 82;
            this.btnDeliveryNoRecibido.Text = "Delivery no entregado";
            this.btnDeliveryNoRecibido.UseVisualStyleBackColor = false;
            this.btnDeliveryNoRecibido.Click += new System.EventHandler(this.BtnDeliveryNoRecibido_Click);
            this.btnDeliveryNoRecibido.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnDeliveryNoRecibido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnDeliveryEntregado
            // 
            this.btnDeliveryEntregado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeliveryEntregado.BackColor = System.Drawing.Color.Transparent;
            this.btnDeliveryEntregado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeliveryEntregado.FlatAppearance.BorderSize = 2;
            this.btnDeliveryEntregado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliveryEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliveryEntregado.ForeColor = System.Drawing.Color.White;
            this.btnDeliveryEntregado.Location = new System.Drawing.Point(766, 462);
            this.btnDeliveryEntregado.Name = "btnDeliveryEntregado";
            this.btnDeliveryEntregado.Size = new System.Drawing.Size(160, 30);
            this.btnDeliveryEntregado.TabIndex = 81;
            this.btnDeliveryEntregado.Text = "Delivery entregado";
            this.btnDeliveryEntregado.UseVisualStyleBackColor = false;
            this.btnDeliveryEntregado.Click += new System.EventHandler(this.BtnDeliveryEntregado_Click);
            this.btnDeliveryEntregado.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnDeliveryEntregado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
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
            this.btnEliminarElementos.Location = new System.Drawing.Point(766, 534);
            this.btnEliminarElementos.Name = "btnEliminarElementos";
            this.btnEliminarElementos.Size = new System.Drawing.Size(160, 30);
            this.btnEliminarElementos.TabIndex = 80;
            this.btnEliminarElementos.Text = "Eliminar Delivery";
            this.btnEliminarElementos.UseVisualStyleBackColor = false;
            this.btnEliminarElementos.Click += new System.EventHandler(this.BtnEliminarElementos_Click);
            this.btnEliminarElementos.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnEliminarElementos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // tmrActualizaDatos
            // 
            this.tmrActualizaDatos.Enabled = true;
            this.tmrActualizaDatos.Interval = 1000;
            this.tmrActualizaDatos.Tick += new System.EventHandler(this.tmrActualizaDatos_Tick);
            // 
            // FrmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(933, 576);
            this.Controls.Add(this.btnDeliveryNoRecibido);
            this.Controls.Add(this.btnDeliveryEntregado);
            this.Controls.Add(this.btnEliminarElementos);
            this.Controls.Add(this.btnCrearDelivery);
            this.Controls.Add(this.btnVerDeliveriesNoEntregados);
            this.Controls.Add(this.picLupa);
            this.Controls.Add(this.ckbIncluirFechaDesde);
            this.Controls.Add(this.ckbIncluirFechaHasta);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblEstadoDelivery);
            this.Controls.Add(this.dtpDechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.cmbEstadoEnvio);
            this.Controls.Add(this.txtBuscarPorNombre);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.dgvDelivery);
            this.Controls.Add(this.lblDelivery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDelivery";
            this.Text = "FrmDelivery";
            this.Load += new System.EventHandler(this.FrmDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.DataGridView dgvDelivery;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.CheckBox ckbIncluirFechaDesde;
        private System.Windows.Forms.CheckBox ckbIncluirFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblEstadoDelivery;
        private System.Windows.Forms.DateTimePicker dtpDechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.ComboBox cmbEstadoEnvio;
        private System.Windows.Forms.TextBox txtBuscarPorNombre;
        private System.Windows.Forms.PictureBox picLupa;
        private System.Windows.Forms.Button btnVerDeliveriesNoEntregados;
        private System.Windows.Forms.Button btnCrearDelivery;
        private System.Windows.Forms.Button btnDeliveryNoRecibido;
        private System.Windows.Forms.Button btnDeliveryEntregado;
        private System.Windows.Forms.Button btnEliminarElementos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefonoCadete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDireccionDeDestino;
        private System.Windows.Forms.DataGridViewButtonColumn ColPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccionDeFilas;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Timer tmrActualizaDatos;
    }
}