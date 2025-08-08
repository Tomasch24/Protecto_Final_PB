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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPROVEEDORES));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            resources.ApplyResources(lblRNC, "lblRNC");
            lblRNC.Name = "lblRNC";
            // 
            // lblNOMBRE
            // 
            resources.ApplyResources(lblNOMBRE, "lblNOMBRE");
            lblNOMBRE.Name = "lblNOMBRE";
            // 
            // lblTELEFONO
            // 
            resources.ApplyResources(lblTELEFONO, "lblTELEFONO");
            lblTELEFONO.Name = "lblTELEFONO";
            // 
            // lblTIPO
            // 
            resources.ApplyResources(lblTIPO, "lblTIPO");
            lblTIPO.Name = "lblTIPO";
            // 
            // btnBUSCAR
            // 
            resources.ApplyResources(btnBUSCAR, "btnBUSCAR");
            btnBUSCAR.BackColor = Color.FromArgb(43, 56, 46);
            btnBUSCAR.ForeColor = Color.White;
            btnBUSCAR.Name = "btnBUSCAR";
            btnBUSCAR.UseVisualStyleBackColor = false;
            btnBUSCAR.Click += btnBUSCAR_Click;
            // 
            // lnlPRODUCTO
            // 
            resources.ApplyResources(lnlPRODUCTO, "lnlPRODUCTO");
            lnlPRODUCTO.Name = "lnlPRODUCTO";
            // 
            // TxtPRODUCTO
            // 
            resources.ApplyResources(TxtPRODUCTO, "TxtPRODUCTO");
            TxtPRODUCTO.BackColor = Color.White;
            TxtPRODUCTO.Name = "TxtPRODUCTO";
            TxtPRODUCTO.KeyPress += TxtPRODUCTO_KeyPress;
            // 
            // dgvPROVEEDORES
            // 
            resources.ApplyResources(dgvPROVEEDORES, "dgvPROVEEDORES");
            dgvPROVEEDORES.AllowUserToAddRows = false;
            dgvPROVEEDORES.AllowUserToDeleteRows = false;
            dgvPROVEEDORES.AllowUserToResizeColumns = false;
            dgvPROVEEDORES.AllowUserToResizeRows = false;
            dgvPROVEEDORES.BackgroundColor = Color.White;
            dgvPROVEEDORES.BorderStyle = BorderStyle.None;
            dgvPROVEEDORES.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvPROVEEDORES.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(111, 129, 105);
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPROVEEDORES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPROVEEDORES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(111, 129, 105);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPROVEEDORES.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPROVEEDORES.EnableHeadersVisualStyles = false;
            dgvPROVEEDORES.GridColor = Color.Black;
            dgvPROVEEDORES.Name = "dgvPROVEEDORES";
            dgvPROVEEDORES.ReadOnly = true;
            dgvPROVEEDORES.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle3.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPROVEEDORES.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPROVEEDORES.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPROVEEDORES.CellMouseClick += dgvLISTATEMPORAL_CellMouseClick;
            // 
            // btnREGISTRAR
            // 
            resources.ApplyResources(btnREGISTRAR, "btnREGISTRAR");
            btnREGISTRAR.BackColor = Color.FromArgb(43, 56, 46);
            btnREGISTRAR.ForeColor = Color.White;
            btnREGISTRAR.Name = "btnREGISTRAR";
            btnREGISTRAR.UseVisualStyleBackColor = false;
            btnREGISTRAR.Click += btnREGISTRAR_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.FromArgb(43, 56, 46);
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // TxtTELEFONO
            // 
            resources.ApplyResources(TxtTELEFONO, "TxtTELEFONO");
            TxtTELEFONO.BackColor = Color.White;
            TxtTELEFONO.Name = "TxtTELEFONO";
            // 
            // TxtRNC
            // 
            resources.ApplyResources(TxtRNC, "TxtRNC");
            TxtRNC.BackColor = Color.White;
            TxtRNC.Name = "TxtRNC";
            // 
            // btnLIMPIAR
            // 
            resources.ApplyResources(btnLIMPIAR, "btnLIMPIAR");
            btnLIMPIAR.BackColor = Color.FromArgb(43, 56, 46);
            btnLIMPIAR.ForeColor = Color.White;
            btnLIMPIAR.Name = "btnLIMPIAR";
            btnLIMPIAR.UseVisualStyleBackColor = false;
            btnLIMPIAR.Click += btnLIMPIAR_Click;
            // 
            // btnELIMINAR
            // 
            resources.ApplyResources(btnELIMINAR, "btnELIMINAR");
            btnELIMINAR.BackColor = Color.FromArgb(43, 56, 46);
            btnELIMINAR.ForeColor = Color.White;
            btnELIMINAR.Name = "btnELIMINAR";
            btnELIMINAR.UseVisualStyleBackColor = false;
            btnELIMINAR.Click += btnELIMINAR_Click;
            // 
            // TxtNOMBRE
            // 
            resources.ApplyResources(TxtNOMBRE, "TxtNOMBRE");
            TxtNOMBRE.BackColor = Color.White;
            TxtNOMBRE.Name = "TxtNOMBRE";
            TxtNOMBRE.TextChanged += TxtNOMBRE_TextChanged;
            TxtNOMBRE.KeyPress += TxtNOMBRE_KeyPress;
            // 
            // btnEDITAR
            // 
            resources.ApplyResources(btnEDITAR, "btnEDITAR");
            btnEDITAR.BackColor = Color.FromArgb(43, 56, 46);
            btnEDITAR.ForeColor = Color.White;
            btnEDITAR.Name = "btnEDITAR";
            btnEDITAR.UseVisualStyleBackColor = false;
            btnEDITAR.Click += btnEDITAR_Click;
            // 
            // cmbTipoProveedor
            // 
            resources.ApplyResources(cmbTipoProveedor, "cmbTipoProveedor");
            cmbTipoProveedor.BackColor = Color.White;
            cmbTipoProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoProveedor.FormattingEnabled = true;
            cmbTipoProveedor.Name = "cmbTipoProveedor";
            // 
            // lblPRECIO
            // 
            resources.ApplyResources(lblPRECIO, "lblPRECIO");
            lblPRECIO.Name = "lblPRECIO";
            // 
            // TxtPRECIO
            // 
            resources.ApplyResources(TxtPRECIO, "TxtPRECIO");
            TxtPRECIO.BackColor = Color.White;
            TxtPRECIO.Name = "TxtPRECIO";
            TxtPRECIO.KeyPress += TxtPRECIO_KeyPress;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
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
            groupBox1.ForeColor = Color.White;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // pbRegistrar
            // 
            resources.ApplyResources(pbRegistrar, "pbRegistrar");
            pbRegistrar.BackColor = Color.White;
            pbRegistrar.Name = "pbRegistrar";
            pbRegistrar.TabStop = false;
            pbRegistrar.Click += pictureBox2_Click;
            // 
            // pbBuscar
            // 
            resources.ApplyResources(pbBuscar, "pbBuscar");
            pbBuscar.BackColor = Color.White;
            pbBuscar.Name = "pbBuscar";
            pbBuscar.TabStop = false;
            pbBuscar.Click += pbBuscar_Click;
            // 
            // pbEditar
            // 
            resources.ApplyResources(pbEditar, "pbEditar");
            pbEditar.BackColor = Color.White;
            pbEditar.Name = "pbEditar";
            pbEditar.TabStop = false;
            pbEditar.Click += pbEditar_Click;
            // 
            // pbLimpiar
            // 
            resources.ApplyResources(pbLimpiar, "pbLimpiar");
            pbLimpiar.BackColor = Color.White;
            pbLimpiar.Name = "pbLimpiar";
            pbLimpiar.TabStop = false;
            pbLimpiar.Click += pbLimpiar_Click;
            // 
            // pbBorrar
            // 
            resources.ApplyResources(pbBorrar, "pbBorrar");
            pbBorrar.BackColor = Color.White;
            pbBorrar.Name = "pbBorrar";
            pbBorrar.TabStop = false;
            pbBorrar.Click += pbBorrar_Click;
            // 
            // FormPROVEEDORES
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 56, 46);
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
