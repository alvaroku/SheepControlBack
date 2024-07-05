using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class SaleSheepRepository : GenericRepository<SaleSheep>,ISaleSheepRepository
    {
        public SaleSheepRepository(SheepControlDbContext context) : base(context)
        {
        }

        public async Task<float> GetGanancias()
        {
           return await _dbSet.SumAsync(x => x.SaleProfit);
        }

        public async Task<IEnumerable<SaleSheep>> ReadIncludes()
        {
            return await _dbSet.Include(x => x.Sheep).ToListAsync();
        }
    }
}
