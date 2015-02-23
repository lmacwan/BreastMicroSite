﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace BreastMicroSite.Live
{
    public class GalleryController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var breadcrumbs = new List<BreadCrumbElement>();

            breadcrumbs.Add(new BreadCrumbElement()
            {
                Name = (string)model.Content.GetProperty("heading").Value,
                Value = "/" + model.Content.Name
            });

            ViewBag.BreadCrumbs = breadcrumbs;
            return base.Index(model);
        }

    }
}
