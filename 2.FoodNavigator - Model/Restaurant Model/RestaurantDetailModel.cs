using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.FoodNavigator___Model.Restaurant_Model
{
    public class RestaurantDetailModel
    {
        public string name { get; set; }
        public string address { get; set;}
        public string open { get; set; }
        public string openHours { get; set; }
        public double rating { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public string photo { get; set; }

        public RestaurantDetailModel(string name,string address,string open,string openHours,double rating,string phone,string photo,string website)
        {
            this.name = name;
            this.address = address;
            this.open = open;
            this.openHours = openHours;
            this.rating = rating;
            this.phone = phone;
            this.photo = photo;
            this.website = website;
        }
    }
}
