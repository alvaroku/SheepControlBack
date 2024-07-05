using Entities.DTOs;

namespace Business.Definitions
{
    public interface IUserBusiness
    {
        Task<Response<UserResponse>> Create(UserRequest userRequest);
        Task<IEnumerable<UserResponse>> Read();
        Task<Response<UserResponse>> Update(int id, UserRequest request);
        Task<Response<ProfileResponse>> Update(int id, ProfileRequest request);
        Task<Response<bool>> ChangePassword(int id, ChangePasswordRequest request);
        Task<Response<bool>> Delete(int id);
        Task<Response<bool>> ToggleActive(int id);
        Task<Response<string>> RecoveryPassword(string email);
        Task<FileStream> GetImage(string imageName);
    }
}
