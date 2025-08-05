using System;
using System.Data;
using System.Runtime.CompilerServices;
using Capa_negocios;
using ConexionADatos;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace capa_negocios
{
    //TODO clase abstracta base Factura
    public abstract class Factura
    {
        public int IdFactura { get; set; }
        public CNCliente Cliente { get; set; }
        public string NombreFactura { get; set; }
        public string TelefonoF { get; set; }
        public string RncF { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } 

        public decimal SubTotal => Precio * Cantidad;
        public decimal Descuento { get;  set; }
        public decimal Total { get; set; }

        //TODO constructor clase facrura

        public Factura(CNCliente cliente)
        {
            Cliente = cliente;
        }

        //TODO metodo vacio para aplicarle descuento a clientes registrados
        public void AplicarDescuento()
        {
            decimal DescuentoPorCantidad = Cantidad switch
            {
                >= 50 => SubTotal * 0.15m,
                >= 20 => SubTotal * 0.10m,
                >= 10 => SubTotal * 0.05m,
                _ => 0
            };

            decimal DescuentoClienteRegistrado; 
                
            if (Cliente?.IdCliente > 0)
                DescuentoClienteRegistrado = SubTotal * 0.05m;
            else
                DescuentoClienteRegistrado = 0;

            Descuento = DescuentoPorCantidad + DescuentoClienteRegistrado;

        }

        //TODO Metodo Virtual para calcular totales
        public virtual void CalcularTotales()
        {
           
            Total = SubTotal - Descuento;
        }

        //TODO Método abstracto para identificar el tipo de factura (Contado o Credito)
        public abstract string TipoFactura(); 

       
    }
}


