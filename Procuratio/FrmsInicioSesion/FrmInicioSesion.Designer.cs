namespace Procuratio
{
    partial class FrmInicioSesion
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
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.lblNombreAplicacion = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pblLineaUsuario = new System.Windows.Forms.Panel();
            this.pnlLineaContraseña = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblInicioDeSesion = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.tmrPantallaCarga = new System.Windows.Forms.Timer(this.components);
            this.lblMensajeDeError = new System.Windows.Forms.Label();
            this.picBTNMostrarContraseña = new System.Windows.Forms.PictureBox();
            this.picBTNMinimizar = new System.Windows.Forms.PictureBox();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.pnlContFrm = new System.Windows.Forms.Panel();
            this.pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNMostrarContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            this.pnlIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIzquierdo.Controls.Add(this.lblNombreAplicacion);
            this.pnlIzquierdo.Controls.Add(this.picLogo);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(175, 275);
            this.pnlIzquierdo.TabIndex = 0;
            this.pnlIzquierdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // lblNombreAplicacion
            // 
            this.lblNombreAplicacion.AutoSize = true;
            this.lblNombreAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAplicacion.Location = new System.Drawing.Point(24, 185);
            this.lblNombreAplicacion.Name = "lblNombreAplicacion";
            this.lblNombreAplicacion.Size = new System.Drawing.Size(125, 20);
            this.lblNombreAplicacion.TabIndex = 1;
            this.lblNombreAplicacion.Text = "PROCURATIO";
            this.lblNombreAplicacion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Procuratio.Properties.Resources.Icono_2;
            this.picLogo.Location = new System.Drawing.Point(30, 80);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(112, 101);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // pblLineaUsuario
            // 
            this.pblLineaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblLineaUsuario.Location = new System.Drawing.Point(208, 104);
            this.pblLineaUsuario.Name = "pblLineaUsuario";
            this.pblLineaUsuario.Size = new System.Drawing.Size(285, 2);
            this.pblLineaUsuario.TabIndex = 1;
            // 
            // pnlLineaContraseña
            // 
            this.pnlLineaContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLineaContraseña.Location = new System.Drawing.Point(208, 163);
            this.pnlLineaContraseña.Name = "pnlLineaContraseña";
            this.pnlLineaContraseña.Size = new System.Drawing.Size(285, 2);
            this.pnlLineaContraseña.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(210, 83);
            this.txtUsuario.MaxLength = 18;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(285, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "NOMBRE";
            this.txtUsuario.TextChanged += new System.EventHandler(this.LimpiarlblMensajeDeError);
            this.txtUsuario.Enter += new System.EventHandler(this.BorraTextoTXT_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PresionaEnter);
            this.txtUsuario.Leave += new System.EventHandler(this.ColocaTextoTXT_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(210, 142);
            this.txtContraseña.MaxLength = 18;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(285, 20);
            this.txtContraseña.TabIndex = 6;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.TextChanged += new System.EventHandler(this.LimpiarlblMensajeDeError);
            this.txtContraseña.Enter += new System.EventHandler(this.BorraTextoTXT_Enter);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PresionaEnter);
            this.txtContraseña.Leave += new System.EventHandler(this.ColocaTextoTXT_Leave);
            // 
            // lblInicioDeSesion
            // 
            this.lblInicioDeSesion.AutoSize = true;
            this.lblInicioDeSesion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioDeSesion.ForeColor = System.Drawing.Color.Gray;
            this.lblInicioDeSesion.Location = new System.Drawing.Point(265, 31);
            this.lblInicioDeSesion.Name = "lblInicioDeSesion";
            this.lblInicioDeSesion.Size = new System.Drawing.Size(168, 23);
            this.lblInicioDeSesion.TabIndex = 5;
            this.lblInicioDeSesion.Text = "INICIO DE SESIÓN";
            this.lblInicioDeSesion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(104)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(208, 208);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(287, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // tmrPantallaCarga
            // 
            this.tmrPantallaCarga.Interval = 1000;
            this.tmrPantallaCarga.Tick += new System.EventHandler(this.tmrPantallaCarga_Tick);
            // 
            // lblMensajeDeError
            // 
            this.lblMensajeDeError.AutoSize = true;
            this.lblMensajeDeError.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeDeError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeDeError.Location = new System.Drawing.Point(206, 179);
            this.lblMensajeDeError.Name = "lblMensajeDeError";
            this.lblMensajeDeError.Size = new System.Drawing.Size(213, 16);
            this.lblMensajeDeError.TabIndex = 10;
            this.lblMensajeDeError.Text = "Usuario y/o contraseña invalida";
            this.lblMensajeDeError.Visible = false;
            this.lblMensajeDeError.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // picBTNMostrarContraseña
            // 
            this.picBTNMostrarContraseña.Image = global::Procuratio.Properties.Resources.Ojo_Contraseña;
            this.picBTNMostrarContraseña.Location = new System.Drawing.Point(494, 137);
            this.picBTNMostrarContraseña.Name = "picBTNMostrarContraseña";
            this.picBTNMostrarContraseña.Size = new System.Drawing.Size(30, 28);
            this.picBTNMostrarContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNMostrarContraseña.TabIndex = 11;
            this.picBTNMostrarContraseña.TabStop = false;
            this.picBTNMostrarContraseña.MouseLeave += new System.EventHandler(this.picBTNMostrarContraseña_MouseLeave);
            this.picBTNMostrarContraseña.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBTNMostrarContraseña_MouseMove);
            // 
            // picBTNMinimizar
            // 
            this.picBTNMinimizar.Image = global::Procuratio.Properties.Resources.Minimizar2;
            this.picBTNMinimizar.Location = new System.Drawing.Point(455, 1);
            this.picBTNMinimizar.Name = "picBTNMinimizar";
            this.picBTNMinimizar.Size = new System.Drawing.Size(35, 28);
            this.picBTNMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNMinimizar.TabIndex = 8;
            this.picBTNMinimizar.TabStop = false;
            this.picBTNMinimizar.Click += new System.EventHandler(this.picBTNMinimizar_Click);
            this.picBTNMinimizar.MouseLeave += new System.EventHandler(this.ColorFondoBotones_MouseLeave);
            this.picBTNMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorFondoBotones_MouseMove);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar2;
            this.picBTNCerrar.Location = new System.Drawing.Point(489, 1);
            this.picBTNCerrar.Name = "picBTNCerrar";
            this.picBTNCerrar.Size = new System.Drawing.Size(35, 28);
            this.picBTNCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNCerrar.TabIndex = 7;
            this.picBTNCerrar.TabStop = false;
            this.picBTNCerrar.Click += new System.EventHandler(this.picBTNSalir_Click);
            this.picBTNCerrar.MouseLeave += new System.EventHandler(this.ColorFondoBotones_MouseLeave);
            this.picBTNCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorFondoBotones_MouseMove);
            // 
            // pnlContFrm
            // 
            this.pnlContFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContFrm.Name = "pnlContFrm";
            this.pnlContFrm.Size = new System.Drawing.Size(525, 275);
            this.pnlContFrm.TabIndex = 12;
            this.pnlContFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(525, 275);
            this.Controls.Add(this.picBTNMostrarContraseña);
            this.Controls.Add(this.lblMensajeDeError);
            this.Controls.Add(this.picBTNMinimizar);
            this.Controls.Add(this.picBTNCerrar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblInicioDeSesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pnlLineaContraseña);
            this.Controls.Add(this.pblLineaUsuario);
            this.Controls.Add(this.pnlIzquierdo);
            this.Controls.Add(this.pnlContFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicioSesion";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicioSesion";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNMostrarContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.Panel pblLineaUsuario;
        private System.Windows.Forms.Panel pnlLineaContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblInicioDeSesion;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picBTNMinimizar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNombreAplicacion;
        private System.Windows.Forms.Timer tmrPantallaCarga;
        private System.Windows.Forms.Label lblMensajeDeError;
        private System.Windows.Forms.PictureBox picBTNMostrarContraseña;
        private System.Windows.Forms.Panel pnlContFrm;
    }
}