using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UmbracoTutorial.ViewModel;

namespace UmbracoTutorial.SurfaceController
{
    public class BlogPostSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        [System.Web.Http.HttpPost]
        public ActionResult CreateMessage(ContactViewModel model)
        {
            //model not valid -> not save, return to Umbraco Page
            if (!ModelState.IsValid)
            {
                ViewBag.Message = "Unable to send message!";
                return CurrentUmbracoPage();
            }

            TempData.Add("SuccessMessage","Your message was successfully submitted at" + DateTime.Now);

            return RedirectToCurrentUmbracoPage();
        }
    }
}