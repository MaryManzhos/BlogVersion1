using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Test3.Models
{
    public class RecentPostsModel
    {
        public RecentPostsModel()
        {
            ItemsPosts = new Collection<RecentPostsItemModel>();
            ItemsPosts.Add(new RecentPostsItemModel());
            ItemsPosts.Add(new RecentPostsItemModel());
            ItemsPosts.Add(new RecentPostsItemModel());
          
        }
        public ICollection<RecentPostsItemModel> ItemsPosts { get; set; }
    }
}