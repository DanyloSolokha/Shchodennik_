using System.ComponentModel;

namespace Schodennik
{
    internal static class Program
    {
        public static string BaseDirectory = GetProjectRootDirectory();

        private static mainWindow _mainWindow;

        public static mainWindow MainWindow
        {
            get { return _mainWindow; }
        }
        
        
        
        
        
        
        
        
        // <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            _mainWindow = new mainWindow();
            Application.Run(_mainWindow);
        }

        private static string GetProjectRootDirectory()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var directoryInfo = new DirectoryInfo(currentDirectory);

            for (int i = 0; i < 3; i++)
            {
                directoryInfo = directoryInfo.Parent;
            }

            return directoryInfo.FullName;
        }
    }
}