using DataAccess.Implementations;
using SheepControlApi.Dtos;
using SheepControlApi.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Business.Definitions
{
    public interface IUserBusiness
    {
        public Response<UserResponse> Create(UserRequest userRequest);
        public IEnumerable<UserResponse> Read();
        public Response<LoginResponse> Login(LoginRequest userRequest);
        public Response<UserResponse> ValidarToken(ClaimsIdentity identity);
    }
}
