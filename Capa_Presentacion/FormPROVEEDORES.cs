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




        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            string rncBuscado = TxtRNC.Text.Trim();

            if (string.IsNullOrWhiteSpace(rncBuscado))
            {
                MessageBox.Show("Por favor ingresa un ID para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CNProveedor negocio = new CNProveedor();
            DataTable resultado = negocio.BuscarProveedoresPorRNC(rncBuscado);

            if (resultado.Rows.Count > 0)
            {
                DataRow proveedor = resultado.Rows[0];

                TxtRNC.Text = proveedor["RNC"].ToString();
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
                if (string.IsNullOrWhiteSpace(TxtRNC.Text) || string.IsNullOrWhiteSpace(TxtNOMBRE.Text))
                {
                    MessageBox.Show("Por favor completa los campos obligatorios (RNC y Nombre).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(TxtPRECIO.Text.Trim(), out decimal precio) || precio < 0 || precio > 1000000)
                {
                    MessageBox.Show("El precio debe ser un número válido entre 0 y 1,000,000.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PROVEEDOR nuevoProveedor;
                string tipoProveedor = cmbTipoProveedor.SelectedItem?.ToString();

                if (tipoProveedor == "LOCAL")
                {
                    nuevoProveedor = new ProveedorLocal(TxtRNC.Text.Trim(), TxtNOMBRE.Text.Trim(), TxtTELEFONO.Text.Trim(), TxtPRODUCTO.Text.Trim(), precio);
                }
                else if (tipoProveedor == "INTERNACIONAL")
                {
                    nuevoProveedor = new ProveedorInternacional(TxtRNC.Text.Trim(), TxtNOMBRE.Text.Trim(), TxtTELEFONO.Text.Trim(), TxtPRODUCTO.Text.Trim(), precio);
                }
                else
                {
                    MessageBox.Show("Selecciona un tipo válido para el proveedor.", "Tipo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

             

                using (SqlConnection conn = new SqlConnection(new Productos_Agri().Conexion))
                {
                    conn.Open();
                    CNProveedor negocio = new CNProveedor();
                    negocio.InsertarProveedorEnBD(nuevoProveedor, conn);

                    MessageBox.Show("Proveedor registrado correctamente.");
                    LimpiarCampos();
                    CargarProveedoresDesdeBD(); // Refrescar el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }


        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {

            // Llamar al método que ya limpia los campos correctamente.
            LimpiarCampos();

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
            bool eliminado = negocio.EliminarProveedorPorRNC(RNCaEliminar);

            if (eliminado)
            {
                MessageBox.Show("El registro se eliminó correctamente de la base de datos.");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el proveedor. Verifica el RNC o intenta nuevamente.");
            }

            // Se llama al método correcto para refrescar.
            CargarProveedoresDesdeBD();
            LimpiarCampos();

        }



        private void dgvLISTATEMPORAL_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void FormPROVEEDORES_Load(object sender, EventArgs e)
        {
            // Evitar que se generen columnas automáticamente
            dgvPROVEEDORES.AutoGenerateColumns = false;
            dgvPROVEEDORES.Columns.Clear();

            // Definir las columnas manualmente y enlazar con los datos del DataTable
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "IDPROVEEDOR", HeaderText = "ID", DataPropertyName = "IDPROVEEDOR" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "RNC", HeaderText = "RNC", DataPropertyName = "RNC" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "NOMBRE", HeaderText = "Nombre", DataPropertyName = "NOMBRE" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "TELEFONO", HeaderText = "Teléfono", DataPropertyName = "TELEFONO" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "TIPO", HeaderText = "Tipo", DataPropertyName = "TIPO" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "PRODUCTO", HeaderText = "Producto", DataPropertyName = "PRODUCTO" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "PRECIO", HeaderText = "Precio", DataPropertyName = "PRECIO" });

            //Cargar los datos desde la base de datos
            CargarProveedoresDesdeBD();
        }


        private void btnEDITAR_Click(object sender, EventArgs e)
        {
            if (dgvPROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un proveedor de la lista para editar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string rncSeleccionado = dgvPROVEEDORES.CurrentRow.Cells["RNC"].Value?.ToString();

                if (!decimal.TryParse(TxtPRECIO.Text.Trim(), out decimal precio) || precio < 0 || precio > 1000000)
                {
                    MessageBox.Show("Formato de precio inválido. Debe estar entre 0 y 1,000,000.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PROVEEDOR proveedorActualizado;
                string tipoProveedor = cmbTipoProveedor.SelectedItem?.ToString();

                if (tipoProveedor == "LOCAL")
                {
                    proveedorActualizado = new ProveedorLocal(TxtRNC.Text.Trim(), TxtNOMBRE.Text.Trim(), TxtTELEFONO.Text.Trim(), TxtPRODUCTO.Text.Trim(), precio);
                }
                else if (tipoProveedor == "INTERNACIONAL")
                {
                    proveedorActualizado = new ProveedorInternacional(TxtRNC.Text.Trim(), TxtNOMBRE.Text.Trim(), TxtTELEFONO.Text.Trim(), TxtPRODUCTO.Text.Trim(), precio);
                }
                else
                {
                    MessageBox.Show("Selecciona un tipo válido para el proveedor.", "Tipo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CNProveedor negocio = new CNProveedor();
                bool actualizado = negocio.ActualizarProveedor(rncSeleccionado, proveedorActualizado);

                if (actualizado)
                {
                    MessageBox.Show("Proveedor actualizado correctamente.", "Edición exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el proveedor. El RNC original no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex)
            {
                // Captura el error específico de RNC duplicado.
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Captura cualquier otro error inesperado.
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Se ejecuta siempre para refrescar la interfaz.
                CargarProveedoresDesdeBD();
                LimpiarCampos();
            }
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtNOMBRE_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btnLIMPIAR.Hide();
            btnBUSCAR.Hide();
            btnEDITAR.Hide();
            btnELIMINAR.Hide();
            btnREGISTRAR.Show();
            TxtNOMBRE.Enabled = true;
            TxtRNC.Enabled = true;
            TxtTELEFONO.Enabled = true;
            TxtPRECIO.Enabled = true;
            TxtPRODUCTO.Enabled = true;
            cmbTipoProveedor.Enabled = true;
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            btnLIMPIAR.Hide();
            btnREGISTRAR.Hide();
            btnEDITAR.Hide();
            btnELIMINAR.Hide();
            btnBUSCAR.Show();
            TxtNOMBRE.Enabled = true;
            TxtRNC.Enabled = true;
            TxtTELEFONO.Enabled = true;
            TxtPRECIO.Enabled = true;
            TxtPRODUCTO.Enabled = true;
            cmbTipoProveedor.Enabled = true;

        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            btnLIMPIAR.Hide();
            btnREGISTRAR.Hide();
            btnBUSCAR.Hide();
            btnELIMINAR.Hide();
            btnEDITAR.Show();
            TxtNOMBRE.Enabled = true;
            TxtRNC.Enabled = true;
            TxtTELEFONO.Enabled = true;
            TxtPRECIO.Enabled = true;
            TxtPRODUCTO.Enabled = true;
            cmbTipoProveedor.Enabled = true;
        }

        private void pbBorrar_Click(object sender, EventArgs e)
        {
            btnLIMPIAR.Hide();
            btnREGISTRAR.Hide();
            btnBUSCAR.Hide();
            btnEDITAR.Hide();
            btnELIMINAR.Show();
            TxtNOMBRE.Enabled = true;
            TxtRNC.Enabled = true;
            TxtTELEFONO.Enabled = true;
            TxtPRECIO.Enabled = true;
            TxtPRODUCTO.Enabled = true;
            cmbTipoProveedor.Enabled = true;
        }

        private void pbLimpiar_Click(object sender, EventArgs e)
        {
            btnELIMINAR.Hide();
            btnREGISTRAR.Hide();
            btnBUSCAR.Hide();
            btnEDITAR.Hide();
            btnLIMPIAR.Show();
            TxtNOMBRE.Enabled = true;
            TxtRNC.Enabled = true;
            TxtTELEFONO.Enabled = true;
            TxtPRECIO.Enabled = true;
            TxtPRODUCTO.Enabled = true;
            cmbTipoProveedor.Enabled = true;
        }

        private void TxtIDPROVEEDOR_TextChanged(object sender, EventArgs e)
        {


        }
    }

}
