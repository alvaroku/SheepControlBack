using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;

namespace DataAccess.Repositories.Implementations
{
    public class ActionRepository : GenericRepository<Entities.Action>, IActionRepository
    {
        public ActionRepository(SheepControlDbContext context) : base(context)
        {
        }
    }
}
