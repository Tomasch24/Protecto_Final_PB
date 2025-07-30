using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocios
{
    //TODO Clase abstracta base CNPersona
    public abstract class CNPersona
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string RNC { get; set; }

        public CNPersona(string nombre, string telefono, string rnc)
        {
            Nombre = nombre;
            Telefono = telefono;
            RNC = rnc;
        }
    }
}
