using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FoodNavigator___Controller.Server_Connector;
using FoodNavi___Model.Restaurant;
using Newtonsoft.Json;
using _2.FoodNavigator___Model.Restaurant_Model;
using _2.FoodNavigator___Model.Selected_Values;

namespace FoodNavigator___Controller.Details_Controller
{
    public class DetailsController
    {
        public RestaurantDetailModel loadDetails()
        {
            var response = ServerConnector.GoogleDownloader($"https://maps.googleapis.com/maps/api/place/details/json?placeid={SelectedRestaurant.Reference}&key=AIzaSyCeB6wF-ddWKB2O_BXHLIoHZdqFdOdpPbY");
            var result = JsonConvert.DeserializeObject<RestaurantDetails.RootObject>(response).result;

            string open;

            if(result.opening_hours!=null)
               open = result.opening_hours.open_now ? "Open: Yes" : "Open: No";
            else
                open = "Open: no informations";

            string openHours;

            try
            {
                var date = (int)DateTime.Now.DayOfWeek - 1;

                if (date == -1)
                {
                    date = 6;
                }
             
                openHours = $"{result.opening_hours.weekday_text[date]}";
            }
            catch
            {
                openHours = $"Today: no info";
            }

            var url = result.website ?? "false";

            return new RestaurantDetailModel(result.name,result.formatted_address,open,openHours,result.rating,result.international_phone_number,result.photos[0].photo_reference,url);
        }
    }
}
