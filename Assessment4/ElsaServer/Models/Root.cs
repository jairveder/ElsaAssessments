using System.Text.Json.Serialization;

namespace ElsaServer.Models
{
    public class Root
    {
        [JsonPropertyName("openapi")]
        public string? Openapi { get; set; }

        [JsonPropertyName("info")]
        public Info? Info { get; set; }

        [JsonPropertyName("servers")]
        public List<Server>? Servers { get; set; }

        [JsonPropertyName("components")]
        public Components? Components { get; set; }

        [JsonPropertyName("paths")]
        public Dictionary<string, Dictionary<string, Method>?>? Paths { get; set; }
    }
}