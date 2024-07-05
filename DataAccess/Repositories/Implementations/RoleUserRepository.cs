using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class RoleUserRepository : GenericRepository<RoleUser>,IRoleUserRepository
    {
        public RoleUserRepository(SheepControlDbContext context) : base(context)
        {
        }
        public async Task<RoleUser> GetIncludesById(int id)
        {
            return await _dbSet.Where(r => r.Id == id).Include(pu => pu.Role).Include(pu => pu.User).FirstAsync();
        }
        public async Task<IEnumerable<RoleUser>> GetIncludesListById(int id)
        {
            return await _dbSet.Where(r => r.UserId == id).Include(pu => pu.Role).Include(pu => pu.User).ToListAsync();
        }
        public async Task<IEnumerable<RoleUser>> ReadIncludes()
        {
            return await _dbSet.Include(pu => pu.Role).Include(pu => pu.User).ToListAsync();
        }
        public async Task<IEnumerable<RoleUser>> ReadIncludesByUserId(int id)
        {
            return await _dbSet.Where(e => e.UserId == id).Include(pu => pu.Role).Include(x => x.User).ToListAsync();
        }
        public async Task DeleteAllRolesByUserId(int id)
        {
            var allPR = _dbSet.Where(r => r.UserId == id);
            _dbSet.RemoveRange(allPR);
            await _context.SaveChangesAsync();
        }
    }
}
