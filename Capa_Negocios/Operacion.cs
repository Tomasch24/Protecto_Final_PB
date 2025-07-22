using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocios
{
    public class Operacion : BaseDatos
    {
        public override void PrepararOperacion()
        {
            try
            {
                // Lógica para preparar la operación  
                using (var connection = GetConnection())
                {
                    connection.Open();
                    Console.WriteLine("Conexión preparada correctamente.");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error al preparar la operación para la lógica.", ex);
            }
        }
    }
}
