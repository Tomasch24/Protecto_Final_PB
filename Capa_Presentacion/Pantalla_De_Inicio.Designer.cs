namespace Capa_Interfas
{
    partial class Pantalla_De_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_De_Inicio));
            butCatalogo = new Button();
            butHacer_pedido = new Button();
            pictureBox1 = new PictureBox();
            iconoMinimizar = new PictureBox();
            iconoCerrar = new PictureBox();
            MenuVertical = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            btnSlide = new PictureBox();
            BarraTitulo = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSlide).BeginInit();
            BarraTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // butCatalogo
            // 
            butCatalogo.FlatAppearance.BorderSize = 0;
            butCatalogo.FlatStyle = FlatStyle.Flat;
            butCatalogo.Font = new Font("Calibri", 14F, FontStyle.Bold);
            butCatalogo.ForeColor = SystemColors.ButtonHighlight;
            butCatalogo.Image = (Image)resources.GetObject("butCatalogo.Image");
            butCatalogo.ImageAlign = ContentAlignment.MiddleLeft;
            butCatalogo.Location = new Point(3, 240);
            butCatalogo.Name = "butCatalogo";
            butCatalogo.Size = new Size(307, 68);
            butCatalogo.TabIndex = 0;
            butCatalogo.Text = "Catalogo";
            butCatalogo.UseVisualStyleBackColor = true;
            butCatalogo.Click += button1_Click;
            // 
            // butHacer_pedido
            // 
            butHacer_pedido.FlatAppearance.BorderSize = 0;
            butHacer_pedido.FlatStyle = FlatStyle.Flat;
            butHacer_pedido.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butHacer_pedido.ForeColor = SystemColors.ButtonHighlight;
            butHacer_pedido.Image = (Image)resources.GetObject("butHacer_pedido.Image");
            butHacer_pedido.ImageAlign = ContentAlignment.MiddleLeft;
            butHacer_pedido.Location = new Point(-4, 403);
            butHacer_pedido.Name = "butHacer_pedido";
            butHacer_pedido.Size = new Size(281, 68);
            butHacer_pedido.TabIndex = 1;
            butHacer_pedido.Text = "   Hacer Pedido";
            butHacer_pedido.UseVisualStyleBackColor = true;
            butHacer_pedido.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(373, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(864, 573);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // iconoMinimizar
            // 
            iconoMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoMinimizar.Image = (Image)resources.GetObject("iconoMinimizar.Image");
            iconoMinimizar.Location = new Point(1288, 12);
            iconoMinimizar.Name = "iconoMinimizar";
            iconoMinimizar.Size = new Size(30, 30);
            iconoMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconoMinimizar.TabIndex = 6;
            iconoMinimizar.TabStop = false;
            iconoMinimizar.Click += iconoMinimizar_Click;
            // 
            // iconoCerrar
            // 
            iconoCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoCerrar.Image = (Image)resources.GetObject("iconoCerrar.Image");
            iconoCerrar.Location = new Point(1324, 12);
            iconoCerrar.Name = "iconoCerrar";
            iconoCerrar.Size = new Size(30, 30);
            iconoCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            iconoCerrar.TabIndex = 8;
            iconoCerrar.TabStop = false;
            iconoCerrar.Click += iconoCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(120, 160, 100);
            MenuVertical.Controls.Add(button1);
            MenuVertical.Controls.Add(pictureBox2);
            MenuVertical.Controls.Add(butCatalogo);
            MenuVertical.Controls.Add(butHacer_pedido);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(68, 878);
            MenuVertical.TabIndex = 10;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 14F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(10, 566);
            button1.Name = "button1";
            button1.Size = new Size(281, 68);
            button1.TabIndex = 3;
            button1.Text = "Personal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-36, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(369, 210);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnSlide
            // 
            btnSlide.Image = (Image)resources.GetObject("btnSlide.Image");
            btnSlide.Location = new Point(6, 2);
            btnSlide.Name = "btnSlide";
            btnSlide.Size = new Size(45, 45);
            btnSlide.SizeMode = PictureBoxSizeMode.Zoom;
            btnSlide.TabIndex = 5;
            btnSlide.TabStop = false;
            btnSlide.Click += btnSlide_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.Controls.Add(btnSlide);
            BarraTitulo.Controls.Add(iconoCerrar);
            BarraTitulo.Controls.Add(iconoMinimizar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(68, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1366, 50);
            BarraTitulo.TabIndex = 11;
            BarraTitulo.Paint += BarraTitulo_Paint_1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown_1;
            // 
            // Pantalla_De_Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1434, 878);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pantalla_De_Inicio";
            Text = "Form3";
            Load += Pantalla_De_Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSlide).EndInit();
            BarraTitulo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button butCatalogo;
        private Button butHacer_pedido;
        private PictureBox pictureBox1;
        private PictureBox iconoMinimizar;
        private PictureBox iconoCerrar;
        private Panel MenuVertical;
        private PictureBox btnSlide;
        private Panel BarraTitulo;
        private PictureBox pictureBox2;
        private Button button1;
    }
}