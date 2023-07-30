using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;

namespace Business.Implementations
{
    public class RoleUserBusiness : IRoleUserBusiness
    {
        RoleUserRepository _Repository;
        public RoleUserBusiness(SheepControlDbContext context) {
            _Repository = new RoleUserRepository(context);
        }

        public Response<IEnumerable<RoleUserResponse>> Create(RoleUserRequestCreateRequest permissionRequest)
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

            _Repository.DeleteAllRolesByUserId(permissionRequest.UserId);

            _Repository.CreateRange(userRoles);

            var newP = _Repository.ReadIncludesByUserId(permissionRequest.UserId);
            response.Data = Mapper.Map<IEnumerable<RoleUserResponse>>(newP);
            return response;

        }

        public IEnumerable<RoleUserResponse> Read()
        {
            var respuesta = _Repository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<RoleUserResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<RoleUserResponse> Update(int id, RoleUserRequest request)
        {
            Response<RoleUserResponse> response = new Response<RoleUserResponse>();

            RoleUser vaccine = _Repository.GetById(id);

            vaccine.ModificationDate = DateTime.Now;
            vaccine.RoleId = request.RoleId;
            vaccine.UserId = request.UserId;

            _Repository.Update(vaccine);

            vaccine = _Repository.GetIncludesById(vaccine.Id);
            response.Data = Mapper.Map<RoleUserResponse>(vaccine);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            RoleUser sh = _Repository.GetById(id);
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
