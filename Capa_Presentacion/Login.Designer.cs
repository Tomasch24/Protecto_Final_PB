namespace Capa_Presentacion
{
    partial class Login
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
            panelLogTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            panel1 = new Panel();
            txtUser = new TextBox();
            lblUser = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            lblError = new Label();
            panelLogTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLogTitulo
            // 
            panelLogTitulo.BackColor = Color.FromArgb(88, 173, 83);
            panelLogTitulo.Controls.Add(btnMinimizar);
            panelLogTitulo.Controls.Add(btnCerrar);
            panelLogTitulo.Dock = DockStyle.Top;
            panelLogTitulo.Location = new Point(0, 0);
            panelLogTitulo.Name = "panelLogTitulo";
            panelLogTitulo.Size = new Size(462, 50);
            panelLogTitulo.TabIndex = 0;
            panelLogTitulo.Paint += panelLogTitulo_Paint;
            panelLogTitulo.MouseMove += panelLogTitulo_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.MINIMIZAR;
            btnMinimizar.Location = new Point(398, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(27, 26);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.CERRAR__2_;
            btnCerrar.Location = new Point(431, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(27, 26);
            btnCerrar.TabIndex = 2;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(88, 173, 83);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 669);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 27);
            panel1.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(41, 76, 37);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(50, 328);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(350, 22);
            txtUser.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Century", 12F, FontStyle.Bold);
            lblUser.ForeColor = Color.Black;
            lblUser.Location = new Point(50, 292);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(90, 23);
            lblUser.TabIndex = 3;
            lblUser.Text = "Usuario";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century", 12F, FontStyle.Bold);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(50, 372);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(126, 23);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(41, 76, 37);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(50, 412);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 22);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(88, 173, 83);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(50, 540);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(350, 63);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Paint += btnLogin_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_OSCURO;
            pictureBox1.Location = new Point(120, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Century", 9F, FontStyle.Bold);
            lblError.ForeColor = Color.Black;
            lblError.ImageAlign = ContentAlignment.MiddleLeft;
            lblError.Location = new Point(50, 449);
            lblError.Name = "lblError";
            lblError.Size = new Size(147, 18);
            lblError.TabIndex = 11;
            lblError.Text = "Mensaje de Error";
            lblError.TextAlign = ContentAlignment.MiddleRight;
            lblError.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(462, 696);
            Controls.Add(lblError);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblUser);
            Controls.Add(txtUser);
            Controls.Add(panel1);
            Controls.Add(panelLogTitulo);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Login_Load;
            KeyDown += Login_KeyDown;
            MouseMove += Login_MouseDown;
            panelLogTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLogTitulo;
        private PictureBox btnCerrar;
        private Panel panel1;
        private PictureBox btnMinimizar;
        private TextBox txtUser;
        private Label lblUser;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Label lblError;
    }
}