using System.Text.Json.Serialization;

namespace StrategeRisk.WebApp.Models.DTOs.CityDTOs
{
    public class CityDTO
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }    
    }
}
