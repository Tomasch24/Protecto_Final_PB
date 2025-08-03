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
            btnEliminar = new DataGridViewTextBoxColumn();
            button3 = new Button();
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
            button1 = new Button();
            button6 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            gbDatosC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBuscarIdCliente).BeginInit();
            gbDatosV.SuspendLayout();
            gbInformacionP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBuscarIdProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 9F);
            txtIdCliente.Location = new Point(20, 69);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(82, 31);
            txtIdCliente.TabIndex = 0;
            // 
            // lblRnc
            // 
            lblRnc.AutoSize = true;
            lblRnc.BackColor = Color.FromArgb(88, 173, 83);
            lblRnc.Font = new Font("Verdana", 9F);
            lblRnc.ForeColor = Color.White;
            lblRnc.Location = new Point(677, 37);
            lblRnc.Name = "lblRnc";
            lblRnc.Size = new Size(49, 22);
            lblRnc.TabIndex = 12;
            lblRnc.Text = "RNC";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(88, 173, 83);
            lblTelefono.Font = new Font("Verdana", 9F);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(414, 37);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(85, 22);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(88, 173, 83);
            lblNombre.Font = new Font("Verdana", 9F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(152, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 22);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // MtxtRnc
            // 
            MtxtRnc.Font = new Font("Segoe UI", 9F);
            MtxtRnc.Location = new Point(677, 69);
            MtxtRnc.Name = "MtxtRnc";
            MtxtRnc.Size = new Size(236, 31);
            MtxtRnc.TabIndex = 5;
            // 
            // MtxtTelefono
            // 
            MtxtTelefono.Font = new Font("Segoe UI", 9F);
            MtxtTelefono.ForeColor = SystemColors.ControlText;
            MtxtTelefono.Location = new Point(414, 69);
            MtxtTelefono.Name = "MtxtTelefono";
            MtxtTelefono.Size = new Size(236, 31);
            MtxtTelefono.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(152, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 31);
            txtNombre.TabIndex = 1;
            // 
            // dgvFactura
            // 
            dgvFactura.AllowUserToAddRows = false;
            dgvFactura.AllowUserToDeleteRows = false;
            dgvFactura.AllowUserToResizeColumns = false;
            dgvFactura.AllowUserToResizeRows = false;
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, SubTotal, btnEliminar });
            dgvFactura.EnableHeadersVisualStyles = false;
            dgvFactura.Location = new Point(33, 417);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.ReadOnly = true;
            dgvFactura.RowHeadersWidth = 62;
            dgvFactura.Size = new Size(1079, 405);
            dgvFactura.TabIndex = 100;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.MinimumWidth = 8;
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Width = 169;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 8;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 169;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 170;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 169;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 8;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 169;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "";
            btnEliminar.MinimumWidth = 8;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Width = 169;
            // 
            // button3
            // 
            button3.Location = new Point(1275, 717);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // gbDatosC
            // 
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
            gbDatosC.Location = new Point(558, 94);
            gbDatosC.Name = "gbDatosC";
            gbDatosC.Size = new Size(931, 124);
            gbDatosC.TabIndex = 22;
            gbDatosC.TabStop = false;
            gbDatosC.Text = "Datos del Cliente";
            // 
            // pbBuscarIdCliente
            // 
            pbBuscarIdCliente.BackColor = Color.Transparent;
            pbBuscarIdCliente.Location = new Point(112, 69);
            pbBuscarIdCliente.Name = "pbBuscarIdCliente";
            pbBuscarIdCliente.Size = new Size(30, 36);
            pbBuscarIdCliente.SizeMode = PictureBoxSizeMode.Zoom;
            pbBuscarIdCliente.TabIndex = 13;
            pbBuscarIdCliente.TabStop = false;
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.BackColor = Color.FromArgb(88, 173, 83);
            lblIdCliente.Font = new Font("Verdana", 9F);
            lblIdCliente.ForeColor = Color.White;
            lblIdCliente.Location = new Point(20, 37);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(98, 22);
            lblIdCliente.TabIndex = 9;
            lblIdCliente.Text = "Id Cliente";
            // 
            // txtProducto
            // 
            txtProducto.Font = new Font("Segoe UI", 9F);
            txtProducto.Location = new Point(153, 100);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(236, 31);
            txtProducto.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 9F);
            txtPrecio.Location = new Point(420, 100);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(236, 31);
            txtPrecio.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 9F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(6, 69);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(236, 31);
            dtpFecha.TabIndex = 1;
            // 
            // cbTipo
            // 
            cbTipo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(255, 69);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(238, 33);
            cbTipo.TabIndex = 7;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.BackColor = Color.FromArgb(88, 173, 83);
            lblProducto.Font = new Font("Verdana", 9F);
            lblProducto.ForeColor = Color.White;
            lblProducto.Location = new Point(153, 66);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(89, 22);
            lblProducto.TabIndex = 14;
            lblProducto.Text = "Producto";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.FromArgb(88, 173, 83);
            lblPrecio.Font = new Font("Verdana", 9F);
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(420, 66);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(65, 22);
            lblPrecio.TabIndex = 15;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.FromArgb(88, 173, 83);
            lblCantidad.Font = new Font("Verdana", 9F);
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(965, 66);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(90, 22);
            lblCantidad.TabIndex = 16;
            lblCantidad.Text = "Cantidad";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.FromArgb(88, 173, 83);
            lblTipo.Font = new Font("Verdana", 9F);
            lblTipo.ForeColor = Color.White;
            lblTipo.Location = new Point(255, 37);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(48, 22);
            lblTipo.TabIndex = 17;
            lblTipo.Text = "Tipo";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.FromArgb(88, 173, 83);
            lblFecha.Font = new Font("Verdana", 9F);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(6, 37);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(62, 22);
            lblFecha.TabIndex = 19;
            lblFecha.Text = "Fecha";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(1308, 276);
            button1.Name = "button1";
            button1.Size = new Size(163, 120);
            button1.TabIndex = 20;
            button1.Text = "Agregar";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.MenuBar;
            button6.Location = new Point(1259, 757);
            button6.Name = "button6";
            button6.Size = new Size(142, 51);
            button6.TabIndex = 22;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = false;
            // 
            // gbDatosV
            // 
            gbDatosV.Controls.Add(cbTipo);
            gbDatosV.Controls.Add(lblTipo);
            gbDatosV.Controls.Add(lblFecha);
            gbDatosV.Controls.Add(dtpFecha);
            gbDatosV.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            gbDatosV.ForeColor = Color.White;
            gbDatosV.Location = new Point(33, 94);
            gbDatosV.Name = "gbDatosV";
            gbDatosV.Size = new Size(509, 124);
            gbDatosV.TabIndex = 23;
            gbDatosV.TabStop = false;
            gbDatosV.Text = "Datos de Venta";
            // 
            // gbInformacionP
            // 
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
            gbInformacionP.Location = new Point(33, 246);
            gbInformacionP.Name = "gbInformacionP";
            gbInformacionP.Size = new Size(1217, 150);
            gbInformacionP.TabIndex = 24;
            gbInformacionP.TabStop = false;
            gbInformacionP.Text = "Informacion del Producto";
            // 
            // pbBuscarIdProducto
            // 
            pbBuscarIdProducto.BackColor = Color.Transparent;
            pbBuscarIdProducto.Location = new Point(98, 100);
            pbBuscarIdProducto.Name = "pbBuscarIdProducto";
            pbBuscarIdProducto.Size = new Size(30, 36);
            pbBuscarIdProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pbBuscarIdProducto.TabIndex = 23;
            pbBuscarIdProducto.TabStop = false;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Font = new Font("Segoe UI", 9F);
            txtIdProducto.Location = new Point(6, 100);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(82, 31);
            txtIdProducto.TabIndex = 21;
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.BackColor = Color.FromArgb(88, 173, 83);
            lblIdProducto.Font = new Font("Verdana", 9F);
            lblIdProducto.ForeColor = Color.White;
            lblIdProducto.Location = new Point(6, 68);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(114, 22);
            lblIdProducto.TabIndex = 22;
            lblIdProducto.Text = "Id Producto";
            // 
            // nudCantidad
            // 
            nudCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidad.Location = new Point(965, 101);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(236, 31);
            nudCantidad.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(88, 173, 83);
            label1.Font = new Font("Verdana", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(697, 66);
            label1.Name = "label1";
            label1.Size = new Size(60, 22);
            label1.TabIndex = 19;
            label1.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 9F);
            txtStock.Location = new Point(697, 100);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(236, 31);
            txtStock.TabIndex = 18;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(88, 173, 83);
            lblTitulo.Font = new Font("Lucida Sans", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(57, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(137, 45);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "Venta";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(88, 173, 83);
            lblTotal.Font = new Font("Verdana", 9F);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(1259, 470);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(128, 22);
            lblTotal.TabIndex = 25;
            lblTotal.Text = "Total a Pagar";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.BackColor = Color.FromArgb(88, 173, 83);
            lblPago.Font = new Font("Verdana", 9F);
            lblPago.ForeColor = Color.White;
            lblPago.Location = new Point(1259, 544);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(168, 22);
            lblPago.TabIndex = 26;
            lblPago.Text = "Cliente paga con:";
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.BackColor = Color.FromArgb(88, 173, 83);
            lblCambio.Font = new Font("Verdana", 9F);
            lblCambio.ForeColor = Color.White;
            lblCambio.Location = new Point(1259, 615);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(79, 22);
            lblCambio.TabIndex = 27;
            lblCambio.Text = "Cambio";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1259, 495);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(168, 31);
            txtTotal.TabIndex = 101;
            // 
            // txtPago
            // 
            txtPago.Location = new Point(1259, 569);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(168, 31);
            txtPago.TabIndex = 102;
            // 
            // txtCambio
            // 
            txtCambio.Location = new Point(1259, 640);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(168, 31);
            txtCambio.TabIndex = 103;
            // 
            // Facturacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(88, 173, 83);
            ClientSize = new Size(1504, 841);
            Controls.Add(txtCambio);
            Controls.Add(txtPago);
            Controls.Add(txtTotal);
            Controls.Add(lblCambio);
            Controls.Add(lblPago);
            Controls.Add(lblTotal);
            Controls.Add(gbInformacionP);
            Controls.Add(button6);
            Controls.Add(gbDatosV);
            Controls.Add(button1);
            Controls.Add(gbDatosC);
            Controls.Add(lblTitulo);
            Controls.Add(button3);
            Controls.Add(dgvFactura);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
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
        private Button button3;
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
        private Button button1;
        private Label lblIdCliente;
        private Button button6;
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
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn btnEliminar;
        private TextBox txtTotal;
        private TextBox txtPago;
        private TextBox txtCambio;
    }
}