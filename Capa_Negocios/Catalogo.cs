using capa_negocios;
using Capa_negocios;
using ConexionADatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class ProductoVista
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public string ImagenPath { get; set; }



        /*public static List<ProductoVista> Mostrar_InfCatPro()
        {
            Productos_Agri data = new Productos_Agri();

            List<ProductoVista> productos = new();

            using (SqlConnection conn = new SqlConnection(data.Conexion))
            {
             

                string query = "SELECT * FROM Producto";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProductoVista p = new ProductoVista();

                    p.IdProducto = Convert.ToInt32(reader["Id"]);
                    p.Nombre = reader["Nombre"].ToString();
                    p.Precio = Convert.ToDecimal(reader["Precio"]);
                    p.Stock = Convert.ToInt32(reader["Stock"]);

                    productos.Add(p);
                }
                conn.Close();
              
            }
            return productos;
            
       }*/
    }
}

   


