using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using FoodNavigator___Controller.Data_Encrypter;
using FoodNavigator___Controller.Server_Connector;
using _2.FoodNavigator___Model.Login;

namespace FoodNavigator___Controller.Settings_Controller
{
    public static class SettingsConnector
    {
        public static void Password(string password)
        {
            ServerConnector.ServerDownloader($"passwordc/{LoginData.Username}/{Uri.EscapeDataString(Enrypter.Encrypt(password, "ifnerjf^$^jmernvjeaj")).Replace('%', '&')}");
        }

        public static void Picture(string url)
        {
            ServerConnector.ServerDownloader($"photo/{Uri.EscapeDataString(LoginData.Username)}/{url}");
        }
    }
}
