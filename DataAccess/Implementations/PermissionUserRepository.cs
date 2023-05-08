using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations
{
    public class PermissionUserRepository : BaseRepository<PermissionUser>
    {
        public PermissionUserRepository(SheepControlDbContext context) : base(context)
        {
        }
        public IEnumerable<PermissionUser> GetPermissionByUserIncludes(int userId)
        {
            return _dbSet.Where(r => r.UserId == userId).Include(pu=>pu.Permission).Include(pu=>pu.Permission.Controller).Include(pu => pu.Permission.Action).ToList();
        }
    }
}
