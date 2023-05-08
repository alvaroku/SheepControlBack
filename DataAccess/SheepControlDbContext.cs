using Entities;
using Microsoft.EntityFrameworkCore;


namespace DataAccess
{
    public class SheepControlDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Sheep> Sheeps { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<VaccineSheep> VaccinesSheeps { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionUser> PermissionsUsers { get; set; }
        public DbSet<Controller> Controllers { get; set; }
        public DbSet<Entities.Action> Actions { get; set; }
        public SheepControlDbContext(DbContextOptions<SheepControlDbContext> options) : base(options)
        {
        }
    }
}
