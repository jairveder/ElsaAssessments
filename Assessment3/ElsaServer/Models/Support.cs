using System.Text.Json.Serialization;

namespace ElsaServer.Models
{
    public class Support
    {
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}