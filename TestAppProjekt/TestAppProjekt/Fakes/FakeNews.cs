using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppProjekt.Fakes
{
    public class FakeNews
    {
        public static List<int> NewsId = new List<int>() { 1, 2, 3, 4, 5 };
        public static List<string> NewsType = new List<string>() { "", "", "", "", "" };
        public static List<string> Location = new List<string>() { "", "", "", "", "" };
        public static List<string> Subject = new List<string>() { "News 1", "News 2", "News 3", "News 4", "News 5" };
        public static List<string> NewsText = new List<string>()
        {
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.",
            "Quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Ut enim ad minim veniam, quis nostrud exercitation ullamco.",
            "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore. Ut enim ad minim veniam, quis nostrud exercitation ullamco.",
            "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia. Ut enim ad minim veniam, quis nostrud exercitation ullamco.",
            "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium. Ut enim ad minim veniam, quis nostrud exercitation ullamco."
        };

        public static List<DateTime> CreatedDate = new List<DateTime>() { DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now };
        public static List<DateTime> ValidThrough = new List<DateTime>() { DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now };
        public static List<string> PublishedBy = new List<string>() { "", "", "", "", "" };
        public static List<string> NewsImgUrl = new List<string>() { "", "", "", "", "" };
    }
}
