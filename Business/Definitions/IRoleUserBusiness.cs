using Entities.DTOs;

namespace Business.Definitions
{
    public interface IRoleUserBusiness
    {
        public Response<IEnumerable<RoleUserResponse>> Create(RoleUserRequestCreateRequest request);
        public IEnumerable<RoleUserResponse> Read();
        public Response<RoleUserResponse> Update(int id, RoleUserRequest request);
        public Response<bool> Delete(int id);
        public Response<bool> ToggleActive(int id);
    }
}
