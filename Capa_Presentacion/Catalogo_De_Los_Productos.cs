using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_negocios;
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
            MostrarInformacion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       private void MostrarInformacion() 
       {

            var lista = ProductoVista.Mostrar_InfCatPro();

            DGVProductos.DataSource = null;
            DGVProductos.DataSource = lista.Select(P => new
            {
                
                P.Id,
                P.Nombre,
                P.Precio,
                P.Stock
            }).ToList();
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


    }
}

    

