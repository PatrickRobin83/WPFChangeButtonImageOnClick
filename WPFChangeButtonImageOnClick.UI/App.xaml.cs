using System.Windows;
using WPFChangeButtonImageOnClick.UI.ViewModels;

namespace WPFChangeButtonImageOnClick.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Overrides of Application

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainWindowViewModel()
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        #endregion
    }
}