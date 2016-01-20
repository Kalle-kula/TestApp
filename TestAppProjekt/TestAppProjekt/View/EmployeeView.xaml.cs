using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestAppProjekt.View
{
    public class TabsPage : TabbedPage
    {
        public TabsPage()
        {
            this.Children.Add(
                new NavigationPage(new EmployeesPage())
            {
                Title="Employees"
            });

            this.Children.Add(
                new NavigationPage(new HomeScreen())
                {
                    Title = "Home"
                });


            //Skapa ny class som inte har xaml och som ser ut som den här och sen länkar till sidorna som ska komma upp som tabbede
        }
    }
}





//public partial class EmployeeView : ContentPage
//    {
//        public EmployeeView()
//        {
//            InitializeComponent();
//        }
//    }

