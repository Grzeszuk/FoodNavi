using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using FoodNavigator___Controller.Data_Encrypter;
using FoodNavigator___Controller.Server_Connector;
using Newtonsoft.Json;
using _2.FoodNavigator___Model.Login;

namespace FoodNavigator___Controller.Welcome_Controller
{
    public class WelcomeController
    {
        public bool Login(string name, SecureString password)
        {
     
                var confidential = Uri.EscapeDataString(
                    Enrypter.Encrypt(new System.Net.NetworkCredential(string.Empty, password).Password,
                        "ifnerjf^$^jmernvjeaj"));
                confidential = confidential.Replace('%', '&');
                var response = ServerConnector.ServerDownloader($"login/{Uri.EscapeDataString(name.ToLower())}/{confidential}");
                var result = JsonConvert.DeserializeObject<LoginJson>(response);

                if (result.allow)
                {

                    LoginData.Username = Uri.EscapeDataString(name);

                    LoginData.Password = confidential;

                    LoginData.Photo = !string.Equals(result.photo, null, StringComparison.Ordinal)
                        ? result.photo
                        : (result.photo = "false");

                    return true;
                }
                else if (result.allow == false)
                {
                    MessageBox.Show("Invalid username or password", "FoodNavi - Login problem", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    return false;
                }
                else
                {
                    MessageBox.Show("No internet connection/Server Error", "FoodNavi - Login problem",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }        
        }
    }
}
