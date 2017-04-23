using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FoodNavigator___Controller.Connection_Controller;
using FoodNavigator___Controller.Data_Encrypter;
using FoodNavigator___Controller.Register_Controller;
using FoodNavigator___Controller.Server_Connector;
using MahApps.Metro.Controls;

namespace FoodNavigator___View.Register_window
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : IRegisterController
    {
        private readonly RegisterController _controller;
        public RegisterWindow()
        {
            InitializeComponent();
            _controller = new RegisterController(this);
        }
        private async void registerButton_Click(object sender, RoutedEventArgs e)
        {
            if (ConnectionController.CheckConnection())
            {
                if (Equals(UserLabel.Foreground, Brushes.LightGreen) &&
                    ReferenceEquals(PasswordLabel.Foreground, Brushes.LightGreen) &&
                    ReferenceEquals(PasswordLabel2.Foreground, Brushes.LightGreen) &&
                    Equals(MailLabel.Foreground, Brushes.LightGreen) && !Equals(PhotoLabel.Foreground, Brushes.Red))
                {
                    if (Check.IsChecked != null && Check.IsChecked.Value)
                    {
                        await Task.Run(() =>
                        {
                            try
                            {
                                this.Dispatcher.Invoke((Action) (() =>
                                {
                                    var password = Uri
                                        .EscapeDataString(
                                            Enrypter.Encrypt(passwordBox.Password, "ifnerjf^$^jmernvjeaj"))
                                        .Replace('%', '&');


                                    var response =
                                        ServerConnector.ServerDownloader(
                                            $"register/{Uri.EscapeDataString(usernameBox.Text)}/{password}/{emailBox.Text}");

                                    if (Equals(PhotoLabel.Foreground, Brushes.LightGreen))
                                    {
                                        var photourl = photoURL.Text != ""
                                            ? Uri.EscapeDataString(photoURL.Text).Replace("%", "^")
                                            : "no photo";
                                        ServerConnector.ServerDownloader(
                                            $"photo/{Uri.EscapeDataString(usernameBox.Text)}/{photourl}");
                                    }


                                    if (response.Contains("true"))
                                    {
                                        MessageBox.Show(
                                            "Registration is completed. Please check your mail to activate your account.",
                                            "FoodNavi - Register", MessageBoxButton.OK, MessageBoxImage.Information);
                                        this.Hide();
                                    }
                                    else if(response.Contains("email"))
                                    {
                                        MessageBox.Show("Email is already used.", "FoodNavi - Register",
                                            MessageBoxButton.OK, MessageBoxImage.Information);
                                        emailBox.Clear();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Username is already used.", "FoodNavi - Register",
                                            MessageBoxButton.OK, MessageBoxImage.Information);
                                        usernameBox.Clear();
                                    }
                                }));
                            }
                            catch
                            {
                                MessageBox.Show("Please check your internet connection.", "FoodNavi - Register",
                                    MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        });
                    }
                    else
                    {
                        MessageBox.Show("Please check that you are not a robot.", "FoodNavi - Register",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Please fill all values. All hints should be green to register.",
                        "FoodNavi - Register", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection", "FoodNavigator - Register",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void usernameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           _controller.changeUserColor(usernameBox.Text);
        }
        private void emailBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           _controller.changeEmailColor(emailBox.Text);      
        }
        private void confirmPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
          _controller.changeConfirmColor(passwordBox.Password,confirmPassword.Password);
        }
        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            _controller.changePasswordColor(passwordBox.Password);
        }
        private void photoURL_TextChanged(object sender, TextChangedEventArgs e)
        {
           _controller.changePhotoColor(photoURL.Text);
        }
        public void changeUserColor(SolidColorBrush color)
        {
            NameLabel.Foreground = color;
            UserLabel.Foreground = color;
        }
        public void changePasswordColor(SolidColorBrush color)
        {
            PasswordLabel2.Foreground = color;
            PasswordCheck.Foreground = color;
        }
        public void changeConfirmColor(SolidColorBrush color)
        {
            PasswordLabel.Foreground = color;
        }
        public void changeBigColor(SolidColorBrush color)
        {
            BigLetter.Foreground = color;
        }
        public void changeSmallColor(SolidColorBrush color)
        {
            SmallLetter.Foreground = color;
        }
        public void changeSpecialColor(SolidColorBrush color)
        {
            Special.Foreground = color;
        }
        public void changeNumberColor(SolidColorBrush color)
        {
            Number.Foreground = color;
        }
        public void changeEmailColor(SolidColorBrush color)
        {
            MailLabel.Foreground = color;
        }
        public void changePhotoColor(SolidColorBrush color)
        {
            PhotoLabel.Foreground = color;
        }
        public void changeCountColor(SolidColorBrush color)
        {
            count.Foreground = color;
        }

        private async void TwoNoobs(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
               this.Dispatcher.Invoke(() =>
                {
                    System.Diagnostics.Process.Start($"https://web.facebook.com/Grzeszuk");
                });
            });
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                registerButton_Click(sender, e);
            }
        }
    }
}
