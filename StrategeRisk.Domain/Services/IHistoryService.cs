using StrategeRisk.Domain.Models;

namespace StrategeRisk.Domain.Services
{
    public interface IHistoryService
    {
        Task<IEnumerable<History>> GetAsync(int companyId);
    }
}
