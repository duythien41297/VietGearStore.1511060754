using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VietGearStore._1511060754.Models;

namespace VietGearStore._1511060754.Controllers
{
    public class GioithieuController : Controller
    {
        datalinhkienEntities _db = new datalinhkienEntities();
        // GET: Gioithieu
        public ActionResult Index()
        {
            var v = from t in _db.Abouts
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
    }
}