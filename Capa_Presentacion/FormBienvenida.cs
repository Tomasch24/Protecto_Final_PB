using Capa_de_Modulos.CACHE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Presentacion
{
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Empty click event handler
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }

            // Aumenta el valor del ProgressBar solo si no ha llegado a 100
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }

            if (progressBar1.Value == 100)
            {
                // Simula una operación asíncrona de 1 segundo
                await Task.Delay(1000);
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity <= 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            lblusuario.Text = LoginUser.Nombre + " " + LoginUser.Apellido;
            this.Opacity = 0.0;
            timer1.Start();
        }
    }
}
