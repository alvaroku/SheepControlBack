using Entities.DTOs;
using System.Security.Claims;

namespace Business.Definitions
{
    public interface IAuthenticationBusiness
    {
        public Response<LoginResponse> Auth(LoginRequest userRequest);
        public UserResponse ValidarToken(ClaimsIdentity identity);
        public Response<bool> CheckPermissionControllerActionForUser(ClaimsIdentity claims, string control, string action);
        public Response<EmailReponse> GetEmailFromToken(EmailRequest request);
    }
}
