using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NttmLesson09.Models;

namespace NttmLesson09.Controllers
{
    public class NttmMonHocsController : Controller
    {
        private NttmK22CNT4QLSinhVienEntities3 db = new NttmK22CNT4QLSinhVienEntities3();

        // GET: NttmMonHocs
        public ActionResult NttmIndex()
        {
            return View(db.NttmMonHocs.ToList());
        }

        // GET: NttmMonHocs/Details/5
        public ActionResult NttmDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmMonHoc nttmMonHoc = db.NttmMonHocs.Find(id);
            if (nttmMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(nttmMonHoc);
        }

        // GET: NttmMonHocs/Create
        public ActionResult NttmCreate()
        {
            return View();
        }

        // POST: NttmMonHocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmCreate([Bind(Include = "NttmMaMH,NttmTenMH,NttmSoTiet")] NttmMonHoc nttmMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.NttmMonHocs.Add(nttmMonHoc);
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }

            return View(nttmMonHoc);
        }

        // GET: NttmMonHocs/Edit/5
        public ActionResult NttmEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmMonHoc nttmMonHoc = db.NttmMonHocs.Find(id);
            if (nttmMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(nttmMonHoc);
        }

        // POST: NttmMonHocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmEdit([Bind(Include = "NttmMaMH,NttmTenMH,NttmSoTiet")] NttmMonHoc nttmMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nttmMonHoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }
            return View(nttmMonHoc);
        }

        // GET: NttmMonHocs/Delete/5
        public ActionResult NttmDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmMonHoc nttmMonHoc = db.NttmMonHocs.Find(id);
            if (nttmMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(nttmMonHoc);
        }

        // POST: NttmMonHocs/Delete/5
        [HttpPost, ActionName("NttmDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NttmMonHoc nttmMonHoc = db.NttmMonHocs.Find(id);
            db.NttmMonHocs.Remove(nttmMonHoc);
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
