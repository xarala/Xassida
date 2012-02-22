using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace XassidaReader
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        
        private void Application_Startup(object sender, StartupEventArgs e)
        {

            SplashScreen splashScreen = new SplashScreen("SplashScreen.png");
            splashScreen.Show(false);
            splashScreen.Close(TimeSpan.FromSeconds(4));
            //System.Threading.Thread.Sleep(3000);
            XassaidesWindow mainWindow = new XassaidesWindow();
            mainWindow.Show();

        }

    }
}
