namespace Capa_Presentacion
{
    partial class FormBienvenida
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
            panel1 = new Panel();
            lblPoint = new Label();
            pictureBox1 = new PictureBox();
            lblusuario = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(88, 173, 72);
            panel1.Controls.Add(lblPoint);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 125);
            panel1.TabIndex = 0;
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Font = new Font("Lucida Fax", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPoint.ForeColor = Color.White;
            lblPoint.Location = new Point(275, 47);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(515, 34);
            lblPoint.TabIndex = 2;
            lblPoint.Text = "Welcome To Green Point System";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LOGO_OSCURO;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 186);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Lucida Fax", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblusuario.ForeColor = Color.White;
            lblusuario.Location = new Point(42, 175);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(167, 40);
            lblusuario.TabIndex = 3;
            lblusuario.Text = "Usuario ";
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 30;
            timer2.Tick += timer2_Tick;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.FromArgb(88, 173, 72);
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.ForeColor = Color.FromArgb(22, 39, 33);
            progressBar1.Location = new Point(0, 272);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(917, 29);
            progressBar1.TabIndex = 5;
            // 
            // FormBienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 39, 33);
            ClientSize = new Size(917, 301);
            Controls.Add(progressBar1);
            Controls.Add(lblusuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBienvenida";
            Load += FormBienvenida_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblPoint;
        private Label lblusuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ProgressBar progressBar1;
    }
}