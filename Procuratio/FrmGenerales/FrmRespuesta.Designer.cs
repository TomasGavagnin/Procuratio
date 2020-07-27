namespace Procuratio.FrmGenerales
{
    partial class FrmRespuesta
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
            this.PnlContForm = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnNo = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.flpRespuesta = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlContForm.SuspendLayout();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            this.flpRespuesta.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlContForm
            // 
            this.PnlContForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlContForm.Controls.Add(this.flpRespuesta);
            this.PnlContForm.Controls.Add(this.lblMensaje);
            this.PnlContForm.Controls.Add(this.pnlBarraDeArrastre);
            this.PnlContForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContForm.Location = new System.Drawing.Point(0, 0);
            this.PnlContForm.Name = "PnlContForm";
            this.PnlContForm.Size = new System.Drawing.Size(520, 250);
            this.PnlContForm.TabIndex = 0;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatAppearance.BorderSize = 2;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(338, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(160, 30);
            this.BtnCancelar.TabIndex = 55;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            this.BtnCancelar.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.BtnCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // BtnNo
            // 
            this.BtnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNo.BackColor = System.Drawing.Color.Transparent;
            this.BtnNo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnNo.FlatAppearance.BorderSize = 2;
            this.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNo.ForeColor = System.Drawing.Color.White;
            this.BtnNo.Location = new System.Drawing.Point(172, 3);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(160, 30);
            this.BtnNo.TabIndex = 54;
            this.BtnNo.Text = "No";
            this.BtnNo.UseVisualStyleBackColor = false;
            this.BtnNo.Visible = false;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            this.BtnNo.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.BtnNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnSi
            // 
            this.btnSi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSi.BackColor = System.Drawing.Color.Transparent;
            this.btnSi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSi.FlatAppearance.BorderSize = 2;
            this.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.ForeColor = System.Drawing.Color.White;
            this.btnSi.Location = new System.Drawing.Point(6, 3);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(160, 30);
            this.btnSi.TabIndex = 53;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Visible = false;
            this.btnSi.Click += new System.EventHandler(this.BtnSi_Click);
            this.btnSi.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnSi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(11, 43);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(491, 157);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Informacion";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBarraDeArrastre
            // 
            this.pnlBarraDeArrastre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            this.pnlBarraDeArrastre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarraDeArrastre.Controls.Add(this.lblTituloFrm);
            this.pnlBarraDeArrastre.Controls.Add(this.picLogo);
            this.pnlBarraDeArrastre.Controls.Add(this.picBTNCerrar);
            this.pnlBarraDeArrastre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraDeArrastre.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraDeArrastre.Name = "pnlBarraDeArrastre";
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(518, 30);
            this.pnlBarraDeArrastre.TabIndex = 3;
            this.pnlBarraDeArrastre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // lblTituloFrm
            // 
            this.lblTituloFrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTituloFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloFrm.Location = new System.Drawing.Point(41, 0);
            this.lblTituloFrm.Name = "lblTituloFrm";
            this.lblTituloFrm.Size = new System.Drawing.Size(157, 28);
            this.lblTituloFrm.TabIndex = 9;
            this.lblTituloFrm.Text = "Confirmación";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
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
            // picBTNCerrar
            // 
            this.picBTNCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBTNCerrar.ErrorImage = global::Procuratio.Properties.Resources.Cerrar;
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar;
            this.picBTNCerrar.Location = new System.Drawing.Point(481, 0);
            this.picBTNCerrar.Name = "picBTNCerrar";
            this.picBTNCerrar.Size = new System.Drawing.Size(35, 28);
            this.picBTNCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNCerrar.TabIndex = 1;
            this.picBTNCerrar.TabStop = false;
            this.picBTNCerrar.Click += new System.EventHandler(this.PicBTNCerrar_Click);
            this.picBTNCerrar.MouseLeave += new System.EventHandler(this.ColorFondoBotones_MouseLeave);
            this.picBTNCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorFondoBotones_MouseMove);
            // 
            // flpRespuesta
            // 
            this.flpRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flpRespuesta.Controls.Add(this.BtnCancelar);
            this.flpRespuesta.Controls.Add(this.BtnNo);
            this.flpRespuesta.Controls.Add(this.btnSi);
            this.flpRespuesta.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpRespuesta.Location = new System.Drawing.Point(6, 203);
            this.flpRespuesta.Name = "flpRespuesta";
            this.flpRespuesta.Size = new System.Drawing.Size(501, 37);
            this.flpRespuesta.TabIndex = 56;
            // 
            // FrmRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(520, 250);
            this.Controls.Add(this.PnlContForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRespuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRespuesta";
            this.Load += new System.EventHandler(this.FrmRespuesta_Load);
            this.PnlContForm.ResumeLayout(false);
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            this.flpRespuesta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlContForm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.Label lblTituloFrm;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnNo;
        private System.Windows.Forms.FlowLayoutPanel flpRespuesta;
    }
}