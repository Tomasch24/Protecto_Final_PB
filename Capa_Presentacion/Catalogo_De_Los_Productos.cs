using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Catalogo_De_Los_Productos_Load(object sender, EventArgs e)
        {

        }

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
    }
}
