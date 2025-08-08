using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Negocios;

    namespace Capa_Negocios
    {
        //  TODO Herencia
        public class ProveedorInternacional : PROVEEDOR
        {
            // TODO Constructor: llama al constructor base con tipo "INTERNACIONAL"
            public ProveedorInternacional( string rnc, string nombre, string telefono, string producto, decimal precio)
                : base(rnc, nombre, telefono, producto,"INTERNACIONAL", precio)
            {
            }


            // TODO Implementación de métodos abstractos
            public override string ObtenerIdentificadorPrincipal() => RNC;

            // Validación personalizada: el pasaporte no puede ser nulo ni vacío
            public override bool EsValido() =>
                !string.IsNullOrWhiteSpace(RNC);

            public override string ObtenerTipo() => "INTERNACIONAL";
        }
    }
