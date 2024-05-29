using Nttm_BaiThiGiuaKy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nttm_BaiThiGiuaKy.Controllers
{
    public class NttmCustormerController : Controller
    {
        private static List<NttmCustormer> nttmCustormers = new List<NttmCustormer>()
        {
            new NttmCustormer{Nttm2210900041_CustId="221090041",Nttm_FullName="Nguyễn Thị Trà Mi", Nttm_Address="Hà Nội",
                Nttm_Email="traminguyen0304@gmail.com",Nttm_Phone="0963225045",Nttm_Balance=1},
            new NttmCustormer{Nttm2210900041_CustId="1",Nttm_FullName="Trà Mi", Nttm_Address="Hà Nội",
                Nttm_Email="traminguyen0304@gmail.com",Nttm_Phone="0963225045",Nttm_Balance=0}
        };
        // GET: NttmCustormer
        /// <summary>
        /// Hiển thị danh sách Customer 
        /// Author: Nguyễn Thị Trà Mi
        /// </summary>
        /// <returns></returns>
        public ActionResult NttmIndex()
        {
            return View(nttmCustormers);
        }
        // GET: NttmCreate / ID 
        /// <summary>
        /// Xem thông tin chi tiết khách hàng 
        /// Author: Nguyễn Thị Trà Mi 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult NttmCreate(string id)
        {
            // Tìm phần tử cần xem 
            var customer = nttmCustormers.FirstOrDefault(x => x.Nttm2210900041_CustId == id);
            return View(customer);
        }
        // GET: NttmDetail 
        /// <summary>
        /// From thêm mới khách hàng 
        /// Author: Nguyễn Thị Trà Mi
        /// </summary>
        /// <returns></returns>
        public ActionResult NttmDetail()
        {
            var nttmCustomer = new NttmCustormer();
            return View(nttmCustomer);
        }
        [HttpPost]
        public ActionResult NttmDetail(NttmCustormer nttmCustormer)
        {
            // thêm mới đối tượng Customer vào danh sách 
            nttmCustormers.Add(nttmCustormer);
            // Chuyển về trang danh sách 
            return RedirectToAction("NttmIndex");
        }
        // GET: NttmEdit 
        /// <summary>
        /// From sửa thông tin khách hàng 
        /// Author: Nguyễn Thị Trà Mi
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult NttmEdit(string id)
        {
            var customer = nttmCustormers.FirstOrDefault(x => x.Nttm2210900041_CustId == id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult NttmEdit(NttmCustormer customer)
        {
            var nttmcus = nttmCustormers.FirstOrDefault(x => x.Nttm2210900041_CustId == customer.Nttm2210900041_CustId);
            // Sửa lại thông tin
            nttmcus.Nttm2210900041_CustId = customer.Nttm2210900041_CustId;
            nttmcus.Nttm_FullName = customer.Nttm_FullName;
            nttmcus.Nttm_Address = customer.Nttm_Address;
            nttmcus.Nttm_Email = customer.Nttm_Email;
            nttmcus.Nttm_Phone = customer.Nttm_Phone;
            nttmcus.Nttm_Balance = customer.Nttm_Balance;

            return RedirectToAction("NttmIndex");
        }
        // GET: NttmDelete 
        /// <summary>
        /// Xóa khách hàng 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult NttmDelete(string id)
        {
            var customer = nttmCustormers.FirstOrDefault(x => x.Nttm2210900041_CustId == id);
            // Xóa 
            nttmCustormers.Remove(customer);
            return RedirectToAction("NttmIndex");
        }
    }
}