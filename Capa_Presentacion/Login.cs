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
        // TODO: SECCIÓN: Constructor
        public Login()
        {
            InitializeComponent();
            personalizar();
        }

        // TODO: SECCIÓN: Eventos de botones del LoginForm
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
            // Verifica si los campos de usuario y contraseña no están vacíos
            if (txtUser.Text != "Usuario")
            {
                if (txtPassword.Text != "Contraseña")
                {
                    this.Hide();
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUser.Text, txtPassword.Text);

                    if (validLogin)
                    {

                        // TODO: Si el login es exitoso, establece el DialogResult y cierra el formulario.
                        this.DialogResult = DialogResult.OK;
                        this.Close();

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
            lblError.Text = "     " + msg;
            lblError.Visible = true;
        }

        // TODO: Este método ya no será necesario en el Login, pues el formulario se cierra por completo.
        // La lógica de "cerrar sesión" se manejará en los formularios principales y en el Program.cs.
        private void LogOut(object sender, FormClosedEventArgs e)
        {

        }




        #endregion



        #region eventos para mover el formulario

        // DllImport para capturar el mouse y enviar mensajes de la ventana

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void panelLogTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // TODO: SECCIÓN: Personalización de controles
        private void personalizar()
        {
            txtUser.AutoSize = false;
            txtUser.Size = new Size(350, 35);
            txtPassword.AutoSize = false;
            txtPassword.Size = new Size(350, 35);
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;
            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle buttonRectangle = btn.ClientRectangle;
            buttonRectangle.Inflate(0, 30);
            buttonPath.AddEllipse(buttonRectangle);
            btn.Region = new Region(buttonPath);
        }

        // TODO: SECCIÓN: Eventos de Teclado
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUser.Focused)
                {
                    txtPassword.Focus();
                    e.Handled = true;
                }
                else if (txtPassword.Focused)
                {
                    btnLogin_Click(sender, e);
                    e.Handled = true;
                }
            }
        }


        // TODO: SECCIÓN: Eventos adicionales
        private void panelLogTitulo_Paint(object sender, PaintEventArgs e) { }
        private void Login_Load(object sender, EventArgs e) { }

        private void panelLogTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


    }
}