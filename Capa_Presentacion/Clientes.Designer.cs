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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            btnGuardarCliente = new Button();
            gbDatosC = new GroupBox();
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
            pbBuscar = new PictureBox();
            pbRegistrar = new PictureBox();
            pbEditar = new PictureBox();
            pbEliminar = new PictureBox();
            gbDatosC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRegistrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEliminar).BeginInit();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.Enabled = false;
            txtCorreo.Font = new Font("Verdana", 10F);
            txtCorreo.Location = new Point(20, 355);
            txtCorreo.Margin = new Padding(2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(258, 32);
            txtCorreo.TabIndex = 115;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.FromArgb(111, 129, 105);
            lblCorreo.Font = new Font("Verdana", 9F);
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(20, 331);
            lblCorreo.Margin = new Padding(2, 0, 2, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(72, 22);
            lblCorreo.TabIndex = 111;
            lblCorreo.Text = "Correo";
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.BackColor = Color.FromArgb(111, 129, 105);
            btnGuardarCliente.Enabled = false;
            btnGuardarCliente.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnGuardarCliente.ForeColor = Color.White;
            btnGuardarCliente.Location = new Point(802, 660);
            btnGuardarCliente.Margin = new Padding(2);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(161, 40);
            btnGuardarCliente.TabIndex = 107;
            btnGuardarCliente.Text = "Guardar";
            btnGuardarCliente.UseVisualStyleBackColor = false;
            btnGuardarCliente.Click += btnGuardarCliente_Click;
            // 
            // gbDatosC
            // 
            gbDatosC.BackColor = Color.FromArgb(111, 129, 105);
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
            gbDatosC.Location = new Point(1063, 88);
            gbDatosC.Margin = new Padding(2);
            gbDatosC.Name = "gbDatosC";
            gbDatosC.Padding = new Padding(2);
            gbDatosC.Size = new Size(290, 418);
            gbDatosC.TabIndex = 108;
            gbDatosC.TabStop = false;
            gbDatosC.Text = "Datos del Cliente";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Enabled = false;
            txtIdCliente.Font = new Font("Verdana", 10F);
            txtIdCliente.Location = new Point(20, 55);
            txtIdCliente.Margin = new Padding(2);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(82, 32);
            txtIdCliente.TabIndex = 0;
            txtIdCliente.KeyPress += txtIdCliente_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Verdana", 10F);
            txtNombre.Location = new Point(20, 124);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 32);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(111, 129, 105);
            lblNombre.Font = new Font("Verdana", 9F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(20, 100);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 22);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // MtxtTelefono
            // 
            MtxtTelefono.Enabled = false;
            MtxtTelefono.Font = new Font("Verdana", 10F);
            MtxtTelefono.ForeColor = SystemColors.ControlText;
            MtxtTelefono.Location = new Point(20, 200);
            MtxtTelefono.Margin = new Padding(2);
            MtxtTelefono.Mask = "+1 (999) 000-0000";
            MtxtTelefono.Name = "MtxtTelefono";
            MtxtTelefono.Size = new Size(258, 32);
            MtxtTelefono.TabIndex = 4;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(111, 129, 105);
            lblTelefono.Font = new Font("Verdana", 9F);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(20, 176);
            lblTelefono.Margin = new Padding(2, 0, 2, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(85, 22);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Telefono";
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.BackColor = Color.FromArgb(111, 129, 105);
            lblIdCliente.Font = new Font("Verdana", 9F);
            lblIdCliente.ForeColor = Color.White;
            lblIdCliente.Location = new Point(20, 31);
            lblIdCliente.Margin = new Padding(2, 0, 2, 0);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(98, 22);
            lblIdCliente.TabIndex = 9;
            lblIdCliente.Text = "Id Cliente";
            // 
            // MtxtRnc
            // 
            MtxtRnc.Enabled = false;
            MtxtRnc.Font = new Font("Verdana", 10F);
            MtxtRnc.Location = new Point(20, 282);
            MtxtRnc.Margin = new Padding(2);
            MtxtRnc.Mask = "000-0000000-0";
            MtxtRnc.Name = "MtxtRnc";
            MtxtRnc.Size = new Size(258, 32);
            MtxtRnc.TabIndex = 5;
            // 
            // lblRnc
            // 
            lblRnc.AutoSize = true;
            lblRnc.BackColor = Color.FromArgb(111, 129, 105);
            lblRnc.Font = new Font("Verdana", 9F);
            lblRnc.ForeColor = Color.White;
            lblRnc.Location = new Point(20, 251);
            lblRnc.Margin = new Padding(2, 0, 2, 0);
            lblRnc.Name = "lblRnc";
            lblRnc.Size = new Size(49, 22);
            lblRnc.TabIndex = 12;
            lblRnc.Text = "RNC";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Lucida Sans", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(111, 129, 105);
            lblTitulo.Location = new Point(45, 33);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(218, 45);
            lblTitulo.TabIndex = 105;
            lblTitulo.Text = "CLIENTES";
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.BackColor = Color.FromArgb(111, 129, 105);
            btnEditarCliente.Enabled = false;
            btnEditarCliente.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnEditarCliente.ForeColor = Color.White;
            btnEditarCliente.Location = new Point(802, 660);
            btnEditarCliente.Margin = new Padding(2);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(161, 40);
            btnEditarCliente.TabIndex = 104;
            btnEditarCliente.Text = "Editar Cliente";
            btnEditarCliente.UseVisualStyleBackColor = false;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 56, 46);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(111, 129, 105);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.Black;
            dgvClientes.Location = new Point(45, 88);
            dgvClientes.Margin = new Padding(2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(918, 550);
            dgvClientes.TabIndex = 114;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(111, 129, 105);
            btnBuscar.Enabled = false;
            btnBuscar.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(769, 660);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(194, 40);
            btnBuscar.TabIndex = 115;
            btnBuscar.Text = "Buscar por Id";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.BackColor = Color.FromArgb(111, 129, 105);
            btnEliminarCliente.Enabled = false;
            btnEliminarCliente.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnEliminarCliente.ForeColor = Color.White;
            btnEliminarCliente.Location = new Point(769, 660);
            btnEliminarCliente.Margin = new Padding(2);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(194, 40);
            btnEliminarCliente.TabIndex = 116;
            btnEliminarCliente.Text = "Eliminar Cliente";
            btnEliminarCliente.UseVisualStyleBackColor = false;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // pbAtras
            // 
            pbAtras.BackColor = Color.White;
            pbAtras.Image = Properties.Resources.Flecha_hacia_atras;
            pbAtras.Location = new Point(905, 32);
            pbAtras.Margin = new Padding(2);
            pbAtras.Name = "pbAtras";
            pbAtras.Size = new Size(58, 46);
            pbAtras.SizeMode = PictureBoxSizeMode.Zoom;
            pbAtras.TabIndex = 117;
            pbAtras.TabStop = false;
            pbAtras.Click += pbAtras_Click;
            // 
            // pbBuscar
            // 
            pbBuscar.Image = Properties.Resources.Imagen_de_WhatsApp_2025_08_06_a_las_20_52_28_6e773097_removebg_preview;
            pbBuscar.Location = new Point(985, 148);
            pbBuscar.Margin = new Padding(2);
            pbBuscar.Name = "pbBuscar";
            pbBuscar.Size = new Size(58, 49);
            pbBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            pbBuscar.TabIndex = 118;
            pbBuscar.TabStop = false;
            pbBuscar.Click += pbBuscar_Click;
            // 
            // pbRegistrar
            // 
            pbRegistrar.Image = Properties.Resources.address_card_solid_full_removebg_preview1;
            pbRegistrar.Location = new Point(985, 212);
            pbRegistrar.Margin = new Padding(2);
            pbRegistrar.Name = "pbRegistrar";
            pbRegistrar.Size = new Size(60, 49);
            pbRegistrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbRegistrar.TabIndex = 119;
            pbRegistrar.TabStop = false;
            pbRegistrar.Click += pbRegistrar_Click;
            // 
            // pbEditar
            // 
            pbEditar.Image = Properties.Resources.user_pen_solid_full_1_removebg_preview;
            pbEditar.Location = new Point(985, 271);
            pbEditar.Margin = new Padding(2);
            pbEditar.Name = "pbEditar";
            pbEditar.Size = new Size(58, 49);
            pbEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pbEditar.TabIndex = 120;
            pbEditar.TabStop = false;
            pbEditar.Click += pbEditar_Click;
            // 
            // pbEliminar
            // 
            pbEliminar.Image = Properties.Resources.Imagen_de_WhatsApp_2025_08_06_a_las_20_52_28_2dfab1f8_removebg_preview;
            pbEliminar.Location = new Point(985, 330);
            pbEliminar.Margin = new Padding(2);
            pbEliminar.Name = "pbEliminar";
            pbEliminar.Size = new Size(58, 49);
            pbEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            pbEliminar.TabIndex = 121;
            pbEliminar.TabStop = false;
            pbEliminar.Click += pbEliminar_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1385, 772);
            Controls.Add(pbEliminar);
            Controls.Add(pbEditar);
            Controls.Add(pbRegistrar);
            Controls.Add(pbBuscar);
            Controls.Add(pbAtras);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardarCliente);
            Controls.Add(gbDatosC);
            Controls.Add(lblTitulo);
            Controls.Add(btnEditarCliente);
            Controls.Add(dgvClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Clientes_Load;
            gbDatosC.ResumeLayout(false);
            gbDatosC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRegistrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEliminar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCorreo;
        private Label lblCorreo;
        private Button btnGuardarCliente;
        private GroupBox gbDatosC;
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
        private PictureBox pbBuscar;
        private PictureBox pbRegistrar;
        private PictureBox pbEditar;
        private PictureBox pbEliminar;
    }
}