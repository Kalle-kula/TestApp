using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using Xamarin.Forms; 
using TestAppProjekt.Meny_2;
using TestAppProjekt.Meny_3;

namespace TestAppProjekt
{
    public class App : Application
    {
        public static MasterDetailPage MasterDetailPage;
        public App()
        {
            MasterDetailPage = new MasterDetailPage
            {
                Master = new MenuPage(),

                //Detail = new NavigationPage(new LinkPage("A")),
                Detail = new NavigationPage(new View.HomeScreen()),
            };
            MainPage = MasterDetailPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
