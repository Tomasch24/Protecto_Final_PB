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
            btnClientes = new Button();
            lblRol = new Label();
            btnReportes = new Button();
            PBuser = new PictureBox();
            btnPedidos = new Button();
            btnFacturacion = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pbIconCerrar = new PictureBox();
            BarraTitulo = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelHerencia.SuspendLayout();
            panel1.SuspendLayout();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBuser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIconCerrar).BeginInit();
            BarraTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.SIN_FONDO_OSCURO;
            pictureBox1.Location = new Point(411, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 461);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelHerencia
            // 
            PanelHerencia.Controls.Add(panel1);
            PanelHerencia.Controls.Add(MenuVertical);
            PanelHerencia.Dock = DockStyle.Fill;
            PanelHerencia.Location = new Point(0, 57);
            PanelHerencia.Name = "PanelHerencia";
            PanelHerencia.Size = new Size(1710, 853);
            PanelHerencia.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(315, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1395, 853);
            panel1.TabIndex = 12;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(22, 39, 33);
            MenuVertical.Controls.Add(btnExit);
            MenuVertical.Controls.Add(lblemail);
            MenuVertical.Controls.Add(lblnom);
            MenuVertical.Controls.Add(btnClientes);
            MenuVertical.Controls.Add(lblRol);
            MenuVertical.Controls.Add(btnReportes);
            MenuVertical.Controls.Add(PBuser);
            MenuVertical.Controls.Add(btnPedidos);
            MenuVertical.Controls.Add(btnFacturacion);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.ForeColor = SystemColors.ControlText;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(315, 853);
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
            btnExit.Location = new Point(0, 815);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(315, 38);
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
            lblemail.Location = new Point(112, 108);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(46, 15);
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
            lblnom.Location = new Point(112, 21);
            lblnom.Name = "lblnom";
            lblnom.Size = new Size(60, 15);
            lblnom.TabIndex = 13;
            lblnom.Text = "Nombre";
            lblnom.Click += lblnom_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(87, 112, 50);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(58, 510);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(186, 38);
            btnClientes.TabIndex = 7;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click_1;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Lucida Bright", 7.8F, FontStyle.Bold);
            lblRol.ForeColor = Color.White;
            lblRol.Location = new Point(112, 69);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(29, 15);
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
            btnReportes.Location = new Point(58, 636);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(186, 38);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Sistema";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click_1;
            // 
            // PBuser
            // 
            PBuser.BackColor = Color.Transparent;
            PBuser.Image = Properties.Resources.USUARIO_NEGRO;
            PBuser.Location = new Point(0, 21);
            PBuser.Margin = new Padding(2);
            PBuser.Name = "PBuser";
            PBuser.Size = new Size(107, 88);
            PBuser.SizeMode = PictureBoxSizeMode.Zoom;
            PBuser.TabIndex = 11;
            PBuser.TabStop = false;
            PBuser.Click += PBuser_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(96, 141, 72);
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Location = new Point(58, 363);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(186, 38);
            btnPedidos.TabIndex = 3;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click_1;
            // 
            // btnFacturacion
            // 
            btnFacturacion.BackColor = Color.FromArgb(42, 100, 66);
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            btnFacturacion.ForeColor = Color.White;
            btnFacturacion.Location = new Point(58, 215);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(186, 38);
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
            // pbIconCerrar
            // 
            pbIconCerrar.Image = Properties.Resources.icons8_eliminar_50;
            pbIconCerrar.Location = new Point(1627, 11);
            pbIconCerrar.Margin = new Padding(2);
            pbIconCerrar.Name = "pbIconCerrar";
            pbIconCerrar.Size = new Size(32, 32);
            pbIconCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbIconCerrar.TabIndex = 0;
            pbIconCerrar.TabStop = false;
            pbIconCerrar.Click += pbIconCerrar_Click_1;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(230, 230, 230);
            BarraTitulo.Controls.Add(pbIconCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.ForeColor = Color.White;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Margin = new Padding(2);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1710, 57);
            BarraTitulo.TabIndex = 13;
            // 
            // Pantalla_Inicio_Cajera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1710, 910);
            Controls.Add(PanelHerencia);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)pbIconCerrar).EndInit();
            BarraTitulo.ResumeLayout(false);
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
        private Button btnClientes;
        private Label lblRol;
        private Button btnReportes;
        private PictureBox PBuser;
        private Button btnPedidos;
        private Button btnFacturacion;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pbIconCerrar;
        private Panel BarraTitulo;
        private Button btnExit;
    }
}