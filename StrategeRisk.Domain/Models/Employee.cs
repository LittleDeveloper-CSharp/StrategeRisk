using StrategeRisk.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace StrategeRisk.Domain.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public EmployeeTitle Title { get; set; }

        public DateTime BirthDate { get; set; }

        public int PositionId { get; set; }

        public EmployeePosition Position { get; set; } = null!;

        public Company Company { get; set; } = null!;
    }
}
