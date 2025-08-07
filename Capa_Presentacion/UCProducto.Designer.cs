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
            pbImagenPro.Location = new Point(15, 21);
            pbImagenPro.Name = "pbImagenPro";
            pbImagenPro.Size = new Size(135, 122);
            pbImagenPro.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagenPro.TabIndex = 0;
            pbImagenPro.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(170, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.ForeColor = Color.Black;
            lblPrecio.Location = new Point(170, 64);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.ForeColor = Color.Black;
            lblStock.Location = new Point(170, 118);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(55, 25);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock";
            // 
            // btnAgregarFac
            // 
            btnAgregarFac.BackColor = Color.White;
            btnAgregarFac.Enabled = false;
            btnAgregarFac.ForeColor = Color.Black;
            btnAgregarFac.Location = new Point(76, 169);
            btnAgregarFac.Name = "btnAgregarFac";
            btnAgregarFac.Size = new Size(112, 34);
            btnAgregarFac.TabIndex = 4;
            btnAgregarFac.Text = "Agregar";
            btnAgregarFac.UseVisualStyleBackColor = false;
            btnAgregarFac.Click += btnAgregarFac_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.ForeColor = Color.Black;
            lblID.Location = new Point(171, 89);
            lblID.Name = "lblID";
            lblID.Size = new Size(28, 25);
            lblID.TabIndex = 5;
            lblID.Text = "Id";
            // 
            // UCProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
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
            Name = "UCProducto";
            Size = new Size(456, 229);
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
