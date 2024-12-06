
using Vehicle_Management.Presentation;

namespace Vehicle_Management
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
            SignUp2 signUp = new SignUp2();
            Application.Run(signUp);   
        }
    }
   
}