using Blog.Business;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    public class TagsController : Controller
    {
        private ManagementTags managementTags = new ManagementTags();
        private ManagementArticle managementArticle = new ManagementArticle();

        public  ActionResult Index(int id)
        {
            return View(id);
        }


        public PartialViewResult _TagsList()
        {
            return PartialView(managementTags.List().Take(12));
        }

        public ActionResult ArticleList(int id, int pageNumber = 1)
        {
            int pageSize = 6;
            return View("_ArticleList", managementArticle.List(x => x.tbl_articleTags.Any(y => y.TagID == id)).ToPagedList(pageNumber, pageSize));
        }
    }
}