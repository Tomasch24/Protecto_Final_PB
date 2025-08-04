using capa_negocios;
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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            cbTipo.Items.Add("Contado");
            cbTipo.Items.Add("Crédito");
            cbTipo.SelectedIndex = 0;
            txtTotal.Text = "0";


        }
        private void LimpiarCampos()
        {
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            MtxtRnc.Text = "";
            MtxtTelefono.Text = "";
            txtIdCliente.Text = "";
            txtIdProducto.Text = "";
            txtCambio.Text = "";
            txtPago.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
            txtStock.Text = "";
            txtTotal.Text = "0";
        }
        private void GenerarFactura()
        {
            /* var lista = FacturaDal.GenerarFacturas();

             dgvFactura.DataSource = null;
             dgvFactura.DataSource = lista.Select(f => new
             {
                 IdFactura = f.IdFactura,
                 IdCliente = f.Cliente?.IdCliente > 0 ? f.Cliente.IdCliente.ToString() : "No registrado",
                 Nombre = f.Cliente?.Nombre ?? f.NombreFactura ?? "Desconocido",
                 Telefono = f.TelefonoF,
                 Rnc = f.RncF,
                 f.Descripcion,
                 f.Cantidad,
                 f.Precio,
                 f.SubTotal,
                 f.Descuento,
                 f.Total,
                 Tipo = f.TipoFactura(),
                 f.Fecha
             }).ToList();*/


        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void pbBuscarIdCliente_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCliente.Text, out int idCliente))
            {
                MessageBox.Show("Por favor ingrese un Id de cliente válido.");
                return;
            }

            CNCliente cliente = CNClienteDal.BuscarPorId(idCliente);

            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                MtxtTelefono.Text = cliente.Telefono;
                MtxtRnc.Text = cliente.RNC;
                txtNombre.Tag = cliente; // Guarda el cliente para usarlo al facturar
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }

            txtNombre.ReadOnly = true;
            MtxtTelefono.ReadOnly = true;
            MtxtRnc.ReadOnly = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //TODO Capturas de error de los textbox
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Cliente esta incompleto.", "Favor completar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (string.IsNullOrWhiteSpace(txtIdProducto.Text))
            {
                MessageBox.Show("Error en el campo Producto.", "Ingrese un Producto valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(nudCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Error en el campo Cantidad.", "Ingrese una Cantidad valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Error en el campo Precio.", "Ingrese un Precio valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CNCliente cliente;
            if (int.TryParse(txtIdCliente.Text, out int id))
            {
                cliente = CNClienteDal.BuscarPorId(id);
            }
            else
            {
                cliente = new CNCliente(txtNombre.Text, MtxtTelefono.Text, MtxtRnc.Text, "");
            }


            Factura factura = cbTipo.SelectedItem?.ToString() == "Contado"
                ? new FacturaContado(cliente)
                : new FacturaCredito(cliente);

            factura.Descripcion = txtIdProducto.Text;
            factura.Precio = precio;
            factura.Cantidad = cantidad;
            factura.AplicarDescuento();
            factura.Fecha = dtpFecha.Value;
            factura.CalcularTotales();

            //TODO captura de exito o error al infresar datos
            int result = FacturaDal.IngresarDatos(factura);

            if (result > 0)
            {
                MessageBox.Show("Exito al guardar datos de factura", "Factura guardada con Exito", MessageBoxButtons.OK);

                dgvFactura.Rows.Add(new object[]
                {
                     txtIdProducto.Text,
                     txtProducto.Text,
                     txtPrecio.Text,
                     nudCantidad.Value,
                     factura.SubTotal
                });



                // GenerarFactura();

            }
            else
            {
                MessageBox.Show("Error 404: el codigo del cerebro del jeifferson de este codigo dejo de compilar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }

}
