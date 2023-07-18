using StrategeRisk.Application.Validations;
using StrategeRisk.Domain.Infrastucture;
using StrategeRisk.Domain.Models;
using StrategeRisk.Domain.Services;

namespace StrategeRisk.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IGenericRepository<Employee> _repository;
        private readonly ICompanyService _companyService;

        public EmployeeService(
            IGenericRepository<Employee> repository,
            ICompanyService companyService)
        {
            _repository = repository;
            _companyService = companyService;
        }

        public async Task<bool> CreateAsync(int companyId, Employee employee)
        {
            var isValid = employee.Validation();
            if(isValid)
            {
                var company = await _companyService.GetAsync(companyId);
                employee.Company = company;

                await _repository.CreateAsync(employee);
            }

            return isValid;
        }

        public async Task DeleteAsync(int id)
        {
            var employee = await _repository.GetAsync(x => x.Id == id);
            if (employee is null)
                return;

            await _repository.DeleteAsync(employee);
        }

        public async Task<IEnumerable<Employee>> GetAsync(int companyId)
        {
            return await _repository.FindByAsync(x => x.Company.Id == companyId);
        }

        public async Task<bool> UpdateAsync(Employee employee)
        {
            var isValid = employee.Validation();
            if (isValid)
            {
                var entity = await _repository.GetAsync(x=> x.Id == employee.Id);
                if(entity is null)
                    return false;
                
                entity.Position = employee.Position;
                entity.Title = employee.Title;
                entity.BirthDate = employee.BirthDate;
                entity.FirstName = employee.FirstName;
                entity.LastName = employee.LastName;

                await _repository.UpdateAsync(entity);
            }

            return isValid;
        }
    }
}
