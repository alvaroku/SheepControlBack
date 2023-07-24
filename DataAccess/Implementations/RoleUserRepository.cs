using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Implementations
{
    public class RoleUserRepository : BaseRepository<RoleUser>
    {
        public RoleUserRepository(SheepControlDbContext context) : base(context)
        {
        }
        public RoleUser GetIncludesById(int id)
        {
            return _dbSet.Where(r => r.Id == id).Include(pu => pu.Role).Include(pu => pu.User).First();
        }
        public IEnumerable<RoleUser> GetIncludesListById(int id)
        {
            return _dbSet.Where(r => r.UserId == id).Include(pu => pu.Role).Include(pu => pu.User).ToList();
        }
        public IEnumerable< RoleUser> ReadIncludes()
        {
            return _dbSet.Include(pu => pu.Role).Include(pu => pu.User).ToList();
        }
        public IEnumerable<RoleUser> ReadIncludesByUserId(int id)
        {
            return _dbSet.Where(e => e.UserId == id).Include(pu => pu.Role).Include(x=>x.User).ToList();
        }
        public void DeleteAllRolesByUserId(int id)
        {
            var allPR = _dbSet.Where(r => r.UserId == id);
            _dbSet.RemoveRange(allPR);
            _context.SaveChanges();
        }
    }
}
