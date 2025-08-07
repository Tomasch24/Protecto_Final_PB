using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_negocios;
using Capa_Negocios;
using Capa_Presentacion;
using ConexionADatos;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;

namespace Capa_Interfas
{


    public partial class Catalogo_De_Los_Productos : Form
    {

        public Catalogo_De_Los_Productos()
        {
            InitializeComponent();
            CargarProductos();
        }


        private void CargarProductos()
        {
            try
            {
                Productos_Agri data = new Productos_Agri();

                using (SqlConnection conn = new SqlConnection(data.Conexion))
                {

                    string query = "SELECT Id, Nombre, Precio, Stock, ImagenPath FROM Producto";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    //TODO Ejecutar la consulta y obtener los resultados
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        UCProducto ucpro = new UCProducto();

                        //TODO Obtener la ruta de la imagen (si existe)
                        string imagenPath = reader["ImagenPath"] != DBNull.Value ? reader["ImagenPath"].ToString() : string.Empty;

                        //TODO Cargar los datos del producto en el UserControl
                        ucpro.SetData(
                            Convert.ToInt32(reader["Id"]),
                            reader["Nombre"].ToString(),
                            Convert.ToDecimal(reader["Precio"]),
                            Convert.ToInt32(reader["Stock"]),
                            imagenPath
                        );

                        //TODO Agregar el UserControl al FlowLayoutPanel
                        flpCatalogo.Controls.Add(ucpro);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos:\n" + ex.Message + "\n\n" + ex.StackTrace);

            }
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



        private void butHacer_pedido_Click(object sender, EventArgs e)
        {



        }

        private void btnVolMenu_Click(object sender, EventArgs e)
        {

        }




        private void DGVProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Catalogo_De_Los_Productos_Load(object sender, EventArgs e)
        {
        }

        //TODO Manejador del evento click para habilitar los botones "Agregar" en todos los productos del catálogo.
        private void btnHabilitarCat_Click(object sender, EventArgs e)
        {

            //TODO Recorre todos los controles dentro del FlowLayoutPanel
            foreach (System.Windows.Forms.Control control in flpCatalogo.Controls)
            {
                if (control is UCProducto uc)
                {
                    uc.HabilitarBotonAgregar();
                }
            }
        }
    }
}

    

