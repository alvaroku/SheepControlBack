using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Implementations
{
    public class VaccineSheepRepository:BaseRepository<VaccineSheep>
    {
        public VaccineSheepRepository(SheepControlDbContext context) : base(context)
        {
        }
        public IEnumerable<VaccineSheep> ReadIncludes()
        {
            return _dbSet.Include(vs => vs.Vaccine).Include(vs => vs.Sheep).ToList();
        }
        public VaccineSheep GetByIdIncludes(int id)
        {
            return _dbSet.Include(vs => vs.Vaccine).Include(vs => vs.Sheep).Where(x => x.Id == id ).FirstOrDefault();
        }
    }
}
