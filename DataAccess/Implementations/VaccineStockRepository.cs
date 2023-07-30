using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Implementations
{
    public class VaccineStockRepository : BaseRepository<VaccineStock>
    {
        public VaccineStockRepository(SheepControlDbContext context) : base(context)
        {
        }
        public IEnumerable<VaccineStock> ReadIncludes()
        {
            return _dbSet.Include(vs => vs.Vaccine).ToList();
        }
        public VaccineStock GetByIdIncludes(int id)
        {
            return _dbSet.Include(vs => vs.Vaccine).Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
