namespace Capa_Presentacion
{
    partial class Pantalla_Inicio_Cajera
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
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            PanelHerencia = new Panel();
            panel1 = new Panel();
            MenuVertical = new Panel();
            btnExit = new Button();
            lblemail = new Label();
            lblnom = new Label();
            lblRol = new Label();
            btnReportes = new Button();
            PBuser = new PictureBox();
            btnFacturacion = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            BarraTitulo = new Panel();
            pictureBox2 = new PictureBox();
            PBlogoC = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelHerencia.SuspendLayout();
            panel1.SuspendLayout();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBuser).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBlogoC).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.SIN_FONDO_OSCURO;
            pictureBox1.Location = new Point(284, 78);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(779, 446);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelHerencia
            // 
            PanelHerencia.Controls.Add(panel1);
            PanelHerencia.Controls.Add(MenuVertical);
            PanelHerencia.Dock = DockStyle.Fill;
            PanelHerencia.Location = new Point(0, 46);
            PanelHerencia.Margin = new Padding(2, 2, 2, 2);
            PanelHerencia.Name = "PanelHerencia";
            PanelHerencia.Size = new Size(1680, 664);
            PanelHerencia.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(290, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1390, 664);
            panel1.TabIndex = 12;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(22, 39, 33);
            MenuVertical.Controls.Add(btnExit);
            MenuVertical.Controls.Add(lblemail);
            MenuVertical.Controls.Add(lblnom);
            MenuVertical.Controls.Add(lblRol);
            MenuVertical.Controls.Add(btnReportes);
            MenuVertical.Controls.Add(PBuser);
            MenuVertical.Controls.Add(btnFacturacion);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.ForeColor = SystemColors.ControlText;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(3, 2, 3, 2);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(290, 664);
            MenuVertical.TabIndex = 11;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(22, 39, 33);
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 635);
            btnExit.Margin = new Padding(2, 2, 2, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(290, 29);
            btnExit.TabIndex = 18;
            btnExit.Text = "Cerrar Sesion";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.BackColor = Color.Transparent;
            lblemail.Font = new Font("Lucida Bright", 7.8F, FontStyle.Bold);
            lblemail.ForeColor = Color.White;
            lblemail.Location = new Point(78, 71);
            lblemail.Margin = new Padding(2, 0, 2, 0);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(41, 14);
            lblemail.TabIndex = 14;
            lblemail.Text = "E-mail";
            lblemail.Click += lblemail_Click;
            // 
            // lblnom
            // 
            lblnom.AutoSize = true;
            lblnom.BackColor = Color.Transparent;
            lblnom.Font = new Font("Lucida Bright", 7.8F, FontStyle.Bold);
            lblnom.ForeColor = Color.White;
            lblnom.Location = new Point(78, 19);
            lblnom.Margin = new Padding(2, 0, 2, 0);
            lblnom.Name = "lblnom";
            lblnom.Size = new Size(52, 14);
            lblnom.TabIndex = 13;
            lblnom.Text = "Nombre";
            lblnom.Click += lblnom_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Lucida Bright", 7.8F, FontStyle.Bold);
            lblRol.ForeColor = Color.White;
            lblRol.Location = new Point(78, 44);
            lblRol.Margin = new Padding(2, 0, 2, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(25, 14);
            lblRol.TabIndex = 12;
            lblRol.Text = "Rol";
            lblRol.Click += lblRol_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(43, 56, 46);
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(65, 363);
            btnReportes.Margin = new Padding(3, 2, 3, 2);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(162, 29);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Sistema";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click_1;
            // 
            // PBuser
            // 
            PBuser.BackColor = Color.Transparent;
            PBuser.Image = Properties.Resources.USUARIO_NEGRO;
            PBuser.Location = new Point(0, 16);
            PBuser.Margin = new Padding(1, 1, 1, 1);
            PBuser.Name = "PBuser";
            PBuser.Size = new Size(75, 68);
            PBuser.SizeMode = PictureBoxSizeMode.Zoom;
            PBuser.TabIndex = 11;
            PBuser.TabStop = false;
            PBuser.Click += PBuser_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.BackColor = Color.FromArgb(42, 100, 66);
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            btnFacturacion.ForeColor = Color.White;
            btnFacturacion.Location = new Point(65, 244);
            btnFacturacion.Margin = new Padding(3, 2, 3, 2);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(162, 29);
            btnFacturacion.TabIndex = 2;
            btnFacturacion.Text = "Facturación";
            btnFacturacion.UseVisualStyleBackColor = false;
            btnFacturacion.Click += btnFacturacion_Click_1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.White;
            BarraTitulo.Controls.Add(pictureBox2);
            BarraTitulo.Controls.Add(PBlogoC);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.ForeColor = Color.White;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Margin = new Padding(1, 1, 1, 1);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1680, 46);
            BarraTitulo.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_eliminar_50;
            pictureBox2.Location = new Point(1641, 11);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // PBlogoC
            // 
            PBlogoC.Image = Properties.Resources.SIN_FONDO_OSCURO;
            PBlogoC.Location = new Point(0, 2);
            PBlogoC.Margin = new Padding(2, 2, 2, 2);
            PBlogoC.Name = "PBlogoC";
            PBlogoC.Size = new Size(90, 55);
            PBlogoC.SizeMode = PictureBoxSizeMode.Zoom;
            PBlogoC.TabIndex = 1;
            PBlogoC.TabStop = false;
            PBlogoC.Click += PBlogoC_Click;
            // 
            // Pantalla_Inicio_Cajera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1680, 710);
            Controls.Add(PanelHerencia);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Pantalla_Inicio_Cajera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla_Inicio_Cajera";
            Load += Pantalla_Inicio_Cajera_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelHerencia.ResumeLayout(false);
            panel1.ResumeLayout(false);
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBuser).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBlogoC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Panel PanelHerencia;
        private Panel panel1;
        private Panel MenuVertical;
        private Label lblemail;
        private Label lblnom;
        private Label lblRol;
        private Button btnReportes;
        private PictureBox PBuser;
        private Button btnFacturacion;
        private ContextMenuStrip contextMenuStrip1;
        private Panel BarraTitulo;
        private Button btnExit;
        private PictureBox PBlogoC;
        private PictureBox pictureBox2;
    }
}