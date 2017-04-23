using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using FoodNavigator_Model;
using FoodNavigator___Controller.Server_Connector;
using FoodNavi___Model.Restaurant;
using GMap.NET;
using MaterialDesignThemes.Wpf;
using Newtonsoft.Json;
using _2.FoodNavigator___Model.Restaurant_Model;
using _2.FoodNavigator___Model.Selected_Values;
using Label = System.Windows.Controls.Label;

namespace FoodNavigator___Controller.Result_Controller
{
    public class ResultController
    {
        private readonly IResultController _view;

        private List<RestaurantAdapter.Result> _restaurantModels;
        public ResultController(IResultController view)
        {
            _view = view;
            _restaurantModels = new List<RestaurantAdapter.Result>();
        }

        public void LoadView()
        {
            var restaurant = JsonConvert.DeserializeObject<RestaurantAdapter.Informations>(SearchValues.Json);

            foreach (var local in restaurant.results)
            {
                _restaurantModels.Add(local);

                var openlabel = local.opening_hours.open_now ? "Open: Yes" : "Open: No";

                var converter = new System.Windows.Media.BrushConverter();

                var marker = new GMap.NET.WindowsPresentation.GMapMarker(new PointLatLng(local.geometry.location.lat,
                    local.geometry.location.lng));

                if (local.opening_hours.open_now)
                {
                    marker.Shape = new Ellipse
                    {
                        Fill = Brushes.Green,
                        Stroke = Brushes.White,
                        Width = 15,
                        Height = 15,
                        StrokeThickness = 1.5
                    };
                }
                else
                {
                    marker.Shape = new Ellipse
                    {
                        Fill = Brushes.Crimson,
                        Stroke = Brushes.White,
                        Width = 15,
                        Height = 15,
                        StrokeThickness = 1.5
                    };
                }

                var rating = new RatingBar() {Value = Convert.ToInt32(local.rating)};

                var info = new StackPanel();
                info.Margin = new Thickness(0, 0, 0, 5);
                info.Children.Add(new Label() {Content = local.name, Background = Brushes.LightGreen});
                info.Children.Add(new Label()
                {
                    Content = local.formatted_address.Split(',')[0],
                    Background = (Brush) converter.ConvertFromString("#CC494949"),
                    Foreground = Brushes.White
                });
                info.Children.Add(new Label()
                {
                    Content = openlabel,
                    Background = (Brush) converter.ConvertFromString("#CC494949"),
                    Foreground = Brushes.White
                });
                info.Children.Add(new Label()
                {
                    Content = rating,
                    Background = Brushes.DarkGray,
                    Foreground = Brushes.White
                });

                _view.AddRestaurantToGrid(
                    new RestaurantMapPointer(local.name, local.opening_hours.open_now, local.geometry.location.lat,
                        local.geometry.location.lng), info, marker);

                checkAdditional();

            }
        }

        private void checkAdditional()
        {
            string check;
            try
            {
                check = SearchValues.Json.Split(',')[1].Split(':')[1].Remove(0, 1).Replace('"', ' ').TrimStart().TrimEnd();

                if (check.Length<30)
                {
                    throw new Exception();
                }
            }
            catch
            {
                check = null;
            }

            if (check == null) return;
            SearchValues.Json = ServerConnector.GoogleDownloader($"https://maps.googleapis.com/maps/api/place/textsearch/json?query={{SelectedValues.Location}}+in+{{SelectedValues.Type}}&radius={{SelectedValues.Radius*1000}}&key=AIzaSyCeB6wF-ddWKB2O_BXHLIoHZdqFdOdpPbY&pagetoken={check}");
            LoadView();
        }

        public void SelectionChanged(int selectedIndex)
        {
            SelectedRestaurant.Reference = _restaurantModels[selectedIndex].place_id;
        }

        public RestaurantAdapter.Result ZoomTo(int listBoxSelectedIndex)
        {
            return _restaurantModels[listBoxSelectedIndex];
        }
    }
}
