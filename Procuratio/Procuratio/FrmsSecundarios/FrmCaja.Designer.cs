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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCaja = new System.Windows.Forms.DataGridView();
            this.dgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSeleccionDeFilas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEliminarElementos = new System.Windows.Forms.Button();
            this.lblRegistroDeCaja = new System.Windows.Forms.Label();
            this.lblSeleccionDeRegistro = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCaja
            // 
            this.dgvCaja.AllowUserToOrderColumns = true;
            this.dgvCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCaja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCaja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvCaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
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
            this.dgvFecha,
            this.dgvHora,
            this.dgvIngreso,
            this.dgvEgreso,
            this.dgvDetalle,
            this.dgvSeleccionDeFilas});
            this.dgvCaja.EnableHeadersVisualStyles = false;
            this.dgvCaja.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCaja.Location = new System.Drawing.Point(7, 221);
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
            this.dgvCaja.Size = new System.Drawing.Size(747, 337);
            this.dgvCaja.TabIndex = 4;
            // 
            // dgvFecha
            // 
            this.dgvFecha.Frozen = true;
            this.dgvFecha.HeaderText = "Fecha";
            this.dgvFecha.Name = "dgvFecha";
            this.dgvFecha.Width = 69;
            // 
            // dgvHora
            // 
            this.dgvHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHora.HeaderText = "Hora";
            this.dgvHora.Name = "dgvHora";
            // 
            // dgvIngreso
            // 
            this.dgvIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvIngreso.HeaderText = "Ingreso";
            this.dgvIngreso.Name = "dgvIngreso";
            // 
            // dgvEgreso
            // 
            this.dgvEgreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvEgreso.HeaderText = "Egreso";
            this.dgvEgreso.Name = "dgvEgreso";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDetalle.HeaderText = "Detalle";
            this.dgvDetalle.Name = "dgvDetalle";
            // 
            // dgvSeleccionDeFilas
            // 
            this.dgvSeleccionDeFilas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSeleccionDeFilas.HeaderText = "Seleccionar";
            this.dgvSeleccionDeFilas.Name = "dgvSeleccionDeFilas";
            // 
            // btnEliminarElementos
            // 
            this.btnEliminarElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarElementos.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarElementos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarElementos.FlatAppearance.BorderSize = 2;
            this.btnEliminarElementos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarElementos.ForeColor = System.Drawing.Color.White;
            this.btnEliminarElementos.Location = new System.Drawing.Point(765, 507);
            this.btnEliminarElementos.Name = "btnEliminarElementos";
            this.btnEliminarElementos.Size = new System.Drawing.Size(160, 50);
            this.btnEliminarElementos.TabIndex = 28;
            this.btnEliminarElementos.Text = "Eliminar elementos seleccionados";
            this.btnEliminarElementos.UseVisualStyleBackColor = false;
            this.btnEliminarElementos.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnEliminarElementos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblRegistroDeCaja
            // 
            this.lblRegistroDeCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblRegistroDeCaja.AutoSize = true;
            this.lblRegistroDeCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblRegistroDeCaja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroDeCaja.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistroDeCaja.Location = new System.Drawing.Point(233, 15);
            this.lblRegistroDeCaja.Name = "lblRegistroDeCaja";
            this.lblRegistroDeCaja.Size = new System.Drawing.Size(495, 19);
            this.lblRegistroDeCaja.TabIndex = 29;
            this.lblRegistroDeCaja.Text = "BALANCES Y REGISTRO DE PAGOS A EMPLEADOS Y PROVEEDORES";
            // 
            // lblSeleccionDeRegistro
            // 
            this.lblSeleccionDeRegistro.AutoSize = true;
            this.lblSeleccionDeRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionDeRegistro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSeleccionDeRegistro.Location = new System.Drawing.Point(12, 49);
            this.lblSeleccionDeRegistro.Name = "lblSeleccionDeRegistro";
            this.lblSeleccionDeRegistro.Size = new System.Drawing.Size(261, 18);
            this.lblSeleccionDeRegistro.TabIndex = 30;
            this.lblSeleccionDeRegistro.Text = "Selecciona lo que quiera registrar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(279, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // FrmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(935, 565);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSeleccionDeRegistro);
            this.Controls.Add(this.lblRegistroDeCaja);
            this.Controls.Add(this.btnEliminarElementos);
            this.Controls.Add(this.dgvCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCaja";
            this.Text = "FrmCaja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvSeleccionDeFilas;
        private System.Windows.Forms.Button btnEliminarElementos;
        private System.Windows.Forms.Label lblRegistroDeCaja;
        private System.Windows.Forms.Label lblSeleccionDeRegistro;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}