﻿using System.Web.Mvc;

namespace VietGearStore._1511060754.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                 "admin_default",
                 "admin/{controller}/{action}/{id}",
                 new { controller = "Home", action = "Index", id = UrlParameter.Optional }
             );
        }
    }
}