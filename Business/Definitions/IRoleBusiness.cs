using Entities.DTOs;

namespace Business.Definitions
{
    public interface IRoleBusiness
    {
        Task< Response<RoleResponse>> Create(RoleRequest request);
        Task< IEnumerable<RoleResponse>> Read();
        Task< Response<RoleResponse>> Update(int id, RoleRequest request);
        Task< Response<bool>> Delete(int id);
        Task< Response<bool>> ToggleActive(int id);
    }
}
