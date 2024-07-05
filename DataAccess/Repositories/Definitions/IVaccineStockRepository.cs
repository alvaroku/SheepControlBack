using DataAccess.Repositories.Generic;
using Entities;

namespace DataAccess.Repositories.Definitions
{
    public interface IVaccineStockRepository : IGenericRepository<VaccineStock>
    {
        Task<IEnumerable<VaccineStock>> ReadIncludes();
        Task<VaccineStock> GetByIdIncludes(int id);
    }
}
