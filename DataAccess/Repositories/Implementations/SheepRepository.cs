using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class SheepRepository : GenericRepository<Sheep>, ISheepRepository
    {
        public SheepRepository(SheepControlDbContext context) : base(context)
        {
        }

        public async Task<float> GetGastoCompra()
        {
            return await _dbSet.Where(x => x.IsAcquisition).SumAsync(y => y.AcquisitionCost);
        }
    }
}
