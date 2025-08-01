using System;
using System.Data;
using PdfSharp.Drawing;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ConexionADatos;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;
using System.Reflection;

using PdfSharp.Pdf;
using PdfSharp.Drawing.Layout;
using PdfSharp.Fonts;

namespace Capa_Presentacion
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 246);
            ExcelPackage.License.SetNonCommercialOrganization("YourOrganizationName");
            //GlobalFontSettings.FontResolver = new CustomFontResolver();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            LoadDailySalesReport();
            CalculateCashBalance();
        }

        private string GetConnectionString()
        {
            ConexionADatos.Productos_Agri conexion = new ConexionADatos.Productos_Agri();
            return conexion.Conexion;
        }

        private void LoadDailySalesReport()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    string query = @"
                        SELECT
                            IdFactura,
                            Nombre AS Cliente,
                            Teléfono,
                            RNC,
                            Fecha,
                            Descripción,
                            Precio,
                            Cantidad,
                            (Precio * Cantidad) AS Subtotal,
                            Tipo
                        FROM Factura
                        WHERE Fecha = CAST(GETDATE() AS DATE)
                        ORDER BY IdFactura DESC;";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvReporte.DataSource = dt;
                    dgvReporte.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte de ventas diario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateCashBalance()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();

                    string queryTotalVentasDia = "SELECT ISNULL(SUM(Precio * Cantidad), 0) FROM Factura WHERE Fecha = CAST(GETDATE() AS DATE);";
                    SqlCommand cmdTotalVentasDia = new SqlCommand(queryTotalVentasDia, connection);
                    decimal totalVentasDia = Convert.ToDecimal(cmdTotalVentasDia.ExecuteScalar());
                    lblTotalVentasDia.Text = $"Total Ventas del Día: ${totalVentasDia:N2}";
                    lblTotalVentasDia.ForeColor = System.Drawing.Color.Black;

                    string queryTotalGastosDia = "SELECT ISNULL(SUM(TOTAL), 0) FROM PEDIDOS WHERE FECHA = CAST(GETDATE() AS DATE);";
                    SqlCommand cmdTotalGastosDia = new SqlCommand(queryTotalGastosDia, connection);
                    decimal totalGastosDia = Convert.ToDecimal(cmdTotalGastosDia.ExecuteScalar());
                    lblTotalGastosDia.Text = $"Total Gastos del Día: ${totalGastosDia:N2}";
                    lblTotalGastosDia.ForeColor = System.Drawing.Color.Black;

                    decimal cuadreCaja = totalVentasDia - totalGastosDia;
                    lblCuadreCaja.Text = $"Cuadre de Caja: ${cuadreCaja:N2}";
                    lblCuadreCaja.ForeColor = (cuadreCaja >= 0) ? System.Drawing.Color.Black : System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el cuadre de caja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvReporte.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar a Excel.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Archivos de Excel (*.xlsx)|*.xlsx",
                FileName = $"Reporte_Ventas_Diarias_{DateTime.Now:yyyyMMdd}.xlsx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Ventas del Día");

                        int currentRow = 1;
                        int lastColumn = dgvReporte.Columns.Count;

                        System.Drawing.Image logoImage = null;
                        try
                        {
                            logoImage = global::Capa_Presentacion.Properties.Resources.bbbb8c27_11ab_4ee8_a7cf_1a4eaf638c3a;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Advertencia: No se pudo cargar el logo para exportar a Excel. {ex.Message}", "Logo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        if (logoImage != null)
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                logoImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                                memoryStream.Position = 0;
                                ExcelPicture excelLogo = worksheet.Drawings.AddPicture("LogoSistema", memoryStream);
                                excelLogo.SetSize(100, 100);
                                excelLogo.From.Column = 0;
                                excelLogo.From.Row = 0;
                            }
                        }

                        string systemName = "REPORTE DE VENTAS DIARIAS - GREEN POINT";
                        worksheet.Cells[currentRow, 2, currentRow, dgvReporte.Columns.Count].Merge = true;
                        worksheet.Cells[currentRow, 2].Value = systemName;
                        worksheet.Cells[currentRow, 2].Style.Font.Size = 16;
                        worksheet.Cells[currentRow, 2].Style.Font.Bold = true;
                        worksheet.Cells[currentRow, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                        currentRow = 6;

                        for (int i = 0; i < dgvReporte.Columns.Count; i++)
                        {
                            worksheet.Cells[currentRow, i + 1].Value = dgvReporte.Columns[i].HeaderText;
                            worksheet.Cells[currentRow, i + 1].Style.Font.Bold = true;
                            worksheet.Cells[currentRow, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            worksheet.Cells[currentRow, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        }

                        for (int i = 0; i < dgvReporte.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvReporte.Columns.Count; j++)
                            {
                                object? cellValue = dgvReporte.Rows[i].Cells[j].Value;
                                worksheet.Cells[currentRow + i + 1, j + 1].Value = cellValue?.ToString() ?? string.Empty;
                            }
                        }

                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                        File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                    }
                    MessageBox.Show("Reporte exportado exitosamente a Excel.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
        }

        private void btnExportarPDF_Click_1(object sender, EventArgs e)
        {
            if (dgvReporte.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar a PDF.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Archivos PDF (*.pdf)|*.pdf",
                FileName = $"Reporte_Ventas_Diarias_{DateTime.Now:yyyyMMdd}.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 1. Crear un nuevo documento PDF
                    PdfDocument document = new PdfDocument();
                    PdfPage page = document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    // Fuentes
                    XFont titleFont = new XFont("Verdana", 16, XFontStyle.Bold);
                    XFont headerFont = new XFont("Verdana", 10, XFontStyle.Bold);
                    XFont dataFont = new XFont("Verdana", 10, XFontStyle.Regular);

                    // Colores y brochas
                    XSolidBrush headerBrush = new XSolidBrush(XColor.FromArgb(211, 211, 211));
                    XSolidBrush blackBrush = new XSolidBrush(XColors.Black);

                    double margin = 20;
                    double yPosition = margin;

                    // 2. Añadir el logo y el título

                    // Título del reporte
                    string titleText = "REPORTE DE VENTAS DIARIAS - GREEN POINT";
                    XSize titleSize = gfx.MeasureString(titleText, titleFont);
                    double titleX = (page.Width - titleSize.Width) / 2;
                    gfx.DrawString(titleText, titleFont, blackBrush, new XRect(titleX, yPosition, page.Width - 2 * margin, titleSize.Height), XStringFormats.Center);

                    // 3. Añadir la tabla con los datos del DataGridView
                    yPosition += 100 + margin; // Posición de inicio de la tabla
                    double headerHeight = 20;
                    double rowHeight = 15;
                    double xPosition = margin;

                    // Calcular anchos de columna
                    double[] columnWidths = new double[dgvReporte.Columns.Count];
                    double totalWidth = page.Width - 2 * margin;

                    for (int i = 0; i < dgvReporte.Columns.Count; i++)
                    {
                        columnWidths[i] = totalWidth / dgvReporte.Columns.Count;
                    }

                    // Dibujar encabezados
                    for (int i = 0; i < dgvReporte.Columns.Count; i++)
                    {
                        XRect rect = new XRect(xPosition, yPosition, columnWidths[i], headerHeight);
                        gfx.DrawRectangle(new XSolidBrush(XColor.FromArgb(211, 211, 211)), rect);
                        gfx.DrawString(dgvReporte.Columns[i].HeaderText, headerFont, blackBrush, rect, XStringFormats.Center);
                        xPosition += columnWidths[i];
                    }
                    yPosition += headerHeight;

                    // Dibujar filas de datos
                    for (int row = 0; row < dgvReporte.Rows.Count; row++)
                    {
                        xPosition = margin;
                        for (int col = 0; col < dgvReporte.Columns.Count; col++)
                        {
                            XRect rect = new XRect(xPosition, yPosition, columnWidths[col], rowHeight);
                            string cellValue = dgvReporte.Rows[row].Cells[col].Value?.ToString() ?? "";
                            gfx.DrawString(cellValue, dataFont, blackBrush, rect, XStringFormats.CenterLeft);
                            xPosition += columnWidths[col];
                        }
                        yPosition += rowHeight;
                    }

                    document.Save(sfd.FileName);

                    MessageBox.Show("Reporte exportado exitosamente a PDF.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

