using System.Text.Json.Serialization;

namespace ElsaServer.Models
{
    public class Property
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}