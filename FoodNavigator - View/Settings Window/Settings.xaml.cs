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
using System.Windows.Shapes;
using FoodNavigator___Controller.Connection_Controller;
using FoodNavigator___Controller.Settings_Controller;
using FoodNavigator___Controller.Window_Controller;
using _2.FoodNavigator___Model.Login;
using Page = FoodNavigator___Controller.Window_Controller.Page;

namespace FoodNavigator___View.Settings_Window
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : ISettingsController
    {
        private readonly SettingsController _controller;
        public Settings()
        {
            InitializeComponent();
            _controller = new SettingsController(this);
            loadStuff();
        }

        private void loadStuff()
        {
            usernameLabel.Content = LoginData.Username;
            if (LoginData.Photo == "false") return;
            BitmapImage userphoto = new BitmapImage();
            userphoto.BeginInit();
            userphoto.UriSource = new Uri(LoginData.Photo);
            userphoto.EndInit();
            userPhoto.Source = userphoto;
        }
        private void signOut_Click(object sender, RoutedEventArgs e)
        {
            WindowController.ChangePage(Page.Welcome);
          this.Close();
        }

        private async void picButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    if (PhotoLabel.Foreground == Brushes.LightGreen)
                    {
                        if (ConnectionController.CheckConnection())
                        {
                            try
                            {
                                SettingsConnector.Picture(picBox.Text);
                                MessageBox.Show("Picture changed. Please login again to see changes.", "FoodNavi - Picture change");

                            }
                            catch
                            {
                                MessageBox.Show("Invalid url.", "FoodNavi - Picture change");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please check your internet connection.", "FoodNavi - Picture change");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid url.", "FoodNavi - Picture change");
                    }

                });
            });
        }

        private async void passButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    if (Equals(PasswordLabel.Foreground, Brushes.LightGreen) && Equals(PasswordCheck.Foreground, Brushes.LightGreen))
                    {
                        if (ConnectionController.CheckConnection())
                        {
                            try
                            {
                                SettingsConnector.Password(passBox.Password);
                                MessageBox.Show("Password changed. Please check your email to see what to do next.", "FoodNavi - Password change",MessageBoxButton.OK,MessageBoxImage.Information);
                                WindowController.ChangePage(Page.Welcome);
                                this.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Password not changed. Please try again.", "FoodNavi - Password change", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please check your internet connection.", "FoodNavi - Password change", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter password and confrim password.", "FoodNavi - Password change", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                });
            });
        }

        private void passBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
           _controller.changePasswordColor(passBox.Password);
        }

        private void passConfrimBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            _controller.changeConfirmColor(passBox.Password,passConfrimBox.Password);
        }

        private void picBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _controller.changePhotoColor(picBox.Text);
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

        public void changePhotoColor(SolidColorBrush color)
        {
            PhotoLabel.Foreground = color;
        }

        public void changeCountColor(SolidColorBrush color)
        {
            count.Foreground = color;
        }
    }
}
