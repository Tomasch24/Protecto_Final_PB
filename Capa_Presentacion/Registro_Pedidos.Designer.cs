namespace Capa_Presentacion
{
    partial class Registro_Pedidos
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblRegistro = new Label();
            btnExportar = new Button();
            dgvRegistro = new DataGridView();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).BeginInit();
            SuspendLayout();
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistro.ForeColor = Color.White;
            lblRegistro.Location = new Point(418, 38);
            lblRegistro.Margin = new Padding(2, 0, 2, 0);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(324, 34);
            lblRegistro.TabIndex = 0;
            lblRegistro.Text = "Registro de Pedidos";
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(41, 76, 37);
            btnExportar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnExportar.ForeColor = SystemColors.Window;
            btnExportar.Location = new Point(903, 460);
            btnExportar.Margin = new Padding(2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(160, 36);
            btnExportar.TabIndex = 1;
            btnExportar.Text = "Exportar a Excel";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // dgvRegistro
            // 
            dgvRegistro.AllowUserToDeleteRows = false;
            dgvRegistro.AllowUserToResizeColumns = false;
            dgvRegistro.AllowUserToResizeRows = false;
            dgvRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRegistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvRegistro.BackgroundColor = SystemColors.Window;

            dgvRegistro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(111, 129, 105);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRegistro.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistro.EnableHeadersVisualStyles = false;
            dgvRegistro.GridColor = Color.Black;
            dgvRegistro.Location = new Point(86, 100);
            dgvRegistro.Margin = new Padding(2);
            dgvRegistro.Name = "dgvRegistro";
            dgvRegistro.ReadOnly = true;
            dgvRegistro.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle3.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(111, 129, 105);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRegistro.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRegistro.RowHeadersWidth = 62;
            dgvRegistro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistro.Size = new Size(977, 340);
            dgvRegistro.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(41, 76, 37);
            btnVolver.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnVolver.ForeColor = SystemColors.Window;
            btnVolver.Location = new Point(86, 460);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(123, 36);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // Registro_Pedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 56, 46);
            ClientSize = new Size(1151, 549);
            Controls.Add(dgvRegistro);
            Controls.Add(btnVolver);
            Controls.Add(btnExportar);
            Controls.Add(lblRegistro);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Registro_Pedidos";
            Text = "Registro_Pedidos";
            Load += Registro_Pedidos_Load;
            Leave += Registro_Pedidos_Leave;
            MouseDown += Registro_Pedidos_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistro;
        private Button btnExportar;
        private DataGridView dgvRegistro;
        private Button btnVolver;
    }
}