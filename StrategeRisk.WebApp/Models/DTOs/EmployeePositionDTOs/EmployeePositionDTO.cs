using System.Text.Json.Serialization;

namespace StrategeRisk.WebApp.Models.DTOs.EmployeePositionDTOs
{
    public class EmployeePositionDTO
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
