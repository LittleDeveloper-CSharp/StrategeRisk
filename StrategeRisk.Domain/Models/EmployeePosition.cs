using System.ComponentModel.DataAnnotations;

namespace StrategeRisk.Domain.Models
{
    public class EmployeePosition
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;
    }
}
