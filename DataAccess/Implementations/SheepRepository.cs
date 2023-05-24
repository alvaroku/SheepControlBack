using Entities;

namespace DataAccess.Implementations
{
    public class SheepRepository : BaseRepository<Sheep>
    {
        public SheepRepository(SheepControlDbContext context) : base(context)
        {
        }
    }
}
