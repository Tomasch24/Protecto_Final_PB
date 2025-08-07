using Capa_Datos;
using ClosedXML.Excel;
using ConexionADatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Capa_Negocios
{
    public class PedidosNegocio
    {
        //TODO Crear una instancia para acceder a la cadena en capa datos
        public Productos_Agri conexionDatos = new Productos_Agri();

        //TODO FORM PEDIDOS metodo para obtener los productos existentes y sus cantidades 
        public DataTable ObtenerProductosExistentes()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = new SqlConnection(conexionDatos.Conexion))
            {
                string query = "SELECT Nombre, Stock FROM Producto WHERE Stock > 0";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        //TODO FORM PEDIDOS metodo para obtener los productos agotados y sus cantidades
        public DataTable ObtenerProductosAgotados()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = new SqlConnection(conexionDatos.Conexion))
            {
                string query = "SELECT Nombre, Stock FROM Producto WHERE Stock = 0";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(tabla);
            }


            return tabla;
        }


        //TODO FORM HACER PEDIDO metodo para obtener los datos completos del producto seleccionado
        public DataRow ObtenerDatosProductoCompleto(string nombreProducto)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = new SqlConnection(conexionDatos.Conexion))
            {
                string query = @"
            SELECT 
                p.Id AS IDPRODUCTO,
                p.Nombre,
                p.Tipo,
                pr.IDPROVEEDOR,
                pr.Nombre AS NombreProveedor,
                pr.RNC,
                pr.Telefono,
                pr.Precio AS PrecioBase
            FROM Producto p
            JOIN Proveedor pr ON p.IDPROVEEDOR = pr.IDPROVEEDOR
            WHERE p.Nombre = @nombre";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombreProducto);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            if (tabla.Rows.Count > 0)
                return tabla.Rows[0];
            else
                return null;
        }


        //TODO FORM HACER PEDIDO metodo para guardar el pedido en registro y actualizar el stock del producto
        public bool RegistrarPedido(int idProducto, string idProveedor, decimal precioBase, int cantidad, decimal total)
        {
            using (SqlConnection conn = new SqlConnection(conexionDatos.Conexion))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    //TODO  Insertar el pedido en la tabla PEDIDOS
                    string insertQuery = @"
                INSERT INTO PEDIDOS (IDPRODUCTO, IDPROVEEDOR, FECHA, PRECIOBASE, CANTIDAD, TOTAL)
                VALUES (@idProducto, @idProveedor, GETDATE(), @precioBase, @cantidad, @total)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn, trans);
                    insertCmd.Parameters.AddWithValue("@idProducto", idProducto);
                    insertCmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                    insertCmd.Parameters.AddWithValue("@precioBase", precioBase);
                    insertCmd.Parameters.AddWithValue("@cantidad", cantidad);
                    insertCmd.Parameters.AddWithValue("@total", total);
                    insertCmd.ExecuteNonQuery();

                    //TODO  Actualizar el stock del producto
                    string updateQuery = "UPDATE Producto SET Stock = Stock + @cantidad WHERE Id = @idProducto";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn, trans);
                    updateCmd.Parameters.AddWithValue("@cantidad", cantidad);
                    updateCmd.Parameters.AddWithValue("@idProducto", idProducto);
                    updateCmd.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch
                {
                    trans.Rollback();
                    return false;
                }
            }
        }


        //TODO FORM Registro Pedidos metodo para obtener todos los pedidos registrados
        public DataTable ObtenerPedidos()
        {
            DataTable tabla = new DataTable();
            string query = @"
        SELECT 
            p.IDPEDIDO,
            pr.Nombre AS NombreProducto,
            p.IDPRODUCTO,
            p.IDPROVEEDOR,
            p.FECHA,
            p.PRECIOBASE,
            p.CANTIDAD,
            p.TOTAL
        FROM PEDIDOS p
        INNER JOIN Producto pr ON p.IDPRODUCTO = pr.Id
        ORDER BY p.FECHA DESC";

            using (SqlConnection conn = new SqlConnection(conexionDatos.Conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(tabla);
            }

            return tabla;
        }
    

    //TODO FORM REGISTRO metodo para exportar los pedidos a Excel
     public void ExportarPedidosAExcel(DataTable tabla, string rutaArchivo)
        {
            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("Pedidos");

               
                ws.Cell("A1").Value = "GreenPoint - Reporte de Pedidos";
                ws.Cell("A2").Value = $"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}";
                ws.Range("A1:G1").Merge().Style.Font.SetBold().Font.FontSize = 16;
                ws.Range("A2:G2").Merge().Style.Font.SetItalic().Font.FontSize = 12;
                ws.Range("A1:G2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                
                for (int i = 0; i < tabla.Columns.Count; i++)
                {
                    ws.Cell(4, i + 1).Value = tabla.Columns[i].ColumnName;
                    ws.Cell(4, i + 1).Style.Font.Bold = true;
                    ws.Cell(4, i + 1).Style.Fill.BackgroundColor = XLColor.LightGreen;
                }

                //TODO ingresar Datos
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    for (int j = 0; j < tabla.Columns.Count; j++)
                    {
                        ws.Cell(i + 5, j + 1).Value = tabla.Rows[i][j]?.ToString();
                    }
                }

                ws.Columns().AdjustToContents();

                wb.SaveAs(rutaArchivo);

                //TODO Abrir el archivo automáticamente
                Process.Start(new ProcessStartInfo(rutaArchivo) { UseShellExecute = true });
            }
     }



    }
}