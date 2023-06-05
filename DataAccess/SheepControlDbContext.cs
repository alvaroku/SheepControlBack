using Entities;
using Microsoft.EntityFrameworkCore;
namespace DataAccess
{
    public class SheepControlDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Sheep> Sheeps { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<VaccineStock> VaccinesStock { get; set; }   
        public DbSet<VaccineSheep> VaccinesSheeps { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<PermissionRole> PermissionsRoles { get; set; }
        public DbSet<RoleUser> RolesUsers { get; set; }
        public DbSet<Controller> Controllers { get; set; }
        public DbSet<Entities.Action> Actions { get; set; }
        public DbSet<SaleSheep> SaleSheeps { get; set; }
        public DbSet<SheepHistoricWeight> SheepHistoricWeights { get; set; }
        public SheepControlDbContext(DbContextOptions<SheepControlDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Controllers
            string CONTROLLER_ACTION = "Action";
            string CONTROLLER_CONTROLLER = "Controller";
            string CONTROLLER_PERMISSION = "Permission";
            string CONTROLLER_USER = "User";
            string CONTROLLER_ROLE = "Role";
            string CONTROLLER_PERMISSIONROLE = "PermissionRole";
            string CONTROLLER_ROLEUSER = "RoleUser";
            string CONTROLLER_SHEEP = "Sheep";
            string CONTROLLER_VACCINE = "Vaccine";
            string CONTROLLER_VACCINESTOCK = "VaccineStock";
        string CONTROLLER_VACCINESHEEP = "VaccineSheep";
            string CONTROLLER_SALESHEEP = "SaleSheep";
            string CONTROLLER_SHEEPHISTORICWEIGHT = "SheepHistoricWeight";
            #endregion

            #region DefaultActions
            string ACTION_CREATE = "Create";
            string ACTION_READ = "Read";
            string ACTION_UPDATE = "Update";
            string ACTION_DELETE = "Delete";
            string ACTION_READWITHFILTERS = "GetWithFilters";
            #endregion

            #region AditionalActions
            string ACTION_TOGGLEACTIVE = "ToggleActive";
            string ACTION_GETBYID = "GetById";
            string ACTION_DELETEALL = "DeleteAll";
            string ACTION_GETSHEEPWITHFINALWEIGHT = "GetSheepWithFinalWeight";
            #endregion

            #region Roles
            string ROLE_SUPERADMIN = "SuperAdmin";
            string ROLE_ADMIN = "Admin";
            string ROLE_USER = "User";
            string ROLE_INVITED = "Invited";
            string ROLE_CUSTOM = "Custom";
            #endregion

            string[] _Controllers = new string[] { CONTROLLER_ACTION, CONTROLLER_CONTROLLER, CONTROLLER_PERMISSION, CONTROLLER_USER, CONTROLLER_PERMISSIONROLE, CONTROLLER_ROLE, CONTROLLER_ROLEUSER, CONTROLLER_SHEEP, CONTROLLER_VACCINE, CONTROLLER_VACCINESTOCK, CONTROLLER_VACCINESHEEP,CONTROLLER_SALESHEEP, CONTROLLER_SHEEPHISTORICWEIGHT };
            string[] _Actions = new string[] { ACTION_CREATE, ACTION_READ, ACTION_UPDATE, ACTION_DELETE, ACTION_TOGGLEACTIVE, ACTION_GETBYID, ACTION_DELETEALL, ACTION_READWITHFILTERS, ACTION_GETSHEEPWITHFINALWEIGHT };
            string[] _Roles = new string[] { ROLE_SUPERADMIN, ROLE_ADMIN, ROLE_USER, ROLE_INVITED, ROLE_CUSTOM };
            base.OnModelCreating(modelBuilder);
            int cont = 0;
            // Aquí puedes definir tus entidades y configuraciones
            List<Controller> controllers = new List<Controller>();
            cont = 0;
            foreach (var controller in _Controllers) {
                cont++;
                controllers.Add(new Controller { Id = cont, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, Name = controller });
            }

            modelBuilder.Entity<Controller>().HasData(controllers);

            cont = 0;
            List<Entities.Action> actions = new List<Entities.Action>();

            foreach (var action in _Actions)
            {
                cont++;
                actions.Add(new Entities.Action {Id=cont, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, Name = action });
            }

            modelBuilder.Entity<Entities.Action>().HasData(actions);

            cont = 0;
            List<Role> roles = new List<Role>();

            foreach (var role in _Roles)
            {
                cont++;
                roles.Add(new Role { Id = cont, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, Name = role });
            }

            modelBuilder.Entity<Role>().HasData(roles);


            string USER_SUPERADMIN_NAME = "sa";
            string USER_SUPERADMIN_EMAIL = "sa@gmail.com";
            string USER_SUPERADMIN_PASSWORD = "sa";
            string USER_SUPERADMIN_PHONE = "9919596720";

            modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = USER_SUPERADMIN_NAME, LastName = USER_SUPERADMIN_NAME, Email = USER_SUPERADMIN_EMAIL, Password = USER_SUPERADMIN_PASSWORD, PhoneNumber = USER_SUPERADMIN_PHONE, Active = true,CreationDate=DateTime.Now,ModificationDate=DateTime.Now }); ;
        }
    }
}
