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
    public class NttmCategoriesController : Controller
    {
        private NttmK22CNT4Lesson11DbEntities db = new NttmK22CNT4Lesson11DbEntities();

        // GET: NttmCategories
        public ActionResult NttmIndex()
        {
            return View(db.NttmCategories.ToList());
        }

        // GET: NttmCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmCategory nttmCategory = db.NttmCategories.Find(id);
            if (nttmCategory == null)
            {
                return HttpNotFound();
            }
            return View(nttmCategory);
        }

        // GET: NttmCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NttmCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NttmID,NttmCateName,NttmStatus")] NttmCategory nttmCategory)
        {
            if (ModelState.IsValid)
            {
                db.NttmCategories.Add(nttmCategory);
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }

            return View(nttmCategory);
        }

        // GET: NttmCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmCategory nttmCategory = db.NttmCategories.Find(id);
            if (nttmCategory == null)
            {
                return HttpNotFound();
            }
            return View(nttmCategory);
        }

        // POST: NttmCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NttmID,NttmCateName,NttmStatus")] NttmCategory nttmCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nttmCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }
            return View(nttmCategory);
        }

        // GET: NttmCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmCategory nttmCategory = db.NttmCategories.Find(id);
            if (nttmCategory == null)
            {
                return HttpNotFound();
            }
            return View(nttmCategory);
        }

        // POST: NttmCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NttmCategory nttmCategory = db.NttmCategories.Find(id);
            db.NttmCategories.Remove(nttmCategory);
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
