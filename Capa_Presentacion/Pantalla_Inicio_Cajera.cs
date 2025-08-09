using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_de_Modulos.CACHE;
using Capa_Interfas;
using DocumentFormat.OpenXml.Bibliography;

namespace Capa_Presentacion
{
    public partial class Pantalla_Inicio_Cajera : Form
    {
        public Pantalla_Inicio_Cajera()
        {
            InitializeComponent();


            this.Text = string.Empty; // Elimina el texto de la barra de título.
            this.DoubleBuffered = true; // Mejora el rendimiento del dibujado del formulario, reduciendo el parpadeo.
            // Limita el área de maximización para que no cubra la barra de tareas de Windows.
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            // Asocia el evento MenuButton_Click a todos los botones del menú

            this.Text = string.Empty;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region Campos de clase
        private Panel loadingPanel;
        // Almacena una referencia al formulario que está actualmente abierto en el panel principal.
        // Se usa para poder cerrarlo antes de abrir uno nuevo. Es 'nullable' (con ?) porque al inicio no hay ningún formulario activo
        private Form? activeForm = null;

        #endregion
        private Button _activeButton;

        #region Constructor y Carga de Datos


        private void Pantalla_De_Inicio_Load(object sender, EventArgs e)
        {
            // Llama al método para cargar la información del perfil del usuario en la interfaz
            LoadUserData();
            // TODO: Se llama a este método para asegurar que la pantalla de inicio se muestre al cargar el formulario.
            CargarPantallaInicio();
        }

        // Carga los datos del usuario (que fueron guardados en la caché durante el login) en los controles del formulario
        private void LoadUserData()
        {
            // Asigna el nombre, posición y email a los labels correspondientes
            lblnom.Text = LoginUser.Nombre + " " + LoginUser.Apellido;
            lblRol.Text = LoginUser.Rol;
            lblemail.Text = LoginUser.Email;

            // Bloque try-catch para manejar de forma segura posibles errores al cargar la imagen
            try
            {
                // Obtiene la ruta relativa de la imagen desde la clase estática de caché (USUARIOS\donna.jpg)
                string fotoPath = LoginUser.FotoPath;

                // Se asegura de que la ruta de la foto no esté vacía antes de intentar cargarla
                if (!string.IsNullOrEmpty(fotoPath))
                {
                    // Combina la ruta de inicio de la aplicación con la ruta relativa de la foto
                    // para obtener la ubicación completa y exacta del archivo de imagen
                    string rutaCompleta = System.IO.Path.Combine(Application.StartupPath, fotoPath);

                    // Verifica que el archivo de imagen realmente existe en la ruta calculada antes de intentar cargarlo
                    if (System.IO.File.Exists(rutaCompleta))
                    {
                        // Carga la imagen desde el archivo y la asigna al control PictureBox
                        PBuser.Image = Image.FromFile(rutaCompleta);
                    }
                }
            }
            catch (Exception ex)
            {
                // Si ocurre cualquier error (el archivo está dañado), muestra un mensaje al usuario
                MessageBox.Show("No se pudo cargar la imagen de perfil: " + ex.Message);
            }
        }


        #endregion



        #region API

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        #endregion

        #region Eventos de navegación al inicio
        // TODO: Este es el nuevo método que limpia el panel principal y vuelve a la pantalla inicial.
        private void CargarPantallaInicio()
        {
            if (activeForm != null)
            {
                // Cierra el formulario hijo actual para limpiar el panel.
                activeForm.Close();
                activeForm = null;
            }
            // TODO: Aquí debes implementar la lógica para mostrar la pantalla en blanco con el logo.
            // Una forma es simplemente asegurarte de que el PanelHerencia esté vacío y que
            // su imagen de fondo (o un PictureBox dentro de él) sea visible.
        }

        // TODO: Este es el evento asociado al PictureBox del logo en la barra de título (PBlogoC).
        private void PBlogoC_Click(object sender, EventArgs e)
        {
            // Llama al método que limpia el panel y muestra la pantalla de inicio.
            CargarPantallaInicio();
        }
        #endregion



        #region botones menu

        //En progreso, hasta que terminen ustedes. 
        #endregion


        #region Metodo normal para abrir Formularios hijos en el panel principal

        // Este es el método central para la navegación, recibe cualquier formulario que deba ser mostrado
        private void OpenPanelHerencia(Form herenciaForm)
        {
            // Comprueba si ya hay un formulario abierto en el panel
            if (activeForm != null)
                // Si lo hay, lo cierra para limpiar el panel antes de abrir el nuevo
                activeForm.Close();

            // Guarda una referencia al nuevo formulario que se va a abrir
            activeForm = herenciaForm;

            //Configura el formulario hijo para que se comporte como un control dentro del panel 
            herenciaForm.TopLevel = false;
            herenciaForm.FormBorderStyle = FormBorderStyle.None; // Le quita los bordes y la barra de título
            herenciaForm.Dock = DockStyle.Fill; // Hace que ocupe todo el espacio del panel

            //Agrega y muestra el formulario en el panel
            PanelHerencia.Controls.Add(herenciaForm); // Lo añade a la colección de controles del panel
            PanelHerencia.Tag = herenciaForm; // Guarda una referencia en la propiedad
            herenciaForm.BringToFront(); // Se asegura de que se muestre por encima de cualquier otro control en el panel
            herenciaForm.Show(); // Muestra el formulario
        }
        #endregion


        #region Botones de la ventana (cerrar, restaurar, Maximizar, Minimizar)  y boton de cierre de sesion

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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que quiere cerrar sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea cerrar la aplicacion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            OpenPanelHerencia(new Catalogo_De_Los_Productos());

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            OpenPanelHerencia(new Facturacion());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            OpenPanelHerencia(new Pedidos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenPanelHerencia(new Clientes());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenPanelHerencia(new Sistema());
        }

        private void pbIconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCatalogo_Click_1(object sender, EventArgs e)
        {
            OpenPanelHerencia(new Catalogo_De_Los_Productos());
        }

        private void PBuser_Click(object sender, EventArgs e)
        {

        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void lblRol_Click(object sender, EventArgs e)
        {

        }

        private void lblnom_Click(object sender, EventArgs e)
        {

        }

        private void btnCatalogo_Click_2(object sender, EventArgs e)
        {
            OpenPanelHerencia(new Catalogo_De_Los_Productos());
        }

        private void btnFacturacion_Click_1(object sender, EventArgs e)
        {
            OpenPanelHerencia(new Facturacion());

        }

        private void btnPedidos_Click_1(object sender, EventArgs e)
        {
            OpenPanelHerencia(new Pedidos());

        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            OpenPanelHerencia(new Clientes());

        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            OpenPanelHerencia(new Sistema());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pantalla_Inicio_Cajera_Load(object sender, EventArgs e)
        {
            LoadUserData();

        }

        private void pbIconCerrar_Click_1(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Muestra un cuadro de diálogo para confirmar la acción.
            if (MessageBox.Show("¿Esta seguro de que quiere cerrar sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                // Si el usuario presiona "Sí", se cierra este formulario (FormAcceso), lo que debería devolver al usuario al formulario de login.
                this.Close();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
#endregion