using Entities.DTOs;

namespace Business.Definitions
{
    public interface IPermissionBusiness
    {
        Task<Response<IEnumerable<PermissionResponse>>> Create(PermissionCreateRequest permissionRequest);
        Task<IEnumerable<PermissionResponse>> Read();
        Task<Response<PermissionResponse>> Update(int id, PermissionRequest request);
        Task<Response<bool>> Delete(int id);
        Task<Response<bool>> ToggleActive(int id);
    }
}
