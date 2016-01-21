﻿using System;
using TestAppProjekt.Model;
using TestAppProjekt.ViewModel;
using Xamarin.Forms;

namespace TestAppProjekt.View
{
    public partial class HomeScreen : ContentPage
    {
        private NewsListViewModel _newsListViewModel;
        public HomeScreen()
        {
            _newsListViewModel = new NewsListViewModel();
            InitializeComponent();
            BindingContext = _newsListViewModel;
        }

        private void NewsListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var news = (NewsModel) e.Item;
            if (e != null)
            {
                Navigation.PushAsync(new NewsDetails(news));
            }
        }

        private void Employees_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new EmployeeViewGeneral()));
        }

        private void Time_Report_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new EmployeeViewGeneral()));
        }

    }
}
