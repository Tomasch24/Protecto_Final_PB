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
            // TODO: Configuración inicial de la aplicación.
            ApplicationConfiguration.Initialize();

            // TODO: Bucle para manejar el flujo de login y cerrar sesión.
            // Si el login es exitoso, se abre el menú principal. Si el menú se cierra,
            // el bucle vuelve a mostrar el login, permitiendo al usuario volver a iniciar sesión.
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

                    // TODO: 3. Determinar qué menú principal abrir según el rol del usuario.
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
                        // TODO: Captura de error: Si el rol no es reconocido, se podría mostrar un mensaje.
                        MessageBox.Show("Rol de usuario no reconocido. La aplicación se cerrará.", "Error de Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // El bucle terminará y la aplicación saldrá.
                        loginExitoso = false;
                    }

                    // TODO: 4. Si se encontró un formulario principal válido, ejecutarlo.
                    if (mainForm != null)
                    {
                        Application.Run(mainForm);
                        // Cuando el formulario principal se cierra, el control vuelve aquí.
                        // El bucle do-while revisará la condición. Si el usuario cerró sesión
                        // (y la bandera `loginExitoso` se mantiene `true`), el bucle se reinicia.
                        
                    }
                    else
                    {
                        // Si el mainForm es nulo, el login no fue exitoso para continuar
                        loginExitoso = false;
                    }
                }
            } while (loginExitoso); // El bucle se repite si el login fue exitoso y el formulario principal se cerró.
        }
    }
}