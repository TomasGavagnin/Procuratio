namespace Procuratio.FrmsSecundarios.FrmsTemporales.FrmCarta
{
    partial class MostrarPedidoFianlizado
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblResultadoTotal = new System.Windows.Forms.Label();
            this.dgvArticulosPedido = new System.Windows.Forms.DataGridView();
            this.ID_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlContenedorFrm.SuspendLayout();
            this.pnlContTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosPedido)).BeginInit();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedorFrm
            // 
            this.pnlContenedorFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorFrm.Controls.Add(this.pnlContTotal);
            this.pnlContenedorFrm.Controls.Add(this.dgvArticulosPedido);
            this.pnlContenedorFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContenedorFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorFrm.Name = "pnlContenedorFrm";
            this.pnlContenedorFrm.Size = new System.Drawing.Size(331, 460);
            this.pnlContenedorFrm.TabIndex = 1;
            // 
            // pnlContTotal
            // 
            this.pnlContTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pnlContTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContTotal.Controls.Add(this.lblTotal);
            this.pnlContTotal.Controls.Add(this.lblResultadoTotal);
            this.pnlContTotal.Location = new System.Drawing.Point(11, 403);
            this.pnlContTotal.Name = "pnlContTotal";
            this.pnlContTotal.Size = new System.Drawing.Size(307, 44);
            this.pnlContTotal.TabIndex = 59;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotal.Location = new System.Drawing.Point(3, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 18);
            this.lblTotal.TabIndex = 56;
            this.lblTotal.Text = "Total:";
            // 
            // lblResultadoTotal
            // 
            this.lblResultadoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultadoTotal.AutoSize = true;
            this.lblResultadoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblResultadoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoTotal.Location = new System.Drawing.Point(55, 10);
            this.lblResultadoTotal.Name = "lblResultadoTotal";
            this.lblResultadoTotal.Size = new System.Drawing.Size(21, 22);
            this.lblResultadoTotal.TabIndex = 57;
            this.lblResultadoTotal.Text = "0";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulosPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulosPedido.ColumnHeadersHeight = 45;
            this.dgvArticulosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArticulosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Articulo,
            this.colArticulo,
            this.colCantidad});
            this.dgvArticulosPedido.EnableHeadersVisualStyles = false;
            this.dgvArticulosPedido.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvArticulosPedido.Location = new System.Drawing.Point(11, 40);
            this.dgvArticulosPedido.Name = "dgvArticulosPedido";
            this.dgvArticulosPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulosPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulosPedido.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvArticulosPedido.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulosPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvArticulosPedido.Size = new System.Drawing.Size(307, 357);
            this.dgvArticulosPedido.TabIndex = 34;
            // 
            // ID_Articulo
            // 
            this.ID_Articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_Articulo.HeaderText = "ID_Articulo";
            this.ID_Articulo.Name = "ID_Articulo";
            this.ID_Articulo.ReadOnly = true;
            this.ID_Articulo.Visible = false;
            this.ID_Articulo.Width = 102;
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
            this.colCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCantidad.HeaderText = "Cant.";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 63;
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
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(329, 30);
            this.pnlBarraDeArrastre.TabIndex = 1;
            this.pnlBarraDeArrastre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // lblTituloFrm
            // 
            this.lblTituloFrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTituloFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloFrm.Location = new System.Drawing.Point(41, 0);
            this.lblTituloFrm.Name = "lblTituloFrm";
            this.lblTituloFrm.Size = new System.Drawing.Size(167, 30);
            this.lblTituloFrm.TabIndex = 11;
            this.lblTituloFrm.Text = "Detalle del pedido";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar;
            this.picBTNCerrar.Location = new System.Drawing.Point(288, 0);
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
            // MostrarPedidoFianlizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(331, 460);
            this.Controls.Add(this.pnlContenedorFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarPedidoFianlizado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarPedidoFianlizado";
            this.Load += new System.EventHandler(this.MostrarPedidoFianlizado_Load);
            this.pnlContenedorFrm.ResumeLayout(false);
            this.pnlContTotal.ResumeLayout(false);
            this.pnlContTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosPedido)).EndInit();
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorFrm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.Label lblTituloFrm;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DataGridView dgvArticulosPedido;
        private System.Windows.Forms.Panel pnlContTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblResultadoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
    }
}