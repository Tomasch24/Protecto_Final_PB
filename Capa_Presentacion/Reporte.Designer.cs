namespace Capa_Presentacion
{
    partial class Reporte
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
            dgvReporte = new DataGridView();
            btnExportarExcel = new Button();
            lblTotalVentasDia = new Label();
            lblTotalGastosDia = new Label();
            lblCuadreCaja = new Label();
            btnExportarPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(51, 37);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(910, 266);
            dgvReporte.TabIndex = 0;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.BackColor = Color.YellowGreen;
            btnExportarExcel.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportarExcel.Location = new Point(989, 37);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(299, 133);
            btnExportarExcel.TabIndex = 1;
            btnExportarExcel.Text = "Exportar Excel";
            btnExportarExcel.UseVisualStyleBackColor = false;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // lblTotalVentasDia
            // 
            lblTotalVentasDia.AutoSize = true;
            lblTotalVentasDia.Location = new Point(51, 343);
            lblTotalVentasDia.Name = "lblTotalVentasDia";
            lblTotalVentasDia.Size = new Size(50, 20);
            lblTotalVentasDia.TabIndex = 2;
            lblTotalVentasDia.Text = "label1";
            // 
            // lblTotalGastosDia
            // 
            lblTotalGastosDia.AutoSize = true;
            lblTotalGastosDia.Location = new Point(51, 455);
            lblTotalGastosDia.Name = "lblTotalGastosDia";
            lblTotalGastosDia.Size = new Size(50, 20);
            lblTotalGastosDia.TabIndex = 3;
            lblTotalGastosDia.Text = "label2";
            // 
            // lblCuadreCaja
            // 
            lblCuadreCaja.AutoSize = true;
            lblCuadreCaja.Location = new Point(51, 395);
            lblCuadreCaja.Name = "lblCuadreCaja";
            lblCuadreCaja.Size = new Size(50, 20);
            lblCuadreCaja.TabIndex = 4;
            lblCuadreCaja.Text = "label3";
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.BackColor = Color.Brown;
            btnExportarPDF.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportarPDF.Location = new Point(989, 176);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(299, 137);
            btnExportarPDF.TabIndex = 5;
            btnExportarPDF.Text = "Exportar PDF";
            btnExportarPDF.UseVisualStyleBackColor = false;
            btnExportarPDF.Click += btnExportarPDF_Click_1;
            // 
            // Reporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 499);
            Controls.Add(btnExportarPDF);
            Controls.Add(lblCuadreCaja);
            Controls.Add(lblTotalGastosDia);
            Controls.Add(lblTotalVentasDia);
            Controls.Add(btnExportarExcel);
            Controls.Add(dgvReporte);
            Name = "Reporte";
            Text = "Reporte";
            Load += Reporte_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReporte;
        private Button btnExportarExcel;
        private Label lblTotalVentasDia;
        private Label lblTotalGastosDia;
        private Label lblCuadreCaja;
        private Button btnExportarPDF;
    }
}