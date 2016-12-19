﻿
namespace Serene.Common.Pages
{
    using Serenity;
    using Serenity.Data;
    using System;
    using System.Web.Mvc;

    [RoutePrefix("Dashboard"), Route("{action=index}")]
    public class DashboardController : Controller
    {
        [Authorize, HttpGet, Route("~/")]
        public ActionResult Index()
        {
            var cachedModel = new DashboardPageModel()
            {
            };

            return View(MVC.Views.Common.Dashboard.DashboardIndex, cachedModel);
        }
    }
}