using System.Linq.Expressions;

namespace StrategeRisk.Domain.Infrastucture
{
    public interface IGenericRepository<T> where T : class
    {
        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> filter);

        Task<IEnumerable<T>> GetAsync(params string[] navigationNames);
        
        Task<T?> GetAsync(Expression<Func<T, bool>> filter);

        Task<IEnumerable<T>> GetAsync();
    }
}
