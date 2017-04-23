using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FoodNavigator___Controller.Connection_Controller
{
    public static class ConnectionController
    {
        [DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool CheckConnection()
        {
            return InternetGetConnectedState(out int desc, 0);
        }
    }
}
