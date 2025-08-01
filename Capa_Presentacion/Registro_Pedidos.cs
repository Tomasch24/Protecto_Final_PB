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
    public partial class Registro_Pedidos : Form
    {
        // TODO Instancia de la clase PedidosNegocio 
        PedidosNegocio negocio = new PedidosNegocio();

        public Registro_Pedidos()
        {
            InitializeComponent();
        }

        private void Registro_Pedidos_Leave(object sender, EventArgs e)
        {

        }

        private void Registro_Pedidos_Load(object sender, EventArgs e)
        {
            // TODO Cargar los pedidos al iniciar el formulario
            CargarPedidos();

        }

        private void CargarPedidos()
        {
            // TODO Cargar los pedidos en el DataGridView
            dgvRegistro.DataSource = negocio.ObtenerPedidos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // TODO Cerrar el formulario de registro de pedidos
            this.Close();
        }


        // TODO evento exportar a Excel
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvRegistro.DataSource == null)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "Reporte_Pedidos.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable tabla = (DataTable)dgvRegistro.DataSource;
                try
                {
                    negocio.ExportarPedidosAExcel(tabla, saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message);
                }
            }
        }
    }
}
