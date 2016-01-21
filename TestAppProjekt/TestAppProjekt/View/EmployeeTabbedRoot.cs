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

            this.Children.Add(new EmployeeViewGeneral() { Title = "General" });
            this.Children.Add(new EmployeeViewSkills() { Title = "Skills" });
            this.Children.Add(new EmployeeViewProjects() { Title = "Projects" });
            this.Children.Add(new EmployeeViewInfo() { Title = "Info" });
            
        }
    }
}
