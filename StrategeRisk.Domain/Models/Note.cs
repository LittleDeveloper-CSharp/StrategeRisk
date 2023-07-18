using System.ComponentModel.DataAnnotations;

namespace StrategeRisk.Domain.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        public string InvoiceNumber { get; set; } = null!;

        public Employee Employee = null!;

        public Company Company = null!;
    }
}
