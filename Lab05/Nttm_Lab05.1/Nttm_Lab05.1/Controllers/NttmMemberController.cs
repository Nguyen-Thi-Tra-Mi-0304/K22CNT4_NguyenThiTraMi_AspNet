using Nttm_Lab05._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nttm_Lab05._1.Controllers
{
    public class NttmMemberController : Controller
    {
        // GET: NttmMember/NttmCreateOne
        public ActionResult NttmCreateOne()
        {
            return View();
        }
        // POST: NttmMember/NttmCreateOne
        [HttpPost]
        public ActionResult NttmCreateOne(NttmMember m) {
            // Chuyển dữ liệu nhận được tới View NttmDetails
            return View("NttmDetails", m);
        }
        // GET: NttmMember/NttmCreateTwo 
        public ActionResult NttmCreateTwo()
        {
            return View();
        }
        // POST: NttmMember/NttmCreateTwo 
        [HttpPost]
        public ActionResult NttmCreateTwo(NttmMember m)
        {
            // kiểm tra trống các trường và thông báo lỗi tới View 
            if (m.Id == null)
            {
                ViewBag.error = "Nttm: Hãy nhập mã số";
                return View();
            }
            if (m.NttmUserName == null)
            {
                ViewBag.error = "Nttm: Hãy nhập tên đăng nhập";
                return View();
            }
            if (m.NttmFullName == null)
            {
                ViewBag.error = "Nttm: Hãy nhập tên họ và tên";
                return View();
            }
            if (m.NttmAge == null)
            {
                ViewBag.error = "Nttm: Hãy nhập tuổi";
                return View();
            }
            if (m.NttmEmail == null)
            {
                ViewBag.error = "Nttm: Hãy nhập Email";
                return View();
            }
            // mẫu kiểm tra Email 
            string regexPatter = @"[A-Za-z0-9.%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";
            if (!System.Text.RegularExpressions.Regex.IsMatch(m.NttmEmail, regexPatter))
            {
                ViewBag.error = "Nttm: Hãy nhập đúng định dạng";
                return View();
            }
            // nếu không xảy ra lỗi thì chuyển dữ liệu tới View NttmDetails
            return View("NttmDetails", m);
        }
        // GET: NttmMember/NttmCreateThree
        public ActionResult NttmCreateThree() {
            return View();
        }
        // POST: NttmMember/NttmCreateThree
        [HttpPost]
        public ActionResult NttmCreateThree(NttmMember m)
        {
            // nếu trạng thái dữ liệu Model hợp lệ thì chuyển dữ liệu tới View NttmDetails
            if (ModelState.IsValid)
                return View("NttmDetails",m);
            else
                return View(); // quay lại view Three để báo lỗi 
        }
        // GET: NttmMember / NttmDetails
        public ActionResult NttmDetails()
        {
            return View();
        }
    }
}