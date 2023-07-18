using StrategeRisk.Domain.Infrastucture;
using StrategeRisk.Domain.Models;
using StrategeRisk.Domain.Services;

namespace StrategeRisk.Application.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly IGenericRepository<History> _historyRepository;

        public HistoryService(IGenericRepository<History> historyRepository)
        {
            _historyRepository = historyRepository;
        }

        public async Task<IEnumerable<History>> GetAsync(int companyId)
        {
            return await _historyRepository.FindByAsync(x => x.Company.Id == companyId);
        }
    }
}
