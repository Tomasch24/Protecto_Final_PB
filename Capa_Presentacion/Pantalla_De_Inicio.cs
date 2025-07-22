using System.Runtime.InteropServices;
using Capa_Presentacion;

namespace Capa_Interfas
{
    public partial class Pantalla_De_Inicio : Form
    {
        public Pantalla_De_Inicio()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void button1_Click(object sender, EventArgs e)
        {
            Catalogo_De_Los_Productos catPro = new Catalogo_De_Los_Productos();

            catPro.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seleccion_De_Producto SelPro = new Seleccion_De_Producto();

            SelPro.Show();

             this.Hide();
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pantalla_De_Inicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 68)
            {
                MenuVertical.Width = 310;
            }
            else
            {
                MenuVertical.Width = 68;
            }
        }




        private void iconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();

            empleado.Show();

            this.Hide();
        }
    }
}
