using System.Text.Json.Serialization;

namespace ElsaServer.Models
{
    public class Schema
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("properties")]
        public Dictionary<string, Property>? Properties { get; set; }
    }
}