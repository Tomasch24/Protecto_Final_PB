using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Capa_Negocios
{
   /* public class ProductoService
    {
        private readonly string conexion = @"Data Source=.;Initial Catalog=GreenPoint;Integrated Security=True";

        public List<Producto> ObtenerResumenProductos()
        {
            var lista = new List<Producto>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "SELECT Id, Nombre, Tipo, Precio FROM Producto";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Producto
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        Tipo = reader["Tipo"].ToString(),
                        Precio = Convert.ToInt32(reader["Precio"])
                    });
                }
            }

            return lista;
        }
    }*/
}
