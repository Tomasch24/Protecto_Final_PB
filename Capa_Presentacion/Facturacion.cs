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
        private void LimpiarCamposProducto()
        {

            txtIdProducto.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
            txtStock.Text = "";

        }
        private void LimpiarCamposCliente()
        {
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            MtxtRnc.Text = "";
            MtxtTelefono.Text = "";
            txtIdCliente.Text = "";

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
        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvFactura.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(row.Cells[4].Value?.ToString(), out decimal subtotal) && decimal.TryParse(row.Cells[5].Value?.ToString(), out decimal descuento))
                {
                    total += (subtotal - descuento);
                }
            }

            txtTotal.Text = total.ToString("0.00");
        }

        private void btnGenerarFacturaPDF_Click(object sender, EventArgs e)
        {
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
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Cargar imagen del logo (ajusta la ruta a tu caso)
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Properties.Resources.LOGO_OSCURO.Save(ms, ImageFormat.Png);
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(ms.ToArray());
                        logo.ScaleAbsolute(100, 50);
                        logo.Alignment = Element.ALIGN_LEFT;
                        pdfDoc.Add(logo);
                    }

                    // Información de la empresa
                    Paragraph infoEmpresa = new Paragraph("GreenPoint\nRNC: 123456789\nDirección: Av. Barcelo, Bavaro, Punta Cana\nTeléfono: (809) 123-4567\n\n", FontFactory.GetFont("Arial", "12", Font.Bold));
                    infoEmpresa.Alignment = Element.ALIGN_LEFT;
                    pdfDoc.Add(infoEmpresa);

                    // Información del cliente
                    pdfDoc.Add(new Paragraph("FACTURA\n", FontFactory.GetFont("Arial", "16", Font.Bold)));
                    pdfDoc.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy}", FontFactory.GetFont("Arial", "12")));
                    pdfDoc.Add(new Paragraph($"Cliente: {txtNombre.Text}"));
                    pdfDoc.Add(new Paragraph($"Teléfono: {MtxtTelefono.Text}"));
                    pdfDoc.Add(new Paragraph($"RNC: {MtxtRnc.Text}"));
                    pdfDoc.Add(new Paragraph($"Tipo de Factura: {cbTipo.SelectedItem.ToString()}\n\n"));

                    // Tabla de productos
                    PdfPTable table = new PdfPTable(6); // ID, Nombre, Precio, Cantidad, Descuento, SubTotal
                    BaseColor colorFondo = new BaseColor(230, 230, 230); // Gris claro
                    FontFactory.GetFont("Arial", "12", Font.Bold);

                    string[] headers = { "ID Producto", "Producto", "Precio", "Cantidad", "Subtotal", "Descuento" };
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

                        table.AddCell(row.Cells[0].Value?.ToString() ?? "");
                        table.AddCell(row.Cells[1].Value?.ToString() ?? "");
                        table.AddCell(row.Cells[2].Value?.ToString() ?? "");
                        table.AddCell(row.Cells[3].Value?.ToString() ?? "");
                        table.AddCell(row.Cells[4].Value?.ToString() ?? "");
                        table.AddCell(row.Cells[5].Value?.ToString() ?? "");


                    }

                    pdfDoc.Add(table);

                    // Total
                    pdfDoc.Add(new Paragraph("\nTOTAL A PAGAR: " + txtTotal.Text, FontFactory.GetFont("Arial", "12", Font.Bold)));

                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("Factura generada con éxito.", "PDF Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimpiarCamposProducto();
            LimpiarCamposCliente();


        }

        private void dgvFactura_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
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

        private void pbBuscarIdProducto_Click(object sender, EventArgs e)
        {
            using(var catalogo = new Catalogo_De_Los_Productos())
            {
                var resulta = catalogo.ShowDialog();

                if (resulta == DialogResult.OK)
                {
                    
                }
            }
        }
    }

}
