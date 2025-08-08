namespace Capa.Presentacion
{
    partial class FormPROVEEDORES
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPROVEEDORES));
            lblRNC = new Label();
            lblNOMBRE = new Label();
            lblTELEFONO = new Label();
            lblTIPO = new Label();
            btnBUSCAR = new Button();
            lnlPRODUCTO = new Label();
            TxtPRODUCTO = new TextBox();
            dgvPROVEEDORES = new DataGridView();
            btnREGISTRAR = new Button();
            label1 = new Label();
            TxtTELEFONO = new MaskedTextBox();
            TxtRNC = new MaskedTextBox();
            btnLIMPIAR = new Button();
            btnELIMINAR = new Button();
            TxtNOMBRE = new TextBox();
            btnEDITAR = new Button();
            cmbTipoProveedor = new ComboBox();
            lblPRECIO = new Label();
            TxtPRECIO = new TextBox();
            groupBox1 = new GroupBox();
            pbRegistrar = new PictureBox();
            pbBuscar = new PictureBox();
            pbEditar = new PictureBox();
            pbLimpiar = new PictureBox();
            pbBorrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPROVEEDORES).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRegistrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLimpiar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBorrar).BeginInit();
            SuspendLayout();
            // 
            // lblRNC
            // 
            lblRNC.AutoSize = true;
            lblRNC.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblRNC.Location = new Point(11, 70);
            lblRNC.Name = "lblRNC";
            lblRNC.Size = new Size(43, 18);
            lblRNC.TabIndex = 0;
            lblRNC.Text = "RNC";
            // 
            // lblNOMBRE
            // 
            lblNOMBRE.AutoSize = true;
            lblNOMBRE.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblNOMBRE.Location = new Point(6, 140);
            lblNOMBRE.Name = "lblNOMBRE";
            lblNOMBRE.Size = new Size(73, 18);
            lblNOMBRE.TabIndex = 1;
            lblNOMBRE.Text = "Nombre";
            // 
            // lblTELEFONO
            // 
            lblTELEFONO.AutoSize = true;
            lblTELEFONO.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblTELEFONO.Location = new Point(11, 213);
            lblTELEFONO.Name = "lblTELEFONO";
            lblTELEFONO.Size = new Size(78, 18);
            lblTELEFONO.TabIndex = 2;
            lblTELEFONO.Text = "Telefono";
            // 
            // lblTIPO
            // 
            lblTIPO.AutoSize = true;
            lblTIPO.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblTIPO.Location = new Point(11, 295);
            lblTIPO.Name = "lblTIPO";
            lblTIPO.Size = new Size(42, 18);
            lblTIPO.TabIndex = 3;
            lblTIPO.Text = "Tipo";
            // 
            // btnBUSCAR
            // 
            btnBUSCAR.BackColor = Color.FromArgb(111, 129, 105);
            btnBUSCAR.FlatStyle = FlatStyle.Flat;
            btnBUSCAR.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBUSCAR.Location = new Point(686, 411);
            btnBUSCAR.Name = "btnBUSCAR";
            btnBUSCAR.Size = new Size(161, 50);
            btnBUSCAR.TabIndex = 12;
            btnBUSCAR.Text = "Buscar";
            btnBUSCAR.UseVisualStyleBackColor = false;
            btnBUSCAR.Visible = false;
            btnBUSCAR.Click += btnBUSCAR_Click;
            // 
            // lnlPRODUCTO
            // 
            lnlPRODUCTO.AutoSize = true;
            lnlPRODUCTO.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lnlPRODUCTO.Location = new Point(11, 369);
            lnlPRODUCTO.Name = "lnlPRODUCTO";
            lnlPRODUCTO.Size = new Size(81, 18);
            lnlPRODUCTO.TabIndex = 13;
            lnlPRODUCTO.Text = "Producto";
            // 
            // TxtPRODUCTO
            // 
            TxtPRODUCTO.BackColor = Color.White;
            TxtPRODUCTO.Enabled = false;
            TxtPRODUCTO.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPRODUCTO.Location = new Point(92, 361);
            TxtPRODUCTO.Name = "TxtPRODUCTO";
            TxtPRODUCTO.Size = new Size(253, 26);
            TxtPRODUCTO.TabIndex = 15;
            TxtPRODUCTO.KeyPress += TxtPRODUCTO_KeyPress;
            // 
            // dgvPROVEEDORES
            // 
            dgvPROVEEDORES.AllowUserToAddRows = false;
            dgvPROVEEDORES.AllowUserToDeleteRows = false;
            dgvPROVEEDORES.AllowUserToResizeColumns = false;
            dgvPROVEEDORES.AllowUserToResizeRows = false;
            dgvPROVEEDORES.BackgroundColor = SystemColors.Window;
            dgvPROVEEDORES.BorderStyle = BorderStyle.None;
            dgvPROVEEDORES.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvPROVEEDORES.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPROVEEDORES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPROVEEDORES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(111, 129, 105);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPROVEEDORES.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPROVEEDORES.EnableHeadersVisualStyles = false;
            dgvPROVEEDORES.GridColor = SystemColors.Window;
            dgvPROVEEDORES.Location = new Point(27, 82);
            dgvPROVEEDORES.Name = "dgvPROVEEDORES";
            dgvPROVEEDORES.ReadOnly = true;
            dgvPROVEEDORES.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle3.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(111, 129, 105);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPROVEEDORES.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPROVEEDORES.RowHeadersWidth = 51;
            dgvPROVEEDORES.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPROVEEDORES.Size = new Size(820, 323);
            dgvPROVEEDORES.TabIndex = 16;
            dgvPROVEEDORES.CellMouseClick += dgvLISTATEMPORAL_CellMouseClick;
            // 
            // btnREGISTRAR
            // 
            btnREGISTRAR.BackColor = Color.FromArgb(111, 129, 105);
            btnREGISTRAR.FlatStyle = FlatStyle.Flat;
            btnREGISTRAR.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnREGISTRAR.Location = new Point(686, 411);
            btnREGISTRAR.Name = "btnREGISTRAR";
            btnREGISTRAR.Size = new Size(161, 50);
            btnREGISTRAR.TabIndex = 17;
            btnREGISTRAR.Text = "Registrar ";
            btnREGISTRAR.UseVisualStyleBackColor = false;
            btnREGISTRAR.Visible = false;
            btnREGISTRAR.Click += btnREGISTRAR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 39, 33);
            label1.Location = new Point(271, 12);
            label1.Name = "label1";
            label1.Size = new Size(338, 45);
            label1.TabIndex = 18;
            label1.Text = " PROVEEDORES";
            // 
            // TxtTELEFONO
            // 
            TxtTELEFONO.BackColor = Color.White;
            TxtTELEFONO.Enabled = false;
            TxtTELEFONO.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTELEFONO.Location = new Point(92, 205);
            TxtTELEFONO.Mask = "+1 (000)-000-0000";
            TxtTELEFONO.Name = "TxtTELEFONO";
            TxtTELEFONO.Size = new Size(253, 26);
            TxtTELEFONO.TabIndex = 19;
            // 
            // TxtRNC
            // 
            TxtRNC.BackColor = Color.White;
            TxtRNC.Enabled = false;
            TxtRNC.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtRNC.Location = new Point(92, 62);
            TxtRNC.Mask = "999999999";
            TxtRNC.Name = "TxtRNC";
            TxtRNC.Size = new Size(253, 26);
            TxtRNC.TabIndex = 20;
            // 
            // btnLIMPIAR
            // 
            btnLIMPIAR.BackColor = Color.FromArgb(111, 129, 105);
            btnLIMPIAR.FlatStyle = FlatStyle.Flat;
            btnLIMPIAR.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLIMPIAR.ImageAlign = ContentAlignment.MiddleLeft;
            btnLIMPIAR.Location = new Point(686, 411);
            btnLIMPIAR.Name = "btnLIMPIAR";
            btnLIMPIAR.Size = new Size(161, 50);
            btnLIMPIAR.TabIndex = 21;
            btnLIMPIAR.Text = "Limpiar";
            btnLIMPIAR.UseVisualStyleBackColor = false;
            btnLIMPIAR.Visible = false;
            btnLIMPIAR.Click += btnLIMPIAR_Click;
            // 
            // btnELIMINAR
            // 
            btnELIMINAR.BackColor = Color.FromArgb(111, 129, 105);
            btnELIMINAR.FlatStyle = FlatStyle.Flat;
            btnELIMINAR.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnELIMINAR.Location = new Point(686, 411);
            btnELIMINAR.Name = "btnELIMINAR";
            btnELIMINAR.Size = new Size(161, 50);
            btnELIMINAR.TabIndex = 23;
            btnELIMINAR.Text = "Eliminar";
            btnELIMINAR.UseVisualStyleBackColor = false;
            btnELIMINAR.Visible = false;
            btnELIMINAR.Click += btnELIMINAR_Click;
            // 
            // TxtNOMBRE
            // 
            TxtNOMBRE.BackColor = Color.White;
            TxtNOMBRE.Enabled = false;
            TxtNOMBRE.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNOMBRE.Location = new Point(92, 132);
            TxtNOMBRE.Name = "TxtNOMBRE";
            TxtNOMBRE.Size = new Size(253, 26);
            TxtNOMBRE.TabIndex = 24;
            TxtNOMBRE.TextChanged += TxtNOMBRE_TextChanged;
            TxtNOMBRE.KeyPress += TxtNOMBRE_KeyPress;
            // 
            // btnEDITAR
            // 
            btnEDITAR.BackColor = Color.FromArgb(43, 56, 46);
            btnEDITAR.FlatStyle = FlatStyle.Flat;
            btnEDITAR.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEDITAR.ForeColor = Color.White;
            btnEDITAR.Location = new Point(686, 411);
            btnEDITAR.Name = "btnEDITAR";
            btnEDITAR.Size = new Size(161, 50);
            btnEDITAR.TabIndex = 26;
            btnEDITAR.Text = "Editar";
            btnEDITAR.UseVisualStyleBackColor = false;
            btnEDITAR.Visible = false;
            btnEDITAR.Click += btnEDITAR_Click;
            // 
            // cmbTipoProveedor
            // 
            cmbTipoProveedor.BackColor = Color.White;
            cmbTipoProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoProveedor.Enabled = false;
            cmbTipoProveedor.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoProveedor.FormattingEnabled = true;
            cmbTipoProveedor.Location = new Point(92, 287);
            cmbTipoProveedor.Name = "cmbTipoProveedor";
            cmbTipoProveedor.Size = new Size(253, 26);
            cmbTipoProveedor.TabIndex = 27;
            // 
            // lblPRECIO
            // 
            lblPRECIO.AutoSize = true;
            lblPRECIO.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblPRECIO.Location = new Point(11, 443);
            lblPRECIO.Name = "lblPRECIO";
            lblPRECIO.Size = new Size(58, 18);
            lblPRECIO.TabIndex = 29;
            lblPRECIO.Text = "Precio";
            // 
            // TxtPRECIO
            // 
            TxtPRECIO.BackColor = Color.White;
            TxtPRECIO.Enabled = false;
            TxtPRECIO.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPRECIO.Location = new Point(92, 435);
            TxtPRECIO.Name = "TxtPRECIO";
            TxtPRECIO.Size = new Size(253, 26);
            TxtPRECIO.TabIndex = 30;
            TxtPRECIO.KeyPress += TxtPRECIO_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(43, 56, 46);
            groupBox1.Controls.Add(lblPRECIO);
            groupBox1.Controls.Add(cmbTipoProveedor);
            groupBox1.Controls.Add(TxtNOMBRE);
            groupBox1.Controls.Add(TxtPRECIO);
            groupBox1.Controls.Add(TxtPRODUCTO);
            groupBox1.Controls.Add(TxtRNC);
            groupBox1.Controls.Add(TxtTELEFONO);
            groupBox1.Controls.Add(lblTELEFONO);
            groupBox1.Controls.Add(lblTIPO);
            groupBox1.Controls.Add(lnlPRODUCTO);
            groupBox1.Controls.Add(lblNOMBRE);
            groupBox1.Controls.Add(lblRNC);
            groupBox1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(982, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 492);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Proveedores";
            // 
            // pbRegistrar
            // 
            pbRegistrar.Image = (Image)resources.GetObject("pbRegistrar.Image");
            pbRegistrar.Location = new Point(884, 82);
            pbRegistrar.Name = "pbRegistrar";
            pbRegistrar.Size = new Size(80, 52);
            pbRegistrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbRegistrar.TabIndex = 32;
            pbRegistrar.TabStop = false;
            pbRegistrar.Click += pictureBox2_Click;
            // 
            // pbBuscar
            // 
            pbBuscar.Image = (Image)resources.GetObject("pbBuscar.Image");
            pbBuscar.Location = new Point(884, 152);
            pbBuscar.Name = "pbBuscar";
            pbBuscar.Size = new Size(80, 52);
            pbBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            pbBuscar.TabIndex = 33;
            pbBuscar.TabStop = false;
            pbBuscar.Click += pbBuscar_Click;
            // 
            // pbEditar
            // 
            pbEditar.Image = (Image)resources.GetObject("pbEditar.Image");
            pbEditar.Location = new Point(884, 225);
            pbEditar.Name = "pbEditar";
            pbEditar.Size = new Size(80, 52);
            pbEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pbEditar.TabIndex = 34;
            pbEditar.TabStop = false;
            pbEditar.Click += pbEditar_Click;
            // 
            // pbLimpiar
            // 
            pbLimpiar.Image = (Image)resources.GetObject("pbLimpiar.Image");
            pbLimpiar.Location = new Point(884, 373);
            pbLimpiar.Name = "pbLimpiar";
            pbLimpiar.Size = new Size(80, 52);
            pbLimpiar.SizeMode = PictureBoxSizeMode.Zoom;
            pbLimpiar.TabIndex = 35;
            pbLimpiar.TabStop = false;
            pbLimpiar.Click += pbLimpiar_Click;
            // 
            // pbBorrar
            // 
            pbBorrar.Image = (Image)resources.GetObject("pbBorrar.Image");
            pbBorrar.Location = new Point(884, 299);
            pbBorrar.Name = "pbBorrar";
            pbBorrar.Size = new Size(80, 52);
            pbBorrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbBorrar.TabIndex = 36;
            pbBorrar.TabStop = false;
            pbBorrar.Click += pbBorrar_Click;
            // 
            // FormPROVEEDORES
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1381, 533);
            Controls.Add(pbBorrar);
            Controls.Add(pbLimpiar);
            Controls.Add(pbEditar);
            Controls.Add(pbBuscar);
            Controls.Add(pbRegistrar);
            Controls.Add(btnEDITAR);
            Controls.Add(btnELIMINAR);
            Controls.Add(btnLIMPIAR);
            Controls.Add(label1);
            Controls.Add(btnREGISTRAR);
            Controls.Add(dgvPROVEEDORES);
            Controls.Add(btnBUSCAR);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPROVEEDORES";
            Text = "FormLISTATEMPORAL";
            Load += FormPROVEEDORES_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPROVEEDORES).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRegistrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLimpiar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBorrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRNC;
        private Label lblNOMBRE;
        private Label lblTELEFONO;
        private Label lblTIPO;
        private Button btnBUSCAR;
        private Label lnlPRODUCTO;
        private TextBox TxtPRODUCTO;
        private DataGridView dgvPROVEEDORES;
        private Button btnREGISTRAR;
        private Label label1;
        private MaskedTextBox TxtTELEFONO;
        private MaskedTextBox TxtRNC;
        private Button btnLIMPIAR;
        private Button btnELIMINAR;
        private TextBox TxtNOMBRE;
        private Button btnEDITAR;
        private ComboBox cmbTipoProveedor;
        private Label lblPRECIO;
        private TextBox TxtPRECIO;
        private GroupBox groupBox1;
        private PictureBox pbRegistrar;
        private PictureBox pbBuscar;
        private PictureBox pbEditar;
        private PictureBox pbLimpiar;
        private PictureBox pbBorrar;
    }
}
