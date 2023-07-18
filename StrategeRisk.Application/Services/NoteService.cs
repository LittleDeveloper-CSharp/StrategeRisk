using StrategeRisk.Application.Validations;
using StrategeRisk.Domain.Infrastucture;
using StrategeRisk.Domain.Models;
using StrategeRisk.Domain.Services;

namespace StrategeRisk.Application.Services
{
    public class NoteService : INoteService
    {
        private readonly ICompanyService _companyService;
        private readonly IGenericRepository<Note> _repository;

        public NoteService(
            ICompanyService companyService, 
            IGenericRepository<Note> repository)
        {
            _companyService = companyService;
            _repository = repository;
        }

        public async Task<bool> CreateAsync(int companyId, Note note)
        {
            var isValid = note.Validation();
            if (isValid)
            {
                var company = await _companyService.GetAsync(companyId);
                note.Company = company;

                await _repository.CreateAsync(note);
            }

            return isValid;
        }

        public async Task DeleteAsync(int id)
        {
            var note = await _repository.GetAsync(x => x.Id == id);
            if (note is null)
                return;
            
            await _repository.DeleteAsync(note);
        }

        public async Task<IEnumerable<Note>> GetAsync(int companyId)
        {
            return await _repository.FindByAsync(x => x.Company.Id == companyId, nameof(Note.Employee));
        }
    }
}
