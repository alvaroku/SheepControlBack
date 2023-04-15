using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations
{
    public class ActionRepository:BaseRepository<Entities.Action>
    {
        public ActionRepository(SheepControlDbContext context) : base(context)
        {
        }
    }
}
