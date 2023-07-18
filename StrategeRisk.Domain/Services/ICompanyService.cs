using StrategeRisk.Domain.Models;

namespace StrategeRisk.Domain.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetAsync();

        Task<Company> GetAsync(int id);

        Task<bool> UpdateAsync(Company company);

        Task<bool> CreateAsync(Company company);
    }
}
