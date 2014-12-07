using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test3.Models
{
    public class RecentPostsItemModel
    {
         public RecentPostsItemModel()
        {
            title = "title";
            body = "text";
            URL = "#";
         }
        public string title { get; set; }
        public string URL { get; set; }
        public string body { get; set; }
    }
}