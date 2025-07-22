using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Rol { get; set; }

        public virtual string DescribirTrabajo()
        {
            return $"{Nombre} trabaja como {Rol}.";
        }
    }
}
