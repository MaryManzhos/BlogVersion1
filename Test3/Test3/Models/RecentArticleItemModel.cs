using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test3.Models
{
    public class RecentArticleItemModel
    {
        public RecentArticleItemModel()
        {
            Title = "title";
            Date = DateTime.Now;
            Author = "Mary";
            body = "<p>This is an article body from controller!</p>";
            comment = "1 comment";
            URL1 = "#";
            URL2 = "#";
         }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string body { get; set; }
        public string comment { get; set; }
        public string URL1 { get; set; }
        public string URL2 { get; set; }
    }
}