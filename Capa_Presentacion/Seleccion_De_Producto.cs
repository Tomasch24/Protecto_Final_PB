using System;
using System.Windows.Forms;
using Capa_Negocios;
using System.Linq;
using ConexionADatos;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Capa_Interfas
{
    public partial class Seleccion_De_Producto : Form
    {
        // Usaremos esta variable para saber si estamos en modo edición
        private bool esModoEdicion = false;
        private int? idProductoAEditar = null; // Guardará el ID del producto que se está editando

        public Seleccion_De_Producto()
        {
            InitializeComponent();
            MostrarPedidos();
            this.Load += Form1_Load;
            dgvResumen.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // <--- Agrega esta línea
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialización de ComboBoxes
            cmbTipo.Items.Add("Verdura");
            cmbTipo.Items.Add("Grano");
            cmbTipo.Items.Add("Fruta");
            cmbTipo.SelectedIndex = 0;

            cmbTemporada.Items.Add("Verano");
            cmbTemporada.Items.Add("Otono");
            cmbTemporada.Items.Add("Invierno");
            cmbTemporada.Items.Add("Primavera");
            cmbTemporada.SelectedIndex = 0;

            cmbProduc.Items.Add("Zanahoria");
            cmbProduc.Items.Add("Espinaca");
            cmbProduc.Items.Add("Trigo");
            cmbProduc.Items.Add("Maiz");
            cmbProduc.Items.Add("Manzna");
            cmbProduc.Items.Add("Mango");
            cmbProduc.SelectedIndex = 0;


        }

        private void MostrarPedidos()
        {
            Productos_Agri conexion = new Productos_Agri();
            using (SqlConnection conn = new SqlConnection(conexion.Conexion))
            {
                conn.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(
                    "SELECT Id, Tipo, Temporada, Nombre, Cantidad, Precio, CostoDeEnvio FROM Producto", conn);
                DataTable dataTable = new DataTable();
                adpt.Fill(dataTable);
                dgvResumen.DataSource = dataTable;
                conn.Close();
            }
        }

        // --- Botón AGREGAR (ahora también GUARDAR EDICIÓN) ---
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            // Validar si los campos están llenos o tienen formato correcto
            if (string.IsNullOrEmpty(cmbTipo.Text) || string.IsNullOrEmpty(cmbTemporada.Text) ||
                string.IsNullOrEmpty(cmbProduc.Text) || string.IsNullOrEmpty(numericUpDown1.Text) ||
                string.IsNullOrEmpty(txbPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validar precio
            decimal precio;
            if (!decimal.TryParse(txbPrecio.Text, out precio))
            {
                MessageBox.Show("El precio digitado no es válido, digite un precio real.");
                return;
            }
            producto.Precio = precio;

            // Asignar valores de los controles al objeto Producto
            producto.Tipo = cmbTipo.SelectedItem?.ToString() ?? cmbTipo.Text; // Usar SelectedItem si existe, sino Text
            //producto.Temporada = cmbTemporada.SelectedItem?.ToString() ?? cmbTemporada.Text;
            producto.Nombre = cmbProduc.SelectedItem?.ToString() ?? cmbProduc.Text;
            producto.Cantidad = (int)numericUpDown1.Value; // NumericUpDown ya es int/decimal

            // Lógica para GUARDAR o ACTUALIZAR
            if (esModoEdicion && idProductoAEditar.HasValue)
            {
                // Modo edición: actualiza el producto existente en la base de datos
                producto.Id = idProductoAEditar.Value; // Asigna el Id del producto que se está editando

                bool editado = EditarProducto.Editar(producto); // Llama a tu método de la capa de negocios

                if (editado)
                {
                    MessageBox.Show("Producto editado correctamente.");
                    esModoEdicion = false;       // Desactiva el modo edición
                    idProductoAEditar = null;    // Resetea el ID
                    LimpiarCampos();             // Limpia los campos
                    MostrarPedidos();            // Refresca el DataGridView
                }
                else
                {
                    MessageBox.Show("No se pudo editar el producto en la base de datos. Revise la consola para errores."); // Mejorar el manejo de errores
                }
            }
            else
            {
                // Modo agregar nuevo producto
                int resultado = Logicaproducto.GuardarPedido(producto);
                if (resultado > 0)
                {
                    MessageBox.Show("Producto agregado correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el producto.");
                }
                MostrarPedidos();




            }
            // Preparar la operación (si es necesario)
            Operacion ope = new Operacion();
            ope.PrepararOperacion();







        }


        // --- Botón EDITAR (para cargar los datos al formulario) ---
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvResumen.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvResumen.SelectedRows[0];

                // Cargar los datos de la fila a los controles del formulario
                // Asegúrate de que las columnas tengan los nombres correctos del DataGridView
                try
                {
                    idProductoAEditar = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                    cmbTipo.Text = filaSeleccionada.Cells["Tipo"].Value.ToString();
                    cmbTemporada.Text = filaSeleccionada.Cells["Temporada"].Value.ToString();
                    cmbProduc.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                    numericUpDown1.Value = Convert.ToDecimal(filaSeleccionada.Cells["Cantidad"].Value);
                    txbPrecio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();

                    esModoEdicion = true; // Activa el modo edición
                    MessageBox.Show("Datos cargados para edición. Modifique y presione 'Agregar' para guardar.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos para edición: " + ex.Message);
                    esModoEdicion = false;
                    idProductoAEditar = null;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
            }

            if (dgvResumen.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
            }
        }

        // --- Botón ELIMINAR ---
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvResumen.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Obtener el ID de la fila seleccionada
                    int idAEliminar = Convert.ToInt32(dgvResumen.CurrentRow.Cells["Id"].Value);

                    if (EliminarProducto.Eliminar(idAEliminar))
                    {
                        MessageBox.Show("Producto eliminado correctamente.");
                        MostrarPedidos(); // Refresca el DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto. Puede que no exista o haya un problema de conexión.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }

        // Método auxiliar para limpiar los campos
        private void LimpiarCampos()
        {
            cmbTipo.SelectedIndex = 0;
            cmbTemporada.SelectedIndex = 0;
            cmbProduc.SelectedIndex = 0;
            numericUpDown1.Value = numericUpDown1.Minimum; // O 0
            txbPrecio.Clear();
        }

        // Otros eventos si los necesitas
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { /* No hace nada aquí */ }
        private void Form1_Load_1(object sender, EventArgs e) { /* No hace nada aquí, ya tienes Form1_Load */ }
        private void label1_Click(object sender, EventArgs e) { /* No hace nada aquí */ }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconoCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Cierra el formulario actual
        }


        private void iconoMinimizarPe_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolMenu_Click(object sender, EventArgs e)
        {
            Pantalla_De_Inicio inicio = new Pantalla_De_Inicio();
            inicio.Show();

            this.Dispose();
        }
    }
}

//Papa Dios en ti confio