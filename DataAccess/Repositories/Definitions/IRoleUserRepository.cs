using DataAccess.Repositories.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Definitions
{
    public interface IRoleUserRepository:IGenericRepository<RoleUser>
    {
         Task<RoleUser> GetIncludesById(int id);
         Task<IEnumerable<RoleUser>> GetIncludesListById(int id);
         Task<IEnumerable<RoleUser>> ReadIncludes();
         Task<IEnumerable<RoleUser>> ReadIncludesByUserId(int id);
         Task DeleteAllRolesByUserId(int id);
    }
}
