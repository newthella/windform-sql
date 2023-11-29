using System.Data.Common;

namespace CRUD_bidang
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Model model = new Model();
            model.DbConnection.Open();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(model));
            model.DbConnection.Close();
        }
    }
}