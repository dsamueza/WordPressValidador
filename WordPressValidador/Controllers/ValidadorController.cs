using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNegocio.Validar;
using CNegocio.Modelo;

namespace WordPressValidador.Controllers
{
    public class ValidadorController : Controller
    {
        #region Constructores
        Nuevo wordpressnew = new Nuevo();
        #endregion
        string variable = "";
        // GET: Validador
        public ActionResult Index()
        {
            if (Session["IsUsuario"] != null) { 
            ViewBag.lgnUsuario = Session["IsUsuario"];
            return View();
            }
            return RedirectToAction("LogOff", "Login");
        }
        [HttpPost]

        public JsonResult Import(IEnumerable<HttpPostedFileBase> fileExc)
        {
            try
            {
                if (fileExc != null && fileExc.First().FileName.EndsWith("xlsx"))
                {

                    ViewBag.error = "Ingrese excel";
                    string path = Server.MapPath("~/Content/" + fileExc.First().FileName);
                    variable = path;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    fileExc.First().SaveAs(path);

                    IList<Errores> lterrores = wordpressnew.ValidarRegistroNuevo(path);
                    ViewBag.ListaErrores = lterrores;
                    ViewBag.Nerrores = lterrores.Count();
                    ViewBag.lgnUsuario = Session["IsUsuario"];
                    var rowsMarcar = (from mar in lterrores
                                      select new
                                      {
                                          mar.Valor,
                                          mar.celda,
                                          mar.error,
                                          mar.Sugerencia
                                      });
                    var rows = rowsMarcar.ToArray();
                    return Json(rows, JsonRequestBehavior.AllowGet);

                }
                else
                {
                   
                    return Json("-1", JsonRequestBehavior.DenyGet);
                }
            }
            catch (Exception e)
            {
                IList<Errores> lterrores =new List<Errores>();
                lterrores.Add(new Errores { celda="na", Valor= variable, error=e.ToString() });
                var rowsMarcar = (from mar in lterrores
                                  select new
                                  {
                                      mar.Valor,
                                      mar.celda,
                                      mar.error,
                                      mar.Sugerencia
                                  });
                var rows = rowsMarcar.ToArray();
                return Json(rows, JsonRequestBehavior.DenyGet);
            }
          
         
        }
    }
}