using Capa.Presentacion;
using Capa_de_Modulos.CACHE; // Para usar la clase LoginUser que almacena los datos del usuario logueado
using Capa_Presentacion;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Capa_Interfas
{
    public partial class Pantalla_De_Inicio : Form
    {
        public static Pantalla_De_Inicio InstanciaActual;

        #region Campos de clase
        private Panel loadingPanel;
        //TODO  Almacena una referencia al formulario que está actualmente abierto en el panel principal.
        // TODO Se usa para poder cerrarlo antes de abrir uno nuevo. Es 'nullable' (con ?) porque al inicio no hay ningún formulario activo
        private Form? activeForm = null;

        #endregion

        private Button _activeButton;

        #region Constructor y Carga de Datos
        public Pantalla_De_Inicio()
        {
            InitializeComponent();
            this.Text = string.Empty; //TODO Elimina el texto de la barra de título.
            this.DoubleBuffered = true; // TODO Mejora el rendimiento del dibujado del formulario, reduciendo el parpadeo.
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Pantalla_De_Inicio_Load(object sender, EventArgs e)
        {
            //TODO  Llama al método para cargar la información del perfil del usuario en la interfaz
            LoadUserData();
            InstanciaActual = this;
            CargarPantallaInicio(); // TODO: Se llama a este método para asegurar que la pantalla de inicio se muestre al cargar el formulario.
        }

        //TODO  Carga los datos del usuario (que fueron guardados en la caché durante el login) en los controles del formulario
        private void LoadUserData()
        {
            lblnom.Text = LoginUser.Nombre + " " + LoginUser.Apellido;
            lblRol.Text = LoginUser.Rol;
            lblemail.Text = LoginUser.Email;
            try
            {
                string fotoPath = LoginUser.FotoPath;
                if (!string.IsNullOrEmpty(fotoPath))
                {
                    string rutaCompleta = System.IO.Path.Combine(Application.StartupPath, fotoPath);
                    if (System.IO.File.Exists(rutaCompleta))
                    {
                        PBuser.Image = Image.FromFile(rutaCompleta);
                    }
                }
            }
            catch (Exception ex)
            {
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
                activeForm.Close();
                activeForm = null;
            }
            // TODO: Lógica para mostrar la pantalla de inicio. Si el PanelHerencia tiene una imagen de fondo,
            // con limpiar el formulario hijo ya es suficiente.
        }

        // TODO: Evento asociado al PictureBox del logo en la barra de título (PBlogoG).
        private void PBlogoG_Click(object sender, EventArgs e)
        {
            CargarPantallaInicio();
        }
        #endregion

        #region Metodo normal para abrir Formularios hijos en el panel principal
        public void OpenPanelHerencia(Form herenciaForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = herenciaForm;
            herenciaForm.TopLevel = false;
            herenciaForm.FormBorderStyle = FormBorderStyle.None;
            herenciaForm.Dock = DockStyle.Fill;
            PanelHerencia.Controls.Add(herenciaForm);
            PanelHerencia.Tag = herenciaForm;
            herenciaForm.BringToFront();
            herenciaForm.Show();
        }
        #endregion

        #region Eventos de botones
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que quiere cerrar sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void BotonParaDashBoard_Click(object sender, EventArgs e)
        {
            OpenPanelHerencia(new DashGrafico());
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OpenPanelHerencia(new FormPROVEEDORES());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenPanelHerencia(new Sistema());
        }

        private void pbIconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            OpenPanelHerencia(new Catalogo_De_Los_Productos());
        }

        private void lblnom_Click_1(object sender, EventArgs e) { }
        private void lblRol_Click(object sender, EventArgs e) { }

        #endregion

        // TODO: Métodos sin usar. Se han consolidado en una sola región para mayor orden.
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void BarraTitulo_Paint(object sender, PaintEventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void lblnom_Click(object sender, EventArgs e) { }
        private void panel1_Paint_1(object sender, PaintEventArgs e) { }
        private void panel1_Paint_2(object sender, PaintEventArgs e) { }
        private void panel1_Paint_3(object sender, PaintEventArgs e) { }
        private void Dasboard(object sender, EventArgs e) { }
        private void MenuVertical_Paint(object sender, PaintEventArgs e) { }
        private void PBuser_Click(object sender, EventArgs e) { }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}