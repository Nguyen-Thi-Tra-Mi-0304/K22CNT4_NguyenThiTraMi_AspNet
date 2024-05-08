using Lab03._3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03._3.Controllers
{
    public class HTMLHelperController : Controller
    {
        // GET: HTML_Helper_Methods
        public ActionResult FormRegister()
        {
            // tạo list cho droplist
            ViewBag.listCountry = new List<Country>() {
            new Country(){ID="0",Name="-- Chọn Quốc Gia --"},
            new Country(){ID="VN",Name="Việt Nam"},
            new Country(){ID="AT",Name="AUSTRALIA"},
            new Country(){ID="UK",Name="Anh"},
            new Country(){ID="FR",Name="Pháp"},
            new Country(){ID="US",Name="Mỹ"},
            new Country(){ID="KP",Name="Hàn Quốc"},
            new Country(){ID="HU",Name="Hồng Kong"},
            new Country(){ID="CN",Name="Trung Quốc"},
            };
            return View();
        }
        public ActionResult Register()
        {
            // lấy giá trị được các trường đẩy lên server khi submit
            string fvr = "";
            TempData["UName"] = Request["txtUName"];
            TempData["Pass"] = Request["txtPass"];
            TempData["FName"] = Request["txtFName"];
            TempData["Gender"] = Request["Gender"].ToString();
            TempData["Address"] = Request["txtAddress"];
            TempData["Email"] = Request["txtEmail"];
            TempData["Country"] = Request["Country"];

            if (Request["Reading"].ToString().Contains("true")) fvr += "Reading ,";
            if (Request["Shopping"].ToString().Contains("true")) fvr += "Shopping ,";
            if (Request["Sport"].ToString().Contains("true")) fvr += "Sport,";

            TempData["Favourist"] = fvr;

            return View();
        }
    }
}
