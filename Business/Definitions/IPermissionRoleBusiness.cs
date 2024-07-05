using Entities.DTOs;

namespace Business.Definitions
{
    public interface IPermissionRoleBusiness
    {
        Task<Response<IEnumerable<PermissionRoleResponse>>> Create(PermissionRoleCreateRequest request);
        Task<IEnumerable<PermissionRoleResponse>> Read();
        Task<Response<PermissionRoleResponse>> Update(int id, PermissionRoleRequest request);
        Task<Response<bool>> Delete(int id);
        Task<Response<bool>> ToggleActive(int id);
    }
}
