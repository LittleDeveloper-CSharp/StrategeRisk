using System.ComponentModel.DataAnnotations;

namespace StrategeRisk.Domain.Models
{
    public class History
    {
        [Key]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public City StoreCity { get; set; } = null!;

        public Company Company { get; set; } = null!;
    }
}
