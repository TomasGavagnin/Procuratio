namespace Procuratio.FrmsSecundarios.FrmsTemporales
{
    partial class FrmListarMesas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContenedorFrm = new System.Windows.Forms.Panel();
            this.pnlContTotal = new System.Windows.Forms.Panel();
            this.lblCapacidadTotal = new System.Windows.Forms.Label();
            this.lblResultadoCapacidadTotal = new System.Windows.Forms.Label();
            this.grbPlantas = new System.Windows.Forms.GroupBox();
            this.rbnPlantaAlta = new System.Windows.Forms.RadioButton();
            this.rbnPlantaBaja = new System.Windows.Forms.RadioButton();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dgvListarMesas = new System.Windows.Forms.DataGridView();
            this.colID_Mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMesasDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContenedorFrm.SuspendLayout();
            this.pnlContTotal.SuspendLayout();
            this.grbPlantas.SuspendLayout();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedorFrm
            // 
            this.pnlContenedorFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorFrm.Controls.Add(this.pnlContTotal);
            this.pnlContenedorFrm.Controls.Add(this.grbPlantas);
            this.pnlContenedorFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContenedorFrm.Controls.Add(this.dgvListarMesas);
            this.pnlContenedorFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorFrm.Name = "pnlContenedorFrm";
            this.pnlContenedorFrm.Size = new System.Drawing.Size(475, 570);
            this.pnlContenedorFrm.TabIndex = 0;
            // 
            // pnlContTotal
            // 
            this.pnlContTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pnlContTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContTotal.Controls.Add(this.lblCapacidadTotal);
            this.pnlContTotal.Controls.Add(this.lblResultadoCapacidadTotal);
            this.pnlContTotal.Location = new System.Drawing.Point(7, 521);
            this.pnlContTotal.Name = "pnlContTotal";
            this.pnlContTotal.Size = new System.Drawing.Size(273, 44);
            this.pnlContTotal.TabIndex = 59;
            // 
            // lblCapacidadTotal
            // 
            this.lblCapacidadTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCapacidadTotal.AutoSize = true;
            this.lblCapacidadTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCapacidadTotal.Location = new System.Drawing.Point(3, 12);
            this.lblCapacidadTotal.Name = "lblCapacidadTotal";
            this.lblCapacidadTotal.Size = new System.Drawing.Size(130, 18);
            this.lblCapacidadTotal.TabIndex = 54;
            this.lblCapacidadTotal.Text = "Capacidad total:";
            // 
            // lblResultadoCapacidadTotal
            // 
            this.lblResultadoCapacidadTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultadoCapacidadTotal.AutoSize = true;
            this.lblResultadoCapacidadTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblResultadoCapacidadTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoCapacidadTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCapacidadTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoCapacidadTotal.Location = new System.Drawing.Point(134, 10);
            this.lblResultadoCapacidadTotal.Name = "lblResultadoCapacidadTotal";
            this.lblResultadoCapacidadTotal.Size = new System.Drawing.Size(21, 22);
            this.lblResultadoCapacidadTotal.TabIndex = 55;
            this.lblResultadoCapacidadTotal.Text = "0";
            // 
            // grbPlantas
            // 
            this.grbPlantas.Controls.Add(this.rbnPlantaAlta);
            this.grbPlantas.Controls.Add(this.rbnPlantaBaja);
            this.grbPlantas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grbPlantas.ForeColor = System.Drawing.Color.Gray;
            this.grbPlantas.Location = new System.Drawing.Point(286, 432);
            this.grbPlantas.Name = "grbPlantas";
            this.grbPlantas.Size = new System.Drawing.Size(176, 83);
            this.grbPlantas.TabIndex = 37;
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
            this.rbnPlantaBaja.UseVisualStyleBackColor = true;
            this.rbnPlantaBaja.CheckedChanged += new System.EventHandler(this.RbnPlantaBaja_CheckedChanged);
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
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(473, 30);
            this.pnlBarraDeArrastre.TabIndex = 36;
            this.pnlBarraDeArrastre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // lblTituloFrm
            // 
            this.lblTituloFrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTituloFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloFrm.Location = new System.Drawing.Point(41, 0);
            this.lblTituloFrm.Name = "lblTituloFrm";
            this.lblTituloFrm.Size = new System.Drawing.Size(371, 30);
            this.lblTituloFrm.TabIndex = 10;
            this.lblTituloFrm.Text = "Lista de las mesas activas";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar;
            this.picBTNCerrar.Location = new System.Drawing.Point(432, 0);
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
            // dgvListarMesas
            // 
            this.dgvListarMesas.AllowUserToAddRows = false;
            this.dgvListarMesas.AllowUserToDeleteRows = false;
            this.dgvListarMesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListarMesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListarMesas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvListarMesas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvListarMesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarMesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarMesas.ColumnHeadersHeight = 45;
            this.dgvListarMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListarMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID_Mesa,
            this.colMesasDisponibles,
            this.colCapacidad});
            this.dgvListarMesas.EnableHeadersVisualStyles = false;
            this.dgvListarMesas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvListarMesas.Location = new System.Drawing.Point(7, 41);
            this.dgvListarMesas.Name = "dgvListarMesas";
            this.dgvListarMesas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarMesas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarMesas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvListarMesas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListarMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvListarMesas.Size = new System.Drawing.Size(273, 474);
            this.dgvListarMesas.TabIndex = 35;
            // 
            // colID_Mesa
            // 
            this.colID_Mesa.HeaderText = "ID_Mesa";
            this.colID_Mesa.Name = "colID_Mesa";
            this.colID_Mesa.ReadOnly = true;
            this.colID_Mesa.Visible = false;
            this.colID_Mesa.Width = 89;
            // 
            // colMesasDisponibles
            // 
            this.colMesasDisponibles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMesasDisponibles.HeaderText = "Numero de Mesa";
            this.colMesasDisponibles.Name = "colMesasDisponibles";
            this.colMesasDisponibles.ReadOnly = true;
            // 
            // colCapacidad
            // 
            this.colCapacidad.HeaderText = "Capacidad";
            this.colCapacidad.Name = "colCapacidad";
            this.colCapacidad.ReadOnly = true;
            this.colCapacidad.Width = 98;
            // 
            // FrmListarMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(475, 570);
            this.Controls.Add(this.pnlContenedorFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListarMesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMesasDisponibles";
            this.Load += new System.EventHandler(this.FrmMesasDisponibles_Load);
            this.pnlContenedorFrm.ResumeLayout(false);
            this.pnlContTotal.ResumeLayout(false);
            this.pnlContTotal.PerformLayout();
            this.grbPlantas.ResumeLayout(false);
            this.grbPlantas.PerformLayout();
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorFrm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DataGridView dgvListarMesas;
        private System.Windows.Forms.GroupBox grbPlantas;
        private System.Windows.Forms.RadioButton rbnPlantaAlta;
        private System.Windows.Forms.RadioButton rbnPlantaBaja;
        private System.Windows.Forms.Label lblResultadoCapacidadTotal;
        private System.Windows.Forms.Label lblCapacidadTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMesasDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacidad;
        private System.Windows.Forms.Label lblTituloFrm;
        private System.Windows.Forms.Panel pnlContTotal;
    }
}