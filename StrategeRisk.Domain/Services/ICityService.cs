using StrategeRisk.Domain.Models;

namespace StrategeRisk.Domain.Services
{
    public interface ICityService
    {
        Task<IEnumerable<City>> GetAsync();
    }
}
