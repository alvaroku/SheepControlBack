
using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;
using Microsoft.Extensions.Configuration;

namespace Business.Implementations
{
    public class UserBusiness : IUserBusiness
    {
        UserRepository _UserRepository { get; set; }
        public UserBusiness(SheepControlDbContext context) {

            _UserRepository = new UserRepository(context);

        }
        public Response<UserResponse> Create(UserRequest userRequest)
        {
            Response<UserResponse> response = new Response<UserResponse>();

            try
            {
                User newUser = Mapper.Map<User>(userRequest);
                newUser.CreationDate = DateTime.Now;
                newUser.ModificationDate = newUser.CreationDate;
                _UserRepository.Create(newUser);

                response.Data = Mapper.Map<UserResponse>(newUser);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                response.StatusCode = (int)EnumStatusCode.InternalServer;
            }

            return response;
            
        }
        public IEnumerable<UserResponse> Read() {
            
            var respuesta = _UserRepository.Read();

            var mapeo = Mapper.Map<IEnumerable<UserResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<UserResponse> Update(int id, UserRequest request)
        {
            Response<UserResponse> response = new Response<UserResponse>();

            User u = _UserRepository.GetById(id);

            u.ModificationDate = DateTime.Now;
            u.Name = request.Name;
            u.BirthDate = request.BirthDate;
            u.LastName = request.LastName;
            u.PhoneNumber = request.PhoneNumber;
            u.Password = request.Password;
            u.Email = request.Email;

            _UserRepository.Update(u);

            response.Data = Mapper.Map<UserResponse>(u);

            return response;
        }
        public Response<bool> Delete(int id)
        {
             
            Response<bool> response = new Response<bool>();
            User u = _UserRepository.GetById(id);
            _UserRepository.Delete(u);
            return response;
        }
    }
}
