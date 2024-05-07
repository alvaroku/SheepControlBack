using Entities;
using Entities.DTOs;
using System.Security.Claims;

namespace Business.Definitions
{
    public interface IAuthenticationBusiness
    {
        Task<Response<LoginResponse>> Auth(LoginRequest userRequest);
        Task<User> ValidarToken(ClaimsIdentity identity);
        Task<Response<bool>> CheckPermissionControllerActionForUser(ClaimsIdentity claims, string control, string action);
        public Response<EmailReponse> GetEmailFromToken(EmailRequest request);
        Task<Response<ProfileResponse>>  GetProfileInfoByToken(ClaimsIdentity claims);
    }
}
