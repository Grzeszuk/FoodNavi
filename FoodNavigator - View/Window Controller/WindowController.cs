using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FoodNavigator___View.Cloud_Load_Window;
using FoodNavigator___View.Details_Window;
using FoodNavigator___View.Help_Window;
using FoodNavigator___View.Main_Help_Window;
using FoodNavigator___View.Main_window;
using FoodNavigator___View.Password_Windows;
using FoodNavigator___View.Register_window;
using FoodNavigator___View.Result_page;
using FoodNavigator___View.Search_page;
using FoodNavigator___View.Settings_Window;
using FoodNavigator___View.Welcome_page;

namespace FoodNavigator___Controller.Window_Controller
{
    public enum Page
    {
        Welcome,
        Search,
        Result
    };

    public enum PopUps
    {
        Register,
        Load,
        Details,
        WelcomeHelp,
        SearchHelp,
        ResultHelp,
        Passwordr,
        Passwordc,
        Settings,
    };

    public static class WindowController
    {
        private static MainWindow _mainPage;
        public static void StartApplication()
        { 
                _mainPage = new MainWindow();
                ChangePage(Page.Welcome);
                _mainPage.ShowDialog();
                _mainPage.Close();
        }

        public static void ChangePage(Page arg)
        {
            _mainPage.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            switch(arg)
            {
                case Page.Welcome:
                    _mainPage.Content = new WelcomePage();
                    _mainPage.Title = "FoodNavi - Welcome";
                    _mainPage.Name = "Welcome";
                    _mainPage.ResizeMode = System.Windows.ResizeMode.CanMinimize;
                    _mainPage.WindowState = System.Windows.WindowState.Maximized;
                    break;

                case Page.Search:
                    _mainPage.Content = new SearchPage();
                    _mainPage.Title = "FoodNavi - Search Options";
                    _mainPage.Name = "Search";
                    _mainPage.ResizeMode = System.Windows.ResizeMode.CanMinimize;
                    _mainPage.WindowState = System.Windows.WindowState.Maximized;
                    break;

                case Page.Result:
                    _mainPage.Content = new ResultPage();
                    _mainPage.Title = "Result";
                    _mainPage.ResizeMode = System.Windows.ResizeMode.CanMinimize;
                    _mainPage.WindowState = System.Windows.WindowState.Maximized;
                    break;

                default:
                    break;
            }
        }

        public static bool ShowPopUp(PopUps arg)
        {
            Window popUpWindow = null;

            switch (arg)
            {
                case PopUps.Register:
                    popUpWindow = new RegisterWindow();
                    popUpWindow.Title = "FoodNavi - Register";
                    break;

                case PopUps.Load:
                    popUpWindow = new CloudWindow();
                    popUpWindow.Title = "FoodNavi - Load from cloud";
                    break;

                case PopUps.Details:
                    popUpWindow = new DetailsWindow();
                    popUpWindow.Title = "FoodNavi - Restaurant details";
                    break;

                case PopUps.WelcomeHelp:
                    popUpWindow = new MainHelp();
                    popUpWindow.Title = "FoodNavi - Login Help";
                    break;

                case PopUps.SearchHelp:
                    popUpWindow = new SearchHelp();
                    popUpWindow.Title = "FoodNavi - Search Help";
                    break;

                case PopUps.ResultHelp:
                    popUpWindow = new ResultHelp();
                    popUpWindow.Title = "FoodNavi - Result Help";
                    break;

                case PopUps.Passwordr:
                    popUpWindow = new PasswordRemember();
                    popUpWindow.Title = "FoodNavi - Password remember";
                    break;

                case PopUps.Passwordc:
                    popUpWindow = new PasswordChange();
                    popUpWindow.Title = "FoodNavi - Password change";
                    break;

                case PopUps.Settings:
                    popUpWindow = new Settings();
                    popUpWindow.Title = "FoodNavi - Account settings";
                    break;

                default:
                    break;
            }

            if (popUpWindow != null)
            {
                popUpWindow.ResizeMode = System.Windows.ResizeMode.NoResize;
                popUpWindow.WindowState = System.Windows.WindowState.Normal;
                popUpWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                return popUpWindow.ShowDialog().Value;
            }
            else
            {
                MessageBox.Show("Application error please contact us about that problem", "FoodNavigator - Error",MessageBoxButton.OK,MessageBoxImage.Error);
                return false;
            }
        }

        public static string ReturnCurrentPage()
        {
            return _mainPage.Name;
        }

        public static void CloseApplication()
        {
            Application.Current.Shutdown();
        }
    }
}
