using Entities.DTOs;

namespace Business.Definitions
{
    public interface IPermissionRoleBusiness
    {
        public Response<IEnumerable<PermissionRoleResponse>> Create(PermissionRoleCreateRequest request);
        public IEnumerable<PermissionRoleResponse> Read();
        public Response<PermissionRoleResponse> Update(int id, PermissionRoleRequest request);
        public Response<bool> Delete(int id);
        public Response<bool> ToggleActive(int id);
    }
}
