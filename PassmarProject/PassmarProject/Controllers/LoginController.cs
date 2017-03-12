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
            Usuario usuario = new Usuario()
            {
                usu_id = 1,
                usu_nom = "Alain",
                usu_mail = "alain@gmail.com",
                usu_tel = "5563234445",
                usu_is_rol = "Admon",
                usu_pass = "1234"

            };
            return View(usuario);
        }
    }
}