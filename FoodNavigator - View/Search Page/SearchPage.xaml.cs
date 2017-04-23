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
using FoodNavigator___Controller.Cloud_Controller;
using FoodNavigator___Controller.Connection_Controller;
using FoodNavigator___Controller.Search_Controller;
using FoodNavigator___Controller.Server_Connector;
    using FoodNavigator___Controller.Window_Controller;
    using Page = System.Windows.Controls.Page;
using _2.FoodNavigator___Model.Login;
using _2.FoodNavigator___Model.Selected_Values;

namespace FoodNavigator___View.Search_page
{
    /// <summary>
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page,ISearchController
    {
        private readonly SearchController _controller;
        public SearchPage()
        {
            InitializeComponent();

            _controller = new SearchController(this);
            _controller.loadView();

           loadStuff();       
        }

        private void loadStuff()
        {
            foodBox.SelectedItem = foodBox.Items[0];
            usernameLabel.Content = LoginData.Username;
            transportBox.IsBannerEnabled = false;

            if (LoginData.Photo != "false")
            {
                BitmapImage userphoto = new BitmapImage();
                userphoto.BeginInit();
                userphoto.UriSource = new Uri(LoginData.Photo);
                userphoto.EndInit();
                userPhoto.Source = userphoto;
            }

            try
            {
                CityBox.Text = SelectedValues.Location;
                StreetBox.Text = SelectedValues.Street;
                slider.Value = SelectedValues.Radius;
                CityBox.Text = SelectedValues.Location;
                foodBox.SelectedIndex = SelectedValues.FoodIndex;

                if (SelectedValues.FoodIndex + 2 >= foodBox.Items.Count - 1)
                    foodBox.ScrollIntoView(SelectedValues.FoodIndex + 1 < foodBox.Items.Count - 1
                        ? foodBox.Items[SelectedValues.FoodIndex + 1]
                        : foodBox.Items[SelectedValues.FoodIndex]);
                else
                    foodBox.ScrollIntoView(foodBox.Items[SelectedValues.FoodIndex + 2]);

                foodBox.UpdateLayout();
                transportBox.SelectedIndex = SelectedValues.TransportIndex;
            }
            catch 
            {

            }
        }

        public void addTypeToBox(Label arg)
        {
            foodBox.Items.Add(arg);
        }

        public void addTransportToBox(Label arg)
        {
            transportBox.Items.Add(arg);
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(distanceLabel!=null)
                distanceLabel.Content =$"distance: {Math.Ceiling(slider.Value)}KM";

            if (distance != null)
                distance.Content = $"{Math.Ceiling(slider.Value)}KM";
        }

        private void foodBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (food == null) return;
            var result = (Label)foodBox.SelectedItem;
            food.Content = result.Content;
        }

        private void transportBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (type == null) return;
            var result = (Label) transportBox.SelectedItem;
            type.Content = result.Content;
        }

        private void signOut_Click(object sender, RoutedEventArgs e)
        {
            WindowController.ChangePage(FoodNavigator___Controller.Window_Controller.Page.Welcome);
        }

        private void CityBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(CityBox.Text.Length>0)
            city.Content = CityBox.Text;
            else
            {
                city.Content = "{fill in city}";
            }
        }

        private async void searchButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    if (ConnectionController.CheckConnection())
                    {
                        if (CityBox.Text.Length>0)
                        {
                            var result = (Label)foodBox.SelectedItem;
                            var result2 = (Label)transportBox.SelectedItem;

                            SelectedValues.Location = CityBox.Text;
                            SelectedValues.Street = StreetBox.Text;
                            SelectedValues.Radius = Convert.ToInt32(Math.Ceiling(slider.Value));
                            SelectedValues.Type = result.Content.ToString();
                            SelectedValues.Transport = result2.Content.ToString();

                            var response = _controller.Search();

                            if (!response.Contains("no result"))
                            {
                                SearchValues.Json = response;
                                WindowController.ChangePage(FoodNavigator___Controller.Window_Controller.Page.Result);
                            }
                            else
                            {
                                MessageBox.Show("No results. Please change your query.", "FoodNavi - Search problem", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please fill in city first.", "FoodNavi - Search", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check your internet connection.", "FoodNavi - Search", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                });
            });
        
        }

        private async void loadButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    if (ConnectionController.CheckConnection())
                    {
                        if (!WindowController.ShowPopUp(PopUps.Load)) return;
                        CityBox.Text = SelectedValues.Location;
                        StreetBox.Text = SelectedValues.Street;
                        slider.Value = SelectedValues.Radius;
                        CityBox.Text = SelectedValues.Location;
                        foodBox.SelectedIndex = SelectedValues.FoodIndex;

                        if (SelectedValues.FoodIndex + 2 >= foodBox.Items.Count - 1)
                            foodBox.ScrollIntoView(SelectedValues.FoodIndex + 1 < foodBox.Items.Count - 1
                                ? foodBox.Items[SelectedValues.FoodIndex + 1]
                                : foodBox.Items[SelectedValues.FoodIndex]);
                        else
                            foodBox.ScrollIntoView(foodBox.Items[SelectedValues.FoodIndex + 2]);

                        foodBox.UpdateLayout();
                        transportBox.SelectedIndex = SelectedValues.TransportIndex;

                    }
                    else
                    {
                        MessageBox.Show("Please check your internet connection,", "FoodNavi - Cloud load",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                    }              
                });
            });
          
        }

        private async void saveButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    if (ConnectionController.CheckConnection())
                    {
                        if (CityBox.Text.Length > 0)
                        {
                            var location = StreetBox.Text.Length > 0 ? $"{CityBox.Text};{StreetBox.Text}" : CityBox.Text;

                            CloudConnector.Save((Label)foodBox.SelectedItem, (Label)transportBox.SelectedItem, location,
                                Convert.ToInt32(Math.Ceiling(slider.Value)),foodBox.SelectedIndex,transportBox.SelectedIndex);
                        }
                        else
                        {
                            MessageBox.Show("Please fill in your city.", "FoodNavi - Search", MessageBoxButton.OK,
                                MessageBoxImage.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check your internet connection.", "FoodNavi - Cloud save",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                });
            });
        
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            WindowController.ChangePage(FoodNavigator___Controller.Window_Controller.Page.Search);
        }

        private async void random(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    var random = new Random();

                    foodBox.SelectedIndex = random.Next(0,foodBox.Items.Count-1);
                    transportBox.SelectedIndex = random.Next(0, transportBox.Items.Count - 1);
                    slider.Value = random.Next(0, 10);

                });
            });
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
