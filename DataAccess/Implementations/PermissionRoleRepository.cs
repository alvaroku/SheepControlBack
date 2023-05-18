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
        public IEnumerable<PermissionRole> ReadIncludesByRolId(int id)
        {
            return _dbSet.Where(e=>e.RoleId == id).Include(pu => pu.Permission).Include(pu => pu.Permission.Controller).Include(pu => pu.Permission.Action).Include(pu => pu.Role).ToList();
        }
        public IEnumerable<PermissionRole> ReadIncludesListByRoleId(int id)
        {
            return _dbSet.Where(r=>r.RoleId == id).Include(pu => pu.Permission).Include(pu => pu.Permission.Controller).Include(pu => pu.Permission.Action).Include(pu => pu.Role).ToList();
        }
        public void DeleteAllPermissionsByRolId(int id)
        {
            var allPR = _dbSet.Where(r => r.RoleId == id);
            _dbSet.RemoveRange(allPR);
            _context.SaveChanges();
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
