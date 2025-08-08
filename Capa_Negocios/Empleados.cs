using System; // Importa el espacio de nombres principal de .NET, que contiene tipos fundamentales.
using System.Collections.Generic; // Proporciona colecciones de datos, como listas y diccionarios.
using System.Linq; // Habilita las consultas LINQ (Language Integrated Query) para trabajar con colecciones.
using System.Text; // Ofrece clases para manipulación de cadenas de texto.
using System.Threading.Tasks; // Permite el uso de programación asíncrona.

namespace Capa_Negocios // Define el espacio de nombres para la capa de negocios de tu aplicación.
{
    
    public class Empleado
    {
        // TODO Propiedades automáticas que representan los datos de un empleado.
        // TODO 'get' y 'set' permiten leer y escribir el valor de la propiedad.

       
        public string Nombre { get; set; }

        
        public string Rol { get; set; }


        public virtual string DescribirTrabajo()
        {
            // TODO Retorna una cadena interpolada que usa las propiedades 'Nombre' y 'Rol'.
            // TODO Esta es la implementación por defecto.
            return $"{Nombre} trabaja como {Rol}.";
        }
    }
}