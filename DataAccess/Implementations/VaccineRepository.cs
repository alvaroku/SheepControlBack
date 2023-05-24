using Entities;

namespace DataAccess.Implementations
{
    public class VaccineRepository : BaseRepository<Vaccine>
    {
        public VaccineRepository(SheepControlDbContext context) : base(context)
        {
        }
    }
}
