using Blog.Business;
using Blog.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace Blog.UI.Controllers
{
    public class HomeController : Controller
    {
        private ManagementArticle managementArticle = new ManagementArticle();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ArticleList(int pageNumber=1)
        {
            
            int pageSize = 6;

            return View("_ArticleList", managementArticle.List().ToPagedList(pageNumber, pageSize));

        }



    }
}