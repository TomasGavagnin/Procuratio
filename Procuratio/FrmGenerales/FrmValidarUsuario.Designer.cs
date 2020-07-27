namespace Procuratio
{
    partial class FrmValidarUsuario
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
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.lblNombreAplicacion = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picBTNMostrarContraseña = new System.Windows.Forms.PictureBox();
            this.lblMensajeDeError = new System.Windows.Forms.Label();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblInicioDeSesion = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.pnlLineaContraseña = new System.Windows.Forms.Panel();
            this.pnlDecorativo4 = new System.Windows.Forms.Panel();
            this.lblUsuariosAutorizados = new System.Windows.Forms.Label();
            this.pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNMostrarContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            this.pnlDecorativo4.SuspendLayout();
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
            this.pnlIzquierdo.Size = new System.Drawing.Size(175, 207);
            this.pnlIzquierdo.TabIndex = 1;
            this.pnlIzquierdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // lblNombreAplicacion
            // 
            this.lblNombreAplicacion.AutoSize = true;
            this.lblNombreAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAplicacion.Location = new System.Drawing.Point(25, 148);
            this.lblNombreAplicacion.Name = "lblNombreAplicacion";
            this.lblNombreAplicacion.Size = new System.Drawing.Size(125, 20);
            this.lblNombreAplicacion.TabIndex = 1;
            this.lblNombreAplicacion.Text = "PROCURATIO";
            this.lblNombreAplicacion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Procuratio.Properties.Resources.Icono_2;
            this.picLogo.Location = new System.Drawing.Point(30, 43);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(112, 101);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // picBTNMostrarContraseña
            // 
            this.picBTNMostrarContraseña.Image = global::Procuratio.Properties.Resources.Ojo_Contraseña;
            this.picBTNMostrarContraseña.Location = new System.Drawing.Point(501, 75);
            this.picBTNMostrarContraseña.Name = "picBTNMostrarContraseña";
            this.picBTNMostrarContraseña.Size = new System.Drawing.Size(35, 28);
            this.picBTNMostrarContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNMostrarContraseña.TabIndex = 21;
            this.picBTNMostrarContraseña.TabStop = false;
            this.picBTNMostrarContraseña.MouseLeave += new System.EventHandler(this.picBTNMostrarContraseña_MouseLeave);
            this.picBTNMostrarContraseña.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBTNMostrarContraseña_MouseMove);
            // 
            // lblMensajeDeError
            // 
            this.lblMensajeDeError.AutoSize = true;
            this.lblMensajeDeError.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeDeError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeDeError.Location = new System.Drawing.Point(205, 108);
            this.lblMensajeDeError.Name = "lblMensajeDeError";
            this.lblMensajeDeError.Size = new System.Drawing.Size(274, 32);
            this.lblMensajeDeError.TabIndex = 20;
            this.lblMensajeDeError.Text = "Contraseña invalida o su usuario no tiene\r\nautorizacion";
            this.lblMensajeDeError.Visible = false;
            this.lblMensajeDeError.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar2;
            this.picBTNCerrar.Location = new System.Drawing.Point(501, -1);
            this.picBTNCerrar.Name = "picBTNCerrar";
            this.picBTNCerrar.Size = new System.Drawing.Size(35, 28);
            this.picBTNCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNCerrar.TabIndex = 18;
            this.picBTNCerrar.TabStop = false;
            this.picBTNCerrar.Click += new System.EventHandler(this.PicBTNCerrar_Click);
            this.picBTNCerrar.MouseLeave += new System.EventHandler(this.ColorFondoBotones_MouseLeave);
            this.picBTNCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorFondoBotones_MouseMove);
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
            this.btnIngresar.Location = new System.Drawing.Point(209, 146);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(287, 23);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // lblInicioDeSesion
            // 
            this.lblInicioDeSesion.AutoSize = true;
            this.lblInicioDeSesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioDeSesion.ForeColor = System.Drawing.Color.Gray;
            this.lblInicioDeSesion.Location = new System.Drawing.Point(182, 39);
            this.lblInicioDeSesion.Name = "lblInicioDeSesion";
            this.lblInicioDeSesion.Size = new System.Drawing.Size(352, 18);
            this.lblInicioDeSesion.TabIndex = 16;
            this.lblInicioDeSesion.Text = "ACCESO SOLO PARA USUARIO AUTORIZADO (*)";
            this.lblInicioDeSesion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(211, 80);
            this.txtContraseña.MaxLength = 18;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(291, 20);
            this.txtContraseña.TabIndex = 17;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.TextChanged += new System.EventHandler(this.LimpiarlblMensajeDeError);
            this.txtContraseña.Enter += new System.EventHandler(this.BorraTextoTXT_Enter);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            this.txtContraseña.Leave += new System.EventHandler(this.ColocaTextoTXT_Leave);
            // 
            // pnlLineaContraseña
            // 
            this.pnlLineaContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLineaContraseña.Location = new System.Drawing.Point(209, 102);
            this.pnlLineaContraseña.Name = "pnlLineaContraseña";
            this.pnlLineaContraseña.Size = new System.Drawing.Size(290, 2);
            this.pnlLineaContraseña.TabIndex = 14;
            // 
            // pnlDecorativo4
            // 
            this.pnlDecorativo4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo4.Controls.Add(this.lblUsuariosAutorizados);
            this.pnlDecorativo4.Controls.Add(this.lblMensajeDeError);
            this.pnlDecorativo4.Controls.Add(this.picBTNCerrar);
            this.pnlDecorativo4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDecorativo4.Location = new System.Drawing.Point(0, 0);
            this.pnlDecorativo4.Name = "pnlDecorativo4";
            this.pnlDecorativo4.Size = new System.Drawing.Size(537, 207);
            this.pnlDecorativo4.TabIndex = 22;
            this.pnlDecorativo4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // lblUsuariosAutorizados
            // 
            this.lblUsuariosAutorizados.AutoSize = true;
            this.lblUsuariosAutorizados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosAutorizados.ForeColor = System.Drawing.Color.Gray;
            this.lblUsuariosAutorizados.Location = new System.Drawing.Point(207, 179);
            this.lblUsuariosAutorizados.Name = "lblUsuariosAutorizados";
            this.lblUsuariosAutorizados.Size = new System.Drawing.Size(185, 16);
            this.lblUsuariosAutorizados.TabIndex = 19;
            this.lblUsuariosAutorizados.Text = "Usuario que tiene autorizacion";
            this.lblUsuariosAutorizados.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // FrmValidarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(537, 207);
            this.Controls.Add(this.picBTNMostrarContraseña);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblInicioDeSesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.pnlLineaContraseña);
            this.Controls.Add(this.pnlIzquierdo);
            this.Controls.Add(this.pnlDecorativo4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmValidarUsuario";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmValidarUsuario";
            this.Enter += new System.EventHandler(this.BorraTextoTXT_Enter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNMostrarContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            this.pnlDecorativo4.ResumeLayout(false);
            this.pnlDecorativo4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.Label lblNombreAplicacion;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picBTNMostrarContraseña;
        private System.Windows.Forms.Label lblMensajeDeError;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblInicioDeSesion;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Panel pnlLineaContraseña;
        private System.Windows.Forms.Panel pnlDecorativo4;
        private System.Windows.Forms.Label lblUsuariosAutorizados;
    }
}