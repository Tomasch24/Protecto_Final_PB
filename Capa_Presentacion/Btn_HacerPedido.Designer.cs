namespace Capa_Presentacion
{
    partial class Btn_HacerPedido
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
            lblInformacion = new Label();
            lblProveedor = new Label();
            lblProducto = new Label();
            lblPrecioBase = new Label();
            lblRNC = new Label();
            lblTelefono = new Label();
            lblCantidad = new Label();
            lblTotal = new Label();
            lblConfirmar = new Button();
            btnCancelar = new Button();
            txtRNC = new TextBox();
            txtProveedor = new TextBox();
            txtProducto = new TextBox();
            txtTelefono = new TextBox();
            txtPrecioBase = new TextBox();
            txtCantidad = new TextBox();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformacion.ForeColor = Color.White;
            lblInformacion.Location = new Point(368, 31);
            lblInformacion.Margin = new Padding(4, 0, 4, 0);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(445, 40);
            lblInformacion.TabIndex = 0;
            lblInformacion.Text = "Información del Pedido";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.BackColor = Color.FromArgb(43, 56, 46);
            lblProveedor.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            lblProveedor.ForeColor = Color.White;
            lblProveedor.Location = new Point(127, 151);
            lblProveedor.Margin = new Padding(4, 0, 4, 0);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(139, 26);
            lblProveedor.TabIndex = 1;
            lblProveedor.Text = "Proveedor";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.BackColor = Color.FromArgb(43, 56, 46);
            lblProducto.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            lblProducto.ForeColor = Color.White;
            lblProducto.Location = new Point(127, 205);
            lblProducto.Margin = new Padding(4, 0, 4, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(123, 26);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto";
            // 
            // lblPrecioBase
            // 
            lblPrecioBase.AutoSize = true;
            lblPrecioBase.BackColor = Color.FromArgb(43, 56, 46);
            lblPrecioBase.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            lblPrecioBase.ForeColor = Color.White;
            lblPrecioBase.Location = new Point(127, 307);
            lblPrecioBase.Margin = new Padding(4, 0, 4, 0);
            lblPrecioBase.Name = "lblPrecioBase";
            lblPrecioBase.Size = new Size(199, 26);
            lblPrecioBase.TabIndex = 3;
            lblPrecioBase.Text = "Precio Unitario";
            // 
            // lblRNC
            // 
            lblRNC.AutoSize = true;
            lblRNC.BackColor = Color.FromArgb(43, 56, 46);
            lblRNC.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            lblRNC.ForeColor = Color.White;
            lblRNC.Location = new Point(127, 103);
            lblRNC.Margin = new Padding(4, 0, 4, 0);
            lblRNC.Name = "lblRNC";
            lblRNC.Size = new Size(64, 26);
            lblRNC.TabIndex = 4;
            lblRNC.Text = "RNC";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(43, 56, 46);
            lblTelefono.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(127, 257);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(120, 26);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            lblCantidad.Location = new Point(357, 382);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(214, 25);
            lblCantidad.TabIndex = 7;
            lblCantidad.Text = "Cantidad a Pedir:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            lblTotal.Location = new Point(357, 422);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(175, 25);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total a Pagar:";
            // 
            // lblConfirmar
            // 
            lblConfirmar.BackColor = Color.FromArgb(88, 173, 83);
            lblConfirmar.FlatStyle = FlatStyle.Flat;
            lblConfirmar.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lblConfirmar.ForeColor = SystemColors.Window;
            lblConfirmar.Location = new Point(368, 494);
            lblConfirmar.Margin = new Padding(4, 3, 4, 3);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(146, 34);
            lblConfirmar.TabIndex = 9;
            lblConfirmar.Text = "Confirmar";
            lblConfirmar.UseVisualStyleBackColor = false;
            lblConfirmar.Click += lblConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Verdana", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(628, 494);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 34);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtRNC
            // 
            txtRNC.Location = new Point(446, 103);
            txtRNC.Margin = new Padding(4, 3, 4, 3);
            txtRNC.Name = "txtRNC";
            txtRNC.ReadOnly = true;
            txtRNC.Size = new Size(641, 32);
            txtRNC.TabIndex = 11;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(446, 151);
            txtProveedor.Margin = new Padding(4, 3, 4, 3);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.ReadOnly = true;
            txtProveedor.Size = new Size(641, 32);
            txtProveedor.TabIndex = 12;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(446, 205);
            txtProducto.Margin = new Padding(4, 3, 4, 3);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(641, 32);
            txtProducto.TabIndex = 13;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(446, 257);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(641, 32);
            txtTelefono.TabIndex = 15;
            // 
            // txtPrecioBase
            // 
            txtPrecioBase.Location = new Point(446, 307);
            txtPrecioBase.Margin = new Padding(4, 3, 4, 3);
            txtPrecioBase.Name = "txtPrecioBase";
            txtPrecioBase.ReadOnly = true;
            txtPrecioBase.Size = new Size(641, 32);
            txtPrecioBase.TabIndex = 16;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(628, 379);
            txtCantidad.Margin = new Padding(4, 3, 4, 3);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(194, 32);
            txtCantidad.TabIndex = 17;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(628, 422);
            txtTotal.Margin = new Padding(4, 3, 4, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(194, 32);
            txtTotal.TabIndex = 18;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // Btn_HacerPedido
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 56, 46);
            ClientSize = new Size(1178, 609);
            Controls.Add(txtTotal);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecioBase);
            Controls.Add(txtTelefono);
            Controls.Add(txtProducto);
            Controls.Add(txtProveedor);
            Controls.Add(txtRNC);
            Controls.Add(btnCancelar);
            Controls.Add(lblConfirmar);
            Controls.Add(lblTotal);
            Controls.Add(lblCantidad);
            Controls.Add(lblTelefono);
            Controls.Add(lblRNC);
            Controls.Add(lblPrecioBase);
            Controls.Add(lblProducto);
            Controls.Add(lblProveedor);
            Controls.Add(lblInformacion);
            Font = new Font("Verdana", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Btn_HacerPedido";
            Load += Btn_HacerPedido_Load;
            MouseDown += Btn_HacerPedido_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInformacion;
        private Label lblProveedor;
        private Label lblProducto;
        private Label lblPrecioBase;
        private Label lblRNC;
        private Label lblTelefono;
        private Label lblCantidad;
        private Label lblTotal;
        private Button btnCancelar;
        private TextBox txtRNC;
        private TextBox txtProveedor;
        private TextBox txtProducto;
        private TextBox txtTelefono;
        private TextBox txtPrecioBase;
        private TextBox txtCantidad;
        private TextBox txtTotal;
        public Button lblConfirmar;
    }
}