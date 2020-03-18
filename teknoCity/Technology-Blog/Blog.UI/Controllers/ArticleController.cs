using Blog.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    [Authorize]
    public class ArticleController : Controller
    {
        ManagementArticle managementArticle = new ManagementArticle();
      
        [AllowAnonymous]
        public ActionResult ArticleDetail(int id)
        {

            return View(managementArticle.Find(x => x.ArticleID == id));
        }
        [Authorize(Roles ="Yazar")]
        public ActionResult ArticleAdd()
        {
            return View();
        }
    }
}