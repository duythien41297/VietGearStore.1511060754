using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VietGearStore._1511060754.Models;

namespace VietGearStore._1511060754.Controllers
{
    public class GlobalController : Controller
    {
        datalinhkienEntities _db = new datalinhkienEntities();
        // GET: Global
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getMenu()
        {
            var v = from t in _db.Menus
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
        public ActionResult getMenuLeft()
        {
            var v = from t in _db.Categories
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
        public ActionResult getLienlac()
        {
            var v = from t in _db.Lienlacs
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
        public ActionResult getInfo()
        {
            var v = from t in _db.Infoes
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
        public ActionResult getSlide()
        {
            var v = from t in _db.Slides
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
        public ActionResult getLogo()
        {
            var v = from t in _db.Logoes
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
    }
}