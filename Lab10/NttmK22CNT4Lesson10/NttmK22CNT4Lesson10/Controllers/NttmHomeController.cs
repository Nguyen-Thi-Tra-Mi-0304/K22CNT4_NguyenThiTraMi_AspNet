using NttmK22CNT4Lesson10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NttmK22CNT4Lesson10.Controllers
{
    public class NttmHomeController : Controller
    {
        public ActionResult NttmIndex()
        {
            // Kiểm tra dữ liệu trong session
            if (Session["NttmAccount"]  != null)
            {
                var nttmAccount = Session["NttmAccount"] as NttmAccount;
                ViewBag.FullName = nttmAccount.NttmFullName; 
            }
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