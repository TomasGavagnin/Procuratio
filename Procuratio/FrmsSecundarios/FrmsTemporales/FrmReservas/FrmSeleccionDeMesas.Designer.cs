namespace Procuratio
{
    partial class FrmSeleccionDeMesas
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
            this.pnlContenedorFrm = new System.Windows.Forms.Panel();
            this.lblResultadoCapacidadTotal = new System.Windows.Forms.Label();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.lblResultadoCantidadPersonas = new System.Windows.Forms.Label();
            this.lblCapacidadTotal = new System.Windows.Forms.Label();
            this.dgvSeleccionarMesaReserva = new System.Windows.Forms.DataGridView();
            this.ColID_Mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccionDeFilas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbPlantas = new System.Windows.Forms.GroupBox();
            this.rbnPlantaAlta = new System.Windows.Forms.RadioButton();
            this.rbnPlantaBaja = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picBTNInformacion = new System.Windows.Forms.PictureBox();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tmrColor = new System.Windows.Forms.Timer(this.components);
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.pnlContenedorFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionarMesaReserva)).BeginInit();
            this.gpbPlantas.SuspendLayout();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedorFrm
            // 
            this.pnlContenedorFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorFrm.Controls.Add(this.lblResultadoCapacidadTotal);
            this.pnlContenedorFrm.Controls.Add(this.lblCantidadPersonas);
            this.pnlContenedorFrm.Controls.Add(this.lblResultadoCantidadPersonas);
            this.pnlContenedorFrm.Controls.Add(this.lblCapacidadTotal);
            this.pnlContenedorFrm.Controls.Add(this.dgvSeleccionarMesaReserva);
            this.pnlContenedorFrm.Controls.Add(this.gpbPlantas);
            this.pnlContenedorFrm.Controls.Add(this.btnAceptar);
            this.pnlContenedorFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContenedorFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorFrm.Name = "pnlContenedorFrm";
            this.pnlContenedorFrm.Size = new System.Drawing.Size(525, 450);
            this.pnlContenedorFrm.TabIndex = 0;
            // 
            // lblResultadoCapacidadTotal
            // 
            this.lblResultadoCapacidadTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultadoCapacidadTotal.AutoSize = true;
            this.lblResultadoCapacidadTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblResultadoCapacidadTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoCapacidadTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCapacidadTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoCapacidadTotal.Location = new System.Drawing.Point(458, 267);
            this.lblResultadoCapacidadTotal.Name = "lblResultadoCapacidadTotal";
            this.lblResultadoCapacidadTotal.Size = new System.Drawing.Size(21, 22);
            this.lblResultadoCapacidadTotal.TabIndex = 53;
            this.lblResultadoCapacidadTotal.Text = "0";
            this.ttpMensajesDeAyuda.SetToolTip(this.lblResultadoCapacidadTotal, "Total acumulado segun la/s mesa/s seleccionadas");
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPersonas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidadPersonas.Location = new System.Drawing.Point(307, 235);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(151, 18);
            this.lblCantidadPersonas.TabIndex = 52;
            this.lblCantidadPersonas.Text = "Cant. de personas:";
            // 
            // lblResultadoCantidadPersonas
            // 
            this.lblResultadoCantidadPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultadoCantidadPersonas.AutoSize = true;
            this.lblResultadoCantidadPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblResultadoCantidadPersonas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCantidadPersonas.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoCantidadPersonas.Location = new System.Drawing.Point(458, 234);
            this.lblResultadoCantidadPersonas.Name = "lblResultadoCantidadPersonas";
            this.lblResultadoCantidadPersonas.Size = new System.Drawing.Size(21, 22);
            this.lblResultadoCantidadPersonas.TabIndex = 51;
            this.lblResultadoCantidadPersonas.Text = "0";
            this.ttpMensajesDeAyuda.SetToolTip(this.lblResultadoCantidadPersonas, "Cantidad de personas que asistiran a la reserva");
            // 
            // lblCapacidadTotal
            // 
            this.lblCapacidadTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCapacidadTotal.AutoSize = true;
            this.lblCapacidadTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCapacidadTotal.Location = new System.Drawing.Point(327, 269);
            this.lblCapacidadTotal.Name = "lblCapacidadTotal";
            this.lblCapacidadTotal.Size = new System.Drawing.Size(130, 18);
            this.lblCapacidadTotal.TabIndex = 50;
            this.lblCapacidadTotal.Text = "Capacidad total:";
            // 
            // dgvSeleccionarMesaReserva
            // 
            this.dgvSeleccionarMesaReserva.AllowUserToAddRows = false;
            this.dgvSeleccionarMesaReserva.AllowUserToDeleteRows = false;
            this.dgvSeleccionarMesaReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSeleccionarMesaReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSeleccionarMesaReserva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvSeleccionarMesaReserva.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvSeleccionarMesaReserva.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeleccionarMesaReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSeleccionarMesaReserva.ColumnHeadersHeight = 45;
            this.dgvSeleccionarMesaReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSeleccionarMesaReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID_Mesa,
            this.colNumeroMesa,
            this.colCapacidad,
            this.colSeleccionDeFilas});
            this.dgvSeleccionarMesaReserva.EnableHeadersVisualStyles = false;
            this.dgvSeleccionarMesaReserva.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSeleccionarMesaReserva.Location = new System.Drawing.Point(7, 40);
            this.dgvSeleccionarMesaReserva.Name = "dgvSeleccionarMesaReserva";
            this.dgvSeleccionarMesaReserva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeleccionarMesaReserva.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSeleccionarMesaReserva.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvSeleccionarMesaReserva.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSeleccionarMesaReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSeleccionarMesaReserva.Size = new System.Drawing.Size(294, 401);
            this.dgvSeleccionarMesaReserva.TabIndex = 34;
            this.ttpMensajesDeAyuda.SetToolTip(this.dgvSeleccionarMesaReserva, "Mesas que se le asignara a la reserva");
            this.dgvSeleccionarMesaReserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSeleccionarMesaReserva_CellContentClick);
            // 
            // ColID_Mesa
            // 
            this.ColID_Mesa.HeaderText = "ID_Mesa";
            this.ColID_Mesa.Name = "ColID_Mesa";
            this.ColID_Mesa.ReadOnly = true;
            this.ColID_Mesa.Visible = false;
            this.ColID_Mesa.Width = 89;
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
            this.colCapacidad.HeaderText = "Capacidad";
            this.colCapacidad.Name = "colCapacidad";
            this.colCapacidad.ReadOnly = true;
            this.colCapacidad.Width = 98;
            // 
            // colSeleccionDeFilas
            // 
            this.colSeleccionDeFilas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSeleccionDeFilas.HeaderText = "Seleccionar";
            this.colSeleccionDeFilas.Name = "colSeleccionDeFilas";
            // 
            // gpbPlantas
            // 
            this.gpbPlantas.Controls.Add(this.rbnPlantaAlta);
            this.gpbPlantas.Controls.Add(this.rbnPlantaBaja);
            this.gpbPlantas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gpbPlantas.ForeColor = System.Drawing.Color.Gray;
            this.gpbPlantas.Location = new System.Drawing.Point(333, 302);
            this.gpbPlantas.Name = "gpbPlantas";
            this.gpbPlantas.Size = new System.Drawing.Size(160, 83);
            this.gpbPlantas.TabIndex = 33;
            this.gpbPlantas.TabStop = false;
            this.gpbPlantas.Text = "Plantas";
            // 
            // rbnPlantaAlta
            // 
            this.rbnPlantaAlta.AutoSize = true;
            this.rbnPlantaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnPlantaAlta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnPlantaAlta.Location = new System.Drawing.Point(6, 54);
            this.rbnPlantaAlta.Name = "rbnPlantaAlta";
            this.rbnPlantaAlta.Size = new System.Drawing.Size(105, 22);
            this.rbnPlantaAlta.TabIndex = 33;
            this.rbnPlantaAlta.Text = "Planta alta";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnPlantaAlta, "Ver las mesas de la planta alta");
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
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnPlantaBaja, "Ver las mesas de la planta baja");
            this.rbnPlantaBaja.UseVisualStyleBackColor = true;
            this.rbnPlantaBaja.CheckedChanged += new System.EventHandler(this.RbnPlantaBaja_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.BorderSize = 2;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(333, 391);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(160, 50);
            this.btnAceptar.TabIndex = 32;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(523, 30);
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
            this.lblTituloFrm.Text = "Seleccion de mesas para la reserva";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picBTNInformacion
            // 
            this.picBTNInformacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNInformacion.Image = global::Procuratio.Properties.Resources._3017955_48;
            this.picBTNInformacion.Location = new System.Drawing.Point(441, 0);
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
            this.picBTNCerrar.Location = new System.Drawing.Point(482, 0);
            this.picBTNCerrar.Name = "picBTNCerrar";
            this.picBTNCerrar.Size = new System.Drawing.Size(41, 30);
            this.picBTNCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNCerrar.TabIndex = 3;
            this.picBTNCerrar.TabStop = false;
            this.picBTNCerrar.Click += new System.EventHandler(this.picBTNCerrar_Click);
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
            // tmrColor
            // 
            this.tmrColor.Enabled = true;
            this.tmrColor.Tick += new System.EventHandler(this.tmrColor_Tick);
            // 
            // FrmSeleccionDeMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.pnlContenedorFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSeleccionDeMesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSeleccionDeMesas";
            this.Load += new System.EventHandler(this.FrmSeleccionDeMesas_Load);
            this.pnlContenedorFrm.ResumeLayout(false);
            this.pnlContenedorFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionarMesaReserva)).EndInit();
            this.gpbPlantas.ResumeLayout(false);
            this.gpbPlantas.PerformLayout();
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorFrm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picBTNInformacion;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Timer tmrColor;
        private System.Windows.Forms.GroupBox gpbPlantas;
        private System.Windows.Forms.RadioButton rbnPlantaAlta;
        private System.Windows.Forms.RadioButton rbnPlantaBaja;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvSeleccionarMesaReserva;
        private System.Windows.Forms.Label lblResultadoCantidadPersonas;
        private System.Windows.Forms.Label lblCapacidadTotal;
        private System.Windows.Forms.Label lblResultadoCapacidadTotal;
        private System.Windows.Forms.Label lblCantidadPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID_Mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccionDeFilas;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Label lblTituloFrm;
    }
}