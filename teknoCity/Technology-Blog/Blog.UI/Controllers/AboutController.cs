using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public PartialViewResult _About()
        {
            return PartialView();
        }
    }
}