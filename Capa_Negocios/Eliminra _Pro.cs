using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionADatos;
using Microsoft.Data.SqlClient;



namespace Capa_Negocios
{
    // TODO LOGICA PARA ELIMINAR PRODUCTO 
    public class EliminarProducto
    {
        public static bool Eliminar(int Id)
        {
            try
            {
                Productos_Agri conexion = new Productos_Agri();
                using (SqlConnection conn = new SqlConnection(conexion.Conexion))
                {
                    conn.Open();
                    string query = "DELETE FROM Producto WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }

}
