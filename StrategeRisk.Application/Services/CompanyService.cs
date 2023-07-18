using StrategeRisk.Application.Validations;
using StrategeRisk.Domain.Infrastucture;
using StrategeRisk.Domain.Models;
using StrategeRisk.Domain.Services;

namespace StrategeRisk.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IGenericRepository<Company> _repository;

        public CompanyService(IGenericRepository<Company> repository)
        {
            _repository = repository;
        }

        public async Task<bool> CreateAsync(Company company)
        {
            var isValid = company.Validation();
            if (isValid)
                await _repository.CreateAsync(company);

            return isValid;
        }

        public async Task<IEnumerable<Company>> GetAsync()
        {
            return await _repository.GetAsync(nameof(Company.City), nameof(Company.State));
        }

        public async Task<Company> GetAsync(int id)
        {
            var company = await _repository.GetAsync(x => x.Id == id);
            if (company is null)
                return new Company();

            return company;
        }

        public async Task<bool> UpdateAsync(Company company)
        {
            var isValid = company.Validation();
            if (isValid)
            {
                var model = await _repository.GetAsync(x=> x.Id == company.Id);
                if (model is null)
                    return false;

                model.Phone = company.Phone;
                model.Address = company.Address;
                model.City = company.City;
                model.State = company.State;
                model.Name= company.Name;

                await _repository.UpdateAsync(company);
            }

            return isValid;
        }
    }
}
