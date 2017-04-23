using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FoodNavigator___Controller.Register_Controller
{
    public class RegisterController
    {
        private readonly IRegisterController _view;

        public RegisterController(IRegisterController view)
        {
            _view = view;
        }
        public void changeUserColor(string text)
        {
            _view.changeUserColor(text.Length < 5 ? Brushes.Red : Brushes.LightGreen);
        }
        public void changePasswordColor(string text)
        {
            var passTemplate = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");

            if(passTemplate.IsMatch(text) && text.Length>7)
                _view.changePasswordColor(Brushes.LightGreen);
            else
                _view.changePasswordColor(Brushes.Red);

            changeCountColor(text);
            changeBigColor(text);
            changeSmallColor(text);
            changeNumberColor(text);
            changeSpecialColor(text);

        }
        public void changeConfirmColor(string text1, string text2)
        {
            if (text1 == text2 && text2.Length>0)
            {
                _view.changeConfirmColor(Brushes.LightGreen);
            }
            else
            {
                _view.changeConfirmColor(Brushes.Red);
            }
        }
        public void changeCountColor(string text)
        {
            _view.changeCountColor(text.Length < 8 ? Brushes.Red : Brushes.LightGreen);
        }
        public void changeBigColor(string text)
        {
            var hasUpperChar = new Regex(@"[A-Z]+");

            _view.changeBigColor(hasUpperChar.IsMatch(text) ? Brushes.LightGreen : Brushes.Red);
        }
        public void changeSmallColor(string text)
        {
            var hasLowerChar = new Regex(@"[a-z]+");
            _view.changeSmallColor(hasLowerChar.IsMatch(text) ? Brushes.LightGreen : Brushes.Red);
        }
        public void changeSpecialColor(string text)
        {
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            _view.changeSpecialColor(hasSymbols.IsMatch(text) ? Brushes.LightGreen : Brushes.Red);
        }
        public void changeNumberColor(string text)
        {
            var hasNumber = new Regex(@"[0-9]+");
            _view.changeNumberColor(hasNumber.IsMatch(text) ? Brushes.LightGreen : Brushes.Red);

        }
        public void changeEmailColor(string text)
        {
            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            _view.changeEmailColor(regex.IsMatch(text) ? Brushes.LightGreen : Brushes.Red);
        }
        public void changePhotoColor(string text)
        {
            var regex = new Regex(@"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$");
            if (regex.IsMatch(text))
            {
                _view.changePhotoColor(Brushes.LightGreen);
            }
            else if (text.Length == 0)
            {
                _view.changePhotoColor(Brushes.Black);
            }
            else
            {
                _view.changePhotoColor(Brushes.Red);
            }
        }
    }
}
