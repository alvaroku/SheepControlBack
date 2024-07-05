using DataAccess.Repositories.Generic;
using Entities;

namespace DataAccess.Repositories.Definitions
{
    public interface ISaleSheepRepository:IGenericRepository<SaleSheep>
    {
        Task<IEnumerable<SaleSheep>> ReadIncludes();
        Task<float> GetGanancias();
    }
}
