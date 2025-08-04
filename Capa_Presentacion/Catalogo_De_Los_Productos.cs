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
using ConexionADatos;
using Microsoft.Data.SqlClient;

namespace Capa_Interfas
{


    public partial class Catalogo_De_Los_Productos : Form
    {
        public Catalogo_De_Los_Productos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconoCerrarCat_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void iconoMinimizarCat_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //private readonly ProductoService servicio = new ProductoService();

        /*private void Catalogo_De_Los_Productos_Load(object sender, EventArgs e)
        {
            var productos = servicio.ObtenerResumenProductos();
            DGVProductos.DataSource = productos;

            // Ajuste visual de columnas (opcional)
            DGVProductos.Columns["Id"].HeaderText = "ID";
            DGVProductos.Columns["Nombre"].HeaderText = "Nombre";
            DGVProductos.Columns["Tipo"].HeaderText = "Tipo";
            DGVProductos.Columns["Precio"].HeaderText = "Precio";
        }*/

        private void butHacer_pedido_Click(object sender, EventArgs e)
        {
            Seleccion_De_Producto selecCat = new Seleccion_De_Producto();

            selecCat.Show();

            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolMenu_Click(object sender, EventArgs e)
        {
            Pantalla_De_Inicio inicio = new Pantalla_De_Inicio();
            inicio.Show();

            this.Dispose();
        }

        private void DGVProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Productos_Agri conexion = new Productos_Agri();
            using (SqlConnection conn = new SqlConnection(conexion.Conexion))
            {
                conn.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(
                    "SELECT Id, Nombre, Temporada, Tipo, Precio, Stock,", conn);
                DataTable dataTable = new DataTable();
                adpt.Fill(dataTable);
                DGVProductos.DataSource = dataTable;
                conn.Close();
            }
        }
    }
}
