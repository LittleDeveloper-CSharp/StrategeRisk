using Microsoft.AspNetCore.Mvc;
using StrategeRisk.Domain.Models;
using StrategeRisk.Domain.Services;
using StrategeRisk.WebApp.Models;

namespace StrategeRisk.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICompanyService _companyService;

        public HomeController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<IActionResult> Index()
        {
            var companies = await _companyService.GetAsync();

            return View(companies.Select(x=> new CompanyRowViewModel
            {
                Id = x.Id,
                City = x.City.Name,
                Name = x.Name,
                Phone= x.Phone,
                State = x.State.Name
            }));
        }
    }
}
