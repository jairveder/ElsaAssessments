using System.Text.Json.Serialization;

namespace ElsaServer.Models
{
    public class Components
    {
        [JsonPropertyName("schemas")]
        public Dictionary<string, Schema>? Schemas { get; set; }
    }
}