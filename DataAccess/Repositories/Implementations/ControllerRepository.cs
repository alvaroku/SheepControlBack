using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;
namespace DataAccess.Repositories.Implementations
{
    public class ControllerRepository : GenericRepository<Controller>, IControllerRepository
    {
        public ControllerRepository(SheepControlDbContext context) : base(context)
        {
        }
    }
}
