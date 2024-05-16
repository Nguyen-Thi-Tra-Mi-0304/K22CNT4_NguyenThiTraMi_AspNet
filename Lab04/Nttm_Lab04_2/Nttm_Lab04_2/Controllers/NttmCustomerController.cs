using Nttm_Lab04_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nttm_Lab04_2.Controllers
{
    public class NttmCustomerController : Controller
    {
        // GET: NttmCustomer
        //khai báo biến CustomerRepository
        static NttmCustomerRepository listCustomer;
        public NttmCustomerController()
        {
            //khởi tạo CustomerRepository
            listCustomer = new NttmCustomerRepository();
        }
        // GET: /Customer/GetCustomers
        public ActionResult NttmGetCustomers()
        {
            return View(listCustomer.NttmGetCustomers());
        }
        //POST: /Customer/GetCustomers
        [HttpPost]
        public ActionResult GetCustomers(string name)
        {
            return View(listCustomer.NttmSearchCustomer(name));
        }
        // GET: /Customer/Details/5
        public ActionResult Details(string id)
        {
            return View(listCustomer.NttmGetCustomer(id));
        }
        // GET: /Customer/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: /Customer/Create
        [HttpPost]
        public ActionResult Create(NttmCustomer cus)
        {
            listCustomer.NttmAddCustomer(cus);
            return RedirectToAction("GetCustomers");
        }
        // GET: /Customer/Edit/5
        public ActionResult Edit(string id)
        {
            return View(listCustomer.NttmGetCustomer(id));
        }
        // POST: /Customer/Edit
        [HttpPost]
        public ActionResult Edit(NttmCustomer cus)
        {
            listCustomer.NttmUpdateCustomer(cus);
            return RedirectToAction("GetCustomers");
        }
        // GET: /Customer/Delete/5
        public ActionResult Delete(string id)
        {
            listCustomer.NttmDeleteCustomer(listCustomer.NttmGetCustomer(id));
            return RedirectToAction("GetCustomers");
        }
    }
    }