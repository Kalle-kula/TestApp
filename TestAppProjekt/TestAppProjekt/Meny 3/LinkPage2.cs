using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace TestAppProjekt.Meny_3
{
    public class LinkPage2 : ContentPage
    {
        public LinkPage2(string name)
        {
            Title = name;
            Content = new StackLayout
            {
                Children =
                { //här ska new navigationPage(new name())
                    new SubLink(name),
                    new SubLink(name + ".2"),
                    new SubLink(name + ".3"),
                },
            };
        }
    }
}
