namespace Procuratio
{
    partial class FrmCaja
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
            this.dgvCaja = new System.Windows.Forms.DataGridView();
            this.ColID_Caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoDeCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistroDeCaja = new System.Windows.Forms.Label();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.pnlContenedorResultados = new System.Windows.Forms.Panel();
            this.lblResultadoDiferencia = new System.Windows.Forms.Label();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.lblResultadoEgresos = new System.Windows.Forms.Label();
            this.lblEgreso = new System.Windows.Forms.Label();
            this.lblResultadoIngresos = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.ckbIncluirFechaDesde = new System.Windows.Forms.CheckBox();
            this.ckbIncluirFechaHasta = new System.Windows.Forms.CheckBox();
            this.lblReservasHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpDechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnVerRegistrosDeHoy = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblBuscarPorTipoDeCuenta = new System.Windows.Forms.Label();
            this.cmbTipoDeMonto = new System.Windows.Forms.ComboBox();
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.mtbHoraComienzo = new System.Windows.Forms.MaskedTextBox();
            this.mtbHoraFin = new System.Windows.Forms.MaskedTextBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.pnlDecorativo8 = new System.Windows.Forms.Panel();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.pnlDecorativo2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).BeginInit();
            this.pnlContenedorResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCaja
            // 
            this.dgvCaja.AllowUserToAddRows = false;
            this.dgvCaja.AllowUserToDeleteRows = false;
            this.dgvCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCaja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCaja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvCaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCaja.ColumnHeadersHeight = 45;
            this.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID_Caja,
            this.colID_Pedido,
            this.colFecha,
            this.colHora,
            this.ColTipoDeCuenta,
            this.colIngreso,
            this.colEgreso,
            this.colDetalle,
            this.ColNombreUsuario});
            this.dgvCaja.EnableHeadersVisualStyles = false;
            this.dgvCaja.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCaja.Location = new System.Drawing.Point(7, 102);
            this.dgvCaja.Name = "dgvCaja";
            this.dgvCaja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaja.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCaja.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvCaja.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCaja.Size = new System.Drawing.Size(747, 412);
            this.dgvCaja.TabIndex = 4;
            this.dgvCaja.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDatosReservas_CellMouseDoubleClick);
            // 
            // ColID_Caja
            // 
            this.ColID_Caja.Frozen = true;
            this.ColID_Caja.HeaderText = "ID_Caja";
            this.ColID_Caja.Name = "ColID_Caja";
            this.ColID_Caja.ReadOnly = true;
            this.ColID_Caja.Visible = false;
            this.ColID_Caja.Width = 83;
            // 
            // colID_Pedido
            // 
            this.colID_Pedido.HeaderText = "ID_Pedido";
            this.colID_Pedido.Name = "colID_Pedido";
            this.colID_Pedido.ReadOnly = true;
            this.colID_Pedido.Visible = false;
            this.colID_Pedido.Width = 99;
            // 
            // colFecha
            // 
            this.colFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFecha.FillWeight = 70F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 90;
            // 
            // colHora
            // 
            this.colHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHora.FillWeight = 30F;
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            this.colHora.Width = 60;
            // 
            // ColTipoDeCuenta
            // 
            this.ColTipoDeCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTipoDeCuenta.HeaderText = "Tipo de cuenta";
            this.ColTipoDeCuenta.Name = "ColTipoDeCuenta";
            this.ColTipoDeCuenta.ReadOnly = true;
            // 
            // colIngreso
            // 
            this.colIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIngreso.FillWeight = 50F;
            this.colIngreso.HeaderText = "Ingresos";
            this.colIngreso.Name = "colIngreso";
            this.colIngreso.ReadOnly = true;
            this.colIngreso.Width = 70;
            // 
            // colEgreso
            // 
            this.colEgreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEgreso.FillWeight = 50F;
            this.colEgreso.HeaderText = "Egresos";
            this.colEgreso.Name = "colEgreso";
            this.colEgreso.ReadOnly = true;
            this.colEgreso.Width = 70;
            // 
            // colDetalle
            // 
            this.colDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDetalle.HeaderText = "Detalle";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.ReadOnly = true;
            // 
            // ColNombreUsuario
            // 
            this.ColNombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColNombreUsuario.FillWeight = 70F;
            this.ColNombreUsuario.HeaderText = "Registro generado por";
            this.ColNombreUsuario.Name = "ColNombreUsuario";
            this.ColNombreUsuario.ReadOnly = true;
            this.ColNombreUsuario.Width = 150;
            // 
            // lblRegistroDeCaja
            // 
            this.lblRegistroDeCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblRegistroDeCaja.AutoSize = true;
            this.lblRegistroDeCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblRegistroDeCaja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroDeCaja.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistroDeCaja.Location = new System.Drawing.Point(336, 10);
            this.lblRegistroDeCaja.Name = "lblRegistroDeCaja";
            this.lblRegistroDeCaja.Size = new System.Drawing.Size(223, 19);
            this.lblRegistroDeCaja.TabIndex = 29;
            this.lblRegistroDeCaja.Text = "REGISTROS DE MOVIMIENTOS";
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarRegistro.FlatAppearance.BorderSize = 2;
            this.btnAgregarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(766, 214);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(160, 50);
            this.btnAgregarRegistro.TabIndex = 30;
            this.btnAgregarRegistro.Text = "Agregar nuevo registro";
            this.btnAgregarRegistro.UseVisualStyleBackColor = false;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.BtnAgregarRegistro_Click);
            this.btnAgregarRegistro.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnAgregarRegistro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // pnlContenedorResultados
            // 
            this.pnlContenedorResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pnlContenedorResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorResultados.Controls.Add(this.lblResultadoDiferencia);
            this.pnlContenedorResultados.Controls.Add(this.lblDiferencia);
            this.pnlContenedorResultados.Controls.Add(this.lblResultadoEgresos);
            this.pnlContenedorResultados.Controls.Add(this.lblEgreso);
            this.pnlContenedorResultados.Controls.Add(this.lblResultadoIngresos);
            this.pnlContenedorResultados.Controls.Add(this.lblIngreso);
            this.pnlContenedorResultados.Location = new System.Drawing.Point(7, 520);
            this.pnlContenedorResultados.Name = "pnlContenedorResultados";
            this.pnlContenedorResultados.Size = new System.Drawing.Size(747, 40);
            this.pnlContenedorResultados.TabIndex = 31;
            // 
            // lblResultadoDiferencia
            // 
            this.lblResultadoDiferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultadoDiferencia.AutoSize = true;
            this.lblResultadoDiferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblResultadoDiferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDiferencia.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoDiferencia.Location = new System.Drawing.Point(597, 7);
            this.lblResultadoDiferencia.Name = "lblResultadoDiferencia";
            this.lblResultadoDiferencia.Size = new System.Drawing.Size(21, 22);
            this.lblResultadoDiferencia.TabIndex = 53;
            this.lblResultadoDiferencia.Text = "0";
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferencia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDiferencia.Location = new System.Drawing.Point(502, 9);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(89, 18);
            this.lblDiferencia.TabIndex = 52;
            this.lblDiferencia.Text = "Diferencia:";
            // 
            // lblResultadoEgresos
            // 
            this.lblResultadoEgresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultadoEgresos.AutoSize = true;
            this.lblResultadoEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblResultadoEgresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoEgresos.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoEgresos.Location = new System.Drawing.Point(321, 7);
            this.lblResultadoEgresos.Name = "lblResultadoEgresos";
            this.lblResultadoEgresos.Size = new System.Drawing.Size(21, 22);
            this.lblResultadoEgresos.TabIndex = 51;
            this.lblResultadoEgresos.Text = "0";
            // 
            // lblEgreso
            // 
            this.lblEgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEgreso.AutoSize = true;
            this.lblEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgreso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEgreso.Location = new System.Drawing.Point(239, 9);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(76, 18);
            this.lblEgreso.TabIndex = 50;
            this.lblEgreso.Text = "Egresos:";
            // 
            // lblResultadoIngresos
            // 
            this.lblResultadoIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultadoIngresos.AutoSize = true;
            this.lblResultadoIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblResultadoIngresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoIngresos.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoIngresos.Location = new System.Drawing.Point(86, 7);
            this.lblResultadoIngresos.Name = "lblResultadoIngresos";
            this.lblResultadoIngresos.Size = new System.Drawing.Size(21, 22);
            this.lblResultadoIngresos.TabIndex = 49;
            this.lblResultadoIngresos.Text = "0";
            // 
            // lblIngreso
            // 
            this.lblIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIngreso.Location = new System.Drawing.Point(4, 9);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(78, 18);
            this.lblIngreso.TabIndex = 48;
            this.lblIngreso.Text = "Ingresos:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreUsuario.Location = new System.Drawing.Point(27, 74);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(72, 18);
            this.lblNombreUsuario.TabIndex = 59;
            this.lblNombreUsuario.Text = "Usuario:";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.cmbUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbUsuarios.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(104, 71);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(169, 26);
            this.cmbUsuarios.TabIndex = 58;
            this.cmbUsuarios.Text = "Nombre usuario";
            // 
            // ckbIncluirFechaDesde
            // 
            this.ckbIncluirFechaDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbIncluirFechaDesde.AutoSize = true;
            this.ckbIncluirFechaDesde.Checked = true;
            this.ckbIncluirFechaDesde.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIncluirFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckbIncluirFechaDesde.ForeColor = System.Drawing.Color.White;
            this.ckbIncluirFechaDesde.Location = new System.Drawing.Point(691, 40);
            this.ckbIncluirFechaDesde.Name = "ckbIncluirFechaDesde";
            this.ckbIncluirFechaDesde.Size = new System.Drawing.Size(72, 22);
            this.ckbIncluirFechaDesde.TabIndex = 69;
            this.ckbIncluirFechaDesde.Text = "Incluir";
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
            this.ckbIncluirFechaHasta.Location = new System.Drawing.Point(691, 73);
            this.ckbIncluirFechaHasta.Name = "ckbIncluirFechaHasta";
            this.ckbIncluirFechaHasta.Size = new System.Drawing.Size(72, 22);
            this.ckbIncluirFechaHasta.TabIndex = 68;
            this.ckbIncluirFechaHasta.Text = "Incluir";
            this.ckbIncluirFechaHasta.UseVisualStyleBackColor = true;
            this.ckbIncluirFechaHasta.CheckedChanged += new System.EventHandler(this.CkbIncluirFechaHasta_CheckedChanged);
            // 
            // lblReservasHasta
            // 
            this.lblReservasHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReservasHasta.AutoSize = true;
            this.lblReservasHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservasHasta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblReservasHasta.Location = new System.Drawing.Point(281, 75);
            this.lblReservasHasta.Name = "lblReservasHasta";
            this.lblReservasHasta.Size = new System.Drawing.Size(57, 18);
            this.lblReservasHasta.TabIndex = 67;
            this.lblReservasHasta.Text = "Hasta:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaDesde.Location = new System.Drawing.Point(277, 40);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(61, 18);
            this.lblFechaDesde.TabIndex = 66;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // dtpDechaHasta
            // 
            this.dtpDechaHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDechaHasta.Location = new System.Drawing.Point(340, 74);
            this.dtpDechaHasta.Name = "dtpDechaHasta";
            this.dtpDechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpDechaHasta.TabIndex = 64;
            this.dtpDechaHasta.ValueChanged += new System.EventHandler(this.DtpDechaHasta_ValueChanged);
            this.dtpDechaHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpDechaHasta_KeyPress);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaDesde.Location = new System.Drawing.Point(340, 40);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 63;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.DtpFechaDesde_ValueChanged);
            this.dtpFechaDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpFechaDesde_KeyPress);
            // 
            // btnVerRegistrosDeHoy
            // 
            this.btnVerRegistrosDeHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerRegistrosDeHoy.BackColor = System.Drawing.Color.Transparent;
            this.btnVerRegistrosDeHoy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerRegistrosDeHoy.FlatAppearance.BorderSize = 2;
            this.btnVerRegistrosDeHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerRegistrosDeHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerRegistrosDeHoy.ForeColor = System.Drawing.Color.White;
            this.btnVerRegistrosDeHoy.Location = new System.Drawing.Point(766, 158);
            this.btnVerRegistrosDeHoy.Name = "btnVerRegistrosDeHoy";
            this.btnVerRegistrosDeHoy.Size = new System.Drawing.Size(160, 50);
            this.btnVerRegistrosDeHoy.TabIndex = 70;
            this.btnVerRegistrosDeHoy.Text = "Ver los registros de hoy";
            this.btnVerRegistrosDeHoy.UseVisualStyleBackColor = false;
            this.btnVerRegistrosDeHoy.Click += new System.EventHandler(this.BtnVerRegistrosDeHoy_Click);
            this.btnVerRegistrosDeHoy.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnVerRegistrosDeHoy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
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
            this.btnImprimir.Location = new System.Drawing.Point(766, 270);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(160, 50);
            this.btnImprimir.TabIndex = 73;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnImprimir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblBuscarPorTipoDeCuenta
            // 
            this.lblBuscarPorTipoDeCuenta.AutoSize = true;
            this.lblBuscarPorTipoDeCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorTipoDeCuenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBuscarPorTipoDeCuenta.Location = new System.Drawing.Point(0, 40);
            this.lblBuscarPorTipoDeCuenta.Name = "lblBuscarPorTipoDeCuenta";
            this.lblBuscarPorTipoDeCuenta.Size = new System.Drawing.Size(100, 18);
            this.lblBuscarPorTipoDeCuenta.TabIndex = 75;
            this.lblBuscarPorTipoDeCuenta.Text = "Movimiento:";
            // 
            // cmbTipoDeMonto
            // 
            this.cmbTipoDeMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoDeMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.cmbTipoDeMonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoDeMonto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbTipoDeMonto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTipoDeMonto.FormattingEnabled = true;
            this.cmbTipoDeMonto.Location = new System.Drawing.Point(104, 39);
            this.cmbTipoDeMonto.Name = "cmbTipoDeMonto";
            this.cmbTipoDeMonto.Size = new System.Drawing.Size(169, 26);
            this.cmbTipoDeMonto.TabIndex = 74;
            this.cmbTipoDeMonto.Text = "Nombre de la cuenta";
            // 
            // mtbHoraComienzo
            // 
            this.mtbHoraComienzo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbHoraComienzo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.mtbHoraComienzo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbHoraComienzo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.mtbHoraComienzo.ForeColor = System.Drawing.Color.DarkGray;
            this.mtbHoraComienzo.Location = new System.Drawing.Point(642, 41);
            this.mtbHoraComienzo.Mask = "00:00";
            this.mtbHoraComienzo.Name = "mtbHoraComienzo";
            this.mtbHoraComienzo.Size = new System.Drawing.Size(44, 19);
            this.mtbHoraComienzo.TabIndex = 78;
            this.mtbHoraComienzo.Text = "0000";
            this.mtbHoraComienzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpMensajesDeAyuda.SetToolTip(this.mtbHoraComienzo, "Hora del dia de la fecha desde en la que se comenzara a mostrar");
            this.mtbHoraComienzo.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHoraFin
            // 
            this.mtbHoraFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbHoraFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.mtbHoraFin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbHoraFin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.mtbHoraFin.ForeColor = System.Drawing.Color.DarkGray;
            this.mtbHoraFin.Location = new System.Drawing.Point(642, 73);
            this.mtbHoraFin.Mask = "00:00";
            this.mtbHoraFin.Name = "mtbHoraFin";
            this.mtbHoraFin.Size = new System.Drawing.Size(44, 19);
            this.mtbHoraFin.TabIndex = 81;
            this.mtbHoraFin.Text = "2359";
            this.mtbHoraFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpMensajesDeAyuda.SetToolTip(this.mtbHoraFin, "Hora del dia de la feastacha desde en la que se finalizara el mostrar");
            this.mtbHoraFin.ValidatingType = typeof(System.DateTime);
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
            this.btnAplicarFiltro.Location = new System.Drawing.Point(766, 102);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(160, 50);
            this.btnAplicarFiltro.TabIndex = 76;
            this.btnAplicarFiltro.Text = "Aplicar filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = false;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.BtnAplicarFiltro_Click);
            this.btnAplicarFiltro.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnAplicarFiltro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHoraInicio.Location = new System.Drawing.Point(544, 42);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(95, 18);
            this.lblHoraInicio.TabIndex = 79;
            this.lblHoraInicio.Text = "Hora inicio:";
            // 
            // pnlDecorativo8
            // 
            this.pnlDecorativo8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDecorativo8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo8.Location = new System.Drawing.Point(642, 60);
            this.pnlDecorativo8.Name = "pnlDecorativo8";
            this.pnlDecorativo8.Size = new System.Drawing.Size(44, 2);
            this.pnlDecorativo8.TabIndex = 77;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHoraFin.Location = new System.Drawing.Point(566, 74);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(73, 18);
            this.lblHoraFin.TabIndex = 82;
            this.lblHoraFin.Text = "Hora fin:";
            // 
            // pnlDecorativo2
            // 
            this.pnlDecorativo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDecorativo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo2.Location = new System.Drawing.Point(642, 92);
            this.pnlDecorativo2.Name = "pnlDecorativo2";
            this.pnlDecorativo2.Size = new System.Drawing.Size(44, 2);
            this.pnlDecorativo2.TabIndex = 80;
            // 
            // FrmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(935, 565);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.pnlDecorativo2);
            this.Controls.Add(this.mtbHoraFin);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.pnlDecorativo8);
            this.Controls.Add(this.mtbHoraComienzo);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.lblBuscarPorTipoDeCuenta);
            this.Controls.Add(this.cmbTipoDeMonto);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnVerRegistrosDeHoy);
            this.Controls.Add(this.ckbIncluirFechaDesde);
            this.Controls.Add(this.ckbIncluirFechaHasta);
            this.Controls.Add(this.lblReservasHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpDechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.pnlContenedorResultados);
            this.Controls.Add(this.btnAgregarRegistro);
            this.Controls.Add(this.lblRegistroDeCaja);
            this.Controls.Add(this.dgvCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCaja";
            this.Text = "FrmCaja";
            this.Load += new System.EventHandler(this.FrmCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).EndInit();
            this.pnlContenedorResultados.ResumeLayout(false);
            this.pnlContenedorResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaja;
        private System.Windows.Forms.Label lblRegistroDeCaja;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Panel pnlContenedorResultados;
        private System.Windows.Forms.Label lblResultadoEgresos;
        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.Label lblResultadoIngresos;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblResultadoDiferencia;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.CheckBox ckbIncluirFechaDesde;
        private System.Windows.Forms.CheckBox ckbIncluirFechaHasta;
        private System.Windows.Forms.Label lblReservasHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpDechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnVerRegistrosDeHoy;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblBuscarPorTipoDeCuenta;
        private System.Windows.Forms.ComboBox cmbTipoDeMonto;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Panel pnlDecorativo8;
        private System.Windows.Forms.MaskedTextBox mtbHoraComienzo;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Panel pnlDecorativo2;
        private System.Windows.Forms.MaskedTextBox mtbHoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID_Caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoDeCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreUsuario;
    }
}