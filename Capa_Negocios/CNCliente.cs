using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocios
{
    //TODO Clase cliente heredando de clase abstracta base CNPersona
    public class CNCliente : CNPersona
    {
        public int IdCliente { get; set; }
        public decimal Descuento { get; set; } = 5;

        public string Correo { get; set; }

        //TODO Constructor CNCliente
        public CNCliente(string nombre, string telefono, string rnc, string correo)
            : base(nombre, telefono, rnc)
        {
            Descuento = 5;
        }
    }
}
