using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using FoodNavigator___Controller.Window_Controller;
using MahApps.Metro;

namespace FoodNavigator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
 
            // Create an instance of the window that is located in another assembly
            WindowController.StartApplication();
        }

    }
}
