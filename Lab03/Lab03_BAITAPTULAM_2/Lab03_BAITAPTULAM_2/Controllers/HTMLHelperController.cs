using Lab03_BAITAPTULAM_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03_BAITAPTULAM_2.Controllers
{
    public class HTMLHelperController : Controller
    {
        // GET: HTMLHelper
        public ActionResult FormRegister()
        {
            // tạo list cho droplist
            ViewBag.listCompany = new List<Company>()
            {
                new Company(){Id="0",Name="-- Chọn Công ty --"},
                new Company(){Id="NN",Name="Đơn vị sự nghiệp nhà nước"},
                new Company(){Id="TN",Name="Đơn vị sự nghiệp tư nhân"},
                new Company(){Id="TNHH",Name="Công ty TNHH một thành viên"},
                new Company(){Id="CP",Name="Công ty cổ phần"},
                new Company(){Id="TNHH2",Name="Công ty TNHH từ 2 thành viên trở lên"}
            };
            return View();
        }
        public ActionResult Register() {
            // lấy giá trị được  các trường đẩy lên server khi submit 
            TempData["CName"] = Request["txtCName"];
            TempData["Company"] = Request["txtCompany"];
            TempData["Quantity"] = Request["txtQuantity"];
            TempData["Address"] = Request["txtAddress"];
            TempData["FName"] = Request["txtFName"];
            TempData["Phone"] = Request["txtPhone"];
            TempData["Fax"] = Request["txtFax"];
            TempData["Email"] = Request["txtEmail"];
            TempData["AEmail"] = Request["txtAEmail"];
            TempData["UName"] = Request["txtUName"];
            TempData["Pass"] = Request["txtPass"];
            TempData["Mail"] = Request["Mail"].ToString();
            return View();
        }
    }
}