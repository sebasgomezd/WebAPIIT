using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPIExamen;
using WebAPIExamen.Controllers;
using WebAPIExamen.Models;

namespace WebAPIExamen.Tests.Controllers
{
    [TestClass]
    public class ProvinciaControllerTest
    {
        

        [TestMethod]
        public async Task WhenProvinciaNoExistThenMessageNOtExistAsync()
        {
            // Disponer
            //ValuesController controller = new ValuesController();
            AccionaITController controller = new AccionaITController();
            InputProv input = new InputProv { Nombre = "Chile" };
            var expeted = new string[] { "No existe provincia" };

            // Actuar
            IEnumerable<string> result =await controller.ObtenerLatYLong(input);

            // Declarar
            Assert.AreNotEqual(result, expeted);
        }

        [TestMethod]
        public async Task WhenProvinciaExistThenMessageLatitud()
        {
            // Disponer            
            AccionaITController controller = new AccionaITController();
            InputProv input = new InputProv { Nombre = "Cordoba" };

            string pos1 = "latitud";

            // Actuar
            IEnumerable<string> result = await controller.ObtenerLatYLong(input);
            string firsElement = result.First();
            Assert.IsTrue(firsElement.StartsWith(pos1));
            // Declarar

        }



    }
}
