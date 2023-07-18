using System.ComponentModel.DataAnnotations;

namespace StrategeRisk.Domain.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;

        public int CityId { get; set; }

        public int StateId { get; set; }

        public string Phone { get; set; } = null!;

        public City City { get; set; } = null!;

        public State State { get; set; } = null!;
    
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
