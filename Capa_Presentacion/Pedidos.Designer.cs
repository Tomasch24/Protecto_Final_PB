namespace Capa_Presentacion
{
    partial class Pedidos
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabPedidos = new TabControl();
            tabExistentes = new TabPage();
            dgvExistentes = new DataGridView();
            ProductosExistentes = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            tabAgotados = new TabPage();
            dgvAgotados = new DataGridView();
            ProductosAgotados = new DataGridViewTextBoxColumn();
            Stock0 = new DataGridViewTextBoxColumn();
            lblPedidos = new Label();
            btnHacerPedido = new Button();
            btnRegistroPedidos = new Button();
            tabPedidos.SuspendLayout();
            tabExistentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExistentes).BeginInit();
            tabAgotados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgotados).BeginInit();
            SuspendLayout();
            // 
            // tabPedidos
            // 
            tabPedidos.Controls.Add(tabExistentes);
            tabPedidos.Controls.Add(tabAgotados);
            tabPedidos.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPedidos.Location = new Point(87, 96);
            tabPedidos.Margin = new Padding(2);
            tabPedidos.Name = "tabPedidos";
            tabPedidos.SelectedIndex = 0;
            tabPedidos.Size = new Size(1189, 429);
            tabPedidos.TabIndex = 0;
            tabPedidos.DrawItem += tabPedidos_DrawItem;
            // 
            // tabExistentes
            // 
            tabExistentes.Controls.Add(dgvExistentes);
            tabExistentes.Location = new Point(4, 29);
            tabExistentes.Margin = new Padding(2);
            tabExistentes.Name = "tabExistentes";
            tabExistentes.Padding = new Padding(2);
            tabExistentes.Size = new Size(1181, 396);
            tabExistentes.TabIndex = 0;
            tabExistentes.Text = "Productos Existentes";
            tabExistentes.UseVisualStyleBackColor = true;
            // 
            // dgvExistentes
            // 
            dgvExistentes.AllowUserToAddRows = false;
            dgvExistentes.AllowUserToDeleteRows = false;
            dgvExistentes.AllowUserToResizeColumns = false;
            dgvExistentes.AllowUserToResizeRows = false;

            dgvExistentes.BackgroundColor = SystemColors.Window;

            dgvExistentes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;


            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 56, 46);
            dataGridViewCellStyle1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(111, 129, 105);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExistentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExistentes.Columns.AddRange(new DataGridViewColumn[] { ProductosExistentes, Stock });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(111, 129, 105);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvExistentes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvExistentes.EnableHeadersVisualStyles = false;
            dgvExistentes.GridColor = Color.Black;
            dgvExistentes.Location = new Point(0, 0);
            dgvExistentes.Margin = new Padding(2);
            dgvExistentes.Name = "dgvExistentes";
            dgvExistentes.ReadOnly = true;
            dgvExistentes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(111, 129, 105);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvExistentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvExistentes.RowHeadersWidth = 62;
            dgvExistentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExistentes.Size = new Size(1185, 400);
            dgvExistentes.TabIndex = 0;
            // 
            // ProductosExistentes
            // 
            ProductosExistentes.DataPropertyName = "Nombre";
            ProductosExistentes.Frozen = true;
            ProductosExistentes.HeaderText = "Producto";
            ProductosExistentes.MinimumWidth = 8;
            ProductosExistentes.Name = "ProductosExistentes";
            ProductosExistentes.ReadOnly = true;
            ProductosExistentes.Width = 600;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.Frozen = true;
            Stock.HeaderText = "Cantidad en Stock";
            Stock.MinimumWidth = 8;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 800;
            // 
            // tabAgotados
            // 
            tabAgotados.Controls.Add(dgvAgotados);
            tabAgotados.Location = new Point(4, 29);
            tabAgotados.Margin = new Padding(2);
            tabAgotados.Name = "tabAgotados";
            tabAgotados.Padding = new Padding(2);
            tabAgotados.Size = new Size(1181, 396);
            tabAgotados.TabIndex = 1;
            tabAgotados.Text = "Productos Agotados";
            tabAgotados.UseVisualStyleBackColor = true;
            // 
            // dgvAgotados
            // 
            dgvAgotados.AllowUserToAddRows = false;
            dgvAgotados.AllowUserToDeleteRows = false;
            dgvAgotados.AllowUserToResizeColumns = false;
            dgvAgotados.AllowUserToResizeRows = false;
            dgvAgotados.BackgroundColor = SystemColors.Window;
            dgvAgotados.BorderStyle = BorderStyle.None;
            dgvAgotados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(43, 56, 46);
            dataGridViewCellStyle4.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(111, 129, 105);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAgotados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAgotados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgotados.Columns.AddRange(new DataGridViewColumn[] { ProductosAgotados, Stock0 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(111, 129, 105);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvAgotados.DefaultCellStyle = dataGridViewCellStyle5;
            dgvAgotados.Dock = DockStyle.Fill;
            dgvAgotados.EnableHeadersVisualStyles = false;
            dgvAgotados.GridColor = Color.Black;
            dgvAgotados.Location = new Point(2, 2);
            dgvAgotados.Margin = new Padding(2);
            dgvAgotados.Name = "dgvAgotados";
            dgvAgotados.ReadOnly = true;
            dgvAgotados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle6.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = Color.Green;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvAgotados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvAgotados.RowHeadersWidth = 62;
            dgvAgotados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgotados.Size = new Size(1177, 392);
            dgvAgotados.TabIndex = 0;
            // 
            // ProductosAgotados
            // 
            ProductosAgotados.DataPropertyName = "Nombre";
            ProductosAgotados.Frozen = true;
            ProductosAgotados.HeaderText = "Producto";
            ProductosAgotados.MinimumWidth = 8;
            ProductosAgotados.Name = "ProductosAgotados";
            ProductosAgotados.ReadOnly = true;
            ProductosAgotados.Width = 600;
            // 
            // Stock0
            // 
            Stock0.DataPropertyName = "Stock";
            Stock0.Frozen = true;
            Stock0.HeaderText = "Cantidad en Stock";
            Stock0.MinimumWidth = 8;
            Stock0.Name = "Stock0";
            Stock0.ReadOnly = true;
            Stock0.Width = 800;
            // 
            // lblPedidos
            // 
            lblPedidos.AutoSize = true;
            lblPedidos.BackColor = Color.FromArgb(43, 56, 46);
            lblPedidos.Font = new Font("Lucida Sans", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPedidos.ForeColor = Color.White;
            lblPedidos.Location = new Point(564, 29);
            lblPedidos.Margin = new Padding(2, 0, 2, 0);
            lblPedidos.Name = "lblPedidos";
            lblPedidos.Size = new Size(184, 42);
            lblPedidos.TabIndex = 1;
            lblPedidos.Text = "PEDIDOS";
            lblPedidos.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnHacerPedido
            // 
            btnHacerPedido.BackColor = Color.FromArgb(43, 56, 46);
            btnHacerPedido.FlatStyle = FlatStyle.Flat;
            btnHacerPedido.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHacerPedido.ForeColor = SystemColors.Window;
            btnHacerPedido.Location = new Point(326, 581);
            btnHacerPedido.Margin = new Padding(2);
            btnHacerPedido.Name = "btnHacerPedido";
            btnHacerPedido.Size = new Size(216, 35);
            btnHacerPedido.TabIndex = 1;
            btnHacerPedido.Text = "Realizar Pedido";
            btnHacerPedido.UseVisualStyleBackColor = false;
            btnHacerPedido.Click += btnHacerPedido_Click;
            // 
            // btnRegistroPedidos
            // 
            btnRegistroPedidos.BackColor = Color.FromArgb(43, 56, 46);
            btnRegistroPedidos.FlatStyle = FlatStyle.Flat;
            btnRegistroPedidos.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistroPedidos.ForeColor = SystemColors.Window;
            btnRegistroPedidos.Location = new Point(806, 581);
            btnRegistroPedidos.Margin = new Padding(2);
            btnRegistroPedidos.Name = "btnRegistroPedidos";
            btnRegistroPedidos.Size = new Size(216, 35);
            btnRegistroPedidos.TabIndex = 2;
            btnRegistroPedidos.Text = "Ver Registro de Pedidos";
            btnRegistroPedidos.UseVisualStyleBackColor = false;
            btnRegistroPedidos.Click += btnRegistroPedidos_Click;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 56, 46);
            ClientSize = new Size(1369, 657);
            Controls.Add(btnRegistroPedidos);
            Controls.Add(btnHacerPedido);
            Controls.Add(lblPedidos);
            Controls.Add(tabPedidos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Pedidos";
            Load += Pedidos_Load;
            tabPedidos.ResumeLayout(false);
            tabExistentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExistentes).EndInit();
            tabAgotados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAgotados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabPedidos;
        private TabPage tabExistentes;
        private TabPage tabAgotados;
        private DataGridView dgvExistentes;
        private DataGridView dgvAgotados;
        private Label lblPedidos;
        private Button btnHacerPedido;
        private Button btnRegistroPedidos;
        private DataGridViewTextBoxColumn ProductosExistentes;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn ProductosAgotados;
        private DataGridViewTextBoxColumn Stock0;
    }
}