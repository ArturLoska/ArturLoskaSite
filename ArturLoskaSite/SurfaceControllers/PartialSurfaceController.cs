using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArturLoskaSite.SurfaceControllers
{
    public class PartialSurfaceController : SurfaceControler

    {
        // GET: PartialSurface
        public ActionResult Index()
        {
            return View();
        }
    }
}