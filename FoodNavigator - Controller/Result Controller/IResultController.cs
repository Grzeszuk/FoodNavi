using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using FoodNavigator_Model;
using GMap.NET.WindowsPresentation;
using _2.FoodNavigator___Model.Restaurant_Model;
using Label = System.Windows.Controls.Label;

namespace FoodNavigator___Controller.Result_Controller
{
    public interface IResultController
    {
        void AddRestaurantToGrid(RestaurantMapPointer arg,StackPanel info,GMapMarker marker);
    }
}
