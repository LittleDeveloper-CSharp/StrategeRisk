using StrategeRisk.Domain.Infrastucture;
using StrategeRisk.Domain.Models;
using StrategeRisk.Domain.Services;

namespace StrategeRisk.Application.Services
{
    public class CityService : ICityService
    {
        private readonly IGenericRepository<City> _cityRepository;

        public CityService(IGenericRepository<City> cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<IEnumerable<City>> GetAsync()
        {
            return await _cityRepository.GetAsync();
        }
    }
}
