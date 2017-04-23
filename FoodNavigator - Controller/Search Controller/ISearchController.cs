using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FoodNavigator___Controller.Search_Controller
{
    public interface ISearchController
    {
        void addTypeToBox(Label arg);
        void addTransportToBox(Label arg);
    }
}
