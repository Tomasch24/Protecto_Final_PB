namespace Capa_Presentacion
{
    partial class Facturacion
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtIdCliente = new TextBox();
            lblRnc = new Label();
            lblTelefono = new Label();
            lblNombre = new Label();
            MtxtRnc = new MaskedTextBox();
            MtxtTelefono = new MaskedTextBox();
            txtNombre = new TextBox();
            dgvFactura = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewButtonColumn();
            gbDatosC = new GroupBox();
            pbBuscarIdCliente = new PictureBox();
            lblIdCliente = new Label();
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            dtpFecha = new DateTimePicker();
            cbTipo = new ComboBox();
            lblProducto = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            lblTipo = new Label();
            lblFecha = new Label();
            btnAgregar = new Button();
            btnGenerarFacturaPDF = new Button();
            gbDatosV = new GroupBox();
            gbInformacionP = new GroupBox();
            pbBuscarIdProducto = new PictureBox();
            txtIdProducto = new TextBox();
            lblIdProducto = new Label();
            nudCantidad = new NumericUpDown();
            label1 = new Label();
            txtStock = new TextBox();
            lblTitulo = new Label();
            lblTotal = new Label();
            lblPago = new Label();
            lblCambio = new Label();
            txtTotal = new TextBox();
            txtPago = new TextBox();
            txtCambio = new TextBox();
            btnFacturar = new Button();
            cbMetodoPago = new ComboBox();
            pbAtrasMP = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            gbDatosC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBuscarIdCliente).BeginInit();
            gbDatosV.SuspendLayout();
            gbInformacionP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBuscarIdProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAtrasMP).BeginInit();
            SuspendLayout();
            // 
            // txtIdCliente
            // 
            txtIdCliente.Enabled = false;
            txtIdCliente.Font = new Font("Verdana", 10F);
            txtIdCliente.Location = new Point(20, 69);
            txtIdCliente.Margin = new Padding(2);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(66, 28);
            txtIdCliente.TabIndex = 0;
            txtIdCliente.KeyPress += txtIdCliente_KeyPress;
            // 
            // lblRnc
            // 
            lblRnc.AutoSize = true;
            lblRnc.BackColor = Color.FromArgb(111, 129, 105);
            lblRnc.Font = new Font("Verdana", 9F);
            lblRnc.ForeColor = Color.White;
            lblRnc.Location = new Point(602, 38);
            lblRnc.Margin = new Padding(2, 0, 2, 0);
            lblRnc.Name = "lblRnc";
            lblRnc.Size = new Size(40, 18);
            lblRnc.TabIndex = 12;
            lblRnc.Text = "RNC";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(111, 129, 105);
            lblTelefono.Font = new Font("Verdana", 9F);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(372, 38);
            lblTelefono.Margin = new Padding(2, 0, 2, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 18);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(111, 129, 105);
            lblNombre.Font = new Font("Verdana", 9F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(136, 39);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 18);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // MtxtRnc
            // 
            MtxtRnc.Enabled = false;
            MtxtRnc.Font = new Font("Verdana", 10F);
            MtxtRnc.Location = new Point(602, 69);
            MtxtRnc.Margin = new Padding(2);
            MtxtRnc.Mask = "000-0000000-0";
            MtxtRnc.Name = "MtxtRnc";
            MtxtRnc.Size = new Size(190, 28);
            MtxtRnc.TabIndex = 5;
            // 
            // MtxtTelefono
            // 
            MtxtTelefono.Enabled = false;
            MtxtTelefono.Font = new Font("Verdana", 10F);
            MtxtTelefono.ForeColor = SystemColors.ControlText;
            MtxtTelefono.Location = new Point(372, 69);
            MtxtTelefono.Margin = new Padding(2);
            MtxtTelefono.Mask = "+1 (999) 000-0000";
            MtxtTelefono.Name = "MtxtTelefono";
            MtxtTelefono.Size = new Size(190, 28);
            MtxtTelefono.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Verdana", 10F);
            txtNombre.Location = new Point(136, 70);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 28);
            txtNombre.TabIndex = 1;
            // 
            // dgvFactura
            // 
            dgvFactura.AllowUserToAddRows = false;
            dgvFactura.AllowUserToDeleteRows = false;
            dgvFactura.AllowUserToResizeColumns = false;
            dgvFactura.AllowUserToResizeRows = false;
            dgvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFactura.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, SubTotal, Descuento, btnEliminar });
            dgvFactura.EnableHeadersVisualStyles = false;
            dgvFactura.Location = new Point(32, 384);
            dgvFactura.Margin = new Padding(2);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.ReadOnly = true;
            dgvFactura.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Green;
            dgvFactura.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvFactura.Size = new Size(1162, 405);
            dgvFactura.TabIndex = 100;
            dgvFactura.CellContentClick += dgvFactura_CellContentClick;
            dgvFactura.CellPainting += dgvFactura_CellPainting;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.MinimumWidth = 8;
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Resizable = DataGridViewTriState.False;
            IdProducto.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 8;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Resizable = DataGridViewTriState.False;
            // 
            // Precio
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle2;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Resizable = DataGridViewTriState.False;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Resizable = DataGridViewTriState.False;
            // 
            // SubTotal
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            SubTotal.DefaultCellStyle = dataGridViewCellStyle3;
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 8;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Resizable = DataGridViewTriState.False;
            // 
            // Descuento
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            Descuento.DefaultCellStyle = dataGridViewCellStyle4;
            Descuento.HeaderText = "Descuento";
            Descuento.MinimumWidth = 8;
            Descuento.Name = "Descuento";
            Descuento.ReadOnly = true;
            Descuento.Resizable = DataGridViewTriState.False;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "";
            btnEliminar.MinimumWidth = 8;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Resizable = DataGridViewTriState.False;
            btnEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // gbDatosC
            // 
            gbDatosC.BackColor = Color.FromArgb(111, 129, 105);
            gbDatosC.Controls.Add(pbBuscarIdCliente);
            gbDatosC.Controls.Add(txtIdCliente);
            gbDatosC.Controls.Add(txtNombre);
            gbDatosC.Controls.Add(lblNombre);
            gbDatosC.Controls.Add(MtxtTelefono);
            gbDatosC.Controls.Add(lblTelefono);
            gbDatosC.Controls.Add(lblIdCliente);
            gbDatosC.Controls.Add(MtxtRnc);
            gbDatosC.Controls.Add(lblRnc);
            gbDatosC.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            gbDatosC.ForeColor = Color.White;
            gbDatosC.Location = new Point(564, 94);
            gbDatosC.Margin = new Padding(2);
            gbDatosC.Name = "gbDatosC";
            gbDatosC.Padding = new Padding(2);
            gbDatosC.Size = new Size(818, 124);
            gbDatosC.TabIndex = 22;
            gbDatosC.TabStop = false;
            gbDatosC.Text = "Datos del Cliente";
            // 
            // pbBuscarIdCliente
            // 
            pbBuscarIdCliente.BackColor = Color.Transparent;
            pbBuscarIdCliente.Enabled = false;
            pbBuscarIdCliente.Image = Properties.Resources.icons8_search_32;
            pbBuscarIdCliente.Location = new Point(89, 69);
            pbBuscarIdCliente.Margin = new Padding(2);
            pbBuscarIdCliente.Name = "pbBuscarIdCliente";
            pbBuscarIdCliente.Size = new Size(24, 29);
            pbBuscarIdCliente.SizeMode = PictureBoxSizeMode.Zoom;
            pbBuscarIdCliente.TabIndex = 13;
            pbBuscarIdCliente.TabStop = false;
            pbBuscarIdCliente.Click += pbBuscarIdCliente_Click;
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.BackColor = Color.FromArgb(111, 129, 105);
            lblIdCliente.Font = new Font("Verdana", 9F);
            lblIdCliente.ForeColor = Color.White;
            lblIdCliente.Location = new Point(20, 38);
            lblIdCliente.Margin = new Padding(2, 0, 2, 0);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(98, 18);
            lblIdCliente.TabIndex = 9;
            lblIdCliente.Text = "Cod. Cliente";
            // 
            // txtProducto
            // 
            txtProducto.Enabled = false;
            txtProducto.Font = new Font("Verdana", 10F);
            txtProducto.Location = new Point(186, 77);
            txtProducto.Margin = new Padding(2);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(190, 28);
            txtProducto.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Font = new Font("Verdana", 10F);
            txtPrecio.Location = new Point(420, 77);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(190, 28);
            txtPrecio.TabIndex = 3;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Enabled = false;
            dtpFecha.Font = new Font("Verdana", 10F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(6, 69);
            dtpFecha.Margin = new Padding(2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(190, 28);
            dtpFecha.TabIndex = 1;
            dtpFecha.TabStop = false;
            // 
            // cbTipo
            // 
            cbTipo.Enabled = false;
            cbTipo.Font = new Font("Verdana", 10F);
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(255, 69);
            cbTipo.Margin = new Padding(2);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(191, 28);
            cbTipo.TabIndex = 7;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.BackColor = Color.FromArgb(111, 129, 105);
            lblProducto.Font = new Font("Verdana", 9F);
            lblProducto.ForeColor = Color.White;
            lblProducto.Location = new Point(186, 42);
            lblProducto.Margin = new Padding(2, 0, 2, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(75, 18);
            lblProducto.TabIndex = 14;
            lblProducto.Text = "Producto";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.FromArgb(111, 129, 105);
            lblPrecio.Font = new Font("Verdana", 9F);
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(420, 42);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 18);
            lblPrecio.TabIndex = 15;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.FromArgb(111, 129, 105);
            lblCantidad.Font = new Font("Verdana", 9F);
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(965, 42);
            lblCantidad.Margin = new Padding(2, 0, 2, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(73, 18);
            lblCantidad.TabIndex = 16;
            lblCantidad.Text = "Cantidad";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.FromArgb(111, 129, 105);
            lblTipo.Font = new Font("Verdana", 9F);
            lblTipo.ForeColor = Color.White;
            lblTipo.Location = new Point(255, 38);
            lblTipo.Margin = new Padding(2, 0, 2, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 18);
            lblTipo.TabIndex = 17;
            lblTipo.Text = "Tipo";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.FromArgb(111, 129, 105);
            lblFecha.Font = new Font("Verdana", 9F);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(6, 38);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(52, 18);
            lblFecha.TabIndex = 19;
            lblFecha.Text = "Fecha";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(41, 76, 37);
            btnAgregar.Enabled = false;
            btnAgregar.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.icons8_plus_math_64__1_;
            btnAgregar.ImageAlign = ContentAlignment.TopCenter;
            btnAgregar.Location = new Point(1220, 247);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(162, 90);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.BottomCenter;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGenerarFacturaPDF
            // 
            btnGenerarFacturaPDF.BackColor = Color.Red;
            btnGenerarFacturaPDF.ForeColor = Color.White;
            btnGenerarFacturaPDF.Location = new Point(1220, 606);
            btnGenerarFacturaPDF.Margin = new Padding(2);
            btnGenerarFacturaPDF.Name = "btnGenerarFacturaPDF";
            btnGenerarFacturaPDF.Size = new Size(151, 41);
            btnGenerarFacturaPDF.TabIndex = 22;
            btnGenerarFacturaPDF.Text = "Generar Factura PDF";
            btnGenerarFacturaPDF.UseVisualStyleBackColor = false;
            btnGenerarFacturaPDF.Click += btnGenerarFacturaPDF_Click;
            // 
            // gbDatosV
            // 
            gbDatosV.BackColor = Color.FromArgb(111, 129, 105);
            gbDatosV.Controls.Add(cbTipo);
            gbDatosV.Controls.Add(lblTipo);
            gbDatosV.Controls.Add(lblFecha);
            gbDatosV.Controls.Add(dtpFecha);
            gbDatosV.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            gbDatosV.ForeColor = Color.White;
            gbDatosV.Location = new Point(32, 94);
            gbDatosV.Margin = new Padding(2);
            gbDatosV.Name = "gbDatosV";
            gbDatosV.Padding = new Padding(2);
            gbDatosV.Size = new Size(509, 124);
            gbDatosV.TabIndex = 23;
            gbDatosV.TabStop = false;
            gbDatosV.Text = "Datos de Venta";
            // 
            // gbInformacionP
            // 
            gbInformacionP.BackColor = Color.FromArgb(111, 129, 105);
            gbInformacionP.Controls.Add(pbBuscarIdProducto);
            gbInformacionP.Controls.Add(txtIdProducto);
            gbInformacionP.Controls.Add(lblIdProducto);
            gbInformacionP.Controls.Add(nudCantidad);
            gbInformacionP.Controls.Add(label1);
            gbInformacionP.Controls.Add(txtStock);
            gbInformacionP.Controls.Add(lblCantidad);
            gbInformacionP.Controls.Add(lblPrecio);
            gbInformacionP.Controls.Add(lblProducto);
            gbInformacionP.Controls.Add(txtProducto);
            gbInformacionP.Controls.Add(txtPrecio);
            gbInformacionP.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            gbInformacionP.ForeColor = Color.White;
            gbInformacionP.Location = new Point(32, 235);
            gbInformacionP.Margin = new Padding(2);
            gbInformacionP.Name = "gbInformacionP";
            gbInformacionP.Padding = new Padding(2);
            gbInformacionP.Size = new Size(1162, 120);
            gbInformacionP.TabIndex = 24;
            gbInformacionP.TabStop = false;
            gbInformacionP.Text = "Informacion del Producto";
            // 
            // pbBuscarIdProducto
            // 
            pbBuscarIdProducto.BackColor = Color.Transparent;
            pbBuscarIdProducto.Enabled = false;
            pbBuscarIdProducto.Image = Properties.Resources.icons8_search_32;
            pbBuscarIdProducto.Location = new Point(6, 78);
            pbBuscarIdProducto.Margin = new Padding(2);
            pbBuscarIdProducto.Name = "pbBuscarIdProducto";
            pbBuscarIdProducto.Size = new Size(24, 29);
            pbBuscarIdProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pbBuscarIdProducto.TabIndex = 23;
            pbBuscarIdProducto.TabStop = false;
            pbBuscarIdProducto.Click += pbBuscarIdProducto_Click_1;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Enabled = false;
            txtIdProducto.Font = new Font("Verdana", 10F);
            txtIdProducto.Location = new Point(42, 77);
            txtIdProducto.Margin = new Padding(2);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(85, 28);
            txtIdProducto.TabIndex = 21;
            txtIdProducto.KeyPress += txtIdProducto_KeyPress;
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.BackColor = Color.FromArgb(111, 129, 105);
            lblIdProducto.Font = new Font("Verdana", 9F);
            lblIdProducto.ForeColor = Color.White;
            lblIdProducto.Location = new Point(42, 43);
            lblIdProducto.Margin = new Padding(2, 0, 2, 0);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(115, 18);
            lblIdProducto.TabIndex = 22;
            lblIdProducto.Text = "Cod. Producto";
            // 
            // nudCantidad
            // 
            nudCantidad.Enabled = false;
            nudCantidad.Font = new Font("Verdana", 10F);
            nudCantidad.Location = new Point(965, 78);
            nudCantidad.Margin = new Padding(2);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(189, 28);
            nudCantidad.TabIndex = 20;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(111, 129, 105);
            label1.Font = new Font("Verdana", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(698, 42);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 19;
            label1.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Enabled = false;
            txtStock.Font = new Font("Verdana", 10F);
            txtStock.Location = new Point(698, 77);
            txtStock.Margin = new Padding(2);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(190, 28);
            txtStock.TabIndex = 18;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(111, 129, 105);
            lblTitulo.Location = new Point(32, 28);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(162, 45);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "VENTA";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(111, 129, 105);
            lblTotal.Font = new Font("Verdana", 9F);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(1220, 394);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(104, 18);
            lblTotal.TabIndex = 25;
            lblTotal.Text = "Total a Pagar";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.BackColor = Color.FromArgb(111, 129, 105);
            lblPago.Font = new Font("Verdana", 9F);
            lblPago.ForeColor = Color.White;
            lblPago.Location = new Point(1220, 468);
            lblPago.Margin = new Padding(2, 0, 2, 0);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(130, 18);
            lblPago.TabIndex = 26;
            lblPago.Text = "Metodo de Pago";
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.BackColor = Color.FromArgb(111, 129, 105);
            lblCambio.Font = new Font("Verdana", 9F);
            lblCambio.ForeColor = Color.White;
            lblCambio.Location = new Point(1220, 539);
            lblCambio.Margin = new Padding(2, 0, 2, 0);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(65, 18);
            lblCambio.TabIndex = 27;
            lblCambio.Text = "Cambio";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Verdana", 10F);
            txtTotal.Location = new Point(1220, 419);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(146, 28);
            txtTotal.TabIndex = 101;
            txtTotal.KeyPress += txtTotal_KeyPress;
            // 
            // txtPago
            // 
            txtPago.Font = new Font("Verdana", 10F);
            txtPago.Location = new Point(1220, 493);
            txtPago.Margin = new Padding(2);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(146, 28);
            txtPago.TabIndex = 102;
            txtPago.KeyDown += txtPago_KeyDown_1;
            txtPago.KeyPress += txtPago_KeyPress;
            // 
            // txtCambio
            // 
            txtCambio.Enabled = false;
            txtCambio.Font = new Font("Verdana", 10F);
            txtCambio.Location = new Point(1220, 564);
            txtCambio.Margin = new Padding(2);
            txtCambio.Name = "txtCambio";
            txtCambio.ReadOnly = true;
            txtCambio.Size = new Size(146, 28);
            txtCambio.TabIndex = 103;
            // 
            // btnFacturar
            // 
            btnFacturar.ForeColor = Color.White;
            btnFacturar.Location = new Point(1220, 652);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(151, 41);
            btnFacturar.TabIndex = 104;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = true;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMetodoPago.Enabled = false;
            cbMetodoPago.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Location = new Point(1220, 510);
            cbMetodoPago.Margin = new Padding(2, 2, 2, 2);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(146, 28);
            cbMetodoPago.TabIndex = 105;
            cbMetodoPago.SelectedIndexChanged += cbMetodoPago_SelectedIndexChanged_1;
            // 
            // pbAtrasMP
            // 
            pbAtrasMP.Enabled = false;
            pbAtrasMP.Image = Properties.Resources.Flecha_hacia_atras;
            pbAtrasMP.Location = new Point(1347, 465);
            pbAtrasMP.Margin = new Padding(2, 2, 2, 2);
            pbAtrasMP.Name = "pbAtrasMP";
            pbAtrasMP.Size = new Size(34, 21);
            pbAtrasMP.SizeMode = PictureBoxSizeMode.Zoom;
            pbAtrasMP.TabIndex = 106;
            pbAtrasMP.TabStop = false;
            pbAtrasMP.Click += pbAtrasMP_Click;
            // 
            // Facturacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1429, 822);
            Controls.Add(pbAtrasMP);
            Controls.Add(cbMetodoPago);
            Controls.Add(btnFacturar);
            Controls.Add(txtCambio);
            Controls.Add(txtPago);
            Controls.Add(txtTotal);
            Controls.Add(lblCambio);
            Controls.Add(lblPago);
            Controls.Add(lblTotal);
            Controls.Add(gbInformacionP);
            Controls.Add(btnGenerarFacturaPDF);
            Controls.Add(gbDatosV);
            Controls.Add(btnAgregar);
            Controls.Add(gbDatosC);
            Controls.Add(lblTitulo);
            Controls.Add(dgvFactura);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Facturacion";
            Text = "Facturacion";
            Load += Facturacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            gbDatosC.ResumeLayout(false);
            gbDatosC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBuscarIdCliente).EndInit();
            gbDatosV.ResumeLayout(false);
            gbDatosV.PerformLayout();
            gbInformacionP.ResumeLayout(false);
            gbInformacionP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBuscarIdProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAtrasMP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox MtxtRnc;
        private MaskedTextBox MtxtTelefono;
        private TextBox txtNombre;
        private TextBox txtIdCliente;
        private Label lblRnc;
        private Label lblTelefono;
        private Label lblNombre;
        private DataGridView dgvFactura;
        private GroupBox gbDatosC;
        private TextBox txtProducto;
        private TextBox txtPrecio;
        private DateTimePicker dtpFecha;
        private ComboBox cbTipo;
        private Label lblProducto;
        private Label lblPrecio;
        private Label lblCantidad;
        private Label lblTipo;
        private Label lblFecha;
        private Button btnAgregar;
        private Label lblIdCliente;
        private Button btnGenerarFacturaPDF;
        private GroupBox gbDatosV;
        private PictureBox pbBuscarIdCliente;
        private GroupBox gbInformacionP;
        private Label lblTitulo;
        private TextBox txtStock;
        private NumericUpDown nudCantidad;
        private Label label1;
        private Label lblTotal;
        private Label lblPago;
        private Label lblCambio;
        private PictureBox pbBuscarIdProducto;
        private TextBox txtIdProducto;
        private Label lblIdProducto;
        private TextBox txtTotal;
        private TextBox txtPago;
        private TextBox txtCambio;
        private Button btnFacturar;
        private ComboBox cbMetodoPago;
        private PictureBox pbAtrasMP;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewButtonColumn btnEliminar;
    }
}