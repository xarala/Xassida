using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Shell;
using System.Reflection;

namespace XassidaReader
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        /// <summary>
        /// Overrides the onStartup event handler
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            
            JumpTask task = new JumpTask /// create a jumptask in windows 7 taskbar
            {
                Title = "Ma Bibliothéque",
                Description = "Voir les xassida enregistrés sur ma machine",
                CustomCategory = "Actions",
                IconResourcePath = Assembly.GetEntryAssembly().CodeBase,
                ApplicationPath = Assembly.GetEntryAssembly().CodeBase
            };

            JumpList jumpList = new JumpList();
            jumpList.JumpItems.Add(task);
            jumpList.ShowFrequentCategory = false;
            jumpList.ShowRecentCategory = false;

            JumpList.SetJumpList(Application.Current, jumpList);
            base.OnStartup(e);
        }
        
        private void Application_Startup(object sender, StartupEventArgs e)
        {

            //SplashScreen splashScreen = new SplashScreen("SplashScreen.png");
            //splashScreen.Show(false);
            //splashScreen.Close(TimeSpan.FromSeconds(4));
            //System.Threading.Thread.Sleep(3000);
            XassidaWindow mainWindow = new XassidaWindow();
            mainWindow.Show();

        }

    }
}
