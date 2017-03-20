using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PassmarProject.Models;

namespace PassmarProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            USUARIO usuario = new USUARIO()
            {
                USU_ID=1,
                USU_NOM = "Alain",
                USU_MAIL = "alain@gmail.com",
                USU_TEL = "5563234445",
                USU_ID_ROL = 1,
                USU_PASS = "1234"

            };
            return View(usuario);
        }
    }
}