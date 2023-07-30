using Entities;

namespace DataAccess.Implementations
{
    public class RoleRepository : BaseRepository<Role>
    {
        public RoleRepository(SheepControlDbContext context) : base(context)
        {
        }
    }
}
