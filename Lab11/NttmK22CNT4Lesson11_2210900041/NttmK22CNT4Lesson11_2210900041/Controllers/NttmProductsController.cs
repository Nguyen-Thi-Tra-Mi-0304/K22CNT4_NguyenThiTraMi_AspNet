using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NttmK22CNT4Lesson11_2210900041.Models;

namespace NttmK22CNT4Lesson11_2210900041.Controllers
{
    public class NttmProductsController : Controller
    {
        private NttmK22CNT4Lesson11DbEntities db = new NttmK22CNT4Lesson11DbEntities();

        // GET: NttmProducts
        public ActionResult NttmIndex()
        {
            var nttmProducts = db.NttmProducts.Include(n => n.NttmCategory);
            return View(nttmProducts.ToList());
        }

        // GET: NttmProducts/Details/5
        public ActionResult Details(int? id)
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
        public ActionResult Create()
        {
            ViewBag.NttmCateId = new SelectList(db.NttmCategories, "NttmID", "NttmCateName");
            return View();
        }

        // POST: NttmProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NttmID2210900041,NttmProName,NttmQty,NttmPrice,NttmCateId,NttmActive")] NttmProduct nttmProduct)
        {
            if (ModelState.IsValid)
            {
                db.NttmProducts.Add(nttmProduct);
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }

            ViewBag.NttmCateId = new SelectList(db.NttmCategories, "NttmID", "NttmCateName", nttmProduct.NttmCateId);
            return View(nttmProduct);
        }

        // GET: NttmProducts/Edit/5
        public ActionResult Edit(int? id)
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
            ViewBag.NttmCateId = new SelectList(db.NttmCategories, "NttmID", "NttmCateName", nttmProduct.NttmCateId);
            return View(nttmProduct);
        }

        // POST: NttmProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NttmID2210900041,NttmProName,NttmQty,NttmPrice,NttmCateId,NttmActive")] NttmProduct nttmProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nttmProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }
            ViewBag.NttmCateId = new SelectList(db.NttmCategories, "NttmID", "NttmCateName", nttmProduct.NttmCateId);
            return View(nttmProduct);
        }

        // GET: NttmProducts/Delete/5
        public ActionResult Delete(int? id)
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
        [HttpPost, ActionName("Delete")]
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
