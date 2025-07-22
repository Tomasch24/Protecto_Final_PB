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
            pictureBox1 = new PictureBox();
            iconoCerrarCat = new PictureBox();
            iconoMinimizarCat = new PictureBox();
            pictureBox2 = new PictureBox();
            butHacer_pedido = new Button();
            btnVolMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoCerrarCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizarCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(177, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1015, 674);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // iconoCerrarCat
            // 
            iconoCerrarCat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoCerrarCat.Image = (Image)resources.GetObject("iconoCerrarCat.Image");
            iconoCerrarCat.Location = new Point(1275, 12);
            iconoCerrarCat.Name = "iconoCerrarCat";
            iconoCerrarCat.Size = new Size(30, 30);
            iconoCerrarCat.SizeMode = PictureBoxSizeMode.Zoom;
            iconoCerrarCat.TabIndex = 9;
            iconoCerrarCat.TabStop = false;
            iconoCerrarCat.Click += iconoCerrarCat_Click;
            // 
            // iconoMinimizarCat
            // 
            iconoMinimizarCat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoMinimizarCat.Image = (Image)resources.GetObject("iconoMinimizarCat.Image");
            iconoMinimizarCat.Location = new Point(1239, 12);
            iconoMinimizarCat.Name = "iconoMinimizarCat";
            iconoMinimizarCat.Size = new Size(30, 30);
            iconoMinimizarCat.SizeMode = PictureBoxSizeMode.Zoom;
            iconoMinimizarCat.TabIndex = 12;
            iconoMinimizarCat.TabStop = false;
            iconoMinimizarCat.Click += iconoMinimizarCat_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(379, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(659, 165);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // butHacer_pedido
            // 
            butHacer_pedido.FlatAppearance.BorderSize = 0;
            butHacer_pedido.FlatStyle = FlatStyle.Flat;
            butHacer_pedido.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butHacer_pedido.ForeColor = SystemColors.ButtonHighlight;
            butHacer_pedido.Image = (Image)resources.GetObject("butHacer_pedido.Image");
            butHacer_pedido.ImageAlign = ContentAlignment.MiddleLeft;
            butHacer_pedido.Location = new Point(12, 771);
            butHacer_pedido.Name = "butHacer_pedido";
            butHacer_pedido.Size = new Size(281, 68);
            butHacer_pedido.TabIndex = 14;
            butHacer_pedido.Text = "   Hacer Pedido";
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
            btnVolMenu.Location = new Point(1039, 771);
            btnVolMenu.Name = "btnVolMenu";
            btnVolMenu.Size = new Size(281, 68);
            btnVolMenu.TabIndex = 15;
            btnVolMenu.Text = "      Volver al Menu";
            btnVolMenu.UseVisualStyleBackColor = true;
            btnVolMenu.Click += btnVolMenu_Click;
            // 
            // Catalogo_De_Los_Productos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 160, 100);
            ClientSize = new Size(1317, 851);
            Controls.Add(btnVolMenu);
            Controls.Add(butHacer_pedido);
            Controls.Add(pictureBox2);
            Controls.Add(iconoMinimizarCat);
            Controls.Add(iconoCerrarCat);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Catalogo_De_Los_Productos";
            Text = "Form2";
            Load += Catalogo_De_Los_Productos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoCerrarCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizarCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox iconoCerrarCat;
        private PictureBox iconoMinimizarCat;
        private PictureBox pictureBox2;
        private Button butHacer_pedido;
        private Button btnVolMenu;
    }
}