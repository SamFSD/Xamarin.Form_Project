using Newtonsoft.Json;

namespace IoTAssetManagement.Models
{
    public class Car
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
