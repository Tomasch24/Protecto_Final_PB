using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Negocios;

   namespace Capa_Negocios
   {
        //  Herencia
        public class ProveedorLocal : PROVEEDOR
        {
            //  Constructor: llama al constructor base con "LOCAL" como tipo fijo
            public ProveedorLocal(string idproveedor, string rnc, string nombre, string telefono, string producto, decimal precio)
                : base(idproveedor, rnc, nombre, telefono, producto, "LOCAL", precio)
            {
            }

            //  Implementación de métodos abstractos
            public override string ObtenerIdentificadorPrincipal() => RNC;

            // Validación el RNC debe tener exactamente 9 dígitos
            public override bool EsValido() =>
                !string.IsNullOrWhiteSpace(RNC) && RNC.Length == 9;

            public override string ObtenerTipo() => "LOCAL";
        }
   }
