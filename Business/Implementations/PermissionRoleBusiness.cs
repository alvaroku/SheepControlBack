using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class PermissionRoleBusiness : IPermissionRoleBusiness
    {
        PermissionRoleRepository _PermissionRoleRepository;
        public PermissionRoleBusiness(SheepControlDbContext context) {
            _PermissionRoleRepository = new PermissionRoleRepository(context);
        }

        public Response<PermissionRoleResponse> Create(PermissionRoleRequest permissionRequest)
        {
            Response<PermissionRoleResponse> response = new Response<PermissionRoleResponse>();


            PermissionRole newP = Mapper.Map<PermissionRole>(permissionRequest);

            newP.CreationDate = DateTime.Now;
            newP.ModificationDate = newP.CreationDate;
            newP.Active = true;
            _PermissionRoleRepository.Create(newP);

            newP = _PermissionRoleRepository.GetIncludesById(newP.Id);
            response.Data = Mapper.Map<PermissionRoleResponse>(newP);
            return response;
        }

        public IEnumerable<PermissionRoleResponse> Read()
        {
            var respuesta = _PermissionRoleRepository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<PermissionRoleResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<PermissionRoleResponse> Update(int id, PermissionRoleRequest request)
        {
            Response<PermissionRoleResponse> response = new Response<PermissionRoleResponse>();

            PermissionRole vaccine = _PermissionRoleRepository.GetById(id);

            vaccine.ModificationDate = DateTime.Now;
            vaccine.RoleId = request.RoleId;
            vaccine.PermissionId = request.PermissionId;

            _PermissionRoleRepository.Update(vaccine);

            vaccine = _PermissionRoleRepository.GetIncludesById(vaccine.Id);
            response.Data = Mapper.Map<PermissionRoleResponse>(vaccine);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            PermissionRole sh = _PermissionRoleRepository.GetById(id);
            _PermissionRoleRepository.Delete(sh);
            return response;
        }
    }
}
