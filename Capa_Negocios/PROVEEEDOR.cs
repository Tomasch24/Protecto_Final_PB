using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace Capa_Negocios
    {
        // Es abstracta porque define lo común y obliga a las clases hijas a implementar lo específico
        public abstract class PROVEEDOR
        {
            public string IDPROVEEDOR { get; set; } 
            public string RNC { get; set; }
            public string NOMBRE { get; set; }
            public string TELEFONO { get; set; }
            public string PRODUCTO { get; set; }
            public string TIPO { get; set; }
            public decimal PRECIO { get; set; } 

            // Constructor base: se usa en las clases hijas a través de herencia
            protected PROVEEDOR(string idproveedor, string rnc, string nombre, string telefono, string producto, string tipo, decimal precio)
            {
                IDPROVEEDOR = idproveedor;
                RNC = rnc;
                NOMBRE = nombre;
                TELEFONO = telefono;
                PRODUCTO = producto;
                TIPO = tipo;
                PRECIO = precio;
            }

            // Métodos abstractos: obligan a las subclases a definir su comportamiento
            public abstract string ObtenerIdentificadorPrincipal();  
            public abstract bool EsValido();                        
            public abstract string ObtenerTipo();              
        }
    }

