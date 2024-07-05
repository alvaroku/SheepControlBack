using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;

namespace DataAccess.Repositories.Implementations
{
    public class RoleRepository : GenericRepository<Role>,IRoleRepository
    {
        public RoleRepository(IUnitOfWork context) : base(context)
        {
        }
    }
}
