using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class SaleSheepRepository : GenericRepository<SaleSheep>,ISaleSheepRepository
    {
        public SaleSheepRepository(IUnitOfWork context) : base(context)
        {
        }

        public async Task<float> GetGanancias()
        {
           return await _unitOfWork.Context.SaleSheeps.SumAsync(x => x.SaleProfit);
        }

        public async Task<IEnumerable<SaleSheep>> ReadIncludes()
        {
            return await _unitOfWork.Context.SaleSheeps.Include(x => x.Sheep).ToListAsync();
        }
    }
}
