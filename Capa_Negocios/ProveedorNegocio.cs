using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    internal class ProveedorNegocio
    {
        private CNProveedor data = new CNProveedor();

        public string BuscarNombrePorRNC(string rnc)
        {
            return data.ObtenerNombrePorRNC(rnc);
        }
    }
}
