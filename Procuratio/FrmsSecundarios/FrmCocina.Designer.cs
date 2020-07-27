namespace Procuratio
{
    partial class FrmCocina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblGestionPedidos = new System.Windows.Forms.Label();
            this.dgvListaPedidos = new System.Windows.Forms.DataGridView();
            this.ColID_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEsDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Mozo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMesas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSeleccionDeFilas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPedidoTerminado = new System.Windows.Forms.Button();
            this.lblDetallesDelPedido = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.tmrActualizaPedidos = new System.Windows.Forms.Timer(this.components);
            this.btnForzarActualizacion = new System.Windows.Forms.Button();
            this.dgvPlatosPorMesa = new System.Windows.Forms.DataGridView();
            this.colID_NumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttpMensajesDeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.PtdImprimirTicket = new System.Drawing.Printing.PrintDocument();
            this.ckbImprimirTicketDelivery = new System.Windows.Forms.CheckBox();
            this.lblTextoNumeroPedido = new System.Windows.Forms.Label();
            this.lblMostrarNumeroPedido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatosPorMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionPedidos
            // 
            this.lblGestionPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblGestionPedidos.AutoSize = true;
            this.lblGestionPedidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPedidos.ForeColor = System.Drawing.Color.Gray;
            this.lblGestionPedidos.Location = new System.Drawing.Point(382, 8);
            this.lblGestionPedidos.Name = "lblGestionPedidos";
            this.lblGestionPedidos.Size = new System.Drawing.Size(197, 19);
            this.lblGestionPedidos.TabIndex = 21;
            this.lblGestionPedidos.Text = "GESTION DE LOS PEDIDOS";
            // 
            // dgvListaPedidos
            // 
            this.dgvListaPedidos.AllowUserToAddRows = false;
            this.dgvListaPedidos.AllowUserToDeleteRows = false;
            this.dgvListaPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvListaPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvListaPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaPedidos.ColumnHeadersHeight = 45;
            this.dgvListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID_Pedido,
            this.ColEspera,
            this.ColEsDelivery,
            this.col_Mozo,
            this.ColMesas,
            this.colSeleccionDeFilas});
            this.dgvListaPedidos.EnableHeadersVisualStyles = false;
            this.dgvListaPedidos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvListaPedidos.Location = new System.Drawing.Point(344, 60);
            this.dgvListaPedidos.Name = "dgvListaPedidos";
            this.dgvListaPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaPedidos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvListaPedidos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvListaPedidos.Size = new System.Drawing.Size(417, 493);
            this.dgvListaPedidos.TabIndex = 22;
            this.ttpMensajesDeAyuda.SetToolTip(this.dgvListaPedidos, "Cola de pedidos pendientes");
            this.dgvListaPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaPedidos_CellClick);
            this.dgvListaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaPedidos_CellContentClick);
            // 
            // ColID_Pedido
            // 
            this.ColID_Pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColID_Pedido.FillWeight = 70F;
            this.ColID_Pedido.HeaderText = "Numero pedido";
            this.ColID_Pedido.Name = "ColID_Pedido";
            this.ColID_Pedido.ReadOnly = true;
            this.ColID_Pedido.Width = 70;
            // 
            // ColEspera
            // 
            this.ColEspera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEspera.FillWeight = 70F;
            this.ColEspera.HeaderText = "Tiempo espera";
            this.ColEspera.Name = "ColEspera";
            this.ColEspera.ReadOnly = true;
            // 
            // ColEsDelivery
            // 
            this.ColEsDelivery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEsDelivery.FillWeight = 70F;
            this.ColEsDelivery.HeaderText = "Es delivery";
            this.ColEsDelivery.Name = "ColEsDelivery";
            this.ColEsDelivery.ReadOnly = true;
            // 
            // col_Mozo
            // 
            this.col_Mozo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Mozo.FillWeight = 110F;
            this.col_Mozo.HeaderText = "Mozo";
            this.col_Mozo.Name = "col_Mozo";
            this.col_Mozo.ReadOnly = true;
            // 
            // ColMesas
            // 
            this.ColMesas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColMesas.FillWeight = 50F;
            this.ColMesas.HeaderText = "Mesa/s";
            this.ColMesas.Name = "ColMesas";
            this.ColMesas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColMesas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColMesas.Width = 50;
            // 
            // colSeleccionDeFilas
            // 
            this.colSeleccionDeFilas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSeleccionDeFilas.FillWeight = 80F;
            this.colSeleccionDeFilas.HeaderText = "Seleccionar";
            this.colSeleccionDeFilas.Name = "colSeleccionDeFilas";
            this.colSeleccionDeFilas.Width = 80;
            // 
            // btnPedidoTerminado
            // 
            this.btnPedidoTerminado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPedidoTerminado.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidoTerminado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPedidoTerminado.FlatAppearance.BorderSize = 2;
            this.btnPedidoTerminado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidoTerminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoTerminado.ForeColor = System.Drawing.Color.White;
            this.btnPedidoTerminado.Location = new System.Drawing.Point(768, 60);
            this.btnPedidoTerminado.Name = "btnPedidoTerminado";
            this.btnPedidoTerminado.Size = new System.Drawing.Size(160, 50);
            this.btnPedidoTerminado.TabIndex = 31;
            this.btnPedidoTerminado.Text = "Pedido terminado";
            this.ttpMensajesDeAyuda.SetToolTip(this.btnPedidoTerminado, "Indicar el pedido como terminado para sacarlo de la lista y avisar al mozo que de" +
        "be retirarlo");
            this.btnPedidoTerminado.UseVisualStyleBackColor = false;
            this.btnPedidoTerminado.Click += new System.EventHandler(this.BtnPedidoTerminado_Click);
            this.btnPedidoTerminado.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnPedidoTerminado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // lblDetallesDelPedido
            // 
            this.lblDetallesDelPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetallesDelPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblDetallesDelPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDetallesDelPedido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesDelPedido.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDetallesDelPedido.Location = new System.Drawing.Point(12, 436);
            this.lblDetallesDelPedido.Name = "lblDetallesDelPedido";
            this.lblDetallesDelPedido.Size = new System.Drawing.Size(326, 117);
            this.lblDetallesDelPedido.TabIndex = 33;
            this.ttpMensajesDeAyuda.SetToolTip(this.lblDetallesDelPedido, "Nota de preparacion especial de platos proporcionada por el mozo");
            // 
            // lblNota
            // 
            this.lblNota.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNota.Location = new System.Drawing.Point(34, 413);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(261, 18);
            this.lblNota.TabIndex = 35;
            this.lblNota.Text = "Nota del pedido a tener en cuenta";
            // 
            // tmrActualizaPedidos
            // 
            this.tmrActualizaPedidos.Enabled = true;
            this.tmrActualizaPedidos.Interval = 1000;
            this.tmrActualizaPedidos.Tick += new System.EventHandler(this.TmrActualizaPedidos_Tick);
            // 
            // btnForzarActualizacion
            // 
            this.btnForzarActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForzarActualizacion.BackColor = System.Drawing.Color.Transparent;
            this.btnForzarActualizacion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnForzarActualizacion.FlatAppearance.BorderSize = 2;
            this.btnForzarActualizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForzarActualizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForzarActualizacion.ForeColor = System.Drawing.Color.White;
            this.btnForzarActualizacion.Location = new System.Drawing.Point(768, 116);
            this.btnForzarActualizacion.Name = "btnForzarActualizacion";
            this.btnForzarActualizacion.Size = new System.Drawing.Size(160, 50);
            this.btnForzarActualizacion.TabIndex = 36;
            this.btnForzarActualizacion.Text = "Forzar actualizacion";
            this.ttpMensajesDeAyuda.SetToolTip(this.btnForzarActualizacion, "Los pedidos se actualizan solos, pero puede forzar la actualizacion antes usando " +
        "este boton");
            this.btnForzarActualizacion.UseVisualStyleBackColor = false;
            this.btnForzarActualizacion.Click += new System.EventHandler(this.BtnForzarActualizacion_Click);
            this.btnForzarActualizacion.MouseLeave += new System.EventHandler(this.btnEstiloBotones_Leave);
            this.btnForzarActualizacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstiloBotones_MouseMove);
            // 
            // dgvPlatosPorMesa
            // 
            this.dgvPlatosPorMesa.AllowUserToAddRows = false;
            this.dgvPlatosPorMesa.AllowUserToDeleteRows = false;
            this.dgvPlatosPorMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlatosPorMesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPlatosPorMesa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvPlatosPorMesa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvPlatosPorMesa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlatosPorMesa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlatosPorMesa.ColumnHeadersHeight = 45;
            this.dgvPlatosPorMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlatosPorMesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID_NumeroPedido,
            this.colArticulo,
            this.colDetalle,
            this.colCantidad});
            this.dgvPlatosPorMesa.EnableHeadersVisualStyles = false;
            this.dgvPlatosPorMesa.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPlatosPorMesa.Location = new System.Drawing.Point(12, 60);
            this.dgvPlatosPorMesa.Name = "dgvPlatosPorMesa";
            this.dgvPlatosPorMesa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlatosPorMesa.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPlatosPorMesa.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Brown;
            this.dgvPlatosPorMesa.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPlatosPorMesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPlatosPorMesa.Size = new System.Drawing.Size(326, 348);
            this.dgvPlatosPorMesa.TabIndex = 37;
            this.ttpMensajesDeAyuda.SetToolTip(this.dgvPlatosPorMesa, "Detalle del pedido seleccionado");
            // 
            // colID_NumeroPedido
            // 
            this.colID_NumeroPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colID_NumeroPedido.FillWeight = 80F;
            this.colID_NumeroPedido.HeaderText = "Numero pedido";
            this.colID_NumeroPedido.Name = "colID_NumeroPedido";
            this.colID_NumeroPedido.ReadOnly = true;
            this.colID_NumeroPedido.Visible = false;
            this.colID_NumeroPedido.Width = 75;
            // 
            // colArticulo
            // 
            this.colArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArticulo.FillWeight = 98.47717F;
            this.colArticulo.HeaderText = "Articulo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.ReadOnly = true;
            // 
            // colDetalle
            // 
            this.colDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDetalle.HeaderText = "Detalle";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCantidad.FillWeight = 70F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 70;
            // 
            // ckbImprimirTicketDelivery
            // 
            this.ckbImprimirTicketDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbImprimirTicketDelivery.AutoSize = true;
            this.ckbImprimirTicketDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckbImprimirTicketDelivery.ForeColor = System.Drawing.Color.White;
            this.ckbImprimirTicketDelivery.Location = new System.Drawing.Point(768, 169);
            this.ckbImprimirTicketDelivery.Name = "ckbImprimirTicketDelivery";
            this.ckbImprimirTicketDelivery.Size = new System.Drawing.Size(162, 40);
            this.ckbImprimirTicketDelivery.TabIndex = 38;
            this.ckbImprimirTicketDelivery.Text = "Imprimir ticket de \r\ndelivery";
            this.ckbImprimirTicketDelivery.UseVisualStyleBackColor = true;
            this.ckbImprimirTicketDelivery.Visible = false;
            // 
            // lblTextoNumeroPedido
            // 
            this.lblTextoNumeroPedido.AutoSize = true;
            this.lblTextoNumeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoNumeroPedido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTextoNumeroPedido.Location = new System.Drawing.Point(12, 39);
            this.lblTextoNumeroPedido.Name = "lblTextoNumeroPedido";
            this.lblTextoNumeroPedido.Size = new System.Drawing.Size(151, 18);
            this.lblTextoNumeroPedido.TabIndex = 39;
            this.lblTextoNumeroPedido.Text = "Numero de pedido:";
            // 
            // lblMostrarNumeroPedido
            // 
            this.lblMostrarNumeroPedido.AutoSize = true;
            this.lblMostrarNumeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarNumeroPedido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMostrarNumeroPedido.Location = new System.Drawing.Point(161, 39);
            this.lblMostrarNumeroPedido.Name = "lblMostrarNumeroPedido";
            this.lblMostrarNumeroPedido.Size = new System.Drawing.Size(0, 18);
            this.lblMostrarNumeroPedido.TabIndex = 40;
            // 
            // FrmCocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(935, 565);
            this.Controls.Add(this.lblMostrarNumeroPedido);
            this.Controls.Add(this.lblTextoNumeroPedido);
            this.Controls.Add(this.ckbImprimirTicketDelivery);
            this.Controls.Add(this.dgvPlatosPorMesa);
            this.Controls.Add(this.btnForzarActualizacion);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblDetallesDelPedido);
            this.Controls.Add(this.btnPedidoTerminado);
            this.Controls.Add(this.dgvListaPedidos);
            this.Controls.Add(this.lblGestionPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCocina";
            this.Text = "FrmCocina";
            this.Load += new System.EventHandler(this.FrmCocina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatosPorMesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionPedidos;
        private System.Windows.Forms.DataGridView dgvListaPedidos;
        private System.Windows.Forms.Button btnPedidoTerminado;
        private System.Windows.Forms.Label lblDetallesDelPedido;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Timer tmrActualizaPedidos;
        private System.Windows.Forms.Button btnForzarActualizacion;
        private System.Windows.Forms.DataGridView dgvPlatosPorMesa;
        private System.Windows.Forms.ToolTip ttpMensajesDeAyuda;
        private System.Drawing.Printing.PrintDocument PtdImprimirTicket;
        private System.Windows.Forms.CheckBox ckbImprimirTicketDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEsDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Mozo;
        private System.Windows.Forms.DataGridViewButtonColumn ColMesas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccionDeFilas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_NumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.Label lblTextoNumeroPedido;
        private System.Windows.Forms.Label lblMostrarNumeroPedido;
    }
}