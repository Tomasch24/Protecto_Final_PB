using System.Data;
using ConexionADatos;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Capa_Negocios
{
    public class CNProveedor
    {

        public void GuardarListaProveedores(List<PROVEEDOR> proveedores)
        {
            Productos_Agri datos = new Productos_Agri();

            using (SqlConnection conn = new SqlConnection(datos.Conexion))
            {
                conn.Open();
                foreach (var p in proveedores)
                {
                    if (!p.EsValido())
                    {
                        throw new ArgumentException($"El proveedor '{p.NOMBRE}' tiene datos no válidos.");
                    }
                    InsertarProveedorEnBD(p, conn);
                }
            }
        }


        //Lógica para obtener los datos desde la base
        public DataTable ObtenerTodosLosProveedores()
        {

            Productos_Agri datos = new Productos_Agri();
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(datos.Conexion))
            {
                string query = "SELECT RNC, NOMBRE, TELEFONO, TIPO, PRODUCTO, PRECIO FROM PROVEEDOR";
                using (SqlDataAdapter adapt = new SqlDataAdapter(query, conn))
                {
                    adapt.Fill(dt);
                }
            }
            return dt;
        }


        public string ObtenerNombrePorRNC(string rnc)
        {
            Productos_Agri datos = new Productos_Agri();
            string nombre = null;
            using (SqlConnection conexion = new SqlConnection(datos.Conexion))
            {
                string query = "SELECT Nombre FROM Proveedores WHERE RNC = @RNC";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@RNC", rnc);

                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    nombre = lector["Nombre"].ToString();
                }
            }
            return nombre;
        }



        private void InsertarProveedorEnBD(PROVEEDOR proveedor, SqlConnection conn)
        {
            // Opcional: Verificar si el RNC/ID ya existe antes de insertar
            string checkQuery = "SELECT COUNT(1) FROM PROVEEDOR WHERE RNC = @RNC";
            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
            {
                checkCmd.Parameters.AddWithValue("@RNC", proveedor.ObtenerIdentificadorPrincipal());
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    throw new InvalidOperationException($"El RNC/ID '{proveedor.ObtenerIdentificadorPrincipal()}' ya existe en la base de datos.");
                }
            }

            string query = "INSERT INTO PROVEEDOR (RNC, NOMBRE, TELEFONO, TIPO, PRODUCTO, PRECIO) VALUES (@RNC, @NOMBRE, @TELEFONO, @TIPO, @PRODUCTO, @PRECIO)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@RNC", proveedor.ObtenerIdentificadorPrincipal());
                cmd.Parameters.AddWithValue("@NOMBRE", proveedor.NOMBRE);
                cmd.Parameters.AddWithValue("@TELEFONO", proveedor.TELEFONO);
                cmd.Parameters.AddWithValue("@TIPO", proveedor.ObtenerTipo());
                cmd.Parameters.AddWithValue("@PRODUCTO", proveedor.PRODUCTO);
                cmd.Parameters.AddWithValue("@PRECIO", proveedor.PRECIO);
                cmd.ExecuteNonQuery();
            }



        }

        public void EliminarProveedor(string rnc)
        {
            Productos_Agri datos = new Productos_Agri();
            using (SqlConnection conn = new SqlConnection(datos.Conexion))
            {
                string query = "DELETE FROM PROVEEDOR WHERE RNC = @RNC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RNC", rnc);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public DataTable BuscarProveedores(string RNC)
        {
            Productos_Agri datos = new Productos_Agri();

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(datos.Conexion))
            {
                // Usamos LIKE para búsquedas parciales
                string query = "SELECT RNC, NOMBRE, TELEFONO, TIPO, PRODUCTO FROM PROVEEDOR WHERE RNC LIKE @RNC";
                using (SqlDataAdapter adapt = new SqlDataAdapter(query, conn))
                {
                    adapt.SelectCommand.Parameters.AddWithValue("@RNC", "%" + RNC + "%");
                    adapt.Fill(dt);
                }


            }

            return dt;
        }

        public bool EliminarProveedorPorRNC(string rnc)
        {
            Productos_Agri datos = new Productos_Agri();

            try
            {
                using (SqlConnection conn = new SqlConnection(datos.Conexion))
                {
                    string query = "DELETE FROM Proveedores WHERE RNC = @RNC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RNC", rnc);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch
            {
                return false;
            }
        }


        public bool ActualizarProveedor(string rncOriginal, PROVEEDOR proveedorNuevo)
        {
            Productos_Agri datos = new Productos_Agri();

            try
            {
                using (SqlConnection conn = new SqlConnection(datos.Conexion))
                {
                    string query = @"UPDATE Proveedores
                             SET RNC = @RNC, NOMBRE = @NOMBRE, TELEFONO = @TELEFONO, TIPO = @TIPO, PRODUCTO = @PRODUCTO, PRECIO = @PRECIO
                             WHERE RNC = @RNC_ORIGINAL";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RNC_ORIGINAL", rncOriginal);
                    cmd.Parameters.AddWithValue("@RNC", proveedorNuevo.RNC);
                    cmd.Parameters.AddWithValue("@NOMBRE", proveedorNuevo.NOMBRE);
                    cmd.Parameters.AddWithValue("@TELEFONO", proveedorNuevo.TELEFONO);
                    cmd.Parameters.AddWithValue("@TIPO", proveedorNuevo.TIPO);
                    cmd.Parameters.AddWithValue("@PRODUCTO", proveedorNuevo.PRODUCTO);
                    cmd.Parameters.AddWithValue("@PRECIO", proveedorNuevo.PRECIO);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch
            {
                return false;
            }
        }

    }

}