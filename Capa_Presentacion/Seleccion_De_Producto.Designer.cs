namespace Capa_Interfas
{
    partial class Seleccion_De_Producto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seleccion_De_Producto));
            dgvResumen = new DataGridView();
            cmbTipo = new ComboBox();
            cmbTemporada = new ComboBox();
            cmbProduc = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            btnAgregar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            Temporada = new Label();
            label7 = new Label();
            txbPrecio = new MaskedTextBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            iconoCerrar = new PictureBox();
            iconoMinimizarPe = new PictureBox();
            btnVolMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizarPe).BeginInit();
            SuspendLayout();
            // 
            // dgvResumen
            // 
            dgvResumen.AllowUserToAddRows = false;
            dgvResumen.BackgroundColor = SystemColors.ButtonHighlight;
            dgvResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen.Location = new Point(342, 140);
            dgvResumen.Name = "dgvResumen";
            dgvResumen.ReadOnly = true;
            dgvResumen.RowHeadersWidth = 62;
            dgvResumen.Size = new Size(1048, 317);
            dgvResumen.TabIndex = 0;
            dgvResumen.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbTipo
            // 
            cmbTipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FlatStyle = FlatStyle.Flat;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(0, 185);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(297, 33);
            cmbTipo.TabIndex = 1;
            // 
            // cmbTemporada
            // 
            cmbTemporada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbTemporada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTemporada.FormattingEnabled = true;
            cmbTemporada.Location = new Point(3, 285);
            cmbTemporada.Name = "cmbTemporada";
            cmbTemporada.Size = new Size(297, 33);
            cmbTemporada.TabIndex = 2;
            // 
            // cmbProduc
            // 
            cmbProduc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbProduc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduc.FlatStyle = FlatStyle.Flat;
            cmbProduc.Font = new Font("Sitka Text Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbProduc.FormattingEnabled = true;
            cmbProduc.Location = new Point(0, 86);
            cmbProduc.Name = "cmbProduc";
            cmbProduc.Size = new Size(297, 37);
            cmbProduc.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Location = new Point(3, 387);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(297, 31);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.Location = new Point(23, 525);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(256, 33);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 430);
            label1.Name = "label1";
            label1.Size = new Size(217, 29);
            label1.TabIndex = 7;
            label1.Text = "Digite El Precio";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 336);
            label2.Name = "label2";
            label2.Size = new Size(288, 26);
            label2.TabIndex = 8;
            label2.Text = "Selecione La Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(498, 471);
            label4.Name = "label4";
            label4.Size = new Size(825, 48);
            label4.TabIndex = 10;
            label4.Text = "Los mejores Productos del Condado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(105, 140);
            label5.Name = "label5";
            label5.Size = new Size(70, 29);
            label5.TabIndex = 11;
            label5.Text = "Tipo";
            // 
            // Temporada
            // 
            Temporada.AutoSize = true;
            Temporada.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Temporada.Location = new Point(72, 233);
            Temporada.Name = "Temporada";
            Temporada.Size = new Size(164, 29);
            Temporada.TabIndex = 12;
            Temporada.Text = "Temporada";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(72, 44);
            label7.Name = "label7";
            label7.Size = new Size(134, 29);
            label7.TabIndex = 13;
            label7.Text = "Producto";
            // 
            // txbPrecio
            // 
            txbPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbPrecio.Location = new Point(3, 471);
            txbPrecio.Mask = "0000000000";
            txbPrecio.Name = "txbPrecio";
            txbPrecio.Size = new Size(297, 31);
            txbPrecio.TabIndex = 14;
            txbPrecio.ValidatingType = typeof(int);
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEditar.Location = new Point(24, 581);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(256, 34);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminar.Location = new Point(23, 635);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(257, 34);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(120, 160, 100);
            panel1.Controls.Add(cmbProduc);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(cmbTipo);
            panel1.Controls.Add(txbPrecio);
            panel1.Controls.Add(Temporada);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(cmbTemporada);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericUpDown1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 693);
            panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(411, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(912, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // iconoCerrar
            // 
            iconoCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoCerrar.Image = (Image)resources.GetObject("iconoCerrar.Image");
            iconoCerrar.Location = new Point(1377, 12);
            iconoCerrar.Name = "iconoCerrar";
            iconoCerrar.Size = new Size(30, 30);
            iconoCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            iconoCerrar.TabIndex = 19;
            iconoCerrar.TabStop = false;
            iconoCerrar.Click += iconoCerrar_Click;
            // 
            // iconoMinimizarPe
            // 
            iconoMinimizarPe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoMinimizarPe.Image = (Image)resources.GetObject("iconoMinimizarPe.Image");
            iconoMinimizarPe.Location = new Point(1341, 12);
            iconoMinimizarPe.Name = "iconoMinimizarPe";
            iconoMinimizarPe.Size = new Size(30, 30);
            iconoMinimizarPe.SizeMode = PictureBoxSizeMode.Zoom;
            iconoMinimizarPe.TabIndex = 22;
            iconoMinimizarPe.TabStop = false;
            iconoMinimizarPe.Click += iconoMinimizarPe_Click;
            // 
            // btnVolMenu
            // 
            btnVolMenu.FlatAppearance.BorderSize = 0;
            btnVolMenu.FlatStyle = FlatStyle.Flat;
            btnVolMenu.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolMenu.ForeColor = SystemColors.ActiveCaptionText;
            btnVolMenu.Image = (Image)resources.GetObject("btnVolMenu.Image");
            btnVolMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolMenu.Location = new Point(1139, 616);
            btnVolMenu.Name = "btnVolMenu";
            btnVolMenu.Size = new Size(281, 68);
            btnVolMenu.TabIndex = 23;
            btnVolMenu.Text = "      Volver al Menu";
            btnVolMenu.UseVisualStyleBackColor = true;
            btnVolMenu.Click += btnVolMenu_Click;
            // 
            // Seleccion_De_Producto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1419, 693);
            Controls.Add(btnVolMenu);
            Controls.Add(iconoMinimizarPe);
            Controls.Add(iconoCerrar);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(dgvResumen);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Seleccion_De_Producto";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvResumen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizarPe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResumen;
        private ComboBox cmbTipo;
        private ComboBox cmbTemporada;
        private ComboBox cmbProduc;
        private NumericUpDown numericUpDown1;
        private Button btnAgregar;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label Temporada;
        private Label label7;
        private MaskedTextBox txbPrecio;
        private Button btnEditar;
        private Button btnEliminar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox iconoCerrar;
        private PictureBox iconoMinimizarPe;
        private Button btnVolMenu;
    }
}