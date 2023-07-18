using Microsoft.EntityFrameworkCore;
using StrategeRisk.Domain.Infrastucture;
using System.Linq.Expressions;

namespace StrategeRisk.DataAccess
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.Where(filter).ToArrayAsync();
        }

        public async Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> filter, params string[] navigationNames)
        {
            var query = _dbSet.AsQueryable().Where(filter);
            foreach (var navigationName in navigationNames)
            {
                query = query.Include(navigationName);
            }

            return await query.ToArrayAsync();
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _dbSet.ToArrayAsync();
        }

        public async Task<IEnumerable<T>> GetAsync(params string[] navigationNames)
        {
            var query = _dbSet.AsQueryable();
            foreach (var navigationName in navigationNames)
            {
                query = query.Include(navigationName);
            }

            return await query.ToArrayAsync();
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.SingleOrDefaultAsync(filter);
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);

            await _context.SaveChangesAsync();
        }
    }
}
