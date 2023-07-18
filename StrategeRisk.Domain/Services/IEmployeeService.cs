using StrategeRisk.Domain.Models;

namespace StrategeRisk.Domain.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAsync(int companyId);

        Task<Employee> GetEmployee(int id);

        Task<bool> CreateAsync(int companyId, Employee employee);

        Task DeleteAsync(int id);

        Task<bool> UpdateAsync(Employee employee);
    }
}
