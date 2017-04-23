using System;
using System.Collections.Generic;
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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FoodNavigator___Controller.Connection_Controller;
using FoodNavigator___Controller.Server_Connector;

namespace FoodNavigator___View.Password_Windows
{
    /// <summary>
    /// Interaction logic for PasswordRemember.xaml
    /// </summary>
    public partial class PasswordRemember
    {
        public PasswordRemember()
        {
            InitializeComponent();
        }

        private void emailBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            emailLabel.Foreground = regex.IsMatch(emailBox.Text) ? Brushes.LightGreen : Brushes.Red;
        }

        private async  void recorverButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    if (ConnectionController.CheckConnection())
                    {
                        if (captcha.IsChecked != null && captcha.IsChecked.Value)
                        {
                            if (Equals(emailLabel.Foreground, Brushes.LightGreen))
                            {
                                try
                                {
                                    ServerConnector.ServerDownloader($"passwordr/{emailBox.Text}");
                                    MessageBox.Show("If there is account connected with this email address you will get email what to do next.", "FoodNavi - Password recorver", MessageBoxButton.OK, MessageBoxImage.Information);
                                    DialogResult = true;
                                }
                                catch { }
                            }
                            else
                            {
                                MessageBox.Show("Please enter correct email address.", "FoodNavi - Password recorver", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Confirm that you are not a robot.", "FoodNavi - Password recorver", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check your internet connection.", "FoodNavi - Password recorver", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                });
            });
        }
    }
}
