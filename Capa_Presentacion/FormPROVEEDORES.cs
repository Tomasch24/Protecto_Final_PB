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
            TxtIDPROVEEDOR.Text = "";
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
            string idBuscado = TxtIDPROVEEDOR.Text.Trim();

            if (string.IsNullOrWhiteSpace(idBuscado))
            {
                MessageBox.Show("Por favor ingresa un ID para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CNProveedor negocio = new CNProveedor();
            DataTable resultado = negocio.BuscarProveedoresPorID(idBuscado);

            if (resultado.Rows.Count > 0)
            {
                DataRow proveedor = resultado.Rows[0];

                TxtIDPROVEEDOR.Text = proveedor["IDPROVEEDOR"].ToString();
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
                    if (dgvPROVEEDORES.Rows[i].Cells["IDPROVEEDOR"].Value?.ToString() == idBuscado)
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
                    nuevoProveedor = new ProveedorLocal(TxtIDPROVEEDOR.Text.Trim(), TxtRNC.Text.Trim(), TxtNOMBRE.Text.Trim(), TxtTELEFONO.Text.Trim(), TxtPRODUCTO.Text.Trim(), precio);
                }
                else if (tipoProveedor == "INTERNACIONAL")
                {
                    nuevoProveedor = new ProveedorInternacional(TxtIDPROVEEDOR.Text.Trim(), TxtRNC.Text.Trim(), TxtNOMBRE.Text.Trim(), TxtTELEFONO.Text.Trim(), TxtPRODUCTO.Text.Trim(), precio);
                }
                else
                {
                    MessageBox.Show("Selecciona un tipo válido para el proveedor.", "Tipo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!nuevoProveedor.EsValido())
                {
                    MessageBox.Show("El identificador ingresado no es válido.", "Validación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // MODIFICADO: Se llama al método correcto para refrescar.
            CargarProveedoresDesdeBD();
            LimpiarCampos();

        }



        private void dgvLISTATEMPORAL_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void FormPROVEEDORES_Load(object sender, EventArgs e)
        {
            // 1. Evitar que se generen columnas automáticamente
            dgvPROVEEDORES.AutoGenerateColumns = false;
            dgvPROVEEDORES.Columns.Clear();

            // 2. Definir las columnas manualmente y enlazar con los datos del DataTable
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "IDPROVEEDOR", HeaderText = "ID", DataPropertyName = "IDPROVEEDOR" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "RNC", HeaderText = "RNC", DataPropertyName = "RNC" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "NOMBRE", HeaderText = "Nombre", DataPropertyName = "NOMBRE" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "TELEFONO", HeaderText = "Teléfono", DataPropertyName = "TELEFONO" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "TIPO", HeaderText = "Tipo", DataPropertyName = "TIPO" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "PRODUCTO", HeaderText = "Producto", DataPropertyName = "PRODUCTO" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "PRECIO", HeaderText = "Precio", DataPropertyName = "PRECIO" });

            // 3. Cargar los datos desde la base de datos
            CargarProveedoresDesdeBD();
        }


        private void btnEDITAR_Click(object sender, EventArgs e)
        {
            if (dgvPROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un proveedor de la lista para editar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                proveedorActualizado = new ProveedorLocal(TxtIDPROVEEDOR.Text.Trim(), TxtRNC.Text.Trim(), TxtNOMBRE.Text.Trim(), TxtTELEFONO.Text.Trim(), TxtPRODUCTO.Text.Trim(), precio);
            }
            else if (tipoProveedor == "INTERNACIONAL")
            {
                proveedorActualizado = new ProveedorInternacional(TxtIDPROVEEDOR.Text.Trim(), TxtRNC.Text.Trim(), TxtNOMBRE.Text.Trim(), TxtTELEFONO.Text.Trim(), TxtPRODUCTO.Text.Trim(), precio);
            }
            else
            {
                MessageBox.Show("Selecciona un tipo válido para el proveedor.", "Tipo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!proveedorActualizado.EsValido())
            {
                MessageBox.Show("El identificador ingresado no es válido.", "Validación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("No se pudo actualizar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // MODIFICADO: Se llama al método correcto para refrescar.
            CargarProveedoresDesdeBD();
            LimpiarCampos();
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
