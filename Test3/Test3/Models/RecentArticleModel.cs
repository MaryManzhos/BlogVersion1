using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Test3.Models
{
    public class RecentArticleModel
    {
         public RecentArticleModel()
        {
            Item = new Collection<RecentArticleItemModel>();
            Item.Add(new RecentArticleItemModel());
            Item.Add(new RecentArticleItemModel());    
        }
        public ICollection<RecentArticleItemModel> Item { get; set; }
    }
}