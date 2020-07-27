namespace Procuratio
{
    partial class FrmResumenPedido
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
            this.pnlContenedorFrm = new System.Windows.Forms.Panel();
            this.cmbMesas = new System.Windows.Forms.ComboBox();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.dgvArticulosPedido = new System.Windows.Forms.DataGridView();
            this.colID_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContenedorResumen = new System.Windows.Forms.Panel();
            this.chkRedondearPrecio = new System.Windows.Forms.CheckBox();
            this.lblTotalAumento = new System.Windows.Forms.Label();
            this.lblMostrarTotalAumento = new System.Windows.Forms.Label();
            this.pnlDecorativo6 = new System.Windows.Forms.Panel();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.nudPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.lblTotalDescuento = new System.Windows.Forms.Label();
            this.lblMostrarTotalDescuento = new System.Windows.Forms.Label();
            this.gpbDescuentosAumentos = new System.Windows.Forms.GroupBox();
            this.rbnNoRealizarAumentoDescuento = new System.Windows.Forms.RadioButton();
            this.rbnAumento = new System.Windows.Forms.RadioButton();
            this.rbnDescuento = new System.Windows.Forms.RadioButton();
            this.btnImprimirResumen = new System.Windows.Forms.Button();
            this.grbEgresoIngreso = new System.Windows.Forms.GroupBox();
            this.rbnEgreso = new System.Windows.Forms.RadioButton();
            this.rbnIngreso = new System.Windows.Forms.RadioButton();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.pnlDecorativo1 = new System.Windows.Forms.Panel();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMostratTotal = new System.Windows.Forms.Label();
            this.lblMostrarVuelto = new System.Windows.Forms.Label();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.PtdImprimirTicket = new System.Drawing.Printing.PrintDocument();
            this.btnCerrarPreCuenta = new System.Windows.Forms.Button();
            this.pnlContenedorFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosPedido)).BeginInit();
            this.pnlContenedorResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).BeginInit();
            this.gpbDescuentosAumentos.SuspendLayout();
            this.grbEgresoIngreso.SuspendLayout();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedorFrm
            // 
            this.pnlContenedorFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorFrm.Controls.Add(this.cmbMesas);
            this.pnlContenedorFrm.Controls.Add(this.lblNumeroPedido);
            this.pnlContenedorFrm.Controls.Add(this.dgvArticulosPedido);
            this.pnlContenedorFrm.Controls.Add(this.pnlContenedorResumen);
            this.pnlContenedorFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContenedorFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorFrm.Name = "pnlContenedorFrm";
            this.pnlContenedorFrm.Size = new System.Drawing.Size(800, 700);
            this.pnlContenedorFrm.TabIndex = 0;
            // 
            // cmbMesas
            // 
            this.cmbMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.cmbMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMesas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbMesas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMesas.FormattingEnabled = true;
            this.cmbMesas.Location = new System.Drawing.Point(11, 37);
            this.cmbMesas.Name = "cmbMesas";
            this.cmbMesas.Size = new System.Drawing.Size(80, 26);
            this.cmbMesas.TabIndex = 72;
            this.cmbMesas.Text = "Mesas";
            this.ttpMensajesDeAyuda.SetToolTip(this.cmbMesas, "Ver las mesas del pedido");
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPedido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumeroPedido.Location = new System.Drawing.Point(97, 42);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(89, 18);
            this.lblNumeroPedido.TabIndex = 47;
            this.lblNumeroPedido.Text = "Pedido N°:";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulosPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulosPedido.ColumnHeadersHeight = 45;
            this.dgvArticulosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArticulosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID_Articulo,
            this.colArticulo,
            this.colCantidad,
            this.colPrecioUnitario,
            this.ColSubtotal});
            this.dgvArticulosPedido.EnableHeadersVisualStyles = false;
            this.dgvArticulosPedido.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvArticulosPedido.Location = new System.Drawing.Point(11, 69);
            this.dgvArticulosPedido.Name = "dgvArticulosPedido";
            this.dgvArticulosPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulosPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvArticulosPedido.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvArticulosPedido.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvArticulosPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvArticulosPedido.Size = new System.Drawing.Size(776, 353);
            this.dgvArticulosPedido.TabIndex = 25;
            this.ttpMensajesDeAyuda.SetToolTip(this.dgvArticulosPedido, "Detalle del pedido");
            // 
            // colID_Articulo
            // 
            this.colID_Articulo.HeaderText = "ID_Articulo";
            this.colID_Articulo.Name = "colID_Articulo";
            this.colID_Articulo.ReadOnly = true;
            this.colID_Articulo.Visible = false;
            this.colID_Articulo.Width = 102;
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
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 87;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrecioUnitario.FillWeight = 40F;
            this.colPrecioUnitario.HeaderText = "Precio unitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            // 
            // ColSubtotal
            // 
            this.ColSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColSubtotal.FillWeight = 40F;
            this.ColSubtotal.HeaderText = "Subtotal";
            this.ColSubtotal.Name = "ColSubtotal";
            this.ColSubtotal.ReadOnly = true;
            // 
            // pnlContenedorResumen
            // 
            this.pnlContenedorResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pnlContenedorResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorResumen.Controls.Add(this.chkRedondearPrecio);
            this.pnlContenedorResumen.Controls.Add(this.lblTotalAumento);
            this.pnlContenedorResumen.Controls.Add(this.lblMostrarTotalAumento);
            this.pnlContenedorResumen.Controls.Add(this.pnlDecorativo6);
            this.pnlContenedorResumen.Controls.Add(this.lblPorcentaje);
            this.pnlContenedorResumen.Controls.Add(this.nudPorcentaje);
            this.pnlContenedorResumen.Controls.Add(this.lblTotalDescuento);
            this.pnlContenedorResumen.Controls.Add(this.lblMostrarTotalDescuento);
            this.pnlContenedorResumen.Controls.Add(this.gpbDescuentosAumentos);
            this.pnlContenedorResumen.Controls.Add(this.btnImprimirResumen);
            this.pnlContenedorResumen.Controls.Add(this.grbEgresoIngreso);
            this.pnlContenedorResumen.Controls.Add(this.txtPago);
            this.pnlContenedorResumen.Controls.Add(this.pnlDecorativo1);
            this.pnlContenedorResumen.Controls.Add(this.lblPago);
            this.pnlContenedorResumen.Controls.Add(this.lblVuelto);
            this.pnlContenedorResumen.Controls.Add(this.lblTotal);
            this.pnlContenedorResumen.Controls.Add(this.lblMostratTotal);
            this.pnlContenedorResumen.Controls.Add(this.lblMostrarVuelto);
            this.pnlContenedorResumen.Controls.Add(this.btnRegistrarPago);
            this.pnlContenedorResumen.Controls.Add(this.btnCerrarPreCuenta);
            this.pnlContenedorResumen.Location = new System.Drawing.Point(11, 428);
            this.pnlContenedorResumen.Name = "pnlContenedorResumen";
            this.pnlContenedorResumen.Size = new System.Drawing.Size(776, 260);
            this.pnlContenedorResumen.TabIndex = 46;
            // 
            // chkRedondearPrecio
            // 
            this.chkRedondearPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkRedondearPrecio.AutoSize = true;
            this.chkRedondearPrecio.Checked = true;
            this.chkRedondearPrecio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRedondearPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.chkRedondearPrecio.ForeColor = System.Drawing.Color.White;
            this.chkRedondearPrecio.Location = new System.Drawing.Point(267, 138);
            this.chkRedondearPrecio.Name = "chkRedondearPrecio";
            this.chkRedondearPrecio.Size = new System.Drawing.Size(161, 22);
            this.chkRedondearPrecio.TabIndex = 67;
            this.chkRedondearPrecio.Text = "Redondear precio";
            this.ttpMensajesDeAyuda.SetToolTip(this.chkRedondearPrecio, "Redondear el precio evitando que los articulos tengan precios que incluyan centav" +
        "os, ademas de que se asignara un precio que termine con 5 o 0 (por cuestiones de" +
        " una gestion de vuelvo mas eficiente)");
            this.chkRedondearPrecio.UseVisualStyleBackColor = true;
            this.chkRedondearPrecio.CheckedChanged += new System.EventHandler(this.ChkRedondearPrecio_CheckedChanged);
            // 
            // lblTotalAumento
            // 
            this.lblTotalAumento.AutoSize = true;
            this.lblTotalAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAumento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalAumento.Location = new System.Drawing.Point(9, 223);
            this.lblTotalAumento.Name = "lblTotalAumento";
            this.lblTotalAumento.Size = new System.Drawing.Size(190, 18);
            this.lblTotalAumento.TabIndex = 65;
            this.lblTotalAumento.Text = "Total que se aumentara:";
            // 
            // lblMostrarTotalAumento
            // 
            this.lblMostrarTotalAumento.AutoSize = true;
            this.lblMostrarTotalAumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblMostrarTotalAumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrarTotalAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarTotalAumento.ForeColor = System.Drawing.Color.Gray;
            this.lblMostrarTotalAumento.Location = new System.Drawing.Point(203, 221);
            this.lblMostrarTotalAumento.Name = "lblMostrarTotalAumento";
            this.lblMostrarTotalAumento.Size = new System.Drawing.Size(21, 22);
            this.lblMostrarTotalAumento.TabIndex = 66;
            this.lblMostrarTotalAumento.Text = "0";
            this.ttpMensajesDeAyuda.SetToolTip(this.lblMostrarTotalAumento, "Valor que se aumentara del total");
            // 
            // pnlDecorativo6
            // 
            this.pnlDecorativo6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDecorativo6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo6.Location = new System.Drawing.Point(203, 157);
            this.pnlDecorativo6.Name = "pnlDecorativo6";
            this.pnlDecorativo6.Size = new System.Drawing.Size(55, 2);
            this.pnlDecorativo6.TabIndex = 64;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPorcentaje.Location = new System.Drawing.Point(24, 138);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(175, 18);
            this.lblPorcentaje.TabIndex = 62;
            this.lblPorcentaje.Text = "Porcentaje (opcional):";
            // 
            // nudPorcentaje
            // 
            this.nudPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.nudPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPorcentaje.Enabled = false;
            this.nudPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPorcentaje.ForeColor = System.Drawing.Color.DarkGray;
            this.nudPorcentaje.Location = new System.Drawing.Point(203, 139);
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
            this.nudPorcentaje.TabIndex = 63;
            this.nudPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpMensajesDeAyuda.SetToolTip(this.nudPorcentaje, "Porcentaje de aumento/descuento que se le aplicara sobre el total del pedido");
            this.nudPorcentaje.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudPorcentaje.ValueChanged += new System.EventHandler(this.NudPorcentaje_ValueChanged);
            // 
            // lblTotalDescuento
            // 
            this.lblTotalDescuento.AutoSize = true;
            this.lblTotalDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDescuento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalDescuento.Location = new System.Drawing.Point(5, 181);
            this.lblTotalDescuento.Name = "lblTotalDescuento";
            this.lblTotalDescuento.Size = new System.Drawing.Size(195, 18);
            this.lblTotalDescuento.TabIndex = 55;
            this.lblTotalDescuento.Text = "Total que se descontara:";
            // 
            // lblMostrarTotalDescuento
            // 
            this.lblMostrarTotalDescuento.AutoSize = true;
            this.lblMostrarTotalDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblMostrarTotalDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrarTotalDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarTotalDescuento.ForeColor = System.Drawing.Color.Gray;
            this.lblMostrarTotalDescuento.Location = new System.Drawing.Point(203, 179);
            this.lblMostrarTotalDescuento.Name = "lblMostrarTotalDescuento";
            this.lblMostrarTotalDescuento.Size = new System.Drawing.Size(21, 22);
            this.lblMostrarTotalDescuento.TabIndex = 56;
            this.lblMostrarTotalDescuento.Text = "0";
            this.ttpMensajesDeAyuda.SetToolTip(this.lblMostrarTotalDescuento, "Valor que se descontara del total");
            // 
            // gpbDescuentosAumentos
            // 
            this.gpbDescuentosAumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbDescuentosAumentos.Controls.Add(this.rbnNoRealizarAumentoDescuento);
            this.gpbDescuentosAumentos.Controls.Add(this.rbnAumento);
            this.gpbDescuentosAumentos.Controls.Add(this.rbnDescuento);
            this.gpbDescuentosAumentos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gpbDescuentosAumentos.ForeColor = System.Drawing.Color.Gray;
            this.gpbDescuentosAumentos.Location = new System.Drawing.Point(445, 86);
            this.gpbDescuentosAumentos.Name = "gpbDescuentosAumentos";
            this.gpbDescuentosAumentos.Size = new System.Drawing.Size(326, 113);
            this.gpbDescuentosAumentos.TabIndex = 54;
            this.gpbDescuentosAumentos.TabStop = false;
            this.gpbDescuentosAumentos.Text = "Accion a realizar";
            // 
            // rbnNoRealizarAumentoDescuento
            // 
            this.rbnNoRealizarAumentoDescuento.AutoSize = true;
            this.rbnNoRealizarAumentoDescuento.Checked = true;
            this.rbnNoRealizarAumentoDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnNoRealizarAumentoDescuento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnNoRealizarAumentoDescuento.Location = new System.Drawing.Point(6, 26);
            this.rbnNoRealizarAumentoDescuento.Name = "rbnNoRealizarAumentoDescuento";
            this.rbnNoRealizarAumentoDescuento.Size = new System.Drawing.Size(227, 22);
            this.rbnNoRealizarAumentoDescuento.TabIndex = 34;
            this.rbnNoRealizarAumentoDescuento.TabStop = true;
            this.rbnNoRealizarAumentoDescuento.Text = "No realizar ninguna accion";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnNoRealizarAumentoDescuento, "No realizarle ningun descuento o aumento");
            this.rbnNoRealizarAumentoDescuento.UseVisualStyleBackColor = true;
            this.rbnNoRealizarAumentoDescuento.Click += new System.EventHandler(this.RbnAccionARealizar_Click);
            // 
            // rbnAumento
            // 
            this.rbnAumento.AutoSize = true;
            this.rbnAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnAumento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnAumento.Location = new System.Drawing.Point(6, 80);
            this.rbnAumento.Name = "rbnAumento";
            this.rbnAumento.Size = new System.Drawing.Size(92, 22);
            this.rbnAumento.TabIndex = 33;
            this.rbnAumento.Text = "Aumento";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnAumento, "Realizar un aumento");
            this.rbnAumento.UseVisualStyleBackColor = true;
            this.rbnAumento.Click += new System.EventHandler(this.RbnAccionARealizar_Click);
            // 
            // rbnDescuento
            // 
            this.rbnDescuento.AutoSize = true;
            this.rbnDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnDescuento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnDescuento.Location = new System.Drawing.Point(6, 53);
            this.rbnDescuento.Name = "rbnDescuento";
            this.rbnDescuento.Size = new System.Drawing.Size(107, 22);
            this.rbnDescuento.TabIndex = 32;
            this.rbnDescuento.Text = "Descuento";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnDescuento, "Realizar un descuento");
            this.rbnDescuento.UseVisualStyleBackColor = true;
            this.rbnDescuento.Click += new System.EventHandler(this.RbnAccionARealizar_Click);
            // 
            // btnImprimirResumen
            // 
            this.btnImprimirResumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnImprimirResumen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImprimirResumen.FlatAppearance.BorderSize = 2;
            this.btnImprimirResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirResumen.ForeColor = System.Drawing.Color.White;
            this.btnImprimirResumen.Location = new System.Drawing.Point(445, 205);
            this.btnImprimirResumen.Name = "btnImprimirResumen";
            this.btnImprimirResumen.Size = new System.Drawing.Size(160, 50);
            this.btnImprimirResumen.TabIndex = 53;
            this.btnImprimirResumen.Text = "Imprimir ticket";
            this.btnImprimirResumen.UseVisualStyleBackColor = false;
            this.btnImprimirResumen.Click += new System.EventHandler(this.BtnImprimirTicket_Click);
            this.btnImprimirResumen.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnImprimirResumen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // grbEgresoIngreso
            // 
            this.grbEgresoIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grbEgresoIngreso.Controls.Add(this.rbnEgreso);
            this.grbEgresoIngreso.Controls.Add(this.rbnIngreso);
            this.grbEgresoIngreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grbEgresoIngreso.ForeColor = System.Drawing.Color.Gray;
            this.grbEgresoIngreso.Location = new System.Drawing.Point(445, 2);
            this.grbEgresoIngreso.Name = "grbEgresoIngreso";
            this.grbEgresoIngreso.Size = new System.Drawing.Size(326, 83);
            this.grbEgresoIngreso.TabIndex = 52;
            this.grbEgresoIngreso.TabStop = false;
            this.grbEgresoIngreso.Text = "Tipo de movimiento";
            // 
            // rbnEgreso
            // 
            this.rbnEgreso.AutoSize = true;
            this.rbnEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnEgreso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnEgreso.Location = new System.Drawing.Point(6, 54);
            this.rbnEgreso.Name = "rbnEgreso";
            this.rbnEgreso.Size = new System.Drawing.Size(80, 22);
            this.rbnEgreso.TabIndex = 33;
            this.rbnEgreso.Text = "Egreso";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnEgreso, "Indicar que el pedido fue un egreso");
            this.rbnEgreso.UseVisualStyleBackColor = true;
            this.rbnEgreso.Click += new System.EventHandler(this.RbnTipoMovimiento_Click);
            // 
            // rbnIngreso
            // 
            this.rbnIngreso.AutoSize = true;
            this.rbnIngreso.Checked = true;
            this.rbnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnIngreso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnIngreso.Location = new System.Drawing.Point(6, 26);
            this.rbnIngreso.Name = "rbnIngreso";
            this.rbnIngreso.Size = new System.Drawing.Size(82, 22);
            this.rbnIngreso.TabIndex = 32;
            this.rbnIngreso.TabStop = true;
            this.rbnIngreso.Text = "Ingreso";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnIngreso, "Indicar que el peiddo fue un ingreso");
            this.rbnIngreso.UseVisualStyleBackColor = true;
            this.rbnIngreso.Click += new System.EventHandler(this.RbnTipoMovimiento_Click);
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnRegistrarPago.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarPago.FlatAppearance.BorderSize = 2;
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPago.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPago.Location = new System.Drawing.Point(611, 205);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(160, 50);
            this.btnRegistrarPago.TabIndex = 51;
            this.btnRegistrarPago.Text = "Registrar pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = false;
            this.btnRegistrarPago.Click += new System.EventHandler(this.BtnRegistrarPago_Click);
            this.btnRegistrarPago.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnRegistrarPago.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // txtPago
            // 
            this.txtPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.txtPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPago.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPago.Location = new System.Drawing.Point(202, 53);
            this.txtPago.MaxLength = 7;
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(75, 19);
            this.txtPago.TabIndex = 50;
            this.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpMensajesDeAyuda.SetToolTip(this.txtPago, "Pago del cliente");
            this.txtPago.TextChanged += new System.EventHandler(this.TxtPago_TextChanged);
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPago_KeyPress);
            // 
            // pnlDecorativo1
            // 
            this.pnlDecorativo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo1.Location = new System.Drawing.Point(202, 72);
            this.pnlDecorativo1.Name = "pnlDecorativo1";
            this.pnlDecorativo1.Size = new System.Drawing.Size(75, 2);
            this.pnlDecorativo1.TabIndex = 49;
            // 
            // lblPago
            // 
            this.lblPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPago.Location = new System.Drawing.Point(4, 53);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(194, 18);
            this.lblPago.TabIndex = 48;
            this.lblPago.Text = "Pago (campo de apoyo):";
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVuelto.Location = new System.Drawing.Point(139, 95);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(60, 18);
            this.lblVuelto.TabIndex = 46;
            this.lblVuelto.Text = "Vuelto:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotal.Location = new System.Drawing.Point(147, 11);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 18);
            this.lblTotal.TabIndex = 44;
            this.lblTotal.Text = "Total:";
            // 
            // lblMostratTotal
            // 
            this.lblMostratTotal.AutoSize = true;
            this.lblMostratTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblMostratTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostratTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostratTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblMostratTotal.Location = new System.Drawing.Point(202, 10);
            this.lblMostratTotal.Name = "lblMostratTotal";
            this.lblMostratTotal.Size = new System.Drawing.Size(21, 22);
            this.lblMostratTotal.TabIndex = 45;
            this.lblMostratTotal.Text = "0";
            this.ttpMensajesDeAyuda.SetToolTip(this.lblMostratTotal, "Total del pedido");
            // 
            // lblMostrarVuelto
            // 
            this.lblMostrarVuelto.AutoSize = true;
            this.lblMostrarVuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblMostrarVuelto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrarVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarVuelto.ForeColor = System.Drawing.Color.Gray;
            this.lblMostrarVuelto.Location = new System.Drawing.Point(203, 95);
            this.lblMostrarVuelto.Name = "lblMostrarVuelto";
            this.lblMostrarVuelto.Size = new System.Drawing.Size(21, 22);
            this.lblMostrarVuelto.TabIndex = 47;
            this.lblMostrarVuelto.Text = "0";
            this.ttpMensajesDeAyuda.SetToolTip(this.lblMostrarVuelto, "Diferencia entre el total y el pago");
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
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(798, 30);
            this.pnlBarraDeArrastre.TabIndex = 2;
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
            this.lblTituloFrm.Text = "Resumen de cuenta";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar;
            this.picBTNCerrar.Location = new System.Drawing.Point(757, 0);
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
            // btnCerrarPreCuenta
            // 
            this.btnCerrarPreCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPreCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnCerrarPreCuenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarPreCuenta.FlatAppearance.BorderSize = 2;
            this.btnCerrarPreCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPreCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPreCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCerrarPreCuenta.Location = new System.Drawing.Point(611, 205);
            this.btnCerrarPreCuenta.Name = "btnCerrarPreCuenta";
            this.btnCerrarPreCuenta.Size = new System.Drawing.Size(160, 50);
            this.btnCerrarPreCuenta.TabIndex = 68;
            this.btnCerrarPreCuenta.Text = "Cerrar pre cuenta";
            this.btnCerrarPreCuenta.UseVisualStyleBackColor = false;
            this.btnCerrarPreCuenta.Click += new System.EventHandler(this.BtnCerrarPreCuenta_Click);
            this.btnCerrarPreCuenta.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCerrarPreCuenta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // FrmResumenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.pnlContenedorFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmResumenPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmResumenPedido";
            this.Load += new System.EventHandler(this.FrmResumenPedido_Load);
            this.pnlContenedorFrm.ResumeLayout(false);
            this.pnlContenedorFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosPedido)).EndInit();
            this.pnlContenedorResumen.ResumeLayout(false);
            this.pnlContenedorResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).EndInit();
            this.gpbDescuentosAumentos.ResumeLayout(false);
            this.gpbDescuentosAumentos.PerformLayout();
            this.grbEgresoIngreso.ResumeLayout(false);
            this.grbEgresoIngreso.PerformLayout();
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorFrm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblMostratTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlContenedorResumen;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Label lblMostrarVuelto;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Panel pnlDecorativo1;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.GroupBox grbEgresoIngreso;
        private System.Windows.Forms.RadioButton rbnEgreso;
        private System.Windows.Forms.RadioButton rbnIngreso;
        private System.Windows.Forms.DataGridView dgvArticulosPedido;
        private System.Windows.Forms.Button btnImprimirResumen;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.ComboBox cmbMesas;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Label lblTituloFrm;
        private System.Windows.Forms.Label lblTotalDescuento;
        private System.Windows.Forms.Label lblMostrarTotalDescuento;
        private System.Windows.Forms.GroupBox gpbDescuentosAumentos;
        private System.Windows.Forms.RadioButton rbnNoRealizarAumentoDescuento;
        private System.Windows.Forms.RadioButton rbnAumento;
        private System.Windows.Forms.RadioButton rbnDescuento;
        private System.Windows.Forms.Panel pnlDecorativo6;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.NumericUpDown nudPorcentaje;
        private System.Windows.Forms.Label lblTotalAumento;
        private System.Windows.Forms.Label lblMostrarTotalAumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubtotal;
        private System.Windows.Forms.CheckBox chkRedondearPrecio;
        private System.Drawing.Printing.PrintDocument PtdImprimirTicket;
        private System.Windows.Forms.Button btnCerrarPreCuenta;
    }
}