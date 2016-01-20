using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppProjekt.Meny_2;

namespace TestAppProjekt.Meny_2
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Title = "Home",
                TargeType = typeof(View.HomeScreen)
                
            });

            this.Add(new MenuItem()
            {
                Title = "Employees",
                TargeType = typeof(View.HomeScreen)
            });

            this.Add(new MenuItem()
            {
                Title = "Locations",
                TargeType = typeof(View.HomeScreen)
            });

            this.Add(new MenuItem()
            {
                Title = "Time Reports",
                TargeType = typeof(View.HomeScreen)
            });

            this.Add(new MenuItem()
            {
                Title = "Settings",
                TargeType = typeof(View.HomeScreen)
            });

            this.Add(new MenuItem()
            {
                Title = "Logout",
                TargeType = typeof(View.HomeScreen)
            });
        }
    }
}
