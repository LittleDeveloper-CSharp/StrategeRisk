using StrategeRisk.Domain.Models;

namespace StrategeRisk.Domain.Services
{
    public interface IStateService
    {
        Task<IEnumerable<State>> GetAsync();
    }
}
