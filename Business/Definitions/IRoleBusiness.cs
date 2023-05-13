using Entities.DTOs;

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
