namespace Procuratio
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picBTNExpandir = new System.Windows.Forms.PictureBox();
            this.picBTNMinimizar = new System.Windows.Forms.PictureBox();
            this.picBTNReducir = new System.Windows.Forms.PictureBox();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.pnlContFrmPrincipal = new System.Windows.Forms.Panel();
            this.pnlDecorativo4 = new System.Windows.Forms.Panel();
            this.pnlContDeFrmsSecundarios = new System.Windows.Forms.Panel();
            this.pnlContDatos = new System.Windows.Forms.Panel();
            this.stpMostrarDatos = new System.Windows.Forms.StatusStrip();
            this.tslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslTiempoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlDecorativo3 = new System.Windows.Forms.Panel();
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.pnlContBotonesMenu = new System.Windows.Forms.Panel();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.pnlDecorativo1 = new System.Windows.Forms.Panel();
            this.pnlContCerrarSesion = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnMesas = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.pnlContDatosUsuario = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTituloNombreCompleto = new System.Windows.Forms.Label();
            this.picBTNDespliegaMenuVertical = new System.Windows.Forms.PictureBox();
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.pnlDecorativo2 = new System.Windows.Forms.Panel();
            this.tmrActualizarDatos = new System.Windows.Forms.Timer(this.components);
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNExpandir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNReducir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            this.pnlContFrmPrincipal.SuspendLayout();
            this.pnlDecorativo4.SuspendLayout();
            this.pnlContDatos.SuspendLayout();
            this.stpMostrarDatos.SuspendLayout();
            this.pnlMenuVertical.SuspendLayout();
            this.pnlContBotonesMenu.SuspendLayout();
            this.pnlContCerrarSesion.SuspendLayout();
            this.pnlContDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNDespliegaMenuVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraDeArrastre
            // 
            this.pnlBarraDeArrastre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            this.pnlBarraDeArrastre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarraDeArrastre.Controls.Add(this.picLogo);
            this.pnlBarraDeArrastre.Controls.Add(this.picBTNExpandir);
            this.pnlBarraDeArrastre.Controls.Add(this.picBTNMinimizar);
            this.pnlBarraDeArrastre.Controls.Add(this.picBTNReducir);
            this.pnlBarraDeArrastre.Controls.Add(this.picBTNCerrar);
            this.pnlBarraDeArrastre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraDeArrastre.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraDeArrastre.Name = "pnlBarraDeArrastre";
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(1237, 30);
            this.pnlBarraDeArrastre.TabIndex = 1;
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
            // picBTNExpandir
            // 
            this.picBTNExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBTNExpandir.Image = ((System.Drawing.Image)(resources.GetObject("picBTNExpandir.Image")));
            this.picBTNExpandir.Location = new System.Drawing.Point(1165, 0);
            this.picBTNExpandir.Name = "picBTNExpandir";
            this.picBTNExpandir.Size = new System.Drawing.Size(35, 28);
            this.picBTNExpandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNExpandir.TabIndex = 5;
            this.picBTNExpandir.TabStop = false;
            this.picBTNExpandir.Click += new System.EventHandler(this.picBTNExpandirReducir_Click);
            this.picBTNExpandir.MouseLeave += new System.EventHandler(this.ColorFondoBotones_MouseLeave);
            this.picBTNExpandir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorFondoBotones_MouseMove);
            // 
            // picBTNMinimizar
            // 
            this.picBTNMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBTNMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBTNMinimizar.Image")));
            this.picBTNMinimizar.Location = new System.Drawing.Point(1131, 0);
            this.picBTNMinimizar.Name = "picBTNMinimizar";
            this.picBTNMinimizar.Size = new System.Drawing.Size(35, 28);
            this.picBTNMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNMinimizar.TabIndex = 3;
            this.picBTNMinimizar.TabStop = false;
            this.picBTNMinimizar.Click += new System.EventHandler(this.picBTNMinimizar_Click);
            this.picBTNMinimizar.MouseLeave += new System.EventHandler(this.ColorFondoBotones_MouseLeave);
            this.picBTNMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorFondoBotones_MouseMove);
            // 
            // picBTNReducir
            // 
            this.picBTNReducir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBTNReducir.Image = ((System.Drawing.Image)(resources.GetObject("picBTNReducir.Image")));
            this.picBTNReducir.Location = new System.Drawing.Point(1166, 0);
            this.picBTNReducir.Name = "picBTNReducir";
            this.picBTNReducir.Size = new System.Drawing.Size(35, 28);
            this.picBTNReducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNReducir.TabIndex = 2;
            this.picBTNReducir.TabStop = false;
            this.picBTNReducir.Visible = false;
            this.picBTNReducir.Click += new System.EventHandler(this.picBTNExpandirReducir_Click);
            this.picBTNReducir.MouseLeave += new System.EventHandler(this.ColorFondoBotones_MouseLeave);
            this.picBTNReducir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorFondoBotones_MouseMove);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBTNCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picBTNCerrar.Image")));
            this.picBTNCerrar.Location = new System.Drawing.Point(1200, 0);
            this.picBTNCerrar.Name = "picBTNCerrar";
            this.picBTNCerrar.Size = new System.Drawing.Size(35, 28);
            this.picBTNCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNCerrar.TabIndex = 1;
            this.picBTNCerrar.TabStop = false;
            this.picBTNCerrar.Click += new System.EventHandler(this.picBTNCerrar_Click);
            this.picBTNCerrar.MouseLeave += new System.EventHandler(this.ColorFondoBotones_MouseLeave);
            this.picBTNCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorFondoBotones_MouseMove);
            // 
            // pnlContFrmPrincipal
            // 
            this.pnlContFrmPrincipal.AutoSize = true;
            this.pnlContFrmPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.pnlContFrmPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContFrmPrincipal.Controls.Add(this.pnlDecorativo4);
            this.pnlContFrmPrincipal.Controls.Add(this.pnlDecorativo3);
            this.pnlContFrmPrincipal.Controls.Add(this.pnlMenuVertical);
            this.pnlContFrmPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContFrmPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlContFrmPrincipal.Name = "pnlContFrmPrincipal";
            this.pnlContFrmPrincipal.Size = new System.Drawing.Size(1237, 636);
            this.pnlContFrmPrincipal.TabIndex = 2;
            // 
            // pnlDecorativo4
            // 
            this.pnlDecorativo4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo4.Controls.Add(this.pnlContDeFrmsSecundarios);
            this.pnlDecorativo4.Controls.Add(this.pnlContDatos);
            this.pnlDecorativo4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDecorativo4.Location = new System.Drawing.Point(300, 29);
            this.pnlDecorativo4.Name = "pnlDecorativo4";
            this.pnlDecorativo4.Size = new System.Drawing.Size(935, 605);
            this.pnlDecorativo4.TabIndex = 2;
            // 
            // pnlContDeFrmsSecundarios
            // 
            this.pnlContDeFrmsSecundarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContDeFrmsSecundarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContDeFrmsSecundarios.Location = new System.Drawing.Point(0, 0);
            this.pnlContDeFrmsSecundarios.Name = "pnlContDeFrmsSecundarios";
            this.pnlContDeFrmsSecundarios.Size = new System.Drawing.Size(933, 576);
            this.pnlContDeFrmsSecundarios.TabIndex = 1;
            // 
            // pnlContDatos
            // 
            this.pnlContDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContDatos.Controls.Add(this.stpMostrarDatos);
            this.pnlContDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContDatos.Location = new System.Drawing.Point(0, 576);
            this.pnlContDatos.Name = "pnlContDatos";
            this.pnlContDatos.Size = new System.Drawing.Size(933, 27);
            this.pnlContDatos.TabIndex = 0;
            // 
            // stpMostrarDatos
            // 
            this.stpMostrarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.stpMostrarDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stpMostrarDatos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslHora,
            this.tslFecha,
            this.tslTiempoConexion});
            this.stpMostrarDatos.Location = new System.Drawing.Point(0, 0);
            this.stpMostrarDatos.Name = "stpMostrarDatos";
            this.stpMostrarDatos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stpMostrarDatos.Size = new System.Drawing.Size(931, 25);
            this.stpMostrarDatos.SizingGrip = false;
            this.stpMostrarDatos.TabIndex = 0;
            // 
            // tslHora
            // 
            this.tslHora.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tslHora.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tslHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslHora.ForeColor = System.Drawing.Color.Gray;
            this.tslHora.Name = "tslHora";
            this.tslHora.Size = new System.Drawing.Size(52, 20);
            this.tslHora.Text = "Hora";
            // 
            // tslFecha
            // 
            this.tslFecha.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tslFecha.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tslFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslFecha.ForeColor = System.Drawing.Color.Gray;
            this.tslFecha.Name = "tslFecha";
            this.tslFecha.Size = new System.Drawing.Size(63, 20);
            this.tslFecha.Text = "Fecha";
            // 
            // tslTiempoConexion
            // 
            this.tslTiempoConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tslTiempoConexion.ForeColor = System.Drawing.Color.Gray;
            this.tslTiempoConexion.Name = "tslTiempoConexion";
            this.tslTiempoConexion.Size = new System.Drawing.Size(258, 20);
            this.tslTiempoConexion.Text = "Tiempo de conexion = 00:00:00";
            // 
            // pnlDecorativo3
            // 
            this.pnlDecorativo3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDecorativo3.Location = new System.Drawing.Point(300, 0);
            this.pnlDecorativo3.Name = "pnlDecorativo3";
            this.pnlDecorativo3.Size = new System.Drawing.Size(935, 29);
            this.pnlDecorativo3.TabIndex = 1;
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pnlMenuVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuVertical.Controls.Add(this.pnlContBotonesMenu);
            this.pnlMenuVertical.Controls.Add(this.pnlContDatosUsuario);
            this.pnlMenuVertical.Controls.Add(this.pnlDecorativo2);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.ForeColor = System.Drawing.Color.Coral;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(300, 634);
            this.pnlMenuVertical.TabIndex = 0;
            // 
            // pnlContBotonesMenu
            // 
            this.pnlContBotonesMenu.AutoScroll = true;
            this.pnlContBotonesMenu.Controls.Add(this.btnConfiguracion);
            this.pnlContBotonesMenu.Controls.Add(this.pnlDecorativo1);
            this.pnlContBotonesMenu.Controls.Add(this.pnlContCerrarSesion);
            this.pnlContBotonesMenu.Controls.Add(this.btnCaja);
            this.pnlContBotonesMenu.Controls.Add(this.btnMesas);
            this.pnlContBotonesMenu.Controls.Add(this.btnReservas);
            this.pnlContBotonesMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContBotonesMenu.Location = new System.Drawing.Point(0, 77);
            this.pnlContBotonesMenu.Name = "pnlContBotonesMenu";
            this.pnlContBotonesMenu.Size = new System.Drawing.Size(298, 555);
            this.pnlContBotonesMenu.TabIndex = 9;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Image = global::Procuratio.Properties.Resources._48_pixeles__35_largo__imagen_derecha___30_ancho;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 454);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(298, 50);
            this.btnConfiguracion.TabIndex = 12;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            this.btnConfiguracion.MouseLeave += new System.EventHandler(this.ColorBotonesMenuVertical_MouseLeave);
            this.btnConfiguracion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorBotonesMenuVertical_MouseMove);
            // 
            // pnlDecorativo1
            // 
            this.pnlDecorativo1.BackColor = System.Drawing.Color.Gray;
            this.pnlDecorativo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorativo1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDecorativo1.Location = new System.Drawing.Point(0, 504);
            this.pnlDecorativo1.Name = "pnlDecorativo1";
            this.pnlDecorativo1.Size = new System.Drawing.Size(298, 3);
            this.pnlDecorativo1.TabIndex = 17;
            // 
            // pnlContCerrarSesion
            // 
            this.pnlContCerrarSesion.Controls.Add(this.btnCerrarSesion);
            this.pnlContCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContCerrarSesion.Location = new System.Drawing.Point(0, 507);
            this.pnlContCerrarSesion.Name = "pnlContCerrarSesion";
            this.pnlContCerrarSesion.Size = new System.Drawing.Size(298, 48);
            this.pnlContCerrarSesion.TabIndex = 16;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, -2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(298, 50);
            this.btnCerrarSesion.TabIndex = 16;
            this.btnCerrarSesion.Text = "Cerrar sesión actual";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            this.btnCerrarSesion.MouseLeave += new System.EventHandler(this.ColorBotonesMenuVertical_MouseLeave);
            this.btnCerrarSesion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorBotonesMenuVertical_MouseMove);
            // 
            // btnCaja
            // 
            this.btnCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaja.FlatAppearance.BorderSize = 0;
            this.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCaja.ForeColor = System.Drawing.Color.White;
            this.btnCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCaja.Image")));
            this.btnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaja.Location = new System.Drawing.Point(0, 100);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(298, 50);
            this.btnCaja.TabIndex = 11;
            this.btnCaja.Text = "Caja";
            this.btnCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            this.btnCaja.MouseLeave += new System.EventHandler(this.ColorBotonesMenuVertical_MouseLeave);
            this.btnCaja.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorBotonesMenuVertical_MouseMove);
            // 
            // btnMesas
            // 
            this.btnMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMesas.FlatAppearance.BorderSize = 0;
            this.btnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnMesas.ForeColor = System.Drawing.Color.White;
            this.btnMesas.Image = ((System.Drawing.Image)(resources.GetObject("btnMesas.Image")));
            this.btnMesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesas.Location = new System.Drawing.Point(0, 50);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(298, 50);
            this.btnMesas.TabIndex = 10;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMesas.UseVisualStyleBackColor = false;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            this.btnMesas.MouseLeave += new System.EventHandler(this.ColorBotonesMenuVertical_MouseLeave);
            this.btnMesas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorBotonesMenuVertical_MouseMove);
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.Color.White;
            this.btnReservas.Image = ((System.Drawing.Image)(resources.GetObject("btnReservas.Image")));
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.Location = new System.Drawing.Point(0, 0);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(298, 50);
            this.btnReservas.TabIndex = 9;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservas.UseVisualStyleBackColor = false;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            this.btnReservas.MouseLeave += new System.EventHandler(this.ColorBotonesMenuVertical_MouseLeave);
            this.btnReservas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorBotonesMenuVertical_MouseMove);
            // 
            // pnlContDatosUsuario
            // 
            this.pnlContDatosUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContDatosUsuario.Controls.Add(this.lblNombre);
            this.pnlContDatosUsuario.Controls.Add(this.lblUsuario);
            this.pnlContDatosUsuario.Controls.Add(this.lblTituloNombreCompleto);
            this.pnlContDatosUsuario.Controls.Add(this.picBTNDespliegaMenuVertical);
            this.pnlContDatosUsuario.Controls.Add(this.lblTituloUsuario);
            this.pnlContDatosUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContDatosUsuario.Location = new System.Drawing.Point(0, 28);
            this.pnlContDatosUsuario.Name = "pnlContDatosUsuario";
            this.pnlContDatosUsuario.Size = new System.Drawing.Size(298, 49);
            this.pnlContDatosUsuario.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(61, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsuario.Location = new System.Drawing.Point(110, 6);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 15);
            this.lblUsuario.TabIndex = 18;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblTituloNombreCompleto
            // 
            this.lblTituloNombreCompleto.AutoSize = true;
            this.lblTituloNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTituloNombreCompleto.ForeColor = System.Drawing.Color.Gray;
            this.lblTituloNombreCompleto.Location = new System.Drawing.Point(2, 24);
            this.lblTituloNombreCompleto.Name = "lblTituloNombreCompleto";
            this.lblTituloNombreCompleto.Size = new System.Drawing.Size(62, 15);
            this.lblTituloNombreCompleto.TabIndex = 17;
            this.lblTituloNombreCompleto.Text = "Nombre:";
            // 
            // picBTNDespliegaMenuVertical
            // 
            this.picBTNDespliegaMenuVertical.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNDespliegaMenuVertical.Image = ((System.Drawing.Image)(resources.GetObject("picBTNDespliegaMenuVertical.Image")));
            this.picBTNDespliegaMenuVertical.Location = new System.Drawing.Point(251, 0);
            this.picBTNDespliegaMenuVertical.Name = "picBTNDespliegaMenuVertical";
            this.picBTNDespliegaMenuVertical.Size = new System.Drawing.Size(45, 47);
            this.picBTNDespliegaMenuVertical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNDespliegaMenuVertical.TabIndex = 6;
            this.picBTNDespliegaMenuVertical.TabStop = false;
            this.picBTNDespliegaMenuVertical.Click += new System.EventHandler(this.picBTNDespliegaMenuVertical_Click);
            this.picBTNDespliegaMenuVertical.MouseLeave += new System.EventHandler(this.ColorFondoBotones_MouseLeave);
            this.picBTNDespliegaMenuVertical.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorFondoBotones_MouseMove);
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.AutoSize = true;
            this.lblTituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTituloUsuario.ForeColor = System.Drawing.Color.Gray;
            this.lblTituloUsuario.Location = new System.Drawing.Point(2, 6);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(111, 15);
            this.lblTituloUsuario.TabIndex = 7;
            this.lblTituloUsuario.Text = "Tipo de usuario:";
            // 
            // pnlDecorativo2
            // 
            this.pnlDecorativo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDecorativo2.Location = new System.Drawing.Point(0, 0);
            this.pnlDecorativo2.Name = "pnlDecorativo2";
            this.pnlDecorativo2.Size = new System.Drawing.Size(298, 28);
            this.pnlDecorativo2.TabIndex = 7;
            // 
            // tmrActualizarDatos
            // 
            this.tmrActualizarDatos.Enabled = true;
            this.tmrActualizarDatos.Interval = 1000;
            this.tmrActualizarDatos.Tick += new System.EventHandler(this.tmrActualizarDatos_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 636);
            this.Controls.Add(this.pnlBarraDeArrastre);
            this.Controls.Add(this.pnlContFrmPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNExpandir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNReducir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            this.pnlContFrmPrincipal.ResumeLayout(false);
            this.pnlDecorativo4.ResumeLayout(false);
            this.pnlContDatos.ResumeLayout(false);
            this.pnlContDatos.PerformLayout();
            this.stpMostrarDatos.ResumeLayout(false);
            this.stpMostrarDatos.PerformLayout();
            this.pnlMenuVertical.ResumeLayout(false);
            this.pnlContBotonesMenu.ResumeLayout(false);
            this.pnlContCerrarSesion.ResumeLayout(false);
            this.pnlContDatosUsuario.ResumeLayout(false);
            this.pnlContDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNDespliegaMenuVertical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.Panel pnlContFrmPrincipal;
        private System.Windows.Forms.PictureBox picBTNMinimizar;
        private System.Windows.Forms.PictureBox picBTNReducir;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picBTNExpandir;
        private System.Windows.Forms.PictureBox picBTNDespliegaMenuVertical;
        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.Panel pnlContDatosUsuario;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.Label lblTituloNombreCompleto;
        private System.Windows.Forms.Panel pnlDecorativo4;
        private System.Windows.Forms.Panel pnlDecorativo3;
        private System.Windows.Forms.Panel pnlDecorativo2;
        private System.Windows.Forms.Panel pnlContBotonesMenu;
        private System.Windows.Forms.Panel pnlContCerrarSesion;
        private System.Windows.Forms.Panel pnlContDatos;
        private System.Windows.Forms.StatusStrip stpMostrarDatos;
        private System.Windows.Forms.ToolStripStatusLabel tslHora;
        private System.Windows.Forms.ToolStripStatusLabel tslFecha;
        private System.Windows.Forms.Timer tmrActualizarDatos;
        private System.Windows.Forms.Panel pnlContDeFrmsSecundarios;
        private System.Windows.Forms.Panel pnlDecorativo1;
        private System.Windows.Forms.ToolStripStatusLabel tslTiempoConexion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnConfiguracion;
    }
}

