using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NttmLesson07.Models;

namespace NttmLesson07.Controllers
{
    public class NttmKhoasController : Controller
    {
        private NttmK22CNT4Lesson07DbEntities1 db = new NttmK22CNT4Lesson07DbEntities1();

        // GET: NttmKhoas
        public ActionResult NttmIndex()
        {
            return View(db.nttmKhoas.ToList());
        }

        // GET: NttmKhoas/Details/5
        public ActionResult NttmDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nttmKhoa nttmKhoa = db.nttmKhoas.Find(id);
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
        public ActionResult NttmCreate([Bind(Include = "nttmMaKH,nttmTenKH,nttmTrangThai")] nttmKhoa nttmKhoa)
        {
            if (ModelState.IsValid)
            {
                db.nttmKhoas.Add(nttmKhoa);
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
            nttmKhoa nttmKhoa = db.nttmKhoas.Find(id);
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
        public ActionResult NttmEdit([Bind(Include = "nttmMaKH,nttmTenKH,nttmTrangThai")] nttmKhoa nttmKhoa)
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
            nttmKhoa nttmKhoa = db.nttmKhoas.Find(id);
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
            nttmKhoa nttmKhoa = db.nttmKhoas.Find(id);
            db.nttmKhoas.Remove(nttmKhoa);
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
