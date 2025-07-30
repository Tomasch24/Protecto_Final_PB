namespace Capa.Presentacion
{
    partial class FormLISTATEMPORAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLISTATEMPORAL));
            lblRNC = new Label();
            lblNOMBRE = new Label();
            lblTELEFONO = new Label();
            lblTIPO = new Label();
            btnBUSCAR = new Button();
            lnlPRODUCTO = new Label();
            TxtPRODUCTO = new TextBox();
            dgvLISTATEMPORAL = new DataGridView();
            btnREGISTRARLISTATEMP = new Button();
            label1 = new Label();
            TxtTELEFONO = new MaskedTextBox();
            TxtRNC = new MaskedTextBox();
            btnLIMPIAR = new Button();
            btnELIMINAR = new Button();
            TxtNOMBRE = new TextBox();
            btnGUARDARENBD = new Button();
            btnEDITAR = new Button();
            cmbTipoProveedor = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvLISTATEMPORAL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRNC
            // 
            lblRNC.AutoSize = true;
            lblRNC.Location = new Point(126, 130);
            lblRNC.Name = "lblRNC";
            lblRNC.Size = new Size(38, 20);
            lblRNC.TabIndex = 0;
            lblRNC.Text = "RNC";
            // 
            // lblNOMBRE
            // 
            lblNOMBRE.AutoSize = true;
            lblNOMBRE.Location = new Point(100, 195);
            lblNOMBRE.Name = "lblNOMBRE";
            lblNOMBRE.Size = new Size(64, 20);
            lblNOMBRE.TabIndex = 1;
            lblNOMBRE.Text = "Nombre";
            // 
            // lblTELEFONO
            // 
            lblTELEFONO.AutoSize = true;
            lblTELEFONO.Location = new Point(97, 254);
            lblTELEFONO.Name = "lblTELEFONO";
            lblTELEFONO.Size = new Size(67, 20);
            lblTELEFONO.TabIndex = 2;
            lblTELEFONO.Text = "Telefono";
            // 
            // lblTIPO
            // 
            lblTIPO.AutoSize = true;
            lblTIPO.Location = new Point(125, 325);
            lblTIPO.Name = "lblTIPO";
            lblTIPO.Size = new Size(39, 20);
            lblTIPO.TabIndex = 3;
            lblTIPO.Text = "Tipo";
            // 
            // btnBUSCAR
            // 
            btnBUSCAR.Location = new Point(97, 510);
            btnBUSCAR.Name = "btnBUSCAR";
            btnBUSCAR.Size = new Size(94, 29);
            btnBUSCAR.TabIndex = 12;
            btnBUSCAR.Text = "Buscar";
            btnBUSCAR.UseVisualStyleBackColor = true;
            btnBUSCAR.Click += btnBUSCAR_Click;
            // 
            // lnlPRODUCTO
            // 
            lnlPRODUCTO.AutoSize = true;
            lnlPRODUCTO.Location = new Point(95, 391);
            lnlPRODUCTO.Name = "lnlPRODUCTO";
            lnlPRODUCTO.Size = new Size(69, 20);
            lnlPRODUCTO.TabIndex = 13;
            lnlPRODUCTO.Text = "Producto";
            // 
            // TxtPRODUCTO
            // 
            TxtPRODUCTO.Location = new Point(170, 384);
            TxtPRODUCTO.Name = "TxtPRODUCTO";
            TxtPRODUCTO.Size = new Size(253, 27);
            TxtPRODUCTO.TabIndex = 15;
            // 
            // dgvLISTATEMPORAL
            // 
            dgvLISTATEMPORAL.AllowUserToAddRows = false;
            dgvLISTATEMPORAL.AllowUserToResizeRows = false;
            dgvLISTATEMPORAL.BackgroundColor = SystemColors.ControlLightLight;
            dgvLISTATEMPORAL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLISTATEMPORAL.Location = new Point(479, 123);
            dgvLISTATEMPORAL.Name = "dgvLISTATEMPORAL";
            dgvLISTATEMPORAL.ReadOnly = true;
            dgvLISTATEMPORAL.RowHeadersWidth = 51;
            dgvLISTATEMPORAL.Size = new Size(685, 296);
            dgvLISTATEMPORAL.TabIndex = 16;
            dgvLISTATEMPORAL.CellMouseClick += dgvLISTATEMPORAL_CellMouseClick;
            // 
            // btnREGISTRARLISTATEMP
            // 
            btnREGISTRARLISTATEMP.Location = new Point(303, 448);
            btnREGISTRARLISTATEMP.Name = "btnREGISTRARLISTATEMP";
            btnREGISTRARLISTATEMP.Size = new Size(94, 29);
            btnREGISTRARLISTATEMP.TabIndex = 17;
            btnREGISTRARLISTATEMP.Text = "Registrar ";
            btnREGISTRARLISTATEMP.UseVisualStyleBackColor = true;
            btnREGISTRARLISTATEMP.Click += btnREGISTRAR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 14);
            label1.Name = "label1";
            label1.Size = new Size(577, 34);
            label1.TabIndex = 18;
            label1.Text = "LISTA TEMPORAL PROVEEDORES";
            // 
            // TxtTELEFONO
            // 
            TxtTELEFONO.Location = new Point(170, 247);
            TxtTELEFONO.Mask = "(999)-000-0000";
            TxtTELEFONO.Name = "TxtTELEFONO";
            TxtTELEFONO.Size = new Size(253, 27);
            TxtTELEFONO.TabIndex = 19;
            // 
            // TxtRNC
            // 
            TxtRNC.Location = new Point(170, 123);
            TxtRNC.Mask = "999999999";
            TxtRNC.Name = "TxtRNC";
            TxtRNC.Size = new Size(253, 27);
            TxtRNC.TabIndex = 20;
            // 
            // btnLIMPIAR
            // 
            btnLIMPIAR.Location = new Point(355, 510);
            btnLIMPIAR.Name = "btnLIMPIAR";
            btnLIMPIAR.Size = new Size(94, 29);
            btnLIMPIAR.TabIndex = 21;
            btnLIMPIAR.Text = "Limpiar";
            btnLIMPIAR.UseVisualStyleBackColor = true;
            btnLIMPIAR.Click += btnLIMPIAR_Click;
            // 
            // btnELIMINAR
            // 
            btnELIMINAR.Location = new Point(228, 510);
            btnELIMINAR.Name = "btnELIMINAR";
            btnELIMINAR.Size = new Size(94, 29);
            btnELIMINAR.TabIndex = 23;
            btnELIMINAR.Text = "Eliminar";
            btnELIMINAR.UseVisualStyleBackColor = true;
            btnELIMINAR.Click += btnELIMINAR_Click;
            // 
            // TxtNOMBRE
            // 
            TxtNOMBRE.Location = new Point(170, 188);
            TxtNOMBRE.Name = "TxtNOMBRE";
            TxtNOMBRE.Size = new Size(253, 27);
            TxtNOMBRE.TabIndex = 24;
            // 
            // btnGUARDARENBD
            // 
            btnGUARDARENBD.Location = new Point(479, 448);
            btnGUARDARENBD.Name = "btnGUARDARENBD";
            btnGUARDARENBD.Size = new Size(134, 29);
            btnGUARDARENBD.TabIndex = 25;
            btnGUARDARENBD.Text = "Guardar en BD";
            btnGUARDARENBD.UseVisualStyleBackColor = true;
            btnGUARDARENBD.Click += btnGUARDARENBD_Click;
            // 
            // btnEDITAR
            // 
            btnEDITAR.Location = new Point(155, 448);
            btnEDITAR.Name = "btnEDITAR";
            btnEDITAR.Size = new Size(94, 29);
            btnEDITAR.TabIndex = 26;
            btnEDITAR.Text = "Editar";
            btnEDITAR.UseVisualStyleBackColor = true;
            btnEDITAR.Click += btnEDITAR_Click;
            // 
            // cmbTipoProveedor
            // 
            cmbTipoProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoProveedor.FormattingEnabled = true;
            cmbTipoProveedor.Location = new Point(170, 317);
            cmbTipoProveedor.Name = "cmbTipoProveedor";
            cmbTipoProveedor.Size = new Size(253, 28);
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
            // FormLISTATEMPORAL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1235, 575);
            Controls.Add(pictureBox1);
            Controls.Add(cmbTipoProveedor);
            Controls.Add(btnEDITAR);
            Controls.Add(btnGUARDARENBD);
            Controls.Add(TxtNOMBRE);
            Controls.Add(btnELIMINAR);
            Controls.Add(btnLIMPIAR);
            Controls.Add(TxtRNC);
            Controls.Add(TxtTELEFONO);
            Controls.Add(label1);
            Controls.Add(btnREGISTRARLISTATEMP);
            Controls.Add(dgvLISTATEMPORAL);
            Controls.Add(TxtPRODUCTO);
            Controls.Add(lnlPRODUCTO);
            Controls.Add(btnBUSCAR);
            Controls.Add(lblTIPO);
            Controls.Add(lblTELEFONO);
            Controls.Add(lblNOMBRE);
            Controls.Add(lblRNC);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLISTATEMPORAL";
            Text = "FormLISTATEMPORAL";
            Load += FormLISTATEMPORAL_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLISTATEMPORAL).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private DataGridView dgvLISTATEMPORAL;
        private Button btnREGISTRARLISTATEMP;
        private Label label1;
        private MaskedTextBox TxtTELEFONO;
        private MaskedTextBox TxtRNC;
        private Button btnLIMPIAR;
        private Button btnELIMINAR;
        private TextBox TxtNOMBRE;
        private Button btnGUARDARENBD;
        private Button btnEDITAR;
        private ComboBox cmbTipoProveedor;
        private PictureBox pictureBox1;
    }
}
