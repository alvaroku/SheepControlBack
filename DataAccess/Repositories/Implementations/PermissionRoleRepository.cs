using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class PermissionRoleRepository : GenericRepository<PermissionRole>,IPermissionRoleRepository
    {
        public PermissionRoleRepository(SheepControlDbContext context) : base(context)
        {
        }
        public async Task<PermissionRole> GetIncludesById(int id)
        {
            return await _dbSet.Where(r => r.Id == id)
                .Include(pu => pu.Permission)
                .Include(pu => pu.Permission.Controller)
                .Include(pu => pu.Permission.Action)
                .Include(pu => pu.Role).FirstAsync();
        }
        public async Task<IEnumerable<PermissionRole>> ReadIncludes()
        {
            return await _dbSet.Include(pu => pu.Permission).Include(pu => pu.Permission.Controller).Include(pu => pu.Permission.Action).Include(pu => pu.Role).ToListAsync();
        }
        public async Task<IEnumerable<PermissionRole>> ReadIncludesByRolId(int id)
        {
            return await _dbSet.Where(e => e.RoleId == id).Include(pu => pu.Permission).Include(pu => pu.Permission.Controller).Include(pu => pu.Permission.Action).Include(pu => pu.Role).ToListAsync();
        }
        public async Task<IEnumerable<PermissionRole>> ReadIncludesListByRoleId(int id)
        {
            return await _dbSet.Where(r => r.RoleId == id).Include(pu => pu.Permission).Include(pu => pu.Permission.Controller).Include(pu => pu.Permission.Action).Include(pu => pu.Role).ToListAsync();
        }
        public async Task DeleteAllPermissionsByRolId(int id)
        {
            var allPR = _dbSet.Where(r => r.RoleId == id);
            _dbSet.RemoveRange(allPR);
            await _context.SaveChangesAsync();
            try
            {
                string table = _dbSet.EntityType.Name.Split(".")[1];
                string sp = $"ResetId{table}";
                string command = "EXEC " + sp;
                _dbSet.FromSqlRaw(command).ToList();
            }
            catch (Exception e)
            {

            }
        }
    }
}
