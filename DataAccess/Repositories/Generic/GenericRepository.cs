using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Repositories.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext _context;
        protected DbSet<T> _dbSet => _context.Set<T>();
        protected GenericRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Exists(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public async Task CreateRange(IEnumerable<T> Data)
        {
            await _dbSet.AddRangeAsync(Data);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRange(IEnumerable<T> Data)
        {
            _dbSet.UpdateRange(Data);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAll()
        {
            _dbSet.RemoveRange(_dbSet);
            await _context.SaveChangesAsync();
        }
    }
}
