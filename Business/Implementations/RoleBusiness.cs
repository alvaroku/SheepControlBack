using AutoMapper;
using Business.Definitions;
using DataAccess.Repositories.Definitions;
using Entities;
using Entities.DTOs;
using Shared;

namespace Business.Implementations
{
    public class RoleBusiness : IRoleBusiness
    {
        IRoleRepository _Repository;
        public RoleBusiness(IRoleRepository roleRepository)
        {
            _Repository = roleRepository;
        }

        public async Task<Response<RoleResponse>> Create(RoleRequest Request)
        {
            Response<RoleResponse> response = new Response<RoleResponse>();

            Role newP = Mapper.Map<Role>(Request);

            newP.CreationDate = DateTime.Now;
            newP.ModificationDate = newP.CreationDate;
            newP.Active = true;
            await _Repository.Add(newP);
            response.Data = Mapper.Map<RoleResponse>(newP);
            response.Message = MessageConstants.CreateSuccesMessage;
            return response;
        }

        public async Task<IEnumerable<RoleResponse>> Read()
        {
            var respuesta = await _Repository.GetAll();

            var mapeo = Mapper.Map<IEnumerable<RoleResponse>>(respuesta);

            return mapeo.ToList();
        }
        public async Task<Response<RoleResponse>> Update(int id, RoleRequest request)
        {
            Response<RoleResponse> response = new Response<RoleResponse>();

            Role vaccine = await _Repository.GetById(id);

            vaccine.ModificationDate = DateTime.Now;
            vaccine.Name = request.Name;

            await _Repository.Update(vaccine);

            response.Data = Mapper.Map<RoleResponse>(vaccine);
            response.Message = MessageConstants.UpdateSuccesMessage;

            return response;
        }
        public async Task<Response<bool>> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            await _Repository.Delete(id);
            response.Message = MessageConstants.DeleteSuccesMessage;
            return response;
        }
        public async Task<Response<bool>> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = await _Repository.GetById(id);
            data.Active = !data.Active;
            await _Repository.Update(data);
            response.Data = data.Active;
            response.Message = data.Active ? MessageConstants.ActiveSuccesMessage : MessageConstants.InactiveSuccesMessage;
            return response;
        }
    }
}
