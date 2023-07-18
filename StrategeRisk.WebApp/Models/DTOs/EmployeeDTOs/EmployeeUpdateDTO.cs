using StrategeRisk.Domain.Enums;
using System.Text.Json.Serialization;

namespace StrategeRisk.WebApp.Models.DTOs.EmployeeDTOs
{
    public class EmployeeUpdateDTO
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("title")]
        public EmployeeTitle Title { get; set; }

        [JsonPropertyName("birthDate")]
        public DateTime BirthDate { get; set; }

        [JsonPropertyName("positionId")]
        public int PositionId { get; set; }
    }
}
