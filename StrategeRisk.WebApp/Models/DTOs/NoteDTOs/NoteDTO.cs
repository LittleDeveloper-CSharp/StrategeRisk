using System.Text.Json.Serialization;

namespace StrategeRisk.WebApp.Models.DTOs.NoteDTOs
{
    public class NoteDTO
    {
        [JsonPropertyName("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonPropertyName("employeeFullName")]
        public string EmployeeFullName { get; set; }
    }
}
