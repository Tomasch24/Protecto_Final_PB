using System.Data;
using System.Diagnostics.Eventing.Reader;
using Capa_Datos;
using Capa_Negocios;
using Capa_Presentacion;
using Microsoft.Data.SqlClient;

namespace Capa.Presentacion
{
    public partial class FormLISTATEMPORAL : Form
    {

        private List<PROVEEDOR> listaProveedoresTemporal = new List<PROVEEDOR>();
        private CNProveedor cnProveedor = new CNProveedor();

        public FormLISTATEMPORAL()
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
            dgvLISTATEMPORAL.DataSource = null; // Desenlazar para refrescar
            dgvLISTATEMPORAL.DataSource = listaProveedoresTemporal; // Enlazar a la lista temporal
        }


        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            string rncBuscado = TxtRNC.Text.Trim();

            if (string.IsNullOrWhiteSpace(rncBuscado))
            {
                MessageBox.Show("Por favor ingresa un RNC para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar en la lista temporal
            var proveedorEncontrado = listaProveedoresTemporal.FirstOrDefault(p => p.RNC == rncBuscado);

            if (proveedorEncontrado != null)
            {
                // Llenar los campos del formulario
                TxtNOMBRE.Text = proveedorEncontrado.NOMBRE;
                TxtTELEFONO.Text = proveedorEncontrado.TELEFONO;
                cmbTipoProveedor.Text = proveedorEncontrado.TIPO;
                TxtPRODUCTO.Text = proveedorEncontrado.PRODUCTO;


                // Seleccionar la fila correspondiente en el DataGridView
                for (int i = 0; i < dgvLISTATEMPORAL.Rows.Count; i++)
                {
                    if (dgvLISTATEMPORAL.Rows[i].Cells[0].Value?.ToString() == rncBuscado)
                    {
                        dgvLISTATEMPORAL.ClearSelection();
                        dgvLISTATEMPORAL.Rows[i].Selected = true;
                        dgvLISTATEMPORAL.CurrentCell = dgvLISTATEMPORAL.Rows[i].Cells[0];
                        break;
                    }
                }

                // MessageBox.Show("Proveedor encontrado y cargado en la lista.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Proveedor no encontrado en la lista temporal.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnREGISTRAR_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtRNC.Text) || string.IsNullOrWhiteSpace(TxtNOMBRE.Text))
            {
                MessageBox.Show("Por favor completa los campos obligatorios (RNC y Nombre).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear proveedor según el tipo seleccionado
            PROVEEDOR nuevoProveedor;

            if (cmbTipoProveedor.SelectedItem?.ToString() == "LOCAL")
            {
                nuevoProveedor = new ProveedorLocal(
                    TxtRNC.Text.Trim(),
                    TxtNOMBRE.Text.Trim(),
                    TxtTELEFONO.Text.Trim(),
                    TxtPRODUCTO.Text.Trim()
                );
            }
            else if (cmbTipoProveedor.SelectedItem?.ToString() == "INTERNACIONAL")
            {
                nuevoProveedor = new ProveedorInternacional(
                    TxtRNC.Text.Trim(),
                    TxtNOMBRE.Text.Trim(),
                    TxtTELEFONO.Text.Trim(),
                    TxtPRODUCTO.Text.Trim()
                );
            }
            else
            {
                MessageBox.Show("Selecciona un tipo de proveedor válido.", "Tipo no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación personalizada desde la clase
            if (!nuevoProveedor.EsValido())
            {
                MessageBox.Show("El identificador no es válido. Verifica el RNC o pasaporte.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar duplicados
            if (listaProveedoresTemporal.Any(p => p.ObtenerIdentificadorPrincipal() == nuevoProveedor.ObtenerIdentificadorPrincipal()))
            {
                MessageBox.Show("Ya existe un proveedor con este identificador en la lista temporal.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar a la lista temporal
            listaProveedoresTemporal.Add(nuevoProveedor);

            // Refrescar el DataGridView
            dgvLISTATEMPORAL.Rows.Clear();
            foreach (var proveedor in listaProveedoresTemporal)
            {
                dgvLISTATEMPORAL.Rows.Add(
                    proveedor.RNC,
                    proveedor.NOMBRE,
                    proveedor.TELEFONO,
                    proveedor.TIPO,
                    proveedor.PRODUCTO

                );
            }


            TxtRNC.Clear();
            TxtNOMBRE.Clear();
            TxtTELEFONO.Clear();
            cmbTipoProveedor.SelectedIndex = -1;
            TxtPRODUCTO.Clear();


            // Quitar selección azul
            dgvLISTATEMPORAL.ClearSelection();
            dgvLISTATEMPORAL.CurrentCell = null;

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
            if (dgvLISTATEMPORAL != null)
            {
                dgvLISTATEMPORAL.ClearSelection();
                dgvLISTATEMPORAL.CurrentCell = null;

                // Volver a cargar la lista completa (sin filtrar ni alterar)
                dgvLISTATEMPORAL.Rows.Clear();
                foreach (var proveedor in listaProveedoresTemporal)
                {
                    dgvLISTATEMPORAL.Rows.Add(
                        proveedor.RNC,
                        proveedor.NOMBRE,
                        proveedor.TELEFONO,
                        proveedor.PRODUCTO,
                        proveedor.TIPO
                    );
                }
            }
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {

            if (dgvLISTATEMPORAL.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un proveedor para eliminar.");
                return;
            }

            string RNCaEliminar = dgvLISTATEMPORAL.CurrentRow.Cells[0].Value?.ToString();

            PROVEEDOR proveedorAEliminar = listaProveedoresTemporal.FirstOrDefault(p => p.RNC == RNCaEliminar);
            if (proveedorAEliminar != null)
            {
                listaProveedoresTemporal.Remove(proveedorAEliminar);
                MessageBox.Show("El Registro se eliminó correctamente de la lista temporal.");
            }
            else
            {
                MessageBox.Show("El proveedor no fue encontrado en la lista temporal.");
            }

            // Refrescar manualmente el DataGridView
            dgvLISTATEMPORAL.Rows.Clear();
            foreach (var proveedor in listaProveedoresTemporal)
            {
                dgvLISTATEMPORAL.Rows.Add(
                    proveedor.RNC,
                    proveedor.NOMBRE,
                    proveedor.TELEFONO,
                    proveedor.TIPO,
                    proveedor.PRODUCTO

                );
            }

            dgvLISTATEMPORAL.ClearSelection();
            dgvLISTATEMPORAL.CurrentCell = null;


            TxtRNC.Clear();
            TxtNOMBRE.Clear();
            TxtTELEFONO.Clear();
            cmbTipoProveedor.SelectedIndex = -1;
            TxtPRODUCTO.Clear();

        }

        private void btnGUARDARENBD_Click(object sender, EventArgs e)
        {
            if (!listaProveedoresTemporal.Any())
            {
                MessageBox.Show("No hay proveedores en la lista para guardar.");
                return;
            }

            try
            {
                // guarda los proveedores en la BD.
                cnProveedor.GuardarListaProveedores(listaProveedoresTemporal);
                MessageBox.Show("Proveedores guardados en la Base de Datos exitosamente.");

                //  Marcamos el resultado como "OK" para avisar que todo salió bien.
                this.DialogResult = DialogResult.OK;

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message);
                // Si hay un error, el formulario no se cierra y no se marca como OK.
            }
        }

        private void dgvLISTATEMPORAL_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLISTATEMPORAL.Rows[e.RowIndex] != null)
            {
                DataGridViewRow fila = dgvLISTATEMPORAL.Rows[e.RowIndex];

                TxtRNC.Text = fila.Cells[0].Value?.ToString() ?? "";
                TxtNOMBRE.Text = fila.Cells[1].Value?.ToString() ?? "";
                TxtTELEFONO.Text = fila.Cells[2].Value?.ToString() ?? "";
                cmbTipoProveedor.Text = fila.Cells[3].Value?.ToString() ?? "";
                TxtPRODUCTO.Text = fila.Cells[4].Value?.ToString() ?? "";
            }
        }

        private void FormLISTATEMPORAL_Load(object sender, EventArgs e)
        {
            dgvLISTATEMPORAL.Columns.Clear();
            dgvLISTATEMPORAL.Columns.Add("RNC", "RNC");
            dgvLISTATEMPORAL.Columns.Add("NOMBRE", "NOMBRE");
            dgvLISTATEMPORAL.Columns.Add("TELEFONO", "TELEFONO");
            dgvLISTATEMPORAL.Columns.Add("TIPO", "TIPO");
            dgvLISTATEMPORAL.Columns.Add("PRODUCTO", "PRODUCTO");


            dgvLISTATEMPORAL.ClearSelection();
            dgvLISTATEMPORAL.CurrentCell = null;
        }

        private void btnEDITAR_Click(object sender, EventArgs e)
        {
            // Validar que hay un proveedor seleccionado
            if (dgvLISTATEMPORAL.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un proveedor de la lista para editar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rncSeleccionado = dgvLISTATEMPORAL.CurrentRow.Cells[0].Value?.ToString();

            // Buscar proveedor en la lista temporal
            var proveedorOriginal = listaProveedoresTemporal.FirstOrDefault(p => p.RNC == rncSeleccionado);
            if (proveedorOriginal == null)
            {
                MessageBox.Show("No se pudo encontrar el proveedor en la lista temporal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear proveedor actualizado según el tipo seleccionado
            PROVEEDOR proveedorActualizado;

            if (cmbTipoProveedor.SelectedItem?.ToString() == "LOCAL")
            {
                proveedorActualizado = new ProveedorLocal(
                    TxtRNC.Text.Trim(),
                    TxtNOMBRE.Text.Trim(),
                    TxtTELEFONO.Text.Trim(),
                    TxtPRODUCTO.Text.Trim()
                );
            }
            else if (cmbTipoProveedor.SelectedItem?.ToString() == "INTERNACIONAL")
            {
                proveedorActualizado = new ProveedorInternacional(
                    TxtRNC.Text.Trim(),
                    TxtNOMBRE.Text.Trim(),
                    TxtTELEFONO.Text.Trim(),
                    TxtPRODUCTO.Text.Trim()
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

            // Reemplazar el proveedor en la misma posición de la lista
            int indice = listaProveedoresTemporal.IndexOf(proveedorOriginal);
            listaProveedoresTemporal[indice] = proveedorActualizado;

            // Refrescar el DataGridView
            dgvLISTATEMPORAL.Rows.Clear();
            foreach (var proveedor in listaProveedoresTemporal)
            {
                dgvLISTATEMPORAL.Rows.Add(
                    proveedor.RNC,
                    proveedor.NOMBRE,
                    proveedor.TELEFONO,
                    proveedor.TIPO,
                    proveedor.PRODUCTO

                );
            }

            dgvLISTATEMPORAL.ClearSelection();
            dgvLISTATEMPORAL.CurrentCell = null;

            // Limpiar campos
            TxtRNC.Clear();
            TxtNOMBRE.Clear();
            TxtTELEFONO.Clear();
            cmbTipoProveedor.SelectedIndex = -1;
            TxtPRODUCTO.Clear();


            MessageBox.Show("Proveedor actualizado correctamente.", "Edición exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormPRINCIPAL form = new FormPRINCIPAL();
            form.Show();
            this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }

}
