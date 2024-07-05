using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class PermissionRepository : GenericRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(SheepControlDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Permission>> ReadIncludes()
        {
            return await _dbSet.Include(p => p.Controller).Include(p => p.Action).ToListAsync();
        }
        public async Task<IEnumerable<Permission>> ReadIncludesByControllerId(int id)
        {
            return await _dbSet.Where(e => e.ControllerId == id).Include(pu => pu.Controller).Include(pu => pu.Action).ToListAsync();
        }
        public async Task<Permission> GetIncludesById(int id)
        {
            return await _dbSet.Include(p => p.Controller).Include(p => p.Action).Where(p => p.Id == id).FirstAsync();
        }
        public async Task DeleteAllActionsByControllerId(int id)
        {
            var allPR = _dbSet.Where(r => r.ControllerId == id);
            _dbSet.RemoveRange(allPR);
            await _context.SaveChangesAsync();
        }
    }
}
