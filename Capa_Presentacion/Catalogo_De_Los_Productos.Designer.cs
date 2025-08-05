namespace Capa_Interfas
{
    partial class Catalogo_De_Los_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo_De_Los_Productos));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            DGVProductos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1160, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 851);
            panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DGVProductos
            // 
            DGVProductos.AllowUserToAddRows = false;
            DGVProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVProductos.BackgroundColor = Color.White;
            DGVProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProductos.Location = new Point(60, 145);
            DGVProductos.Name = "DGVProductos";
            DGVProductos.ReadOnly = true;
            DGVProductos.RowHeadersWidth = 62;
            DGVProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVProductos.Size = new Size(1037, 568);
            DGVProductos.TabIndex = 17;
            DGVProductos.CellContentClick += DGVProductos_CellContentClick;
            // 
            // Catalogo_De_Los_Productos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1317, 851);
            Controls.Add(DGVProductos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Catalogo_De_Los_Productos";
            Text = "Form2";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView DGVProductos;
    }
}