using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using FoodNavigator___Controller.Server_Connector;
using _2.FoodNavigator___Model.Selected_Values;

namespace FoodNavigator___Controller.Search_Controller
{
  
    public class SearchController
    {
        private readonly ISearchController _view;

        public SearchController(ISearchController view)
        {
            _view = view;
        }

        public void loadView()
        {
            addTypes();
            addTransport();
        }

        private void addTypes()
        { 
            var converter = new System.Windows.Media.BrushConverter();
            var typesList = new List<string>()
            {
                ("Burgers"),
                ("Doner kebab"),
                ("Pizza"),
                ("Fried chicken"),
                ("Coffee"),
                ("Drinks"),
                ("Ice creams"),
                ("African"),
                ("Bulgarian"),
                ("Chinese"),
                ("French"),
                ("Greek"),
                ("Indian"),
                ("Italian"),
                ("Japanese"),
                ("Jewish"),
                ("Native American"),
                ("Russian"),
                ("Turkish"),
                ("Fastfood"),
                ("Streetfood"),
                ("Food trucks"),
                ("Vegetarian food"),
                ("Healthy food"),

            };

            foreach (var type in typesList)
            {
                _view.addTypeToBox(new Label()
                { Content = type,
                    Background = (Brush)converter.ConvertFromString("#CC494949"),
                    Foreground =  Brushes.White,
                    FontSize = 24,
                    FontFamily = new FontFamily("One Day"),
                    Padding = new Thickness(0,0,0,10),
                });
            }
        }

        private void addTransport()
        {
            var converter = new System.Windows.Media.BrushConverter();
            var transportList = new List<string>()
            {
                "Walking",
                "Driving",
                "Cycling",
                "Public",
            };

            foreach (var type in transportList)
            {
                _view.addTransportToBox(new Label()
                {
                    Content = type,
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    VerticalContentAlignment = VerticalAlignment.Center,
                    Background = (Brush)converter.ConvertFromString("#CC494949"),
                    Foreground = Brushes.White,
                    FontSize = 48,
                });
            }
        }

        public string Search()
        {
            return ServerConnector.GoogleDownloader($"https://maps.googleapis.com/maps/api/place/textsearch/json?query={SelectedValues.Location}+in+{SelectedValues.Type}&radius={SelectedValues.Radius*1000}&key=AIzaSyCeB6wF-ddWKB2O_BXHLIoHZdqFdOdpPbY");
        }
    }
}
