using System.Text.Json.Serialization;

namespace ElsaServer.Models
{
    public class Server
    {
        [JsonPropertyName("url")]
        public Uri? Url { get; set; }
    }
}