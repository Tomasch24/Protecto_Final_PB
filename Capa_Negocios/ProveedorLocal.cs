using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Negocios;

   namespace Capa_Negocios
   {
        //  TODO Herencia
        public class ProveedorLocal : PROVEEDOR
        {
            //  TODO Constructor: llama al constructor base con "LOCAL" como tipo fijo
            public ProveedorLocal(string rnc, string nombre, string telefono, string producto, decimal precio)
                : base(rnc, nombre, telefono, producto, "LOCAL", precio)
            {
            }

            // TODO Implementación de métodos abstractos
            public override string ObtenerIdentificadorPrincipal() => RNC;

            // TODO Validación el RNC debe tener exactamente 9 dígitos
            public override bool EsValido() =>
                !string.IsNullOrWhiteSpace(RNC) && RNC.Length == 9;

            public override string ObtenerTipo() => "LOCAL";
        }
   }
