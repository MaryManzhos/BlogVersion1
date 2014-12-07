using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test3.Models;

namespace Test3.Controllers
{
    public class PostsController : Controller
    {
        //
        // GET: /Category/

        public ActionResult Recent()
        {
            var model = new RecentPostsModel();
            return View(model);
        }

    }
}
