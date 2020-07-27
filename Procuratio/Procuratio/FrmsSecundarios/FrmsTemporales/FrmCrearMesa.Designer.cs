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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearMesa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picBTNInformacion = new System.Windows.Forms.PictureBox();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.pnlContenedorDeFrm = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvNumerosDeMesasReservas = new System.Windows.Forms.DataGridView();
            this.dgvNumeroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSeleccionDeFilas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbPlanta = new System.Windows.Forms.GroupBox();
            this.rbnPlantaAlta = new System.Windows.Forms.RadioButton();
            this.rbnPlantaBaja = new System.Windows.Forms.RadioButton();
            this.tmrColor = new System.Windows.Forms.Timer(this.components);
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            this.pnlContenedorDeFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerosDeMesasReservas)).BeginInit();
            this.gpbPlanta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraDeArrastre
            // 
            this.pnlBarraDeArrastre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            this.pnlBarraDeArrastre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarraDeArrastre.Controls.Add(this.picLogo);
            this.pnlBarraDeArrastre.Controls.Add(this.picBTNInformacion);
            this.pnlBarraDeArrastre.Controls.Add(this.picBTNCerrar);
            this.pnlBarraDeArrastre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraDeArrastre.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraDeArrastre.Name = "pnlBarraDeArrastre";
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(573, 30);
            this.pnlBarraDeArrastre.TabIndex = 38;
            this.pnlBarraDeArrastre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Image = global::Procuratio.Properties.Resources.Icono_2;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(41, 28);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            this.picLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picBTNInformacion
            // 
            this.picBTNInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            this.picBTNInformacion.Image = global::Procuratio.Properties.Resources._3017955_48;
            this.picBTNInformacion.Location = new System.Drawing.Point(507, 0);
            this.picBTNInformacion.Name = "picBTNInformacion";
            this.picBTNInformacion.Size = new System.Drawing.Size(35, 28);
            this.picBTNInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNInformacion.TabIndex = 36;
            this.picBTNInformacion.TabStop = false;
            this.picBTNInformacion.Click += new System.EventHandler(this.PicBTNInformacion_Click);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picBTNCerrar.Image")));
            this.picBTNCerrar.Location = new System.Drawing.Point(538, 0);
            this.picBTNCerrar.Name = "picBTNCerrar";
            this.picBTNCerrar.Size = new System.Drawing.Size(35, 28);
            this.picBTNCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNCerrar.TabIndex = 34;
            this.picBTNCerrar.TabStop = false;
            this.picBTNCerrar.Click += new System.EventHandler(this.PicBTNCerrar_Click);
            this.picBTNCerrar.MouseLeave += new System.EventHandler(this.ColorFondoBotones_MouseLeave);
            this.picBTNCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorFondoBotones_MouseMove);
            // 
            // pnlContenedorDeFrm
            // 
            this.pnlContenedorDeFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorDeFrm.Controls.Add(this.btnAceptar);
            this.pnlContenedorDeFrm.Controls.Add(this.dgvNumerosDeMesasReservas);
            this.pnlContenedorDeFrm.Controls.Add(this.gpbPlanta);
            this.pnlContenedorDeFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContenedorDeFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorDeFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorDeFrm.Name = "pnlContenedorDeFrm";
            this.pnlContenedorDeFrm.Size = new System.Drawing.Size(575, 580);
            this.pnlContenedorDeFrm.TabIndex = 39;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.BorderSize = 2;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(404, 519);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(160, 50);
            this.btnAceptar.TabIndex = 41;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnAceptar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // dgvNumerosDeMesasReservas
            // 
            this.dgvNumerosDeMesasReservas.AllowUserToOrderColumns = true;
            this.dgvNumerosDeMesasReservas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvNumerosDeMesasReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNumerosDeMesasReservas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvNumerosDeMesasReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvNumerosDeMesasReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNumerosDeMesasReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNumerosDeMesasReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNumerosDeMesasReservas.ColumnHeadersHeight = 45;
            this.dgvNumerosDeMesasReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNumerosDeMesasReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNumeroMesa,
            this.dgvSeleccionDeFilas});
            this.dgvNumerosDeMesasReservas.EnableHeadersVisualStyles = false;
            this.dgvNumerosDeMesasReservas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvNumerosDeMesasReservas.Location = new System.Drawing.Point(11, 40);
            this.dgvNumerosDeMesasReservas.Name = "dgvNumerosDeMesasReservas";
            this.dgvNumerosDeMesasReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNumerosDeMesasReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNumerosDeMesasReservas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvNumerosDeMesasReservas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNumerosDeMesasReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNumerosDeMesasReservas.Size = new System.Drawing.Size(381, 530);
            this.dgvNumerosDeMesasReservas.TabIndex = 40;
            // 
            // dgvNumeroMesa
            // 
            this.dgvNumeroMesa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNumeroMesa.HeaderText = "Numero de Mesa";
            this.dgvNumeroMesa.Name = "dgvNumeroMesa";
            // 
            // dgvSeleccionDeFilas
            // 
            this.dgvSeleccionDeFilas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSeleccionDeFilas.HeaderText = "Seleccionar";
            this.dgvSeleccionDeFilas.Name = "dgvSeleccionDeFilas";
            // 
            // gpbPlanta
            // 
            this.gpbPlanta.Controls.Add(this.rbnPlantaAlta);
            this.gpbPlanta.Controls.Add(this.rbnPlantaBaja);
            this.gpbPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.gpbPlanta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gpbPlanta.Location = new System.Drawing.Point(404, 420);
            this.gpbPlanta.Name = "gpbPlanta";
            this.gpbPlanta.Size = new System.Drawing.Size(160, 93);
            this.gpbPlanta.TabIndex = 39;
            this.gpbPlanta.TabStop = false;
            this.gpbPlanta.Text = "Planta";
            // 
            // rbnPlantaAlta
            // 
            this.rbnPlantaAlta.AutoSize = true;
            this.rbnPlantaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnPlantaAlta.ForeColor = System.Drawing.Color.DimGray;
            this.rbnPlantaAlta.Location = new System.Drawing.Point(6, 55);
            this.rbnPlantaAlta.Name = "rbnPlantaAlta";
            this.rbnPlantaAlta.Size = new System.Drawing.Size(106, 22);
            this.rbnPlantaAlta.TabIndex = 32;
            this.rbnPlantaAlta.Text = "Planta Alta";
            this.rbnPlantaAlta.UseVisualStyleBackColor = true;
            // 
            // rbnPlantaBaja
            // 
            this.rbnPlantaBaja.AutoSize = true;
            this.rbnPlantaBaja.Checked = true;
            this.rbnPlantaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnPlantaBaja.ForeColor = System.Drawing.Color.DimGray;
            this.rbnPlantaBaja.Location = new System.Drawing.Point(6, 27);
            this.rbnPlantaBaja.Name = "rbnPlantaBaja";
            this.rbnPlantaBaja.Size = new System.Drawing.Size(111, 22);
            this.rbnPlantaBaja.TabIndex = 31;
            this.rbnPlantaBaja.TabStop = true;
            this.rbnPlantaBaja.Text = "Planta Baja";
            this.rbnPlantaBaja.UseVisualStyleBackColor = true;
            // 
            // tmrColor
            // 
            this.tmrColor.Tick += new System.EventHandler(this.tmrColor_Tick);
            // 
            // FrmCrearMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(575, 580);
            this.Controls.Add(this.pnlContenedorDeFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearMesa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCrearMesa_FormClosed);
            this.Load += new System.EventHandler(this.FrmCrearMesa_Load);
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            this.pnlContenedorDeFrm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerosDeMesasReservas)).EndInit();
            this.gpbPlanta.ResumeLayout(false);
            this.gpbPlanta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picBTNInformacion;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.Panel pnlContenedorDeFrm;
        private System.Windows.Forms.Timer tmrColor;
        private System.Windows.Forms.GroupBox gpbPlanta;
        private System.Windows.Forms.RadioButton rbnPlantaAlta;
        private System.Windows.Forms.RadioButton rbnPlantaBaja;
        private System.Windows.Forms.DataGridView dgvNumerosDeMesasReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumeroMesa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvSeleccionDeFilas;
        private System.Windows.Forms.Button btnAceptar;
    }
}