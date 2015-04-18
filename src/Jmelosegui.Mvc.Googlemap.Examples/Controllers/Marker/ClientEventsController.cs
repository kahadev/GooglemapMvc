﻿using System.Web.Mvc;

namespace Jmelosegui.Mvc.Googlemap.Examples.Controllers
{
    public partial class MarkerController
    {
        public ActionResult ClientEvents(bool? clickable, bool? draggable)
        {
            ViewData["clickable"] = clickable ?? true;
            ViewData["draggable"] = draggable ?? true;
            return View();
        }
    }
}