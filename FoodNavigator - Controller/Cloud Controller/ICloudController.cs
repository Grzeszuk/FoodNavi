using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FoodNavigator___Controller.Cloud_Controller
{
    public interface ICloudController
    {
        void AddSelectionToGrid(StackPanel panel);
        void CheckCount();
    }
}
