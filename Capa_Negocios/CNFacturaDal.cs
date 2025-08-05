using capa_negocios;
using ConexionADatos;
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

                string query = "INSERT INTO Factura (IdCliente, Nombre, Teléfono, RNC, Fecha, Producto, Precio, Cantidad, Tipo)" +
                                 "VALUES (@IdCliente, @Nombre, @Teléfono, @RNC, @Fecha, @Producto, @Precio, @Cantidad, @Tipo)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@IdCliente", factura.Cliente?.IdCliente > 0 ? factura.Cliente.IdCliente : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Nombre", factura.Cliente.Nombre);
                cmd.Parameters.AddWithValue("@Teléfono", factura.Cliente.Telefono);
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
    }
}
