using DataAccess.Repositories.Generic;
using Entities;

namespace DataAccess.Repositories.Definitions
{
    public interface IVaccineSheepRepository : IGenericRepository<VaccineSheep>
    {
        Task<IEnumerable<VaccineSheep>> ReadIncludes();
        Task<VaccineSheep> GetByIdIncludes(int id);
    }
}
