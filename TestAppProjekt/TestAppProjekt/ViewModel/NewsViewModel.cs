using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestAppProjekt.Annotations;
using TestAppProjekt.Model;
using TestAppProjekt.Fakes;

namespace TestAppProjekt.ViewModel
{
    public class NewsViewModel
    {
        //private string _newsText;

        public NewsViewModel(NewsModel newsModel)
        {
            NewsId = newsModel.NewsId;
            NewsType = newsModel.NewsType;
            Location = newsModel.Location;
            Subject = newsModel.Subject;
            CreatedDate = newsModel.CreatedDate;
            ValidThrough = newsModel.CreatedDate;
            NewsText = newsModel.NewsText;
            PublishedBy = newsModel.PublishedBy;
            NewsImgUrl = newsModel.NewsImgUrl;
        }

        public int NewsId { get; set; }
        public string NewsType { get; set; }
        public string Location { get; set; }
        public string Subject { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ValidThrough { get; set; }
        public string NewsText { get; set; }
        public string PublishedBy { get; set; }
        public string NewsImgUrl { get; set; }
       
    }
}
