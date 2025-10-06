using DebtsManagementSystem.Data;
using DebtsManagementSystem.Forms;

namespace DebtsManagementSystem
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
            using(var context = new AppDbContext())
            {
                DbInitializer.Initialize(context);
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}