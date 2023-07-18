using System.Text.Json.Serialization;

namespace StrategeRisk.WebApp.Models.DTOs.EmployeeDTOs
{
    public class EmployeeDTO
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
    }
}
