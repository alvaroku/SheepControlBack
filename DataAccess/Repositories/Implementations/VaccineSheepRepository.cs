using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class VaccineSheepRepository : GenericRepository<VaccineSheep>, IVaccineSheepRepository
    {
        public VaccineSheepRepository(IUnitOfWork context) : base(context)
        {
        }
        public async Task<IEnumerable<VaccineSheep>> ReadIncludes()
        {
            return await _unitOfWork.Context.VaccinesSheeps.Include(vs => vs.Vaccine).Include(vs => vs.Sheep).ToListAsync();
        }
        public async Task<VaccineSheep> GetByIdIncludes(int id)
        {
            return await _unitOfWork.Context.VaccinesSheeps.Include(vs => vs.Vaccine).Include(vs => vs.Sheep).Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
