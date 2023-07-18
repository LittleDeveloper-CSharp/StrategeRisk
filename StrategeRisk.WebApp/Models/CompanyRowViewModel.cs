using System.ComponentModel.DataAnnotations;

namespace StrategeRisk.WebApp.Models
{
    public class CompanyRowViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Company Name")]
        public string Name { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}
