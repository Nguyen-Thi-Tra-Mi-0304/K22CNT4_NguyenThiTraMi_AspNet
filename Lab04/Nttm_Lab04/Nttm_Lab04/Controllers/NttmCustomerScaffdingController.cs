using Nttm_Lab04.Models;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nttm_Lab04.Controllers
{
    public class NttmCustomerScaffdingController : Controller
    {
        // mockdata 
        private static List<NttmCustomer> listCustomer = new List<NttmCustomer>()
        {
            new NttmCustomer()
                {
                    CustomerID = 1,
                    FirstName = "Nguyễn Thị Trà",
                    LastName = "Mi",
                    Address = "K22Cnt4",
                    YearOfBirth = 2004
                },
            new NttmCustomer()
                {
                    CustomerID = 2,
                    FirstName = "Phạm Thị Thu",
                    LastName = "Huyền",
                    Address = "K22Cnt1",
                    YearOfBirth = 2004
                },
            new NttmCustomer()
                {
                    CustomerID = 3,
                    FirstName = "Phạm Thị Thu",
                    LastName = "Huyền 1",
                    Address = "K22Cnt2",
                    YearOfBirth = 2004
                },
            new NttmCustomer()
                {
                    CustomerID = 4,
                    FirstName = "Phạm Thị Thu",
                    LastName = "Huyền 2",
                    Address = "K22Cnt3",
                    YearOfBirth = 2004
                },
        };
        // GET: NttmCustomerScaffding
        // listCustomer
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult NttmCreate()
        {
            var model = new NttmCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult NttmCreate(NttmCustomer model)
        {
            // thêm mới đối tượng khách hàng vào danh sách dữ liệu
           listCustomer.Add(model);

            /* return View(model);*/
            // Chuyển về trang danh sách 
            return RedirectToAction("Index");
        }

        public ActionResult NttmEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerID==id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult NttmEdit(NttmCustomer customer)
        {
            var cus = listCustomer.FirstOrDefault(x => x.CustomerID == customer.CustomerID);
            // Sửa lại thông tin
            cus.CustomerID = customer.CustomerID;
            cus.FirstName = customer.FirstName;
            cus.LastName = customer.LastName;
            cus.Address = customer.Address;
            cus.YearOfBirth = customer.YearOfBirth;
            // Chuyển về trang danh sách 
            return RedirectToAction("Index");
        }

        // GET: //Detail/Id 
        public ActionResult NttmDetails (int? id)
        {
            // Tìm phần tử cần xem 
            var customer = listCustomer.FirstOrDefault (x => x.CustomerID == id);
            return View(customer);
        }


        // GET: //Delete/Id
        public ActionResult NttmDelete(int id)
        {
            var customer = listCustomer.FirstOrDefault(x => x.CustomerID == id);
            // Xóa 
            listCustomer.Remove(customer);
            return RedirectToAction("Index");
        }
    }
}