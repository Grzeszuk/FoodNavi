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
 using FoodNavigator___Controller.Connection_Controller;
 using FoodNavigator___Controller.Welcome_Controller;
using FoodNavigator___Controller.Window_Controller;
using Page = System.Windows.Controls.Page;

namespace FoodNavigator___View.Welcome_page
{
    /// <summary>
    /// Interaction logic for WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : Page
    {
        private readonly WelcomeController _controller;
        public WelcomePage()
        {
            _controller=new WelcomeController();
            InitializeComponent();
            loadStuff();
        }

        public void loadStuff()
        {
            usernameBox.TextWrapping = TextWrapping.NoWrap;

            if (!ConnectionController.CheckConnection())
            {
                connectionLabel.Content = "Disconnected from TwoNoobs Azure Cloud™";
            }
        }

        private async void loginButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run((Action)(() =>
            {
                this.Dispatcher.Invoke((Action) (() =>
                {
                    if (ConnectionController.CheckConnection())
                    {
                        if (usernameBox.Text.Length > 4 && passwordBox.Password.Length > 7)
                        {
                            if (_controller.Login(usernameBox.Text, passwordBox.SecurePassword))
                            {
                                WindowController.ChangePage(FoodNavigator___Controller.Window_Controller.Page.Search);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter your username and password.", "FoodNavi - Login problem",
                                MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check your internet connection.", "FoodNavi - Login",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                 
                }));         
            }));
        }

        private async void makeButton_Click(object sender, RoutedEventArgs e)
        {
                await Task.Run(() =>
                {
                    this.Dispatcher.Invoke((Action)(() =>
                    {
                        if (ConnectionController.CheckConnection())
                        {
                            WindowController.ShowPopUp(PopUps.Register);
                        }
                        else
                        {
                            MessageBox.Show("Please check your internet connection", "FoodNavi - Register",
                                MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }));
                });      
        }

        private void usernameBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            LabelColors();
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            LabelColors();
        }

        private void LabelColors()
        {
            nameLabel.Foreground = usernameBox.Text.Length > 4 ? Brushes.LightGreen : Brushes.Red;
            passwordLabel.Foreground = passwordBox.Password.Length > 7 ? Brushes.LightGreen : Brushes.Red;

            if(nameLabel.Foreground.Equals(Brushes.LightGreen) && (passwordLabel.Foreground.Equals(Brushes.LightGreen)))
            {
                loginLabel.Foreground = Brushes.LightGreen;
            }
            else
            {
                loginLabel.Foreground = Brushes.Red;
            }
        }

        private void loginButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.Enter) return;
            MessageBox.Show("x", "x");
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                loginButton_Click(sender, e);
            }
        }

        private void passwordRecorvery_Click(object sender, RoutedEventArgs e)
        {
            WindowController.ShowPopUp(PopUps.Passwordr);
        }
    }
}
