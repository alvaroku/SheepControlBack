using DataAccess.Repositories.Generic;
using Entities;

namespace DataAccess.Repositories.Definitions
{
    public interface IPermissionRepository : IGenericRepository<Permission>
    {
        Task<IEnumerable<Permission>> ReadIncludes();
        Task<IEnumerable<Permission>> ReadIncludesByControllerId(int id);
        Task<Permission> GetIncludesById(int id);
        Task DeleteAllActionsByControllerId(int id);
    }
}
