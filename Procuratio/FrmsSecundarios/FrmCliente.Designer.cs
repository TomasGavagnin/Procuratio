namespace Procuratio
{
    partial class FrmCliente
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
            this.pnlContFrm = new System.Windows.Forms.Panel();
            this.PicLuba3 = new System.Windows.Forms.PictureBox();
            this.TxtBuscarPorApellido = new System.Windows.Forms.TextBox();
            this.BtnUsarAsistencias = new System.Windows.Forms.Button();
            this.btnCargarLista = new System.Windows.Forms.Button();
            this.btnMostrarClientesSeleccionados = new System.Windows.Forms.Button();
            this.lblResultadoTotalClientes = new System.Windows.Forms.Label();
            this.btnCancelarSeleccion = new System.Windows.Forms.Button();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.btnCargarClientes = new System.Windows.Forms.Button();
            this.PicLupa2 = new System.Windows.Forms.PictureBox();
            this.TxtBuscarPorTelefono = new System.Windows.Forms.TextBox();
            this.picLupa = new System.Windows.Forms.PictureBox();
            this.txtBuscarPorNombre = new System.Windows.Forms.TextBox();
            this.dgvListarClientes = new System.Windows.Forms.DataGridView();
            this.colID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsistenciasAcumuladas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnviarCliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.pnlBarraDeArrastre = new System.Windows.Forms.Panel();
            this.lblTituloFrm = new System.Windows.Forms.Label();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.flpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlContFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLuba3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLupa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).BeginInit();
            this.pnlBarraDeArrastre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.flpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContFrm
            // 
            this.pnlContFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContFrm.Controls.Add(this.flpBotones);
            this.pnlContFrm.Controls.Add(this.PicLuba3);
            this.pnlContFrm.Controls.Add(this.TxtBuscarPorApellido);
            this.pnlContFrm.Controls.Add(this.btnCargarClientes);
            this.pnlContFrm.Controls.Add(this.PicLupa2);
            this.pnlContFrm.Controls.Add(this.TxtBuscarPorTelefono);
            this.pnlContFrm.Controls.Add(this.picLupa);
            this.pnlContFrm.Controls.Add(this.txtBuscarPorNombre);
            this.pnlContFrm.Controls.Add(this.dgvListarClientes);
            this.pnlContFrm.Controls.Add(this.pnlBarraDeArrastre);
            this.pnlContFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContFrm.Name = "pnlContFrm";
            this.pnlContFrm.Size = new System.Drawing.Size(822, 652);
            this.pnlContFrm.TabIndex = 0;
            // 
            // PicLuba3
            // 
            this.PicLuba3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.PicLuba3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicLuba3.Image = global::Procuratio.Properties.Resources.Lupa;
            this.PicLuba3.Location = new System.Drawing.Point(12, 68);
            this.PicLuba3.Name = "PicLuba3";
            this.PicLuba3.Size = new System.Drawing.Size(29, 26);
            this.PicLuba3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLuba3.TabIndex = 64;
            this.PicLuba3.TabStop = false;
            // 
            // TxtBuscarPorApellido
            // 
            this.TxtBuscarPorApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarPorApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.TxtBuscarPorApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarPorApellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarPorApellido.ForeColor = System.Drawing.Color.DimGray;
            this.TxtBuscarPorApellido.Location = new System.Drawing.Point(40, 68);
            this.TxtBuscarPorApellido.MaxLength = 100;
            this.TxtBuscarPorApellido.Name = "TxtBuscarPorApellido";
            this.TxtBuscarPorApellido.ShortcutsEnabled = false;
            this.TxtBuscarPorApellido.Size = new System.Drawing.Size(603, 26);
            this.TxtBuscarPorApellido.TabIndex = 63;
            this.TxtBuscarPorApellido.Text = "Buscar por apellido de cliente...";
            this.ttpMensajesDeAyuda.SetToolTip(this.TxtBuscarPorApellido, "Filtrar por apellido de cliente");
            this.TxtBuscarPorApellido.TextChanged += new System.EventHandler(this.TxtBuscarPorApellido_TextChanged);
            this.TxtBuscarPorApellido.Enter += new System.EventHandler(this.TxtBuscarPorApellido_Enter);
            this.TxtBuscarPorApellido.Leave += new System.EventHandler(this.TxtBuscarPorApellido_Leave);
            // 
            // BtnUsarAsistencias
            // 
            this.BtnUsarAsistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUsarAsistencias.BackColor = System.Drawing.Color.Transparent;
            this.BtnUsarAsistencias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUsarAsistencias.FlatAppearance.BorderSize = 2;
            this.BtnUsarAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsarAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsarAsistencias.ForeColor = System.Drawing.Color.White;
            this.BtnUsarAsistencias.Location = new System.Drawing.Point(3, 227);
            this.BtnUsarAsistencias.Name = "BtnUsarAsistencias";
            this.BtnUsarAsistencias.Size = new System.Drawing.Size(160, 50);
            this.BtnUsarAsistencias.TabIndex = 62;
            this.BtnUsarAsistencias.Text = "Usar asistencias de los clientes seleccionados";
            this.BtnUsarAsistencias.UseVisualStyleBackColor = false;
            this.BtnUsarAsistencias.Visible = false;
            this.BtnUsarAsistencias.Click += new System.EventHandler(this.BtnUsarAsistencias_Click);
            this.BtnUsarAsistencias.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.BtnUsarAsistencias.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnCargarLista
            // 
            this.btnCargarLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarLista.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarLista.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCargarLista.FlatAppearance.BorderSize = 2;
            this.btnCargarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarLista.ForeColor = System.Drawing.Color.White;
            this.btnCargarLista.Location = new System.Drawing.Point(3, 3);
            this.btnCargarLista.Name = "btnCargarLista";
            this.btnCargarLista.Size = new System.Drawing.Size(160, 50);
            this.btnCargarLista.TabIndex = 61;
            this.btnCargarLista.Text = "Cargar lista de clientes completa";
            this.btnCargarLista.UseVisualStyleBackColor = false;
            this.btnCargarLista.Click += new System.EventHandler(this.BtnCargarLista_Click);
            this.btnCargarLista.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCargarLista.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // btnMostrarClientesSeleccionados
            // 
            this.btnMostrarClientesSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarClientesSeleccionados.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarClientesSeleccionados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrarClientesSeleccionados.FlatAppearance.BorderSize = 2;
            this.btnMostrarClientesSeleccionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarClientesSeleccionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarClientesSeleccionados.ForeColor = System.Drawing.Color.White;
            this.btnMostrarClientesSeleccionados.Location = new System.Drawing.Point(3, 115);
            this.btnMostrarClientesSeleccionados.Name = "btnMostrarClientesSeleccionados";
            this.btnMostrarClientesSeleccionados.Size = new System.Drawing.Size(160, 50);
            this.btnMostrarClientesSeleccionados.TabIndex = 60;
            this.btnMostrarClientesSeleccionados.Text = "Mostrar clientes seleccionados";
            this.btnMostrarClientesSeleccionados.UseVisualStyleBackColor = false;
            this.btnMostrarClientesSeleccionados.Visible = false;
            this.btnMostrarClientesSeleccionados.Click += new System.EventHandler(this.BtnMostrarClientesSeleccionados_Click);
            this.btnMostrarClientesSeleccionados.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnMostrarClientesSeleccionados.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblResultadoTotalClientes
            // 
            this.lblResultadoTotalClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultadoTotalClientes.AutoSize = true;
            this.lblResultadoTotalClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblResultadoTotalClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoTotalClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTotalClientes.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoTotalClientes.Location = new System.Drawing.Point(133, 280);
            this.lblResultadoTotalClientes.Name = "lblResultadoTotalClientes";
            this.lblResultadoTotalClientes.Size = new System.Drawing.Size(21, 22);
            this.lblResultadoTotalClientes.TabIndex = 59;
            this.lblResultadoTotalClientes.Text = "0";
            this.ttpMensajesDeAyuda.SetToolTip(this.lblResultadoTotalClientes, "Capacidad total que es calculada en base a las mesas seleccionadas");
            this.lblResultadoTotalClientes.Visible = false;
            // 
            // btnCancelarSeleccion
            // 
            this.btnCancelarSeleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarSeleccion.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarSeleccion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelarSeleccion.FlatAppearance.BorderSize = 2;
            this.btnCancelarSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSeleccion.ForeColor = System.Drawing.Color.White;
            this.btnCancelarSeleccion.Location = new System.Drawing.Point(3, 171);
            this.btnCancelarSeleccion.Name = "btnCancelarSeleccion";
            this.btnCancelarSeleccion.Size = new System.Drawing.Size(160, 50);
            this.btnCancelarSeleccion.TabIndex = 57;
            this.btnCancelarSeleccion.Text = "Desmarcar los clientes seleccionados";
            this.btnCancelarSeleccion.UseVisualStyleBackColor = false;
            this.btnCancelarSeleccion.Visible = false;
            this.btnCancelarSeleccion.Click += new System.EventHandler(this.BtnCancelarSeleccion_Click);
            this.btnCancelarSeleccion.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCancelarSeleccion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalClientes.Location = new System.Drawing.Point(3, 280);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(124, 18);
            this.lblTotalClientes.TabIndex = 58;
            this.lblTotalClientes.Text = "Seleccionados:";
            this.lblTotalClientes.Visible = false;
            // 
            // btnCargarClientes
            // 
            this.btnCargarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCargarClientes.FlatAppearance.BorderSize = 2;
            this.btnCargarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarClientes.ForeColor = System.Drawing.Color.White;
            this.btnCargarClientes.Location = new System.Drawing.Point(652, 589);
            this.btnCargarClientes.Name = "btnCargarClientes";
            this.btnCargarClientes.Size = new System.Drawing.Size(160, 50);
            this.btnCargarClientes.TabIndex = 56;
            this.btnCargarClientes.Text = "Cargar clientes seleccionados";
            this.btnCargarClientes.UseVisualStyleBackColor = false;
            this.btnCargarClientes.Visible = false;
            this.btnCargarClientes.Click += new System.EventHandler(this.BtnCargarClientes_Click);
            this.btnCargarClientes.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCargarClientes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // PicLupa2
            // 
            this.PicLupa2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.PicLupa2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicLupa2.Image = global::Procuratio.Properties.Resources.Lupa;
            this.PicLupa2.Location = new System.Drawing.Point(12, 99);
            this.PicLupa2.Name = "PicLupa2";
            this.PicLupa2.Size = new System.Drawing.Size(29, 26);
            this.PicLupa2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLupa2.TabIndex = 55;
            this.PicLupa2.TabStop = false;
            // 
            // TxtBuscarPorTelefono
            // 
            this.TxtBuscarPorTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarPorTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.TxtBuscarPorTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarPorTelefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarPorTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.TxtBuscarPorTelefono.Location = new System.Drawing.Point(40, 99);
            this.TxtBuscarPorTelefono.MaxLength = 100;
            this.TxtBuscarPorTelefono.Name = "TxtBuscarPorTelefono";
            this.TxtBuscarPorTelefono.ShortcutsEnabled = false;
            this.TxtBuscarPorTelefono.Size = new System.Drawing.Size(603, 26);
            this.TxtBuscarPorTelefono.TabIndex = 54;
            this.TxtBuscarPorTelefono.Text = "Buscar por telefono de cliente...";
            this.ttpMensajesDeAyuda.SetToolTip(this.TxtBuscarPorTelefono, "Filtrar por telefono de cliente");
            this.TxtBuscarPorTelefono.TextChanged += new System.EventHandler(this.TxtBuscarPorTelefono_TextChanged);
            this.TxtBuscarPorTelefono.Enter += new System.EventHandler(this.TxtBuscarPorTelefono_Enter);
            this.TxtBuscarPorTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarPorTelefono_KeyPress);
            this.TxtBuscarPorTelefono.Leave += new System.EventHandler(this.TxtBuscarPorTelefono_Leave);
            // 
            // picLupa
            // 
            this.picLupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.picLupa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLupa.Image = global::Procuratio.Properties.Resources.Lupa;
            this.picLupa.Location = new System.Drawing.Point(12, 37);
            this.picLupa.Name = "picLupa";
            this.picLupa.Size = new System.Drawing.Size(29, 26);
            this.picLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLupa.TabIndex = 53;
            this.picLupa.TabStop = false;
            // 
            // txtBuscarPorNombre
            // 
            this.txtBuscarPorNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarPorNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtBuscarPorNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPorNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPorNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarPorNombre.Location = new System.Drawing.Point(40, 37);
            this.txtBuscarPorNombre.MaxLength = 100;
            this.txtBuscarPorNombre.Name = "txtBuscarPorNombre";
            this.txtBuscarPorNombre.Size = new System.Drawing.Size(603, 26);
            this.txtBuscarPorNombre.TabIndex = 52;
            this.txtBuscarPorNombre.Text = "Buscar por nombre de cliente...";
            this.ttpMensajesDeAyuda.SetToolTip(this.txtBuscarPorNombre, "Filtrar por nombre de cliente");
            this.txtBuscarPorNombre.TextChanged += new System.EventHandler(this.TxtBuscarPorNombre_TextChanged);
            this.txtBuscarPorNombre.Enter += new System.EventHandler(this.TxtBuscarPorNombre_Enter);
            this.txtBuscarPorNombre.Leave += new System.EventHandler(this.TxtBuscarPorNombre_Leave);
            // 
            // dgvListarClientes
            // 
            this.dgvListarClientes.AllowUserToAddRows = false;
            this.dgvListarClientes.AllowUserToDeleteRows = false;
            this.dgvListarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListarClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListarClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvListarClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvListarClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarClientes.ColumnHeadersHeight = 45;
            this.dgvListarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListarClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID_Cliente,
            this.colNombre,
            this.colApellido,
            this.colTelefono,
            this.colAsistenciasAcumuladas,
            this.colEnviarCliente,
            this.ColSeleccionar});
            this.dgvListarClientes.EnableHeadersVisualStyles = false;
            this.dgvListarClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvListarClientes.Location = new System.Drawing.Point(11, 131);
            this.dgvListarClientes.Name = "dgvListarClientes";
            this.dgvListarClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarClientes.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvListarClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListarClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvListarClientes.Size = new System.Drawing.Size(632, 508);
            this.dgvListarClientes.TabIndex = 51;
            this.ttpMensajesDeAyuda.SetToolTip(this.dgvListarClientes, "Clientes disponibles");
            this.dgvListarClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListarClientes_CellContentClick);
            this.dgvListarClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvListarClientes_CellMouseClick);
            this.dgvListarClientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvListarClientes_CellMouseDoubleClick);
            // 
            // colID_Cliente
            // 
            this.colID_Cliente.HeaderText = "ID_Cliente";
            this.colID_Cliente.Name = "colID_Cliente";
            this.colID_Cliente.ReadOnly = true;
            this.colID_Cliente.Visible = false;
            this.colID_Cliente.Width = 99;
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
            // colTelefono
            // 
            this.colTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // colAsistenciasAcumuladas
            // 
            this.colAsistenciasAcumuladas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAsistenciasAcumuladas.FillWeight = 90F;
            this.colAsistenciasAcumuladas.HeaderText = "Asistencias acumuladas";
            this.colAsistenciasAcumuladas.Name = "colAsistenciasAcumuladas";
            this.colAsistenciasAcumuladas.ReadOnly = true;
            this.colAsistenciasAcumuladas.Width = 90;
            // 
            // colEnviarCliente
            // 
            this.colEnviarCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEnviarCliente.HeaderText = "Enviar cliente";
            this.colEnviarCliente.Name = "colEnviarCliente";
            this.colEnviarCliente.Text = "Enviar";
            this.colEnviarCliente.Width = 88;
            // 
            // ColSeleccionar
            // 
            this.ColSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColSeleccionar.HeaderText = "Seleccionar";
            this.ColSeleccionar.Name = "ColSeleccionar";
            this.ColSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColSeleccionar.Visible = false;
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrearCliente.FlatAppearance.BorderSize = 2;
            this.btnCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCliente.ForeColor = System.Drawing.Color.White;
            this.btnCrearCliente.Location = new System.Drawing.Point(3, 59);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(160, 50);
            this.btnCrearCliente.TabIndex = 50;
            this.btnCrearCliente.Text = "Crear cliente";
            this.btnCrearCliente.UseVisualStyleBackColor = false;
            this.btnCrearCliente.Click += new System.EventHandler(this.BtnCrearCliente_Click);
            this.btnCrearCliente.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnCrearCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
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
            this.pnlBarraDeArrastre.Size = new System.Drawing.Size(820, 30);
            this.pnlBarraDeArrastre.TabIndex = 3;
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
            this.lblTituloFrm.Text = "Lista de clientes";
            this.lblTituloFrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeArrastre_MouseDown);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar;
            this.picBTNCerrar.Location = new System.Drawing.Point(779, 0);
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
            // flpBotones
            // 
            this.flpBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBotones.Controls.Add(this.btnCargarLista);
            this.flpBotones.Controls.Add(this.btnCrearCliente);
            this.flpBotones.Controls.Add(this.btnMostrarClientesSeleccionados);
            this.flpBotones.Controls.Add(this.btnCancelarSeleccion);
            this.flpBotones.Controls.Add(this.BtnUsarAsistencias);
            this.flpBotones.Controls.Add(this.lblTotalClientes);
            this.flpBotones.Controls.Add(this.lblResultadoTotalClientes);
            this.flpBotones.Location = new System.Drawing.Point(649, 131);
            this.flpBotones.Name = "flpBotones";
            this.flpBotones.Size = new System.Drawing.Size(167, 452);
            this.flpBotones.TabIndex = 65;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(822, 652);
            this.Controls.Add(this.pnlContFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.pnlContFrm.ResumeLayout(false);
            this.pnlContFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLuba3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLupa2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).EndInit();
            this.pnlBarraDeArrastre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.flpBotones.ResumeLayout(false);
            this.flpBotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContFrm;
        private System.Windows.Forms.Panel pnlBarraDeArrastre;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.DataGridView dgvListarClientes;
        private System.Windows.Forms.PictureBox picLupa;
        private System.Windows.Forms.TextBox txtBuscarPorNombre;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Windows.Forms.Label lblTituloFrm;
        private System.Windows.Forms.PictureBox PicLupa2;
        private System.Windows.Forms.TextBox TxtBuscarPorTelefono;
        private System.Windows.Forms.Button btnCargarClientes;
        private System.Windows.Forms.Button btnCancelarSeleccion;
        private System.Windows.Forms.Label lblResultadoTotalClientes;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.Button btnMostrarClientesSeleccionados;
        private System.Windows.Forms.Button btnCargarLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsistenciasAcumuladas;
        private System.Windows.Forms.DataGridViewButtonColumn colEnviarCliente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionar;
        private System.Windows.Forms.Button BtnUsarAsistencias;
        private System.Windows.Forms.PictureBox PicLuba3;
        private System.Windows.Forms.TextBox TxtBuscarPorApellido;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
    }
}