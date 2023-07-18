using Microsoft.AspNetCore.Mvc;
using StrategeRisk.Domain.Services;
using StrategeRisk.WebApp.Models.DTOs;
using StrategeRisk.WebApp.Models.DTOs.CompanyDTOs;
using StrategeRisk.WebApp.Models.DTOs.EmployeeDTOs;
using StrategeRisk.WebApp.Models.DTOs.NoteDTOs;

namespace StrategeRisk.WebApp.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IHistoryService _historyService;
        private readonly INoteService _noteService;
        private readonly ICompanyService _companyService;

        public CompaniesController(
            IEmployeeService employeeService,
            IHistoryService historyService,
            INoteService noteService,
            ICompanyService companyService)
        {
            _employeeService = employeeService;
            _historyService = historyService;
            _noteService = noteService;
            _companyService = companyService;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var company = await _companyService.GetAsync(id);

            return Ok(new CompanyDTO
            {
                Address = company.Address,
                CityId = company.CityId,
                Id = company.Id,
                Name = company.Name,
                StateId = company.StateId,
            });
        }

        [HttpGet("{companyId:int}/histories")]
        public async Task<IActionResult> GetHistories(int companyId)
        {
            var histories = await _historyService.GetAsync(companyId);

            return Ok(histories.Select(x => new HistoryDTO
            {
                OrderDate = x.OrderDate,
                StoreCity = x.StoreCity.Name
            }));
        }

        [HttpGet("{companyId:int}/employees")]
        public async Task<IActionResult> GetEmployees(int companyId)
        {
            var employees = await _employeeService.GetAsync(companyId);

            return Ok(employees.Select(x => new EmployeeDTO
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
            }));
        }

        [HttpGet("{companyId:int}/notes")]
        public async Task<IActionResult> GetNotes(int companyId)
        {
            var notes = await _noteService.GetAsync(companyId);

            return Ok(notes.Select(x => new NoteDTO
            {
                EmployeeFullName = $"{x.Employee.FirstName} {x.Employee.LastName}",
                InvoiceNumber = x.InvoiceNumber,
            }));
        }
    }
}
