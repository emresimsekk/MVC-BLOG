using Blog.Business;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    public class CategoryController : Controller
    {
        
        private ManagementCategory managementCategory = new ManagementCategory();
        private ManagementArticle managementArticle = new ManagementArticle();

        public ActionResult Index(int id)
        {
            return View(id);
        }

        public PartialViewResult _CategoryList()
        {
            return PartialView(managementCategory.List().Take(6));
        }

        public ActionResult ArticleList(int id, int pageNumber = 1)
        {
            int pageSize = 6;
            return View("_ArticleList", managementArticle.List(x => x.CategoryID == id).ToPagedList(pageNumber, pageSize));
        }
    }
}