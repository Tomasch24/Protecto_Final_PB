using Capa_de_Modulos.CACHE; // Para usar la clase LoginUser que almacena los datos del usuario logueado
using Capa_Presentacion;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;

namespace Capa_Interfas
{
    public partial class Pantalla_De_Inicio : Form
    {
        #region Campos de clase

        // Almacena una referencia al formulario que está actualmente abierto en el panel principal.
        // Se usa para poder cerrarlo antes de abrir uno nuevo. Es 'nullable' (con ?) porque al inicio no hay ningún formulario activo
        private Form? activeForm = null;

        #endregion


        #region Constructor y Carga de Datos
        public Pantalla_De_Inicio()
        {
            InitializeComponent();

            this.Text = string.Empty; // Elimina el texto de la barra de título.
            this.DoubleBuffered = true; // Mejora el rendimiento del dibujado del formulario, reduciendo el parpadeo.
            // Limita el área de maximización para que no cubra la barra de tareas de Windows.
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Pantalla_De_Inicio_Load(object sender, EventArgs e)
        {
            // Llama al método para cargar la información del perfil del usuario en la interfaz
            LoadUserData();
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
                // Obtiene la ruta relativa de la imagen desde la clase estática de caché (USUARIOS\harvey.jpg)
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

        private void btnMaximzar_Click(object sender, EventArgs e)
        {
            // Cambia el estado de la ventana a maximizado
            this.WindowState = FormWindowState.Maximized;
            // Oculta el botón de maximizar y muestra el de restaurar para una mejor experiencia de usuario
            btnRestaurar.Visible = true;
            btnMaximzar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            // Devuelve la ventana a su estado normal.
            this.WindowState = FormWindowState.Normal;
            // Oculta el botón de restaurar y vuelve a mostrar el de maximizar
            btnRestaurar.Visible = false;
            btnMaximzar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion



       
    }
}
