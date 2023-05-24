using Entities;
namespace DataAccess.Implementations
{
    public class ControllerRepository : BaseRepository<Controller>
    {
        public ControllerRepository(SheepControlDbContext context) : base(context)
        {
        }
    }
}
