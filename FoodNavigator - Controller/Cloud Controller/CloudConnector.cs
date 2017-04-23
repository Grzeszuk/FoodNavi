using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FoodNavigator___Controller.Server_Connector;
using Newtonsoft.Json;
using _2.FoodNavigator___Model.Cloud_Model;
using _2.FoodNavigator___Model.Login;
using Label = System.Windows.Controls.Label;

namespace FoodNavigator___Controller.Cloud_Controller
{
    public class CloudConnector
    {
        public static void Save(Label food,Label transport,string location,int radius,int foodIndex,int typeIndex)
        {
            try
            {
                if (Server_Connector.ServerConnector.ServerDownloader(
                        $"save/{LoginData.Username}/{LoginData.Password}/{location.Replace('/','&')}/{food.Content}/{radius}/{transport.Content}/{foodIndex}/{typeIndex}")
                    .Contains("true"))
                {
                    MessageBox.Show("Successfully saved the selection.", "FoodNavigator - Save", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    throw  new Exception();
                }
               
            }
            catch
            {
                MessageBox.Show("The selection was not saved.", "FoodNavigator - Selection error",MessageBoxButton.OK,MessageBoxImage.Error);
            }

        }

        public static string Load()
        {
            try
            {
                return ServerConnector.ServerDownloader($"load/{LoginData.Username}/{LoginData.Password}");        
            }
            catch
            {
                return "false";
            }
        }

        public static void Delete(string selection)
        {
            if(selection!=null)
            ServerConnector.ServerDownloader($"delete/{LoginData.Username}/{LoginData.Password}/{selection.Replace('/','&')}");
        }
    }
}
