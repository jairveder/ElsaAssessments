using System.Text.Json.Serialization;

namespace ElsaServer.Models
{
    public class Response
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("content")]
        public Dictionary<string, Schema>? ContentTypes { get; set; }
    }
}