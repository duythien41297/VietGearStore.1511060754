using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VietGearStore._1511060754.Models;

namespace VietGearStore._1511060754.Areas.admin.Controllers
{
    public class LienlacsController : Controller
    {
        private datalinhkienEntities db = new datalinhkienEntities();

        // GET: admin/Lienlacs
        public ActionResult Index()
        {
            return View(db.Lienlacs.ToList());
        }

        // GET: admin/Lienlacs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lienlac lienlac = db.Lienlacs.Find(id);
            if (lienlac == null)
            {
                return HttpNotFound();
            }
            return View(lienlac);
        }

        // GET: admin/Lienlacs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/Lienlacs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,hide,order,datebegin")] Lienlac lienlac)
        {
            if (ModelState.IsValid)
            {
                lienlac.datebegin = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                db.Lienlacs.Add(lienlac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lienlac);
        }

        // GET: admin/Lienlacs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lienlac lienlac = db.Lienlacs.Find(id);
            if (lienlac == null)
            {
                return HttpNotFound();
            }
            return View(lienlac);
        }

        // POST: admin/Lienlacs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,hide,order,datebegin")] Lienlac lienlac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lienlac).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lienlac);
        }

        // GET: admin/Lienlacs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lienlac lienlac = db.Lienlacs.Find(id);
            if (lienlac == null)
            {
                return HttpNotFound();
            }
            return View(lienlac);
        }

        // POST: admin/Lienlacs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lienlac lienlac = db.Lienlacs.Find(id);
            db.Lienlacs.Remove(lienlac);
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
