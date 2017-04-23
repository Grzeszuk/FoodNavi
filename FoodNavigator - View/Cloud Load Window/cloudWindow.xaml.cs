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
using FoodNavigator___Controller.Cloud_Controller;

namespace FoodNavigator___View.Cloud_Load_Window
{
    /// <summary>
    /// Interaction logic for CloudWindow.xaml
    /// </summary>
    public partial class CloudWindow : ICloudController
    {
        private readonly CloudController _controller;
        public CloudWindow()
        {
            InitializeComponent();
            _controller = new CloudController(this);
            _controller.LoadSaves();
        }

        public async void CheckCount()
        {
            await Task.Run(() =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    try
                    {
                        loadBox.SelectedItem = loadBox.Items[0];
                    }
                    catch
                    {
                        MessageBox.Show("You don't have saved selections", "FoodNavigator - Cloud load", MessageBoxButton.OK, MessageBoxImage.Information);
                        DialogResult = false;
                    }
                });
            });
        
        }

        public void AddSelectionToGrid(StackPanel panel)
        {
            loadBox.Items.Add(panel);
        }

        private async void loadButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    DialogResult = _controller.LoadSelection((StackPanel)loadBox.SelectedItem);
                });
            });
        }

        private async void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    var result = MessageBox.Show("Are you sure to delete selection?","FoodNavigator - Cloud delete",MessageBoxButton.YesNo,MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        _controller.DeleteSelection((StackPanel)loadBox.SelectedItem);
                        loadBox.Items.Remove(loadBox.SelectedItem);
                    }  

                    if (loadBox.Items.Count == 0)
                        DialogResult = false;

                });
            });
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
