using System.Text.Json.Serialization;

namespace ElsaServer.Models
{
    public class Parameter
    {
        [JsonPropertyName("in")]
        public string? In { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("schema")]
        public Schema? Schema { get; set; }
    }
}