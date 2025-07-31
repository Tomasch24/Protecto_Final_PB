using ConexionADatos;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

//Entrega Final 3.0
namespace Capa_Negocios
{
    //Todo Classe Principal 
    public class Producto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public virtual string Tipo { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string ImangenRuta { get; set; }
        public decimal Total => Precio * Cantidad;

        //TODO Costo de envio y su metodo
        public decimal CostoDeEnvio => CostoEn();

        public decimal CostoEn()
        {
            decimal CostoE = Total * 0.15m;

            return CostoE;
        }



    }



}