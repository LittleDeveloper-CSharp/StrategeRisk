using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StrategeRisk.WebApp.Models.DTOs.NoteDTOs
{
    public class NoteCreateDTO
    {
        [Required]
        [JsonPropertyName("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [Required]
        [JsonPropertyName("companyId")]
        public int CompanyId { get; set; }

        [Required]
        [JsonPropertyName("employeeId")]
        public int EmployeeId { get; set; }
    }
}
