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
using FoodNavigator_Model;
using FoodNavigator___Controller.Result_Controller;
using FoodNavigator___Controller.Window_Controller;
using GMap.NET;
using GMap.NET.WindowsPresentation;
using  Newtonsoft.Json;
using _2.FoodNavigator___Model.Login;
using _2.FoodNavigator___Model.Restaurant_Model;
using _2.FoodNavigator___Model.Selected_Values;
using Page = System.Windows.Controls.Page;

namespace FoodNavigator___View.Result_page
{
    /// <summary>
    /// Interaction logic for ResultPage.xaml
    /// </summary>
    public partial class ResultPage : Page,IResultController
    {
        private ResultController _controller;
        public ResultPage()
        {
            InitializeComponent();

            _controller = new ResultController(this);
            _controller.LoadView();

            if (listBox.Items.Count != 0)
                listBox.SelectedIndex = 0;


            LoadStuff();
        }

        private void LoadStuff()
        {
            try
            {
 
                if (listBox.Items.Count == 0)
                {
                    listBox.Items.Add(new Label() { Content = "No results", Background = Brushes.LightGreen, Foreground = Brushes.White, FontSize = 32 });
                }

                usernameLabel.Content = LoginData.Username;

                if (LoginData.Photo != "false")
                {
                    BitmapImage userphoto = new BitmapImage();
                    userphoto.BeginInit();
                    userphoto.UriSource = new Uri(LoginData.Photo);
                    userphoto.EndInit();
                    userPhoto.Source = userphoto;
                }

                #region gmap settings
                resultMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
                resultMap.SetPositionByKeywords($"{SelectedValues.Location}, Poland");
                resultMap.ShowCenter = false;
                resultMap.MinZoom = 12;
                resultMap.MaxZoom = 18;
                resultMap.Zoom = 12;
                #endregion
            }
            catch
            {
                MessageBox.Show("Application error.","FoodNavi - Results");
            }
        }
        public void AddRestaurantToGrid(RestaurantMapPointer arg,StackPanel info,GMapMarker marker)
        {
            listBox.Items.Add(info);
            resultMap.Markers.Add(marker);
        }


        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (zoomLabel == null) return;
            zoomLabel.Text = $"Zoom: {Math.Round(slider.Value - 11)}x";
            resultMap.Zoom = Math.Round(slider.Value);
        }

        private void signOut_Click(object sender, RoutedEventArgs e)
        {
            WindowController.ChangePage(FoodNavigator___Controller.Window_Controller.Page.Welcome);
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            WindowController.ChangePage(FoodNavigator___Controller.Window_Controller.Page.Search);
        }

        private void listBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                _controller.SelectionChanged(listBox.SelectedIndex);
                WindowController.ShowPopUp(PopUps.Details);
            }
            catch {}
    
        }

        private void standardMap_Click(object sender, RoutedEventArgs e)
        {
            resultMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            resultMap.ReloadMap();
            selectorColor(1);
        }

        private void hybridMap_Click(object sender, RoutedEventArgs e)
        {
            resultMap.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
            resultMap.ReloadMap();
            selectorColor(2);
        }

        private void satelliteMap_Click(object sender, RoutedEventArgs e)
        {
            resultMap.MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
            resultMap.ReloadMap();
            selectorColor(3);
        }

        private void selectorColor(int index)
        {
            var converter = new System.Windows.Media.BrushConverter();

            if (index == 1)
            {
                standardMap.Background = (Brush) converter.ConvertFromString("#3300FF2E");
                hybridMap.Background = (Brush)converter.ConvertFromString("#33FF0000");
                satelliteMap.Background = (Brush)converter.ConvertFromString("#33FF0000");


            }
            else if (index == 2)
            {
                hybridMap.Background = (Brush) converter.ConvertFromString("#3300FF2E");
                satelliteMap.Background = (Brush)converter.ConvertFromString("#33FF0000");
                standardMap.Background = (Brush)converter.ConvertFromString("#33FF0000");

            }
            else if (index == 3)
            {
                satelliteMap.Background = (Brush) converter.ConvertFromString("#3300FF2E");
                standardMap.Background = (Brush)converter.ConvertFromString("#33FF0000");
                hybridMap.Background = (Brush)converter.ConvertFromString("#33FF0000");
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var point = _controller.ZoomTo(listBox.SelectedIndex);
            resultMap.SetPositionByKeywords($"{point.formatted_address}");
            resultMap.Zoom = 18;
        }
    }
}
