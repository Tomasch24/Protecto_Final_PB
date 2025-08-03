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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            cbTipo.Items.Add("Contado");
            cbTipo.Items.Add("Crédito");
            cbTipo.SelectedIndex = 0;
            txtTotal.Text = "0";
        }
        private void LimpiarCampos()
        {
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            MtxtRnc.Text = "";
            MtxtTelefono.Text = "";
            txtIdCliente.Text = "";
            txtIdProducto.Text = "";
            txtCambio.Text = "";
            txtPago.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
            txtStock.Text = "";
            txtTotal.Text = "0";
        }
    }
    
}
