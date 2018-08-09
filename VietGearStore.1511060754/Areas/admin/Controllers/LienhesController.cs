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
    public class LienhesController : Controller
    {
        private datalinhkienEntities db = new datalinhkienEntities();

        // GET: admin/Lienhes
        public ActionResult Index()
        {
            return View(db.Lienhes.ToList());
        }

        // GET: admin/Lienhes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lienhe lienhe = db.Lienhes.Find(id);
            if (lienhe == null)
            {
                return HttpNotFound();
            }
            return View(lienhe);
        }

        // GET: admin/Lienhes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/Lienhes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,gmail,description,detail,datebegin")] Lienhe lienhe)
        {
            if (ModelState.IsValid)
            {
                db.Lienhes.Add(lienhe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lienhe);
        }

        // GET: admin/Lienhes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lienhe lienhe = db.Lienhes.Find(id);
            if (lienhe == null)
            {
                return HttpNotFound();
            }
            return View(lienhe);
        }

        // POST: admin/Lienhes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,gmail,description,detail,datebegin")] Lienhe lienhe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lienhe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lienhe);
        }

        // GET: admin/Lienhes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lienhe lienhe = db.Lienhes.Find(id);
            if (lienhe == null)
            {
                return HttpNotFound();
            }
            return View(lienhe);
        }

        // POST: admin/Lienhes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lienhe lienhe = db.Lienhes.Find(id);
            db.Lienhes.Remove(lienhe);
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
