using Nttm_Lab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nttm_Lab04.Controllers
{
    public class NttmCustomerController : Controller
    {
        // GET: NttmCustomer
        public ActionResult Index()
        {
            return View();
        }

        // Action: NttmCustomerDetail
        public ActionResult NttmCustomerDetail() 
        {
            // Tạo đối tượng dữ liệu 
            var customer = new NttmCustomer()
            {
                CustomerID = 1, 
                FirstName = "Nguyễn Thị Trà",
                LastName = "Mi",
                Address = "K22Cnt4",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            return View();
        }

        // GET: NttmListCustomer
        public ActionResult NttmListCustomer()
        {
            var list = new List<NttmCustomer>()
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
                    Address = "K22Cnt4",
                    YearOfBirth = 2004
                },
                new NttmCustomer()
                {
                    CustomerID = 3,
                    FirstName = "Phạm Thị Thu",
                    LastName = "Huyền 1",
                    Address = "K22Cnt4",
                    YearOfBirth = 2004
                },
                new NttmCustomer()
                {
                    CustomerID = 4,
                    FirstName = "Phạm Thị Thu",
                    LastName = "Huyền 2",
                    Address = "K22Cnt4",
                    YearOfBirth = 2004
                },
        };
        ViewBag.list = list; // Đưa dữ liệu ra view bằng đối tượng ViewBag
            return View(list);
        }
    }
}