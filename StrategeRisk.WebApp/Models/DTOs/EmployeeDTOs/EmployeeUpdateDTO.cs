using StrategeRisk.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StrategeRisk.WebApp.Models.DTOs.EmployeeDTOs
{
    public class EmployeeUpdateDTO
    {
        [Required]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required]
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [Required]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [Required]
        [JsonPropertyName("title")]
        public EmployeeTitle Title { get; set; }

        [Required]
        [JsonPropertyName("birthDate")]
        public DateTime BirthDate { get; set; }

        [Required]
        [JsonPropertyName("positionId")]
        public int PositionId { get; set; }
    }
}
