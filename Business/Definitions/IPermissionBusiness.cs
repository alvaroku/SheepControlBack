using Entities.DTOs;

namespace Business.Definitions
{
    public interface IPermissionBusiness
    {
        public Response<PermissionResponse> Create(PermissionRequest permissionRequest);
        public IEnumerable<PermissionResponse> Read();
        public Response<PermissionResponse> Update(int id, PermissionRequest request);
        public Response<bool> Delete(int id);
    }
}
