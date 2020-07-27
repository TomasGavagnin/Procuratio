namespace Procuratio
{
    partial class FrmCarta
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
            this.lblRegistroDeDatos = new System.Windows.Forms.Label();
            this.dgvCarta = new System.Windows.Forms.DataGridView();
            this.colID_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PrecioDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccionDeFilas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSeleccionarTodo = new System.Windows.Forms.Button();
            this.btnDesceleccionarTodo = new System.Windows.Forms.Button();
            this.txtBuscarPorNombre = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.pnlDecorativo6 = new System.Windows.Forms.Panel();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.nudPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.btnAplicarAumentoDescuento = new System.Windows.Forms.Button();
            this.rbnAumento = new System.Windows.Forms.RadioButton();
            this.rbnDescuento = new System.Windows.Forms.RadioButton();
            this.grbAumentoDescuento = new System.Windows.Forms.GroupBox();
            this.btnEliminarArtCat = new System.Windows.Forms.Button();
            this.btnCrearArticulo = new System.Windows.Forms.Button();
            this.pnlContenedorResultados = new System.Windows.Forms.Panel();
            this.GrbUsar = new System.Windows.Forms.GroupBox();
            this.RbnCantidad = new System.Windows.Forms.RadioButton();
            this.RbnPorcentaje = new System.Windows.Forms.RadioButton();
            this.chkAplicarACarta = new System.Windows.Forms.CheckBox();
            this.chkAplicarADelivery = new System.Windows.Forms.CheckBox();
            this.chkRedondearPrecio = new System.Windows.Forms.CheckBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.pnlDecorativo1 = new System.Windows.Forms.Panel();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCrearCategoria = new System.Windows.Forms.Button();
            this.picLupa = new System.Windows.Forms.PictureBox();
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.BtnVerEditarCategorias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).BeginInit();
            this.grbAumentoDescuento.SuspendLayout();
            this.pnlContenedorResultados.SuspendLayout();
            this.GrbUsar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistroDeDatos
            // 
            this.lblRegistroDeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblRegistroDeDatos.AutoSize = true;
            this.lblRegistroDeDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroDeDatos.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistroDeDatos.Location = new System.Drawing.Point(307, 8);
            this.lblRegistroDeDatos.Name = "lblRegistroDeDatos";
            this.lblRegistroDeDatos.Size = new System.Drawing.Size(312, 19);
            this.lblRegistroDeDatos.TabIndex = 22;
            this.lblRegistroDeDatos.Text = "GESTION DE LA CARTA DEL RESTAURANTE";
            // 
            // dgvCarta
            // 
            this.dgvCarta.AllowUserToAddRows = false;
            this.dgvCarta.AllowUserToDeleteRows = false;
            this.dgvCarta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.Col_PrecioDelivery,
            this.colSeleccionDeFilas});
            this.dgvCarta.EnableHeadersVisualStyles = false;
            this.dgvCarta.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCarta.Location = new System.Drawing.Point(7, 70);
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
            this.dgvCarta.Size = new System.Drawing.Size(750, 352);
            this.dgvCarta.TabIndex = 23;
            this.dgvCarta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCarta_CellContentClick);
            this.dgvCarta.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCarta_CellMouseDoubleClick);
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
            this.colCategoria.Width = 140;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio de la carta";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 80;
            // 
            // Col_PrecioDelivery
            // 
            this.Col_PrecioDelivery.FillWeight = 80F;
            this.Col_PrecioDelivery.HeaderText = "Precio del delivery";
            this.Col_PrecioDelivery.Name = "Col_PrecioDelivery";
            this.Col_PrecioDelivery.ReadOnly = true;
            this.Col_PrecioDelivery.Width = 80;
            // 
            // colSeleccionDeFilas
            // 
            this.colSeleccionDeFilas.FillWeight = 101.5228F;
            this.colSeleccionDeFilas.HeaderText = "Seleccionar";
            this.colSeleccionDeFilas.Name = "colSeleccionDeFilas";
            // 
            // btnSeleccionarTodo
            // 
            this.btnSeleccionarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnSeleccionarTodo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSeleccionarTodo.FlatAppearance.BorderSize = 2;
            this.btnSeleccionarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarTodo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarTodo.Location = new System.Drawing.Point(418, 6);
            this.btnSeleccionarTodo.Name = "btnSeleccionarTodo";
            this.btnSeleccionarTodo.Size = new System.Drawing.Size(160, 50);
            this.btnSeleccionarTodo.TabIndex = 34;
            this.btnSeleccionarTodo.Text = "Seleccionar todo";
            this.btnSeleccionarTodo.UseVisualStyleBackColor = false;
            this.btnSeleccionarTodo.Click += new System.EventHandler(this.BtnSeleccionarTodo_Click);
            this.btnSeleccionarTodo.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnSeleccionarTodo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnDesceleccionarTodo
            // 
            this.btnDesceleccionarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesceleccionarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnDesceleccionarTodo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDesceleccionarTodo.FlatAppearance.BorderSize = 2;
            this.btnDesceleccionarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesceleccionarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesceleccionarTodo.ForeColor = System.Drawing.Color.White;
            this.btnDesceleccionarTodo.Location = new System.Drawing.Point(418, 62);
            this.btnDesceleccionarTodo.Name = "btnDesceleccionarTodo";
            this.btnDesceleccionarTodo.Size = new System.Drawing.Size(160, 50);
            this.btnDesceleccionarTodo.TabIndex = 35;
            this.btnDesceleccionarTodo.Text = "Cancelar seleccion";
            this.btnDesceleccionarTodo.UseVisualStyleBackColor = false;
            this.btnDesceleccionarTodo.Click += new System.EventHandler(this.BtnDesceleccionarTodo_Click);
            this.btnDesceleccionarTodo.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnDesceleccionarTodo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // txtBuscarPorNombre
            // 
            this.txtBuscarPorNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarPorNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtBuscarPorNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPorNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPorNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarPorNombre.Location = new System.Drawing.Point(35, 37);
            this.txtBuscarPorNombre.MaxLength = 100;
            this.txtBuscarPorNombre.Name = "txtBuscarPorNombre";
            this.txtBuscarPorNombre.Size = new System.Drawing.Size(324, 26);
            this.txtBuscarPorNombre.TabIndex = 37;
            this.txtBuscarPorNombre.Text = "Buscar por nombre de articulo...";
            this.ttpMensajesDeAyuda.SetToolTip(this.txtBuscarPorNombre, "Filtrar por nombre de articulo");
            this.txtBuscarPorNombre.TextChanged += new System.EventHandler(this.TxtBuscarPorNombre_TextChanged);
            this.txtBuscarPorNombre.Enter += new System.EventHandler(this.TxtBuscarPorNombre_Enter);
            this.txtBuscarPorNombre.Leave += new System.EventHandler(this.TxtBuscarPorNombre_Leave);
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
            this.cmbCategoria.Location = new System.Drawing.Point(529, 38);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(228, 26);
            this.cmbCategoria.TabIndex = 40;
            this.cmbCategoria.Text = "Categoria";
            this.ttpMensajesDeAyuda.SetToolTip(this.cmbCategoria, "Filtrar por categoria");
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.CmbCategoria_SelectedIndexChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCategoria.Location = new System.Drawing.Point(363, 41);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(162, 18);
            this.lblCategoria.TabIndex = 41;
            this.lblCategoria.Text = "Filtrar por categoria:";
            // 
            // pnlDecorativo6
            // 
            this.pnlDecorativo6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDecorativo6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo6.Location = new System.Drawing.Point(343, 30);
            this.pnlDecorativo6.Name = "pnlDecorativo6";
            this.pnlDecorativo6.Size = new System.Drawing.Size(55, 2);
            this.pnlDecorativo6.TabIndex = 61;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPorcentaje.Location = new System.Drawing.Point(244, 11);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(94, 18);
            this.lblPorcentaje.TabIndex = 40;
            this.lblPorcentaje.Text = "Porcentaje:";
            // 
            // nudPorcentaje
            // 
            this.nudPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.nudPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPorcentaje.ForeColor = System.Drawing.Color.DarkGray;
            this.nudPorcentaje.Location = new System.Drawing.Point(343, 12);
            this.nudPorcentaje.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudPorcentaje.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudPorcentaje.Name = "nudPorcentaje";
            this.nudPorcentaje.ReadOnly = true;
            this.nudPorcentaje.Size = new System.Drawing.Size(55, 20);
            this.nudPorcentaje.TabIndex = 60;
            this.nudPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpMensajesDeAyuda.SetToolTip(this.nudPorcentaje, "Porcentaje/descuento que se le aplciara a los articulos");
            this.nudPorcentaje.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnAplicarAumentoDescuento
            // 
            this.btnAplicarAumentoDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicarAumentoDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnAplicarAumentoDescuento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAplicarAumentoDescuento.FlatAppearance.BorderSize = 2;
            this.btnAplicarAumentoDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarAumentoDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarAumentoDescuento.ForeColor = System.Drawing.Color.White;
            this.btnAplicarAumentoDescuento.Location = new System.Drawing.Point(584, 62);
            this.btnAplicarAumentoDescuento.Name = "btnAplicarAumentoDescuento";
            this.btnAplicarAumentoDescuento.Size = new System.Drawing.Size(160, 50);
            this.btnAplicarAumentoDescuento.TabIndex = 39;
            this.btnAplicarAumentoDescuento.Text = "Aplicar a los elementos seleccionados";
            this.btnAplicarAumentoDescuento.UseVisualStyleBackColor = false;
            this.btnAplicarAumentoDescuento.Click += new System.EventHandler(this.BtnAplicarAumentoDescuento_Click);
            this.btnAplicarAumentoDescuento.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnAplicarAumentoDescuento.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // rbnAumento
            // 
            this.rbnAumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbnAumento.AutoSize = true;
            this.rbnAumento.Checked = true;
            this.rbnAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnAumento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnAumento.Location = new System.Drawing.Point(6, 31);
            this.rbnAumento.Name = "rbnAumento";
            this.rbnAumento.Size = new System.Drawing.Size(92, 22);
            this.rbnAumento.TabIndex = 32;
            this.rbnAumento.TabStop = true;
            this.rbnAumento.Text = "Aumento";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnAumento, "Aumento que se le aplicara a los articulos seleccionados basado en el porcentaje " +
        "indicado");
            this.rbnAumento.UseVisualStyleBackColor = true;
            // 
            // rbnDescuento
            // 
            this.rbnDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbnDescuento.AutoSize = true;
            this.rbnDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnDescuento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnDescuento.Location = new System.Drawing.Point(6, 66);
            this.rbnDescuento.Name = "rbnDescuento";
            this.rbnDescuento.Size = new System.Drawing.Size(107, 22);
            this.rbnDescuento.TabIndex = 33;
            this.rbnDescuento.Text = "Descuento";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnDescuento, "Descuento que se le aplicara a los articulos seleccionados basado en el porcentaj" +
        "e indicado");
            this.rbnDescuento.UseVisualStyleBackColor = true;
            // 
            // grbAumentoDescuento
            // 
            this.grbAumentoDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbAumentoDescuento.Controls.Add(this.rbnDescuento);
            this.grbAumentoDescuento.Controls.Add(this.rbnAumento);
            this.grbAumentoDescuento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grbAumentoDescuento.ForeColor = System.Drawing.Color.Gray;
            this.grbAumentoDescuento.Location = new System.Drawing.Point(5, 6);
            this.grbAumentoDescuento.Name = "grbAumentoDescuento";
            this.grbAumentoDescuento.Size = new System.Drawing.Size(115, 106);
            this.grbAumentoDescuento.TabIndex = 42;
            this.grbAumentoDescuento.TabStop = false;
            this.grbAumentoDescuento.Text = "Realizar un";
            // 
            // btnEliminarArtCat
            // 
            this.btnEliminarArtCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarArtCat.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarArtCat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarArtCat.FlatAppearance.BorderSize = 2;
            this.btnEliminarArtCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArtCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArtCat.ForeColor = System.Drawing.Color.White;
            this.btnEliminarArtCat.Location = new System.Drawing.Point(766, 238);
            this.btnEliminarArtCat.Name = "btnEliminarArtCat";
            this.btnEliminarArtCat.Size = new System.Drawing.Size(160, 50);
            this.btnEliminarArtCat.TabIndex = 63;
            this.btnEliminarArtCat.Text = "Eliminar o restaurar articulos y categorias";
            this.btnEliminarArtCat.UseVisualStyleBackColor = false;
            this.btnEliminarArtCat.Click += new System.EventHandler(this.BtnEliminarArtCat_Click);
            this.btnEliminarArtCat.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnEliminarArtCat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnCrearArticulo
            // 
            this.btnCrearArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearArticulo.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearArticulo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrearArticulo.FlatAppearance.BorderSize = 2;
            this.btnCrearArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearArticulo.ForeColor = System.Drawing.Color.White;
            this.btnCrearArticulo.Location = new System.Drawing.Point(766, 70);
            this.btnCrearArticulo.Name = "btnCrearArticulo";
            this.btnCrearArticulo.Size = new System.Drawing.Size(160, 50);
            this.btnCrearArticulo.TabIndex = 66;
            this.btnCrearArticulo.Text = "Crear articulo";
            this.btnCrearArticulo.UseVisualStyleBackColor = false;
            this.btnCrearArticulo.Click += new System.EventHandler(this.BtnCrearArticulo_Click);
            this.btnCrearArticulo.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCrearArticulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // pnlContenedorResultados
            // 
            this.pnlContenedorResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pnlContenedorResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorResultados.Controls.Add(this.GrbUsar);
            this.pnlContenedorResultados.Controls.Add(this.chkAplicarACarta);
            this.pnlContenedorResultados.Controls.Add(this.chkAplicarADelivery);
            this.pnlContenedorResultados.Controls.Add(this.chkRedondearPrecio);
            this.pnlContenedorResultados.Controls.Add(this.pnlDecorativo6);
            this.pnlContenedorResultados.Controls.Add(this.lblPorcentaje);
            this.pnlContenedorResultados.Controls.Add(this.nudPorcentaje);
            this.pnlContenedorResultados.Controls.Add(this.grbAumentoDescuento);
            this.pnlContenedorResultados.Controls.Add(this.btnAplicarAumentoDescuento);
            this.pnlContenedorResultados.Controls.Add(this.btnDesceleccionarTodo);
            this.pnlContenedorResultados.Controls.Add(this.btnSeleccionarTodo);
            this.pnlContenedorResultados.Controls.Add(this.txtCantidad);
            this.pnlContenedorResultados.Controls.Add(this.pnlDecorativo1);
            this.pnlContenedorResultados.Controls.Add(this.lblCantidad);
            this.pnlContenedorResultados.Location = new System.Drawing.Point(7, 428);
            this.pnlContenedorResultados.Name = "pnlContenedorResultados";
            this.pnlContenedorResultados.Size = new System.Drawing.Size(750, 120);
            this.pnlContenedorResultados.TabIndex = 67;
            // 
            // GrbUsar
            // 
            this.GrbUsar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GrbUsar.Controls.Add(this.RbnCantidad);
            this.GrbUsar.Controls.Add(this.RbnPorcentaje);
            this.GrbUsar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.GrbUsar.ForeColor = System.Drawing.Color.Gray;
            this.GrbUsar.Location = new System.Drawing.Point(123, 6);
            this.GrbUsar.Name = "GrbUsar";
            this.GrbUsar.Size = new System.Drawing.Size(115, 106);
            this.GrbUsar.TabIndex = 43;
            this.GrbUsar.TabStop = false;
            this.GrbUsar.Text = "Usar";
            // 
            // RbnCantidad
            // 
            this.RbnCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RbnCantidad.AutoSize = true;
            this.RbnCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.RbnCantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RbnCantidad.Location = new System.Drawing.Point(6, 66);
            this.RbnCantidad.Name = "RbnCantidad";
            this.RbnCantidad.Size = new System.Drawing.Size(92, 22);
            this.RbnCantidad.TabIndex = 33;
            this.RbnCantidad.Text = "Cantidad";
            this.ttpMensajesDeAyuda.SetToolTip(this.RbnCantidad, "Aumento que se le aplicara a los articulos seleccionados basado en la cantidad in" +
        "gresada");
            this.RbnCantidad.UseVisualStyleBackColor = true;
            this.RbnCantidad.Click += new System.EventHandler(this.RbnCantidad_Click);
            // 
            // RbnPorcentaje
            // 
            this.RbnPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RbnPorcentaje.AutoSize = true;
            this.RbnPorcentaje.Checked = true;
            this.RbnPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.RbnPorcentaje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RbnPorcentaje.Location = new System.Drawing.Point(6, 31);
            this.RbnPorcentaje.Name = "RbnPorcentaje";
            this.RbnPorcentaje.Size = new System.Drawing.Size(107, 22);
            this.RbnPorcentaje.TabIndex = 32;
            this.RbnPorcentaje.TabStop = true;
            this.RbnPorcentaje.Text = "Porcentaje";
            this.ttpMensajesDeAyuda.SetToolTip(this.RbnPorcentaje, "Aumento que se le aplicara a los articulos seleccionados basado en el porcentaje " +
        "indicado");
            this.RbnPorcentaje.UseVisualStyleBackColor = true;
            this.RbnPorcentaje.Click += new System.EventHandler(this.RbnPorcentaje_Click);
            // 
            // chkAplicarACarta
            // 
            this.chkAplicarACarta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAplicarACarta.AutoSize = true;
            this.chkAplicarACarta.Checked = true;
            this.chkAplicarACarta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAplicarACarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.chkAplicarACarta.ForeColor = System.Drawing.Color.White;
            this.chkAplicarACarta.Location = new System.Drawing.Point(247, 63);
            this.chkAplicarACarta.Name = "chkAplicarACarta";
            this.chkAplicarACarta.Size = new System.Drawing.Size(153, 22);
            this.chkAplicarACarta.TabIndex = 64;
            this.chkAplicarACarta.Text = "Aplicar a la carta";
            this.ttpMensajesDeAyuda.SetToolTip(this.chkAplicarACarta, "Le aplica el descuento/aumento al precio del delivery");
            this.chkAplicarACarta.UseVisualStyleBackColor = true;
            // 
            // chkAplicarADelivery
            // 
            this.chkAplicarADelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAplicarADelivery.AutoSize = true;
            this.chkAplicarADelivery.Checked = true;
            this.chkAplicarADelivery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAplicarADelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.chkAplicarADelivery.ForeColor = System.Drawing.Color.White;
            this.chkAplicarADelivery.Location = new System.Drawing.Point(247, 90);
            this.chkAplicarADelivery.Name = "chkAplicarADelivery";
            this.chkAplicarADelivery.Size = new System.Drawing.Size(154, 22);
            this.chkAplicarADelivery.TabIndex = 63;
            this.chkAplicarADelivery.Text = "Aplicar a delivery";
            this.ttpMensajesDeAyuda.SetToolTip(this.chkAplicarADelivery, "Le aplica el descuento/aumento al precio del delivery");
            this.chkAplicarADelivery.UseVisualStyleBackColor = true;
            // 
            // chkRedondearPrecio
            // 
            this.chkRedondearPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkRedondearPrecio.AutoSize = true;
            this.chkRedondearPrecio.Checked = true;
            this.chkRedondearPrecio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRedondearPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.chkRedondearPrecio.ForeColor = System.Drawing.Color.White;
            this.chkRedondearPrecio.Location = new System.Drawing.Point(247, 37);
            this.chkRedondearPrecio.Name = "chkRedondearPrecio";
            this.chkRedondearPrecio.Size = new System.Drawing.Size(161, 22);
            this.chkRedondearPrecio.TabIndex = 62;
            this.chkRedondearPrecio.Text = "Redondear precio";
            this.ttpMensajesDeAyuda.SetToolTip(this.chkRedondearPrecio, "Redondear el precio evitando que los articulos tengan precios que incluyan centav" +
        "os, ademas de que se asignara un precio que termine con 5 o 0 (por cuestiones de" +
        " una gestion de vuelvo mas eficiente)");
            this.chkRedondearPrecio.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCantidad.Location = new System.Drawing.Point(323, 11);
            this.txtCantidad.MaxLength = 7;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(75, 19);
            this.txtCantidad.TabIndex = 71;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpMensajesDeAyuda.SetToolTip(this.txtCantidad, "Pago del cliente");
            this.txtCantidad.Visible = false;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // pnlDecorativo1
            // 
            this.pnlDecorativo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo1.Location = new System.Drawing.Point(324, 30);
            this.pnlDecorativo1.Name = "pnlDecorativo1";
            this.pnlDecorativo1.Size = new System.Drawing.Size(75, 2);
            this.pnlDecorativo1.TabIndex = 70;
            this.pnlDecorativo1.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidad.Location = new System.Drawing.Point(244, 11);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 18);
            this.lblCantidad.TabIndex = 65;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.Visible = false;
            // 
            // btnCrearCategoria
            // 
            this.btnCrearCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrearCategoria.FlatAppearance.BorderSize = 2;
            this.btnCrearCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCrearCategoria.Location = new System.Drawing.Point(766, 126);
            this.btnCrearCategoria.Name = "btnCrearCategoria";
            this.btnCrearCategoria.Size = new System.Drawing.Size(160, 50);
            this.btnCrearCategoria.TabIndex = 68;
            this.btnCrearCategoria.Text = "Crear categoria";
            this.btnCrearCategoria.UseVisualStyleBackColor = false;
            this.btnCrearCategoria.Click += new System.EventHandler(this.BtnCrearCategoria_Click);
            this.btnCrearCategoria.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCrearCategoria.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // picLupa
            // 
            this.picLupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.picLupa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLupa.Image = global::Procuratio.Properties.Resources.Lupa;
            this.picLupa.Location = new System.Drawing.Point(7, 37);
            this.picLupa.Name = "picLupa";
            this.picLupa.Size = new System.Drawing.Size(29, 26);
            this.picLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLupa.TabIndex = 38;
            this.picLupa.TabStop = false;
            // 
            // BtnVerEditarCategorias
            // 
            this.BtnVerEditarCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVerEditarCategorias.BackColor = System.Drawing.Color.Transparent;
            this.BtnVerEditarCategorias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnVerEditarCategorias.FlatAppearance.BorderSize = 2;
            this.BtnVerEditarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerEditarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerEditarCategorias.ForeColor = System.Drawing.Color.White;
            this.BtnVerEditarCategorias.Location = new System.Drawing.Point(766, 182);
            this.BtnVerEditarCategorias.Name = "BtnVerEditarCategorias";
            this.BtnVerEditarCategorias.Size = new System.Drawing.Size(160, 50);
            this.BtnVerEditarCategorias.TabIndex = 69;
            this.BtnVerEditarCategorias.Text = "Ver y editar categorias";
            this.BtnVerEditarCategorias.UseVisualStyleBackColor = false;
            this.BtnVerEditarCategorias.Click += new System.EventHandler(this.BtnVerEditarCategorias_Click);
            this.BtnVerEditarCategorias.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.BtnVerEditarCategorias.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // FrmCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(935, 555);
            this.Controls.Add(this.BtnVerEditarCategorias);
            this.Controls.Add(this.btnCrearCategoria);
            this.Controls.Add(this.pnlContenedorResultados);
            this.Controls.Add(this.btnCrearArticulo);
            this.Controls.Add(this.btnEliminarArtCat);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.picLupa);
            this.Controls.Add(this.txtBuscarPorNombre);
            this.Controls.Add(this.dgvCarta);
            this.Controls.Add(this.lblRegistroDeDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCarta";
            this.Text = "FrmCarta";
            this.Load += new System.EventHandler(this.FrmCarta_Load);
            this.Shown += new System.EventHandler(this.FrmCarta_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).EndInit();
            this.grbAumentoDescuento.ResumeLayout(false);
            this.grbAumentoDescuento.PerformLayout();
            this.pnlContenedorResultados.ResumeLayout(false);
            this.pnlContenedorResultados.PerformLayout();
            this.GrbUsar.ResumeLayout(false);
            this.GrbUsar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistroDeDatos;
        private System.Windows.Forms.DataGridView dgvCarta;
        private System.Windows.Forms.Button btnSeleccionarTodo;
        private System.Windows.Forms.Button btnDesceleccionarTodo;
        private System.Windows.Forms.TextBox txtBuscarPorNombre;
        private System.Windows.Forms.PictureBox picLupa;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel pnlDecorativo6;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.NumericUpDown nudPorcentaje;
        private System.Windows.Forms.Button btnAplicarAumentoDescuento;
        private System.Windows.Forms.RadioButton rbnAumento;
        private System.Windows.Forms.RadioButton rbnDescuento;
        private System.Windows.Forms.GroupBox grbAumentoDescuento;
        private System.Windows.Forms.Button btnEliminarArtCat;
        private System.Windows.Forms.Button btnCrearArticulo;
        private System.Windows.Forms.Panel pnlContenedorResultados;
        private System.Windows.Forms.Button btnCrearCategoria;
        private System.Windows.Forms.CheckBox chkRedondearPrecio;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Button BtnVerEditarCategorias;
        private System.Windows.Forms.CheckBox chkAplicarADelivery;
        private System.Windows.Forms.CheckBox chkAplicarACarta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PrecioDelivery;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccionDeFilas;
        private System.Windows.Forms.GroupBox GrbUsar;
        private System.Windows.Forms.RadioButton RbnCantidad;
        private System.Windows.Forms.RadioButton RbnPorcentaje;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Panel pnlDecorativo1;
    }
}