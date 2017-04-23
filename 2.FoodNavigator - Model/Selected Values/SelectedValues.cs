using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.FoodNavigator___Model.Selected_Values
{
    public static class SelectedValues
    {
        public static string Location { get; set; }
        public static string Street { get; set; }
        public static string Type { get; set; }
        public static string Transport { get; set; }
        public static int Radius { get; set; } = 5;
        public static int FoodIndex { get; set; } = 0;
        public static int TransportIndex { get; set; } = 0;
    }

    public static class SearchValues
    {
        public static  string Json { get; set; }
    }

    public static class SelectedRestaurant
    {
        public static string Reference { get; set; }
    }
}
