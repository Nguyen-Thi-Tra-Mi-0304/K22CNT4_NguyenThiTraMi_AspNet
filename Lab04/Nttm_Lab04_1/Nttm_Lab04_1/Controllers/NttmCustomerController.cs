using Nttm_Lab04_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nttm_Lab04_1.Controllers
{
    public class NttmCustomerController : Controller
    {
        // GET: /Customer/CustomerDetail (action trả về thông tin chi tiết 1 khách hàng cho view CustomerDetail
        public ActionResult NttmCustomerDetail()
        {
            //tạo một đối tượng Customer 
            NttmCustomer cus = new NttmCustomer()
            {
                CustomerId = "2210900041",
                FullName = "Nguyễn Thị Trà Mi", 
                Address = "Hà Nội",
                Email = "traminguyen0304@gmail.com",
                Phone = "0963.225.045",
                Balance = 20000000
            };
            //cách 1 gán dữ liệu vào ViewBag để chuyển tới View
            //ViewBag.customer = cus;
            //return View();
            //có thể truyền dữ liệu qua đối tượng model để chuyển tới View
            return View(cus);
        }
        //GET /Product/CustomerList (action trả về danh sách khách hàng cho view CustomerList)
        public ActionResult NttmCustomerList()
        {
            // tạo một danh sách khách hàng 
            List<NttmCustomer> listCustomer = new List<NttmCustomer>()
            {
                new NttmCustomer() {CustomerId = "CNT001",
                FullName = "Nguyễn Thị Trà Mi",
                Address = "Hà Nội", Email="traminguyen0304@gmail.com",
                Phone="0962.225.045", Balance = 1000000},
                new NttmCustomer(){ CustomerId = "KH002", FullName = "Đỗ Thị Cúc",
                Address = "Hà Nội",Email = "cucdt@gmail.com",
                Phone = "0986.767.444",Balance = 2200000},
                new NttmCustomer(){ CustomerId = "KH003",
                FullName = "Nguyễn Tuấn Thắng",
                Address = "Nam Định",Email = "thangnt@gmail.com",
                Phone = "0924.656.542",Balance = 1200000},
                new NttmCustomer(){ CustomerId = "KH004", FullName = "Lê Ngọc Hải",
                Address = "Hà Nội",Email = "hailn@gmail.com",
                Phone = "0996.555.267",Balance = 6200000 }
            };
            //gán dữ liệu vào ViewBag để chuyển qua View
            ViewBag.listcustomer = listCustomer;
            return View();
        }
    }
}