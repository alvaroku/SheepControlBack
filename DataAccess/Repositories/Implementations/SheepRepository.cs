using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class SheepRepository : GenericRepository<Sheep>, ISheepRepository
    {
        public SheepRepository(IUnitOfWork context) : base(context)
        {
        }

        public async Task<float> GetGastoCompra()
        {
            return await _unitOfWork.Context.Sheeps.Where(x => x.IsAcquisition).SumAsync(y => y.AcquisitionCost);
        }
    }
}
