using Entities.DTOs;

namespace Business.Definitions
{
    public interface IRoleUserBusiness
    {
        Task<Response<IEnumerable<RoleUserResponse>>> Create(RoleUserRequestCreateRequest request);
        Task<IEnumerable<RoleUserResponse>> Read();
        Task<Response<RoleUserResponse>> Update(int id, RoleUserRequest request);
        Task<Response<bool>> Delete(int id);
        Task<Response<bool>> ToggleActive(int id);
    }
}
