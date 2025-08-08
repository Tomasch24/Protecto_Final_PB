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
            panel3 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblAcercade
            // 
            lblAcercade.AutoSize = true;
            lblAcercade.Font = new Font("Lucida Sans", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcercade.ForeColor = Color.White;
            lblAcercade.Location = new Point(515, 231);
            lblAcercade.Margin = new Padding(2, 0, 2, 0);
            lblAcercade.Name = "lblAcercade";
            lblAcercade.Size = new Size(365, 39);
            lblAcercade.TabIndex = 0;
            lblAcercade.Text = "Acerca de Nosotros";
            lblAcercade.TextAlign = ContentAlignment.TopCenter;
            lblAcercade.Click += lblAcercade_Click;
            // 
            // lblNombres
            // 
            lblNombres.BackColor = Color.Transparent;
            lblNombres.Font = new Font("Lucida Fax", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombres.ForeColor = Color.White;
            lblNombres.Location = new Point(79, 323);
            lblNombres.Margin = new Padding(2, 0, 2, 0);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(1147, 397);
            lblNombres.TabIndex = 1;
            lblNombres.Text = resources.GetString("lblNombres.Text");
            lblNombres.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Positivo;
            pictureBox1.Location = new Point(555, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(268, 247);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 8);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(858, 247);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 8);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(42, 100, 66);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1680, 218);
            panel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 801);
            label1.Name = "label1";
            label1.Size = new Size(333, 19);
            label1.TabIndex = 6;
            label1.Text = "Todos los derechos reservados 2025";
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 100, 66);
            ClientSize = new Size(1680, 843);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(lblNombres);
            Controls.Add(lblAcercade);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Sistema";
            Load += Sistema_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAcercade;
        private Label lblNombres;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
    }
}