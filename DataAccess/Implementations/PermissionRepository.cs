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
            return _dbSet.Include(p=>p.Controller).Include(p=>p.Action).ToList();
        }
        public Permission GetIncludesById(int id)
        {
            return _dbSet.Include(p => p.Controller).Include(p => p.Action).Where(p=>p.Id == id).First();
        }
    }
}
