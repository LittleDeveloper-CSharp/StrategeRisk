using Microsoft.AspNetCore.Mvc;
using StrategeRisk.Domain.Services;
using StrategeRisk.WebApp.Models;
using StrategeRisk.WebApp.Models.CompanyViewModels;

namespace StrategeRisk.WebApp.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<IActionResult> Index()
        {
            var companies = await _companyService.GetAsync();

            return View(companies.Select(x => new CompanyRowViewModel
            {
                Id = x.Id,
                City = x.City.Name,
                Name = x.Name,
                Phone = x.Phone,
                State = x.State.Name
            }));
        }

        public async Task<IActionResult> Details(int id)
        {
            var company = await _companyService.GetAsync(id);

            return View(new CompanyViewModel
            {
                Id = id,
                Name = company.Name,
            });
        }
    }
}
