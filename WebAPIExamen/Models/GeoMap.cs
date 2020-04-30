using Newtonsoft.Json;

namespace WebAPIExamen.Models
{
    public class GeoMap
    {
        [JsonProperty("cantidad")]
        public int Cantidad{ get; set; }

        [JsonProperty("inicio")]
        public int Inicio { get; set; }

        [JsonProperty("parametros")]
        public Parametros parametros { get; set; }

        [JsonProperty("provincias")]
        public Provincia[] Provincias { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

   

    public class Parametros
    {

        [JsonProperty("nombre")]
        public string Nombre { get; set; }
    }
}