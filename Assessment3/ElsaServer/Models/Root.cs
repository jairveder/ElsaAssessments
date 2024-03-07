using System.Text.Json.Serialization;

namespace ElsaServer.Models
{
    public class Root
    {
        [JsonPropertyName("page")]
        public int? Page { get; set; }

        [JsonPropertyName("per_page")]
        public int? PerPage { get; set; }

        [JsonPropertyName("total")]
        public int? Total { get; set; }

        [JsonPropertyName("total_pages")]
        public int? TotalPages { get; set; }

        [JsonPropertyName("data")]
        public List<User>? Users { get; set; }

        [JsonPropertyName("Support")]
        public Support? Support { get; set; }
    }
}