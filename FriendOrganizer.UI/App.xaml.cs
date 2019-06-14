using System.Windows;
using Autofac;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.Startup;
using FriendOrganizer.UI.ViewModel;

namespace FriendOrganizer.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {

            var boostrapper = new Bootstrapper();
            var container = boostrapper.Bootstrap();

            // without IOC
            //var mainWindow = new MainWindow(
            //    new MainViewModel(
            //        new FriendDataService()
            //    )
            //);

            // with IOC
            var mainWindow = container.Resolve<MainWindow>();

            mainWindow.Show();
        }
    }
}
