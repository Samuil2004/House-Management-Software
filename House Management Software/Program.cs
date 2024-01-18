using House_Management_Software;

namespace House_Management_Software
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // see https://aka.ms/applicationconfiguration.


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(new MenuPage());
        }
    }
}