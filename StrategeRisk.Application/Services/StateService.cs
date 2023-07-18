using StrategeRisk.Domain.Infrastucture;
using StrategeRisk.Domain.Models;
using StrategeRisk.Domain.Services;

namespace StrategeRisk.Application.Services
{
    public class StateService : IStateService
    {
        private readonly IGenericRepository<State> _stateRepository;

        public StateService(IGenericRepository<State> stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public async Task<IEnumerable<State>> GetAsync()
        {
            return await _stateRepository.GetAsync();
        }
    }
}
