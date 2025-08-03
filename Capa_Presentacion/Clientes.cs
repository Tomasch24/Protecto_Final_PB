using Capa_negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            pbAtras.Hide();
            Mclientes();
            txtNombre.MaxLength = 50;
            txtCorreo.MaxLength = 50;
            txtIdCliente.Hide();
            lblIdCliente.Hide();
            pbBuscarIdCliente.Hide();
        }
        private void Mclientes()
        {
            CNClienteDal datos = new CNClienteDal();
            var lista = datos.MostrarClientes();

            dgvClientes.DataSource = lista.Select(c => new
            {
                c.IdCliente,
                c.Nombre,
                c.Telefono,
                c.RNC,
                c.Correo
            }).ToList();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            MtxtTelefono.Text = "";
            MtxtRnc.Text = "";
            txtCorreo.Text = "";

        }

        private int? idClienteEditando = null;
        //TODO Evento para editar clientes

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente para editar.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "¿Estás seguro de que deseas editar los datos del cliente seleccionado?",
                "Confirmar Edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            DataGridViewRow fila = dgvClientes.SelectedRows[0];
            idClienteEditando = Convert.ToInt32(fila.Cells["IdCliente"].Value); // Guardar ID del cliente para saber que se está editando

            // Llenar los campos del formulario con los datos seleccionados
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            MtxtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            MtxtRnc.Text = fila.Cells["RNC"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value?.ToString();

            // Cambiar el texto y estilo del botón Guardar para indicar "modo edición"
            btnGuardarCliente.Text = "Guardar Cambios";
            btnGuardarCliente.BackColor = Color.SkyBlue;
            btnGuardarCliente.ForeColor = Color.Black;


            Mclientes();
            LimpiarCampos();

        }
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Error en el campo Nombre.", "Ingrese un Nombre valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!MtxtTelefono.MaskCompleted)
            {
                MessageBox.Show("El campo Teléfono está incompleto.", "Favor completar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!MtxtRnc.MaskCompleted)
            {
                MessageBox.Show("El campo RNC está incompleto.", "Favor completar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {


                if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                    throw new Exception("El campo de correo está vacío.");

                if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
                    throw new Exception("Formato de correo inválido." + "\nFavor usar una direccion de correo valida: usuario@ejemplo.com");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            CNCliente cliente = new CNCliente(txtNombre.Text.Trim(), MtxtTelefono.Text.Trim(), MtxtRnc.Text.Trim(), txtCorreo.Text.Trim());

            cliente.Correo = txtCorreo.Text.Trim();


            CNClienteDal datos = new CNClienteDal();
            int resultado;

            if (idClienteEditando != null)
            {
                //TODO Modo edición
                cliente.IdCliente = idClienteEditando.Value;
                resultado = datos.EditarCliente(cliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el cliente.");
                }

                // Restaurar modo normal del botón
                idClienteEditando = null;
                btnGuardarCliente.Text = "Registrar";
                btnGuardarCliente.BackColor = Color.Gainsboro;

            }
            else
            {
                // Modo creación
                resultado = datos.InsertarCliente(cliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente registrado correctamente.");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar el cliente.");
                }
            }


            Mclientes();
            LimpiarCampos();
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y teclas de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquear la tecla
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.No) return;

            // Obtener el ID del cliente seleccionado en el DataGridView
            int idClienteSelec = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["IdCliente"].Value);

            // Llamar a la lógica de datos para eliminar el cliente
            CNClienteDal datos = new CNClienteDal();
            int eliminado = datos.EliminarCliente(idClienteSelec);

            if (eliminado > 0)
            {
                MessageBox.Show("Cliente eliminado correctamente.");
                Mclientes(); // Refrescar el listado
                LimpiarCampos(); // Limpiar los campos si alguno estaba cargado
            }
            else
            {
                MessageBox.Show("Error al eliminar el cliente.");
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar.Hide();
            lblIdCliente.Show();
            txtIdCliente.Show();
            txtIdCliente.Text = "";
            pbBuscarIdCliente.Show();
        }

        private void pbBuscarIdCliente_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCliente.Text, out int id))
            {
                MessageBox.Show("Por favor ingrese un Id de factura válido.");
                return;
            }

            CNCliente cliente = CNClienteDal.BuscarPorId(id);

            if (cliente != null)
            {
                dgvClientes.DataSource = new[]
                {
                    new
                    {

                        cliente.IdCliente,
                        cliente.Nombre,
                        cliente.Telefono,
                        cliente.RNC,
                        cliente.Correo
                    }
                };



            }
            else
            {
                MessageBox.Show("No se encontró ninguna factura con ese Id.");
            }
            btnBuscar.Show();
            lblIdCliente.Hide();
            txtIdCliente.Hide();
            pbAtras.Show();
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            Mclientes();
            pbAtras.Hide();

        }
    }
}
