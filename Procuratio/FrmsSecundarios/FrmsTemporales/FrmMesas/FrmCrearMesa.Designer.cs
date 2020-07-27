namespace Procuratio
{
    partial class FrmCrearMesa
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
            this.tmrColor = new System.Windows.Forms.Timer(this.components);
            this.pnlContenedorFrm = new System.Windows.Forms.Panel();
            this.btnCargarClientes = new System.Windows.Forms.Button();
            this.cmbNombreChef = new System.Windows.Forms.ComboBox();
            this.lblResultadoCapacidadTotal = new System.Windows.Forms.Label();
            this.lblCapacidadTotal = new System.Windows.Forms.Label();
            this.cmbNombreMozo = new System.Windows.Forms.ComboBox();
            this.dgvCrearMesa = new System.Windows.Forms.DataGridView();
            this.colID_NumeroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccionDeFilas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grbPlantas = new System.Windows.Forms.GroupBox();
            this.rbnPlantaAlta = new System.Windows.Forms.RadioButton();
            this.rbnPlantaBaja = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picBTNInformacion = new System.Windows.Forms.PictureBox();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.pnlContenedorFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearMesa)).BeginInit();
            this.grbPlantas.SuspendLayout();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrColor
            // 
            this.tmrColor.Enabled = true;
            this.tmrColor.Tick += new System.EventHandler(this.tmrColor_Tick);
            // 
            // pnlContenedorFrm
            // 
            this.pnlContenedorFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorFrm.Controls.Add(this.btnCargarClientes);
            this.pnlContenedorFrm.Controls.Add(this.cmbNombreChef);
            this.pnlContenedorFrm.Controls.Add(this.lblResultadoCapacidadTotal);
            this.pnlContenedorFrm.Controls.Add(this.lblCapacidadTotal);
            this.pnlContenedorFrm.Controls.Add(this.cmbNombreMozo);
            this.pnlContenedorFrm.Controls.Add(this.dgvCrearMesa);
            this.pnlContenedorFrm.Controls.Add(this.grbPlantas);
            this.pnlContenedorFrm.Controls.Add(this.btnAceptar);
            this.pnlContenedorFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContenedorFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorFrm.Name = "pnlContenedorFrm";
            this.pnlContenedorFrm.Size = new System.Drawing.Size(500, 568);
            this.pnlContenedorFrm.TabIndex = 0;
            // 
            // btnCargarClientes
            // 
            this.btnCargarClientes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCargarClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCargarClientes.FlatAppearance.BorderSize = 2;
            this.btnCargarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarClientes.ForeColor = System.Drawing.Color.White;
            this.btnCargarClientes.Location = new System.Drawing.Point(320, 453);
            this.btnCargarClientes.Name = "btnCargarClientes";
            this.btnCargarClientes.Size = new System.Drawing.Size(160, 50);
            this.btnCargarClientes.TabIndex = 59;
            this.btnCargarClientes.Text = "Cargar clientes del pedido (opcional)";
            this.btnCargarClientes.UseVisualStyleBackColor = false;
            this.btnCargarClientes.Click += new System.EventHandler(this.BtnCargarClientes_Click);
            this.btnCargarClientes.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCargarClientes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // cmbNombreChef
            // 
            this.cmbNombreChef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNombreChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.cmbNombreChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNombreChef.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbNombreChef.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbNombreChef.FormattingEnabled = true;
            this.cmbNombreChef.Location = new System.Drawing.Point(320, 420);
            this.cmbNombreChef.Name = "cmbNombreChef";
            this.cmbNombreChef.Size = new System.Drawing.Size(160, 26);
            this.cmbNombreChef.TabIndex = 58;
            this.cmbNombreChef.Text = "Nombre del chef";
            this.ttpMensajesDeAyuda.SetToolTip(this.cmbNombreChef, "Asginar el chef que se hara cargo de la/s mesa/s");
            // 
            // lblResultadoCapacidadTotal
            // 
            this.lblResultadoCapacidadTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultadoCapacidadTotal.AutoSize = true;
            this.lblResultadoCapacidadTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblResultadoCapacidadTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoCapacidadTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCapacidadTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoCapacidadTotal.Location = new System.Drawing.Point(448, 268);
            this.lblResultadoCapacidadTotal.Name = "lblResultadoCapacidadTotal";
            this.lblResultadoCapacidadTotal.Size = new System.Drawing.Size(21, 22);
            this.lblResultadoCapacidadTotal.TabIndex = 57;
            this.lblResultadoCapacidadTotal.Text = "0";
            this.ttpMensajesDeAyuda.SetToolTip(this.lblResultadoCapacidadTotal, "Capacidad total que es calculada en base a las mesas seleccionadas");
            // 
            // lblCapacidadTotal
            // 
            this.lblCapacidadTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCapacidadTotal.AutoSize = true;
            this.lblCapacidadTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCapacidadTotal.Location = new System.Drawing.Point(320, 269);
            this.lblCapacidadTotal.Name = "lblCapacidadTotal";
            this.lblCapacidadTotal.Size = new System.Drawing.Size(130, 18);
            this.lblCapacidadTotal.TabIndex = 56;
            this.lblCapacidadTotal.Text = "Capacidad total:";
            // 
            // cmbNombreMozo
            // 
            this.cmbNombreMozo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNombreMozo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.cmbNombreMozo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNombreMozo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbNombreMozo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbNombreMozo.FormattingEnabled = true;
            this.cmbNombreMozo.Location = new System.Drawing.Point(320, 388);
            this.cmbNombreMozo.Name = "cmbNombreMozo";
            this.cmbNombreMozo.Size = new System.Drawing.Size(161, 26);
            this.cmbNombreMozo.TabIndex = 33;
            this.cmbNombreMozo.Text = "Nombre del mozo";
            this.ttpMensajesDeAyuda.SetToolTip(this.cmbNombreMozo, "Asignar el mozo que se hara cargo de la/s mesa/s");
            // 
            // dgvCrearMesa
            // 
            this.dgvCrearMesa.AllowUserToAddRows = false;
            this.dgvCrearMesa.AllowUserToDeleteRows = false;
            this.dgvCrearMesa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCrearMesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCrearMesa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCrearMesa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvCrearMesa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCrearMesa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCrearMesa.ColumnHeadersHeight = 45;
            this.dgvCrearMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCrearMesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID_NumeroMesa,
            this.colNumeroMesa,
            this.colCapacidad,
            this.colSeleccionDeFilas});
            this.dgvCrearMesa.EnableHeadersVisualStyles = false;
            this.dgvCrearMesa.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCrearMesa.Location = new System.Drawing.Point(7, 40);
            this.dgvCrearMesa.Name = "dgvCrearMesa";
            this.dgvCrearMesa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCrearMesa.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCrearMesa.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvCrearMesa.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCrearMesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCrearMesa.Size = new System.Drawing.Size(299, 519);
            this.dgvCrearMesa.TabIndex = 32;
            this.dgvCrearMesa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCrearMesa_CellContentClick);
            // 
            // colID_NumeroMesa
            // 
            this.colID_NumeroMesa.HeaderText = "ID_NumeroMesa";
            this.colID_NumeroMesa.Name = "colID_NumeroMesa";
            this.colID_NumeroMesa.ReadOnly = true;
            this.colID_NumeroMesa.Visible = false;
            this.colID_NumeroMesa.Width = 140;
            // 
            // colNumeroMesa
            // 
            this.colNumeroMesa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNumeroMesa.HeaderText = "Numero de Mesa";
            this.colNumeroMesa.Name = "colNumeroMesa";
            this.colNumeroMesa.ReadOnly = true;
            // 
            // colCapacidad
            // 
            this.colCapacidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCapacidad.HeaderText = "Capacidad";
            this.colCapacidad.Name = "colCapacidad";
            this.colCapacidad.ReadOnly = true;
            this.colCapacidad.Width = 104;
            // 
            // colSeleccionDeFilas
            // 
            this.colSeleccionDeFilas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSeleccionDeFilas.HeaderText = "Seleccionar";
            this.colSeleccionDeFilas.Name = "colSeleccionDeFilas";
            this.colSeleccionDeFilas.Width = 104;
            // 
            // grbPlantas
            // 
            this.grbPlantas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grbPlantas.Controls.Add(this.rbnPlantaAlta);
            this.grbPlantas.Controls.Add(this.rbnPlantaBaja);
            this.grbPlantas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grbPlantas.ForeColor = System.Drawing.Color.Gray;
            this.grbPlantas.Location = new System.Drawing.Point(320, 299);
            this.grbPlantas.Name = "grbPlantas";
            this.grbPlantas.Size = new System.Drawing.Size(161, 83);
            this.grbPlantas.TabIndex = 31;
            this.grbPlantas.TabStop = false;
            this.grbPlantas.Text = "Planta";
            // 
            // rbnPlantaAlta
            // 
            this.rbnPlantaAlta.AutoSize = true;
            this.rbnPlantaAlta.Enabled = false;
            this.rbnPlantaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnPlantaAlta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnPlantaAlta.Location = new System.Drawing.Point(6, 54);
            this.rbnPlantaAlta.Name = "rbnPlantaAlta";
            this.rbnPlantaAlta.Size = new System.Drawing.Size(105, 22);
            this.rbnPlantaAlta.TabIndex = 33;
            this.rbnPlantaAlta.Text = "Planta alta";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnPlantaAlta, "Ver las mesas disponibles en la planta alta");
            this.rbnPlantaAlta.UseVisualStyleBackColor = true;
            this.rbnPlantaAlta.CheckedChanged += new System.EventHandler(this.RbnPlantaAlta_CheckedChanged);
            // 
            // rbnPlantaBaja
            // 
            this.rbnPlantaBaja.AutoSize = true;
            this.rbnPlantaBaja.Checked = true;
            this.rbnPlantaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnPlantaBaja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnPlantaBaja.Location = new System.Drawing.Point(6, 26);
            this.rbnPlantaBaja.Name = "rbnPlantaBaja";
            this.rbnPlantaBaja.Size = new System.Drawing.Size(109, 22);
            this.rbnPlantaBaja.TabIndex = 32;
            this.rbnPlantaBaja.TabStop = true;
            this.rbnPlantaBaja.Text = "Planta baja";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnPlantaBaja, "Ver las mesas disponibles en la planta baja");
            this.rbnPlantaBaja.UseVisualStyleBackColor = true;
            this.rbnPlantaBaja.CheckedChanged += new System.EventHandler(this.RbnPlantaBaja_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.BorderSize = 2;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(320, 509);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(160, 50);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnAceptar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
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
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(498, 30);
            this.pnlBarraDeArrastre.TabIndex = 0;
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
            this.lblTituloFrm.Text = "Datos del pedido";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picBTNInformacion
            // 
            this.picBTNInformacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNInformacion.Image = global::Procuratio.Properties.Resources._3017955_48;
            this.picBTNInformacion.Location = new System.Drawing.Point(416, 0);
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
            this.picBTNCerrar.Location = new System.Drawing.Point(457, 0);
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
            // FrmCrearMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(500, 568);
            this.Controls.Add(this.pnlContenedorFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearMesa";
            this.Load += new System.EventHandler(this.FrmCrearMesa_Load);
            this.pnlContenedorFrm.ResumeLayout(false);
            this.pnlContenedorFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearMesa)).EndInit();
            this.grbPlantas.ResumeLayout(false);
            this.grbPlantas.PerformLayout();
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrColor;
        private System.Windows.Forms.Panel pnlContenedorFrm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.PictureBox picBTNInformacion;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grbPlantas;
        private System.Windows.Forms.RadioButton rbnPlantaBaja;
        private System.Windows.Forms.RadioButton rbnPlantaAlta;
        private System.Windows.Forms.DataGridView dgvCrearMesa;
        private System.Windows.Forms.ComboBox cmbNombreMozo;
        private System.Windows.Forms.Label lblResultadoCapacidadTotal;
        private System.Windows.Forms.Label lblCapacidadTotal;
        private System.Windows.Forms.ComboBox cmbNombreChef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_NumeroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccionDeFilas;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Label lblTituloFrm;
        private System.Windows.Forms.Button btnCargarClientes;
    }
}