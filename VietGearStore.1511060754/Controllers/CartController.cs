using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VietGearStore._1511060754.Models;
namespace VietGearStore._1511060754.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult add()
        {
            return View();
        }
    }
}