using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace TestAppProjekt.Meny_3
{
    public class SubLink2 : Button
    {
        public SubLink2(string name)
        {
            Text = name;
            Command = new Command(o => App.MasterDetailPage.Detail.Navigation.PushAsync(new LinkPage(name)));
        }
    }
}
