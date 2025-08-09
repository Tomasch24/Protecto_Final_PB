using capa_negocios;
using Capa_Negocios;
using ConexionADatos;
using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocios
{
    //TODO clase encargada de los metodos que interactuan con la base de datos y la tabla factura
    public class FacturaDal
    {
        //TODO Metodo para ingresar los datos de la factura
        public static int IngresarDatos(Factura factura)
        {
            int retorna = 0;
            Productos_Agri data = new Productos_Agri();
            //TODO Se abre la conexion
            using (SqlConnection conn = new SqlConnection(data.Conexion))
            {
                //TODO se abre la base de datos
                conn.Open();

                // TODO comando sql para que se guarden los datos que inserte el usuario en la base de datos

                string query = "INSERT INTO Factura (IdCliente, Nombre, Telefono, RNC, Fecha, Producto, Precio, Cantidad, Tipo)" +
                                 "VALUES (@IdCliente, @Nombre, @Telefono, @RNC, @Fecha, @Producto, @Precio, @Cantidad, @Tipo)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@IdCliente", factura.Cliente?.IdCliente > 0 ? factura.Cliente.IdCliente : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Nombre", factura.Cliente.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", factura.Cliente.Telefono);
                cmd.Parameters.AddWithValue("@RNC", factura.Cliente.RNC);
                cmd.Parameters.AddWithValue("@Fecha", factura.Fecha);
                cmd.Parameters.AddWithValue("@Producto", factura.Producto);
                cmd.Parameters.AddWithValue("@Precio", factura.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", factura.Cantidad);
                cmd.Parameters.AddWithValue("@Tipo", factura.TipoFactura());

                retorna = cmd.ExecuteNonQuery();

                conn.Close();
            }
            return retorna;
        }

        //TODO metodo encargado de actualizar el stock en la tabla producto
        public static void ActualizarStock(Producto producto)
        {

            Productos_Agri data = new Productos_Agri();
            using (SqlConnection conn = new SqlConnection(data.Conexion))
            {
               
                string query = "UPDATE Producto SET Stock = @Stock WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn)) 
                {
                   
                    cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@Id", producto.Id);

                    conn.Open(); 
                    cmd.ExecuteNonQuery(); 
                }
            }
        }
        //TODO metodo encargado de buscar el producto para actualizar el stock en la tabla producto
        public static Producto BuscarPorId(int Id)
        {
            Productos_Agri data = new Productos_Agri();
            Producto P = null; // Initialize the product object to null.

            using (SqlConnection conn = new SqlConnection(data.Conexion))
            {
                conn.Open();
                string query = "SELECT Id, Stock From Producto Where Id = @Id"; // Only select the necessary columns.
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        P = new Producto();
                        P.Id = (int)reader["Id"]; // 1. Set the Id property.
                        P.Stock = (int)reader["Stock"]; // 2. Set the Stock property.
                    }
                }
            }
            return P; // 3. Return the product object (will be null if not found).
        }
    }
}
