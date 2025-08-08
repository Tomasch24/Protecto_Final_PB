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
            btnHabilitarCat = new Button();
            pictureBox1 = new PictureBox();
            flpCatalogo = new FlowLayoutPanel();
            lbldescripcion = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnHabilitarCat);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1160, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 851);
            panel1.TabIndex = 16;
            // 
            // btnHabilitarCat
            // 
            btnHabilitarCat.BackColor = Color.FromArgb(111, 129, 105);
            btnHabilitarCat.Dock = DockStyle.Bottom;
            btnHabilitarCat.FlatStyle = FlatStyle.Flat;
            btnHabilitarCat.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHabilitarCat.ForeColor = Color.White;
            btnHabilitarCat.Location = new Point(0, 799);
            btnHabilitarCat.Margin = new Padding(2);
            btnHabilitarCat.Name = "btnHabilitarCat";
            btnHabilitarCat.Size = new Size(158, 52);
            btnHabilitarCat.TabIndex = 19;
            btnHabilitarCat.Text = "Habilitar";
            btnHabilitarCat.UseVisualStyleBackColor = false;
            btnHabilitarCat.Click += btnHabilitarCat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flpCatalogo
            // 
            flpCatalogo.AutoScroll = true;
            flpCatalogo.BackColor = Color.White;
            flpCatalogo.Location = new Point(32, 179);
            flpCatalogo.Margin = new Padding(2);
            flpCatalogo.Name = "flpCatalogo";
            flpCatalogo.Size = new Size(1108, 548);
            flpCatalogo.TabIndex = 17;
            // 
            // lbldescripcion
            // 
            lbldescripcion.AutoSize = true;
            lbldescripcion.Font = new Font("Lucida Sans", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldescripcion.ForeColor = Color.White;
            lbldescripcion.Location = new Point(438, 98);
            lbldescripcion.Margin = new Padding(2, 0, 2, 0);
            lbldescripcion.Name = "lbldescripcion";
            lbldescripcion.Size = new Size(329, 59);
            lbldescripcion.TabIndex = 18;
            lbldescripcion.Text = "CATÁLOGO";
            // 
            // Catalogo_De_Los_Productos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(111, 129, 105);
            ClientSize = new Size(1318, 851);
            Controls.Add(lbldescripcion);
            Controls.Add(flpCatalogo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Catalogo_De_Los_Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Catalogo_De_Los_Productos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flpCatalogo;
        private Label lbldescripcion;
        private Button btnHabilitarCat;
    }
}