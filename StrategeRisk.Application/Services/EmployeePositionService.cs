using StrategeRisk.Domain.Infrastucture;
using StrategeRisk.Domain.Models;
using StrategeRisk.Domain.Services;

namespace StrategeRisk.Application.Services
{
    public class EmployeePositionService : IEmployeePositionService
    {
        private readonly IGenericRepository<EmployeePosition> _employeePositionsRepository;

        public EmployeePositionService(IGenericRepository<EmployeePosition> employeePositionsRepository)
        {
            _employeePositionsRepository = employeePositionsRepository;
        }

        public async Task<IEnumerable<EmployeePosition>> GetAsync()
        {
            return await _employeePositionsRepository.GetAsync();
        }
    }
}
