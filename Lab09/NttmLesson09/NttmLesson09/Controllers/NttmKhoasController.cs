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
    public class NttmKhoasController : Controller
    {
        private NttmK22CNT4QLSinhVienEntities3 db = new NttmK22CNT4QLSinhVienEntities3();

        // GET: NttmKhoas
        public ActionResult NttmIndex()
        {
            return View(db.NttmKhoas.ToList());
        }

        // GET: NttmKhoas/Details/5
        public ActionResult NttmDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmKhoa nttmKhoa = db.NttmKhoas.Find(id);
            if (nttmKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nttmKhoa);
        }

        // GET: NttmKhoas/Create
        public ActionResult NttmCreate()
        {
            return View();
        }

        // POST: NttmKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmCreate([Bind(Include = "NttmMaKH,NttmTenKH")] NttmKhoa nttmKhoa)
        {
            if (ModelState.IsValid)
            {
                db.NttmKhoas.Add(nttmKhoa);
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }

            return View(nttmKhoa);
        }

        // GET: NttmKhoas/Edit/5
        public ActionResult NttmEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmKhoa nttmKhoa = db.NttmKhoas.Find(id);
            if (nttmKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nttmKhoa);
        }

        // POST: NttmKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmEdit([Bind(Include = "NttmMaKH,NttmTenKH")] NttmKhoa nttmKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nttmKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }
            return View(nttmKhoa);
        }

        // GET: NttmKhoas/Delete/5
        public ActionResult NttmDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmKhoa nttmKhoa = db.NttmKhoas.Find(id);
            if (nttmKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nttmKhoa);
        }

        // POST: NttmKhoas/Delete/5
        [HttpPost, ActionName("NttmDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NttmKhoa nttmKhoa = db.NttmKhoas.Find(id);
            db.NttmKhoas.Remove(nttmKhoa);
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
