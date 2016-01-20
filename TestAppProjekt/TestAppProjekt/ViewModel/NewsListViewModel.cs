using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using TestAppProjekt.Fakes;
using TestAppProjekt.Model;

namespace TestAppProjekt.ViewModel
{
    class NewsListViewModel : INotifyPropertyChanged
    {
        public List<NewsModel> News { get; set; }

        public NewsListViewModel()
        {
            News = new List<NewsModel>(); 
            for (int i = 0; i < FakeNews.NewsId.Count; i++)
            {
                News.Add(new NewsModel()
                {
                    NewsImgUrl = FakeNews.NewsImgUrl[i],
                    PublishedBy = FakeNews.PublishedBy[i],
                    NewsType = FakeNews.NewsType[i],
                    NewsId = FakeNews.NewsId[i],
                    NewsText = FakeNews.NewsText[i],
                    Location = FakeNews.Location[i],
                    Subject = FakeNews.Subject[i],
                    CreatedDate = FakeNews.CreatedDate[i],
                    ValidThrough = FakeNews.ValidThrough[i],
                });
            }
        }

        //private string CreateShortText(string createShortText)
        //{
        //    int maxLength = 50;
        //    var newsText = FakeNews.NewsText;
        //    if (newsText.)
        //    {
                
        //    }

        //}

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
