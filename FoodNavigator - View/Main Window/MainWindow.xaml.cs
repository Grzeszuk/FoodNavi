using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FoodNavigator___Controller.Window_Controller;
using MahApps.Metro.Controls;

namespace FoodNavigator___View.Main_window
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TwoNoobs(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://web.facebook.com/Grzeszuk");
        }

        private void DisplayHelp(object sender, RoutedEventArgs e)
        {
            switch (WindowController.ReturnCurrentPage())
            {
                case "Welcome":
                    WindowController.ShowPopUp(PopUps.WelcomeHelp);
                    break;

                case "Search":
                    WindowController.ShowPopUp(PopUps.SearchHelp);
                    break;

                case "Result":
                    WindowController.ShowPopUp(PopUps.ResultHelp);
                    break;

                default:
                    break;
            }
        }

        private void SettingsWindow(object sender, RoutedEventArgs e)
        {
            if (WindowController.ReturnCurrentPage() != "Welcome")
                WindowController.ShowPopUp(PopUps.Settings);
            else
            {
                MessageBox.Show("Please login first to see your account settings", "FoodNavi - Account settings.",MessageBoxButton.OK,MessageBoxImage.Information);
;            }
        }
    }
}
