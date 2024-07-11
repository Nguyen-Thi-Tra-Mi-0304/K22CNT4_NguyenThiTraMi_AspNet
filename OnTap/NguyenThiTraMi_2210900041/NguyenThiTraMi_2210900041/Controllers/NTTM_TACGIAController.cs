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
    public class NTTM_TACGIAController : Controller
    {
        private NguyenThiTraMi_2210900041Entities db = new NguyenThiTraMi_2210900041Entities();

        // GET: NTTM_TACGIA
        public ActionResult NttmIndex()
        {
            return View(db.NTTM_TACGIA.ToList());
        }

        // GET: NTTM_TACGIA/Details/5
        public ActionResult NttmDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTTM_TACGIA nTTM_TACGIA = db.NTTM_TACGIA.Find(id);
            if (nTTM_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nTTM_TACGIA);
        }

        // GET: NTTM_TACGIA/Create
        public ActionResult NttmCreate()
        {
            return View();
        }

        // POST: NTTM_TACGIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmCreate([Bind(Include = "Nttm_MaTG,Nttm_TenTacGia")] NTTM_TACGIA nTTM_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.NTTM_TACGIA.Add(nTTM_TACGIA);
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }

            return View(nTTM_TACGIA);
        }

        // GET: NTTM_TACGIA/Edit/5
        public ActionResult NttmEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTTM_TACGIA nTTM_TACGIA = db.NTTM_TACGIA.Find(id);
            if (nTTM_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nTTM_TACGIA);
        }

        // POST: NTTM_TACGIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NttmEdit([Bind(Include = "Nttm_MaTG,Nttm_TenTacGia")] NTTM_TACGIA nTTM_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nTTM_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NttmIndex");
            }
            return View(nTTM_TACGIA);
        }

        // GET: NTTM_TACGIA/Delete/5
        public ActionResult NttmDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTTM_TACGIA nTTM_TACGIA = db.NTTM_TACGIA.Find(id);
            if (nTTM_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nTTM_TACGIA);
        }

        // POST: NTTM_TACGIA/Delete/5
        [HttpPost, ActionName("NttmDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NTTM_TACGIA nTTM_TACGIA = db.NTTM_TACGIA.Find(id);
            db.NTTM_TACGIA.Remove(nTTM_TACGIA);
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
