using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test3.Models
{
    public class CommentItemModel
    {
        public CommentItemModel()
        {
            UserName = "Alex";
            body = "text";
            Date = DateTime.Now;
        }
        public string UserName { get; set; }
        public string body { get; set; }
        public DateTime Date { get; set; }

    }
}