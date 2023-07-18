using System.Text.Json.Serialization;

namespace StrategeRisk.WebApp.Models.DTOs
{
    public class HistoryDTO
    {
        [JsonPropertyName("orderDate")]
        public DateTime OrderDate { get; set; }

        [JsonPropertyName("storeCity")]
        public string StoreCity { get; set; }
    }
}
