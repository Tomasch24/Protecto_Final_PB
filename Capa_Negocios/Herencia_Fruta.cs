using System; // Permite el uso de tipos de datos y funciones del sistema.
using System.Collections.Generic; // Habilita el uso de colecciones de datos, como listas.
using System.Linq; // Proporciona capacidades de consulta LINQ para trabajar con colecciones.
using System.Text; // Ofrece clases para manipular cadenas de texto.
using System.Threading.Tasks; // Facilita la programación asíncrona.

namespace Capa_Negocios // TODO Define el espacio de nombres para la capa de lógica de negocio.
{

    public class Fruta : Producto
    {
  
        public override string Tipo => "Fruta";

        // TODO Agregar propiedades específicas para una fruta
        // TODO Esto permitiría especializar aún más la clase.
    }
}