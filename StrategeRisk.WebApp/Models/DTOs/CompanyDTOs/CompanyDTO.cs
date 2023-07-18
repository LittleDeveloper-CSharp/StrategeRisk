using System.Text.Json.Serialization;

namespace StrategeRisk.WebApp.Models.DTOs.CompanyDTOs
{
    public class CompanyDTO
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("cityId")]
        public int CityId { get; set; }

        [JsonPropertyName("stateId")]
        public int StateId { get; set; }
    }
}
