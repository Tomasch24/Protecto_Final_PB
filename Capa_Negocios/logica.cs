using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos; 
using ConexionADatos;
using Microsoft.Data.SqlClient;


namespace Capa_Negocios
{
    //TODO Aqui esta el metodo para Guardar los pedidos, Estableciendo conexion con la Base de datos 
    public class Logicaproducto 
    {

       
        public static int GuardarPedido(Producto producto)
        {
            int retorno = 0;
            Productos_Agri conexion = new Productos_Agri();
            using (SqlConnection conn = new SqlConnection(conexion.Conexion))
            {
                conn.Open();
                string query = "INSERT INTO Producto (Nombre, Temporada, Tipo, Precio, Cantidad, Total, CostoDeEnvio) " +
                               "VALUES (@nombre, @Temporada, @Tipo, @Precio, @Cantidad, @Total, @CostoDeEnvio)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Temporada", producto.Temporada);
                cmd.Parameters.AddWithValue("@Tipo", producto.Tipo);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                cmd.Parameters.AddWithValue("@Total", producto.Total);
                cmd.Parameters.AddWithValue("@CostoDeEnvio", producto.CostoDeEnvio);

                retorno = cmd.ExecuteNonQuery();


            }

            return retorno;
        }



    }
}
