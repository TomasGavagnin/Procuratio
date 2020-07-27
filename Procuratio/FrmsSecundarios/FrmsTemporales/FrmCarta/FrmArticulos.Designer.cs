namespace Procuratio
{
    partial class FrmArticulo
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
            this.txtPrecioDelivery = new System.Windows.Forms.TextBox();
            this.pnlDecorativo8 = new System.Windows.Forms.Panel();
            this.lblPrecioDelivery = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.pnlDecorativo2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.pnlDecorativo1 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.pnlContenedorFrm.SuspendLayout();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedorFrm
            // 
            this.pnlContenedorFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorFrm.Controls.Add(this.txtPrecioDelivery);
            this.pnlContenedorFrm.Controls.Add(this.pnlDecorativo8);
            this.pnlContenedorFrm.Controls.Add(this.lblPrecioDelivery);
            this.pnlContenedorFrm.Controls.Add(this.txtPrecio);
            this.pnlContenedorFrm.Controls.Add(this.pnlDecorativo2);
            this.pnlContenedorFrm.Controls.Add(this.label1);
            this.pnlContenedorFrm.Controls.Add(this.cmbCategoria);
            this.pnlContenedorFrm.Controls.Add(this.txtDescripcion);
            this.pnlContenedorFrm.Controls.Add(this.lblCategoria);
            this.pnlContenedorFrm.Controls.Add(this.txtNombreArticulo);
            this.pnlContenedorFrm.Controls.Add(this.pnlDecorativo1);
            this.pnlContenedorFrm.Controls.Add(this.lblDescripcion);
            this.pnlContenedorFrm.Controls.Add(this.lblNombre);
            this.pnlContenedorFrm.Controls.Add(this.btnAceptar);
            this.pnlContenedorFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContenedorFrm.Controls.Add(this.btnGuardarCambios);
            this.pnlContenedorFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorFrm.Name = "pnlContenedorFrm";
            this.pnlContenedorFrm.Size = new System.Drawing.Size(493, 346);
            this.pnlContenedorFrm.TabIndex = 0;
            // 
            // txtPrecioDelivery
            // 
            this.txtPrecioDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtPrecioDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioDelivery.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioDelivery.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrecioDelivery.Location = new System.Drawing.Point(131, 253);
            this.txtPrecioDelivery.MaxLength = 6;
            this.txtPrecioDelivery.Name = "txtPrecioDelivery";
            this.txtPrecioDelivery.ShortcutsEnabled = false;
            this.txtPrecioDelivery.Size = new System.Drawing.Size(348, 19);
            this.txtPrecioDelivery.TabIndex = 56;
            this.ttpMensajesDeAyuda.SetToolTip(this.txtPrecioDelivery, "Precio del articulo cuando es delivery");
            this.txtPrecioDelivery.TextChanged += new System.EventHandler(this.TxtPrecioDelivery_TextChanged);
            this.txtPrecioDelivery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioDelivery_KeyPress);
            // 
            // pnlDecorativo8
            // 
            this.pnlDecorativo8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo8.Location = new System.Drawing.Point(131, 272);
            this.pnlDecorativo8.Name = "pnlDecorativo8";
            this.pnlDecorativo8.Size = new System.Drawing.Size(348, 2);
            this.pnlDecorativo8.TabIndex = 55;
            // 
            // lblPrecioDelivery
            // 
            this.lblPrecioDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioDelivery.AutoSize = true;
            this.lblPrecioDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDelivery.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecioDelivery.Location = new System.Drawing.Point(4, 253);
            this.lblPrecioDelivery.Name = "lblPrecioDelivery";
            this.lblPrecioDelivery.Size = new System.Drawing.Size(124, 18);
            this.lblPrecioDelivery.TabIndex = 54;
            this.lblPrecioDelivery.Text = "Precio delivery:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrecio.Location = new System.Drawing.Point(131, 226);
            this.txtPrecio.MaxLength = 6;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ShortcutsEnabled = false;
            this.txtPrecio.Size = new System.Drawing.Size(348, 19);
            this.txtPrecio.TabIndex = 46;
            this.ttpMensajesDeAyuda.SetToolTip(this.txtPrecio, "Precio del articulo");
            this.txtPrecio.TextChanged += new System.EventHandler(this.TxtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // pnlDecorativo2
            // 
            this.pnlDecorativo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo2.Location = new System.Drawing.Point(131, 245);
            this.pnlDecorativo2.Name = "pnlDecorativo2";
            this.pnlDecorativo2.Size = new System.Drawing.Size(348, 2);
            this.pnlDecorativo2.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(24, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Precio carta:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbCategoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(131, 185);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(348, 26);
            this.cmbCategoria.TabIndex = 43;
            this.cmbCategoria.Text = "Categoria";
            this.ttpMensajesDeAyuda.SetToolTip(this.cmbCategoria, "Categoria a la que pertenecera el articulo (tener en cuenta si a esta se la asign" +
        "o para que sea enviados los articulos a cocina  no)");
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDescripcion.Location = new System.Drawing.Point(131, 81);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(348, 91);
            this.txtDescripcion.TabIndex = 42;
            this.ttpMensajesDeAyuda.SetToolTip(this.txtDescripcion, "Descripcion del articulo");
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCategoria.Location = new System.Drawing.Point(42, 189);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(86, 18);
            this.lblCategoria.TabIndex = 40;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtNombreArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreArticulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreArticulo.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreArticulo.Location = new System.Drawing.Point(131, 51);
            this.txtNombreArticulo.MaxLength = 35;
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.ShortcutsEnabled = false;
            this.txtNombreArticulo.Size = new System.Drawing.Size(348, 19);
            this.txtNombreArticulo.TabIndex = 39;
            this.ttpMensajesDeAyuda.SetToolTip(this.txtNombreArticulo, "Nombre del articulo");
            // 
            // pnlDecorativo1
            // 
            this.pnlDecorativo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo1.Location = new System.Drawing.Point(131, 70);
            this.pnlDecorativo1.Name = "pnlDecorativo1";
            this.pnlDecorativo1.Size = new System.Drawing.Size(348, 2);
            this.pnlDecorativo1.TabIndex = 38;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 81);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 18);
            this.lblDescripcion.TabIndex = 37;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(54, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 18);
            this.lblNombre.TabIndex = 34;
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
            this.btnAceptar.Location = new System.Drawing.Point(320, 284);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(160, 50);
            this.btnAceptar.TabIndex = 33;
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
            this.pnlBarraDeArrastre.Controls.Add(this.picBTNCerrar);
            this.pnlBarraDeArrastre.Controls.Add(this.picLogo);
            this.pnlBarraDeArrastre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraDeArrastre.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraDeArrastre.Name = "pnlBarraDeArrastre";
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(491, 30);
            this.pnlBarraDeArrastre.TabIndex = 1;
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
            this.lblTituloFrm.Text = "Datos del articulo";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar;
            this.picBTNCerrar.Location = new System.Drawing.Point(450, 0);
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
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarCambios.FlatAppearance.BorderSize = 2;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(320, 284);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(160, 50);
            this.btnGuardarCambios.TabIndex = 53;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Visible = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.BtnGuardarCambios_Click);
            this.btnGuardarCambios.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnGuardarCambios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(493, 346);
            this.Controls.Add(this.pnlContenedorFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModificaArticulo";
            this.Load += new System.EventHandler(this.FrmModificaArticulo_Load);
            this.pnlContenedorFrm.ResumeLayout(false);
            this.pnlContenedorFrm.PerformLayout();
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorFrm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.Panel pnlDecorativo1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Panel pnlDecorativo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Label lblTituloFrm;
        private System.Windows.Forms.TextBox txtPrecioDelivery;
        private System.Windows.Forms.Panel pnlDecorativo8;
        private System.Windows.Forms.Label lblPrecioDelivery;
    }
}