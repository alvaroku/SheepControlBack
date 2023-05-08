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
    public class PermissionBusiness : IPermissionBusiness
    {
        PermissionRepository _PermissionRepository;
        public PermissionBusiness(SheepControlDbContext context) {
            _PermissionRepository = new PermissionRepository(context);
        }

        public Response<PermissionResponse> Create(PermissionRequest permissionRequest)
        {
            Response<PermissionResponse> response = new Response<PermissionResponse>();


            Permission newP = Mapper.Map<Permission>(permissionRequest);

            newP.CreationDate = DateTime.Now;
            newP.ModificationDate = newP.CreationDate;
            newP.Clave = "test";
            _PermissionRepository.Create(newP);

            newP = _PermissionRepository.GetIncludesById(newP.Id);
            response.Data = Mapper.Map<PermissionResponse>(newP);
            return response;
        }

        public IEnumerable<PermissionResponse> Read()
        {
            var respuesta = _PermissionRepository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<PermissionResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<PermissionResponse> Update(int id, PermissionRequest request)
        {
            Response<PermissionResponse> response = new Response<PermissionResponse>();

            Permission vaccine = _PermissionRepository.GetById(id);

            vaccine.ModificationDate = DateTime.Now;
            vaccine.Clave = "clave-nueva";
            vaccine.Description = request.Description;
            vaccine.ControllerId = request.ControllerId;
            vaccine.ActionId = request.ActionId;

            _PermissionRepository.Update(vaccine);

            vaccine = _PermissionRepository.GetIncludesById(vaccine.Id);
            response.Data = Mapper.Map<PermissionResponse>(vaccine);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Permission sh = _PermissionRepository.GetById(id);
            _PermissionRepository.Delete(sh);
            return response;
        }
    }
}
