using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class Administrador : Empleado
    {
        public override string DescribirTrabajo()
        {
            return $" {Nombre} es el administrador general y creador del sistema.";
        }
    }
}
