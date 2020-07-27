namespace Procuratio.FrmsSecundarios.FrmEstadisticas
{
    partial class FrmEstadisticasCaja
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblEstadisticasCaja = new System.Windows.Forms.Label();
            this.pnlConteContControles = new System.Windows.Forms.Panel();
            this.pnlDecorativo7 = new System.Windows.Forms.Panel();
            this.lblGananciasPerdidasPorMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.nudAñoGananciasPerdidas = new System.Windows.Forms.NumericUpDown();
            this.pnlDecorativo1 = new System.Windows.Forms.Panel();
            this.ChtGananciasPorMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PicGananciasPerdidasMes = new System.Windows.Forms.PictureBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.ckbIncluirFechaHasta = new System.Windows.Forms.CheckBox();
            this.ckbIncluirFechaDesde = new System.Windows.Forms.CheckBox();
            this.dtpDechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblReservasHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.btnAplicarValoresPorDefecto = new System.Windows.Forms.Button();
            this.pnlConteContControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñoGananciasPerdidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChtGananciasPorMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGananciasPerdidasMes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstadisticasCaja
            // 
            this.lblEstadisticasCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEstadisticasCaja.AutoSize = true;
            this.lblEstadisticasCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblEstadisticasCaja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadisticasCaja.ForeColor = System.Drawing.Color.Gray;
            this.lblEstadisticasCaja.Location = new System.Drawing.Point(346, 4);
            this.lblEstadisticasCaja.Name = "lblEstadisticasCaja";
            this.lblEstadisticasCaja.Size = new System.Drawing.Size(158, 19);
            this.lblEstadisticasCaja.TabIndex = 32;
            this.lblEstadisticasCaja.Text = "ESTADISTICAS CAJA";
            // 
            // pnlConteContControles
            // 
            this.pnlConteContControles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConteContControles.AutoScroll = true;
            this.pnlConteContControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pnlConteContControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConteContControles.Controls.Add(this.pnlDecorativo7);
            this.pnlConteContControles.Controls.Add(this.lblGananciasPerdidasPorMes);
            this.pnlConteContControles.Controls.Add(this.lblAño);
            this.pnlConteContControles.Controls.Add(this.nudAñoGananciasPerdidas);
            this.pnlConteContControles.Controls.Add(this.pnlDecorativo1);
            this.pnlConteContControles.Controls.Add(this.ChtGananciasPorMes);
            this.pnlConteContControles.Controls.Add(this.PicGananciasPerdidasMes);
            this.pnlConteContControles.Location = new System.Drawing.Point(10, 59);
            this.pnlConteContControles.Name = "pnlConteContControles";
            this.pnlConteContControles.Size = new System.Drawing.Size(747, 496);
            this.pnlConteContControles.TabIndex = 34;
            // 
            // pnlDecorativo7
            // 
            this.pnlDecorativo7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDecorativo7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo7.Location = new System.Drawing.Point(0, 209);
            this.pnlDecorativo7.Name = "pnlDecorativo7";
            this.pnlDecorativo7.Size = new System.Drawing.Size(745, 1);
            this.pnlDecorativo7.TabIndex = 100;
            // 
            // lblGananciasPerdidasPorMes
            // 
            this.lblGananciasPerdidasPorMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblGananciasPerdidasPorMes.AutoSize = true;
            this.lblGananciasPerdidasPorMes.BackColor = System.Drawing.Color.Transparent;
            this.lblGananciasPerdidasPorMes.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGananciasPerdidasPorMes.ForeColor = System.Drawing.Color.Gray;
            this.lblGananciasPerdidasPorMes.Location = new System.Drawing.Point(243, 6);
            this.lblGananciasPerdidasPorMes.Name = "lblGananciasPerdidasPorMes";
            this.lblGananciasPerdidasPorMes.Size = new System.Drawing.Size(289, 19);
            this.lblGananciasPerdidasPorMes.TabIndex = 99;
            this.lblGananciasPerdidasPorMes.Text = "GANANCIAS Y PERDIDAS (AÑO ????)";
            // 
            // lblAño
            // 
            this.lblAño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAño.Location = new System.Drawing.Point(584, 161);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(42, 18);
            this.lblAño.TabIndex = 98;
            this.lblAño.Text = "Año:";
            // 
            // nudAñoGananciasPerdidas
            // 
            this.nudAñoGananciasPerdidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAñoGananciasPerdidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.nudAñoGananciasPerdidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudAñoGananciasPerdidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAñoGananciasPerdidas.ForeColor = System.Drawing.Color.DarkGray;
            this.nudAñoGananciasPerdidas.Location = new System.Drawing.Point(633, 159);
            this.nudAñoGananciasPerdidas.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudAñoGananciasPerdidas.Minimum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.nudAñoGananciasPerdidas.Name = "nudAñoGananciasPerdidas";
            this.nudAñoGananciasPerdidas.ReadOnly = true;
            this.nudAñoGananciasPerdidas.Size = new System.Drawing.Size(80, 20);
            this.nudAñoGananciasPerdidas.TabIndex = 95;
            this.nudAñoGananciasPerdidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAñoGananciasPerdidas.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            // 
            // pnlDecorativo1
            // 
            this.pnlDecorativo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDecorativo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo1.Location = new System.Drawing.Point(634, 179);
            this.pnlDecorativo1.Name = "pnlDecorativo1";
            this.pnlDecorativo1.Size = new System.Drawing.Size(80, 2);
            this.pnlDecorativo1.TabIndex = 96;
            // 
            // ChtGananciasPorMes
            // 
            this.ChtGananciasPorMes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChtGananciasPorMes.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.Maximum = 13D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Gray;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.Silver;
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.White;
            this.ChtGananciasPorMes.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            legend2.TitleForeColor = System.Drawing.Color.White;
            this.ChtGananciasPorMes.Legends.Add(legend2);
            this.ChtGananciasPorMes.Location = new System.Drawing.Point(5, 31);
            this.ChtGananciasPorMes.Name = "ChtGananciasPorMes";
            this.ChtGananciasPorMes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.BackSecondaryColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.Gold;
            series2.Legend = "Legend1";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Ganancias";
            series2.YValuesPerPoint = 4;
            this.ChtGananciasPorMes.Series.Add(series2);
            this.ChtGananciasPorMes.Size = new System.Drawing.Size(714, 180);
            this.ChtGananciasPorMes.TabIndex = 94;
            this.ChtGananciasPorMes.Text = "chart2";
            // 
            // PicGananciasPerdidasMes
            // 
            this.PicGananciasPerdidasMes.Image = global::Procuratio.Properties.Resources.No_se_encontraron_datos;
            this.PicGananciasPerdidasMes.Location = new System.Drawing.Point(298, 31);
            this.PicGananciasPerdidasMes.Name = "PicGananciasPerdidasMes";
            this.PicGananciasPerdidasMes.Size = new System.Drawing.Size(200, 170);
            this.PicGananciasPerdidasMes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicGananciasPerdidasMes.TabIndex = 91;
            this.PicGananciasPerdidasMes.TabStop = false;
            this.PicGananciasPerdidasMes.Visible = false;
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
            this.btnAplicarFiltro.Location = new System.Drawing.Point(767, 59);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(160, 50);
            this.btnAplicarFiltro.TabIndex = 57;
            this.btnAplicarFiltro.Text = "Aplicar filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = false;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.BtnAplicarFiltro_Click);
            this.btnAplicarFiltro.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnAplicarFiltro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // ckbIncluirFechaHasta
            // 
            this.ckbIncluirFechaHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ckbIncluirFechaHasta.AutoSize = true;
            this.ckbIncluirFechaHasta.Checked = true;
            this.ckbIncluirFechaHasta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIncluirFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckbIncluirFechaHasta.ForeColor = System.Drawing.Color.White;
            this.ckbIncluirFechaHasta.Location = new System.Drawing.Point(685, 34);
            this.ckbIncluirFechaHasta.Name = "ckbIncluirFechaHasta";
            this.ckbIncluirFechaHasta.Size = new System.Drawing.Size(72, 22);
            this.ckbIncluirFechaHasta.TabIndex = 67;
            this.ckbIncluirFechaHasta.Text = "Incluir";
            this.ckbIncluirFechaHasta.UseVisualStyleBackColor = true;
            this.ckbIncluirFechaHasta.Visible = false;
            this.ckbIncluirFechaHasta.CheckedChanged += new System.EventHandler(this.CkbIncluirFechaHasta_CheckedChanged);
            // 
            // ckbIncluirFechaDesde
            // 
            this.ckbIncluirFechaDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ckbIncluirFechaDesde.AutoSize = true;
            this.ckbIncluirFechaDesde.Checked = true;
            this.ckbIncluirFechaDesde.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIncluirFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckbIncluirFechaDesde.ForeColor = System.Drawing.Color.White;
            this.ckbIncluirFechaDesde.Location = new System.Drawing.Point(309, 34);
            this.ckbIncluirFechaDesde.Name = "ckbIncluirFechaDesde";
            this.ckbIncluirFechaDesde.Size = new System.Drawing.Size(72, 22);
            this.ckbIncluirFechaDesde.TabIndex = 68;
            this.ckbIncluirFechaDesde.Text = "Incluir";
            this.ckbIncluirFechaDesde.UseVisualStyleBackColor = true;
            this.ckbIncluirFechaDesde.Visible = false;
            this.ckbIncluirFechaDesde.CheckedChanged += new System.EventHandler(this.CkbIncluirFechaDesde_CheckedChanged);
            // 
            // dtpDechaHasta
            // 
            this.dtpDechaHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpDechaHasta.Location = new System.Drawing.Point(450, 34);
            this.dtpDechaHasta.Name = "dtpDechaHasta";
            this.dtpDechaHasta.Size = new System.Drawing.Size(231, 20);
            this.dtpDechaHasta.TabIndex = 64;
            this.dtpDechaHasta.Visible = false;
            this.dtpDechaHasta.ValueChanged += new System.EventHandler(this.DtpDechaHasta_ValueChanged);
            // 
            // lblReservasHasta
            // 
            this.lblReservasHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblReservasHasta.AutoSize = true;
            this.lblReservasHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservasHasta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblReservasHasta.Location = new System.Drawing.Point(387, 35);
            this.lblReservasHasta.Name = "lblReservasHasta";
            this.lblReservasHasta.Size = new System.Drawing.Size(57, 18);
            this.lblReservasHasta.TabIndex = 66;
            this.lblReservasHasta.Text = "Hasta:";
            this.lblReservasHasta.Visible = false;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpFechaDesde.Location = new System.Drawing.Point(74, 34);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(231, 20);
            this.dtpFechaDesde.TabIndex = 63;
            this.dtpFechaDesde.Visible = false;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.DtpFechaDesde_ValueChanged);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaDesde.Location = new System.Drawing.Point(7, 34);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(61, 18);
            this.lblFechaDesde.TabIndex = 65;
            this.lblFechaDesde.Text = "Desde:";
            this.lblFechaDesde.Visible = false;
            // 
            // btnAplicarValoresPorDefecto
            // 
            this.btnAplicarValoresPorDefecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicarValoresPorDefecto.BackColor = System.Drawing.Color.Transparent;
            this.btnAplicarValoresPorDefecto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAplicarValoresPorDefecto.FlatAppearance.BorderSize = 2;
            this.btnAplicarValoresPorDefecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarValoresPorDefecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarValoresPorDefecto.ForeColor = System.Drawing.Color.White;
            this.btnAplicarValoresPorDefecto.Location = new System.Drawing.Point(767, 115);
            this.btnAplicarValoresPorDefecto.Name = "btnAplicarValoresPorDefecto";
            this.btnAplicarValoresPorDefecto.Size = new System.Drawing.Size(160, 50);
            this.btnAplicarValoresPorDefecto.TabIndex = 72;
            this.btnAplicarValoresPorDefecto.Text = "Aplicar valores por defecto";
            this.btnAplicarValoresPorDefecto.UseVisualStyleBackColor = false;
            this.btnAplicarValoresPorDefecto.Click += new System.EventHandler(this.BtnAplicarValoresPorDefecto_Click);
            this.btnAplicarValoresPorDefecto.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnAplicarValoresPorDefecto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // FrmEstadisticasCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(935, 565);
            this.Controls.Add(this.btnAplicarValoresPorDefecto);
            this.Controls.Add(this.ckbIncluirFechaHasta);
            this.Controls.Add(this.ckbIncluirFechaDesde);
            this.Controls.Add(this.dtpDechaHasta);
            this.Controls.Add(this.lblReservasHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.pnlConteContControles);
            this.Controls.Add(this.lblEstadisticasCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadisticasCaja";
            this.Text = "FrmEstadisticasMesa";
            this.Load += new System.EventHandler(this.FrmEstadisticasMesa_Load);
            this.pnlConteContControles.ResumeLayout(false);
            this.pnlConteContControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñoGananciasPerdidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChtGananciasPorMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGananciasPerdidasMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstadisticasCaja;
        private System.Windows.Forms.Panel pnlConteContControles;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.CheckBox ckbIncluirFechaHasta;
        private System.Windows.Forms.CheckBox ckbIncluirFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpDechaHasta;
        private System.Windows.Forms.Label lblReservasHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Panel pnlDecorativo7;
        private System.Windows.Forms.Label lblGananciasPerdidasPorMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.NumericUpDown nudAñoGananciasPerdidas;
        private System.Windows.Forms.Panel pnlDecorativo1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChtGananciasPorMes;
        private System.Windows.Forms.PictureBox PicGananciasPerdidasMes;
        private System.Windows.Forms.Button btnAplicarValoresPorDefecto;
    }
}