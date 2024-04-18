using MySqlConnector;
namespace EventManagementSystem
{
    internal static class Program
    {
        public static Database db = Database.GetInstance("localhost", "3306", "root", "1234", "eventmng");

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginPage());

        }
    }
}