using System.ComponentModel.DataAnnotations;

namespace StrategeRisk.Domain.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
