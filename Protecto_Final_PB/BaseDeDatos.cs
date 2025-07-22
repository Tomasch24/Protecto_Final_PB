using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConexionADatos;
using Microsoft.Data.SqlClient;

namespace Capa_Datos
{
   
   
        public abstract class BaseDatos
        {
            protected string ConnectionString { get; private set; }

            // Constructor de la clase base
            public BaseDatos()
            {
                Productos_Agri cadena = new Productos_Agri();
                ConnectionString = cadena.Conexion;
                Console.WriteLine("BaseDatos: Constructor ejecutado. Conexión lista."); // Para demostración
            }

            // Método Protegido Virtual: Puede ser sobrescrito por clases derivadas
            // Usaremos esto para una posible lógica de loggeo o validación de conexión pre-operación
            protected virtual SqlConnection GetConnection()
            {
                Console.WriteLine("BaseDatos: Obteniendo conexión a la base de datos."); // Para demostración
                return new SqlConnection(ConnectionString);
            }

            // Método Abstracto: Debe ser implementado por cualquier clase no abstracta que herede de BaseDatos
            // Esto obliga a las clases derivadas a definir cómo se "prepara" una operación
            public abstract void PrepararOperacion();

            protected int ExecuteNonQuery(SqlCommand command)
            {
                using (SqlConnection connection = GetConnection())
                {
                    command.Connection = connection;
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }

            protected SqlDataReader ExecuteReader(SqlCommand command)
            {
                SqlConnection connection = GetConnection();
                command.Connection = connection;
                connection.Open();
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }
    
}
