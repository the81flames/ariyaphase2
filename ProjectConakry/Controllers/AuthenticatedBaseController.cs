﻿using ProjectConakry.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ProjectConakry.Web.Ariya.Controllers
{
    public class AuthenticatedBaseController : Controller
    {

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            CustomPrincipal principal = System.Web.HttpContext.Current.Session["currentUser"] as CustomPrincipal;
            ViewBag.UserId = principal == null ? new Customer().Id : (principal.Customer as Customer).Id;
            ViewBag.ImagePath = ControllerConstants.ImagePath;
        }

        
    }
}
