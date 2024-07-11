using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NguyenThiTraMi_2210900041.Models;

namespace NguyenThiTraMi_2210900041.Controllers
{
    public class NTTM_SACHController : Controller
    {
        private NguyenThiTraMi_2210900041Entities db = new NguyenThiTraMi_2210900041Entities();

        // GET: NTTM_SACH
        public ActionResult NttmIndex()
        {
            var nTTM_SACH = db.NTTM_SACH.Include(n => n.NTTM_TACGIA);
            return View(nTTM_SACH.ToList());
        }

        // GET: NTTM_SACH/Details/5
        public ActionResult NttmDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTTM_SACH nTTM_SACH = db.NTTM_SACH.Find(id);
            if (nTTM_SACH == null)
            {
                return HttpNotFound();
            }
            return View(nTTM_SACH);
        }

        // GET: NTTM_SACH/Create
        public ActionResult NttmCreate()
        {
            ViewBag.Nttm_MaTG = new SelectList(db.NTTM_TACGIA, "Nttm_MaTG", "Nttm_TenTacGia");
            return View();
        }

        // POST: NTTM_SACH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmCreate([Bind(Include = "Nttm_MaSach,Nttm_TenSach,Nttm_SoTrang,Nttm_NamXB,Nttm_MaTG,Nttm_TrangThai")] NTTM_SACH nTTM_SACH)
        {
            if (ModelState.IsValid)
            {
                db.NTTM_SACH.Add(nTTM_SACH);
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }

            ViewBag.Nttm_MaTG = new SelectList(db.NTTM_TACGIA, "Nttm_MaTG", "Nttm_TenTacGia", nTTM_SACH.Nttm_MaTG);
            return View(nTTM_SACH);
        }

        // GET: NTTM_SACH/Edit/5
        public ActionResult NttmEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTTM_SACH nTTM_SACH = db.NTTM_SACH.Find(id);
            if (nTTM_SACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.Nttm_MaTG = new SelectList(db.NTTM_TACGIA, "Nttm_MaTG", "Nttm_TenTacGia", nTTM_SACH.Nttm_MaTG);
            return View(nTTM_SACH);
        }

        // POST: NTTM_SACH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmEdit([Bind(Include = "Nttm_MaSach,Nttm_TenSach,Nttm_SoTrang,Nttm_NamXB,Nttm_MaTG,Nttm_TrangThai")] NTTM_SACH nTTM_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nTTM_SACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }
            ViewBag.Nttm_MaTG = new SelectList(db.NTTM_TACGIA, "Nttm_MaTG", "Nttm_TenTacGia", nTTM_SACH.Nttm_MaTG);
            return View(nTTM_SACH);
        }

        // GET: NTTM_SACH/Delete/5
        public ActionResult NttmDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTTM_SACH nTTM_SACH = db.NTTM_SACH.Find(id);
            if (nTTM_SACH == null)
            {
                return HttpNotFound();
            }
            return View(nTTM_SACH);
        }

        // POST: NTTM_SACH/Delete/5
        [HttpPost, ActionName("NttmDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NTTM_SACH nTTM_SACH = db.NTTM_SACH.Find(id);
            db.NTTM_SACH.Remove(nTTM_SACH);
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
