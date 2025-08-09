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
using System.Runtime.InteropServices;


namespace Capa_Presentacion
{
    public partial class Btn_HacerPedido : Form
    {
        // TODO Instancia de la clase PedidosNegocio para manejar la lógica de negocio
        public PedidosNegocio pedidoNegocio = new PedidosNegocio();
        // TODO Variables para almacenar los datos del producto seleccionado (de la base de datos)
        public DataRow datosProducto;
        public string nombreProducto;
        public decimal precioBase;
        public int idProducto;
        public string idProveedor;


        public Btn_HacerPedido(string producto)
        {
            InitializeComponent();
            txtCantidad.Text = "1"; // TODO Valor por defecto
            txtCantidad.MaxLength = 3; // TODO Limitar a 3 dígitos

            nombreProducto = producto; // TODO Guardar el nombre del producto seleccionado

        }

        

        // TODO Evento que se dispara cuando cambia el texto del campo de cantidad
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
            // TODO Calcular el total automáticamente
            txtTotal.Text = (cantidad * precioBase).ToString("0.00");
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        // TODO Evento que se dispara al hacer clic en el botón de confirmar pedido

        private void lblConfirmar_Click(object sender, EventArgs e)
        {
            // TODO validaciones
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
                this.DialogResult = DialogResult.OK; // TODO para refrescar desde el form anterior
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar el pedido.");
            }
        }


        // TODO Evento que se dispara al hacer clic en el botón de cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // TODO carga el form hacer pedido y obtiene los datos del producto seleccionado
        private void Btn_HacerPedido_Load(object sender, EventArgs e)
        {
            datosProducto = pedidoNegocio.ObtenerDatosProductoCompleto(nombreProducto);
            if (datosProducto != null)
            {
                idProducto = Convert.ToInt32(datosProducto["IDPRODUCTO"]);
                idProveedor = datosProducto["IDPROVEEDOR"].ToString();
                precioBase = Convert.ToDecimal(datosProducto["PrecioBase"]);

                txtProducto.Text = datosProducto["Nombre"].ToString();
                txtProveedor.Text = datosProducto["NombreProveedor"].ToString();
                txtRNC.Text = datosProducto["RNC"].ToString();
                txtTelefono.Text = datosProducto["Telefono"].ToString();
                txtPrecioBase.Text = precioBase.ToString("0.00");
            }

            txtTotal.Text = (1 * precioBase).ToString("0.00");
        }

        //TODO codigo para mover el formulario
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;



        // TODO Permitir mover el formulario desde cualquier parte del mismo
        private void Btn_HacerPedido_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
