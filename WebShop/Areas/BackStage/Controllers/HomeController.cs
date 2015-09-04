using BookShopEntity;
using BookShopManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebShop.Areas.BackStage.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /BackStage/Home/

        private BookManager _bManager = new BookManager();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
           // return RedirectToAction("login","/backstage/account");
            return Redirect("/backstage/account/login");
        }

        public ActionResult UserInfo()
        {
            return View();
        }

        public ActionResult BookInfo()
        {
            var list = _bManager.GetBookList(15);
            return View(list);
        }

        public ActionResult Details(int id)
        {
            var book = _bManager.GetBookBy(id);
            return View(book);
        }

        [HttpGet]
        public ActionResult Edit(int id=0)
        { 
            var book = _bManager.GetBookBy(id);
            return View(book);
        }
        [HttpPost]
        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            if (_bManager.Delete(id))
                return Content("<script>alert('修改成功！');location.href='/home/bookinfo'</script>");
            else
                return Content("<script>alert('修改失败！');location.href='/home/bookinfo'</script>");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(BookInfo book, HttpPostedFileBase file)
        {
            if (_bManager.Add(book))
                return Content("<script>alert('添加成功！');location.href='/home/bookinfo'</script>");
            else
                return Content("<script>alert('添加失败！');location.href='/home/bookinfo'</script>");
        }



    }   
}
