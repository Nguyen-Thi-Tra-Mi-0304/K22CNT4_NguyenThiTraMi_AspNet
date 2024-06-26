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
    public class NttmSinhViensController : Controller
    {
        private NttmK22CNT4QLSinhVienEntities3 db = new NttmK22CNT4QLSinhVienEntities3();

        // GET: NttmSinhViens
        public ActionResult NttmIndex()
        {
            var nttmSinhViens = db.NttmSinhViens.Include(n => n.NttmKhoa);
            return View(nttmSinhViens.ToList());
        }

        // GET: NttmSinhViens/Details/5
        public ActionResult NttmDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmSinhVien nttmSinhVien = db.NttmSinhViens.Find(id);
            if (nttmSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nttmSinhVien);
        }

        // GET: NttmSinhViens/Create
        public ActionResult NttmCreate()
        {
            ViewBag.NttmMaKH = new SelectList(db.NttmKhoas, "NttmMaKH", "NttmTenKH");
            return View();
        }

        // POST: NttmSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmCreate([Bind(Include = "NttmMaSV,NttmHoSV,NttmTenSV,NttmPhai,NttmNgaySinh,NttmNoiSinh,NttmMaKH,NttmHocBong,NttmDiemTrungBinh")] NttmSinhVien nttmSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.NttmSinhViens.Add(nttmSinhVien);
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }

            ViewBag.NttmMaKH = new SelectList(db.NttmKhoas, "NttmMaKH", "NttmTenKH", nttmSinhVien.NttmMaKH);
            return View(nttmSinhVien);
        }

        // GET: NttmSinhViens/Edit/5
        public ActionResult NttmEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmSinhVien nttmSinhVien = db.NttmSinhViens.Find(id);
            if (nttmSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.NttmMaKH = new SelectList(db.NttmKhoas, "NttmMaKH", "NttmTenKH", nttmSinhVien.NttmMaKH);
            return View(nttmSinhVien);
        }

        // POST: NttmSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmEdit([Bind(Include = "NttmMaSV,NttmHoSV,NttmTenSV,NttmPhai,NttmNgaySinh,NttmNoiSinh,NttmMaKH,NttmHocBong,NttmDiemTrungBinh")] NttmSinhVien nttmSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nttmSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }
            ViewBag.NttmMaKH = new SelectList(db.NttmKhoas, "NttmMaKH", "NttmTenKH", nttmSinhVien.NttmMaKH);
            return View(nttmSinhVien);
        }

        // GET: NttmSinhViens/Delete/5
        public ActionResult NttmDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmSinhVien nttmSinhVien = db.NttmSinhViens.Find(id);
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
            NttmSinhVien nttmSinhVien = db.NttmSinhViens.Find(id);
            db.NttmSinhViens.Remove(nttmSinhVien);
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
