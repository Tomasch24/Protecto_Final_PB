namespace Capa_Presentacion
{
    partial class Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            lblAcercade = new Label();
            lblNombres = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAcercade
            // 
            lblAcercade.AutoSize = true;
            lblAcercade.Font = new Font("Lucida Sans", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcercade.ForeColor = Color.White;
            lblAcercade.Location = new Point(514, 43);
            lblAcercade.Name = "lblAcercade";
            lblAcercade.Size = new Size(423, 45);
            lblAcercade.TabIndex = 0;
            lblAcercade.Text = "Acerca de Nosotros";
            lblAcercade.TextAlign = ContentAlignment.TopCenter;
            lblAcercade.Click += lblAcercade_Click;
            // 
            // lblNombres
            // 
            lblNombres.BackColor = Color.Transparent;
            lblNombres.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombres.ForeColor = Color.White;
            lblNombres.Location = new Point(81, 101);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(1229, 687);
            lblNombres.TabIndex = 1;
            lblNombres.Text = resources.GetString("lblNombres.Text");
            lblNombres.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Positivo;
            pictureBox1.Location = new Point(920, 484);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(205, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 10);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(943, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 10);
            panel2.TabIndex = 4;
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(111, 129, 105);
            ClientSize = new Size(1711, 821);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblNombres);
            Controls.Add(lblAcercade);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sistema";
            Load += Sistema_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAcercade;
        private Label lblNombres;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
    }
}