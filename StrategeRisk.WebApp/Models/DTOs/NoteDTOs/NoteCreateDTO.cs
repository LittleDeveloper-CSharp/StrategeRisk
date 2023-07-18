using System.Text.Json.Serialization;

namespace StrategeRisk.WebApp.Models.DTOs.NoteDTOs
{
    public class NoteCreateDTO
    {
        [JsonPropertyName("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonPropertyName("companyId")]
        public int CompanyId { get; set; }

        [JsonPropertyName("employeeId")]
        public int EmployeeId { get; set; }
    }
}
