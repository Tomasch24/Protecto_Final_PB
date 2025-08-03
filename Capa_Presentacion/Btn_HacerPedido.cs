using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class Btn_HacerPedido : Form
    {
        public PedidosNegocio pedidoNegocio = new PedidosNegocio();
        public DataRow datosProducto;
        public string nombreProducto;
        public decimal precioBase;
        public int idProducto;
        public string idProveedor;


        public Btn_HacerPedido(string producto)
        {
            InitializeComponent();
            txtCantidad.Text = "1"; // Valor por defecto
            txtCantidad.MaxLength = 3; // Limitar a 3 dígitos

            nombreProducto = producto;

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            // TODO Validar que solo se ingresen números
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 1 || cantidad > 999)
            {
                MessageBox.Show("Por favor, ingrese un número válido entre 1 y 999.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Text = "1";
                cantidad = 1;
            }
            if (precioBase <= 0)
                return;
            // Calcular el total automáticamente
            txtTotal.Text = (cantidad * precioBase).ToString("0.00");
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lblConfirmar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0 || cantidad > 999)
            {
                MessageBox.Show("Cantidad inválida.");
                return;
            }

            decimal total = cantidad * precioBase;
            bool exito = pedidoNegocio.RegistrarPedido(idProducto, idProveedor, precioBase, cantidad, total);

            if (exito)
            {
                MessageBox.Show("Pedido registrado correctamente.");
                this.DialogResult = DialogResult.OK; // para refrescar desde el form anterior
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar el pedido.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_HacerPedido_Load(object sender, EventArgs e)
        {
            datosProducto = pedidoNegocio.ObtenerDatosProductoCompleto(nombreProducto);
            if (datosProducto != null)
            {
                idProducto = Convert.ToInt32(datosProducto["IDPRODUCTO"]);
                idProveedor = datosProducto["IDPROVEEDOR"].ToString();
                precioBase = Convert.ToDecimal(datosProducto["PrecioBase"]);

                txtProducto.Text = datosProducto["Nombre"].ToString();
                txtTipo.Text = datosProducto["Tipo"].ToString();
                txtProveedor.Text = datosProducto["NombreProveedor"].ToString();
                txtRNC.Text = datosProducto["RNC"].ToString();
                txtTelefono.Text = datosProducto["Telefono"].ToString();
                txtPrecioBase.Text = precioBase.ToString("0.00");
            }
        }
    }
}
