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
            btnMaximzar = new PictureBox();
            btnCerrar = new PictureBox();
            BarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnSlide = new PictureBox();
            butHacer_pedido = new Button();
            butCatalogo = new Button();
            button1 = new Button();
            PBuser = new PictureBox();
            lblRol = new Label();
            lblnom = new Label();
            lblemail = new Label();
            btnLogOut = new Button();
            MenuVertical = new Panel();
            btnDashboard = new Button();
            panel2 = new Panel();
            PanelHerencia = new Panel();
            PanelLogo = new Panel();
            ((System.ComponentModel.ISupportInitialize)btnMaximzar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSlide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBuser).BeginInit();
            MenuVertical.SuspendLayout();
            panel2.SuspendLayout();
            PanelHerencia.SuspendLayout();
            SuspendLayout();
            // 
            // btnMaximzar
            // 
            btnMaximzar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximzar.BackColor = Color.FromArgb(222, 176, 124);
            btnMaximzar.Image = Capa_Presentacion.Properties.Resources.MAXIMIZAR;
            btnMaximzar.Location = new Point(959, 10);
            btnMaximzar.Margin = new Padding(2);
            btnMaximzar.Name = "btnMaximzar";
            btnMaximzar.Size = new Size(24, 24);
            btnMaximzar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximzar.TabIndex = 6;
            btnMaximzar.TabStop = false;
            btnMaximzar.Click += btnMaximzar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(222, 176, 124);
            btnCerrar.Image = Capa_Presentacion.Properties.Resources.CERRAR__2_;
            btnCerrar.Location = new Point(987, 6);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(33, 32);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 8;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(222, 176, 124);
            BarraTitulo.BorderStyle = BorderStyle.FixedSingle;
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnSlide);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Controls.Add(btnMaximzar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(318, 0);
            BarraTitulo.Margin = new Padding(2);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1032, 57);
            BarraTitulo.TabIndex = 11;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.BackColor = Color.FromArgb(222, 176, 124);
            btnRestaurar.Image = Capa_Presentacion.Properties.Resources.RESTAURAR;
            btnRestaurar.Location = new Point(959, 11);
            btnRestaurar.Margin = new Padding(2);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(24, 24);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 10;
            btnRestaurar.TabStop = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.FromArgb(222, 176, 124);
            btnMinimizar.Image = Capa_Presentacion.Properties.Resources.MINIMIZAR;
            btnMinimizar.Location = new Point(931, 10);
            btnMinimizar.Margin = new Padding(2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(24, 24);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 9;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnSlide
            // 
           // btnSlide.Image = Capa_Presentacion.Properties.Resources.icons8_bullet_list_48;
            btnSlide.Location = new Point(14, 6);
            btnSlide.Margin = new Padding(2);
            btnSlide.Name = "btnSlide";
            btnSlide.Size = new Size(45, 36);
            btnSlide.SizeMode = PictureBoxSizeMode.Zoom;
            btnSlide.TabIndex = 5;
            btnSlide.TabStop = false;
            btnSlide.Click += btnSlide_Click;
            // 
            // butHacer_pedido
            // 
            butHacer_pedido.BackColor = Color.FromArgb(41, 76, 37);
            butHacer_pedido.FlatAppearance.BorderSize = 0;
            butHacer_pedido.FlatStyle = FlatStyle.Popup;
            butHacer_pedido.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butHacer_pedido.ForeColor = Color.White;
            butHacer_pedido.Image = (Image)resources.GetObject("butHacer_pedido.Image");
            butHacer_pedido.ImageAlign = ContentAlignment.MiddleLeft;
            butHacer_pedido.Location = new Point(0, 262);
            butHacer_pedido.Margin = new Padding(2);
            butHacer_pedido.Name = "butHacer_pedido";
            butHacer_pedido.Size = new Size(318, 54);
            butHacer_pedido.TabIndex = 1;
            butHacer_pedido.Text = "   Hacer Pedido";
            butHacer_pedido.UseVisualStyleBackColor = false;
            // 
            // butCatalogo
            // 
            butCatalogo.BackColor = Color.FromArgb(41, 76, 37);
            butCatalogo.FlatAppearance.BorderSize = 0;
            butCatalogo.FlatStyle = FlatStyle.Popup;
            butCatalogo.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butCatalogo.ForeColor = Color.White;
            butCatalogo.Image = (Image)resources.GetObject("butCatalogo.Image");
            butCatalogo.ImageAlign = ContentAlignment.MiddleLeft;
            butCatalogo.Location = new Point(2, 187);
            butCatalogo.Margin = new Padding(2);
            butCatalogo.Name = "butCatalogo";
            butCatalogo.Size = new Size(316, 54);
            butCatalogo.TabIndex = 0;
            butCatalogo.Text = "Catalogo";
            butCatalogo.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 76, 37);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 342);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(318, 63);
            button1.TabIndex = 3;
            button1.Text = "Personal";
            button1.UseVisualStyleBackColor = false;
            // 
            // PBuser
            // 
            PBuser.Image = Capa_Presentacion.Properties.Resources.USUARIO_NEGRO;
            PBuser.Location = new Point(8, 3);
            PBuser.Margin = new Padding(2);
            PBuser.Name = "PBuser";
            PBuser.Size = new Size(95, 130);
            PBuser.SizeMode = PictureBoxSizeMode.Zoom;
            PBuser.TabIndex = 7;
            PBuser.TabStop = false;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Century", 9F, FontStyle.Bold);
            lblRol.ForeColor = Color.Black;
            lblRol.Location = new Point(119, 12);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(35, 18);
            lblRol.TabIndex = 8;
            lblRol.Text = "Rol";
            // 
            // lblnom
            // 
            lblnom.AutoSize = true;
            lblnom.Font = new Font("Century", 9F, FontStyle.Bold);
            lblnom.ForeColor = Color.Black;
            lblnom.Location = new Point(119, 60);
            lblnom.Name = "lblnom";
            lblnom.Size = new Size(70, 18);
            lblnom.TabIndex = 9;
            lblnom.Text = "Nombre";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Century", 9F, FontStyle.Bold);
            lblemail.ForeColor = Color.Black;
            lblemail.Location = new Point(119, 104);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(61, 18);
            lblemail.TabIndex = 10;
            lblemail.Text = "E-mail";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(41, 76, 37);
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 746);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(318, 54);
            btnLogOut.TabIndex = 11;
            btnLogOut.Text = "Cerrar Sesion";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(222, 176, 124);
            MenuVertical.Controls.Add(btnDashboard);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(btnLogOut);
            MenuVertical.Controls.Add(butCatalogo);
            MenuVertical.Controls.Add(butHacer_pedido);
            MenuVertical.Controls.Add(button1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(2);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(318, 800);
            MenuVertical.TabIndex = 10;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(41, 76, 37);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 425);
            btnDashboard.Margin = new Padding(2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(318, 63);
            btnDashboard.TabIndex = 13;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(222, 176, 124);
            panel2.Controls.Add(PBuser);
            panel2.Controls.Add(lblnom);
            panel2.Controls.Add(lblRol);
            panel2.Controls.Add(lblemail);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 151);
            panel2.TabIndex = 12;
            // 
            // PanelHerencia
            // 
            PanelHerencia.BackgroundImage = Capa_Presentacion.Properties.Resources.OPCION_E;
            PanelHerencia.Controls.Add(PanelLogo);
            PanelHerencia.Dock = DockStyle.Fill;
            PanelHerencia.Location = new Point(318, 0);
            PanelHerencia.Name = "PanelHerencia";
            PanelHerencia.Size = new Size(1032, 800);
            PanelHerencia.TabIndex = 12;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.FromArgb(128, 1, 1, 1);
           // PanelLogo.BackgroundImage = Capa_Presentacion.Properties.Resources.SIN_FONDO_OSCURO;
            PanelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PanelLogo.Location = new Point(321, 248);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(357, 333);
            PanelLogo.TabIndex = 0;
            // 
            // Pantalla_De_Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1350, 800);
            Controls.Add(BarraTitulo);
            Controls.Add(PanelHerencia);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Pantalla_De_Inicio";
            Text = "Form3";
            Load += Pantalla_De_Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)btnMaximzar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSlide).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBuser).EndInit();
            MenuVertical.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PanelHerencia.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox btnMaximzar;
        private PictureBox btnCerrar;
        private Panel BarraTitulo;
        private PictureBox btnMinimizar;
        private PictureBox btnRestaurar;
        private Button butHacer_pedido;
        private Button butCatalogo;
        private Button button1;
        private PictureBox PBuser;
        private Label lblRol;
        private Label lblnom;
        private PictureBox btnSlide;
        private Label lblemail;
        private Button btnLogOut;
        private Panel MenuVertical;
        private Panel panel2;
        private Button btnDashboard;
        private Panel PanelHerencia;
        private Panel PanelLogo;
    }
}