using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai1._1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public ActionResult Index()
        {
            return View();
        }
        // GET: Home/About 
        public ActionResult About()
        {
            return View();
        }
        // GET: Home/Contact
        public ActionResult Contact()
        {
            return View();
        }
    }
}