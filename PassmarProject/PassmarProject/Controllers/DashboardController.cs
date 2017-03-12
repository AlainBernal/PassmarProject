using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassmarProject.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dasboard
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}