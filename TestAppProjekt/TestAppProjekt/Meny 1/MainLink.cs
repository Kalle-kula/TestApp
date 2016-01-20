using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TestAppProjekt.View;
using Xamarin.Forms;

namespace TestAppProjekt
{
    public class MainLink : Button
    {
        //när man klickar på ett menyitem
        public MainLink(string name)
        {
            
            Text = name;
            //Command = new Command(o =>
            //{
            //    App.MasterDetailPage.Detail = new NavigationPage(new EmployeesPage());
            //    App.MasterDetailPage.IsPresented = false;
            //});
        }
    }
}
