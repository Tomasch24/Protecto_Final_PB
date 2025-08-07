using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class UCProducto : UserControl
    {
        public UCProducto()
        {
            InitializeComponent();
        }
        //TODO Propiedad pública para almacenar el ID del producto
        public int IdProducto { get; set; }

        //TODO Evento que se dispara cuando se agrega un producto
        public event EventHandler<ProductoEventArgs> ProductoAgregado;

        public void SetData(int id, string nombre, decimal precio, int stock, string Imagenpath)
        {
            IdProducto = id;

            //TODO Mostrar los datos en las etiquetas del control
            lblID.Text = id.ToString();
            lblNombre.Text = nombre;
            lblPrecio.Text = $"Precio: {precio:C}DOP";
            lblStock.Text = $"Stock: {stock}";

            try
            {
                //TODO Construir la ruta completa de la imagen usando la carpeta de inicio de la aplicación
                string rutaCompleta = Path.Combine(Application.StartupPath, Imagenpath);

                if (!string.IsNullOrEmpty(Imagenpath) && File.Exists(rutaCompleta))
                {
                    pbImagenPro.Image = Image.FromFile(rutaCompleta);
                }
                else
                {
                    pbImagenPro.Image = null;
                }
            }
            catch
            {
                pbImagenPro.Image = null;
            }
        }

        //TODO Clase personalizada para transportar datos de producto en eventos
        public class ProductoEventArgs : EventArgs
        {
            public int IdProducto { get; set; }
            public string Nombre { get; set; }

            public decimal Precio { get; set; }
            public int Stock { get; set; }

        }

        //TODO Extrae el valor decimal del texto de precio formateado
        private decimal ObtenerPrecio(string texto)
        {
            //TODO Elimina la etiqueta y el símbolo de moneda
            string sinEtiqueta = texto.Replace("Precio: ", "").Replace("$", "").Trim();                

            decimal precio;
            return decimal.TryParse(sinEtiqueta, NumberStyles.Any, CultureInfo.InvariantCulture, out precio) ? precio : 0m;
                  
        }

       //TODO Extrae el valor entero del texto de stock formateado
        private int ObtenerStock(string texto)
        {
            
            string sinEtiqueta = texto.Replace("Stock:", "").Trim();

            //TODDO Intenta convertir el texto limpio a entero
            int stock;
            return int.TryParse(sinEtiqueta, out stock) ? stock : 0;
        }

        //Manejador del evento click del botón "Agregar a Factura"
        private void btnAgregarFac_Click(object sender, EventArgs e)
        {

            //TODO Dispara el evento personalizado, enviando los datos del producto como argumentos
            ProductoAgregado?.Invoke(this, new ProductoEventArgs
            {
                IdProducto = int.TryParse(lblID.Text, out int id) ? id : 0,
                Nombre = lblNombre.Text,
                Precio = ObtenerPrecio(lblPrecio.Text),
                Stock = ObtenerStock(lblStock.Text)

            });
        }

        public void HabilitarBotonAgregar()
        {
            btnAgregarFac.Enabled = true;
        }
    }

}




