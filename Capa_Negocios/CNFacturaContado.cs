using capa_negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocios
{
    //TODO herencia clase Factura en factura Contado
    public class FacturaContado : Factura
    {
        public FacturaContado(CNCliente cliente) : base(cliente) { }

        //TODO uso del metodo abstracto
        public override string TipoFactura() => "Contado";
    }

}
