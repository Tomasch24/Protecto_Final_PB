using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Btn_HacerPedido : Form
    {
        public Btn_HacerPedido()
        {
            InitializeComponent();
            txtCantidad.Text = "1"; // Valor por defecto
            txtCantidad.MaxLength = 3; // Limitar a 3 dígitos
           


        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            // Validar que solo se ingresen números
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 1 || cantidad > 999)
            {
                MessageBox.Show("Por favor, ingrese un número válido entre 1 y 999.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Text = "1"; // Restablecer a valor por defecto
            }
        }
    }
}
