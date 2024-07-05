using AutoMapper;
using Business.Definitions;
using DataAccess.Repositories.Definitions;
using Entities;
using Entities.DTOs;

namespace Business.Implementations
{
    public class PermissionRoleBusiness : IPermissionRoleBusiness
    {
        IPermissionRoleRepository _Repository;
        public PermissionRoleBusiness(IPermissionRoleRepository permissionRoleRepository)
        {
            _Repository = permissionRoleRepository;
        }

        public async Task<Response<IEnumerable<PermissionRoleResponse>>> Create(PermissionRoleCreateRequest permissionRequest)
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

            await _Repository.DeleteAllPermissionsByRolId(permissionRequest.RoleId);

            await _Repository.CreateRange(permisionRoles);

            var newP = await _Repository.ReadIncludesByRolId(permissionRequest.RoleId);
            response.Data = Mapper.Map<IEnumerable<PermissionRoleResponse>>(newP);
            return response;
        }

        public async Task<IEnumerable<PermissionRoleResponse>> Read()
        {
            var respuesta = await _Repository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<PermissionRoleResponse>>(respuesta);

            return mapeo.ToList();
        }
        public async Task<Response<PermissionRoleResponse>> Update(int id, PermissionRoleRequest request)
        {
            Response<PermissionRoleResponse> response = new Response<PermissionRoleResponse>();

            PermissionRole vaccine = await _Repository.GetById(id);

            vaccine.ModificationDate = DateTime.Now;
            vaccine.RoleId = request.RoleId;
            vaccine.PermissionId = request.PermissionId;

            await _Repository.Update(vaccine);

            vaccine = await _Repository.GetIncludesById(vaccine.Id);
            response.Data = Mapper.Map<PermissionRoleResponse>(vaccine);

            return response;
        }
        public async Task<Response<bool>> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            await _Repository.Delete(id);
            return response;
        }
        public async Task<Response<bool>> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = await _Repository.GetById(id);
            data.Active = !data.Active;
            await _Repository.Update(data);
            response.Data = data.Active;
            return response;
        }
    }
}
