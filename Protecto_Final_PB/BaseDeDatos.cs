using System; //  TODO Permite el uso de tipos básicos y funciones del sistema
using System.Collections.Generic; //TODO Permite el uso de colecciones genéricas como List<T>
using System.Linq; // TODO Permite usar consultas LINQ para trabajar con colecciones
using System.Text; // TODO Proporciona clases para manejar codificaciones de caracteres
using System.Threading.Tasks; //TODO  Permite el uso de programación asíncrona

// TODO  Para interactuar con bases de datos
using System.Data; //TODO  Proporciona clases para la arquitectura ADO.NET (Acceso a Datos)
using ConexionADatos; // TODO Importa el namespace donde presumiblemente se encuentra la clase 'Productos_Agri'
using Microsoft.Data.SqlClient; // TODO Proporciona la clase para conectarse a SQL Server

// TODO Define el namespace para la capa de datos de la aplicación
namespace Capa_Datos
{
    /// <summary>
    /// Clase abstracta base para la gestión de la conexión y operaciones genéricas con la base de datos.
    /// Esta clase no puede ser instanciada directamente, solo puede ser heredada.
    /// Su propósito es centralizar la lógica de conexión y métodos comunes para todas las
    /// clases de datos (Data Access Objects o DAOs).
    /// </summary>
    public abstract class BaseDatos
    {
        // TODO Propiedad protegida que almacena la cadena de conexión a la base de datos.
        //  TODO 'protected' significa que solo es accesible por la clase actual y las clases que heredan de ella.
        // TODO 'private set' asegura que la cadena solo se puede establecer desde el constructor de esta clase.
        protected string ConnectionString { get; private set; }

        /// <summary>
        /// Constructor de la clase BaseDatos.
        /// Se encarga de inicializar la cadena de conexión.
        /// </summary>
        public BaseDatos()
        {
            // TODO Crea una instancia de la clase 'Productos_Agri' (presumiblemente en el namespace ConexionADatos).
            Productos_Agri cadena = new Productos_Agri();
            //TODO Asigna la cadena de conexión desde la propiedad 'Conexion' de la instancia creada.
            ConnectionString = cadena.Conexion;
            //TODO Mensaje de consola para fines de depuración o demostración.
            Console.WriteLine("BaseDatos: Constructor ejecutado. Conexión lista.");
        }

        /// <summary>
        /// Método protegido virtual para obtener una nueva instancia de SqlConnection.
        /// 'virtual' permite que las clases derivadas (hijas) puedan sobrescribir este método
        /// para añadir o modificar su comportamiento (por ejemplo, para registrar eventos de conexión).
        /// </summary>
        /// <returns>Una nueva instancia de SqlConnection configurada con la cadena de conexión.</returns>
        protected virtual SqlConnection GetConnection()
        {
            // TODOMensaje de consola para depuración.
            Console.WriteLine("BaseDatos: Obteniendo conexión a la base de datos.");
            //TODO Retorna una nueva conexión de SQL Server.
            return new SqlConnection(ConnectionString);
        }

        /// <summary>
        /// Método abstracto que debe ser implementado por cualquier clase que herede de BaseDatos.
        /// Obliga a las clases hijas a definir su propia lógica para "preparar" una operación,
        /// como podría ser configurar parámetros o validaciones específicas.
        /// </summary>
        public abstract void PrepararOperacion();

        /// <summary>
        /// Ejecuta una consulta SQL que no retorna resultados (por ejemplo, INSERT, UPDATE, DELETE).
        /// Este método gestiona automáticamente la conexión (apertura y cierre).
        /// </summary>
        /// <param name="command">El SqlCommand a ejecutar.</param>
        /// <returns>El número de filas afectadas por la operación.</returns>
        protected int ExecuteNonQuery(SqlCommand command)
        {
            // TODO 'using' asegura que la conexión se cerrará y se liberarán los recursos automáticamente,
            // TODO incluso si ocurre un error.
            using (SqlConnection connection = GetConnection())
            {
                // TODO Asigna la conexión al comando SQL.
                command.Connection = connection;
                //TODO  Abre la conexión con la base de datos.
                connection.Open();
                // TODO Ejecuta el comando y retorna el número de filas afectadas.
                return command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Ejecuta una consulta SQL que retorna un conjunto de resultados (por ejemplo, SELECT).
        /// </summary>
        /// <param name="command">El SqlCommand a ejecutar.</param>
        /// <returns>Un SqlDataReader para leer los datos del resultado.</returns>
        protected SqlDataReader ExecuteReader(SqlCommand command)
        {
            //  TODO Obtiene una nueva conexión.
            SqlConnection connection = GetConnection();
            // TODO Asigna la conexión al comando SQL.
            command.Connection = connection;
            // TODO Abre la conexión.
            connection.Open();
            // TODO Ejecuta el comando y retorna el lector de datos.
            // TODO CommandBehavior.CloseConnection asegura que la conexión se cerrará
            // TODO automáticamente cuando el SqlDataReader sea cerrado. Esto es crucial.
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}