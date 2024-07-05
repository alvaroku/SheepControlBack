using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class SheepHistoricWeightRepository : GenericRepository<SheepHistoricWeight>, ISheepHistoricWeightRepository
    {
        public SheepHistoricWeightRepository(IUnitOfWork context) : base(context)
        {
        }
        public async Task<IEnumerable<SheepHistoricWeight>> ReadIncludes()
        {
            return await _unitOfWork.Context.SheepHistoricWeights.Include(p => p.Sheep).ToListAsync();
        }
    }
}
