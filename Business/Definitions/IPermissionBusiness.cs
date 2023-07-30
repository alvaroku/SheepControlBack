using Entities.DTOs;

namespace Business.Definitions
{
    public interface IPermissionBusiness
    {
        Response<IEnumerable<PermissionResponse>> Create(PermissionCreateRequest permissionRequest);
        public IEnumerable<PermissionResponse> Read();
        public Response<PermissionResponse> Update(int id, PermissionRequest request);
        public Response<bool> Delete(int id);
        public Response<bool> ToggleActive(int id);
    }
}
