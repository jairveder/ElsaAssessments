using System.Text.Json.Serialization;

namespace ElsaServer.Models
{
    public class Info
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("version")]
        public int? Version { get; set; }
    }
}