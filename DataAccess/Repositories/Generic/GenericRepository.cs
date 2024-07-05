using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Repositories.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected GenericRepository(IUnitOfWork unitOfWork)
        {
             _unitOfWork = unitOfWork;
        }

        public async Task<T> GetById(int id)
        {
            return await _unitOfWork.Context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _unitOfWork.Context.Set<T>().ToListAsync();
        }

        public async Task Add(T entity)
        {
            await _unitOfWork.Context.Set<T>().AddAsync(entity);
            await _unitOfWork.Commit();
        }

        public async Task Update(T entity)
        {
            _unitOfWork.Context.Set<T>().Update(entity);
            await _unitOfWork.Commit();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _unitOfWork.Context.Set<T>().Remove(entity);
            await _unitOfWork.Commit();
        }

        public async Task<bool> Exists(Expression<Func<T, bool>> expression)
        {
            return await _unitOfWork.Context.Set<T>().AnyAsync(expression);
        }

        public async Task CreateRange(IEnumerable<T> Data)
        {
            await _unitOfWork.Context.Set<T>().AddRangeAsync(Data);
            await _unitOfWork.Commit();
        }

        public async Task UpdateRange(IEnumerable<T> Data)
        {
            _unitOfWork.Context.Set<T>().UpdateRange(Data);
            await _unitOfWork.Commit();
        }

        public async Task DeleteAll()
        {
            _unitOfWork.Context.Set<T>().RemoveRange(_unitOfWork.Context.Set<T>());
            await _unitOfWork.Commit();
        }
    }
}
