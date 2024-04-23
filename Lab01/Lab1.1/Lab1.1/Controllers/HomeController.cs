using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1._1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //sử dung ViewBag để đưa dữ liệu ra View
            ViewBag.message = "Chào mừng bạn đến với ASP.NET MVC 5";
            return View();
        }
        public ActionResult About()
        {
            //sử dung ViewBag để đưa dữ liệu ra View
            ViewBag.message = "Đây là trang About";
            return View();
        }
    }
}