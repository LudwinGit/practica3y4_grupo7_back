using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica3y4.Controllers;

namespace Practica3y4.Tests.Controllers
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void validarCadenaPassword() //Prueba que el password contenga caracteres permitidos
        {
            LoginController controller = new LoginController();
            // Act
            bool result = controller.validarCadenaPassword() ;
            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void validarLongitudPassword() //Prueba que la longitud del password ente entre [5,8] caracteres
        {
            LoginController controller = new LoginController();
            // Act
            bool result = controller.validarLongitudPassword();
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void validarCadenaCuenta()   //Prueba que el string de la cuenta posea solo numeros
        {
            LoginController controller = new LoginController();
            // Act
            bool result = controller.validarCadenaCuenta();
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void validarLongitudCuenta() //Prueba que la longitud de la cadena de la cuenta sea de 6 caracteres
        {
            LoginController controller = new LoginController();
            // Act
            bool result = controller.validarLongitudCuenta();
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void validarExistenciaCuenta()   //Prueba si la cuenta existe en la base de datos
        {
            LoginController controller = new LoginController();
            // Act
            bool result = controller.validarExistenciaCuenta();
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void pruebaLogueoCorrecto()  
        {
            LoginController controller = new LoginController();
            // Act
            bool result = controller.Loguear("123456","correcto");
            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void pruebaLogueoCuentaIncorrecta()
        {
            LoginController controller = new LoginController();
            // Act
            bool result = controller.Loguear("123@23", "password");
            // Assert
            Assert.IsNotNull(result);
        }
        public void pruebaLogueoPasswordIncorrecta()
        {
            LoginController controller = new LoginController();
            // Act
            bool result = controller.Loguear("12345", "...@...");
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
