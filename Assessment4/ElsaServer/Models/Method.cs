using System.Text.Json.Serialization;

namespace ElsaServer.Models
{
    public class Method
    {
        [JsonPropertyName("summary")]
        public string? Summary { get; set; }

        [JsonPropertyName("parameters")]
        public List<Parameter?>? Parameters { get; set; }

        [JsonPropertyName("responses")]
        public Dictionary<string, Response?>? Responses { get; set; }
    }
}