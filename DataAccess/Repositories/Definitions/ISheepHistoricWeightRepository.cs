using DataAccess.Repositories.Generic;
using Entities;

namespace DataAccess.Repositories.Definitions
{
    public interface ISheepHistoricWeightRepository:IGenericRepository<SheepHistoricWeight>
    {
        Task<IEnumerable<SheepHistoricWeight>> ReadIncludes();
    }
}
