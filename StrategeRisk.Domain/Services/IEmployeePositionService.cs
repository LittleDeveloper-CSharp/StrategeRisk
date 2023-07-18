using StrategeRisk.Domain.Models;

namespace StrategeRisk.Domain.Services
{
    public interface IEmployeePositionService
    {
        Task<IEnumerable<EmployeePosition>> GetAsync();
    }
}
