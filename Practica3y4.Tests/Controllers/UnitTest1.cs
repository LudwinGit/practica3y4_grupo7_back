using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica3y4.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Data;

namespace Practica3y4.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestView() 
        {
            RegistroController controlller = new RegistroController();
            ViewResult result = controlller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestCampos()
        {
            RegistroController controller = new RegistroController();
            bool test = controller.validarCAmpos(1233445,"Rick","Alvarez",13344554,34345665,"1234");
            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void TestUserLength()
        {
            RegistroController con = new RegistroController();
            bool result = con.verificarUsuario(1234567);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestPasswordLength()
        {
            RegistroController controller = new RegistroController();
            bool result = controller.verificarPassword("usuaio1234");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestNumeroUsuario()
        {
            RegistroController con = new RegistroController();
            bool result = con.validarNoUsuario(1243454534);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestConsultaSaldo()
        {
            ConsultarSaldoController con = new ConsultarSaldoController();
            bool result = con.consulta(12345678);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestVerificaCuentaConsulta()
        {
            ConsultarSaldoController con = new ConsultarSaldoController();
            bool resul = con.verificarCuenta(12345678);
            Assert.IsNotNull(resul);
        }

        [TestMethod]
        public void TestRespuesta()
        {
            ConsultarSaldoController con = new ConsultarSaldoController();
            bool result = con.Respuesta(1234456677);
            Assert.IsNotNull(result);
        }
    }
}
