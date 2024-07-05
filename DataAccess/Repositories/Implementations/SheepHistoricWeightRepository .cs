using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class SheepHistoricWeightRepository : GenericRepository<SheepHistoricWeight>, ISheepHistoricWeightRepository
    {
        public SheepHistoricWeightRepository(SheepControlDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<SheepHistoricWeight>> ReadIncludes()
        {
            return await _dbSet.Include(p => p.Sheep).ToListAsync();
        }
    }
}
