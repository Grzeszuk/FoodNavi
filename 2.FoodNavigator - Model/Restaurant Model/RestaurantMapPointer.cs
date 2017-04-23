using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.FoodNavigator___Model.Restaurant_Model
{
    public class RestaurantMapPointer
    {
        public string Name { get; set; }
        public bool Open { get; set; }
        public double Lng { get; set; }
        public double Lat { get; set; }

        public RestaurantMapPointer(string Name,bool Open,double Lng,double Lat)
        {
            this.Name = Name;
            this.Open = Open;
            this.Lng = Lng;
            this.Lat = Lat;
        }
    }
}
