using System; // Importa el espacio de nombres principal de .NET, que contiene tipos fundamentales.
using System.Collections.Generic; // Proporciona colecciones de datos, como listas y diccionarios.
using System.Linq; // Habilita las consultas LINQ (Language Integrated Query) para trabajar con colecciones.
using System.Text; // Ofrece clases para manipulación de cadenas de texto.
using System.Threading.Tasks; // Permite el uso de programación asíncrona.

namespace Capa_Negocios // TODO Define el espacio de nombres para la capa de negocios de tu aplicación.
{
    /// <summary>
    /// Clase que representa a un Administrador.
    /// Hereda de la clase base 'Empleado', lo que significa que un Administrador es un tipo de Empleado
    /// y hereda todas sus propiedades y métodos.
    /// </summary>
    public class Administrador : Empleado
    {
        // TODO No hay propiedades adicionales específicas para un Administrador en este momento.
        // TODO Considerar si un Administrador necesita propiedades únicas como 'NivelDeAcceso' o 'Departamento'.

        /// <summary>
        /// Sobrescribe el método 'DescribirTrabajo' de la clase base 'Empleado'.
        /// La palabra clave 'override' indica que se está proporcionando una nueva implementación
        /// para un método virtual o abstracto definido en la clase padre.
        /// </summary>
        /// <returns>Una cadena de texto que describe la función del Administrador.</returns>
        public override string DescribirTrabajo()
        {
            // TODO Retorna una cadena interpolada que combina el nombre del administrador
            // TODO con su rol específico en el sistema.
            // TODO La variable 'Nombre' es heredada de la clase 'Empleado'.
            return $" {Nombre} es el administrador general y creador del sistema.";
        }
    }
}