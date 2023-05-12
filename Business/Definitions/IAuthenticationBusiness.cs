﻿using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

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
