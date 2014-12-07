using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test3.Models;

namespace Test3.Controllers
{
    public class BlogPostController : Controller
    {
        //
        // GET: /BlogPost/

        public ActionResult BlogPost()
        {
            var model = new BlogPostModel();
            return View(model);
        }

    }
}
