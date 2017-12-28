using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WordPressValidador.Models;
using CNegocio.Seguridad;
namespace WordPressValidador.Controllers
{
    public class LoginController : Controller
    {
        #region Constructores
        Autentificacion autentifica = new Autentificacion();
        #endregion
        // GET: Login
        public ActionResult Index()
        { 

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(login ModelLogin)
        {
            if (ModelState.IsValid)
            { string loginUsuario = autentifica.IsUser(ModelLogin.NombreUsuario, ModelLogin.PassUsuario);
                if (loginUsuario!="")
                {
                    Session["IsUsuario"] = loginUsuario;
                    return RedirectToAction("Index","Validador");
                }
                ViewBag.msg = "0";
                return View();
            }
            ViewBag.msg = "0";
            return View();
        }
        public ActionResult LogOff() {

            Session.Clear();
            return RedirectToAction("Index");
        }

    }
}
