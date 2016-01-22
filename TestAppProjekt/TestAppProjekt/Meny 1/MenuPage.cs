using TestAppProjekt.View;
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
                BackgroundColor = Color.FromHex("333333"),

            Children = {
                new MainLink("Home") {Command =new Command(o =>
            {
                App.MasterDetailPage.Detail = new NavigationPage(new HomeScreen());
                App.MasterDetailPage.IsPresented = false;
            })
        },
                new MainLink("Employees") {Command =new Command(o =>
            {
                App.MasterDetailPage.Detail = new NavigationPage(new HomeScreen());
                App.MasterDetailPage.IsPresented = false;
                
            })
        },
                //new MainLink("Locations"),
                //new MainLink("Time Reports"),
                //new MainLink("Settings"),
                //new MainLink("Logout"),

                }
            };

            Title = "Master";
            BackgroundColor = Color.Gray.WithLuminosity(0.9);
            Icon = Device.OS == TargetPlatform.iOS ? "menu.png" : null;
            Icon = "MenuIcon.png";

        }

    }
}
