using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Implementations
{
    public class PermissionRepository : BaseRepository<Permission>
    {
        public PermissionRepository(SheepControlDbContext context) : base(context)
        {
        }
        public IEnumerable<Permission> ReadIncludes()
        {
            return _dbSet.Include(p => p.Controller).Include(p => p.Action).ToList();
        }
        public IEnumerable<Permission> ReadIncludesByControllerId(int id)
        {
            return _dbSet.Where(e => e.ControllerId == id).Include(pu => pu.Controller).Include(pu => pu.Action).ToList();
        }
        public Permission GetIncludesById(int id)
        {
            return _dbSet.Include(p => p.Controller).Include(p => p.Action).Where(p=>p.Id == id).First();
        }
        public void DeleteAllActionsByControllerId(int id)
        {
            var allPR = _dbSet.Where(r => r.ControllerId == id);
            _dbSet.RemoveRange(allPR);
            _context.SaveChanges();
        }
    }
}
