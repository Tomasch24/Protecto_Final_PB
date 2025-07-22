namespace Capa_Presentacion
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            listBox1 = new ListBox();
            iconoCerrarEmp = new PictureBox();
            iconoMinimizarEmp = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconoCerrarEmp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizarEmp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.AccessibleRole = AccessibleRole.Window;
            listBox1.BackColor = Color.Honeydew;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Tw Cen MT", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(-1, 114);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.No;
            listBox1.Size = new Size(847, 335);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // iconoCerrarEmp
            // 
            iconoCerrarEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoCerrarEmp.Image = (Image)resources.GetObject("iconoCerrarEmp.Image");
            iconoCerrarEmp.Location = new Point(804, 12);
            iconoCerrarEmp.Name = "iconoCerrarEmp";
            iconoCerrarEmp.Size = new Size(30, 30);
            iconoCerrarEmp.SizeMode = PictureBoxSizeMode.Zoom;
            iconoCerrarEmp.TabIndex = 10;
            iconoCerrarEmp.TabStop = false;
            iconoCerrarEmp.Click += iconoCerrarEmp_Click;
            // 
            // iconoMinimizarEmp
            // 
            iconoMinimizarEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoMinimizarEmp.Image = (Image)resources.GetObject("iconoMinimizarEmp.Image");
            iconoMinimizarEmp.Location = new Point(768, 12);
            iconoMinimizarEmp.Name = "iconoMinimizarEmp";
            iconoMinimizarEmp.Size = new Size(30, 30);
            iconoMinimizarEmp.SizeMode = PictureBoxSizeMode.Zoom;
            iconoMinimizarEmp.TabIndex = 13;
            iconoMinimizarEmp.TabStop = false;
            iconoMinimizarEmp.Click += iconoMinimizarEmp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-31, -90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(877, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 160, 100);
            ClientSize = new Size(846, 480);
            Controls.Add(iconoMinimizarEmp);
            Controls.Add(iconoCerrarEmp);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Empleado";
            Text = "Empleado";
            Load += Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)iconoCerrarEmp).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizarEmp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private PictureBox iconoCerrarEmp;
        private PictureBox iconoMinimizarEmp;
        private PictureBox pictureBox1;
    }
}