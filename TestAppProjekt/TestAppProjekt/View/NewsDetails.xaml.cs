using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppProjekt.Model;
using TestAppProjekt.ViewModel;
using Xamarin.Forms;

namespace TestAppProjekt.View
{
    public partial class NewsDetails : ContentPage
    {
        private NewsViewModel _newsViewModel;
        private static NewsModel _currentNews;

        public NewsDetails(NewsModel newsModel)
        {
            _currentNews = newsModel;
            _newsViewModel = new NewsViewModel(newsModel);
            InitializeComponent();
            BindingContext = _newsViewModel;

        }

    }
}
