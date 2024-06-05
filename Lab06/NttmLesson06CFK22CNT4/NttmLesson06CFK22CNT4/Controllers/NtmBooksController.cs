using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NttmLesson06CFK22CNT4.Models;

namespace NttmLesson06CFK22CNT4.Controllers
{
    public class NtmBooksController : Controller
    {
        private NttmBookStore db = new NttmBookStore();

        // GET: NtmBooks
        public ActionResult Index()
        {
            return View(db.NttmBooks.ToList());
        }

        // GET: NtmBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NtmBook ntmBook = db.NttmBooks.Find(id);
            if (ntmBook == null)
            {
                return HttpNotFound();
            }
            return View(ntmBook);
        }

        // GET: NtmBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NtmBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NttmId,NttmBookId,NttmTitle,NttmAuthor,NttmYear,NttmPublisher,NttmPicture,NttmCategoryId")] NtmBook ntmBook)
        {
            if (ModelState.IsValid)
            {
                db.NttmBooks.Add(ntmBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ntmBook);
        }

        // GET: NtmBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NtmBook ntmBook = db.NttmBooks.Find(id);
            if (ntmBook == null)
            {
                return HttpNotFound();
            }
            return View(ntmBook);
        }

        // POST: NtmBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NttmId,NttmBookId,NttmTitle,NttmAuthor,NttmYear,NttmPublisher,NttmPicture,NttmCategoryId")] NtmBook ntmBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ntmBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ntmBook);
        }

        // GET: NtmBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NtmBook ntmBook = db.NttmBooks.Find(id);
            if (ntmBook == null)
            {
                return HttpNotFound();
            }
            return View(ntmBook);
        }

        // POST: NtmBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NtmBook ntmBook = db.NttmBooks.Find(id);
            db.NttmBooks.Remove(ntmBook);
            db.SaveChanges();
            return RedirectToAction("Index");
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
