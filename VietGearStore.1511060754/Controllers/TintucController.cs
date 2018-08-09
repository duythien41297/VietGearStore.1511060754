using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VietGearStore._1511060754.Models;

namespace VietGearStore._1511060754.Controllers
{
    public class TintucController : Controller
    {
        datalinhkienEntities _db = new datalinhkienEntities();
        // GET: News
        public ActionResult Index()
        {
            var v = from t in _db.News
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
        public ActionResult Detailnews(string meta)
        {
            var v = from t in _db.News
                    where t.meta == meta
                    select t;
            return View(v.FirstOrDefault());
        }
    }
}