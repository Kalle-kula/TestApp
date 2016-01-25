using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestAppProjekt.Model
{
    public class NewsModel
    {
        public int NewsId { get; set; }
        public string NewsType { get; set; }
        public string Location { get; set; }
        public string Subject { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ValidThrough { get; set; }
        public string NewsText { get; set; }
        public string PublishedBy { get; set; }
        public string NewsImgUrl { get; set; }

        public string ShortNewsText
        {
            get
            {
                int maxLenght = 50;
                string shortNewsText = NewsText;
                if (shortNewsText.Length > maxLenght)
                {
                    shortNewsText = shortNewsText.Substring(0, maxLenght) + "...";
                }
                return shortNewsText;
            }
        }
        
    }

    //public class NewsManager

    //{
    //    List<NewsModel> News { get; set; }
    //}
}
