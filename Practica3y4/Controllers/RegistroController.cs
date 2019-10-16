using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica3y4.Controllers
{
    public class RegistroController : Controller
    {
        // GET: Registro
        public ActionResult Index()
        {
            return View();
        }

        public bool validarCAmpos(int usuario, string nombre, string apellidos, int dpi, int cuenta, string password)
        {
            if(usuario != 0  && nombre != "" && apellidos!="" && dpi!=0 && cuenta!=0 && password!=""){
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool verificarPassword(string pass)
        {
            if (pass.Length > 8)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public bool validarNoUsuario(int num)
        {
            if(num is int)
            {
                return true;
            }
            else
            {
                return false;
            }                
        }



    }
}