using DataAccess.Repositories.Generic;
using Entities;

namespace DataAccess.Repositories.Definitions
{
    public interface IPermissionRoleRepository : IGenericRepository<PermissionRole>
    {
        Task<PermissionRole> GetIncludesById(int id);
        Task<IEnumerable<PermissionRole>> ReadIncludes();
        Task<IEnumerable<PermissionRole>> ReadIncludesByRolId(int id);
        Task<IEnumerable<PermissionRole>> ReadIncludesListByRoleId(int id);
        Task DeleteAllPermissionsByRolId(int id);
    }
}
