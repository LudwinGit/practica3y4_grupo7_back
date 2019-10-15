using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica3y4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            WSBanguat.TipoCambioSoapClient ws = new WSBanguat.TipoCambioSoapClient();
            //ViewBag.Message = ws.TipoCambioFechaInicial("10/10/2019");
            ViewBag.fechas = ws.TipoCambioFechaInicial("10/10/2019").Vars;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}