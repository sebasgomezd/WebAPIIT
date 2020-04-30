using Newtonsoft.Json;

namespace WebAPIExamen.Models
{


    public partial class Provincia
    {
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("id")]        
        public long Id { get; set; }

        [JsonProperty("centroide")]
        public Centroide Centroide { get; set; }
    }

    public partial class Centroide
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }
    }
}