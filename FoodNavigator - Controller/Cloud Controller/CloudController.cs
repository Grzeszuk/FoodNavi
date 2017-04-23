using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using FoodNavigator___Controller.Server_Connector;
using MaterialDesignThemes.Wpf;
using _2.FoodNavigator___Model.Login;
using Newtonsoft.Json;
using _2.FoodNavigator___Model.Cloud_Model;
using _2.FoodNavigator___Model.Selected_Values;

namespace FoodNavigator___Controller.Cloud_Controller
{
    public class CloudController
    {
        readonly ICloudController _view;

        public CloudController(ICloudController view)
        {
            _view = view;
        }

        public void LoadSaves()
        {
            try
            {
               var response = JsonConvert.DeserializeObject<CloudLoadJson.Informations>(CloudConnector.Load());
               var converter = new System.Windows.Media.BrushConverter();

                foreach (var item in response.selection)
                {
                    var temp = new StackPanel();

                    if (item.location.Contains(';'))
                    {
                        var split = item.location.Split(';');
                        temp.Children.Add(new Label() { Content = $"City: {split[0]}", Background = Brushes.LightGreen });
                        temp.Children.Add(new Label() { Content = $"Street: {split[1]}", Foreground = Brushes.White, Background = (Brush)converter.ConvertFromString("#CC494949") });

                    }
                    else
                    {
                        temp.Children.Add(new Label() { Content = $"City: {item.location}", Background = Brushes.LightGreen });
                    }
                    temp.Children.Add(new Label() {Content = $"Food type: {item.type}",Foreground = Brushes.White,Background = (Brush)converter.ConvertFromString("#CC494949")});
                    temp.Children.Add(new Label() { Content = $"Radius: {item.radius} KM", Foreground = Brushes.White, Background = (Brush)converter.ConvertFromString("#CC494949") });
                    temp.Children.Add(new Label() { Content = $"Transport type: {item.transport}", Foreground = Brushes.White, Background = (Brush)converter.ConvertFromString("#CC494949") });
                    temp.Children.Add(new Label() { Content = $"Selection code: {LoginData.Username[0]}-{item.foodIndex}-{item.typeIndex}-{LoginData.Username[LoginData.Username.Length-1]}", Foreground = Brushes.White, Background = Brushes.DarkGray });

                    temp.Margin= new Thickness(0,0,0,10);

                    _view.AddSelectionToGrid(temp);

                }
            }
            catch
            {
                MessageBox.Show("You don't have selection saves","FoodNavigator - Cloud load",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            _view.CheckCount();
        }
        public void DeleteSelection(StackPanel arg)
        {
            string selection=null;

            if(arg != null)
            if (arg.Children.Count == 5)
            {
                var location = (Label) arg.Children[0];
                var type = (Label) arg.Children[1];
                var radius = (Label) arg.Children[2];
                var transport = (Label) arg.Children[3];
                var values = (Label) arg.Children[4];

                selection = $"{location.Content.ToString().Split(':')[1].Remove(0,1)}" +
                            $"-{type.Content.ToString().Split(':')[1].Remove(0,1)}" +
                            $"-{radius.Content.ToString().Split(':')[1].Split(' ')[1]}" +
                            $"-{transport.Content.ToString().Split(':')[1].Remove(0,1)}" +
                            $"-{values.Content.ToString().Split('-')[1]}" +
                            $"-{values.Content.ToString().Split('-')[2]}";

            }
            else if (arg.Children.Count == 6)
            {
                {
                    var location = (Label) arg.Children[0];
                    var street = (Label) arg.Children[1];
                    var type = (Label) arg.Children[2];
                    var radius = (Label) arg.Children[3];
                    var transport = (Label) arg.Children[4];
                    var values = (Label) arg.Children[5];

                    selection =
                        $"{location.Content.ToString().Split(':')[1].Remove(0,1)};{street.Content.ToString().Split(':')[1].Remove(0,1)}" +
                        $"-{type.Content.ToString().Split(':')[1].Remove(0,1)}" +
                        $"-{radius.Content.ToString().Split(':')[1].Split(' ')[1]}" +
                        $"-{transport.Content.ToString().Split(':')[1].Remove(0,1)}" +
                        $"-{values.Content.ToString().Split('-')[1]}" +
                        $"-{values.Content.ToString().Split('-')[2]}";
                }
            }

            CloudConnector.Delete(selection);
        }

        public bool LoadSelection(StackPanel arg)
        {
            if (arg.Children.Count == 5)
            {
                var location = (Label) arg.Children[0];
                var type = (Label) arg.Children[1];
                var radius = (Label) arg.Children[2];
                var transport = (Label) arg.Children[3];
                var values = (Label) arg.Children[4];


                SelectedValues.Location = location.Content.ToString().Split(':')[1];
                SelectedValues.Type = type.Content.ToString().Split(':')[1];
                SelectedValues.Radius = Convert.ToInt32(radius.Content.ToString().Split(':')[1].Split(' ')[1]);
                SelectedValues.Transport = transport.Content.ToString().Split(':')[1];
                SelectedValues.FoodIndex = Convert.ToInt32(values.Content.ToString().Split('-')[1]);
                SelectedValues.TransportIndex = Convert.ToInt32(values.Content.ToString().Split('-')[2]);
                return true;
            }
            else if (arg.Children.Count == 6)
            {
                {
                    var location = (Label) arg.Children[0];
                    var street = (Label) arg.Children[1];
                    var type = (Label) arg.Children[2];
                    var radius = (Label) arg.Children[3];
                    var transport = (Label) arg.Children[4];
                    var values = (Label) arg.Children[5];

                    SelectedValues.Location = location.Content.ToString().Split(':')[1];
                    SelectedValues.Street = street.Content.ToString().Split(':')[1];
                    SelectedValues.Type = type.Content.ToString().Split(':')[1];
                    SelectedValues.Radius = Convert.ToInt32(radius.Content.ToString().Split(':')[1].Split(' ')[1]);
                    SelectedValues.Transport = transport.Content.ToString().Split(':')[1];
                    SelectedValues.FoodIndex = Convert.ToInt32(values.Content.ToString().Split('-')[1]);
                    SelectedValues.TransportIndex = Convert.ToInt32(values.Content.ToString().Split('-')[2]);
                    return true;
                }
            }
            else
                return false;
        }
    }
}
