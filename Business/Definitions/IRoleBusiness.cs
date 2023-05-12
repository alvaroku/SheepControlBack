using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Definitions
{
    public interface IRoleBusiness
    {
        public Response<RoleResponse> Create(RoleRequest request);
        public IEnumerable<RoleResponse> Read();
        public Response<RoleResponse> Update(int id, RoleRequest request);
        public Response<bool> Delete(int id);
    }
}
