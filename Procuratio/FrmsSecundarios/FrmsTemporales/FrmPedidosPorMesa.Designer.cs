namespace Procuratio
{
    partial class FrmPedidosPorMesa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContenedorFrm = new System.Windows.Forms.Panel();
            this.btnResetearSeleccionCarta = new System.Windows.Forms.Button();
            this.lblEstadoDelPedido = new System.Windows.Forms.Label();
            this.dgvArticulosPedido = new System.Windows.Forms.DataGridView();
            this.ID_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColArticuloEnviado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccionDeFilas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblPedido = new System.Windows.Forms.Label();
            this.cmbMesas = new System.Windows.Forms.ComboBox();
            this.dgvCarta = new System.Windows.Forms.DataGridView();
            this.colID_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAñadirArticulos = new System.Windows.Forms.Button();
            this.pnlContTotal = new System.Windows.Forms.Panel();
            this.btnMostrarCocina = new System.Windows.Forms.Button();
            this.btnImprimirTicket = new System.Windows.Forms.Button();
            this.btnPedidoRecibido = new System.Windows.Forms.Button();
            this.btnPreCuenta = new System.Windows.Forms.Button();
            this.btnEnviarPedido = new System.Windows.Forms.Button();
            this.lblMostratTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.picLupa = new System.Windows.Forms.PictureBox();
            this.txtBuscarPorNombre = new System.Windows.Forms.TextBox();
            this.pnlDecorativo1 = new System.Windows.Forms.Panel();
            this.pnlContEditaPedido = new System.Windows.Forms.Panel();
            this.PicBTNHabilitaEdicionEspecial = new System.Windows.Forms.PictureBox();
            this.PicBTNActualizarLista = new System.Windows.Forms.PictureBox();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.btnDisminuyeUnidad = new System.Windows.Forms.Button();
            this.btnAumentaUnidad = new System.Windows.Forms.Button();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picBTNInformacion = new System.Windows.Forms.PictureBox();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tmrColor = new System.Windows.Forms.Timer(this.components);
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.PtdImprimirTicket = new System.Drawing.Printing.PrintDocument();
            this.pnlContenedorFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarta)).BeginInit();
            this.pnlContTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).BeginInit();
            this.pnlContEditaPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBTNHabilitaEdicionEspecial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBTNActualizarLista)).BeginInit();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedorFrm
            // 
            this.pnlContenedorFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorFrm.Controls.Add(this.btnResetearSeleccionCarta);
            this.pnlContenedorFrm.Controls.Add(this.lblEstadoDelPedido);
            this.pnlContenedorFrm.Controls.Add(this.dgvArticulosPedido);
            this.pnlContenedorFrm.Controls.Add(this.lblPedido);
            this.pnlContenedorFrm.Controls.Add(this.cmbMesas);
            this.pnlContenedorFrm.Controls.Add(this.dgvCarta);
            this.pnlContenedorFrm.Controls.Add(this.btnAñadirArticulos);
            this.pnlContenedorFrm.Controls.Add(this.pnlContTotal);
            this.pnlContenedorFrm.Controls.Add(this.lblCategoria);
            this.pnlContenedorFrm.Controls.Add(this.cmbCategoria);
            this.pnlContenedorFrm.Controls.Add(this.picLupa);
            this.pnlContenedorFrm.Controls.Add(this.txtBuscarPorNombre);
            this.pnlContenedorFrm.Controls.Add(this.pnlDecorativo1);
            this.pnlContenedorFrm.Controls.Add(this.pnlContEditaPedido);
            this.pnlContenedorFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContenedorFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorFrm.Name = "pnlContenedorFrm";
            this.pnlContenedorFrm.Size = new System.Drawing.Size(1300, 695);
            this.pnlContenedorFrm.TabIndex = 0;
            // 
            // btnResetearSeleccionCarta
            // 
            this.btnResetearSeleccionCarta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetearSeleccionCarta.BackColor = System.Drawing.Color.Transparent;
            this.btnResetearSeleccionCarta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResetearSeleccionCarta.FlatAppearance.BorderSize = 2;
            this.btnResetearSeleccionCarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetearSeleccionCarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetearSeleccionCarta.ForeColor = System.Drawing.Color.White;
            this.btnResetearSeleccionCarta.Location = new System.Drawing.Point(1126, 636);
            this.btnResetearSeleccionCarta.Name = "btnResetearSeleccionCarta";
            this.btnResetearSeleccionCarta.Size = new System.Drawing.Size(160, 50);
            this.btnResetearSeleccionCarta.TabIndex = 74;
            this.btnResetearSeleccionCarta.Text = "Reiniciar la selección de carta";
            this.btnResetearSeleccionCarta.UseVisualStyleBackColor = false;
            this.btnResetearSeleccionCarta.Click += new System.EventHandler(this.BtnResetearSeleccionCarta_Click);
            this.btnResetearSeleccionCarta.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnResetearSeleccionCarta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblEstadoDelPedido
            // 
            this.lblEstadoDelPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoDelPedido.BackColor = System.Drawing.Color.Silver;
            this.lblEstadoDelPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstadoDelPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoDelPedido.ForeColor = System.Drawing.Color.Black;
            this.lblEstadoDelPedido.Location = new System.Drawing.Point(277, 37);
            this.lblEstadoDelPedido.Name = "lblEstadoDelPedido";
            this.lblEstadoDelPedido.Size = new System.Drawing.Size(175, 30);
            this.lblEstadoDelPedido.TabIndex = 73;
            this.lblEstadoDelPedido.Text = "Estado del pedido";
            this.lblEstadoDelPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpMensajesDeAyuda.SetToolTip(this.lblEstadoDelPedido, "Estado actual del pedido");
            // 
            // dgvArticulosPedido
            // 
            this.dgvArticulosPedido.AllowUserToAddRows = false;
            this.dgvArticulosPedido.AllowUserToDeleteRows = false;
            this.dgvArticulosPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulosPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulosPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvArticulosPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvArticulosPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulosPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulosPedido.ColumnHeadersHeight = 45;
            this.dgvArticulosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArticulosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Articulo,
            this.colArticulo,
            this.colCantidad,
            this.colPrecioUnitario,
            this.ColSubtotal,
            this.ColArticuloEnviado,
            this.colSeleccionDeFilas});
            this.dgvArticulosPedido.EnableHeadersVisualStyles = false;
            this.dgvArticulosPedido.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvArticulosPedido.Location = new System.Drawing.Point(11, 72);
            this.dgvArticulosPedido.Name = "dgvArticulosPedido";
            this.dgvArticulosPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulosPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulosPedido.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvArticulosPedido.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulosPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvArticulosPedido.Size = new System.Drawing.Size(441, 438);
            this.dgvArticulosPedido.TabIndex = 24;
            this.dgvArticulosPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulosPedido_CellContentClick);
            // 
            // ID_Articulo
            // 
            this.ID_Articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_Articulo.HeaderText = "ID_Articulo";
            this.ID_Articulo.Name = "ID_Articulo";
            this.ID_Articulo.ReadOnly = true;
            this.ID_Articulo.Visible = false;
            this.ID_Articulo.Width = 102;
            // 
            // colArticulo
            // 
            this.colArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArticulo.FillWeight = 98.47717F;
            this.colArticulo.HeaderText = "Articulo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCantidad.FillWeight = 85F;
            this.colCantidad.HeaderText = "Cant.";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 47;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPrecioUnitario.FillWeight = 95F;
            this.colPrecioUnitario.HeaderText = "Precio unitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            this.colPrecioUnitario.Width = 75;
            // 
            // ColSubtotal
            // 
            this.ColSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColSubtotal.FillWeight = 95F;
            this.ColSubtotal.HeaderText = "Subtotal";
            this.ColSubtotal.Name = "ColSubtotal";
            this.ColSubtotal.ReadOnly = true;
            this.ColSubtotal.Width = 72;
            // 
            // ColArticuloEnviado
            // 
            this.ColArticuloEnviado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColArticuloEnviado.FillWeight = 90F;
            this.ColArticuloEnviado.HeaderText = "Env";
            this.ColArticuloEnviado.Name = "ColArticuloEnviado";
            this.ColArticuloEnviado.ReadOnly = true;
            this.ColArticuloEnviado.Width = 43;
            // 
            // colSeleccionDeFilas
            // 
            this.colSeleccionDeFilas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSeleccionDeFilas.FillWeight = 101.5228F;
            this.colSeleccionDeFilas.HeaderText = "Seleccionar";
            this.colSeleccionDeFilas.Name = "colSeleccionDeFilas";
            this.colSeleccionDeFilas.Width = 80;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPedido.Location = new System.Drawing.Point(84, 44);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(91, 18);
            this.lblPedido.TabIndex = 72;
            this.lblPedido.Text = "Pedido n°: ";
            // 
            // cmbMesas
            // 
            this.cmbMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.cmbMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMesas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbMesas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMesas.FormattingEnabled = true;
            this.cmbMesas.Location = new System.Drawing.Point(12, 40);
            this.cmbMesas.Name = "cmbMesas";
            this.cmbMesas.Size = new System.Drawing.Size(69, 26);
            this.cmbMesas.TabIndex = 71;
            this.cmbMesas.Text = "Mesas";
            this.ttpMensajesDeAyuda.SetToolTip(this.cmbMesas, "Mesas del pedido");
            // 
            // dgvCarta
            // 
            this.dgvCarta.AllowUserToAddRows = false;
            this.dgvCarta.AllowUserToDeleteRows = false;
            this.dgvCarta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCarta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvCarta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCarta.ColumnHeadersHeight = 45;
            this.dgvCarta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCarta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID_Articulo,
            this.colNombre,
            this.colDescripcion,
            this.colCategoria,
            this.colPrecio,
            this.dataGridViewCheckBoxColumn1});
            this.dgvCarta.EnableHeadersVisualStyles = false;
            this.dgvCarta.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCarta.Location = new System.Drawing.Point(530, 72);
            this.dgvCarta.Name = "dgvCarta";
            this.dgvCarta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarta.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCarta.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvCarta.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCarta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCarta.Size = new System.Drawing.Size(757, 558);
            this.dgvCarta.TabIndex = 70;
            this.dgvCarta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCarta_CellContentClick);
            // 
            // colID_Articulo
            // 
            this.colID_Articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID_Articulo.HeaderText = "ID_Articulo";
            this.colID_Articulo.Name = "colID_Articulo";
            this.colID_Articulo.ReadOnly = true;
            this.colID_Articulo.Visible = false;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.FillWeight = 98.47717F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDescripcion.FillWeight = 90F;
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 260;
            // 
            // colCategoria
            // 
            this.colCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCategoria.FillWeight = 130F;
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            this.colCategoria.Width = 130;
            // 
            // colPrecio
            // 
            this.colPrecio.FillWeight = 80F;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 80;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.FillWeight = 90F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Seleccionar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 90;
            // 
            // btnAñadirArticulos
            // 
            this.btnAñadirArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAñadirArticulos.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirArticulos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAñadirArticulos.FlatAppearance.BorderSize = 2;
            this.btnAñadirArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirArticulos.ForeColor = System.Drawing.Color.White;
            this.btnAñadirArticulos.Location = new System.Drawing.Point(530, 636);
            this.btnAñadirArticulos.Name = "btnAñadirArticulos";
            this.btnAñadirArticulos.Size = new System.Drawing.Size(160, 50);
            this.btnAñadirArticulos.TabIndex = 69;
            this.btnAñadirArticulos.Text = "Añadir articulos al pedido";
            this.btnAñadirArticulos.UseVisualStyleBackColor = false;
            this.btnAñadirArticulos.Click += new System.EventHandler(this.BtnAñadirArticulos_Click);
            this.btnAñadirArticulos.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnAñadirArticulos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // pnlContTotal
            // 
            this.pnlContTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pnlContTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContTotal.Controls.Add(this.btnMostrarCocina);
            this.pnlContTotal.Controls.Add(this.btnImprimirTicket);
            this.pnlContTotal.Controls.Add(this.btnPedidoRecibido);
            this.pnlContTotal.Controls.Add(this.btnPreCuenta);
            this.pnlContTotal.Controls.Add(this.btnEnviarPedido);
            this.pnlContTotal.Controls.Add(this.lblMostratTotal);
            this.pnlContTotal.Controls.Add(this.lblTotal);
            this.pnlContTotal.Location = new System.Drawing.Point(11, 516);
            this.pnlContTotal.Name = "pnlContTotal";
            this.pnlContTotal.Size = new System.Drawing.Size(505, 170);
            this.pnlContTotal.TabIndex = 67;
            // 
            // btnMostrarCocina
            // 
            this.btnMostrarCocina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarCocina.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarCocina.Enabled = false;
            this.btnMostrarCocina.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrarCocina.FlatAppearance.BorderSize = 2;
            this.btnMostrarCocina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarCocina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarCocina.ForeColor = System.Drawing.Color.White;
            this.btnMostrarCocina.Location = new System.Drawing.Point(174, 59);
            this.btnMostrarCocina.Name = "btnMostrarCocina";
            this.btnMostrarCocina.Size = new System.Drawing.Size(160, 50);
            this.btnMostrarCocina.TabIndex = 73;
            this.btnMostrarCocina.Text = "Ver lo que cocina tiene de este pedido";
            this.btnMostrarCocina.UseVisualStyleBackColor = false;
            this.btnMostrarCocina.Click += new System.EventHandler(this.BtnMostrarCocina_Click);
            this.btnMostrarCocina.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnMostrarCocina.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnImprimirTicket
            // 
            this.btnImprimirTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirTicket.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImprimirTicket.FlatAppearance.BorderSize = 2;
            this.btnImprimirTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirTicket.ForeColor = System.Drawing.Color.White;
            this.btnImprimirTicket.Location = new System.Drawing.Point(174, 115);
            this.btnImprimirTicket.Name = "btnImprimirTicket";
            this.btnImprimirTicket.Size = new System.Drawing.Size(160, 50);
            this.btnImprimirTicket.TabIndex = 72;
            this.btnImprimirTicket.Text = "Imprimir ticket para cocina";
            this.btnImprimirTicket.UseVisualStyleBackColor = false;
            this.btnImprimirTicket.Click += new System.EventHandler(this.BtnImprimirTicket_Click);
            this.btnImprimirTicket.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnImprimirTicket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnPedidoRecibido
            // 
            this.btnPedidoRecibido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPedidoRecibido.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidoRecibido.Enabled = false;
            this.btnPedidoRecibido.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPedidoRecibido.FlatAppearance.BorderSize = 2;
            this.btnPedidoRecibido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidoRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoRecibido.ForeColor = System.Drawing.Color.White;
            this.btnPedidoRecibido.Location = new System.Drawing.Point(340, 59);
            this.btnPedidoRecibido.Name = "btnPedidoRecibido";
            this.btnPedidoRecibido.Size = new System.Drawing.Size(160, 50);
            this.btnPedidoRecibido.TabIndex = 71;
            this.btnPedidoRecibido.Text = "Pedido recibido";
            this.btnPedidoRecibido.UseVisualStyleBackColor = false;
            this.btnPedidoRecibido.Click += new System.EventHandler(this.BtnPedidoRecibido_Click);
            this.btnPedidoRecibido.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnPedidoRecibido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnPreCuenta
            // 
            this.btnPreCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreCuenta.BackColor = System.Drawing.Color.Transparent;
            this.btnPreCuenta.Enabled = false;
            this.btnPreCuenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPreCuenta.FlatAppearance.BorderSize = 2;
            this.btnPreCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreCuenta.ForeColor = System.Drawing.Color.White;
            this.btnPreCuenta.Location = new System.Drawing.Point(340, 115);
            this.btnPreCuenta.Name = "btnPreCuenta";
            this.btnPreCuenta.Size = new System.Drawing.Size(160, 50);
            this.btnPreCuenta.TabIndex = 70;
            this.btnPreCuenta.Text = "Pre Cuenta";
            this.btnPreCuenta.UseVisualStyleBackColor = false;
            this.btnPreCuenta.Click += new System.EventHandler(this.BtnPreCuenta_Click);
            this.btnPreCuenta.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnPreCuenta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnEnviarPedido
            // 
            this.btnEnviarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviarPedido.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnviarPedido.FlatAppearance.BorderSize = 2;
            this.btnEnviarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarPedido.ForeColor = System.Drawing.Color.White;
            this.btnEnviarPedido.Location = new System.Drawing.Point(340, 3);
            this.btnEnviarPedido.Name = "btnEnviarPedido";
            this.btnEnviarPedido.Size = new System.Drawing.Size(160, 50);
            this.btnEnviarPedido.TabIndex = 68;
            this.btnEnviarPedido.Text = "Confirmar cambios";
            this.btnEnviarPedido.UseVisualStyleBackColor = false;
            this.btnEnviarPedido.Click += new System.EventHandler(this.BtnEnviarPedido_Click);
            this.btnEnviarPedido.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnEnviarPedido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblMostratTotal
            // 
            this.lblMostratTotal.AutoSize = true;
            this.lblMostratTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblMostratTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostratTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostratTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblMostratTotal.Location = new System.Drawing.Point(58, 73);
            this.lblMostratTotal.Name = "lblMostratTotal";
            this.lblMostratTotal.Size = new System.Drawing.Size(21, 22);
            this.lblMostratTotal.TabIndex = 43;
            this.lblMostratTotal.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotal.Location = new System.Drawing.Point(3, 74);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 18);
            this.lblTotal.TabIndex = 42;
            this.lblTotal.Text = "Total:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCategoria.Location = new System.Drawing.Point(893, 44);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(162, 18);
            this.lblCategoria.TabIndex = 66;
            this.lblCategoria.Text = "Filtrar por categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbCategoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(1058, 39);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(228, 26);
            this.cmbCategoria.TabIndex = 65;
            this.cmbCategoria.Text = "Categoria";
            this.ttpMensajesDeAyuda.SetToolTip(this.cmbCategoria, "Filtrar por nombre de categoria");
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.CmbCategoria_SelectedIndexChanged);
            // 
            // picLupa
            // 
            this.picLupa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.picLupa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLupa.Image = global::Procuratio.Properties.Resources.Lupa;
            this.picLupa.Location = new System.Drawing.Point(530, 40);
            this.picLupa.Name = "picLupa";
            this.picLupa.Size = new System.Drawing.Size(29, 26);
            this.picLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLupa.TabIndex = 64;
            this.picLupa.TabStop = false;
            // 
            // txtBuscarPorNombre
            // 
            this.txtBuscarPorNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarPorNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtBuscarPorNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPorNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPorNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarPorNombre.Location = new System.Drawing.Point(558, 40);
            this.txtBuscarPorNombre.MaxLength = 100;
            this.txtBuscarPorNombre.Name = "txtBuscarPorNombre";
            this.txtBuscarPorNombre.Size = new System.Drawing.Size(329, 26);
            this.txtBuscarPorNombre.TabIndex = 63;
            this.txtBuscarPorNombre.Text = "Buscar por nombre de articulo...";
            this.ttpMensajesDeAyuda.SetToolTip(this.txtBuscarPorNombre, "Filtrar por nombre de articulo");
            this.txtBuscarPorNombre.TextChanged += new System.EventHandler(this.TxtBuscarPorNombre_TextChanged);
            this.txtBuscarPorNombre.Enter += new System.EventHandler(this.TxtBuscarPorNombre_Enter);
            this.txtBuscarPorNombre.Leave += new System.EventHandler(this.TxtBuscarPorNombre_Leave);
            // 
            // pnlDecorativo1
            // 
            this.pnlDecorativo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDecorativo1.BackColor = System.Drawing.Color.DimGray;
            this.pnlDecorativo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo1.Location = new System.Drawing.Point(520, 30);
            this.pnlDecorativo1.Name = "pnlDecorativo1";
            this.pnlDecorativo1.Size = new System.Drawing.Size(5, 663);
            this.pnlDecorativo1.TabIndex = 61;
            // 
            // pnlContEditaPedido
            // 
            this.pnlContEditaPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContEditaPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pnlContEditaPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContEditaPedido.Controls.Add(this.PicBTNHabilitaEdicionEspecial);
            this.pnlContEditaPedido.Controls.Add(this.PicBTNActualizarLista);
            this.pnlContEditaPedido.Controls.Add(this.btnEliminarPedido);
            this.pnlContEditaPedido.Controls.Add(this.btnDisminuyeUnidad);
            this.pnlContEditaPedido.Controls.Add(this.btnAumentaUnidad);
            this.pnlContEditaPedido.Location = new System.Drawing.Point(458, 72);
            this.pnlContEditaPedido.Name = "pnlContEditaPedido";
            this.pnlContEditaPedido.Size = new System.Drawing.Size(58, 438);
            this.pnlContEditaPedido.TabIndex = 25;
            // 
            // PicBTNHabilitaEdicionEspecial
            // 
            this.PicBTNHabilitaEdicionEspecial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBTNHabilitaEdicionEspecial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.PicBTNHabilitaEdicionEspecial.Image = global::Procuratio.Properties.Resources.Habilitar_Edicion;
            this.PicBTNHabilitaEdicionEspecial.Location = new System.Drawing.Point(3, 327);
            this.PicBTNHabilitaEdicionEspecial.Name = "PicBTNHabilitaEdicionEspecial";
            this.PicBTNHabilitaEdicionEspecial.Size = new System.Drawing.Size(50, 50);
            this.PicBTNHabilitaEdicionEspecial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBTNHabilitaEdicionEspecial.TabIndex = 37;
            this.PicBTNHabilitaEdicionEspecial.TabStop = false;
            this.ttpMensajesDeAyuda.SetToolTip(this.PicBTNHabilitaEdicionEspecial, "Habilita la eliminacion o reduccion de articulos que ya fueron marcados como coci" +
        "nados (debe ingresar una contraseña de un usuario que tenga un perfil autorizado" +
        ")");
            this.PicBTNHabilitaEdicionEspecial.Click += new System.EventHandler(this.PicBTNHabilitaEdicionEspecial_Click);
            this.PicBTNHabilitaEdicionEspecial.MouseLeave += new System.EventHandler(this.ColorFondoBotones_MouseLeave);
            this.PicBTNHabilitaEdicionEspecial.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorFondoBotones_MouseMove);
            // 
            // PicBTNActualizarLista
            // 
            this.PicBTNActualizarLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBTNActualizarLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.PicBTNActualizarLista.Image = global::Procuratio.Properties.Resources.Actualizar;
            this.PicBTNActualizarLista.Location = new System.Drawing.Point(3, 383);
            this.PicBTNActualizarLista.Name = "PicBTNActualizarLista";
            this.PicBTNActualizarLista.Size = new System.Drawing.Size(50, 50);
            this.PicBTNActualizarLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBTNActualizarLista.TabIndex = 4;
            this.PicBTNActualizarLista.TabStop = false;
            this.ttpMensajesDeAyuda.SetToolTip(this.PicBTNActualizarLista, "Actualizar pedido");
            this.PicBTNActualizarLista.Click += new System.EventHandler(this.PicBTNActualizarLista_Click);
            this.PicBTNActualizarLista.MouseLeave += new System.EventHandler(this.ColorFondoBotones_MouseLeave);
            this.PicBTNActualizarLista.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorFondoBotones_MouseMove);
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarPedido.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarPedido.FlatAppearance.BorderSize = 2;
            this.btnEliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPedido.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPedido.Location = new System.Drawing.Point(3, 115);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(50, 50);
            this.btnEliminarPedido.TabIndex = 36;
            this.btnEliminarPedido.Text = "x";
            this.ttpMensajesDeAyuda.SetToolTip(this.btnEliminarPedido, "Eliminar articulos");
            this.btnEliminarPedido.UseVisualStyleBackColor = false;
            this.btnEliminarPedido.Click += new System.EventHandler(this.BtnEliminarPedido_Click);
            this.btnEliminarPedido.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnEliminarPedido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnDisminuyeUnidad
            // 
            this.btnDisminuyeUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisminuyeUnidad.BackColor = System.Drawing.Color.Transparent;
            this.btnDisminuyeUnidad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDisminuyeUnidad.FlatAppearance.BorderSize = 2;
            this.btnDisminuyeUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisminuyeUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisminuyeUnidad.ForeColor = System.Drawing.Color.White;
            this.btnDisminuyeUnidad.Location = new System.Drawing.Point(3, 59);
            this.btnDisminuyeUnidad.Name = "btnDisminuyeUnidad";
            this.btnDisminuyeUnidad.Size = new System.Drawing.Size(50, 50);
            this.btnDisminuyeUnidad.TabIndex = 36;
            this.btnDisminuyeUnidad.Text = "-";
            this.ttpMensajesDeAyuda.SetToolTip(this.btnDisminuyeUnidad, "Disminuir unidades del articulo");
            this.btnDisminuyeUnidad.UseVisualStyleBackColor = false;
            this.btnDisminuyeUnidad.Click += new System.EventHandler(this.BtnDisminuyeUnidad_Click);
            this.btnDisminuyeUnidad.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnDisminuyeUnidad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnAumentaUnidad
            // 
            this.btnAumentaUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAumentaUnidad.BackColor = System.Drawing.Color.Transparent;
            this.btnAumentaUnidad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAumentaUnidad.FlatAppearance.BorderSize = 2;
            this.btnAumentaUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAumentaUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentaUnidad.ForeColor = System.Drawing.Color.White;
            this.btnAumentaUnidad.Location = new System.Drawing.Point(3, 3);
            this.btnAumentaUnidad.Name = "btnAumentaUnidad";
            this.btnAumentaUnidad.Size = new System.Drawing.Size(50, 50);
            this.btnAumentaUnidad.TabIndex = 35;
            this.btnAumentaUnidad.Text = "+";
            this.ttpMensajesDeAyuda.SetToolTip(this.btnAumentaUnidad, "Aumentar unidades del articulo");
            this.btnAumentaUnidad.UseVisualStyleBackColor = false;
            this.btnAumentaUnidad.Click += new System.EventHandler(this.BtnAumentaUnidad_Click);
            this.btnAumentaUnidad.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnAumentaUnidad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
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
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(1298, 30);
            this.pnlBarraDeArrastre.TabIndex = 1;
            // 
            // lblTituloFrm
            // 
            this.lblTituloFrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTituloFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloFrm.Location = new System.Drawing.Point(41, 0);
            this.lblTituloFrm.Name = "lblTituloFrm";
            this.lblTituloFrm.Size = new System.Drawing.Size(156, 30);
            this.lblTituloFrm.TabIndex = 11;
            this.lblTituloFrm.Text = "Detalle del pedido";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picBTNInformacion
            // 
            this.picBTNInformacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNInformacion.Image = global::Procuratio.Properties.Resources._3017955_48;
            this.picBTNInformacion.Location = new System.Drawing.Point(1216, 0);
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
            this.picBTNCerrar.Location = new System.Drawing.Point(1257, 0);
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
            // 
            // tmrColor
            // 
            this.tmrColor.Enabled = true;
            this.tmrColor.Tick += new System.EventHandler(this.tmrColor_Tick);
            // 
            // PtdImprimirTicket
            // 
            this.PtdImprimirTicket.DocumentName = "Ticket";
            // 
            // FrmPedidosPorMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1300, 695);
            this.Controls.Add(this.pnlContenedorFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPedidosPorMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPedidosPorMesa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPedidosPorMesa_Load);
            this.Shown += new System.EventHandler(this.FrmPedidosPorMesa_Shown);
            this.pnlContenedorFrm.ResumeLayout(false);
            this.pnlContenedorFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarta)).EndInit();
            this.pnlContTotal.ResumeLayout(false);
            this.pnlContTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).EndInit();
            this.pnlContEditaPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBTNHabilitaEdicionEspecial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBTNActualizarLista)).EndInit();
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorFrm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.PictureBox picBTNInformacion;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DataGridView dgvArticulosPedido;
        private System.Windows.Forms.Panel pnlDecorativo1;
        private System.Windows.Forms.PictureBox picLupa;
        private System.Windows.Forms.TextBox txtBuscarPorNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Panel pnlContTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMostratTotal;
        private System.Windows.Forms.Timer tmrColor;
        private System.Windows.Forms.Button btnEnviarPedido;
        private System.Windows.Forms.Button btnAñadirArticulos;
        private System.Windows.Forms.Button btnPreCuenta;
        private System.Windows.Forms.Button btnPedidoRecibido;
        private System.Windows.Forms.DataGridView dgvCarta;
        private System.Windows.Forms.ComboBox cmbMesas;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblEstadoDelPedido;
        private System.Windows.Forms.Button btnImprimirTicket;
        private System.Windows.Forms.Panel pnlContEditaPedido;
        private System.Windows.Forms.PictureBox PicBTNHabilitaEdicionEspecial;
        private System.Windows.Forms.PictureBox PicBTNActualizarLista;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Button btnDisminuyeUnidad;
        private System.Windows.Forms.Button btnAumentaUnidad;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Button btnMostrarCocina;
        private System.Windows.Forms.Label lblTituloFrm;
        private System.Drawing.Printing.PrintDocument PtdImprimirTicket;
        private System.Windows.Forms.Button btnResetearSeleccionCarta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArticuloEnviado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccionDeFilas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}