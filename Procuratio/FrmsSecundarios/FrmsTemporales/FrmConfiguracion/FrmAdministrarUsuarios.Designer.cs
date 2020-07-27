namespace Procuratio
{
    partial class FrmAdministrarUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContFrm = new System.Windows.Forms.Panel();
            this.grbUsuarios = new System.Windows.Forms.GroupBox();
            this.rbnUsuariosInactivos = new System.Windows.Forms.RadioButton();
            this.rbnUsuariosActivos = new System.Windows.Forms.RadioButton();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuarios = new System.Windows.Forms.Button();
            this.dgvDatosUsuarios = new System.Windows.Forms.DataGridView();
            this.colID_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccionDeFilas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picBTNInformacion = new System.Windows.Forms.PictureBox();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnRestaurarUsuario = new System.Windows.Forms.Button();
            this.tmrColor = new System.Windows.Forms.Timer(this.components);
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.pnlContFrm.SuspendLayout();
            this.grbUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuarios)).BeginInit();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContFrm
            // 
            this.pnlContFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContFrm.Controls.Add(this.grbUsuarios);
            this.pnlContFrm.Controls.Add(this.btnCrearUsuario);
            this.pnlContFrm.Controls.Add(this.btnEliminarUsuarios);
            this.pnlContFrm.Controls.Add(this.dgvDatosUsuarios);
            this.pnlContFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContFrm.Controls.Add(this.btnRestaurarUsuario);
            this.pnlContFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContFrm.Name = "pnlContFrm";
            this.pnlContFrm.Size = new System.Drawing.Size(942, 556);
            this.pnlContFrm.TabIndex = 0;
            // 
            // grbUsuarios
            // 
            this.grbUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grbUsuarios.Controls.Add(this.rbnUsuariosInactivos);
            this.grbUsuarios.Controls.Add(this.rbnUsuariosActivos);
            this.grbUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grbUsuarios.ForeColor = System.Drawing.Color.Gray;
            this.grbUsuarios.Location = new System.Drawing.Point(771, 460);
            this.grbUsuarios.Name = "grbUsuarios";
            this.grbUsuarios.Size = new System.Drawing.Size(160, 83);
            this.grbUsuarios.TabIndex = 33;
            this.grbUsuarios.TabStop = false;
            this.grbUsuarios.Text = "Ver";
            // 
            // rbnUsuariosInactivos
            // 
            this.rbnUsuariosInactivos.AutoSize = true;
            this.rbnUsuariosInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnUsuariosInactivos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnUsuariosInactivos.Location = new System.Drawing.Point(6, 54);
            this.rbnUsuariosInactivos.Name = "rbnUsuariosInactivos";
            this.rbnUsuariosInactivos.Size = new System.Drawing.Size(93, 22);
            this.rbnUsuariosInactivos.TabIndex = 33;
            this.rbnUsuariosInactivos.Text = "Inactivos";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnUsuariosInactivos, "Ver los usuarios inactivos");
            this.rbnUsuariosInactivos.UseVisualStyleBackColor = true;
            this.rbnUsuariosInactivos.CheckedChanged += new System.EventHandler(this.RbnUsuariosInactivos_CheckedChanged);
            // 
            // rbnUsuariosActivos
            // 
            this.rbnUsuariosActivos.AutoSize = true;
            this.rbnUsuariosActivos.Checked = true;
            this.rbnUsuariosActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbnUsuariosActivos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbnUsuariosActivos.Location = new System.Drawing.Point(6, 26);
            this.rbnUsuariosActivos.Name = "rbnUsuariosActivos";
            this.rbnUsuariosActivos.Size = new System.Drawing.Size(81, 22);
            this.rbnUsuariosActivos.TabIndex = 32;
            this.rbnUsuariosActivos.TabStop = true;
            this.rbnUsuariosActivos.Text = "Activos";
            this.ttpMensajesDeAyuda.SetToolTip(this.rbnUsuariosActivos, "Ver los usuarios activos");
            this.rbnUsuariosActivos.UseVisualStyleBackColor = true;
            this.rbnUsuariosActivos.CheckedChanged += new System.EventHandler(this.RbnUsuariosActivos_CheckedChanged);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrearUsuario.FlatAppearance.BorderSize = 2;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCrearUsuario.Location = new System.Drawing.Point(771, 36);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(160, 50);
            this.btnCrearUsuario.TabIndex = 32;
            this.btnCrearUsuario.Text = "Crear un nuevo usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.BtnCrearUsuario_Click);
            this.btnCrearUsuario.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCrearUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnEliminarUsuarios
            // 
            this.btnEliminarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarUsuarios.FlatAppearance.BorderSize = 2;
            this.btnEliminarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUsuarios.Location = new System.Drawing.Point(771, 92);
            this.btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            this.btnEliminarUsuarios.Size = new System.Drawing.Size(160, 50);
            this.btnEliminarUsuarios.TabIndex = 31;
            this.btnEliminarUsuarios.Text = "Eliminar usuarios seleccionados";
            this.btnEliminarUsuarios.UseVisualStyleBackColor = false;
            this.btnEliminarUsuarios.Click += new System.EventHandler(this.BtnEliminarUsuarios_Click);
            this.btnEliminarUsuarios.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnEliminarUsuarios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // dgvDatosUsuarios
            // 
            this.dgvDatosUsuarios.AllowUserToAddRows = false;
            this.dgvDatosUsuarios.AllowUserToDeleteRows = false;
            this.dgvDatosUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDatosUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvDatosUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosUsuarios.ColumnHeadersHeight = 45;
            this.dgvDatosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatosUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID_Usuario,
            this.colNick,
            this.colNombre,
            this.colApellido,
            this.colPerfil,
            this.colSeleccionDeFilas});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosUsuarios.EnableHeadersVisualStyles = false;
            this.dgvDatosUsuarios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDatosUsuarios.Location = new System.Drawing.Point(11, 36);
            this.dgvDatosUsuarios.Name = "dgvDatosUsuarios";
            this.dgvDatosUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvDatosUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatosUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDatosUsuarios.Size = new System.Drawing.Size(752, 507);
            this.dgvDatosUsuarios.TabIndex = 4;
            this.ttpMensajesDeAyuda.SetToolTip(this.dgvDatosUsuarios, "Datos del usuario");
            this.dgvDatosUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosUsuarios_CellContentClick);
            this.dgvDatosUsuarios.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDatosUsuarios_CellMouseDoubleClick);
            // 
            // colID_Usuario
            // 
            this.colID_Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID_Usuario.HeaderText = "ID_Usuario";
            this.colID_Usuario.Name = "colID_Usuario";
            this.colID_Usuario.ReadOnly = true;
            this.colID_Usuario.Visible = false;
            // 
            // colNick
            // 
            this.colNick.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNick.HeaderText = "Nick";
            this.colNick.Name = "colNick";
            this.colNick.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colPerfil
            // 
            this.colPerfil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPerfil.HeaderText = "Perfil";
            this.colPerfil.Name = "colPerfil";
            this.colPerfil.ReadOnly = true;
            // 
            // colSeleccionDeFilas
            // 
            this.colSeleccionDeFilas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSeleccionDeFilas.HeaderText = "Seleccionar";
            this.colSeleccionDeFilas.Name = "colSeleccionDeFilas";
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
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(940, 30);
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
            this.lblTituloFrm.Text = "Lista de usuarios";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picBTNInformacion
            // 
            this.picBTNInformacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNInformacion.Image = global::Procuratio.Properties.Resources._3017955_48;
            this.picBTNInformacion.Location = new System.Drawing.Point(858, 0);
            this.picBTNInformacion.Name = "picBTNInformacion";
            this.picBTNInformacion.Size = new System.Drawing.Size(41, 30);
            this.picBTNInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNInformacion.TabIndex = 2;
            this.picBTNInformacion.TabStop = false;
            this.picBTNInformacion.Click += new System.EventHandler(this.PicBTNInformacion_Click);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar;
            this.picBTNCerrar.Location = new System.Drawing.Point(899, 0);
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
            // btnRestaurarUsuario
            // 
            this.btnRestaurarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaurarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestaurarUsuario.FlatAppearance.BorderSize = 2;
            this.btnRestaurarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRestaurarUsuario.Location = new System.Drawing.Point(771, 92);
            this.btnRestaurarUsuario.Name = "btnRestaurarUsuario";
            this.btnRestaurarUsuario.Size = new System.Drawing.Size(160, 50);
            this.btnRestaurarUsuario.TabIndex = 34;
            this.btnRestaurarUsuario.Text = "Activar usuarios seleccionados";
            this.btnRestaurarUsuario.UseVisualStyleBackColor = false;
            this.btnRestaurarUsuario.Visible = false;
            this.btnRestaurarUsuario.Click += new System.EventHandler(this.BtnRestaurarUsuario_Click);
            this.btnRestaurarUsuario.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnRestaurarUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // tmrColor
            // 
            this.tmrColor.Enabled = true;
            this.tmrColor.Tick += new System.EventHandler(this.tmrColor_Tick);
            // 
            // FrmAdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(942, 556);
            this.Controls.Add(this.pnlContFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministrarUsuarios";
            this.Load += new System.EventHandler(this.FrmAdministrarUsuarios_Load);
            this.pnlContFrm.ResumeLayout(false);
            this.grbUsuarios.ResumeLayout(false);
            this.grbUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuarios)).EndInit();
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBTNInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContFrm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.PictureBox picBTNInformacion;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DataGridView dgvDatosUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuarios;
        private System.Windows.Forms.Timer tmrColor;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnRestaurarUsuario;
        private System.Windows.Forms.GroupBox grbUsuarios;
        private System.Windows.Forms.RadioButton rbnUsuariosInactivos;
        private System.Windows.Forms.RadioButton rbnUsuariosActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNick;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerfil;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccionDeFilas;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Label lblTituloFrm;
    }
}