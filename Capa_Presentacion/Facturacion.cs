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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Drawing.Imaging;
using DocumentFormat.OpenXml.Presentation;
using Rectangle = System.Drawing.Rectangle;
using Capa_Interfas;
using static Capa_Presentacion.UCProducto;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Capa_Presentacion
{
    public partial class Facturacion : Form
    {

        //TODO --- SECCIÓN: Constructor y Carga del Formulario ---
        // ---------------------------------------------------

        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            // Inicializa los ComboBox de tipo de factura y método de pago
            cbTipo.Items.Add("Contado");
            cbTipo.Items.Add("Crédito");
            cbTipo.SelectedIndex = 0;
            txtTotal.Text = "0";
            cbMetodoPago.Items.Add("Tarjeta de Credito/Debito");
            cbMetodoPago.Items.Add("Transferencia");
            cbMetodoPago.Items.Add("Efectivo");

            // Oculta los controles relacionados con el cambio de dinero al iniciar el formulario
            txtCambio.Hide();
            lblCambio.Hide();
            pbAtrasMP.Hide();
            btnGenerarFacturaPDF.Hide();
        }

        // TODO --- SECCIÓN: Métodos de Limpieza de Campos ---
        // ---------------------------------------------

        private void LimpiarCamposProducto()
        {
            // Limpia los campos de texto y el NumericUpDown del producto
            txtIdProducto.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
            txtStock.Text = "";
            nudCantidad.Value = 1;
        }

        private void LimpiarCamposExtras()
        {
            // Restablece los campos de pago, cambio y totales
            txtPago.Text = "0";
            txtCambio.Text = "0";
            txtCambio.Hide();
            lblCambio.Hide();
            pbAtrasMP.Hide();
            txtTotal.Text = "0";
            dgvFactura.Rows.Clear();
            txtPago.Hide();
            lblPago.Text = "Metodo de Pago";
            cbMetodoPago.Show();
        }

        private void LimpiarCamposCliente()
        {
            // Limpia los campos de información del cliente
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            MtxtRnc.Text = "";
            MtxtTelefono.Text = "";
            txtIdCliente.Text = "";
        }

        // TODO --- SECCIÓN: Manejo de Eventos de Teclas (KeyPress) ---
        // -------------------------------------------------------

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos, el punto decimal y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos, el punto decimal y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos, el punto decimal y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        // TODO --- SECCIÓN: Lógica de Búsqueda y Adición de Ítems ---
        // -----------------------------------------------------

        private void pbBuscarIdCliente_Click(object sender, EventArgs e)
        {
            // Busca un cliente por su ID y llena los campos correspondientes.
            // Los campos del cliente se hacen de solo lectura después de la búsqueda.
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
                txtNombre.Tag = cliente;
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
            // Valida los campos de cliente y producto, y luego agrega el producto a la factura.
            // Calcula el total y guarda la información en la base de datos.
            // TODO: Capturas de error de los textbox
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
            if (string.IsNullOrWhiteSpace(cbMetodoPago.Text))
            {
                MessageBox.Show("Error en el campo Metodo de Pago.", "Ingrese un Metodo de Pado valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int cantidad = Convert.ToInt32(nudCantidad.Text);
            int stock = Convert.ToInt32(txtStock.Text);

            if (cantidad > stock)
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string precioTexto = txtPrecio.Text.Replace("$", "").Replace(",", "").Trim();


            if (!decimal.TryParse(precioTexto, out decimal precio))
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

            factura.MetodoDePago = cbMetodoPago.SelectedItem?.ToString();
            factura.Producto = txtIdProducto.Text;
            factura.Precio = precio;
            factura.Cantidad = cantidad;
            factura.AplicarDescuento();
            factura.Fecha = dtpFecha.Value;


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
                     factura.SubTotal,
                     factura.Descuento
                });

                LimpiarCamposProducto();
                CalcularTotal();
            }
            else
            {
                MessageBox.Show("Error 404: el codigo del cerebro del jeifferson de este codigo dejo de compilar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // TODO --- SECCIÓN: Lógica de Cálculo y Generación de PDF ---
        // -----------------------------------------------------

        private void CalcularTotal()
        {
            // Itera sobre el DataGridView para calcular el total de la factura.
            decimal total = 0;

            foreach (DataGridViewRow row in dgvFactura.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(row.Cells[4].Value?.ToString(), out decimal subtotal) && decimal.TryParse(row.Cells[5].Value?.ToString(), out decimal descuento))
                {
                    total += (subtotal - descuento);
                }
            }

            txtTotal.Text = total.ToString("C", new CultureInfo("es-DO"));
        }

        private void btnGenerarFacturaPDF_Click(object sender, EventArgs e)
        {
            // Valida los datos del cliente, luego genera y guarda un archivo PDF de la factura.
            // Actualiza el stock de los productos vendidos después de generar el PDF.
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


            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

            guardar.Filter = "PDF Files (*.pdf)|*.pdf";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    CultureInfo cultura = new CultureInfo("es-DO");
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (MemoryStream ms = new MemoryStream())
                    {
                        Properties.Resources.LOGO_OSCURO.Save(ms, ImageFormat.Png);
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(ms.ToArray());
                        logo.ScaleAbsolute(100, 50);
                        logo.Alignment = Element.ALIGN_LEFT;
                        pdfDoc.Add(logo);
                    }

                    Paragraph infoEmpresa = new Paragraph("GreenPoint\nRNC: 123456789\nDirección: Av. Barcelo, Bavaro, Punta Cana\nTeléfono: (809) 123-4567\n\n", FontFactory.GetFont("Arial", "12", Font.Bold));
                    infoEmpresa.Alignment = Element.ALIGN_LEFT;
                    pdfDoc.Add(infoEmpresa);

                    pdfDoc.Add(new Paragraph("FACTURA\n", FontFactory.GetFont("Arial", "16", Font.Bold)));
                    pdfDoc.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy}", FontFactory.GetFont("Arial", "12")));
                    pdfDoc.Add(new Paragraph($"Cliente: {txtNombre.Text}"));
                    pdfDoc.Add(new Paragraph($"Teléfono: {MtxtTelefono.Text}"));
                    pdfDoc.Add(new Paragraph($"RNC: {MtxtRnc.Text}"));
                    pdfDoc.Add(new Paragraph($"Tipo de Factura: {cbTipo.SelectedItem.ToString()}\n\n"));

                    PdfPTable table = new PdfPTable(6);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 12f, 30f, 18f, 12f, 20f, 18f });
                    table.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.SpacingBefore = 10f;
                    table.SpacingAfter = 10f;
                    BaseColor colorFondo = new BaseColor(230, 230, 230);
                    FontFactory.GetFont("Arial", "12", Font.Bold);

                    string[] headers = { "Cod. Producto", "Producto", "Precio", "Cantidad", "Subtotal", "Descuento" };
                    foreach (string encabezado in headers)
                    {
                        PdfPCell celdaTitulo = new PdfPCell(new Phrase(encabezado, FontFactory.GetFont("Arial", "12", Font.Bold)))
                        {
                            BackgroundColor = colorFondo,
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            Padding = 5
                        };
                        table.AddCell(celdaTitulo);
                    }

                    foreach (DataGridViewRow row in dgvFactura.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string precioTexto = row.Cells[2].Value?.ToString() ?? "0";
                        precioTexto = Regex.Replace(precioTexto, @"[^\d.,]", "");

                        decimal precio = Convert.ToDecimal(precioTexto);
                        decimal subtotal = Convert.ToDecimal(row.Cells[4].Value);
                        decimal descuento = Convert.ToDecimal(row.Cells[5].Value);

                        table.AddCell(row.Cells[0].Value?.ToString() ?? "");
                        table.AddCell(row.Cells[1].Value?.ToString() ?? "");
                        table.AddCell(precio.ToString("C", cultura));
                        table.AddCell(row.Cells[3].Value?.ToString() ?? "");
                        table.AddCell(subtotal.ToString("C", cultura));
                        table.AddCell(descuento.ToString("C", cultura));
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Add(new Paragraph("\nTOTAL A PAGAR: " + txtTotal.Text, FontFactory.GetFont("Arial", "12", Font.Bold)));
                    pdfDoc.Close();
                    stream.Close();

                    foreach (DataGridViewRow row in dgvFactura.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
                        int cantidadVendida = Convert.ToInt32(row.Cells["Cantidad"].Value);

                        var producto = FacturaDal.BuscarPorId(idProducto);

                        producto.Stock -= cantidadVendida;
                        FacturaDal.ActualizarStock(producto);
                    }
                }

                MessageBox.Show("Factura generada con éxito.", "PDF Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimpiarCamposProducto();
            LimpiarCamposCliente();
            LimpiarCamposExtras();
        }

        //TODO  --- SECCIÓN: Lógica del DataGridView ---
        // ----------------------------------------

        private void dgvFactura_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Dibuja el icono de "eliminar" en la celda de la columna correspondiente.
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Zafacon25.Width;
                var h = Properties.Resources.Zafacon25.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Zafacon25, new Rectangle(x, y, w, h));

                e.Handled = true;
            }
        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Maneja el evento de clic en la celda de "eliminar" para quitar una fila de la factura.
            // Recalcula el total después de eliminar un producto.
            if (dgvFactura.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvFactura.Rows.RemoveAt(indice);
                    CalcularTotal();
                }
            }
        }

        // TODO --- SECCIÓN: Lógica de Búsqueda de Productos y Cálculo de Cambio ---
        // ------------------------------------------------------------------

        private void pbBuscarIdProducto_Click(object sender, EventArgs e)
        {
            // Abre un formulario de catálogo para que el usuario seleccione un producto.
            // La versión anterior de este método está comentada.
            using (var catalogo = new Catalogo_De_Los_Productos())
            {
                var resulta = catalogo.ShowDialog();

                if (resulta == DialogResult.OK)
                {

                }
            }
        }

        private void CalcularCambio()
        {
            // Calcula el cambio a devolver al cliente, validando que el pago sea suficiente.
            string totalTexto = txtTotal.Text.Replace("RD$", "").Replace(",", "").Trim();
            decimal total = Convert.ToDecimal(totalTexto);
            decimal efectivo;

            if (decimal.TryParse(txtPago.Text, out efectivo))
            {
                if (efectivo < total)
                {
                    MessageBox.Show("Error en el campo Efectivo.", "Ingrese una Cantidad de Efectivo mayor al Total a pagar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                    txtCambio.Text = "RD$0.00";
                }
                else
                {
                    decimal cambio = efectivo - total;

                    txtCambio.Text = cambio.ToString("C", new CultureInfo("es-DO"));
                }
            }
        }

        // TODO --- SECCIÓN: Eventos de Interfaz de Usuario ---
        // ---------------------------------------------

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            // Habilita los campos y botones del formulario para iniciar el proceso de facturación.
            cbTipo.Enabled = true;
            txtIdCliente.Enabled = true;
            txtNombre.Enabled = true;
            MtxtRnc.Enabled = true;
            MtxtTelefono.Enabled = true;

            nudCantidad.Enabled = true;
            txtTotal.Enabled = true;
            txtCambio.Enabled = true;
            txtPago.Enabled = true;
            pbAtrasMP.Enabled = true;
            pbBuscarIdCliente.Enabled = true;
            pbBuscarIdProducto.Enabled = true;
            btnAgregar.Enabled = true;
            btnGenerarFacturaPDF.Enabled = true;
            cbMetodoPago.Enabled = true;
            btnGenerarFacturaPDF.Show();
            btnFacturar.Hide();
        }

        private void cbMetodoPago_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Maneja la selección del método de pago. Si es 'Efectivo', muestra los campos de pago y cambio.
            string seleccion = cbMetodoPago.SelectedItem?.ToString();

            switch (seleccion)
            {
                case "Efectivo":
                    cbMetodoPago.Hide();
                    lblPago.Text = seleccion;
                    txtCambio.Show();
                    lblCambio.Show();
                    pbAtrasMP.Show();
                    break;
            }
        }

        public void SetDatosProducto(UCProducto.ProductoEventArgs e)
        {
            // Método público para establecer los datos de un producto seleccionado desde otro formulario.
            txtIdProducto.Text = e.IdProducto.ToString();
            txtProducto.Text = e.Nombre;
            txtPrecio.Text = e.Precio.ToString("C", new CultureInfo("es-DO"));
            txtStock.Text = e.Stock.ToString();
        }

        private void pbAtrasMP_Click(object sender, EventArgs e)
        {
            // Vuelve a mostrar el ComboBox de método de pago y oculta los campos de pago y cambio.
            cbMetodoPago.Show();
            lblPago.Text = "Metodo de Pago";
            txtCambio.Hide();
            lblCambio.Hide();
            pbAtrasMP.Hide();
        }

        private void txtPago_KeyDown_1(object sender, KeyEventArgs e)
        {
            // Llama a la función de calcular el cambio cuando se presiona la tecla 'Enter' en el campo de pago.
            if (e.KeyData == Keys.Enter)
            {
                CalcularCambio();
            }
        }

        private void pbBuscarIdProducto_Click_1(object sender, EventArgs e)
        {
            // Abre el formulario 'Catalogo_De_Los_Productos' como un diálogo modal.
            // Si el resultado es 'OK', actualiza los campos del formulario de facturación
            // con la información del producto seleccionado.
            using (var catalogo = new Catalogo_De_Los_Productos())
            {
                var result = catalogo.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var producto = catalogo.ProductoSeleccionado;

                    txtIdProducto.Text = producto.IdProducto.ToString();
                    txtProducto.Text = producto.Nombre;
                    txtPrecio.Text = producto.Precio.ToString("C", new CultureInfo("es-DO"));
                    txtStock.Text = producto.Stock.ToString();
                }
            }
        }
    }
}