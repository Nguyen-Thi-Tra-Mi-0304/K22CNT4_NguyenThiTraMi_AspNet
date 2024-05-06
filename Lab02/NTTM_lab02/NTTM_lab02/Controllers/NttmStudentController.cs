using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTTM_lab02.Controllers
{
    public class NttmStudentController : Controller
    {
        /// <summary>
        /// Author: Nguyễn Thị Trà Mi
        /// Class: K22CNT4
        /// </summary>
        /// <returns></returns>
        // GET: NttmStudent
        public ActionResult Index()
        {
            // Truyền dữ liệu từ Controller -> View 
            ViewBag.fullName = "Nguyễn Thị Trà Mi";
            ViewData["Birthday"] = "03/04/2004";
            TempData["Phone"] = "0963225045";
            return View();
        }
        public ActionResult Details() {
            string nttmstr = "";
            nttmstr += "<h3>Họ và tên: Nguyễn Thị Trà Mi </h3>";
            nttmstr += "<p> Mã sinh viên: 2210900041 </p>";
            nttmstr += "<p> Địa chỉ mail: traminguyen0304@gmail.com </p>";

            ViewBag.Details = nttmstr;

            return View("chiTiet");
        }

        public ActionResult NgonNguRazor() {
            string[] names = { "Trần Văn A", "Nguyễn Thị B", "Lê Đại C", "Trịnh Lê D" };
            ViewBag.names = names;
            return View();
        }

        // HTMLHelper
        // GET: NttmStudent/AddNewStudent
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            // lấy dữ liệu trên form
            string fullname = form["fullName"];
            string masv = form["MaSV"];
            string TaiKhoan = form["TaiKhoan"];
            string Matkhau = form["Matkhau"];

            string nttmStr = "<h3>" + fullname + "</h3>";
            nttmStr += "<p>" + masv + "</p>";
            nttmStr += "<p>" + TaiKhoan + "</p>";
            nttmStr += "<p>" + Matkhau + "</p>";

            ViewBag.info = nttmStr;

            return View("Ketqua");
        }
    }
}