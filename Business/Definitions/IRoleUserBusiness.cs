using Entities.DTOs;

namespace Business.Definitions
{
    public interface IRoleUserBusiness
    {
        public Response<RoleUserResponse> Create(RoleUserRequest request);
        public IEnumerable<RoleUserResponse> Read();
        public Response<RoleUserResponse> Update(int id, RoleUserRequest request);
        public Response<bool> Delete(int id);
        public Response<bool> ToggleActive(int id);
    }
}
