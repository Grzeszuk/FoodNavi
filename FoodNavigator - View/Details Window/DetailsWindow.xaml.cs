using System;
using System.Collections.Generic;
using System.IO;
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
using FoodNavigator___Controller.Details_Controller;
using _2.FoodNavigator___Model.Restaurant_Model;
using _2.FoodNavigator___Model.Selected_Values;

namespace FoodNavigator___View.Details_Window
{
    /// <summary>
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow
    {
        private readonly DetailsController _controller;
        private RestaurantDetailModel _details;
        public DetailsWindow()
        {
            InitializeComponent();
            _controller=new DetailsController();
            LoadValues();
        }

        public void LoadValues()
        {

            _details = _controller.loadDetails();
            restaurantName.Content = _details.name;
            restaurantAddress.Content = $"Address: {_details.address.Split(',')[0]},{_details.address.Split(',')[1]}";
            restaurantOpen.Content = _details.open;
            restaurantOpenText.Content = _details.openHours;
            restaurantRatingBar.Value = Convert.ToInt32(_details.rating);
            restaurantPhone.Content = $"Phone: {_details.phone}";


            BitmapImage photo = new BitmapImage();
            photo.BeginInit();
            photo.UriSource = new Uri("https://maps.googleapis.com/maps/api/place/photo?maxwidth=400&photoreference=" + _details.photo + "&key=AIzaSyCeB6wF-ddWKB2O_BXHLIoHZdqFdOdpPbY");
            photo.EndInit();
            backgroundPhoto.Source = photo;


        }

        private async void navigateButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                string code;
        
                switch (SelectedValues.Transport)
                {
                    case "Walking":
                        code = "data=!4m2!4m1!3e2";
                        break;

                    case "Driving":
                        code = "data= 4m2!4m1!3e0";
                        break;

                    case "Cycling":
                        code = "data=!4m2!4m1!3e1";
                        break;

                    case "Public transport":
                        code = "data=!4m2!4m1!3e3";
                        break;

                    default:
                        code = "data=!4m2!4m1!3e0";
                        break;

                }

                System.Diagnostics.Process.Start(SelectedValues.Street != null
                    ? $"https://www.google.pl/maps/dir/{SelectedValues.Location},{SelectedValues.Street}/{_details.address}/{code}"
                    : $"https://www.google.pl/maps/dir/{SelectedValues.Location}/{_details.address}/{code}");
            });
        }

        private async void openButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                if (_details.website != "false")
                {
                    System.Diagnostics.Process.Start(_details.website);
                }
                else
                System.Diagnostics.Process.Start($"https://www.google.com/search?q={_details.name} {SelectedValues.Location}");
            });
        }
    }
}
