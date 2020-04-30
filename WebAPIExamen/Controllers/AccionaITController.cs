using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPIExamen.Models;
using Newtonsoft.Json;

namespace WebAPIExamen.Controllers
{
    public class AccionaITController : ApiController
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [Route("api/login")]
        [HttpPost]
        public IHttpActionResult LoguerUsuario(User user)
        {
            if (user is null)
            {
                log.Error("user is null");
                return BadRequest("Usuario null o vacio");
                
            }

            if (user.usuario.Equals("admin") && user.password.Equals("1234"))
            {
                return Ok(new string[] { user.usuario, user.password });
            }
            string messageError = string.Format("usuario: {0} Invalido", user.usuario);
            log.Error(messageError);
            return BadRequest(messageError);
            

        }
        [Route("api/provincia")]
        [HttpGet]
        public async Task<IEnumerable<string>> ObtenerLatYLong(InputProv provincia)
        {
            HttpClient httpClient = new HttpClient();
            var json =await httpClient.GetStringAsync(string.Format("https://apis.datos.gob.ar/georef/api/provincias?nombre={0}", provincia.Nombre));
            
            var prov = JsonConvert.DeserializeObject<GeoMap>(json);

            if (prov.Cantidad==0)
            {
                return new string[] { "No existe provincia" };
            }
            var latitud = prov.Provincias[0].Centroide.Lat;
            var longitud = prov.Provincias[0].Centroide.Lon;
            return new string[] { string.Format("latitud: {0}",latitud.ToString())
                ,string.Format("longitud: {0}", longitud.ToString()) };
        }
    }
}
