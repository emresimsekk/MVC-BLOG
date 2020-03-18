using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public PartialViewResult _Search()
        {
            return PartialView();
        }
    }
}