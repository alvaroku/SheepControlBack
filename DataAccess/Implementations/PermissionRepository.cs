using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

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
