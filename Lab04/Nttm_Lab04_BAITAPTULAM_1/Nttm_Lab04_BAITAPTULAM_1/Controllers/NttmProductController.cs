using Nttm_Lab04_BAITAPTULAM_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nttm_Lab04_BAITAPTULAM_1.Controllers
{
    public class NttmProductController : Controller
    {
        private readonly NttmIProductsRespository productRepository;
        public NttmProductController()
        {
            productRepository = new NttmProductRespository();
            return; 
        }

        // GET: NttmProduct
        public ActionResult Index()
        {
            var products = productRepository.NttmGetProducts();
            return View(products);
        }

        // POST: NttmProduct/Index
        [HttpPost]
        public ActionResult Index(string name)
        {
            var products = productRepository.NttmSearchCustomer(name);
            return View(products);
        }

        // GET: Product/Details/id
        public ActionResult NttmDetails(string id)
        {
            var product = productRepository.NttmGetProducts(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        // GET: Product/Create
        public ActionResult NttmCreate()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmCreate(NttmProducts product)
        {
            if (ModelState.IsValid)
            {
                productRepository.NttmAddCustomer(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Product/Edit/id
        public ActionResult NttmEdit(string id)
        {
            var product = productRepository.NttmGetProducts(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        // POST: Product/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmEdit(NttmProducts product)
        {
            if (ModelState.IsValid)
            {
                productRepository.NttmUpdateCustomer(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Product/Delete/id
        public ActionResult NttmDelete(string id)
        {
            var product = productRepository.NttmGetProducts(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Product/Delete/id
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult NttmDeleteConfirmed(string id)
        {
            var product = productRepository.NttmGetProducts(id);
            if (product != null)
            {
                productRepository.NttmDeleteCustomer(product);
            }
            return RedirectToAction("Index");
        }

        // GET: Product/Search
        public ActionResult NttmSearch(string name)
        {
            var products = productRepository.NttmSearchCustomer(name);
            return View("Index", products);
        }

    }
}