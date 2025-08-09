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
            components = new System.ComponentModel.Container();
            BarraTitulo = new Panel();
            PBlogoG = new PictureBox();
            MenuVertical = new Panel();
            btnExit = new Button();
            lblemail = new Label();
            lblnom = new Label();
            btnClientes = new Button();
            lblRol = new Label();
            BotonParaDashBoard = new Button();
            btnReportes = new Button();
            PBuser = new PictureBox();
            btnProveedores = new Button();
            btnPedidos = new Button();
            btnFacturacion = new Button();
            PanelHerencia = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox2 = new PictureBox();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBlogoG).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBuser).BeginInit();
            PanelHerencia.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.White;
            BarraTitulo.Controls.Add(pictureBox2);
            BarraTitulo.Controls.Add(PBlogoG);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.ForeColor = Color.White;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Margin = new Padding(2);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1554, 76);
            BarraTitulo.TabIndex = 11;
            BarraTitulo.Paint += BarraTitulo_Paint;
            // 
            // PBlogoG
            // 
            PBlogoG.Image = Capa_Presentacion.Properties.Resources.SIN_FONDO_OSCURO;
            PBlogoG.Location = new Point(3, 0);
            PBlogoG.Name = "PBlogoG";
            PBlogoG.Size = new Size(104, 92);
            PBlogoG.SizeMode = PictureBoxSizeMode.Zoom;
            PBlogoG.TabIndex = 2;
            PBlogoG.TabStop = false;
            PBlogoG.Click += PBlogoG_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(22, 39, 33);
            MenuVertical.Controls.Add(btnExit);
            MenuVertical.Controls.Add(lblemail);
            MenuVertical.Controls.Add(lblnom);
            MenuVertical.Controls.Add(btnClientes);
            MenuVertical.Controls.Add(lblRol);
            MenuVertical.Controls.Add(BotonParaDashBoard);
            MenuVertical.Controls.Add(btnReportes);
            MenuVertical.Controls.Add(PBuser);
            MenuVertical.Controls.Add(btnProveedores);
            MenuVertical.Controls.Add(btnPedidos);
            MenuVertical.Controls.Add(btnFacturacion);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.ForeColor = SystemColors.ControlText;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(4);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(310, 806);
            MenuVertical.TabIndex = 11;
            MenuVertical.Paint += MenuVertical_Paint;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(22, 39, 33);
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 758);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(310, 48);
            btnExit.TabIndex = 17;
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
            lblemail.Location = new Point(140, 135);
            lblemail.Margin = new Padding(4, 0, 4, 0);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(54, 18);
            lblemail.TabIndex = 14;
            lblemail.Text = "E-mail";
            // 
            // lblnom
            // 
            lblnom.AutoSize = true;
            lblnom.BackColor = Color.Transparent;
            lblnom.Font = new Font("Lucida Bright", 7.8F, FontStyle.Bold);
            lblnom.ForeColor = Color.White;
            lblnom.Location = new Point(140, 26);
            lblnom.Margin = new Padding(4, 0, 4, 0);
            lblnom.Name = "lblnom";
            lblnom.Size = new Size(73, 18);
            lblnom.TabIndex = 13;
            lblnom.Text = "Nombre";
            lblnom.Click += lblnom_Click_1;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(87, 112, 50);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(70, 588);
            btnClientes.Margin = new Padding(4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(232, 48);
            btnClientes.TabIndex = 7;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Lucida Bright", 7.8F, FontStyle.Bold);
            lblRol.ForeColor = Color.White;
            lblRol.Location = new Point(140, 86);
            lblRol.Margin = new Padding(4, 0, 4, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(35, 18);
            lblRol.TabIndex = 12;
            lblRol.Text = "Rol";
            lblRol.Click += lblRol_Click;
            // 
            // BotonParaDashBoard
            // 
            BotonParaDashBoard.BackColor = Color.FromArgb(87, 169, 124);
            BotonParaDashBoard.FlatAppearance.BorderSize = 0;
            BotonParaDashBoard.FlatStyle = FlatStyle.Flat;
            BotonParaDashBoard.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            BotonParaDashBoard.ForeColor = Color.White;
            BotonParaDashBoard.Location = new Point(70, 201);
            BotonParaDashBoard.Margin = new Padding(4);
            BotonParaDashBoard.Name = "BotonParaDashBoard";
            BotonParaDashBoard.Size = new Size(232, 48);
            BotonParaDashBoard.TabIndex = 6;
            BotonParaDashBoard.Text = "Dashboard";
            BotonParaDashBoard.UseVisualStyleBackColor = false;
            BotonParaDashBoard.Click += BotonParaDashBoard_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(43, 56, 46);
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(70, 855);
            btnReportes.Margin = new Padding(4);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(232, 48);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Sistema";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // PBuser
            // 
            PBuser.BackColor = Color.Transparent;
            PBuser.Image = Capa_Presentacion.Properties.Resources.USUARIO_NEGRO;
            PBuser.Location = new Point(0, 26);
            PBuser.Margin = new Padding(2);
            PBuser.Name = "PBuser";
            PBuser.Size = new Size(107, 102);
            PBuser.SizeMode = PictureBoxSizeMode.Zoom;
            PBuser.TabIndex = 11;
            PBuser.TabStop = false;
            PBuser.Click += PBuser_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.FromArgb(87, 112, 69);
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Location = new Point(70, 712);
            btnProveedores.Margin = new Padding(4);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(232, 48);
            btnProveedores.TabIndex = 4;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(96, 141, 72);
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Location = new Point(70, 455);
            btnPedidos.Margin = new Padding(4);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(232, 48);
            btnPedidos.TabIndex = 3;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.BackColor = Color.FromArgb(42, 100, 66);
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.Font = new Font("Lucida Bright", 9F, FontStyle.Bold);
            btnFacturacion.ForeColor = Color.White;
            btnFacturacion.Location = new Point(70, 330);
            btnFacturacion.Margin = new Padding(4);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(232, 48);
            btnFacturacion.TabIndex = 2;
            btnFacturacion.Text = "Facturación";
            btnFacturacion.UseVisualStyleBackColor = false;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // PanelHerencia
            // 
            PanelHerencia.Controls.Add(panel1);
            PanelHerencia.Controls.Add(MenuVertical);
            PanelHerencia.Dock = DockStyle.Fill;
            PanelHerencia.Location = new Point(0, 76);
            PanelHerencia.Name = "PanelHerencia";
            PanelHerencia.Size = new Size(1554, 806);
            PanelHerencia.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(310, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1244, 806);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint_3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Capa_Presentacion.Properties.Resources.LOGO_OSCURO;
            pictureBox1.Location = new Point(406, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 419);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Capa_Presentacion.Properties.Resources.icons8_eliminar_50;
            pictureBox2.Location = new Point(1502, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Pantalla_De_Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1554, 882);
            Controls.Add(PanelHerencia);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Pantalla_De_Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Pantalla_De_Inicio_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBlogoG).EndInit();
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBuser).EndInit();
            PanelHerencia.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel BarraTitulo;
        private Panel MenuVertical;
        private Panel PanelHerencia;
        private Button btnReportes;
        private Button btnProveedores;
        private Button btnPedidos;
        private Button btnFacturacion;
        private Button BotonParaDashBoard;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnClientes;
        private Label lblemail;
        private Label lblnom;
        private Label lblRol;
        private PictureBox PBuser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnExit;
        private PictureBox PBlogoG;
        private PictureBox pictureBox2;
    }
}