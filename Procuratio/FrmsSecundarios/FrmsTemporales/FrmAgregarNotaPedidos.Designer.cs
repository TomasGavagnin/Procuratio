namespace Procuratio
{
    partial class FrmAgregarNotaPedidos
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
            this.pnlContenedorFrm = new System.Windows.Forms.Panel();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTextoAviso = new System.Windows.Forms.Label();
            this.lblNotaPedido = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNotaPedido = new System.Windows.Forms.TextBox();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tmrCerrarNota = new System.Windows.Forms.Timer(this.components);
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.pnlContenedorFrm.SuspendLayout();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedorFrm
            // 
            this.pnlContenedorFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorFrm.Controls.Add(this.lblTiempo);
            this.pnlContenedorFrm.Controls.Add(this.lblTextoAviso);
            this.pnlContenedorFrm.Controls.Add(this.lblNotaPedido);
            this.pnlContenedorFrm.Controls.Add(this.btnAceptar);
            this.pnlContenedorFrm.Controls.Add(this.txtNotaPedido);
            this.pnlContenedorFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContenedorFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorFrm.Name = "pnlContenedorFrm";
            this.pnlContenedorFrm.Size = new System.Drawing.Size(548, 301);
            this.pnlContenedorFrm.TabIndex = 0;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.Gray;
            this.lblTiempo.Location = new System.Drawing.Point(354, 213);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(31, 22);
            this.lblTiempo.TabIndex = 44;
            this.lblTiempo.Text = "60";
            // 
            // lblTextoAviso
            // 
            this.lblTextoAviso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoAviso.AutoSize = true;
            this.lblTextoAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoAviso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTextoAviso.Location = new System.Drawing.Point(3, 214);
            this.lblTextoAviso.Name = "lblTextoAviso";
            this.lblTextoAviso.Size = new System.Drawing.Size(349, 18);
            this.lblTextoAviso.TabIndex = 43;
            this.lblTextoAviso.Text = "Esta ventana se cerrara automaticamente en:";
            this.lblTextoAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotaPedido
            // 
            this.lblNotaPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotaPedido.AutoSize = true;
            this.lblNotaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaPedido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNotaPedido.Location = new System.Drawing.Point(3, 42);
            this.lblNotaPedido.Name = "lblNotaPedido";
            this.lblNotaPedido.Size = new System.Drawing.Size(535, 36);
            this.lblNotaPedido.TabIndex = 42;
            this.lblNotaPedido.Text = "Opcional: especifica en este campo los articulos en los que el cliente \r\npidio un" +
    "a elaboracion diferente (como una hamburguesa sin aderezo)";
            this.lblNotaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.BorderSize = 2;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(3, 242);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(540, 50);
            this.btnAceptar.TabIndex = 41;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnAceptar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // txtNotaPedido
            // 
            this.txtNotaPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtNotaPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotaPedido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaPedido.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNotaPedido.Location = new System.Drawing.Point(3, 88);
            this.txtNotaPedido.MaxLength = 120;
            this.txtNotaPedido.Multiline = true;
            this.txtNotaPedido.Name = "txtNotaPedido";
            this.txtNotaPedido.Size = new System.Drawing.Size(540, 116);
            this.txtNotaPedido.TabIndex = 40;
            this.ttpMensajesDeAyuda.SetToolTip(this.txtNotaPedido, "Mensaje que sera enviado a cocina sobre el pedido");
            this.txtNotaPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNotaPedido_KeyPress);
            // 
            // pnlBarraDeArrastre
            // 
            this.pnlBarraDeArrastre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            this.pnlBarraDeArrastre.Controls.Add(this.lblTituloFrm);
            this.pnlBarraDeArrastre.Controls.Add(this.picLogo);
            this.pnlBarraDeArrastre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraDeArrastre.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraDeArrastre.Name = "pnlBarraDeArrastre";
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(546, 30);
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
            this.lblTituloFrm.Text = "Nota que recibira cocina";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
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
            // tmrCerrarNota
            // 
            this.tmrCerrarNota.Enabled = true;
            this.tmrCerrarNota.Interval = 1000;
            this.tmrCerrarNota.Tick += new System.EventHandler(this.TmrCerrarNota_Tick);
            // 
            // FrmAgregarNotaPedidos
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(548, 301);
            this.Controls.Add(this.pnlContenedorFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarNotaPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarNotaPedidos";
            this.Load += new System.EventHandler(this.FrmAgregarNotaPedidos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            this.pnlContenedorFrm.ResumeLayout(false);
            this.pnlContenedorFrm.PerformLayout();
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorFrm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtNotaPedido;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNotaPedido;
        private System.Windows.Forms.Label lblTextoAviso;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Timer tmrCerrarNota;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Label lblTituloFrm;
    }
}