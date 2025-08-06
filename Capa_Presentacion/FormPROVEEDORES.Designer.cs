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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPROVEEDORES));
            lblRNC = new Label();
            lblNOMBRE = new Label();
            lblTELEFONO = new Label();
            lblTIPO = new Label();
            btnBUSCAR = new Button();
            lnlPRODUCTO = new Label();
            TxtPRODUCTO = new TextBox();
            dgvPROVEEDORES = new DataGridView();
            btnREGISTRARLISTATEMP = new Button();
            label1 = new Label();
            TxtTELEFONO = new MaskedTextBox();
            TxtRNC = new MaskedTextBox();
            btnLIMPIAR = new Button();
            btnELIMINAR = new Button();
            TxtNOMBRE = new TextBox();
            btnEDITAR = new Button();
            cmbTipoProveedor = new ComboBox();
            pictureBox1 = new PictureBox();
            lblPRECIO = new Label();
            TxtPRECIO = new TextBox();
            groupBox1 = new GroupBox();
            TxtIDPROVEEDOR = new TextBox();
            lblIDPROVEEDOR = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPROVEEDORES).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRNC
            // 
            lblRNC.AutoSize = true;
            lblRNC.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRNC.Location = new Point(16, 125);
            lblRNC.Name = "lblRNC";
            lblRNC.Size = new Size(40, 18);
            lblRNC.TabIndex = 0;
            lblRNC.Text = "RNC";
            // 
            // lblNOMBRE
            // 
            lblNOMBRE.AutoSize = true;
            lblNOMBRE.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNOMBRE.Location = new Point(11, 184);
            lblNOMBRE.Name = "lblNOMBRE";
            lblNOMBRE.Size = new Size(68, 18);
            lblNOMBRE.TabIndex = 1;
            lblNOMBRE.Text = "Nombre";
            // 
            // lblTELEFONO
            // 
            lblTELEFONO.AutoSize = true;
            lblTELEFONO.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTELEFONO.Location = new Point(11, 247);
            lblTELEFONO.Name = "lblTELEFONO";
            lblTELEFONO.Size = new Size(70, 18);
            lblTELEFONO.TabIndex = 2;
            lblTELEFONO.Text = "Telefono";
            // 
            // lblTIPO
            // 
            lblTIPO.AutoSize = true;
            lblTIPO.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTIPO.Location = new Point(16, 311);
            lblTIPO.Name = "lblTIPO";
            lblTIPO.Size = new Size(39, 18);
            lblTIPO.TabIndex = 3;
            lblTIPO.Text = "Tipo";
            // 
            // btnBUSCAR
            // 
            btnBUSCAR.BackColor = Color.FromArgb(111, 129, 105);
            btnBUSCAR.FlatStyle = FlatStyle.Flat;
            btnBUSCAR.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBUSCAR.Location = new Point(37, 450);
            btnBUSCAR.Name = "btnBUSCAR";
            btnBUSCAR.Size = new Size(94, 29);
            btnBUSCAR.TabIndex = 12;
            btnBUSCAR.Text = "Buscar";
            btnBUSCAR.UseVisualStyleBackColor = false;
            btnBUSCAR.Click += btnBUSCAR_Click;
            // 
            // lnlPRODUCTO
            // 
            lnlPRODUCTO.AutoSize = true;
            lnlPRODUCTO.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnlPRODUCTO.Location = new Point(11, 375);
            lnlPRODUCTO.Name = "lnlPRODUCTO";
            lnlPRODUCTO.Size = new Size(75, 18);
            lnlPRODUCTO.TabIndex = 13;
            lnlPRODUCTO.Text = "Producto";
            // 
            // TxtPRODUCTO
            // 
            TxtPRODUCTO.BackColor = Color.White;
            TxtPRODUCTO.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPRODUCTO.Location = new Point(92, 367);
            TxtPRODUCTO.Name = "TxtPRODUCTO";
            TxtPRODUCTO.Size = new Size(253, 26);
            TxtPRODUCTO.TabIndex = 15;
            // 
            // dgvPROVEEDORES
            // 
            dgvPROVEEDORES.AllowUserToAddRows = false;
            dgvPROVEEDORES.AllowUserToResizeRows = false;
            dgvPROVEEDORES.BackgroundColor = Color.FromArgb(245, 247, 246);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(85, 58, 29);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPROVEEDORES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPROVEEDORES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(111, 129, 105);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPROVEEDORES.DefaultCellStyle = dataGridViewCellStyle5;
            dgvPROVEEDORES.Location = new Point(22, 82);
            dgvPROVEEDORES.Name = "dgvPROVEEDORES";
            dgvPROVEEDORES.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPROVEEDORES.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPROVEEDORES.RowHeadersWidth = 51;
            dgvPROVEEDORES.Size = new Size(843, 343);
            dgvPROVEEDORES.TabIndex = 16;
            dgvPROVEEDORES.CellMouseClick += dgvLISTATEMPORAL_CellMouseClick;
            // 
            // btnREGISTRARLISTATEMP
            // 
            btnREGISTRARLISTATEMP.BackColor = Color.FromArgb(111, 129, 105);
            btnREGISTRARLISTATEMP.FlatStyle = FlatStyle.Flat;
            btnREGISTRARLISTATEMP.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnREGISTRARLISTATEMP.Location = new Point(173, 450);
            btnREGISTRARLISTATEMP.Name = "btnREGISTRARLISTATEMP";
            btnREGISTRARLISTATEMP.Size = new Size(94, 29);
            btnREGISTRARLISTATEMP.TabIndex = 17;
            btnREGISTRARLISTATEMP.Text = "Registrar ";
            btnREGISTRARLISTATEMP.UseVisualStyleBackColor = false;
            btnREGISTRARLISTATEMP.Click += btnREGISTRAR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Lucida Sans", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(111, 129, 105);
            label1.Location = new Point(261, 12);
            label1.Name = "label1";
            label1.Size = new Size(368, 50);
            label1.TabIndex = 18;
            label1.Text = " PROVEEDORES";
            // 
            // TxtTELEFONO
            // 
            TxtTELEFONO.BackColor = Color.White;
            TxtTELEFONO.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTELEFONO.Location = new Point(92, 239);
            TxtTELEFONO.Mask = "(999)-000-0000";
            TxtTELEFONO.Name = "TxtTELEFONO";
            TxtTELEFONO.Size = new Size(253, 26);
            TxtTELEFONO.TabIndex = 19;
            // 
            // TxtRNC
            // 
            TxtRNC.BackColor = Color.White;
            TxtRNC.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtRNC.Location = new Point(92, 117);
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
            btnLIMPIAR.Location = new Point(1127, 534);
            btnLIMPIAR.Name = "btnLIMPIAR";
            btnLIMPIAR.Size = new Size(94, 29);
            btnLIMPIAR.TabIndex = 21;
            btnLIMPIAR.Text = "Limpiar";
            btnLIMPIAR.UseVisualStyleBackColor = false;
            btnLIMPIAR.Click += btnLIMPIAR_Click;
            // 
            // btnELIMINAR
            // 
            btnELIMINAR.BackColor = Color.FromArgb(111, 129, 105);
            btnELIMINAR.FlatStyle = FlatStyle.Flat;
            btnELIMINAR.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnELIMINAR.Location = new Point(459, 450);
            btnELIMINAR.Name = "btnELIMINAR";
            btnELIMINAR.Size = new Size(94, 29);
            btnELIMINAR.TabIndex = 23;
            btnELIMINAR.Text = "Eliminar";
            btnELIMINAR.UseVisualStyleBackColor = false;
            btnELIMINAR.Click += btnELIMINAR_Click;
            // 
            // TxtNOMBRE
            // 
            TxtNOMBRE.BackColor = Color.White;
            TxtNOMBRE.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNOMBRE.Location = new Point(92, 176);
            TxtNOMBRE.Name = "TxtNOMBRE";
            TxtNOMBRE.Size = new Size(253, 26);
            TxtNOMBRE.TabIndex = 24;
            TxtNOMBRE.TextChanged += TxtNOMBRE_TextChanged;
            // 
            // btnEDITAR
            // 
            btnEDITAR.BackColor = Color.FromArgb(111, 129, 105);
            btnEDITAR.FlatStyle = FlatStyle.Flat;
            btnEDITAR.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEDITAR.Location = new Point(314, 450);
            btnEDITAR.Name = "btnEDITAR";
            btnEDITAR.Size = new Size(94, 29);
            btnEDITAR.TabIndex = 26;
            btnEDITAR.Text = "Editar";
            btnEDITAR.UseVisualStyleBackColor = false;
            btnEDITAR.Click += btnEDITAR_Click;
            // 
            // cmbTipoProveedor
            // 
            cmbTipoProveedor.BackColor = Color.White;
            cmbTipoProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoProveedor.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoProveedor.FormattingEnabled = true;
            cmbTipoProveedor.Location = new Point(92, 303);
            cmbTipoProveedor.Name = "cmbTipoProveedor";
            cmbTipoProveedor.Size = new Size(253, 26);
            cmbTipoProveedor.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblPRECIO
            // 
            lblPRECIO.AutoSize = true;
            lblPRECIO.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPRECIO.Location = new Point(11, 443);
            lblPRECIO.Name = "lblPRECIO";
            lblPRECIO.Size = new Size(53, 18);
            lblPRECIO.TabIndex = 29;
            lblPRECIO.Text = "Precio";
            // 
            // TxtPRECIO
            // 
            TxtPRECIO.BackColor = Color.White;
            TxtPRECIO.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPRECIO.Location = new Point(92, 429);
            TxtPRECIO.Name = "TxtPRECIO";
            TxtPRECIO.Size = new Size(253, 26);
            TxtPRECIO.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(111, 129, 105);
            groupBox1.Controls.Add(TxtIDPROVEEDOR);
            groupBox1.Controls.Add(lblIDPROVEEDOR);
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
            groupBox1.Location = new Point(953, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 492);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Proveedores";
            // 
            // TxtIDPROVEEDOR
            // 
            TxtIDPROVEEDOR.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIDPROVEEDOR.Location = new Point(92, 56);
            TxtIDPROVEEDOR.Name = "TxtIDPROVEEDOR";
            TxtIDPROVEEDOR.Size = new Size(253, 26);
            TxtIDPROVEEDOR.TabIndex = 33;
            // 
            // lblIDPROVEEDOR
            // 
            lblIDPROVEEDOR.AutoSize = true;
            lblIDPROVEEDOR.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIDPROVEEDOR.Location = new Point(11, 64);
            lblIDPROVEEDOR.Name = "lblIDPROVEEDOR";
            lblIDPROVEEDOR.Size = new Size(24, 18);
            lblIDPROVEEDOR.TabIndex = 32;
            lblIDPROVEEDOR.Text = "ID";
            // 
            // FormPROVEEDORES
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1369, 657);
            Controls.Add(pictureBox1);
            Controls.Add(btnEDITAR);
            Controls.Add(btnELIMINAR);
            Controls.Add(btnLIMPIAR);
            Controls.Add(label1);
            Controls.Add(btnREGISTRARLISTATEMP);
            Controls.Add(dgvPROVEEDORES);
            Controls.Add(btnBUSCAR);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPROVEEDORES";
            Text = "FormLISTATEMPORAL";
            Load += FormPROVEEDORES_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPROVEEDORES).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btnREGISTRARLISTATEMP;
        private Label label1;
        private MaskedTextBox TxtTELEFONO;
        private MaskedTextBox TxtRNC;
        private Button btnLIMPIAR;
        private Button btnELIMINAR;
        private TextBox TxtNOMBRE;
        private Button btnEDITAR;
        private ComboBox cmbTipoProveedor;
        private PictureBox pictureBox1;
        private Label lblPRECIO;
        private TextBox TxtPRECIO;
        private GroupBox groupBox1;
        private TextBox TxtIDPROVEEDOR;
        private Label lblIDPROVEEDOR;
    }
}
