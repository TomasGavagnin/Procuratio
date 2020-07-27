namespace Procuratio
{
    partial class FrmCambiarEstados
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
            this.pnlContFrm = new System.Windows.Forms.Panel();
            this.grbUsuarios = new System.Windows.Forms.GroupBox();
            this.rbnelementosInactivos = new System.Windows.Forms.RadioButton();
            this.rbnElementosActivos = new System.Windows.Forms.RadioButton();
            this.btnEliminarElementos = new System.Windows.Forms.Button();
            this.btnRestaurarElementos = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.picLupa = new System.Windows.Forms.PictureBox();
            this.txtBuscarPorNombre = new System.Windows.Forms.TextBox();
            this.dgvEstadoCategoria = new System.Windows.Forms.DataGridView();
            this.colID_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParaCocina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvEstadoArticulo = new System.Windows.Forms.DataGridView();
            this.colID_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioDelivey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccionDeFilas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.pnlContFrm.SuspendLayout();
            this.grbUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoArticulo)).BeginInit();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContFrm
            // 
            this.pnlContFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContFrm.Controls.Add(this.grbUsuarios);
            this.pnlContFrm.Controls.Add(this.btnEliminarElementos);
            this.pnlContFrm.Controls.Add(this.btnRestaurarElementos);
            this.pnlContFrm.Controls.Add(this.lblCategoria);
            this.pnlContFrm.Controls.Add(this.cmbCategoria);
            this.pnlContFrm.Controls.Add(this.picLupa);
            this.pnlContFrm.Controls.Add(this.txtBuscarPorNombre);
            this.pnlContFrm.Controls.Add(this.dgvEstadoCategoria);
            this.pnlContFrm.Controls.Add(this.dgvEstadoArticulo);
            this.pnlContFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContFrm.Name = "pnlContFrm";
            this.pnlContFrm.Size = new System.Drawing.Size(1255, 600);
            this.pnlContFrm.TabIndex = 0;
            // 
            // grbUsuarios
            // 
            this.grbUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grbUsuarios.Controls.Add(this.rbnelementosInactivos);
            this.grbUsuarios.Controls.Add(this.rbnElementosActivos);
            this.grbUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grbUsuarios.ForeColor = System.Drawing.Color.Gray;
            this.grbUsuarios.Location = new System.Drawing.Point(1082, 505);
            this.grbUsuarios.Name = "grbUsuarios";
            this.grbUsuarios.Size = new System.Drawing.Size(160, 83);
            this.grbUsuarios.TabIndex = 79;
            this.grbUsuarios.TabStop = false;
            this.grbUsuarios.Text = "Ver";
            // 
            // rbnelementosInactivos
            // 
            this.rbnelementosInactivos.AutoSize = true;
            this.rbnelementosInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnelementosInactivos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnelementosInactivos.Location = new System.Drawing.Point(6, 54);
            this.rbnelementosInactivos.Name = "rbnelementosInactivos";
            this.rbnelementosInactivos.Size = new System.Drawing.Size(93, 22);
            this.rbnelementosInactivos.TabIndex = 33;
            this.rbnelementosInactivos.Text = "Inactivos";
            this.rbnelementosInactivos.UseVisualStyleBackColor = true;
            this.rbnelementosInactivos.CheckedChanged += new System.EventHandler(this.RbnelementosInactivos_CheckedChanged);
            // 
            // rbnElementosActivos
            // 
            this.rbnElementosActivos.AutoSize = true;
            this.rbnElementosActivos.Checked = true;
            this.rbnElementosActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnElementosActivos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnElementosActivos.Location = new System.Drawing.Point(6, 26);
            this.rbnElementosActivos.Name = "rbnElementosActivos";
            this.rbnElementosActivos.Size = new System.Drawing.Size(81, 22);
            this.rbnElementosActivos.TabIndex = 32;
            this.rbnElementosActivos.TabStop = true;
            this.rbnElementosActivos.Text = "Activos";
            this.rbnElementosActivos.UseVisualStyleBackColor = true;
            this.rbnElementosActivos.CheckedChanged += new System.EventHandler(this.RbnElementosActivos_CheckedChanged);
            // 
            // btnEliminarElementos
            // 
            this.btnEliminarElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarElementos.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarElementos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarElementos.FlatAppearance.BorderSize = 2;
            this.btnEliminarElementos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarElementos.ForeColor = System.Drawing.Color.White;
            this.btnEliminarElementos.Location = new System.Drawing.Point(1082, 69);
            this.btnEliminarElementos.Name = "btnEliminarElementos";
            this.btnEliminarElementos.Size = new System.Drawing.Size(160, 50);
            this.btnEliminarElementos.TabIndex = 77;
            this.btnEliminarElementos.Text = "Eliminar elementos seleccionados";
            this.btnEliminarElementos.UseVisualStyleBackColor = false;
            this.btnEliminarElementos.Click += new System.EventHandler(this.BtnEliminarElementos_Click);
            this.btnEliminarElementos.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnEliminarElementos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnRestaurarElementos
            // 
            this.btnRestaurarElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurarElementos.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaurarElementos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestaurarElementos.FlatAppearance.BorderSize = 2;
            this.btnRestaurarElementos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurarElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurarElementos.ForeColor = System.Drawing.Color.White;
            this.btnRestaurarElementos.Location = new System.Drawing.Point(1082, 69);
            this.btnRestaurarElementos.Name = "btnRestaurarElementos";
            this.btnRestaurarElementos.Size = new System.Drawing.Size(160, 50);
            this.btnRestaurarElementos.TabIndex = 80;
            this.btnRestaurarElementos.Text = "Activar elementos seleccionados";
            this.btnRestaurarElementos.UseVisualStyleBackColor = false;
            this.btnRestaurarElementos.Visible = false;
            this.btnRestaurarElementos.Click += new System.EventHandler(this.BtnRestaurarElementos_Click);
            this.btnRestaurarElementos.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnRestaurarElementos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCategoria.Location = new System.Drawing.Point(392, 41);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(162, 18);
            this.lblCategoria.TabIndex = 76;
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
            this.cmbCategoria.Items.AddRange(new object[] {
            "Todas las categorias"});
            this.cmbCategoria.Location = new System.Drawing.Point(558, 37);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(250, 26);
            this.cmbCategoria.TabIndex = 75;
            this.cmbCategoria.Text = "Todas las categorias";
            this.ttpMensajesDeAyuda.SetToolTip(this.cmbCategoria, "Filtrar por categoria");
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.CmbCategoria_SelectedIndexChanged);
            // 
            // picLupa
            // 
            this.picLupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.picLupa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLupa.Image = global::Procuratio.Properties.Resources.Lupa;
            this.picLupa.Location = new System.Drawing.Point(11, 37);
            this.picLupa.Name = "picLupa";
            this.picLupa.Size = new System.Drawing.Size(30, 26);
            this.picLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLupa.TabIndex = 74;
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
            this.txtBuscarPorNombre.Location = new System.Drawing.Point(40, 37);
            this.txtBuscarPorNombre.MaxLength = 100;
            this.txtBuscarPorNombre.Name = "txtBuscarPorNombre";
            this.txtBuscarPorNombre.Size = new System.Drawing.Size(346, 26);
            this.txtBuscarPorNombre.TabIndex = 73;
            this.txtBuscarPorNombre.Text = "Buscar por nombre de articulo...";
            this.ttpMensajesDeAyuda.SetToolTip(this.txtBuscarPorNombre, "Filtrar por nombre de articulo");
            this.txtBuscarPorNombre.TextChanged += new System.EventHandler(this.TxtBuscarPorNombre_TextChanged);
            this.txtBuscarPorNombre.Enter += new System.EventHandler(this.TxtBuscarPorNombre_Enter);
            this.txtBuscarPorNombre.Leave += new System.EventHandler(this.TxtBuscarPorNombre_Leave);
            // 
            // dgvEstadoCategoria
            // 
            this.dgvEstadoCategoria.AllowUserToAddRows = false;
            this.dgvEstadoCategoria.AllowUserToDeleteRows = false;
            this.dgvEstadoCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstadoCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstadoCategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvEstadoCategoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvEstadoCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstadoCategoria.ColumnHeadersHeight = 45;
            this.dgvEstadoCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEstadoCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID_Categoria,
            this.colNombreCategoria,
            this.colParaCocina,
            this.colSeleccionar});
            this.dgvEstadoCategoria.EnableHeadersVisualStyles = false;
            this.dgvEstadoCategoria.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEstadoCategoria.Location = new System.Drawing.Point(814, 69);
            this.dgvEstadoCategoria.Name = "dgvEstadoCategoria";
            this.dgvEstadoCategoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstadoCategoria.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvEstadoCategoria.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstadoCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEstadoCategoria.Size = new System.Drawing.Size(262, 519);
            this.dgvEstadoCategoria.TabIndex = 25;
            this.ttpMensajesDeAyuda.SetToolTip(this.dgvEstadoCategoria, "Categorias");
            this.dgvEstadoCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstadoCategoria_CellContentClick);
            // 
            // colID_Categoria
            // 
            this.colID_Categoria.HeaderText = "ID_Categoria";
            this.colID_Categoria.Name = "colID_Categoria";
            this.colID_Categoria.ReadOnly = true;
            this.colID_Categoria.Visible = false;
            this.colID_Categoria.Width = 116;
            // 
            // colNombreCategoria
            // 
            this.colNombreCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombreCategoria.FillWeight = 125F;
            this.colNombreCategoria.HeaderText = "Categoria";
            this.colNombreCategoria.Name = "colNombreCategoria";
            this.colNombreCategoria.ReadOnly = true;
            // 
            // colParaCocina
            // 
            this.colParaCocina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colParaCocina.FillWeight = 80F;
            this.colParaCocina.HeaderText = "Se envian a cocina";
            this.colParaCocina.Name = "colParaCocina";
            this.colParaCocina.ReadOnly = true;
            this.colParaCocina.Width = 75;
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSeleccionar.FillWeight = 60F;
            this.colSeleccionar.HeaderText = "Seleccionar";
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Width = 80;
            // 
            // dgvEstadoArticulo
            // 
            this.dgvEstadoArticulo.AllowUserToAddRows = false;
            this.dgvEstadoArticulo.AllowUserToDeleteRows = false;
            this.dgvEstadoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstadoArticulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvEstadoArticulo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvEstadoArticulo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoArticulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEstadoArticulo.ColumnHeadersHeight = 45;
            this.dgvEstadoArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEstadoArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID_Articulo,
            this.colNombre,
            this.colDescripcion,
            this.colCategoria,
            this.colPrecio,
            this.ColPrecioDelivey,
            this.colSeleccionDeFilas});
            this.dgvEstadoArticulo.EnableHeadersVisualStyles = false;
            this.dgvEstadoArticulo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEstadoArticulo.Location = new System.Drawing.Point(11, 69);
            this.dgvEstadoArticulo.Name = "dgvEstadoArticulo";
            this.dgvEstadoArticulo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoArticulo.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEstadoArticulo.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvEstadoArticulo.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEstadoArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEstadoArticulo.Size = new System.Drawing.Size(797, 518);
            this.dgvEstadoArticulo.TabIndex = 24;
            this.ttpMensajesDeAyuda.SetToolTip(this.dgvEstadoArticulo, "Articulos");
            this.dgvEstadoArticulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstadoArticulo_CellContentClick);
            // 
            // colID_Articulo
            // 
            this.colID_Articulo.HeaderText = "ID_Articulo";
            this.colID_Articulo.Name = "colID_Articulo";
            this.colID_Articulo.ReadOnly = true;
            this.colID_Articulo.Visible = false;
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 98.47717F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 170;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            this.colCategoria.Width = 170;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio carta";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // ColPrecioDelivey
            // 
            this.ColPrecioDelivey.HeaderText = "Precio delivery";
            this.ColPrecioDelivey.Name = "ColPrecioDelivey";
            this.ColPrecioDelivey.ReadOnly = true;
            // 
            // colSeleccionDeFilas
            // 
            this.colSeleccionDeFilas.FillWeight = 101.5228F;
            this.colSeleccionDeFilas.HeaderText = "Seleccionar";
            this.colSeleccionDeFilas.Name = "colSeleccionDeFilas";
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
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(1253, 30);
            this.pnlBarraDeArrastre.TabIndex = 2;
            this.pnlBarraDeArrastre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // lblTituloFrm
            // 
            this.lblTituloFrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTituloFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloFrm.Location = new System.Drawing.Point(41, 0);
            this.lblTituloFrm.Name = "lblTituloFrm";
            this.lblTituloFrm.Size = new System.Drawing.Size(275, 30);
            this.lblTituloFrm.TabIndex = 11;
            this.lblTituloFrm.Text = "Administrar articulos y categorias";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar;
            this.picBTNCerrar.Location = new System.Drawing.Point(1212, 0);
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
            // FrmCambiarEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1255, 600);
            this.Controls.Add(this.pnlContFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCambiarEstados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCambiarEstados";
            this.Load += new System.EventHandler(this.FrmCambiarEstados_Load);
            this.Shown += new System.EventHandler(this.FrmCambiarEstados_Shown);
            this.pnlContFrm.ResumeLayout(false);
            this.pnlContFrm.PerformLayout();
            this.grbUsuarios.ResumeLayout(false);
            this.grbUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoArticulo)).EndInit();
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContFrm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DataGridView dgvEstadoArticulo;
        private System.Windows.Forms.DataGridView dgvEstadoCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.PictureBox picLupa;
        private System.Windows.Forms.TextBox txtBuscarPorNombre;
        private System.Windows.Forms.GroupBox grbUsuarios;
        private System.Windows.Forms.RadioButton rbnelementosInactivos;
        private System.Windows.Forms.RadioButton rbnElementosActivos;
        private System.Windows.Forms.Button btnEliminarElementos;
        private System.Windows.Forms.Button btnRestaurarElementos;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Label lblTituloFrm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParaCocina;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioDelivey;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccionDeFilas;
    }
}