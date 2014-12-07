using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test3.Models
{
    public class HomeModel
    {
        public HomeModel()
        {
            Article = new RecentArticleModel();
        }

        public RecentArticleModel Article { get; set; }
    }
}