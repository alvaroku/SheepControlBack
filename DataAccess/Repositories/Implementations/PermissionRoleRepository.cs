using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class PermissionRoleRepository : GenericRepository<PermissionRole>,IPermissionRoleRepository
    {
        public PermissionRoleRepository(IUnitOfWork context) : base(context)
        {
        }
        public async Task<PermissionRole> GetIncludesById(int id)
        {
            return await _unitOfWork.Context.PermissionsRoles.Where(r => r.Id == id)
                .Include(pu => pu.Permission)
                .Include(pu => pu.Permission.Controller)
                .Include(pu => pu.Permission.Action)
                .Include(pu => pu.Role).FirstAsync();
        }
        public async Task<IEnumerable<PermissionRole>> ReadIncludes()
        {
            return await _unitOfWork.Context.PermissionsRoles.Include(pu => pu.Permission).Include(pu => pu.Permission.Controller).Include(pu => pu.Permission.Action).Include(pu => pu.Role).ToListAsync();
        }
        public async Task<IEnumerable<PermissionRole>> ReadIncludesByRolId(int id)
        {
            return await _unitOfWork.Context.PermissionsRoles.Where(e => e.RoleId == id).Include(pu => pu.Permission).Include(pu => pu.Permission.Controller).Include(pu => pu.Permission.Action).Include(pu => pu.Role).ToListAsync();
        }
        public async Task<IEnumerable<PermissionRole>> ReadIncludesListByRoleId(int id)
        {
            return await _unitOfWork.Context.PermissionsRoles.Where(r => r.RoleId == id).Include(pu => pu.Permission).Include(pu => pu.Permission.Controller).Include(pu => pu.Permission.Action).Include(pu => pu.Role).ToListAsync();
        }
        public async Task DeleteAllPermissionsByRolId(int id)
        {
            var allPR = _unitOfWork.Context.PermissionsRoles.Where(r => r.RoleId == id);
            _unitOfWork.Context.PermissionsRoles.RemoveRange(allPR);
            await _unitOfWork.Commit();
            try
            {
                string table = _unitOfWork.Context.PermissionsRoles.EntityType.Name.Split(".")[1];
                string sp = $"ResetId{table}";
                string command = "EXEC " + sp;
                _unitOfWork.Context.PermissionsRoles.FromSqlRaw(command).ToList();
            }
            catch (Exception e)
            {

            }
        }
    }
}
