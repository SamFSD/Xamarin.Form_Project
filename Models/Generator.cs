using Newtonsoft.Json;

namespace IoTAssetManagement.Models
{
    public class Generator
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
