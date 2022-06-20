using DataLayer;
using ServiceLayer;
using BusinessLayer;
namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //User spas = new User("Spas", "pass", "email", true);
            //UserContext ctx = new UserContext(ServiceLayer.MVRSystemDBManager.CreateContext());
            //ctx.Create(spas);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LogIn());
        }
    }
}