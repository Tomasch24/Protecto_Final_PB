using System; // Permite el uso de tipos y funciones básicas del sistema.
using System.Collections.Generic; // Habilita el uso de colecciones genéricas como listas y diccionarios.
using System.Linq; // Proporciona capacidades de consulta LINQ para trabajar con colecciones.
using System.Text; // Ofrece clases para manipular cadenas de texto y codificaciones.
using System.Threading.Tasks; // Facilita el desarrollo de programación asíncrona.

namespace Capa_Negocios // TODO Define el espacio de nombres para la capa de lógica de negocio.
{
  
    public class EmpleadoIA : Empleado
    {
        public override string DescribirTrabajo()
        {
            // TODO Utiliza una cadena interpolada para construir una descripción dinámica.
            // TODO Las propiedades 'Nombre' y 'Rol' se heredan de la clase base 'Empleado'.
            return $" {Nombre} es una IA con el rol de {Rol}, procesa pagos de forma automatizada.";
        }
    }
}