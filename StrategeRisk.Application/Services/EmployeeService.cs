using StrategeRisk.Application.Validations;
using StrategeRisk.Domain.Infrastucture;
using StrategeRisk.Domain.Models;
using StrategeRisk.Domain.Services;

namespace StrategeRisk.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IGenericRepository<Employee> _employeeRepository;
        private readonly ICompanyService _companyService;

        public EmployeeService(
            IGenericRepository<Employee> repository,
            ICompanyService companyService)
        {
            _employeeRepository = repository;
            _companyService = companyService;
        }

        public async Task<bool> CreateAsync(int companyId, Employee employee)
        {
            var isValid = employee.Validation();
            if(isValid)
            {
                var company = await _companyService.GetAsync(companyId);
                employee.Company = company;

                await _employeeRepository.CreateAsync(employee);
            }

            return isValid;
        }

        public async Task DeleteAsync(int id)
        {
            var employee = await _employeeRepository.GetAsync(x => x.Id == id);
            if (employee is null)
                return;

            await _employeeRepository.DeleteAsync(employee);
        }

        public async Task<IEnumerable<Employee>> GetAsync(int companyId)
        {
            return await _employeeRepository.FindByAsync(x => x.Company.Id == companyId);
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _employeeRepository.GetAsync(x=> x.Id == id);
        }

        public async Task<bool> UpdateAsync(Employee employee)
        {
            var isValid = employee.Validation();
            if (isValid)
            {
                var entity = await _employeeRepository.GetAsync(x=> x.Id == employee.Id);
                if(entity is null)
                    return false;
                
                entity.Position = employee.Position;
                entity.Title = employee.Title;
                entity.BirthDate = employee.BirthDate;
                entity.FirstName = employee.FirstName;
                entity.LastName = employee.LastName;

                await _employeeRepository.UpdateAsync(entity);
            }

            return isValid;
        }
    }
}
