using AutoMapper;
using Business.Definitions;
using Business.Utils;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;

namespace Business.Implementations
{
    public class RoleBusiness : IRoleBusiness
    {
        RoleRepository _Repository;
        public RoleBusiness(SheepControlDbContext context) {
            _Repository = new RoleRepository(context);
        }

        public Response<RoleResponse> Create(RoleRequest Request)
        {
            Response<RoleResponse> response = new Response<RoleResponse>();


            Role newP = Mapper.Map<Role>(Request);

            newP.CreationDate = DateTime.Now;
            newP.ModificationDate = newP.CreationDate;
            newP.Active = true;
            _Repository.Create(newP);
            response.Data = Mapper.Map<RoleResponse>(newP);
            response.Message = Constants.CreateSuccesMessage;
            return response;
        }

        public IEnumerable<RoleResponse> Read()
        {
            var respuesta = _Repository.Read();

            var mapeo = Mapper.Map<IEnumerable<RoleResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<RoleResponse> Update(int id, RoleRequest request)
        {
            Response<RoleResponse> response = new Response<RoleResponse>();

            Role vaccine = _Repository.GetById(id);

            vaccine.ModificationDate = DateTime.Now;
            vaccine.Name = request.Name;

            _Repository.Update(vaccine);

            response.Data = Mapper.Map<RoleResponse>(vaccine);
            response.Message = Constants.UpdateSuccesMessage;

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Role sh = _Repository.GetById(id);
            _Repository.Delete(sh);
            response.Message = Constants.DeleteSuccesMessage;
            return response;
        }
        public Response<bool> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = _Repository.GetById(id);
            data.Active = !data.Active;
            _Repository.Update(data);
            response.Data = data.Active;
            response.Message = data.Active ? Constants.ActiveSuccesMessage : Constants.InactiveSuccesMessage;
            return response;
        }
    }
}
