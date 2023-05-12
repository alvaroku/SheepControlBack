using DataAccess.Implementations;
using Entities.DTOs;
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
        public Response<UserResponse> Update(int id, UserRequest request);
        public Response<bool> Delete(int id);
    }
}
