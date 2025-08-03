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
            dataGridView1 = new DataGridView();
            gbDatosC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBuscarIdCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(20, 379);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(236, 36);
            txtCorreo.TabIndex = 115;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.FromArgb(88, 173, 83);
            lblCorreo.Font = new Font("Verdana", 9F);
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(20, 354);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(72, 22);
            lblCorreo.TabIndex = 111;
            lblCorreo.Text = "Correo";
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.BackColor = SystemColors.MenuBar;
            btnGuardarCliente.Location = new Point(945, 649);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(142, 51);
            btnGuardarCliente.TabIndex = 107;
            btnGuardarCliente.Text = "button6";
            btnGuardarCliente.UseVisualStyleBackColor = false;
            // 
            // gbDatosC
            // 
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
            gbDatosC.Location = new Point(881, 136);
            gbDatosC.Name = "gbDatosC";
            gbDatosC.Size = new Size(342, 433);
            gbDatosC.TabIndex = 108;
            gbDatosC.TabStop = false;
            gbDatosC.Text = "Datos del Cliente";
            // 
            // pbBuscarIdCliente
            // 
            pbBuscarIdCliente.BackColor = Color.Transparent;
            pbBuscarIdCliente.Location = new Point(112, 69);
            pbBuscarIdCliente.Name = "pbBuscarIdCliente";
            pbBuscarIdCliente.Size = new Size(30, 36);
            pbBuscarIdCliente.SizeMode = PictureBoxSizeMode.Zoom;
            pbBuscarIdCliente.TabIndex = 13;
            pbBuscarIdCliente.TabStop = false;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 9F);
            txtIdCliente.Location = new Point(20, 69);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(82, 31);
            txtIdCliente.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(20, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 31);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(88, 173, 83);
            lblNombre.Font = new Font("Verdana", 9F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(20, 116);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 22);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // MtxtTelefono
            // 
            MtxtTelefono.Font = new Font("Segoe UI", 9F);
            MtxtTelefono.ForeColor = SystemColors.ControlText;
            MtxtTelefono.Location = new Point(20, 233);
            MtxtTelefono.Name = "MtxtTelefono";
            MtxtTelefono.Size = new Size(236, 31);
            MtxtTelefono.TabIndex = 4;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(88, 173, 83);
            lblTelefono.Font = new Font("Verdana", 9F);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(20, 201);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(85, 22);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Telefono";
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.BackColor = Color.FromArgb(88, 173, 83);
            lblIdCliente.Font = new Font("Verdana", 9F);
            lblIdCliente.ForeColor = Color.White;
            lblIdCliente.Location = new Point(20, 37);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(98, 22);
            lblIdCliente.TabIndex = 9;
            lblIdCliente.Text = "Id Cliente";
            // 
            // MtxtRnc
            // 
            MtxtRnc.Font = new Font("Segoe UI", 9F);
            MtxtRnc.Location = new Point(20, 305);
            MtxtRnc.Name = "MtxtRnc";
            MtxtRnc.Size = new Size(236, 31);
            MtxtRnc.TabIndex = 5;
            // 
            // lblRnc
            // 
            lblRnc.AutoSize = true;
            lblRnc.BackColor = Color.FromArgb(88, 173, 83);
            lblRnc.Font = new Font("Verdana", 9F);
            lblRnc.ForeColor = Color.White;
            lblRnc.Location = new Point(20, 273);
            lblRnc.Name = "lblRnc";
            lblRnc.Size = new Size(49, 22);
            lblRnc.TabIndex = 12;
            lblRnc.Text = "RNC";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(88, 173, 83);
            lblTitulo.Font = new Font("Lucida Sans", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(89, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(182, 45);
            lblTitulo.TabIndex = 105;
            lblTitulo.Text = "Clientes";
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(964, 599);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(112, 34);
            btnEditarCliente.TabIndex = 104;
            btnEditarCliente.Text = "button3";
            btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(89, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(726, 564);
            dataGridView1.TabIndex = 114;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(88, 173, 83);
            ClientSize = new Size(1250, 767);
            Controls.Add(btnGuardarCliente);
            Controls.Add(gbDatosC);
            Controls.Add(lblTitulo);
            Controls.Add(btnEditarCliente);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clientes";
            gbDatosC.ResumeLayout(false);
            gbDatosC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBuscarIdCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
    }
}