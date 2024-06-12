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
    public class NttmSinhViensController : Controller
    {
        private NttmK22CNT4Lesson07DbEntities1 db = new NttmK22CNT4Lesson07DbEntities1();

        // GET: NttmSinhViens
        public ActionResult NttmIndex()
        {
            var nttmSinhViens = db.nttmSinhViens.Include(n => n.nttmKhoa);
            return View(nttmSinhViens.ToList());
        }

        // GET: NttmSinhViens/Details/5
        public ActionResult NttmDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nttmSinhVien nttmSinhVien = db.nttmSinhViens.Find(id);
            if (nttmSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nttmSinhVien);
        }

        // GET: NttmSinhViens/Create
        public ActionResult NttmCreate()
        {
            ViewBag.NttmMaKH = new SelectList(db.nttmKhoas, "nttmMaKH", "nttmTenKH");
            return View();
        }

        // POST: NttmSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmCreate([Bind(Include = "NttmMaSV,NttmHoSV,NttmTenSV,NttmPhai,NttmEmail,NttmPhone,NttmMaKH,NttmTrangThai")] nttmSinhVien nttmSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.nttmSinhViens.Add(nttmSinhVien);
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }

            ViewBag.NttmMaKH = new SelectList(db.nttmKhoas, "nttmMaKH", "nttmTenKH", nttmSinhVien.NttmMaKH);
            return View(nttmSinhVien);
        }

        // GET: NttmSinhViens/Edit/5
        public ActionResult NttmEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nttmSinhVien nttmSinhVien = db.nttmSinhViens.Find(id);
            if (nttmSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.NttmMaKH = new SelectList(db.nttmKhoas, "nttmMaKH", "nttmTenKH", nttmSinhVien.NttmMaKH);
            return View(nttmSinhVien);
        }

        // POST: NttmSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NttmMaSV,NttmHoSV,NttmTenSV,NttmPhai,NttmEmail,NttmPhone,NttmMaKH,NttmTrangThai")] nttmSinhVien nttmSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nttmSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }
            ViewBag.NttmMaKH = new SelectList(db.nttmKhoas, "nttmMaKH", "nttmTenKH", nttmSinhVien.NttmMaKH);
            return View(nttmSinhVien);
        }

        // GET: NttmSinhViens/Delete/5
        public ActionResult NttmDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nttmSinhVien nttmSinhVien = db.nttmSinhViens.Find(id);
            if (nttmSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nttmSinhVien);
        }

        // POST: NttmSinhViens/Delete/5
        [HttpPost, ActionName("NttmDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            nttmSinhVien nttmSinhVien = db.nttmSinhViens.Find(id);
            db.nttmSinhViens.Remove(nttmSinhVien);
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
