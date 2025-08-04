using System.Data;
using System.Diagnostics.Eventing.Reader;
using Capa_Datos;
using Capa_Interfas;
using Capa_Negocios;
using Capa_Presentacion;
using Microsoft.Data.SqlClient;
using ConexionADatos;

namespace Capa.Presentacion
{
    public partial class FormPROVEEDORES : Form
    {
        //Lógica para mostrar los datos en la interfaz
        private void CargarProveedoresDesdeBD()
        {
            try
            {
                CNProveedor negocio = new CNProveedor();
                dgvPROVEEDORES.DataSource = negocio.ObtenerTodosLosProveedores();
                dgvPROVEEDORES.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            TxtRNC.Text = "";
            TxtNOMBRE.Text = "";
            TxtTELEFONO.Text = "";
            cmbTipoProveedor.Text = "";
            TxtPRODUCTO.Text = "";
            TxtPRECIO.Text = "";

        }


        private CNProveedor cnProveedor = new CNProveedor();

        public FormPROVEEDORES()
        {
            InitializeComponent();

            if (cmbTipoProveedor.Items.Count == 0)
            {
                cmbTipoProveedor.Items.Add("LOCAL");
                cmbTipoProveedor.Items.Add("INTERNACIONAL");
            }

            cmbTipoProveedor.SelectedIndex = 0;
        }

        private void EnlazarDataGridView()
        {
            CNProveedor negocio = new CNProveedor();
            dgvPROVEEDORES.DataSource = null;
            dgvPROVEEDORES.DataSource = negocio.ObtenerTodosLosProveedores(); // Devuelve un DataTable
            dgvPROVEEDORES.ClearSelection();
        }


        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            string rncBuscado = TxtRNC.Text.Trim();

            if (string.IsNullOrWhiteSpace(rncBuscado))
            {
                MessageBox.Show("Por favor ingresa un RNC para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CNProveedor negocio = new CNProveedor();
            DataTable resultado = negocio.BuscarProveedores(rncBuscado);

            if (resultado.Rows.Count > 0)
            {
                DataRow proveedor = resultado.Rows[0];

                TxtNOMBRE.Text = proveedor["NOMBRE"].ToString();
                TxtTELEFONO.Text = proveedor["TELEFONO"].ToString();
                cmbTipoProveedor.Text = proveedor["TIPO"].ToString();
                TxtPRODUCTO.Text = proveedor["PRODUCTO"].ToString();
                TxtPRECIO.Text = proveedor["PRECIO"].ToString();

                dgvPROVEEDORES.DataSource = resultado;
                dgvPROVEEDORES.ClearSelection();

                for (int i = 0; i < dgvPROVEEDORES.Rows.Count; i++)
                {
                    if (dgvPROVEEDORES.Rows[i].Cells["RNC"].Value?.ToString() == rncBuscado)
                    {
                        dgvPROVEEDORES.Rows[i].Selected = true;
                        dgvPROVEEDORES.CurrentCell = dgvPROVEEDORES.Rows[i].Cells[0];
                        break;
                    }
                }
            }

            else
            {
                MessageBox.Show("Proveedor no encontrado en la base de datos.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }

        }

        private void btnREGISTRAR_Click(object sender, EventArgs e)
        {

            try
            {
                // Validación de campos obligatorios
                if (string.IsNullOrWhiteSpace(TxtRNC.Text) || string.IsNullOrWhiteSpace(TxtNOMBRE.Text))
                {
                    MessageBox.Show("Por favor completa los campos obligatorios (RNC y Nombre).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación de precio
                decimal precio;
                if (!decimal.TryParse(TxtPRECIO.Text.Trim(), out precio))
                {
                    MessageBox.Show("Formato de precio inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (precio < 0 || precio > 1000000)
                {
                    MessageBox.Show("El precio debe estar entre 0 y 1,000,000.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Creación del proveedor según tipo
                PROVEEDOR nuevoProveedor;

                if (cmbTipoProveedor.SelectedItem?.ToString() == "LOCAL")
                {
                    nuevoProveedor = new ProveedorLocal(
                        TxtRNC.Text.Trim(),
                        TxtNOMBRE.Text.Trim(),
                        TxtTELEFONO.Text.Trim(),
                        TxtPRODUCTO.Text.Trim(),
                        precio
                    );
                }
                else if (cmbTipoProveedor.SelectedItem?.ToString() == "INTERNACIONAL")
                {
                    nuevoProveedor = new ProveedorInternacional(
                        TxtRNC.Text.Trim(),
                        TxtNOMBRE.Text.Trim(),
                        TxtTELEFONO.Text.Trim(),
                        TxtPRODUCTO.Text.Trim(),
                        precio
                    );
                }
                else
                {
                    MessageBox.Show("Selecciona un tipo válido para el proveedor.", "Tipo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación personalizada del proveedor
                if (!nuevoProveedor.EsValido())
                {
                    MessageBox.Show("El identificador ingresado no es válido.", "Validación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Inserción directa en la base de datos
                using (SqlConnection conn = new SqlConnection(new Productos_Agri().Conexion))
                {
                    conn.Open();

                    CNProveedor negocio = new CNProveedor();
                    negocio.InsertarProveedorEnBD(nuevoProveedor, conn);

                    MessageBox.Show("Proveedor registrado correctamente.");
                    LimpiarCampos();
                    CargarProveedoresDesdeBD();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }


        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox txt) txt.Clear();
                if (control is MaskedTextBox msk) msk.Clear();
                if (control is ComboBox cmb) cmb.SelectedIndex = -1;
            }

            // Quitar selección visual del DataGridView
            if (dgvPROVEEDORES != null)
            {
                dgvPROVEEDORES.ClearSelection();
                dgvPROVEEDORES.CurrentCell = null;

                // Recargar desde la base de datos
                CargarProveedoresDesdeBD();
            }
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvPROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un proveedor para eliminar.");
                return;
            }

            string RNCaEliminar = dgvPROVEEDORES.CurrentRow.Cells["RNC"].Value?.ToString();

            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes)
                return;

            CNProveedor negocio = new CNProveedor();
            bool eliminado = negocio.EliminarProveedorPorRNC(RNCaEliminar); // Método que ya debe existir en CNProveedor

            if (eliminado)
            {
                MessageBox.Show("El registro se eliminó correctamente de la base de datos.");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el proveedor. Verifica el RNC o intenta nuevamente.");
            }

            // Refrescar el DataGridView desde la base de datos
            EnlazarDataGridView();

            dgvPROVEEDORES.ClearSelection();
            dgvPROVEEDORES.CurrentCell = null;

            TxtRNC.Clear();
            TxtNOMBRE.Clear();
            TxtTELEFONO.Clear();
            cmbTipoProveedor.SelectedIndex = -1;
            TxtPRODUCTO.Clear();
            TxtPRECIO.Clear(); // Si estás usando el campo de precio

        }



        private void dgvLISTATEMPORAL_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPROVEEDORES.Rows[e.RowIndex] != null)
            {
                DataGridViewRow fila = dgvPROVEEDORES.Rows[e.RowIndex];

                TxtRNC.Text = fila.Cells[0].Value?.ToString() ?? "";
                TxtNOMBRE.Text = fila.Cells[1].Value?.ToString() ?? "";
                TxtTELEFONO.Text = fila.Cells[2].Value?.ToString() ?? "";
                cmbTipoProveedor.Text = fila.Cells[3].Value?.ToString() ?? "";
                TxtPRODUCTO.Text = fila.Cells[4].Value?.ToString() ?? "";
                TxtPRECIO.Text = fila.Cells[5].Value?.ToString() ?? "";
            }
        }

        private void FormPROVEEDORES_Load(object sender, EventArgs e)
        {
            dgvPROVEEDORES.Columns.Clear();
            dgvPROVEEDORES.Columns.Add("RNC", "RNC");
            dgvPROVEEDORES.Columns.Add("NOMBRE", "NOMBRE");
            dgvPROVEEDORES.Columns.Add("TELEFONO", "TELEFONO");
            dgvPROVEEDORES.Columns.Add("TIPO", "TIPO");
            dgvPROVEEDORES.Columns.Add("PRODUCTO", "PRODUCTO");
            dgvPROVEEDORES.Columns.Add("PRECIO", "PRECIO");


            dgvPROVEEDORES.ClearSelection();
            dgvPROVEEDORES.CurrentCell = null;
        }


        private void btnEDITAR_Click(object sender, EventArgs e)
        {
            // Validar que hay un proveedor seleccionado
            if (dgvPROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un proveedor de la lista para editar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rncSeleccionado = dgvPROVEEDORES.CurrentRow.Cells["RNC"].Value?.ToString();

            // Crear proveedor actualizado según el tipo seleccionado
            PROVEEDOR proveedorActualizado;

            if (cmbTipoProveedor.SelectedItem?.ToString() == "LOCAL")
            {
                if (!decimal.TryParse(TxtPRECIO.Text.Trim(), out decimal precio))
                {
                    MessageBox.Show("Formato de precio inválido. Ingrese un número decimal.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (precio < 0 || precio > 1000000)
                {
                    MessageBox.Show("El precio debe estar entre 0 y 1,000,000.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                proveedorActualizado = new ProveedorLocal(
                    TxtRNC.Text.Trim(),
                    TxtNOMBRE.Text.Trim(),
                    TxtTELEFONO.Text.Trim(),
                    TxtPRODUCTO.Text.Trim(),
                    precio
                );
            }
            else if (cmbTipoProveedor.SelectedItem?.ToString() == "INTERNACIONAL")
            {
                if (!decimal.TryParse(TxtPRECIO.Text.Trim(), out decimal precio))
                {
                    MessageBox.Show("Formato de precio inválido. Ingrese un número decimal.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (precio < 0 || precio > 1000000)
                {
                    MessageBox.Show("El precio debe estar entre 0 y 1,000,000.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                proveedorActualizado = new ProveedorInternacional(
                    TxtRNC.Text.Trim(),
                    TxtNOMBRE.Text.Trim(),
                    TxtTELEFONO.Text.Trim(),
                    TxtPRODUCTO.Text.Trim(),
                    precio
                );
            }
            else
            {
                MessageBox.Show("Selecciona un tipo válido para el proveedor.", "Tipo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!proveedorActualizado.EsValido())
            {
                MessageBox.Show("El identificador ingresado no es válido. Verifica el RNC o Pasaporte.", "Validación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar en la base de datos
            CNProveedor negocio = new CNProveedor();
            bool actualizado = negocio.ActualizarProveedor(rncSeleccionado, proveedorActualizado);

            if (actualizado)
            {
                MessageBox.Show("Proveedor actualizado correctamente.", "Edición exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el proveedor. Verifica los datos e intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refrescar el DataGridView desde la base de datos
            EnlazarDataGridView();

            dgvPROVEEDORES.ClearSelection();
            dgvPROVEEDORES.CurrentCell = null;

            // Limpiar campos
            TxtRNC.Clear();
            TxtNOMBRE.Clear();
            TxtTELEFONO.Clear();
            cmbTipoProveedor.SelectedIndex = -1;
            TxtPRODUCTO.Clear();
            TxtPRECIO.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pantalla_De_Inicio form = new Pantalla_De_Inicio();
            form.Show();
            this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtNOMBRE_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
