using NttmLesson06CFK22CNT4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NttmLesson06CFK22CNT4.Controllers
{
    public class NttmCategoriesController : Controller
    {
        private static NttmBookStore nttmDb; 
        public NttmCategoriesController() { 
            nttmDb = new NttmBookStore();
        }
        // GET: NttmCategories
        public ActionResult NttmIndex()
        {
            /*
             * Khởi tạo DbContext:
             * EF tìm thông tin kết nối trong file machiee.config của .NET Framwork trên máy 
             * và sau đó tạo csdl
             */
            var nttmcategories = nttmDb.NttmCategories.ToList();
            return View(nttmcategories);
        }
        public ActionResult NttmCreate()
        {
            var nttmCategory = new NttmCategory();
            return View();
        }
        [HttpPost]
        public ActionResult NttmCreate(NttmCategory nttmCategory)
        {
            nttmDb.NttmCategories.Add(nttmCategory);
            nttmDb.SaveChanges();
            return RedirectToAction("NttmIndex");
        }
    }
}