using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test3.Models
{
    public class RecentCommentItemModel
    {
        public RecentCommentItemModel()
        {
            title = "Title";
            text = "some text";
            URL = "#";
        }
        public string title { get; set; }
        public string text { get; set; }
        public string URL { get; set; }
    }
}