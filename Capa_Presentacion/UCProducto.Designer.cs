namespace Capa_Presentacion
{
    partial class UCProducto
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pbImagenPro = new PictureBox();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            btnAgregarFac = new Button();
            lblID = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImagenPro).BeginInit();
            SuspendLayout();
            // 
            // pbImagenPro
            // 
            pbImagenPro.Location = new Point(12, 17);
            pbImagenPro.Margin = new Padding(2, 2, 2, 2);
            pbImagenPro.Name = "pbImagenPro";
            pbImagenPro.Size = new Size(108, 98);
            pbImagenPro.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagenPro.TabIndex = 0;
            pbImagenPro.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(136, 26);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.ForeColor = Color.Black;
            lblPrecio.Location = new Point(136, 51);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.ForeColor = Color.Black;
            lblStock.Location = new Point(136, 94);
            lblStock.Margin = new Padding(2, 0, 2, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock";
            // 
            // btnAgregarFac
            // 
            btnAgregarFac.BackColor = Color.White;
            btnAgregarFac.Enabled = false;
            btnAgregarFac.ForeColor = Color.Black;
            btnAgregarFac.Location = new Point(61, 135);
            btnAgregarFac.Margin = new Padding(2, 2, 2, 2);
            btnAgregarFac.Name = "btnAgregarFac";
            btnAgregarFac.Size = new Size(90, 27);
            btnAgregarFac.TabIndex = 4;
            btnAgregarFac.Text = "Agregar";
            btnAgregarFac.UseVisualStyleBackColor = false;
            btnAgregarFac.Click += btnAgregarFac_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.ForeColor = Color.Black;
            lblID.Location = new Point(137, 71);
            lblID.Margin = new Padding(2, 0, 2, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(22, 20);
            lblID.TabIndex = 5;
            lblID.Text = "Id";
            // 
            // UCProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblID);
            Controls.Add(btnAgregarFac);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(pbImagenPro);
            ForeColor = Color.White;
            Margin = new Padding(2, 2, 2, 2);
            Name = "UCProducto";
            Size = new Size(365, 183);
            Load += UCProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagenPro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImagenPro;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblStock;
        private Button btnAgregarFac;
        private Label lblID;
    }
}
