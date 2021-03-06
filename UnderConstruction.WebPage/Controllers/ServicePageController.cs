﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using UnderConstruction.WebPage.Models.Pages;

namespace UnderConstruction.WebPage.Controllers
{
    public class ServicePageController : PageControllerBase<ServicePage>
    {
        public ServicePageController(IContentLoader loader) : base(loader)
        {
        }

        public ActionResult Index(ServicePage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}