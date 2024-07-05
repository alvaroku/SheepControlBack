using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class VaccineStockRepository : GenericRepository<VaccineStock>,IVaccineStockRepository
    {
        public VaccineStockRepository(IUnitOfWork context) : base(context)
        {
        }
        public async Task<IEnumerable<VaccineStock>>  ReadIncludes()
        {
            return await _unitOfWork.Context.VaccinesStock.Include(vs => vs.Vaccine).ToListAsync();
        }
        public async Task<VaccineStock> GetByIdIncludes(int id)
        {
            return await _unitOfWork.Context.VaccinesStock.Include(vs => vs.Vaccine).Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
