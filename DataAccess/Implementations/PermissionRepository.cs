using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations
{
    public class PermissionRepository : BaseRepository<PermissionRepository>
    {
        public PermissionRepository(SheepControlDbContext context) : base(context)
        {
        }
    }
}
