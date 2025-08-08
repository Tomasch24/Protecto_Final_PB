using Capa_de_Modulos.CACHE; // Importa el espacio de nombres donde se almacena la información del usuario logueado.
using System; 
using System.Collections.Generic; 
using System.ComponentModel; // Habilita atributos y clases para el diseño de componentes.
using System.Data; 
using System.Drawing; 
using System.Linq; 
using System.Threading.Tasks; // Facilita la programación asíncrona.
using static System.Windows.Forms.VisualStyles.VisualStyleElement; 

namespace Capa_Presentacion 
{
   
    public partial class FormBienvenida : Form
    {
        // TODO --- SECCIÓN: Constructor ---

      
        public FormBienvenida()
        {
            InitializeComponent();
        }

        //TODO --- SECCIÓN: Manejadores de Eventos ---

        private void label2_Click(object sender, EventArgs e)
        {
            // Este es un manejador de eventos de clic vacío.
            // No realiza ninguna acción, posiblemente se generó automáticamente y se dejó sin implementar.
        }

       
        private async void timer1_Tick(object sender, EventArgs e)
        {
            // Aumenta la opacidad del formulario hasta que sea completamente visible (1.0).
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }

            // Aumenta el valor de la barra de progreso hasta llegar a 100.
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }

            // Una vez que la barra de progreso llega a 100,
            if (progressBar1.Value == 100)
            {
                // se detiene el timer 1 y comienza el timer 2.
                // El 'await Task.Delay(1000)' introduce una pausa de 1 segundo
                // antes de pasar a la siguiente etapa de la animación.
                await Task.Delay(1000);
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Disminuye la opacidad del formulario para crear un efecto de desvanecimiento (fade-out).
            this.Opacity -= 0.05;

            //TODO Cuando el formulario es completamente transparente, se detiene el temporizador
            // y se cierra el formulario.
            if (this.Opacity <= 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

     
        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            //Muestra el nombre y apellido del usuario que ha iniciado sesión en un Label.
            //La información se obtiene de una clase estática o cache de usuario.
            lblusuario.Text = LoginUser.Nombre + " " + LoginUser.Apellido;

            //Establece la opacidad inicial del formulario a 0 para que sea invisible al cargar.
            this.Opacity = 0.0;

            //Inicia el primer temporizador para comenzar la animación de fade-in y progreso.
            timer1.Start();
        }
    }
}