namespace Procuratio
{
    partial class FrmMesasReservadas
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
            this.pnlContTotal = new System.Windows.Forms.Panel();
            this.lblCapacidadTotal = new System.Windows.Forms.Label();
            this.lblResultadoCapacidadTotal = new System.Windows.Forms.Label();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dgvMesasReservadas = new System.Windows.Forms.DataGridView();
            this.colID_Mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMesasDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.pnlContenedorFrm.SuspendLayout();
            this.pnlContTotal.SuspendLayout();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasReservadas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedorFrm
            // 
            this.pnlContenedorFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorFrm.Controls.Add(this.pnlContTotal);
            this.pnlContenedorFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContenedorFrm.Controls.Add(this.dgvMesasReservadas);
            this.pnlContenedorFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorFrm.Name = "pnlContenedorFrm";
            this.pnlContenedorFrm.Size = new System.Drawing.Size(260, 535);
            this.pnlContenedorFrm.TabIndex = 1;
            // 
            // pnlContTotal
            // 
            this.pnlContTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pnlContTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContTotal.Controls.Add(this.lblCapacidadTotal);
            this.pnlContTotal.Controls.Add(this.lblResultadoCapacidadTotal);
            this.pnlContTotal.Location = new System.Drawing.Point(7, 481);
            this.pnlContTotal.Name = "pnlContTotal";
            this.pnlContTotal.Size = new System.Drawing.Size(240, 44);
            this.pnlContTotal.TabIndex = 58;
            // 
            // lblCapacidadTotal
            // 
            this.lblCapacidadTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCapacidadTotal.AutoSize = true;
            this.lblCapacidadTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblCapacidadTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCapacidadTotal.Location = new System.Drawing.Point(3, 12);
            this.lblCapacidadTotal.Name = "lblCapacidadTotal";
            this.lblCapacidadTotal.Size = new System.Drawing.Size(130, 18);
            this.lblCapacidadTotal.TabIndex = 56;
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
            this.lblResultadoCapacidadTotal.TabIndex = 57;
            this.lblResultadoCapacidadTotal.Text = "0";
            this.ttpMensajesDeAyuda.SetToolTip(this.lblResultadoCapacidadTotal, "Capacidad total acumulada por la capacidad de la/s mesa/s");
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
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(258, 30);
            this.pnlBarraDeArrastre.TabIndex = 36;
            this.pnlBarraDeArrastre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // lblTituloFrm
            // 
            this.lblTituloFrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTituloFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloFrm.Location = new System.Drawing.Point(41, 0);
            this.lblTituloFrm.Name = "lblTituloFrm";
            this.lblTituloFrm.Size = new System.Drawing.Size(170, 30);
            this.lblTituloFrm.TabIndex = 11;
            this.lblTituloFrm.Text = "Mesas";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar;
            this.picBTNCerrar.Location = new System.Drawing.Point(217, 0);
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
            // dgvMesasReservadas
            // 
            this.dgvMesasReservadas.AllowUserToAddRows = false;
            this.dgvMesasReservadas.AllowUserToDeleteRows = false;
            this.dgvMesasReservadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMesasReservadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMesasReservadas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvMesasReservadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvMesasReservadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesasReservadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMesasReservadas.ColumnHeadersHeight = 45;
            this.dgvMesasReservadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMesasReservadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID_Mesa,
            this.colMesasDisponibles,
            this.colCapacidad});
            this.dgvMesasReservadas.EnableHeadersVisualStyles = false;
            this.dgvMesasReservadas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvMesasReservadas.Location = new System.Drawing.Point(7, 41);
            this.dgvMesasReservadas.Name = "dgvMesasReservadas";
            this.dgvMesasReservadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesasReservadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMesasReservadas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvMesasReservadas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMesasReservadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMesasReservadas.Size = new System.Drawing.Size(240, 434);
            this.dgvMesasReservadas.TabIndex = 35;
            this.ttpMensajesDeAyuda.SetToolTip(this.dgvMesasReservadas, "Mesas asignadas a la reserva");
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
            // FrmMesasReservadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(260, 535);
            this.Controls.Add(this.pnlContenedorFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMesasReservadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMesasReservadas";
            this.Load += new System.EventHandler(this.FrmMesasReservadas_Load);
            this.pnlContenedorFrm.ResumeLayout(false);
            this.pnlContTotal.ResumeLayout(false);
            this.pnlContTotal.PerformLayout();
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasReservadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorFrm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DataGridView dgvMesasReservadas;
        private System.Windows.Forms.Label lblResultadoCapacidadTotal;
        private System.Windows.Forms.Label lblCapacidadTotal;
        private System.Windows.Forms.Panel pnlContTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMesasDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacidad;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Label lblTituloFrm;
    }
}