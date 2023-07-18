using StrategeRisk.Domain.Models;

namespace StrategeRisk.Domain.Services
{
    public interface INoteService
    {
        Task<IEnumerable<Note>> GetAsync(int companyId);

        Task<bool> CreateAsync(int companyId, Note note);

        Task DeleteAsync(int id);
    }
}
