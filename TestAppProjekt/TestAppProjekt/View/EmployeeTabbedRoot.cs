using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestAppProjekt.View
{
    public class EmployeeTabbedRoot : TabbedPage
    {
        public EmployeeTabbedRoot()
        {
            this.Children.Add(
                new NavigationPage(new EmployeesPage())
                {
                    Title = "Employees"
                });

            this.Children.Add(
                new NavigationPage(new HomeScreen())
                {
                    Title = "Home"
                });
        }
    }
}
