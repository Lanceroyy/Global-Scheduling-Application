using Project_C969_Appointment_App.Database;

namespace Project_C969_Appointment_App
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

            DatabaseConnection.startConnection();
            Application.Run(new LoginScreen());
            DatabaseConnection.closeConnection();
        }
    }
}