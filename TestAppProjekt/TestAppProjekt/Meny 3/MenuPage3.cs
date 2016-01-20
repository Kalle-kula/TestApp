using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace TestAppProjekt.Meny_3
{
    public class MenuPage3 : ContentPage
    {
        public MenuPage3()
        {
            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform<int>(20, 0, 0), 0, 0),
                Children = {
                new MainLink2("Home"),
                new MainLink2("Employees"),
                new MainLink2("Locations"),
                new MainLink2("Time Reports"),
                new MainLink2("Settings"),
                new MainLink2("Logout"),
                }
            };

            Title = "Master";
            BackgroundColor = Color.Gray.WithLuminosity(0.9);
            Icon = Device.OS == TargetPlatform.iOS ? "menu.png" : null;
            Icon = "MenuIcon.png";
        }
    }
}
