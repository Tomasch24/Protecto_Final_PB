using Capa_Interfas;
using OfficeOpenXml;

namespace Capa_Presentacion
{
    //solo para enviar comit
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
            ExcelPackage.License.SetNonCommercialOrganization("SistemaEvaluacionesApp (Uso No Comercial)");
            ApplicationConfiguration.Initialize();
            Application.Run(new Reporte());
        }
    }
}