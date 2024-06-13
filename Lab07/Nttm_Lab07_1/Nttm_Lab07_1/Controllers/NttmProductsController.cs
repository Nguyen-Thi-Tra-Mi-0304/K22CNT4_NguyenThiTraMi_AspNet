using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nttm_Lab07_1.Models;

namespace Nttm_Lab07_1.Controllers
{
    public class NttmProductsController : Controller
    {
        private NttmShopContext db = new NttmShopContext();

        // GET: NttmProducts
        public ActionResult NttmIndex()
        {
            return View(db.NttmProducts.ToList());
        }

        // GET: NttmProducts/Details/5
        public ActionResult NttmDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmProduct nttmProduct = db.NttmProducts.Find(id);
            if (nttmProduct == null)
            {
                return HttpNotFound();
            }
            return View(nttmProduct);
        }

        // GET: NttmProducts/Create
        public ActionResult NttmCreate()
        {
            return View();
        }

        // POST: NttmProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmCreate([Bind(Include = "NttmProductId,NttmProductName,NttmPrice")] NttmProduct nttmProduct)
        {
            if (ModelState.IsValid)
            {
                db.NttmProducts.Add(nttmProduct);
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }

            return View(nttmProduct);
        }

        // GET: NttmProducts/Edit/5
        public ActionResult NttmEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmProduct nttmProduct = db.NttmProducts.Find(id);
            if (nttmProduct == null)
            {
                return HttpNotFound();
            }
            return View(nttmProduct);
        }

        // POST: NttmProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmEdit([Bind(Include = "NttmProductId,NttmProductName,NttmPrice")] NttmProduct nttmProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nttmProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }
            return View(nttmProduct);
        }

        // GET: NttmProducts/Delete/5
        public ActionResult NttmDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmProduct nttmProduct = db.NttmProducts.Find(id);
            if (nttmProduct == null)
            {
                return HttpNotFound();
            }
            return View(nttmProduct);
        }

        // POST: NttmProducts/Delete/5
        [HttpPost, ActionName("NttmDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NttmProduct nttmProduct = db.NttmProducts.Find(id);
            db.NttmProducts.Remove(nttmProduct);
            db.SaveChanges();
            return RedirectToAction("NttmIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
