using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations
{
    public class RoleRepository : BaseRepository<Role>
    {
        public RoleRepository(SheepControlDbContext context) : base(context)
        {
        }
    }
}
