using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations
{
    public class SaleSheepRepository:BaseRepository<Entities.SaleSheep>
    {
        public SaleSheepRepository(SheepControlDbContext context) : base(context)
        {
        }
        public IEnumerable<SaleSheep> ReadIncludes()
        {
            return _dbSet.Include(x => x.Sheep).ToList();
        }
    }
}
