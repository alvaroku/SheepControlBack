using Entities;
using Microsoft.EntityFrameworkCore;
using Shared;

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
            // Aquí puedes definir tus entidades y configuraciones

            //Agrega controllers
            List<Controller> controllers = new List<Controller>();
            int contControllerId = 0;

            foreach (var controller in DefaultInformationDbConstants._Controllers)
            {
                contControllerId++;
                controllers.Add(new Controller { Id = contControllerId, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, Name = controller });
            }
            modelBuilder.Entity<Controller>().HasData(controllers);

            //Agrega actions
            List<Entities.Action> actions = new List<Entities.Action>();
            int contActionId = 0;
            foreach (var action in DefaultInformationDbConstants._Actions)
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
                    if (!a.Name.Equals(DefaultInformationDbConstants.ACTION_GETSHEEPWITHFINALWEIGHT) && !a.Name.Equals(DefaultInformationDbConstants.ACTION_UPDATEPROFILE))
                    {
                        contPermissionId++;
                        permissions.Add(new Permission { Id = contPermissionId, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, ControllerId = c.Id, ActionId = a.Id, Clave = $"{c.Name}_{a.Name}", Description = $"Permiso para el módulo {c.Name} y la acción {a.Name}" });
                    }

                }
                if (c.Name.Equals(DefaultInformationDbConstants.CONTROLLER_SHEEP))
                {
                    contPermissionId++;
                    permissions.Add(new Permission { Id = contPermissionId, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, ControllerId = c.Id, ActionId = actions.Where(x => x.Name.Equals(DefaultInformationDbConstants.ACTION_GETSHEEPWITHFINALWEIGHT)).First().Id, Clave = $"{c.Name}_{actions.Where(x => x.Name.Equals(DefaultInformationDbConstants.ACTION_GETSHEEPWITHFINALWEIGHT)).First().Name}", Description = $"Permiso para el módulo {c.Name} y la acción {actions.Where(x => x.Name.Equals(DefaultInformationDbConstants.ACTION_GETSHEEPWITHFINALWEIGHT)).First().Name}" });
                }
                if (c.Name.Equals(DefaultInformationDbConstants.CONTROLLER_USER))
                {
                    contPermissionId++;
                    permissions.Add(new Permission { Id = contPermissionId, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, ControllerId = c.Id, ActionId = actions.Where(x => x.Name.Equals(DefaultInformationDbConstants.ACTION_UPDATEPROFILE)).First().Id, Clave = $"{c.Name}_{actions.Where(x => x.Name.Equals(DefaultInformationDbConstants.ACTION_UPDATEPROFILE)).First().Name}", Description = $"Permiso para el módulo {c.Name} y la acción {actions.Where(x => x.Name.Equals(DefaultInformationDbConstants.ACTION_UPDATEPROFILE)).First().Name}" });
                }
            }
            modelBuilder.Entity<Permission>().HasData(permissions);

            List<Role> roles = new List<Role>();
            int cont = 0;

            foreach (var role in DefaultInformationDbConstants._Roles)
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
                permisionRole.Add(new PermissionRole { Id = contPermisionRoleId, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = p.Id, RoleId = roles.Where(x => x.Name.Equals(DefaultInformationDbConstants.ROLE_SUPERADMIN)).First().Id });
            }

            //para el admin
            var controllersForAdmin = new string[]
            {
                DefaultInformationDbConstants.CONTROLLER_SALESHEEP,
                DefaultInformationDbConstants.CONTROLLER_SHEEP,
                DefaultInformationDbConstants.CONTROLLER_VACCINE,
                DefaultInformationDbConstants.CONTROLLER_VACCINESHEEP,
                DefaultInformationDbConstants.CONTROLLER_VACCINESTOCK,
                DefaultInformationDbConstants.CONTROLLER_SHEEPHISTORICWEIGHT
            };

            var actionsForAdmin = new string[]
            {
                DefaultInformationDbConstants.ACTION_CREATE,
                DefaultInformationDbConstants.ACTION_READ,
                DefaultInformationDbConstants.ACTION_UPDATE,
                DefaultInformationDbConstants.ACTION_DELETE,
                DefaultInformationDbConstants.ACTION_DELETEALL,
                DefaultInformationDbConstants.ACTION_READWITHFILTERS,
                DefaultInformationDbConstants.ACTION_TOGGLEACTIVE,
                DefaultInformationDbConstants.ACTION_GETBYID };
            foreach (var c in controllersForAdmin)
            {
                foreach (var ac in actionsForAdmin)
                {
                    contPermisionRoleId++;
                    permisionRole.AddRange(
                        permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == c).First().Id) && (x.ActionId == actions.Where(d => d.Name == ac).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_ADMIN)).First().Id })
                        );
                }
                if (c.Equals(DefaultInformationDbConstants.CONTROLLER_SHEEP))
                {
                    contPermisionRoleId++;
                    permisionRole.AddRange(
                        permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == c).First().Id) && (x.ActionId == actions.Where(d => d.Name == DefaultInformationDbConstants.ACTION_GETSHEEPWITHFINALWEIGHT).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_ADMIN)).First().Id })
                        );
                }
            }
            //adicional para el admin
            contPermisionRoleId++;
            permisionRole.Add(
                permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == DefaultInformationDbConstants.CONTROLLER_USER).First().Id) && (x.ActionId == actions.Where(d => d.Name == DefaultInformationDbConstants.ACTION_CREATE).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_ADMIN)).First().Id }).First()
                );
            contPermisionRoleId++;
            permisionRole.Add(
                permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == DefaultInformationDbConstants.CONTROLLER_USER).First().Id) && (x.ActionId == actions.Where(d => d.Name == DefaultInformationDbConstants.ACTION_READ).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_ADMIN)).First().Id }).First()
                );
            contPermisionRoleId++;
            permisionRole.Add(
                permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == DefaultInformationDbConstants.CONTROLLER_USER).First().Id) && (x.ActionId == actions.Where(d => d.Name == DefaultInformationDbConstants.ACTION_UPDATE).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_ADMIN)).First().Id }).First()
                );
            contPermisionRoleId++;
            permisionRole.Add(
                permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == DefaultInformationDbConstants.CONTROLLER_USER).First().Id) && (x.ActionId == actions.Where(d => d.Name == DefaultInformationDbConstants.ACTION_READWITHFILTERS).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_ADMIN)).First().Id }).First()
                );
            contPermisionRoleId++;
            permisionRole.Add(
                permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == DefaultInformationDbConstants.CONTROLLER_USER).First().Id) && (x.ActionId == actions.Where(d => d.Name == DefaultInformationDbConstants.ACTION_TOGGLEACTIVE).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_ADMIN)).First().Id }).First()
                );
            contPermisionRoleId++;
            permisionRole.Add(
                permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == DefaultInformationDbConstants.CONTROLLER_USER).First().Id) && (x.ActionId == actions.Where(d => d.Name == DefaultInformationDbConstants.ACTION_GETBYID).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_ADMIN)).First().Id }).First()
                );
            contPermisionRoleId++;
            permisionRole.Add(
                permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == DefaultInformationDbConstants.CONTROLLER_USER).First().Id) && (x.ActionId == actions.Where(d => d.Name == DefaultInformationDbConstants.ACTION_UPDATEPROFILE).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_ADMIN)).First().Id }).First()
                );

            //para el user
            var controllersForUser = new string[]
            {
                DefaultInformationDbConstants.CONTROLLER_SALESHEEP,
                DefaultInformationDbConstants.CONTROLLER_SHEEP,
                DefaultInformationDbConstants.CONTROLLER_VACCINE,
               DefaultInformationDbConstants. CONTROLLER_VACCINESHEEP,
               DefaultInformationDbConstants. CONTROLLER_VACCINESTOCK,
                DefaultInformationDbConstants.CONTROLLER_SHEEPHISTORICWEIGHT
            };
            var actionsForUser = new string[]
            {
                DefaultInformationDbConstants.ACTION_CREATE,
                DefaultInformationDbConstants.ACTION_READ,
                DefaultInformationDbConstants.ACTION_UPDATE,
               DefaultInformationDbConstants. ACTION_READWITHFILTERS,
                DefaultInformationDbConstants.ACTION_TOGGLEACTIVE,
               DefaultInformationDbConstants. ACTION_GETBYID
            };
            foreach (var c in controllersForUser)
            {
                foreach (var ac in actionsForUser)
                {
                    contPermisionRoleId++;
                    permisionRole.AddRange(
                        permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == c).First().Id) && (x.ActionId == actions.Where(d => d.Name == ac).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_USER)).First().Id })
                        );
                }
                if (c.Equals(DefaultInformationDbConstants.CONTROLLER_SHEEP))
                {
                    contPermisionRoleId++;
                    permisionRole.AddRange(
                        permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == c).First().Id) && (x.ActionId == actions.Where(d => d.Name == DefaultInformationDbConstants.ACTION_GETSHEEPWITHFINALWEIGHT).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_USER)).First().Id })
                        );
                }
            }

            //Adicional para el user
            contPermisionRoleId++;
            permisionRole.Add(
                permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == DefaultInformationDbConstants.CONTROLLER_USER).First().Id) && (x.ActionId == actions.Where(d => d.Name == DefaultInformationDbConstants.ACTION_UPDATEPROFILE).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_USER)).First().Id }).First()
                );

            //para el invited
            var controllersForInvited = new string[]
            {
                DefaultInformationDbConstants.CONTROLLER_SALESHEEP,
                DefaultInformationDbConstants.CONTROLLER_SHEEP,
                DefaultInformationDbConstants.CONTROLLER_VACCINE,
                DefaultInformationDbConstants.CONTROLLER_VACCINESHEEP,
                DefaultInformationDbConstants.CONTROLLER_VACCINESTOCK,
                DefaultInformationDbConstants.CONTROLLER_SHEEPHISTORICWEIGHT
            };

            var actionsForInvited = new string[]
            {
                DefaultInformationDbConstants.ACTION_READ,
                DefaultInformationDbConstants.ACTION_READWITHFILTERS,
                DefaultInformationDbConstants.ACTION_GETBYID
            };

            foreach (var c in controllersForInvited)
            {
                foreach (var ac in actionsForInvited)
                {
                    contPermisionRoleId++;
                    permisionRole.AddRange(
                        permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == c).First().Id) && (x.ActionId == actions.Where(d => d.Name == ac).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_INVITED)).First().Id })
                        );
                }
                if (c.Equals(DefaultInformationDbConstants.CONTROLLER_SHEEP))
                {
                    contPermisionRoleId++;
                    permisionRole.AddRange(
                        permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == c).First().Id) && (x.ActionId == actions.Where(d => d.Name == DefaultInformationDbConstants.ACTION_GETSHEEPWITHFINALWEIGHT).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_INVITED)).First().Id })
                        );
                }
            }

            //Adicional para el invited
            contPermisionRoleId++;
            permisionRole.Add(
                permissions.Where(x => (x.ControllerId == controllers.Where(y => y.Name == DefaultInformationDbConstants.CONTROLLER_USER).First().Id) && (x.ActionId == actions.Where(d => d.Name == DefaultInformationDbConstants.ACTION_UPDATEPROFILE).First().Id)).Select(a => new PermissionRole { Active = true, Id = contPermisionRoleId, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, PermissionId = a.Id, RoleId = roles.Where(r => r.Name.Equals(DefaultInformationDbConstants.ROLE_INVITED)).First().Id }).First()
                );

            modelBuilder.Entity<PermissionRole>().HasData(permisionRole);

            string defaultPassword = "12345";
            string passwordHash = Utilities.CalcularHash(defaultPassword);

            //usuarios base

            modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = DefaultInformationDbConstants.USER_SUPERADMIN_NAME, LastName = DefaultInformationDbConstants.USER_SUPERADMIN_NAME, Email = DefaultInformationDbConstants.USER_SUPERADMIN_EMAIL, Password = passwordHash, PhoneNumber = DefaultInformationDbConstants.USER_SUPERADMIN_PHONE, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now });

            modelBuilder.Entity<User>().HasData(new User { Id = 2, Name = DefaultInformationDbConstants.USER_ADMIN_NAME, LastName = DefaultInformationDbConstants.USER_ADMIN_NAME, Email = DefaultInformationDbConstants.USER_ADMIN_EMAIL, Password = passwordHash, PhoneNumber = DefaultInformationDbConstants.USER_ADMIN_PHONE, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now });

            modelBuilder.Entity<User>().HasData(new User { Id = 3, Name = DefaultInformationDbConstants.USER_USER_NAME, LastName = DefaultInformationDbConstants.USER_USER_LASTNAME, Email = DefaultInformationDbConstants.USER_USER_EMAIL, Password = passwordHash, PhoneNumber = DefaultInformationDbConstants.USER_USER_PHONE, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now });

            modelBuilder.Entity<User>().HasData(new User { Id = 4, Name = DefaultInformationDbConstants.USER_INVITED_NAME, LastName = DefaultInformationDbConstants.USER_INVITED_NAME, Email = DefaultInformationDbConstants.USER_INVITED_EMAIL, Password = passwordHash, PhoneNumber = DefaultInformationDbConstants.USER_INVITED_PHONE, Active = true, CreationDate = DateTime.Now, ModificationDate = DateTime.Now });

            //asignar roles a los usuarios base
            List<RoleUser> roleUsers = new List<RoleUser>();

            roleUsers.Add(new RoleUser { Active = true, Id = 1, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, UserId = 1, RoleId = roles.Where(x => x.Name.Equals(DefaultInformationDbConstants.ROLE_SUPERADMIN)).First().Id });
            roleUsers.Add(new RoleUser { Active = true, Id = 2, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, UserId = 2, RoleId = roles.Where(x => x.Name.Equals(DefaultInformationDbConstants.ROLE_ADMIN)).First().Id });
            roleUsers.Add(new RoleUser { Active = true, Id = 3, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, UserId = 3, RoleId = roles.Where(x => x.Name.Equals(DefaultInformationDbConstants.ROLE_USER)).First().Id });
            roleUsers.Add(new RoleUser { Active = true, Id = 4, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, UserId = 4, RoleId = roles.Where(x => x.Name.Equals(DefaultInformationDbConstants.ROLE_INVITED)).First().Id });

            modelBuilder.Entity<RoleUser>().HasData(roleUsers);

            base.OnModelCreating(modelBuilder);
        }
    }
}
