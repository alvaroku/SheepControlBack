using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations
{
    public class PermissionRoleRepository : BaseRepository<PermissionRole>
    {
        public PermissionRoleRepository(SheepControlDbContext context) : base(context)
        {
        }
        public PermissionRole GetIncludesById(int id)
        {
            return _dbSet.Where(r => r.Id == id).Include(pu => pu.Permission).Include(pu => pu.Permission.Controller).Include(pu => pu.Permission.Action).Include(pu => pu.Role).First();
        }
        public IEnumerable< PermissionRole> ReadIncludes()
        {
            return _dbSet.Include(pu => pu.Permission).Include(pu => pu.Permission.Controller).Include(pu => pu.Permission.Action).Include(pu => pu.Role).ToList();
        }
        public IEnumerable<PermissionRole> ReadIncludesListByRoleId(int id)
        {
            return _dbSet.Where(r=>r.RoleId == id).Include(pu => pu.Permission).Include(pu => pu.Permission.Controller).Include(pu => pu.Permission.Action).Include(pu => pu.Role).ToList();
        }
    }
}
