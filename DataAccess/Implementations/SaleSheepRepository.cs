using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Implementations
{
    public class SaleSheepRepository:BaseRepository<Entities.SaleSheep>
    {
        public SaleSheepRepository(SheepControlDbContext context) : base(context)
        {
        }
        public IEnumerable<SaleSheep> ReadIncludes()
        {
            return _dbSet.Include(x => x.Sheep).ToList();
        }
    }
}
