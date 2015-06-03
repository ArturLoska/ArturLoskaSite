using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using UmbracoTutorial.ViewModel;

namespace UmbracoTutorial.Controllers
{
    public class HomeController : Umbraco.Web.Mvc.RenderMvcController
    {
        public ActionResult NewPartPopActionResult(RenderModel model)
        {
            return PartialView("~/Views/PartialView/YoutubeNew.cshtml");
        }

        public ActionResult RenPartPopActionResult()
        {
            return PartialView("~/Views/PartialView/YoutubePop.cshtml");
        }

        public ActionResult RenPartRecActionResult()
        {
            return PartialView("~/Views/PartialView/YoutubeRec.cshtml");
        }
        
    }
}