using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using NttmK22CNT4Lesson10.Models;

namespace NttmK22CNT4Lesson10.Controllers
{
    public class NttmAccountsController : Controller
    {
        private NttmK22CT4Lesson10Entities db = new NttmK22CT4Lesson10Entities();

        // GET: NttmAccounts
        public ActionResult Index()
        {
            return View(db.NttmAccounts.ToList());
        }

        // GET: NttmAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmAccount nttmAccount = db.NttmAccounts.Find(id);
            if (nttmAccount == null)
            {
                return HttpNotFound();
            }
            return View(nttmAccount);
        }

        // GET: NttmAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NttmAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NttmID,NttmUserName,NttmPassWord,NttmFullName,NttmEmail,NttmPhone,NttmActive")] NttmAccount nttmAccount)
        {
            if (ModelState.IsValid)
            {
                db.NttmAccounts.Add(nttmAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nttmAccount);
        }

        // GET: NttmAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmAccount nttmAccount = db.NttmAccounts.Find(id);
            if (nttmAccount == null)
            {
                return HttpNotFound();
            }
            return View(nttmAccount);
        }

        // POST: NttmAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NttmID,NttmUserName,NttmPassWord,NttmFullName,NttmEmail,NttmPhone,NttmActive")] NttmAccount nttmAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nttmAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nttmAccount);
        }

        // GET: NttmAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NttmAccount nttmAccount = db.NttmAccounts.Find(id);
            if (nttmAccount == null)
            {
                return HttpNotFound();
            }
            return View(nttmAccount);
        }

        // POST: NttmAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NttmAccount nttmAccount = db.NttmAccounts.Find(id);
            db.NttmAccounts.Remove(nttmAccount);
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

        // Login
        public ActionResult NttmLogin()
        {
            var nttmModel = new NttmAccount();
            return View(nttmModel);
        }
        [HttpPost]
        public ActionResult NttmLogin(NttmAccount nttmAccount)
        {
            var nttmCheck = db.NttmAccounts.Where(x => x.NttmUserName.Equals(nttmAccount.NttmUserName) && x.NttmPassWord.Equals(nttmAccount.NttmPassWord)).FirstOrDefault();
            if (nttmCheck != null)
            {
                // Lưu session 
                Session["NttmAccount"] = nttmCheck;
                return Redirect("/");
            }
            return View(nttmAccount);
        }
    }
}
