using System.Text.Json.Serialization;

namespace StrategeRisk.WebApp.Models.DTOs.StateDTOs
{
    public class StateDTO
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
