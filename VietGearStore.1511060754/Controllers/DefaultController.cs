using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VietGearStore._1511060754.Models;

namespace ShopOnline.Controllers
{
    public class DefaultController : Controller
    {
        datalinhkienEntities _db = new datalinhkienEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getCategory()
        {
            //var category = _db.Menus.Where(x => x.Id == 3).FirstOrDefault();
            ViewBag.meta = "danh-muc";
            var v = from t in _db.Categories
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
        public ActionResult getProduct(long id, string metatitle)
        {
            //ViewBag.Metatitle = metatitle;
            var v = from t in _db.Products
                    where t.categoryid == id && t.hide == true
                    orderby t.order ascending
                    select t;

            return PartialView(v.ToList());
        }
    }
}