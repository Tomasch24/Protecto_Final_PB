using Capa_Interfas;
using DocumentFormat.OpenXml.Bibliography;
using System.Windows.Forms;
using Capa_de_Modulos.CACHE;

namespace Capa_Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // TODO: Configuraci�n inicial de la aplicaci�n.
            ApplicationConfiguration.Initialize();

            // TODO: Bucle para manejar el flujo de login y cerrar sesi�n.
            // Si el login es exitoso, se abre el men� principal. Si el men� se cierra,
            // el bucle vuelve a mostrar el login, permitiendo al usuario volver a iniciar sesi�n.
            bool loginExitoso;

            do
            {
                // TODO: 1. Abrir el formulario de Login como una ventana modal.
                Login loginForm = new Login();
                loginForm.ShowDialog();

                loginExitoso = loginForm.DialogResult == DialogResult.OK;

                if (loginExitoso)
                {
                    // TODO: 2. Si el login fue exitoso, mostrar el formulario de Bienvenida.
                    FormBienvenida bienvenidaForm = new FormBienvenida();
                    bienvenidaForm.ShowDialog();

                    // TODO: 3. Determinar qu� men� principal abrir seg�n el rol del usuario.
                    Form mainForm = null;
                    if (LoginUser.Rol == "Gerente")
                    {
                        mainForm = new Pantalla_De_Inicio();
                    }
                    else if (LoginUser.Rol == "Cajera")
                    {
                        mainForm = new Pantalla_Inicio_Cajera();
                    }
                    else
                    {
                        // TODO: Captura de error: Si el rol no es reconocido, se podr�a mostrar un mensaje.
                        MessageBox.Show("Rol de usuario no reconocido. La aplicaci�n se cerrar�.", "Error de Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // El bucle terminar� y la aplicaci�n saldr�.
                        loginExitoso = false;
                    }

                    // TODO: 4. Si se encontr� un formulario principal v�lido, ejecutarlo.
                    if (mainForm != null)
                    {
                        Application.Run(mainForm);
                        // Cuando el formulario principal se cierra, el control vuelve aqu�.
                        // El bucle do-while revisar� la condici�n. Si el usuario cerr� sesi�n
                        // (y la bandera `loginExitoso` se mantiene `true`), el bucle se reinicia.
                        
                    }
                    else
                    {
                        // Si el mainForm es nulo, el login no fue exitoso para continuar
                        loginExitoso = false;
                    }
                }
            } while (loginExitoso); // El bucle se repite si el login fue exitoso y el formulario principal se cerr�.
        }
    }
}