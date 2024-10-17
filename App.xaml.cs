using System.Configuration;
using System.Data;
using System.Windows;

namespace SquirrrelHouse
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Optionally show the MainWindow after the startup logic
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }

}
