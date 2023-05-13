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
        RoleUserRepository _RoleUserRepository;
        public RoleUserBusiness(SheepControlDbContext context) {
            _RoleUserRepository = new RoleUserRepository(context);
        }

        public Response<RoleUserResponse> Create(RoleUserRequest permissionRequest)
        {
            Response<RoleUserResponse> response = new Response<RoleUserResponse>();


            RoleUser newP = Mapper.Map<RoleUser>(permissionRequest);

            newP.CreationDate = DateTime.Now;
            newP.ModificationDate = newP.CreationDate;
            newP.Active = true;
            _RoleUserRepository.Create(newP);

            newP = _RoleUserRepository.GetIncludesById(newP.Id);
            response.Data = Mapper.Map<RoleUserResponse>(newP);
            return response;
        }

        public IEnumerable<RoleUserResponse> Read()
        {
            var respuesta = _RoleUserRepository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<RoleUserResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<RoleUserResponse> Update(int id, RoleUserRequest request)
        {
            Response<RoleUserResponse> response = new Response<RoleUserResponse>();

            RoleUser vaccine = _RoleUserRepository.GetById(id);

            vaccine.ModificationDate = DateTime.Now;
            vaccine.RoleId = request.RoleId;
            vaccine.UserId = request.UserId;

            _RoleUserRepository.Update(vaccine);

            vaccine = _RoleUserRepository.GetIncludesById(vaccine.Id);
            response.Data = Mapper.Map<RoleUserResponse>(vaccine);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            RoleUser sh = _RoleUserRepository.GetById(id);
            _RoleUserRepository.Delete(sh);
            return response;
        }
    }
}
