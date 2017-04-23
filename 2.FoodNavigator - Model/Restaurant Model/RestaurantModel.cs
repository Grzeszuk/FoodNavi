using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNavigator_Model
{
    public class RestaurantModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Open{ get; set; }
        public double Lng { get; set; }
        public double Lat { get; set; }
        public double Rating { get; set; }
        public int PriceLevel { get; set; }
        public string Text { get; set; }
        public string Photo { get; set; }

        public string PlaceId;
        
        public RestaurantModel(string name,string address,double lat,double lng,double rating,int priceLevel,string open,string text,string photo,string placeId)
        {
            this.Name = name;
            this.Address = address;
            this.Lat = lat;
            this.Lng = lng;
            this.Rating = rating;
            this.PriceLevel = priceLevel;
            this.Open = open;
            this.Photo = photo;
            this.PlaceId = placeId;
            this.Text = text;
        }
    }
}
