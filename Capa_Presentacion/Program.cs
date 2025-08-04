using Capa.Presentacion;
using Capa_Interfas;
using DocumentFormat.OpenXml.Bibliography;

namespace Capa_Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

<<<<<<< Updated upstream
            Application.Run(new DashGrafico());
=======


            Application.Run(new Clientes());

>>>>>>> Stashed changes

        }
    }
}