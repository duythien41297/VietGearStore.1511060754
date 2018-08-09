using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VietGearStore._1511060754.Models;

namespace VietGearStore._1511060754.Controllers
{
    public class LienheController : Controller
    {
        private datalinhkienEntities db = new datalinhkienEntities();

        // GET: Lienhes
        public ActionResult Create()
        {
            return View();
        }
        // POST: Lienhes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,gmail,description,detail,datebegin")] Lienhe lienhe)
        {
            if (ModelState.IsValid)
            {
                lienhe.datebegin = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                db.Lienhes.Add(lienhe);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(lienhe);
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
