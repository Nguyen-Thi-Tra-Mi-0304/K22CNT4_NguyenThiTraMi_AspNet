using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenThiTraMi_2210900041.Controllers
{
    public class NttmHomeController : Controller
    {
        public ActionResult NttmIndex()
        {
            return View();
        }

        public ActionResult NttmAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NttmContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}