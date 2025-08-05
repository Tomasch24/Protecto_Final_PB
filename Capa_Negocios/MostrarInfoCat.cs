using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Capa_Negocios
{
    public class MostrarInfoCat
    {
        private string connectionString = "Server=.;Database=GreenPoint;Integrated Security=true;TrustServerCertificate=True;";
        private SqlConnection connection;
        private SqlDataAdapter adapt;



        public List<ProductoVista> Mostrar_InfCatPro()
        {
            List<ProductoVista> productos = new List<ProductoVista>();

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Producto", connection);
                DataTable dataTable = new DataTable();
                adapt = new SqlDataAdapter(command);
                adapt.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    ProductoVista p = new ProductoVista
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Nombre = row["Nombre"].ToString(),
                        Precio = Convert.ToDecimal(row["Precio"]),
                        Stock = Convert.ToInt32(row["Stock"]),
                    };
                    productos.Add(p);
                }
            }

            return productos;
        }

    }

}