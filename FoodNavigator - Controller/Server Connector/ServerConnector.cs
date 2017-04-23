using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNavigator___Controller.Server_Connector
{
    public static class ServerConnector
    {
        public static string ServerDownloader(string url)
        {
            var client = new System.Net.Http.HttpClient();
            return Task.Run(() => client.GetStringAsync(new Uri(string.Format($"https://foodnavigator.azurewebsites.net/{url}?format=json", string.Empty)))).Result;
        }

        public static string GoogleDownloader(string url)
        {
            var client = new System.Net.Http.HttpClient();
            return Task.Run(() => client.GetStringAsync(new Uri(url))).Result;
        }
    }
}
