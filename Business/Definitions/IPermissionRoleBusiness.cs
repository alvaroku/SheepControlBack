using Entities.DTOs;

namespace Business.Definitions
{
    public interface IPermissionRoleBusiness
    {
        public Response<PermissionRoleResponse> Create(PermissionRoleRequest request);
        public IEnumerable<PermissionRoleResponse> Read();
        public Response<PermissionRoleResponse> Update(int id, PermissionRoleRequest request);
        public Response<bool> Delete(int id);
    }
}
