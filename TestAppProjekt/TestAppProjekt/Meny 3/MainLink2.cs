using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace TestAppProjekt.Meny_3
{
    public class MainLink2 : Button
    {
        public MainLink2(string name)
        {
            Text = name;
            Command = new Command(o =>
            {
                App.MasterDetailPage.Detail = new NavigationPage(new LinkPage2(name));
                App.MasterDetailPage.IsPresented = false;
            });
        }
    }
}
