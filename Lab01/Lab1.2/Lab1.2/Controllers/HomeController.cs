using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1._2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //GET: Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Research IT - DEVMASTER / Chúng tôi sẽ làm bạn hài lòng!";
            return View();
        }
        //GET: Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Thông tin liên hệ";
            return View();
        }
        //GET: Home/Products
        public ActionResult Products()
        {
            ViewBag.Message = "Thực đơn hôm nay";
            string[] products = { "Gà quay", "Cá chép om dưa", "Vịt quay vân đình", "Ốc xào xả ớt" };
            ViewBag.products = products;
            return View();
        }
    }
}