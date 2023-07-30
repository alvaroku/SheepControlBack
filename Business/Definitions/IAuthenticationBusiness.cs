using Entities;
using Entities.DTOs;
using System.Security.Claims;

namespace Business.Definitions
{
    public interface IAuthenticationBusiness
    {
        public Response<LoginResponse> Auth(LoginRequest userRequest);
        public User ValidarToken(ClaimsIdentity identity);
        public Response<bool> CheckPermissionControllerActionForUser(ClaimsIdentity claims, string control, string action);
        public Response<EmailReponse> GetEmailFromToken(EmailRequest request);
        public Response<ProfileResponse> GetProfileInfoByToken(ClaimsIdentity claims);
    }
}
