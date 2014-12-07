using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test3.Models;

namespace Test3.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Posts/

        public ActionResult Recent()
        {
           var model = new RecentArticleModel();
           return View(model);
        }

    }
}
