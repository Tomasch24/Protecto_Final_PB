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
            butHacer_pedido = new Button();
            btnVolMenu = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            DGVProductos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVProductos).BeginInit();
            SuspendLayout();
            // 
            // butHacer_pedido
            // 
            butHacer_pedido.FlatAppearance.BorderSize = 0;
            butHacer_pedido.FlatStyle = FlatStyle.Flat;
            butHacer_pedido.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butHacer_pedido.ForeColor = SystemColors.ButtonHighlight;
            butHacer_pedido.Image = (Image)resources.GetObject("butHacer_pedido.Image");
            butHacer_pedido.ImageAlign = ContentAlignment.MiddleLeft;
            butHacer_pedido.Location = new Point(35, 771);
            butHacer_pedido.Name = "butHacer_pedido";
            butHacer_pedido.Size = new Size(281, 68);
            butHacer_pedido.TabIndex = 14;
            butHacer_pedido.Text = "   Carrito";
            butHacer_pedido.UseVisualStyleBackColor = true;
            butHacer_pedido.Click += butHacer_pedido_Click;
            // 
            // btnVolMenu
            // 
            btnVolMenu.FlatAppearance.BorderSize = 0;
            btnVolMenu.FlatStyle = FlatStyle.Flat;
            btnVolMenu.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolMenu.ForeColor = SystemColors.ButtonHighlight;
            btnVolMenu.Image = (Image)resources.GetObject("btnVolMenu.Image");
            btnVolMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolMenu.Location = new Point(873, 771);
            btnVolMenu.Name = "btnVolMenu";
            btnVolMenu.Size = new Size(281, 68);
            btnVolMenu.TabIndex = 15;
            btnVolMenu.Text = "      Volver al Menu";
            btnVolMenu.UseVisualStyleBackColor = true;
            btnVolMenu.Click += btnVolMenu_Click;
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
            DGVProductos.BackgroundColor = Color.White;
            DGVProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProductos.Location = new Point(85, 158);
            DGVProductos.Name = "DGVProductos";
            DGVProductos.RowHeadersWidth = 62;
            DGVProductos.Size = new Size(995, 523);
            DGVProductos.TabIndex = 17;
            // 
            // Catalogo_De_Los_Productos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(88, 173, 83);
            ClientSize = new Size(1317, 851);
            Controls.Add(DGVProductos);
            Controls.Add(panel1);
            Controls.Add(butHacer_pedido);
            Controls.Add(btnVolMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Catalogo_De_Los_Productos";
            Text = "Form2";
            Load += Catalogo_De_Los_Productos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button butHacer_pedido;
        private Button btnVolMenu;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView DGVProductos;
    }
}