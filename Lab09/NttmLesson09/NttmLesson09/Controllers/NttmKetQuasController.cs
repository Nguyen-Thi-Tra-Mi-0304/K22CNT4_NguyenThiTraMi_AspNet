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
    public class NttmKetQuasController : Controller
    {
        private NttmK22CNT4QLSinhVienEntities3 db = new NttmK22CNT4QLSinhVienEntities3();

        // GET: NttmKetQuas
        public ActionResult NttmIndex()
        {
            var nttmKetQuas = db.NttmKetQuas.Include(n => n.NttmMonHoc).Include(n => n.NttmSinhVien);
            return View(nttmKetQuas.ToList());
        }

        // GET: NttmKetQuas/Details/5
        public ActionResult NttmDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmKetQua nttmKetQua = db.NttmKetQuas.Find(id);
            if (nttmKetQua == null)
            {
                return HttpNotFound();
            }
            return View(nttmKetQua);
        }

        // GET: NttmKetQuas/Create
        public ActionResult NttmCreate()
        {
            ViewBag.NttmMaMH = new SelectList(db.NttmMonHocs, "NttmMaMH", "NttmTenMH");
            ViewBag.NttmMaSV = new SelectList(db.NttmSinhViens, "NttmMaSV", "NttmTenSV");
            return View();
        }

        // POST: NttmKetQuas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmCreate([Bind(Include = "NttmKQ,NttmMaSV,NttmMaMH,NttmDiem")] NttmKetQua nttmKetQua)
        {
            if (ModelState.IsValid)
            {
                db.NttmKetQuas.Add(nttmKetQua);
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }

            ViewBag.NttmMaMH = new SelectList(db.NttmMonHocs, "NttmMaMH", "NttmTenMH", nttmKetQua.NttmMaMH);
            ViewBag.NttmMaSV = new SelectList(db.NttmSinhViens, "NttmMaSV", "NttmHoSV", nttmKetQua.NttmMaSV);
            return View(nttmKetQua);
        }

        // GET: NttmKetQuas/Edit/5
        public ActionResult NttmEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmKetQua nttmKetQua = db.NttmKetQuas.Find(id);
            if (nttmKetQua == null)
            {
                return HttpNotFound();
            }
            ViewBag.NttmMaMH = new SelectList(db.NttmMonHocs, "NttmMaMH", "NttmTenMH", nttmKetQua.NttmMaMH);
            ViewBag.NttmMaSV = new SelectList(db.NttmSinhViens, "NttmMaSV", "NttmHoSV", nttmKetQua.NttmMaSV);
            return View(nttmKetQua);
        }

        // POST: NttmKetQuas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmEdit([Bind(Include = "NttmKQ,NttmMaSV,NttmMaMH,NttmDiem")] NttmKetQua nttmKetQua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nttmKetQua).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }
            ViewBag.NttmMaMH = new SelectList(db.NttmMonHocs, "NttmMaMH", "NttmTenMH", nttmKetQua.NttmMaMH);
            ViewBag.NttmMaSV = new SelectList(db.NttmSinhViens, "NttmMaSV", "NttmHoSV", nttmKetQua.NttmMaSV);
            return View(nttmKetQua);
        }

        // GET: NttmKetQuas/Delete/5
        public ActionResult NttmDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmKetQua nttmKetQua = db.NttmKetQuas.Find(id);
            if (nttmKetQua == null)
            {
                return HttpNotFound();
            }
            return View(nttmKetQua);
        }

        // POST: NttmKetQuas/Delete/5
        [HttpPost, ActionName("NttmDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NttmKetQua nttmKetQua = db.NttmKetQuas.Find(id);
            db.NttmKetQuas.Remove(nttmKetQua);
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
