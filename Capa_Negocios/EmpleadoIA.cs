using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class EmpleadoIA : Empleado
    {
        public override string DescribirTrabajo()
        {
            return $" {Nombre} es una IA con el rol de {Rol}, procesa pagos de forma automatizada.";
        }
    }
}
