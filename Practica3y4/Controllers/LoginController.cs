using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica3y4.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public bool validarCadenaPassword()
        {
            throw new NotImplementedException();
        }

        public bool validarCadenaCuenta()
        {
            throw new NotImplementedException();
        }

        public bool validarExistenciaCuenta()
        {
            throw new NotImplementedException();
        }

        public bool validarLongitudPassword()
        {
            throw new NotImplementedException();
        }

        public bool validarLongitudCuenta()
        {
            throw new NotImplementedException();
        }

        public bool Loguear(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}