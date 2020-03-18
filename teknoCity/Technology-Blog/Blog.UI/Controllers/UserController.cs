using Blog.Business;
using Blog.Entity.Models;
using Blog.Entity.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Blog.UI.Controllers
{
    public class UserController : Controller
    {
       private ManagementUser managementUser = new ManagementUser();
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tbl_user tu)
        {
            string role = ValidateUser(tu.Username, tu.UserPassword);
            if (!string.IsNullOrEmpty(role))
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,tu.Username,DateTime.Now,DateTime.Now.AddMinutes(15),true,role,FormsAuthentication.FormsCookiePath);
                HttpCookie ck = new HttpCookie(FormsAuthentication.FormsCookieName);
                if (ticket.IsPersistent)
                {
                    ck.Expires= ticket.Expiration;
                }
                
                Response.Cookies.Add(ck);
                Session["role"] = role;
                FormsAuthentication.RedirectFromLoginPage(tu.Username, true);
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Login");
        }
        string ValidateUser(string un ,string pwd)
        {
            tbl_user tu= managementUser.Find(x => x.Username==un && x.UserPassword==pwd);
            if (tu!=null)
            {
                return tu.tbl_userGroup.UserGroupName;
            }
            else
            {
                return "";
            }
        }
    }
}