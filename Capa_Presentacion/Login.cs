﻿using Capa_Interfas;
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
            if (txtUser.Text != "Usuario")
            {
                if (txtPassword.Text != "Contraseña")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUser.Text, txtPassword.Text);
                    if (validLogin == true)
                    {
                        Pantalla_De_Inicio mainMenu = new Pantalla_De_Inicio();
                        MessageBox.Show("Bienvenido/a  " + LoginUser.Nombre + " " + LoginUser.Apellido);
                        mainMenu.Show();
                        mainMenu.FormClosed += LogOut; // Asigna el evento FormClosed para manejar el cierre del formulario
                        this.Hide(); // Oculta el formulario de login después de iniciar sesión
                    }
                    else
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



































        private void panelLogTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       
    }
}
