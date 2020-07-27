namespace Procuratio
{
    partial class FrmCrearCategoria
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
            this.pnlContFrm = new System.Windows.Forms.Panel();
            this.gpbCocina = new System.Windows.Forms.GroupBox();
            this.rbnCocinaNo = new System.Windows.Forms.RadioButton();
            this.rbnCocinaSi = new System.Windows.Forms.RadioButton();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.pnlDecorativo1 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picBTNInformacion = new System.Windows.Forms.PictureBox();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tmrColor = new System.Windows.Forms.Timer(this.components);
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.BtnGuardarCambios = new System.Windows.Forms.Button();
            this.pnlContFrm.SuspendLayout();
            this.gpbCocina.SuspendLayout();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContFrm
            // 
            this.pnlContFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContFrm.Controls.Add(this.gpbCocina);
            this.pnlContFrm.Controls.Add(this.txtNombreCategoria);
            this.pnlContFrm.Controls.Add(this.pnlDecorativo1);
            this.pnlContFrm.Controls.Add(this.lblNombre);
            this.pnlContFrm.Controls.Add(this.btnAceptar);
            this.pnlContFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContFrm.Controls.Add(this.BtnGuardarCambios);
            this.pnlContFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContFrm.Name = "pnlContFrm";
            this.pnlContFrm.Size = new System.Drawing.Size(365, 202);
            this.pnlContFrm.TabIndex = 0;
            // 
            // gpbCocina
            // 
            this.gpbCocina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbCocina.Controls.Add(this.rbnCocinaNo);
            this.gpbCocina.Controls.Add(this.rbnCocinaSi);
            this.gpbCocina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gpbCocina.ForeColor = System.Drawing.Color.Gray;
            this.gpbCocina.Location = new System.Drawing.Point(14, 74);
            this.gpbCocina.Name = "gpbCocina";
            this.gpbCocina.Size = new System.Drawing.Size(338, 59);
            this.gpbCocina.TabIndex = 43;
            this.gpbCocina.TabStop = false;
            this.gpbCocina.Text = "Los articulos seran enviados a cocina";
            // 
            // rbnCocinaNo
            // 
            this.rbnCocinaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbnCocinaNo.AutoSize = true;
            this.rbnCocinaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnCocinaNo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnCocinaNo.Location = new System.Drawing.Point(53, 26);
            this.rbnCocinaNo.Name = "rbnCocinaNo";
            this.rbnCocinaNo.Size = new System.Drawing.Size(48, 22);
            this.rbnCocinaNo.TabIndex = 33;
            this.rbnCocinaNo.Text = "No";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnCocinaNo, "Indica que no se enviaran a cocina los articulos incluidos en esta categoria");
            this.rbnCocinaNo.UseVisualStyleBackColor = true;
            // 
            // rbnCocinaSi
            // 
            this.rbnCocinaSi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbnCocinaSi.AutoSize = true;
            this.rbnCocinaSi.Checked = true;
            this.rbnCocinaSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnCocinaSi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnCocinaSi.Location = new System.Drawing.Point(6, 26);
            this.rbnCocinaSi.Name = "rbnCocinaSi";
            this.rbnCocinaSi.Size = new System.Drawing.Size(41, 22);
            this.rbnCocinaSi.TabIndex = 32;
            this.rbnCocinaSi.TabStop = true;
            this.rbnCocinaSi.Text = "Si";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnCocinaSi, "Indica que se enviaran a cocina los articulos incluidos en esta categoria");
            this.rbnCocinaSi.UseVisualStyleBackColor = true;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNombreCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtNombreCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCategoria.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreCategoria.Location = new System.Drawing.Point(86, 45);
            this.txtNombreCategoria.MaxLength = 20;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(266, 19);
            this.txtNombreCategoria.TabIndex = 34;
            this.ttpMensajesDeAyuda.SetToolTip(this.txtNombreCategoria, "Nombre de la categoria");
            // 
            // pnlDecorativo1
            // 
            this.pnlDecorativo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDecorativo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo1.Location = new System.Drawing.Point(86, 64);
            this.pnlDecorativo1.Name = "pnlDecorativo1";
            this.pnlDecorativo1.Size = new System.Drawing.Size(266, 2);
            this.pnlDecorativo1.TabIndex = 33;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(11, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 18);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Nombre:";
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
            this.btnAceptar.Location = new System.Drawing.Point(192, 139);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(160, 50);
            this.btnAceptar.TabIndex = 31;
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
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(363, 30);
            this.pnlBarraDeArrastre.TabIndex = 1;
            this.pnlBarraDeArrastre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // lblTituloFrm
            // 
            this.lblTituloFrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTituloFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloFrm.Location = new System.Drawing.Point(41, 0);
            this.lblTituloFrm.Name = "lblTituloFrm";
            this.lblTituloFrm.Size = new System.Drawing.Size(141, 30);
            this.lblTituloFrm.TabIndex = 11;
            this.lblTituloFrm.Text = "Categoria";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picBTNInformacion
            // 
            this.picBTNInformacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNInformacion.Image = global::Procuratio.Properties.Resources._3017955_48;
            this.picBTNInformacion.Location = new System.Drawing.Point(281, 0);
            this.picBTNInformacion.Name = "picBTNInformacion";
            this.picBTNInformacion.Size = new System.Drawing.Size(41, 30);
            this.picBTNInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNInformacion.TabIndex = 4;
            this.picBTNInformacion.TabStop = false;
            this.picBTNInformacion.Click += new System.EventHandler(this.PicBTNInformacion_Click);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar;
            this.picBTNCerrar.Location = new System.Drawing.Point(322, 0);
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
            // tmrColor
            // 
            this.tmrColor.Enabled = true;
            this.tmrColor.Tick += new System.EventHandler(this.TmrColor_Tick);
            // 
            // BtnGuardarCambios
            // 
            this.BtnGuardarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarCambios.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarCambios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGuardarCambios.FlatAppearance.BorderSize = 2;
            this.BtnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarCambios.Location = new System.Drawing.Point(192, 139);
            this.BtnGuardarCambios.Name = "BtnGuardarCambios";
            this.BtnGuardarCambios.Size = new System.Drawing.Size(160, 50);
            this.BtnGuardarCambios.TabIndex = 44;
            this.BtnGuardarCambios.Text = "Guardar cambios";
            this.BtnGuardarCambios.UseVisualStyleBackColor = false;
            this.BtnGuardarCambios.Visible = false;
            this.BtnGuardarCambios.Click += new System.EventHandler(this.BtnGuardarCambios_Click);
            this.BtnGuardarCambios.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.BtnGuardarCambios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // FrmCrearCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(365, 202);
            this.Controls.Add(this.pnlContFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarCategoria";
            this.Load += new System.EventHandler(this.FrmCrearCategoria_Load);
            this.pnlContFrm.ResumeLayout(false);
            this.pnlContFrm.PerformLayout();
            this.gpbCocina.ResumeLayout(false);
            this.gpbCocina.PerformLayout();
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContFrm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Panel pnlDecorativo1;
        private System.Windows.Forms.GroupBox gpbCocina;
        private System.Windows.Forms.RadioButton rbnCocinaNo;
        private System.Windows.Forms.RadioButton rbnCocinaSi;
        private System.Windows.Forms.PictureBox picBTNInformacion;
        private System.Windows.Forms.Timer tmrColor;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Label lblTituloFrm;
        private System.Windows.Forms.Button BtnGuardarCambios;
    }
}