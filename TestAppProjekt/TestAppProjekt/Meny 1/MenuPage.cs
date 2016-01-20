using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace TestAppProjekt
{
    public class MenuPage : ContentPage
    {
        //Menysidan
        public MenuPage()
        {
            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform<int>(20, 0, 0), 0, 0),
                Children = {
                new MainLink ("Home"),
                new MainLink("Employees"),
                new MainLink("Locations"),
                new MainLink("Time Reports"),
                new MainLink("Settings"),
                new MainLink("Logout"),
                }
            };

            Title = "Master";
            BackgroundColor = Color.Gray.WithLuminosity(0.9);
            Icon = Device.OS == TargetPlatform.iOS ? "menu.png" : null;
            Icon = "MenuIcon.png";
        }
    }
}
