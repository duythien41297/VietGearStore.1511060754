using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VietGearStore._1511060754.Models;

namespace ShopOnline.Controllers
{
    public class ProductController : Controller
    {
        datalinhkienEntities _db = new datalinhkienEntities();
        // GET: Product
        public ActionResult Index(string meta)
        {
            var v = from t in _db.Categories
                    where t.meta == meta
                    select t;
            return View(v.FirstOrDefault());
        }
        public ActionResult Detail(long id)
        {
            var v = from t in _db.Products
                    where t.id == id
                    select t;
            return View(v.FirstOrDefault());
        }
    }
}