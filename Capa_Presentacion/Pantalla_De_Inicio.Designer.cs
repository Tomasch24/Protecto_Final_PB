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
            iconoMinimizar = new PictureBox();
            iconoCerrar = new PictureBox();
            MenuVertical = new Panel();
            button1 = new Button();
            btnSlide = new PictureBox();
            BarraTitulo = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSlide).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            butCatalogo.Location = new Point(2, 192);
            butCatalogo.Margin = new Padding(2);
            butCatalogo.Name = "butCatalogo";
            butCatalogo.Size = new Size(246, 54);
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
            butHacer_pedido.Location = new Point(-3, 322);
            butHacer_pedido.Margin = new Padding(2);
            butHacer_pedido.Name = "butHacer_pedido";
            butHacer_pedido.Size = new Size(225, 54);
            butHacer_pedido.TabIndex = 1;
            butHacer_pedido.Text = "   Hacer Pedido";
            butHacer_pedido.UseVisualStyleBackColor = true;
            butHacer_pedido.Click += button2_Click;
            // 
            // iconoMinimizar
            // 
            iconoMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoMinimizar.Image = (Image)resources.GetObject("iconoMinimizar.Image");
            iconoMinimizar.Location = new Point(743, 10);
            iconoMinimizar.Margin = new Padding(2);
            iconoMinimizar.Name = "iconoMinimizar";
            iconoMinimizar.Size = new Size(24, 24);
            iconoMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconoMinimizar.TabIndex = 6;
            iconoMinimizar.TabStop = false;
            iconoMinimizar.Click += iconoMinimizar_Click;
            // 
            // iconoCerrar
            // 
            iconoCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoCerrar.Image = (Image)resources.GetObject("iconoCerrar.Image");
            iconoCerrar.Location = new Point(772, 10);
            iconoCerrar.Margin = new Padding(2);
            iconoCerrar.Name = "iconoCerrar";
            iconoCerrar.Size = new Size(24, 24);
            iconoCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            iconoCerrar.TabIndex = 8;
            iconoCerrar.TabStop = false;
            iconoCerrar.Click += iconoCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(41, 76, 37);
            MenuVertical.Controls.Add(label3);
            MenuVertical.Controls.Add(label2);
            MenuVertical.Controls.Add(label1);
            MenuVertical.Controls.Add(pictureBox3);
            MenuVertical.Controls.Add(button1);
            MenuVertical.Controls.Add(butCatalogo);
            MenuVertical.Controls.Add(butHacer_pedido);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(2);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(286, 715);
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
            button1.Location = new Point(8, 453);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(225, 54);
            button1.TabIndex = 3;
            button1.Text = "Personal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnSlide
            // 
            btnSlide.Image = (Image)resources.GetObject("btnSlide.Image");
            btnSlide.Location = new Point(5, 2);
            btnSlide.Margin = new Padding(2);
            btnSlide.Name = "btnSlide";
            btnSlide.Size = new Size(36, 36);
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
            BarraTitulo.Location = new Point(286, 0);
            BarraTitulo.Margin = new Padding(2);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(806, 40);
            BarraTitulo.TabIndex = 11;
            BarraTitulo.Paint += BarraTitulo_Paint_1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Capa_Presentacion.Properties.Resources.LOGO_OSCURO;
            pictureBox1.Location = new Point(521, 192);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(122, 125);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(122, 73);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 25);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Capa_Presentacion.Properties.Resources.USUARIO_BLANCO;
            pictureBox3.Location = new Point(11, 16);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(95, 130);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // Pantalla_De_Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1092, 715);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Pantalla_De_Inicio";
            Text = "Form3";
            Load += Pantalla_De_Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)iconoMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSlide).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button butCatalogo;
        private Button butHacer_pedido;
        private PictureBox iconoMinimizar;
        private PictureBox iconoCerrar;
        private Panel MenuVertical;
        private PictureBox btnSlide;
        private Panel BarraTitulo;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
    }
}