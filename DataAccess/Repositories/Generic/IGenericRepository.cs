using System.Linq.Expressions;

namespace DataAccess.Repositories.Generic
{
    public interface IGenericRepository<T>
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(int id);
        Task<bool> Exists(Expression<Func<T, bool>> expression);
        Task CreateRange(IEnumerable<T> Data);
        Task UpdateRange(IEnumerable<T> Data);
        Task DeleteAll();
    }
}
