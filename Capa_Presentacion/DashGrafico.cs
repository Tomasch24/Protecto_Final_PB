using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Necesario para los controles Chart
using Microsoft.Data.SqlClient; // Usamos Microsoft.Data.SqlClient para la conexión a SQL Server
using ConexionADatos; // Importamos el namespace donde está tu clase Productos_Agri
using System.Collections.Generic;

namespace Capa_Presentacion
{
    public partial class DashGrafico : Form
    {
        public DashGrafico()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(245, 247, 246);
            ConfigureChartsInitial(); // TODO Configuración inicial de los gráficos
        }

        private void DashGrafico_Load(object sender, EventArgs e)
        {
            // TODO Llamamos a los métodos para cargar los datos en los gráficos y resúmenes
            LoadVentasChart();
            LoadTopProductsChart();
            LoadProductStockChart();
            LoadSummaryData();
        }

        /// <summary>
        /// Obtiene la cadena de conexión a la base de datos desde la clase Productos_Agri.
        /// </summary>
        private string GetConnectionString()
        {
            // TODO El namespace correcto de la clase de conexión es 'ConexionADatos'.
            ConexionADatos.Productos_Agri conexion = new ConexionADatos.Productos_Agri();
            return conexion.Conexion;
        }

        /// <summary>
        /// Configura las propiedades iniciales de los controles Chart y sus colores.
        /// Se ha mejorado la apariencia 3D de los gráficos.
        /// </summary>
        private void ConfigureChartsInitial()
        {
            // TODO Configuración general de los gráficos
            chartVentas.BackColor = Color.FromArgb(245, 247, 246);
            chartTopProductos.BackColor = Color.FromArgb(245, 247, 246);
            chartStockProductos.BackColor = Color.FromArgb(245, 247, 246);

            // TODO Configuración para el gráfico de Ventas (chartVentas)
            chartVentas.Series.Clear();
            chartVentas.Titles.Clear();
            chartVentas.Titles.Add("Ventas Diarias");
            chartVentas.ChartAreas[0].AxisX.Title = "Fecha";
            chartVentas.ChartAreas[0].AxisY.Title = "Monto de Venta";
            chartVentas.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
            chartVentas.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            chartVentas.ChartAreas[0].AxisX.Interval = 1;
            //TODO  Configuración 3D para el gráfico de ventas
            chartVentas.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartVentas.ChartAreas[0].Area3DStyle.Inclination = 15;
            chartVentas.ChartAreas[0].Area3DStyle.Rotation = 10;
            chartVentas.ChartAreas[0].Area3DStyle.LightStyle = LightStyle.Realistic;

            // TODO Configuración para el gráfico de los 5 Productos Más Vendidos (chartTopProductos)
            chartTopProductos.Series.Clear();
            chartTopProductos.Titles.Clear();
            chartTopProductos.Titles.Add("Los 5 Productos Más Vendidos");
            chartTopProductos.ChartAreas[0].AxisX.Title = "Producto";
            chartTopProductos.ChartAreas[0].AxisY.Title = "Cantidad Vendida";
            //TODO  Desactivar el efecto 3D para el gráfico de pastel
            chartTopProductos.ChartAreas[0].Area3DStyle.Enable3D = false;


            //TODO  Configuración para el gráfico de Cantidad de Cada Producto Existente (chartStockProductos)
            chartStockProductos.Series.Clear();
            chartStockProductos.Titles.Clear();
            chartStockProductos.Titles.Add("Cantidad de Cada Producto Existente");
            chartStockProductos.ChartAreas[0].AxisX.Title = "Producto";
            chartStockProductos.ChartAreas[0].AxisY.Title = "Stock Actual";
            // TODO Desactivar el efecto 3D para el gráfico de stock
            chartStockProductos.ChartAreas[0].Area3DStyle.Enable3D = Enabled;
        }

