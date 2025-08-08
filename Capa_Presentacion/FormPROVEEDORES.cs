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
    // Define una clase parcial para el formulario de proveedores, que hereda de la clase Form.
    public partial class FormPROVEEDORES : Form
    {
        // TODO --- SECCI�N: Variables de Clase y Constructor ---

        // Variable para la capa de negocios de proveedores, inicializada para su uso en los m�todos.
        private CNProveedor cnProveedor = new CNProveedor();

        public FormPROVEEDORES()
        {
            InitializeComponent();

            // L�gica para inicializar el ComboBox si no tiene elementos.
            if (cmbTipoProveedor.Items.Count == 0)
            {
                cmbTipoProveedor.Items.Add("LOCAL");
                cmbTipoProveedor.Items.Add("INTERNACIONAL");
            }

            // Selecciona el primer elemento por defecto.
            cmbTipoProveedor.SelectedIndex = 0;
        }

        //TODO  --- SECCI�N: M�todos Auxiliares ---
        // Estos m�todos ayudan a mantener el c�digo limpio y a evitar la duplicaci�n de l�gica.

        // TODO: L�gica para mostrar los datos en la interfaz
        private void CargarProveedoresDesdeBD()
        {
            try
            {
                // Instancia de la capa de negocios para obtener los datos de los proveedores.
                CNProveedor negocio = new CNProveedor();
                // Asigna el DataTable resultante al DataSource del DataGridView.
                dgvPROVEEDORES.DataSource = negocio.ObtenerTodosLosProveedores();
                // Deselecciona todas las filas del DataGridView.
                dgvPROVEEDORES.ClearSelection();
            }

            catch (Exception ex)
            {
                // Muestra un mensaje de error si la carga falla.
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            // Borra el texto de todos los campos de entrada para el formulario.
            TxtRNC.Text = "";
            TxtNOMBRE.Text = "";
            TxtTELEFONO.Text = "";
            cmbTipoProveedor.Text = "";
            TxtPRODUCTO.Text = "";
            TxtPRECIO.Text = "";
        }

        // TODO --- SECCI�N: Eventos del Formulario (Load y Cierre) ---

        private void FormPROVEEDORES_Load(object sender, EventArgs e)
        {
            // Configuraci�n inicial del DataGridView al cargar el formulario.
            // Esto previene que se generen columnas autom�ticas.
            dgvPROVEEDORES.AutoGenerateColumns = false;
            dgvPROVEEDORES.Columns.Clear();

            // Se definen las columnas manualmente, especificando el nombre y a qu� campo de la base de datos se enlazan.
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "IDPROVEEDOR", HeaderText = "ID", DataPropertyName = "IDPROVEEDOR" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "RNC", HeaderText = "RNC", DataPropertyName = "RNC" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "NOMBRE", HeaderText = "Nombre", DataPropertyName = "NOMBRE" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "TELEFONO", HeaderText = "Tel�fono", DataPropertyName = "TELEFONO" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "TIPO", HeaderText = "Tipo", DataPropertyName = "TIPO" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "PRODUCTO", HeaderText = "Producto", DataPropertyName = "PRODUCTO" });
            dgvPROVEEDORES.Columns.Add(new DataGridViewTextBoxColumn { Name = "PRECIO", HeaderText = "Precio", DataPropertyName = "PRECIO" });

            // Llama al m�todo para cargar los datos en el DataGridView al iniciar.
            CargarProveedoresDesdeBD();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual.
            this.Dispose();
        }

        //TODO  --- SECCI�N: L�gica de Botones Principales (CRUD) ---

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            // Maneja el evento de b�squeda de un proveedor por RNC.
            string rncBuscado = TxtRNC.Text.Trim();

            if (string.IsNullOrWhiteSpace(rncBuscado))
            {
                MessageBox.Show("Por favor ingresa un ID para buscar.", "Campo vac�o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CNProveedor negocio = new CNProveedor();
            DataTable resultado = negocio.BuscarProveedoresPorRNC(rncBuscado);

            if (resultado.Rows.Count > 0)
            {
                DataRow proveedor = resultado.Rows[0];

                // Llena los campos del formulario con los datos encontrados.
                TxtRNC.Text = proveedor["RNC"].ToString();
                TxtNOMBRE.Text = proveedor["NOMBRE"].ToString();
                TxtTELEFONO.Text = proveedor["TELEFONO"].ToString();
                cmbTipoProveedor.Text = proveedor["TIPO"].ToString();
                TxtPRODUCTO.Text = proveedor["PRODUCTO"].ToString();
                TxtPRECIO.Text = proveedor["PRECIO"].ToString();

                // Muestra solo el resultado de la b�squeda en el DataGridView y lo selecciona.
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
                // 1. Validar que todos los campos obligatorios no est�n vac�os.
                if (string.IsNullOrWhiteSpace(TxtRNC.Text) ||
                    string.IsNullOrWhiteSpace(TxtNOMBRE.Text) ||
                    string.IsNullOrWhiteSpace(TxtTELEFONO.Text) ||
                    string.IsNullOrWhiteSpace(TxtPRODUCTO.Text) ||
                    string.IsNullOrWhiteSpace(TxtPRECIO.Text))
                {
                    MessageBox.Show("Por favor completa todos los campos obligatorios.", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Mantener la validaci�n del precio.
                if (!decimal.TryParse(TxtPRECIO.Text.Trim(), out decimal precio) || precio < 0 || precio > 1000000)
                {
                    MessageBox.Show("El precio debe ser un n�mero v�lido entre 0 y 1,000,000.", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Selecciona un tipo v�lido para el proveedor.", "Tipo inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
            // Limpia los campos de texto, quita la selecci�n del DataGridView y recarga los datos.
            LimpiarCampos();
            if (dgvPROVEEDORES != null)
            {
                dgvPROVEEDORES.ClearSelection();
                dgvPROVEEDORES.CurrentCell = null;
                CargarProveedoresDesdeBD();
            }
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            // Maneja el evento de eliminaci�n de un proveedor seleccionado en el DataGridView.
            if (dgvPROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un proveedor para eliminar.");
                return;
            }

            string RNCaEliminar = dgvPROVEEDORES.CurrentRow.Cells["RNC"].Value?.ToString();

            DialogResult confirmacion = MessageBox.Show("�Est�s seguro de que deseas eliminar este proveedor?", "Confirmar eliminaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes)
                return;

            CNProveedor negocio = new CNProveedor();
            bool eliminado = negocio.EliminarProveedorPorRNC(RNCaEliminar);

            if (eliminado)
            {
                MessageBox.Show("El registro se elimin� correctamente de la base de datos.");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el proveedor. Verifica el RNC o intenta nuevamente.");
            }

            // Refresca la interfaz despu�s de la eliminaci�n.
            CargarProveedoresDesdeBD();
            LimpiarCampos();
        }

        private void btnEDITAR_Click(object sender, EventArgs e)
        {
            if (dgvPROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un proveedor de la lista para editar.", "Sin selecci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Validar que todos los campos no est�n vac�os.
                if (string.IsNullOrWhiteSpace(TxtRNC.Text) ||
                    string.IsNullOrWhiteSpace(TxtNOMBRE.Text) ||
                    string.IsNullOrWhiteSpace(TxtTELEFONO.Text) ||
                    string.IsNullOrWhiteSpace(TxtPRODUCTO.Text) ||
                    string.IsNullOrWhiteSpace(TxtPRECIO.Text))
                {
                    MessageBox.Show("Por favor completa todos los campos obligatorios.", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string rncSeleccionado = dgvPROVEEDORES.CurrentRow.Cells["RNC"].Value?.ToString();

                if (!decimal.TryParse(TxtPRECIO.Text.Trim(), out decimal precio) || precio < 0 || precio > 1000000)
                {
                    MessageBox.Show("Formato de precio inv�lido. Debe estar entre 0 y 1,000,000.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Selecciona un tipo v�lido para el proveedor.", "Tipo inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CNProveedor negocio = new CNProveedor();
                bool actualizado = negocio.ActualizarProveedor(rncSeleccionado, proveedorActualizado);

                if (actualizado)
                {
                    MessageBox.Show("Proveedor actualizado correctamente.", "Edici�n exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el proveedor. El RNC original no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error de validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurri� un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CargarProveedoresDesdeBD();
                LimpiarCampos();
            }
        }

        //TODO  --- SECCI�N: Eventos de la Interfaz (Clicks en PictureBox) ---

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Configura la interfaz para el modo "Registrar". Oculta otros botones y habilita los campos.
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
            // Configura la interfaz para el modo "Buscar".
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
            // Configura la interfaz para el modo "Editar".
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
            // Configura la interfaz para el modo "Eliminar".
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
            // Configura la interfaz para el modo "Limpiar".
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

        // TODO --- SECCI�N: Eventos No Implementados o Vac�os ---

        private void dgvLISTATEMPORAL_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Evento vac�o, no realiza ninguna acci�n.
        }

        private void TxtNOMBRE_TextChanged(object sender, EventArgs e)
        {
            // Evento vac�o, no realiza ninguna acci�n.
        }

        private void TxtIDPROVEEDOR_TextChanged(object sender, EventArgs e)
        {
            // Evento vac�o, no realiza ninguna acci�n.
        }

        private void TxtNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si es un n�mero, se marca como "manejado" (Handled = true), lo que previene que aparezca en el TextBox.
                e.Handled = true;
            }
        }

        private void TxtPRODUCTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si es un n�mero, se marca como "manejado" (Handled = true), lo que previene que aparezca en el TextBox.
                e.Handled = true;
            }
        }

        private void TxtPRECIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permite solo un punto decimal.
            // Evita que se escriban m�ltiples puntos en el mismo campo.
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}