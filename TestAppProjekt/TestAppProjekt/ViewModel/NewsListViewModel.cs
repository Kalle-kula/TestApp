using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using TestAppProjekt.Fakes;
using TestAppProjekt.Model;
using TestAppProjekt.Services;

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

            //Anropet sen

            //ServiceConsumer cs = new ServiceConsumer();
            //Task<List<NewsModel>> _news = cs.GetAllNews();
            //News = _news.Result;

        }

        

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
