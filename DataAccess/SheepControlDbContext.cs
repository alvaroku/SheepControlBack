using Entities;
using Microsoft.EntityFrameworkCore;
using System;

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

            string[] _Controllers = new string[] { CONTROLLER_ACTION, CONTROLLER_CONTROLLER, CONTROLLER_PERMISSION, CONTROLLER_USER, CONTROLLER_PERMISSIONROLE, CONTROLLER_ROLE, CONTROLLER_ROLEUSER, CONTROLLER_SHEEP, CONTROLLER_VACCINE, CONTROLLER_VACCINESTOCK, CONTROLLER_VACCINESHEEP, CONTROLLER_SALESHEEP, CONTROLLER_SHEEPHISTORICWEIGHT };
            string[] _Actions = new string[] { ACTION_CREATE, ACTION_READ, ACTION_UPDATE, ACTION_DELETE, ACTION_TOGGLEACTIVE, ACTION_GETBYID, ACTION_DELETEALL, ACTION_READWITHFILTERS, ACTION_GETSHEEPWITHFINALWEIGHT };
            string[] _Roles = new string[] { ROLE_SUPERADMIN, ROLE_ADMIN, ROLE_USER, ROLE_INVITED, ROLE_CUSTOM };



            // Aquí puedes definir tus entidades y configuraciones

            //Agrega controllers
            List<Controller> controllers = new List<Controller>();
            int contControllerId = 0;

            foreach (var controller in _Controllers)
            {
                contControllerId++;
                controllers.Add(new Controller { Id = contControllerId, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, Name = controller });
            }
            modelBuilder.Entity<Controller>().HasData(controllers);

            //Agrega actions
            List<Entities.Action> actions = new List<Entities.Action>();
            int contActionId = 0;
            foreach (var action in _Actions)
            {
                contActionId++;
                actions.Add(new Entities.Action { Id = contActionId, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, Name = action });

            }
            modelBuilder.Entity<Entities.Action>().HasData(actions);

            List<Permission> permissions = new List<Permission>();
            int contPermissionId = 0;

            foreach (var c in controllers)
            {
                foreach (var a in actions)
                {
                    if (!a.Name.Equals(ACTION_GETSHEEPWITHFINALWEIGHT))
                    {
                        contPermissionId++;
                        permissions.Add(new Permission { Id = contPermissionId, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, ControllerId = c.Id, ActionId = a.Id, Clave = $"{c.Name}_{a.Name}", Description = $"Permiso para el módulo {c.Name} y la acción {a.Name}" });
                    }

                }
                if (c.Name.Equals(CONTROLLER_SHEEP))
                {
                    contPermissionId++;
                    permissions.Add(new Permission { Id = contPermissionId, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, ControllerId = c.Id, ActionId = actions.Where(x => x.Name.Equals(ACTION_GETSHEEPWITHFINALWEIGHT)).First().Id, Clave = $"{c.Name}_{actions.Where(x => x.Name.Equals(ACTION_GETSHEEPWITHFINALWEIGHT)).First().Name}", Description = $"Permiso para el módulo {c.Name} y la acción {actions.Where(x => x.Name.Equals(ACTION_GETSHEEPWITHFINALWEIGHT)).First().Name}" });
                }
            }
            modelBuilder.Entity<Permission>().HasData(permissions);

            List<Role> roles = new List<Role>();
            int cont = 0;

            foreach (var role in _Roles)
            {
                cont++;
                roles.Add(new Role { Id = cont, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, Name = role });
            }

            modelBuilder.Entity<Role>().HasData(roles);



            //Asignación de permisos por rol

            List<PermissionRole> permisionRole = new List<PermissionRole>();
            int contPermisionRoleId = 0;

            //para el superAdmin
            foreach (var p in permissions)
            {
                contPermisionRoleId++;
                permisionRole.Add(new PermissionRole { Id = contPermisionRoleId, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = p.Id, RoleId = roles.Where(x => x.Name.Equals(ROLE_SUPERADMIN)).First().Id });
            }

            //para el admin
            var controllersForAdmin = new string[] { CONTROLLER_SALESHEEP, CONTROLLER_SHEEP, CONTROLLER_USER, CONTROLLER_VACCINE, CONTROLLER_VACCINESHEEP, CONTROLLER_VACCINESTOCK, CONTROLLER_SHEEPHISTORICWEIGHT };
            var actionsForAdmin = new string[] { ACTION_CREATE, ACTION_READ, ACTION_UPDATE, ACTION_DELETE, ACTION_DELETEALL, ACTION_READWITHFILTERS, ACTION_TOGGLEACTIVE, ACTION_GETBYID };
            foreach (var c in controllersForAdmin)
            {
                foreach (var ac in actionsForAdmin)
                {
                    contPermisionRoleId++;
                    permisionRole.AddRange(
                        permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == c).First().Id) && (x.ActionId == actions.Where(d => d.Name == ac).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(ROLE_ADMIN)).First().Id })
                        );
                }
                if (c.Equals(CONTROLLER_SHEEP))
                {
                    contPermisionRoleId++;
                    permisionRole.AddRange(
                        permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == c).First().Id) && (x.ActionId == actions.Where(d => d.Name == ACTION_GETSHEEPWITHFINALWEIGHT).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(ROLE_ADMIN)).First().Id })
                        );
                }
            }

            //para el user
            var controllersForUser = new string[] { CONTROLLER_SALESHEEP, CONTROLLER_SHEEP, CONTROLLER_VACCINE, CONTROLLER_VACCINESHEEP, CONTROLLER_VACCINESTOCK, CONTROLLER_SHEEPHISTORICWEIGHT };
            var actionsForUser = new string[] { ACTION_CREATE, ACTION_READ, ACTION_UPDATE, ACTION_READWITHFILTERS, ACTION_TOGGLEACTIVE, ACTION_GETBYID };
            foreach (var c in controllersForUser)
            {
                foreach (var ac in actionsForUser)
                {
                    contPermisionRoleId++;
                    permisionRole.AddRange(
                        permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == c).First().Id) && (x.ActionId == actions.Where(d => d.Name == ac).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(ROLE_USER)).First().Id })
                        );
                }
                if (c.Equals(CONTROLLER_SHEEP))
                {
                    contPermisionRoleId++;
                    permisionRole.AddRange(
                        permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == c).First().Id) && (x.ActionId == actions.Where(d => d.Name == ACTION_GETSHEEPWITHFINALWEIGHT).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(ROLE_USER)).First().Id })
                        );
                }
            }

            //para el invited
            var controllersForInvited = new string[] { CONTROLLER_SALESHEEP, CONTROLLER_SHEEP, CONTROLLER_VACCINE, CONTROLLER_VACCINESHEEP, CONTROLLER_VACCINESTOCK, CONTROLLER_SHEEPHISTORICWEIGHT };
            var actionsForInvited = new string[] { ACTION_READ, ACTION_READWITHFILTERS, ACTION_GETBYID };
            foreach (var c in controllersForInvited)
            {
                foreach (var ac in actionsForInvited)
                {
                    contPermisionRoleId++;
                    permisionRole.AddRange(
                        permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == c).First().Id) && (x.ActionId == actions.Where(d => d.Name == ac).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(ROLE_INVITED)).First().Id })
                        );
                }
                if (c.Equals(CONTROLLER_SHEEP))
                {
                    contPermisionRoleId++;
                    permisionRole.AddRange(
                        permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == c).First().Id) && (x.ActionId == actions.Where(d => d.Name == ACTION_GETSHEEPWITHFINALWEIGHT).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(ROLE_INVITED)).First().Id })
                        );
                }
            }
            modelBuilder.Entity<PermissionRole>().HasData(permisionRole);

            //usuarios base
            string USER_SUPERADMIN_NAME = "sa";
            string USER_SUPERADMIN_EMAIL = "sa@gmail.com";
            string USER_SUPERADMIN_PASSWORD = "sa";
            string USER_SUPERADMIN_PHONE = "9919596720";

            modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = USER_SUPERADMIN_NAME, LastName = USER_SUPERADMIN_NAME, Email = USER_SUPERADMIN_EMAIL, Password = USER_SUPERADMIN_PASSWORD, PhoneNumber = USER_SUPERADMIN_PHONE, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now });

            string USER_ADMIN_NAME = "admin";
            string USER_ADMIN_EMAIL = "admin@gmail.com";
            string USER_ADMIN_PASSWORD = "admin";
            string USER_ADMIN_PHONE = "9919596720";

            modelBuilder.Entity<User>().HasData(new User { Id = 2, Name = USER_ADMIN_NAME, LastName = USER_ADMIN_NAME, Email = USER_ADMIN_EMAIL, Password = USER_ADMIN_PASSWORD, PhoneNumber = USER_ADMIN_PHONE, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now });

            string USER_USER_NAME = "Alvaro";
            string USER_USER_LASTNAME = "Kú";
            string USER_USER_EMAIL = "alvaroku123@gmail.com";
            string USER_USER_PASSWORD = "12345";
            string USER_USER_PHONE = "9919596720";

            modelBuilder.Entity<User>().HasData(new User { Id = 3, Name = USER_USER_NAME, LastName = USER_USER_LASTNAME, Email = USER_USER_EMAIL, Password = USER_USER_PASSWORD, PhoneNumber = USER_USER_PHONE, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now });

            string USER_INVITED_NAME = "Invitado";
            string USER_INVITED_EMAIL = "invitado@gmail.com";
            string USER_INVITED_PASSWORD = "12345";
            string USER_INVITED_PHONE = "9919596720";

            modelBuilder.Entity<User>().HasData(new User { Id = 4, Name = USER_INVITED_NAME, LastName = USER_INVITED_NAME, Email = USER_INVITED_EMAIL, Password = USER_INVITED_PASSWORD, PhoneNumber = USER_INVITED_PHONE, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now });

            //asignar roles a los usuarios base
            List<RoleUser> roleUsers = new List<RoleUser>();

            roleUsers.Add(new RoleUser { Active = true, Id = 1, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, UserId = 1, RoleId = roles.Where(x => x.Name.Equals(ROLE_SUPERADMIN)).First().Id });
            roleUsers.Add(new RoleUser { Active = true, Id = 2, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, UserId = 2, RoleId = roles.Where(x => x.Name.Equals(ROLE_ADMIN)).First().Id });
            roleUsers.Add(new RoleUser { Active = true, Id = 3, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, UserId = 3, RoleId = roles.Where(x => x.Name.Equals(ROLE_USER)).First().Id });
            roleUsers.Add(new RoleUser { Active = true, Id = 4, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, UserId = 4, RoleId = roles.Where(x => x.Name.Equals(ROLE_INVITED)).First().Id });

            modelBuilder.Entity<RoleUser>().HasData(roleUsers);

            base.OnModelCreating(modelBuilder);
        }
    }
}
