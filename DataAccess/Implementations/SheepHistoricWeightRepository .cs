using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Implementations
{
    public class SheepHistoricWeightRepository : BaseRepository<SheepHistoricWeight>
    {
        public SheepHistoricWeightRepository(SheepControlDbContext context) : base(context)
        {
        }
        public IEnumerable<SheepHistoricWeight> ReadIncludes()
        {
            return _dbSet.Include(p=>p.Sheep).ToList();
        }
    }
}
