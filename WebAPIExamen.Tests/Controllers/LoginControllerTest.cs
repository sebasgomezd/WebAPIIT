using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPIExamen;
using WebAPIExamen.Controllers;
using WebAPIExamen.Models;

namespace WebAPIExamen.Tests.Controllers
{
    [TestClass]
    public class LoginControllerTest
    {
        

        [TestMethod]
        public void WhenLoginUserIsInvalidThenBadRequest()
        {
            // Disponer
            //ValuesController controller = new ValuesController();
            AccionaITController controller = new AccionaITController();
            User user = new User { usuario = "pepe", password = "1234" };

            // Actuar
            IHttpActionResult result = controller.LoguerUsuario(user);

            // Declarar
            Assert.IsInstanceOfType(result, typeof(BadRequestErrorMessageResult));
        }

        [TestMethod]
        public void WhenLoginUserIsvalidThenOk()
        {
            // Disponer
            //ValuesController controller = new ValuesController();
            AccionaITController controller = new AccionaITController();
            User user = new User { usuario = "admin", password = "1234" };

            // Actuar
            IHttpActionResult result = controller.LoguerUsuario(user);

            // Declarar
            Assert.IsInstanceOfType(result, typeof(OkNegotiatedContentResult<string[]>));
        }

        [TestMethod]
        public void WhenLoginUserIsNullThenBadrequest()
        {
            // Disponer
            //ValuesController controller = new ValuesController();
            AccionaITController controller = new AccionaITController();
            User user = null;

            // Actuar
            IHttpActionResult result = controller.LoguerUsuario(user);

            // Declarar
            Assert.IsInstanceOfType(result, typeof(BadRequestErrorMessageResult));
        }
    }
}
