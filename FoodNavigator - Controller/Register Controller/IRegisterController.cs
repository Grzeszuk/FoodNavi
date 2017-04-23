using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FoodNavigator___Controller.Register_Controller
{
    public interface IRegisterController
    {
        void changeUserColor(SolidColorBrush color);
        void changePasswordColor(SolidColorBrush color);
        void changeConfirmColor(SolidColorBrush color);
        void changeBigColor(SolidColorBrush color);
        void changeSmallColor(SolidColorBrush color);
        void changeSpecialColor(SolidColorBrush color);
        void changeNumberColor(SolidColorBrush color);
        void changeEmailColor(SolidColorBrush color);
        void changePhotoColor(SolidColorBrush color);
        void changeCountColor(SolidColorBrush color);
    }
}
