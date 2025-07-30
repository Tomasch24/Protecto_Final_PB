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
            tabPedidos.Location = new Point(71, 93);
            tabPedidos.Name = "tabPedidos";
            tabPedidos.SelectedIndex = 0;
            tabPedidos.Size = new Size(1148, 503);
            tabPedidos.TabIndex = 0;
            tabPedidos.DrawItem += tabPedidos_DrawItem;
            // 
            // tabExistentes
            // 
            tabExistentes.Controls.Add(dgvExistentes);
            tabExistentes.Location = new Point(4, 34);
            tabExistentes.Name = "tabExistentes";
            tabExistentes.Padding = new Padding(3);
            tabExistentes.Size = new Size(1140, 465);
            tabExistentes.TabIndex = 0;
            tabExistentes.Text = "Productos Existentes";
            tabExistentes.UseVisualStyleBackColor = true;
            // 
            // dgvExistentes
            // 
            dgvExistentes.AllowUserToDeleteRows = false;
            dgvExistentes.AllowUserToResizeColumns = false;
            dgvExistentes.AllowUserToResizeRows = false;
            dgvExistentes.BackgroundColor = SystemColors.Window;
            dgvExistentes.BorderStyle = BorderStyle.None;
            dgvExistentes.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvExistentes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExistentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExistentes.Columns.AddRange(new DataGridViewColumn[] { ProductosExistentes, Stock });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvExistentes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvExistentes.EnableHeadersVisualStyles = false;
            dgvExistentes.GridColor = SystemColors.Window;
            dgvExistentes.Location = new Point(0, 0);
            dgvExistentes.Name = "dgvExistentes";
            dgvExistentes.ReadOnly = true;
            dgvExistentes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle3.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvExistentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvExistentes.RowHeadersWidth = 62;
            dgvExistentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExistentes.Size = new Size(1140, 465);
            dgvExistentes.TabIndex = 0;
            // 
            // ProductosExistentes
            // 
            ProductosExistentes.Frozen = true;
            ProductosExistentes.HeaderText = "Producto";
            ProductosExistentes.MinimumWidth = 8;
            ProductosExistentes.Name = "ProductosExistentes";
            ProductosExistentes.ReadOnly = true;
            ProductosExistentes.Width = 800;
            // 
            // Stock
            // 
            Stock.Frozen = true;
            Stock.HeaderText = "Cantidad en Stock";
            Stock.MinimumWidth = 8;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 280;
            // 
            // tabAgotados
            // 
            tabAgotados.Controls.Add(dgvAgotados);
            tabAgotados.Location = new Point(4, 34);
            tabAgotados.Name = "tabAgotados";
            tabAgotados.Padding = new Padding(3);
            tabAgotados.Size = new Size(1140, 465);
            tabAgotados.TabIndex = 1;
            tabAgotados.Text = "Productos Agotados";
            tabAgotados.UseVisualStyleBackColor = true;
            // 
            // dgvAgotados
            // 
            dgvAgotados.AllowUserToDeleteRows = false;
            dgvAgotados.AllowUserToResizeColumns = false;
            dgvAgotados.AllowUserToResizeRows = false;
            dgvAgotados.BackgroundColor = SystemColors.Window;
            dgvAgotados.BorderStyle = BorderStyle.None;
            dgvAgotados.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvAgotados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle4.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(41, 76, 37);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAgotados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAgotados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgotados.Columns.AddRange(new DataGridViewColumn[] { ProductosAgotados, Stock0 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Green;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvAgotados.DefaultCellStyle = dataGridViewCellStyle5;
            dgvAgotados.EnableHeadersVisualStyles = false;
            dgvAgotados.GridColor = SystemColors.Window;
            dgvAgotados.Location = new Point(0, 0);
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
            dgvAgotados.Size = new Size(1140, 465);
            dgvAgotados.TabIndex = 0;
            // 
            // ProductosAgotados
            // 
            ProductosAgotados.Frozen = true;
            ProductosAgotados.HeaderText = "Producto";
            ProductosAgotados.MinimumWidth = 8;
            ProductosAgotados.Name = "ProductosAgotados";
            ProductosAgotados.ReadOnly = true;
            ProductosAgotados.Width = 800;
            // 
            // Stock0
            // 
            Stock0.Frozen = true;
            Stock0.HeaderText = "Cantidad en Stock";
            Stock0.MinimumWidth = 8;
            Stock0.Name = "Stock0";
            Stock0.ReadOnly = true;
            Stock0.Width = 280;
            // 
            // lblPedidos
            // 
            lblPedidos.AutoSize = true;
            lblPedidos.Font = new Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPedidos.ForeColor = Color.FromArgb(88, 173, 83);
            lblPedidos.Location = new Point(452, 29);
            lblPedidos.Name = "lblPedidos";
            lblPedidos.Size = new Size(389, 40);
            lblPedidos.TabIndex = 1;
            lblPedidos.Text = "Pedidos Green Point";
            lblPedidos.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnHacerPedido
            // 
            btnHacerPedido.BackColor = Color.FromArgb(41, 76, 37);
            btnHacerPedido.FlatStyle = FlatStyle.Flat;
            btnHacerPedido.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHacerPedido.ForeColor = SystemColors.Window;
            btnHacerPedido.Location = new Point(273, 621);
            btnHacerPedido.Name = "btnHacerPedido";
            btnHacerPedido.Size = new Size(270, 44);
            btnHacerPedido.TabIndex = 1;
            btnHacerPedido.Text = "Realizar Pedido";
            btnHacerPedido.UseVisualStyleBackColor = false;
            btnHacerPedido.Click += btnHacerPedido_Click;
            // 
            // btnRegistroPedidos
            // 
            btnRegistroPedidos.BackColor = Color.FromArgb(41, 76, 37);
            btnRegistroPedidos.FlatStyle = FlatStyle.Flat;
            btnRegistroPedidos.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistroPedidos.ForeColor = SystemColors.Window;
            btnRegistroPedidos.Location = new Point(733, 621);
            btnRegistroPedidos.Name = "btnRegistroPedidos";
            btnRegistroPedidos.Size = new Size(270, 44);
            btnRegistroPedidos.TabIndex = 2;
            btnRegistroPedidos.Text = "Ver Registro de Pedidos";
            btnRegistroPedidos.UseVisualStyleBackColor = false;
            btnRegistroPedidos.Click += btnRegistroPedidos_Click;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 246);
            ClientSize = new Size(1322, 686);
            Controls.Add(btnRegistroPedidos);
            Controls.Add(btnHacerPedido);
            Controls.Add(lblPedidos);
            Controls.Add(tabPedidos);
            Name = "Pedidos";
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