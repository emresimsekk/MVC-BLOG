using Blog.Business;
using Blog.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    public class PopularArticleController : Controller
    {
        private ManagementArticle managementArticle = new ManagementArticle();
        public PartialViewResult _PopulerArticle()
        {
            
            return PartialView(managementArticle.OrderByTakeList(x => x.ArticleCreateDate).Take(3));
        }
    }
}