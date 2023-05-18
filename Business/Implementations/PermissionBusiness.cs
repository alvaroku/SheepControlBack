using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;

namespace Business.Implementations
{
    public class PermissionBusiness : IPermissionBusiness
    {
        PermissionRepository _Repository;
        public PermissionBusiness(SheepControlDbContext context) {
            _Repository = new PermissionRepository(context);
        }

        public Response<PermissionResponse> Create(PermissionRequest permissionRequest)
        {
            Response<PermissionResponse> response = new Response<PermissionResponse>();


            Permission newP = Mapper.Map<Permission>(permissionRequest);

            newP.CreationDate = DateTime.Now;
            newP.ModificationDate = newP.CreationDate;
            newP.Clave = "test";
            _Repository.Create(newP);

            newP = _Repository.GetIncludesById(newP.Id);
            response.Data = Mapper.Map<PermissionResponse>(newP);
            return response;
        }

        public IEnumerable<PermissionResponse> Read()
        {
            var respuesta = _Repository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<PermissionResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<PermissionResponse> Update(int id, PermissionRequest request)
        {
            Response<PermissionResponse> response = new Response<PermissionResponse>();

            Permission vaccine = _Repository.GetById(id);

            vaccine.ModificationDate = DateTime.Now;
            vaccine.Clave = "clave-nueva";
            vaccine.Description = request.Description;
            vaccine.ControllerId = request.ControllerId;
            vaccine.ActionId = request.ActionId;

            _Repository.Update(vaccine);

            vaccine = _Repository.GetIncludesById(vaccine.Id);
            response.Data = Mapper.Map<PermissionResponse>(vaccine);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Permission sh = _Repository.GetById(id);
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
