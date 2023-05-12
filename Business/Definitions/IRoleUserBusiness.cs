using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Definitions
{
    public interface IRoleUserBusiness
    {
        public Response<RoleUserResponse> Create(RoleUserRequest request);
        public IEnumerable<RoleUserResponse> Read();
        public Response<RoleUserResponse> Update(int id, RoleUserRequest request);
        public Response<bool> Delete(int id);
    }
}
