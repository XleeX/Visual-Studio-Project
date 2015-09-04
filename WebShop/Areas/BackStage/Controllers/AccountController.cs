using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShopManager;

namespace WebShop.Areas.BackStage.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /BackStage/Account/

        UserManager um = new UserManager();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string uname, string upwd)
        {
            if (um.CheckAccount(uname, upwd))
            {
                Session[uname] = uname;
                Session.Timeout = 30;
                return Redirect("/backstage/home/index");
            }
            else
                return RedirectToAction("Login", "account");
        }
    
    }
}
