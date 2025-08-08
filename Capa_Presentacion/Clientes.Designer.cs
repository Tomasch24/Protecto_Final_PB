namespace Capa_Presentacion
{
    partial class Clientes
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
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            btnGuardarCliente = new Button();
            gbDatosC = new GroupBox();
            pbBuscarIdCliente = new PictureBox();
            txtIdCliente = new TextBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            MtxtTelefono = new MaskedTextBox();
            lblTelefono = new Label();
            lblIdCliente = new Label();
            MtxtRnc = new MaskedTextBox();
            lblRnc = new Label();
            lblTitulo = new Label();
            btnEditarCliente = new Button();
            dgvClientes = new DataGridView();
            btnBuscar = new Button();
            btnEliminarCliente = new Button();
            pbAtras = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            gbDatosC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBuscarIdCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Verdana", 10F);
            txtCorreo.Location = new Point(16, 290);
            txtCorreo.Margin = new Padding(2, 2, 2, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(190, 28);
            txtCorreo.TabIndex = 115;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.FromArgb(43, 56, 46);
            lblCorreo.Font = new Font("Verdana", 9F);
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(16, 270);
            lblCorreo.Margin = new Padding(2, 0, 2, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(60, 18);
            lblCorreo.TabIndex = 111;
            lblCorreo.Text = "Correo";
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.BackColor = SystemColors.MenuBar;
            btnGuardarCliente.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnGuardarCliente.Location = new Point(241, 563);
            btnGuardarCliente.Margin = new Padding(2, 2, 2, 2);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(129, 32);
            btnGuardarCliente.TabIndex = 107;
            btnGuardarCliente.Text = "Guardar";
            btnGuardarCliente.UseVisualStyleBackColor = false;
            btnGuardarCliente.Click += btnGuardarCliente_Click;
            // 
            // gbDatosC
            // 
            gbDatosC.BackColor = Color.FromArgb(43, 56, 46);
            gbDatosC.Controls.Add(pbBuscarIdCliente);
            gbDatosC.Controls.Add(txtIdCliente);
            gbDatosC.Controls.Add(txtCorreo);
            gbDatosC.Controls.Add(txtNombre);
            gbDatosC.Controls.Add(lblNombre);
            gbDatosC.Controls.Add(lblCorreo);
            gbDatosC.Controls.Add(MtxtTelefono);
            gbDatosC.Controls.Add(lblTelefono);
            gbDatosC.Controls.Add(lblIdCliente);
            gbDatosC.Controls.Add(MtxtRnc);
            gbDatosC.Controls.Add(lblRnc);
            gbDatosC.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            gbDatosC.ForeColor = Color.White;
            gbDatosC.Location = new Point(856, 88);
            gbDatosC.Margin = new Padding(2, 2, 2, 2);
            gbDatosC.Name = "gbDatosC";
            gbDatosC.Padding = new Padding(2, 2, 2, 2);
            gbDatosC.Size = new Size(254, 346);
            gbDatosC.TabIndex = 108;
            gbDatosC.TabStop = false;
            gbDatosC.Text = "Datos del Cliente";
            // 
            // pbBuscarIdCliente
            // 
            pbBuscarIdCliente.BackColor = Color.Transparent;
            pbBuscarIdCliente.Image = Properties.Resources.icons8_search_32;
            pbBuscarIdCliente.Location = new Point(90, 50);
            pbBuscarIdCliente.Margin = new Padding(2, 2, 2, 2);
            pbBuscarIdCliente.Name = "pbBuscarIdCliente";
            pbBuscarIdCliente.Size = new Size(24, 29);
            pbBuscarIdCliente.SizeMode = PictureBoxSizeMode.Zoom;
            pbBuscarIdCliente.TabIndex = 13;
            pbBuscarIdCliente.TabStop = false;
            pbBuscarIdCliente.Click += pbBuscarIdCliente_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Verdana", 10F);
            txtIdCliente.Location = new Point(16, 50);
            txtIdCliente.Margin = new Padding(2, 2, 2, 2);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(66, 28);
            txtIdCliente.TabIndex = 0;
            txtIdCliente.KeyPress += txtIdCliente_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Verdana", 10F);
            txtNombre.Location = new Point(16, 106);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 28);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(43, 56, 46);
            lblNombre.Font = new Font("Verdana", 9F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(16, 80);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 18);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // MtxtTelefono
            // 
            MtxtTelefono.Font = new Font("Verdana", 10F);
            MtxtTelefono.ForeColor = SystemColors.ControlText;
            MtxtTelefono.Location = new Point(16, 174);
            MtxtTelefono.Margin = new Padding(2, 2, 2, 2);
            MtxtTelefono.Mask = "+1 (999) 000-0000";
            MtxtTelefono.Name = "MtxtTelefono";
            MtxtTelefono.Size = new Size(190, 28);
            MtxtTelefono.TabIndex = 4;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(43, 56, 46);
            lblTelefono.Font = new Font("Verdana", 9F);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(16, 148);
            lblTelefono.Margin = new Padding(2, 0, 2, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 18);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Telefono";
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.BackColor = Color.FromArgb(43, 56, 46);
            lblIdCliente.Font = new Font("Verdana", 9F);
            lblIdCliente.ForeColor = Color.White;
            lblIdCliente.Location = new Point(16, 25);
            lblIdCliente.Margin = new Padding(2, 0, 2, 0);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(77, 18);
            lblIdCliente.TabIndex = 9;
            lblIdCliente.Text = "Id Cliente";
            // 
            // MtxtRnc
            // 
            MtxtRnc.Font = new Font("Verdana", 10F);
            MtxtRnc.Location = new Point(16, 231);
            MtxtRnc.Margin = new Padding(2, 2, 2, 2);
            MtxtRnc.Mask = "000-0000000-0";
            MtxtRnc.Name = "MtxtRnc";
            MtxtRnc.Size = new Size(190, 28);
            MtxtRnc.TabIndex = 5;
            // 
            // lblRnc
            // 
            lblRnc.AutoSize = true;
            lblRnc.BackColor = Color.FromArgb(43, 56, 46);
            lblRnc.Font = new Font("Verdana", 9F);
            lblRnc.ForeColor = Color.White;
            lblRnc.Location = new Point(16, 206);
            lblRnc.Margin = new Padding(2, 0, 2, 0);
            lblRnc.Name = "lblRnc";
            lblRnc.Size = new Size(40, 18);
            lblRnc.TabIndex = 12;
            lblRnc.Text = "RNC";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Lucida Sans", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(43, 56, 46);
            lblTitulo.Location = new Point(45, 33);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(158, 39);
            lblTitulo.TabIndex = 105;
            lblTitulo.Text = "Clientes";
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnEditarCliente.Location = new Point(45, 563);
            btnEditarCliente.Margin = new Padding(2, 2, 2, 2);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(129, 32);
            btnEditarCliente.TabIndex = 104;
            btnEditarCliente.Text = "Editar Cliente";
            btnEditarCliente.UseVisualStyleBackColor = true;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Location = new Point(45, 88);
            dgvClientes.Margin = new Padding(2, 2, 2, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(734, 440);
            dgvClientes.TabIndex = 114;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnBuscar.Location = new Point(425, 563);
            btnBuscar.Margin = new Padding(2, 2, 2, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(155, 32);
            btnBuscar.TabIndex = 115;
            btnBuscar.Text = "Buscar por Id";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnEliminarCliente.Location = new Point(615, 563);
            btnEliminarCliente.Margin = new Padding(2, 2, 2, 2);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(155, 32);
            btnEliminarCliente.TabIndex = 116;
            btnEliminarCliente.Text = "Eliminar Cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // pbAtras
            // 
            pbAtras.Image = Properties.Resources.Flecha_hacia_atras;
            pbAtras.Location = new Point(734, 46);
            pbAtras.Margin = new Padding(2, 2, 2, 2);
            pbAtras.Name = "pbAtras";
            pbAtras.Size = new Size(46, 37);
            pbAtras.SizeMode = PictureBoxSizeMode.Zoom;
            pbAtras.TabIndex = 117;
            pbAtras.TabStop = false;
            pbAtras.Click += pbAtras_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(798, 130);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 39);
            pictureBox1.TabIndex = 118;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(798, 174);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 39);
            pictureBox2.TabIndex = 119;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(798, 218);
            pictureBox3.Margin = new Padding(2, 2, 2, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 39);
            pictureBox3.TabIndex = 120;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(798, 262);
            pictureBox4.Margin = new Padding(2, 2, 2, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 39);
            pictureBox4.TabIndex = 121;
            pictureBox4.TabStop = false;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1145, 622);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pbAtras);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardarCliente);
            Controls.Add(gbDatosC);
            Controls.Add(lblTitulo);
            Controls.Add(btnEditarCliente);
            Controls.Add(dgvClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Clientes_Load;
            gbDatosC.ResumeLayout(false);
            gbDatosC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBuscarIdCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCorreo;
        private Label lblCorreo;
        private Button btnGuardarCliente;
        private GroupBox gbDatosC;
        private PictureBox pbBuscarIdCliente;
        private TextBox txtIdCliente;
        private TextBox txtNombre;
        private Label lblNombre;
        private MaskedTextBox MtxtTelefono;
        private Label lblTelefono;
        private Label lblIdCliente;
        private MaskedTextBox MtxtRnc;
        private Label lblRnc;
        private Label lblTitulo;
        private Button btnEditarCliente;
        private DataGridView dgvClientes;
        private Button btnBuscar;
        private Button btnEliminarCliente;
        private PictureBox pbAtras;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}