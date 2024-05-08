using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02._2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ShowProduct()
        {
            return View();
        }
        // GET: Action sửa sản phẩm
        public ActionResult EditProduct(int? productId)
        {
            ViewBag.id = productId;
            return View();
        }
        //GET: Action chi tiết sản phẩm
        public ActionResult DetailsProduct(string productName, int? productId)
        {
            ViewBag.name = productName;
            ViewBag.id = productId;
            return View();
        }

    }
}