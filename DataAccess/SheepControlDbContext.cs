using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SheepControlDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Sheep> Sheeps { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }

        public SheepControlDbContext(DbContextOptions<SheepControlDbContext> options) : base(options)
        {
        }
    }
}
