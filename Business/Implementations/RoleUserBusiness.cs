using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Implementations;
using Entities;
using Entities.DTOs;
using Shared;

namespace Business.Implementations
{
    public class RoleUserBusiness : IRoleUserBusiness
    {
        IRoleUserRepository _Repository;
        public RoleUserBusiness(IRoleUserRepository roleUserRepository)
        {
            _Repository = roleUserRepository;
        }

        public async Task<Response<IEnumerable<RoleUserResponse>>> Create(RoleUserRequestCreateRequest permissionRequest)
        {

            Response<IEnumerable<RoleUserResponse>> response = new Response<IEnumerable<RoleUserResponse>>();

            IEnumerable<RoleUser> userRoles = from idsPer in permissionRequest.RoleIds
                                              select new RoleUser
                                              {
                                                  Active = true,
                                                  CreationDate = DateTime.Now,
                                                  ModificationDate = DateTime.Now,
                                                  RoleId = idsPer,
                                                  UserId = permissionRequest.UserId,
                                              };
            //Borrar todos los Roles del usuario

           await _Repository.DeleteAllRolesByUserId(permissionRequest.UserId);

           await _Repository.CreateRange(userRoles);

            var newP = await _Repository.ReadIncludesByUserId(permissionRequest.UserId);
            response.Message = MessageConstants.CreateSuccesMessage;
            response.Data = Mapper.Map<IEnumerable<RoleUserResponse>>(newP);
            return response;

        }

        public async Task<IEnumerable<RoleUserResponse>> Read()
        {
            var respuesta = await _Repository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<RoleUserResponse>>(respuesta);

            return mapeo.ToList();
        }
        public async Task<Response<RoleUserResponse>> Update(int id, RoleUserRequest request)
        {
            Response<RoleUserResponse> response = new Response<RoleUserResponse>();

            RoleUser vaccine = await _Repository.GetById(id);

            vaccine.ModificationDate = DateTime.Now;
            vaccine.RoleId = request.RoleId;
            vaccine.UserId = request.UserId;

           await _Repository.Update(vaccine);

            vaccine =await _Repository.GetIncludesById(vaccine.Id);
            response.Data = Mapper.Map<RoleUserResponse>(vaccine);
            response.Message = MessageConstants.UpdateSuccesMessage;

            return response;
        }
        public async Task<Response<bool>> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            RoleUser sh =await _Repository.GetById(id);
            await _Repository.Delete(id);
            response.Message = MessageConstants.DeleteSuccesMessage;
            return response;
        }
        public async Task<Response<bool>> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data =await _Repository.GetById(id);
            data.Active = !data.Active;
           await _Repository.Update(data);
            response.Data = data.Active;
            response.Message = data.Active ? MessageConstants.ActiveSuccesMessage : MessageConstants.InactiveSuccesMessage;
            return response;
        }
    }
}
