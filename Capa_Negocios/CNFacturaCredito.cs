using capa_negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocios
{
    //TODO herencia clase Factura en factura Credito
    public class FacturaCredito : Factura
    {
        public FacturaCredito(CNCliente cliente) : base(cliente) { }

        //TODO uso del metodo abstracto
        public override string TipoFactura() => "Crédito";

        //TODO uso del metodo virtual
        public override void CalcularTotales()
        {
          
            Total = (SubTotal - Descuento) + (SubTotal * 0.08m);
        }
    }
}
