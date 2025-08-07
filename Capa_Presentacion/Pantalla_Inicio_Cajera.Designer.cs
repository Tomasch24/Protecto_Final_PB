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
            btnCatalogo = new Button();
            btnFacturacion = new Button();
            btnPedidos = new Button();
            PBuser = new PictureBox();
            btnReportes = new Button();
            lblRol = new Label();
            btnClientes = new Button();
            lblnom = new Label();
            lblemail = new Label();
            MenuVertical = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            PanelHerencia = new Panel();
            BarraTitulo = new Panel();
            ((System.ComponentModel.ISupportInitialize)PBuser).BeginInit();
            MenuVertical.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCatalogo
            // 
            btnCatalogo.BackColor = Color.FromArgb(42, 100, 66);
            btnCatalogo.FlatAppearance.BorderSize = 0;
            btnCatalogo.FlatStyle = FlatStyle.Flat;
            btnCatalogo.ForeColor = Color.White;
            btnCatalogo.Location = new Point(42, 192);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.Size = new Size(186, 38);
            btnCatalogo.TabIndex = 1;
            btnCatalogo.Text = "Catalogo";
            btnCatalogo.UseVisualStyleBackColor = false;
            btnCatalogo.Click += btnCatalogo_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.BackColor = Color.FromArgb(42, 100, 66);
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.ForeColor = Color.White;
            btnFacturacion.Location = new Point(42, 274);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(186, 38);
            btnFacturacion.TabIndex = 2;
            btnFacturacion.Text = "Facturación";
            btnFacturacion.UseVisualStyleBackColor = false;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(96, 141, 72);
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Location = new Point(42, 349);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(186, 38);
            btnPedidos.TabIndex = 3;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
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
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(43, 56, 46);
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(42, 493);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(186, 38);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.White;
            lblRol.Location = new Point(112, 69);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 17);
            lblRol.TabIndex = 12;
            lblRol.Text = "Rol";
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(87, 112, 50);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(42, 422);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(186, 38);
            btnClientes.TabIndex = 7;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // lblnom
            // 
            lblnom.AutoSize = true;
            lblnom.BackColor = Color.Transparent;
            lblnom.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnom.ForeColor = Color.White;
            lblnom.Location = new Point(112, 21);
            lblnom.Name = "lblnom";
            lblnom.Size = new Size(57, 17);
            lblnom.TabIndex = 13;
            lblnom.Text = "Nombre";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.BackColor = Color.Transparent;
            lblemail.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblemail.ForeColor = Color.White;
            lblemail.Location = new Point(112, 108);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(44, 17);
            lblemail.TabIndex = 14;
            lblemail.Text = "E-mail";
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(22, 39, 33);
            MenuVertical.Controls.Add(lblemail);
            MenuVertical.Controls.Add(lblnom);
            MenuVertical.Controls.Add(btnClientes);
            MenuVertical.Controls.Add(lblRol);
            MenuVertical.Controls.Add(btnReportes);
            MenuVertical.Controls.Add(PBuser);
            MenuVertical.Controls.Add(btnPedidos);
            MenuVertical.Controls.Add(btnFacturacion);
            MenuVertical.Controls.Add(btnCatalogo);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.ForeColor = SystemColors.ControlText;
            MenuVertical.Location = new Point(0, 57);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(279, 717);
            MenuVertical.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(PanelHerencia);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(1632, 717);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.LOGO_OSCURO;
            pictureBox1.Location = new Point(718, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(485, 443);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PanelHerencia
            // 
            PanelHerencia.Dock = DockStyle.Fill;
            PanelHerencia.Location = new Point(0, 0);
            PanelHerencia.Name = "PanelHerencia";
            PanelHerencia.Size = new Size(1632, 717);
            PanelHerencia.TabIndex = 1;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(230, 230, 230);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.ForeColor = Color.White;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Margin = new Padding(2);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1632, 57);
            BarraTitulo.TabIndex = 14;
            // 
            // Pantalla_Inicio_Cajera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1632, 774);
            Controls.Add(MenuVertical);
            Controls.Add(panel1);
            Controls.Add(BarraTitulo);
            Name = "Pantalla_Inicio_Cajera";
            Text = "Pantalla_Inicio_Cajera";
            ((System.ComponentModel.ISupportInitialize)PBuser).EndInit();
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCatalogo;
        private Button btnFacturacion;
        private Button btnPedidos;
        private PictureBox PBuser;
        private Button btnReportes;
        private Label lblRol;
        private Button btnClientes;
        private Label lblnom;
        private Label lblemail;
        private Panel MenuVertical;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel BarraTitulo;
        private Panel PanelHerencia;
    }
}