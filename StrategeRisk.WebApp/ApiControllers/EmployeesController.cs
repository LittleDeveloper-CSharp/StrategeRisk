using Microsoft.AspNetCore.Mvc;
using StrategeRisk.Domain.Enums;
using StrategeRisk.Domain.Models;
using StrategeRisk.Domain.Services;
using StrategeRisk.WebApp.Models.DTOs.EmployeeDTOs;
using StrategeRisk.WebApp.Models.DTOs.EmployeePositionDTOs;

namespace StrategeRisk.WebApp.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IEmployeePositionService _employeePositionService;

        public EmployeesController(
            IEmployeeService employeeService,
            IEmployeePositionService employeePositionService)
        {
            _employeeService = employeeService;
            _employeePositionService = employeePositionService;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var employee = await _employeeService.GetEmployee(id);

            return Ok(new EmployeeUpdateDTO
            {
                BirthDate = employee.BirthDate,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Id = id,
                PositionId = employee.PositionId,
                Title = employee.Title,
            });
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeCreateDTO model)
        {
            var employee = new Employee
            {
                BirthDate = model.BirthDate,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PositionId = model.PositionId,
                Title = model.Title,
            };

            var hasCreated = await _employeeService.CreateAsync(model.CompanyId, employee);
            if (hasCreated)
                return BadRequest();

            return Ok();
        }

        [HttpPatch]
        public async Task<IActionResult> Patch(EmployeeUpdateDTO model)
        {
            var employee = new Employee
            {
                Id = model.Id,
                BirthDate = model.BirthDate,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PositionId = model.PositionId,
                Title = model.Title,
            };

            var hasUpdated = await _employeeService.UpdateAsync(employee);
            if (hasUpdated)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _employeeService.DeleteAsync(id);

            return Ok();
        }

        [HttpGet("positions")]
        public async Task<IActionResult> GetPositions()
        {
            var positions = await _employeePositionService.GetAsync();

            return Ok(positions.Select(x => new EmployeePositionDTO
            {
                Id = x.Id,
                Name = x.Name,
            }));
        }

        [HttpGet("title")]
        public IActionResult GetTitle()
        {
            var titles = Enum.GetNames<EmployeeTitle>();

            return Ok(titles.Select(x => new
            {
                id = (int)Enum.Parse<EmployeeTitle>(x),
                name = x
            }));
        }
    }
}
