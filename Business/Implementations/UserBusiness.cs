
using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;

namespace Business.Implementations
{
    public class UserBusiness : IUserBusiness
    {
        UserRepository _Repository { get; set; }
        public UserBusiness(SheepControlDbContext context) {

            _Repository = new UserRepository(context);

        }
        public Response<UserResponse> Create(UserRequest userRequest)
        {
            Response<UserResponse> response = new Response<UserResponse>();

            try
            {
                User newUser = Mapper.Map<User>(userRequest);
                newUser.CreationDate = DateTime.Now;
                newUser.ModificationDate = newUser.CreationDate;
                _Repository.Create(newUser);

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
            
            var respuesta = _Repository.Read();

            var mapeo = Mapper.Map<IEnumerable<UserResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<UserResponse> Update(int id, UserRequest request)
        {
            Response<UserResponse> response = new Response<UserResponse>();

            User u = _Repository.GetById(id);

            u.ModificationDate = DateTime.Now;
            u.Name = request.Name;
            u.BirthDate = request.BirthDate;
            u.LastName = request.LastName;
            u.PhoneNumber = request.PhoneNumber;
            u.Password = request.Password;
            u.Email = request.Email;

            _Repository.Update(u);

            response.Data = Mapper.Map<UserResponse>(u);

            return response;
        }
        public Response<bool> Delete(int id)
        {
             
            Response<bool> response = new Response<bool>();
            User u = _Repository.GetById(id);
            _Repository.Delete(u);
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
