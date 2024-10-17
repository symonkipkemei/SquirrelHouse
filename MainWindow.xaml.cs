using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Squirrel;

namespace SquirrrelHouse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddVersionNumber();
            CheckForUpdates();
        }


        private async Task CheckForUpdates()
        {
            using (var manager = new UpdateManager(@"C:\Users\Symon Kipkemei\Desktop\Temp\Releases")) //References the server
            {
                await manager.UpdateApp();
            }
        }

        private void AddVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            string msg = "Hello Welcome.\n Squirrel in the building. On it as well. Hope this works as well";
            string message = $" v.{fileVersionInfo.FileVersion}";

            this.Title += message;
            
            tbGreetings.Text = msg + message;
        }
    }
}