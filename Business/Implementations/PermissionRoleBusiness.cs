using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;
using System.Security.Cryptography;

namespace Business.Implementations
{
    public class PermissionRoleBusiness : IPermissionRoleBusiness
    {
        PermissionRoleRepository _Repository;
        public PermissionRoleBusiness(SheepControlDbContext context) {
            _Repository = new PermissionRoleRepository(context);
        }

        public Response<IEnumerable<PermissionRoleResponse>> Create(PermissionRoleCreateRequest permissionRequest)
        {
            Response<IEnumerable<PermissionRoleResponse>> response = new Response<IEnumerable<PermissionRoleResponse>>();

            IEnumerable<PermissionRole> permisionRoles = from idsPer in permissionRequest.PermissionIds
                                                select new PermissionRole
                                                {
                                                    PermissionId = idsPer,
                                                    Active = true,
                                                    RoleId = permissionRequest.RoleId,
                                                    ModificationDate = DateTime.Now,
                                                    CreationDate = DateTime.Now,
                                                };
            //Borrar todos los permisos del Rol

            _Repository.DeleteAllPermissionsByRolId(permissionRequest.RoleId);

            _Repository.CreateRange(permisionRoles);

            var newP = _Repository.ReadIncludesByRolId(permissionRequest.RoleId);
            response.Data = Mapper.Map<IEnumerable<PermissionRoleResponse>>(newP);
            return response;
        }

        public IEnumerable<PermissionRoleResponse> Read()
        {
            var respuesta = _Repository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<PermissionRoleResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<PermissionRoleResponse> Update(int id, PermissionRoleRequest request)
        {
            Response<PermissionRoleResponse> response = new Response<PermissionRoleResponse>();

            PermissionRole vaccine = _Repository.GetById(id);

            vaccine.ModificationDate = DateTime.Now;
            vaccine.RoleId = request.RoleId;
            vaccine.PermissionId = request.PermissionId;

            _Repository.Update(vaccine);

            vaccine = _Repository.GetIncludesById(vaccine.Id);
            response.Data = Mapper.Map<PermissionRoleResponse>(vaccine);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            PermissionRole sh = _Repository.GetById(id);
            _Repository.Delete(sh);
            return response;
        }
        public Response<bool> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = _Repository.GetById(id);
            data.Active = !data.Active;
            _Repository.Update(data);
            response.Data = data.Active;
            return response;
        }
    }
}