        /// <summary>
        /// Carga los datos de ventas diarias desde la tabla 'Factura' y los muestra en 'chartVentas'.
        /// </summary>
        private void LoadVentasChart()
        {
            try
            {
                // TODO Establece una nueva conexión SQL usando la cadena de conexión centralizada
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open(); // TODO Abre la conexión a la base de datos

                    // TODO Consulta SQL para obtener la suma de ventas por fecha
                    string query = @"
                        SELECT
                            Fecha,
                            SUM(Precio * Cantidad) AS TotalVentaDiaria
                        FROM Factura
                        GROUP BY Fecha
                        ORDER BY Fecha ASC;"; // TODO Agrupa por fecha y ordena ascendente

                    SqlCommand command = new SqlCommand(query, connection); //TODO  Crea un comando SQL
                    SqlDataReader reader = command.ExecuteReader(); //TODO  Ejecuta la consulta y obtiene un lector de datos

                    chartVentas.Series.Clear(); //TODO  Limpia las series existentes del gráfico de ventas
                    Series series = new Series("Ventas") // TODO Crea una nueva serie de datos llamada "Ventas"
                    {
                        ChartType = SeriesChartType.Column, // TODO Se cambió a Column para mejor efecto 3D
                        BorderWidth = 3, //TODO  Ancho de la línea
                        Color = Color.FromArgb(100, 160, 220) //TODO  Color de las barras para el gráfico de ventas
                    };
                    chartVentas.Series.Add(series); // TODO Añade la serie al gráfico

                    // TODO Lee los datos del lector y los añade a la serie del gráfico
                    while (reader.Read())
                    {
                        DateTime fecha = reader.GetDateTime(0); // TODO Obtiene la fecha
                        decimal totalVenta = reader.GetDecimal(1); //TODO  Obtiene el total de venta
                        series.Points.AddXY(fecha.ToOADate(), totalVenta); // TODO Añade el punto (fecha, totalVenta) al gráfico
                    }
                    reader.Close(); // TODO Cierra el lector de datos
                }
            }
            catch (Exception ex)
            {
                // TODO Muestra un mensaje de error si ocurre una excepción
                MessageBox.Show("Error al cargar el gráfico de ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga los 5 productos con mayor cantidad vendida desde las tablas 'PEDIDOS' y 'Producto',
        /// y los muestra en 'chartTopProductos' como un gráfico circular.
        /// </summary>
        private void LoadTopProductsChart()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();

                    //TODO  Consulta SQL para obtener los 5 productos más vendidos, uniendo PEDIDOS con Producto
                    string query = @"
                        SELECT TOP 5
                            P.Nombre AS NombreProducto,
                            SUM(PE.CANTIDAD) AS CantidadTotalVendida
                        FROM PEDIDOS PE
                        INNER JOIN Producto P ON PE.IDPRODUCTO = P.Id
                        GROUP BY P.Nombre
                        ORDER BY CantidadTotalVendida DESC;";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    chartTopProductos.Series.Clear();
                    Series series = new Series("Productos")
                    {
                        ChartType = SeriesChartType.Pie, // TODO Tipo de gráfico: circular (pastel)
                        IsValueShownAsLabel = true, // TODO Muestra el valor de cada rebanada como etiqueta
                        //TODO  Formato de la etiqueta: solo el valor. Eliminamos el porcentaje para ahorrar espacio.
                        LabelFormat = "{0}", // Solo el valor
                        // TODO Establece la fuente para las etiquetas de los puntos de datos
                        Font = new Font("Arial", 8, FontStyle.Bold)
                    };
                    chartTopProductos.Series.Add(series);

                    //TODO  Paleta de colores de Green Point
                    Color[] newPalette = new Color[]
                    {
                        Color.FromArgb(100, 160, 220),  // Azul
                        Color.FromArgb(255, 175, 50),   // Naranja
                        Color.FromArgb(220, 70, 70), // Rojo
                        Color.FromArgb(180, 180, 180), // Gris
                        Color.FromArgb(50, 80, 120), // Azul oscuro
                        Color.FromArgb(250, 230, 150) // Amarillo claro
                    };
                    int colorIndex = 0;

                    while (reader.Read())
                    {
                        string nombreProducto = reader.GetString(0);
                        int cantidadVendida = reader.GetInt32(1);
                        DataPoint point = new DataPoint(series);
                        point.SetValueXY(nombreProducto, cantidadVendida);
                        point.Color = newPalette[colorIndex % newPalette.Length];
                        // TODO Sin animación, las porciones se añaden unidas por defecto
                        series.Points.Add(point);
                        colorIndex++;
                    }
                    reader.Close();

                    //TODO  Si no hay datos, muestra un mensaje en el título del gráfico
                    if (series.Points.Count == 0)
                    {
                        chartTopProductos.Titles.Clear();
                        chartTopProductos.Titles.Add("No hay datos de productos vendidos disponibles.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico de productos más vendidos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga la cantidad de stock de cada producto y los muestra en 'chartStockProductos'.
        /// </summary>
        private void LoadProductStockChart()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    string query = @"
                        SELECT
                            Nombre,
                            Stock
                        FROM Producto
                        WHERE Stock > 0
                        ORDER BY Nombre ASC;";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    chartStockProductos.Series.Clear();

                    Color[] barPalette = new Color[]
                    {
                        Color.FromArgb(100, 160, 220),  // Azul
                        Color.FromArgb(255, 175, 50),   // Naranja
                        Color.FromArgb(220, 70, 70), // Rojo
                        Color.FromArgb(180, 180, 180), // Gris
                        Color.FromArgb(50, 80, 120), // Azul oscuro
                        Color.FromArgb(250, 230, 150) // Amarillo claro
                    };
                    int colorIndex = 0;

                    while (reader.Read())
                    {
                        string nombreProducto = reader.GetString(0);
                        int stock;
                        string stockValueFromDb = reader.GetValue(1).ToString();
                        if (int.TryParse(stockValueFromDb, out stock))
                        {
                            // Valor válido
                        }
                        else
                        {
                            stock = 0;
                        }

                        // TODO Creamos una serie para cada producto para tener barras separadas
                        Series productSeries = new Series(nombreProducto)
                        {
                            ChartType = SeriesChartType.Column, // Se cambió a Column para barras verticales
                            IsValueShownAsLabel = true,
                            LabelFormat = "{0}",
                            Font = new Font("Arial", 8, FontStyle.Bold),
                            Color = barPalette[colorIndex % barPalette.Length]
                        };

                        productSeries.Points.AddXY(nombreProducto, stock);
                        chartStockProductos.Series.Add(productSeries);
                        productSeries.SmartLabelStyle.Enabled = true;
                        productSeries.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;

                        colorIndex++;
                    }
                    reader.Close();

                    if (chartStockProductos.Series.Count == 0)
                    {
                        chartStockProductos.Titles.Clear();
                        chartStockProductos.Titles.Add("No hay datos de stock de productos disponibles.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico de stock de productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga los datos de resumen (Total de Ventas, Número de Proveedores, Dinero en Caja, etc.).
        /// </summary>
        private void LoadSummaryData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();

                    // Total de Ventas
                    string queryTotalVentas = "SELECT ISNULL(SUM(Precio * Cantidad), 0) FROM Factura;";
                    SqlCommand cmdTotalVentas = new SqlCommand(queryTotalVentas, connection);
                    decimal totalVentas = Convert.ToDecimal(cmdTotalVentas.ExecuteScalar());
                    lblTotalVentas.Text = $"${totalVentas:N2}";
                    lblTotalVentas.ForeColor = Color.FromArgb(41, 76, 37);

                    // Número de Proveedores
                    string queryNumProveedores = "SELECT COUNT(DISTINCT IDPROVEEDOR) FROM PROVEEDOR;";
                    SqlCommand cmdNumProveedores = new SqlCommand(queryNumProveedores, connection);
                    int numProveedores = Convert.ToInt32(cmdNumProveedores.ExecuteScalar());
                    lblNumProveedores.Text = $"{numProveedores}";
                    lblNumProveedores.ForeColor = Color.FromArgb(41, 76, 37);

                    // Dinero en Caja
                    string queryTotalGastos = "SELECT ISNULL(SUM(TOTAL), 0) FROM PEDIDOS;";
                    SqlCommand cmdTotalGastos = new SqlCommand(queryTotalGastos, connection);
                    decimal totalGastos = Convert.ToDecimal(cmdTotalGastos.ExecuteScalar());
                    decimal dineroEnCaja = totalVentas - totalGastos;
                    lblCaja.Text = $"${dineroEnCaja:N2}";
                    lblCaja.ForeColor = Color.FromArgb(41, 76, 37);

                    // N Productos (Número total de productos)
                    string queryNumProductos = "SELECT COUNT(Id) FROM Producto;";
                    SqlCommand cmdNumProductos = new SqlCommand(queryNumProductos, connection);
                    int numProductos = Convert.ToInt32(cmdNumProductos.ExecuteScalar());
                    lblNumProductos.Text = $"{numProductos}";
                    lblNumProductos.ForeColor = Color.FromArgb(41, 76, 37);

                    // Stock (Stock total de todos los productos)
                    string queryTotalStock = "SELECT ISNULL(SUM(Stock), 0) FROM Producto;";
                    SqlCommand cmdTotalStock = new SqlCommand(queryTotalStock, connection);
                    int totalStock = Convert.ToInt32(cmdTotalStock.ExecuteScalar());
                    lblStock.Text = $"{totalStock}";
                    lblStock.ForeColor = Color.FromArgb(41, 76, 37);

                    // Usuarios (Número total de usuarios)
                    string queryNumUsuarios = "SELECT COUNT(IdUsuario) FROM Usuarios;";
                    SqlCommand cmdNumUsuarios = new SqlCommand(queryNumUsuarios, connection);
                    int numUsuarios = Convert.ToInt32(cmdNumUsuarios.ExecuteScalar());
                    lblUsuarios.Text = $"{numUsuarios}";
                    lblUsuarios.ForeColor = Color.FromArgb(41, 76, 37);

                    // Facturas (Número total de facturas)
                    string queryNumFacturas = "SELECT COUNT(IdFactura) FROM Factura;";
                    SqlCommand cmdNumFacturas = new SqlCommand(queryNumFacturas, connection);
                    int numFacturas = Convert.ToInt32(cmdNumFacturas.ExecuteScalar());
                    lblFacturas.Text = $"{numFacturas}";
                    lblFacturas.ForeColor = Color.FromArgb(41, 76, 37);

                    // Fecha actual
                    lblFecha.Text = $"{DateTime.Now:d}";
                    lblFecha.ForeColor = Color.FromArgb(41, 76, 37);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de resumen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}