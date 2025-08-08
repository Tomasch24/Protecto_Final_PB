using Capa_Interfas;
using Capa_Negocios;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Capa_de_Modulos.CACHE;


namespace Capa_Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            personalizar();
        }



        #region Eventos botones del LoginFom
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Verifica si los campos de usuario y contraseña no están vacíos o con valores por defecto
            if (txtUser.Text != "Usuario")
            {
                if (txtPassword.Text != "Contraseña")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUser.Text, txtPassword.Text);

                    // TODO: La validación debe ocurrir primero
                    if (validLogin == true)
                    {
                        // Si el login es exitoso, muestra la pantalla de bienvenida y luego el formulario principal
                        this.Dispose();
                        FormBienvenida bienvenida = new FormBienvenida();
                        bienvenida.ShowDialog();

                        if (LoginUser.Rol == "Gerente")
                        {
                            Pantalla_De_Inicio inicioGerente = new Pantalla_De_Inicio();
                            inicioGerente.Show();
                            inicioGerente.FormClosed += LogOut;
                        }
                        else if (LoginUser.Rol == "Cajera")
                        {
                            Pantalla_Inicio_Cajera inicioCajera = new Pantalla_Inicio_Cajera();
                            inicioCajera.Show();
                            inicioCajera.FormClosed += LogOut;
                        }
                        else
                        {
                            msgError("Rol de usuario no reconocido.");
                            this.Show(); // En caso de rol no reconocido, vuelve a mostrar el login
                        }
                    }
                    else // Si la validación falla
                    {
                        msgError("Usuario o contraseña incorrectos \n Intenta nuevamente, por favor.");
                        txtPassword.Clear();
                        txtUser.Focus();
                    }
                }
                else msgError("Ingrese La Contraseña");
            }
            else msgError("Ingrese el nombre de usuario");

        }



        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
            lblError.Visible = false; // Oculta el mensaje de error al cerrar el formulario
            this.Show(); // Muestra el formulario de login nuevamente
            txtUser.Focus(); 
        }

          

        
        #endregion



        #region eventos para mover el formulario

        // DllImport para capturar el mouse y enviar mensajes de la ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture(); // extern indica que la implementación está en una DLL externa

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam); // Se necesita el cuarto parámetro

        // Constantes para el mensaje de la ventana
        private const int WM_NCLBUTTONDOWN = 0xA1; // Mensaje cuando se presiona el botón izquierdo del mouse fuera del area del form
        private const int HT_CAPTION = 0x2; // Indica que la acción ocurrió en la barra de título


        // Evento MouseDown para que el panel sea arrastrable
        private void panelLogTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera la captura actual del mouse
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envía un mensaje a la ventana para iniciar el arrastre
            }
        }

        //Lo mismo para el formulario completo, de manera que se pueda mover
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion



        #region Personalizacion de controles

        private void personalizar()
        {
            txtUser.AutoSize = false;
            txtUser.Size = new Size(350, 35);

            txtPassword.AutoSize = false;
            txtPassword.Size = new Size(350, 35);
            txtPassword.UseSystemPasswordChar = true; //TODO : hacer que la contraseña no sea "legible"
        }
        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {
            // El 'sender' es el botón que dispara el evento. Lo convertimos al tipo Button
            Button btn = sender as Button;

            // Verificamos que sea un botón válido para evitar errores
            if (btn == null) return;

            // Creamos un nuevo GraphicsPath para definir la forma del botón
            GraphicsPath buttonPath = new GraphicsPath();

            // Obtenemos el rectángulo que define el área del botón
            Rectangle buttonRectangle = btn.ClientRectangle;

            buttonRectangle.Inflate(0, 30);

            // Añadimos una forma elíptica al GraphicsPath usando el rectángulo inflado
            buttonPath.AddEllipse(buttonRectangle);

            // Esto es lo que visualmente le da la forma elíptica.
            btn.Region = new Region(buttonPath);

        }
        #endregion


        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            //TODO Si la tecla presionada es Enter
            if (e.KeyCode == Keys.Enter)
            {
                //TODO Si el foco está en el TextBox de usuario (txtUser)
                if (txtUser.Focused)
                {
                    //TODO Mueve el foco al TextBox de contraseña (txtPassword)
                    txtPassword.Focus();
                    //TODO Evita que el "Enter" sea procesado por otros controles, como el botón
                    e.Handled = true;
                }
                //TODO Si el foco está en el TextBox de contraseña (txtPassword)
                else if (txtPassword.Focused)
                {
                    //TODO Llama al evento click del botón de login
                    btnLogin_Click(sender, e);
                    e.Handled = true;
                }
            }
        }

        private void panelLogTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       
    }
}
