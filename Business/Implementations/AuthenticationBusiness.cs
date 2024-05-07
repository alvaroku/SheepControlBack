using AutoMapper;
using Business.Definitions;
using DataAccess.Implementations;
using Entities.DTOs;
using Entities;
using System.Security.Claims;
using System.Text;
using DataAccess;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using System.Security.Principal;
using Azure.Core;
using DataAccess.Repositories.Implementations;

namespace Business.Implementations
{
    public class AuthenticationBusiness : IAuthenticationBusiness
    {
        UserRepository _UserRepository;
        PermissionRoleRepository _PermissionRolRepository;
        RoleUserRepository _RoleUserRepository;
        IConfiguration _configuration;
        public AuthenticationBusiness(IConfiguration configuration, SheepControlDbContext dbContext)
        {
            _UserRepository = new UserRepository(dbContext);
            _PermissionRolRepository = new PermissionRoleRepository(dbContext);
            _RoleUserRepository = new RoleUserRepository(dbContext);
            _configuration = configuration;
        }
        public async Task<Response<LoginResponse>> Auth(LoginRequest userRequest)
        {
            Response<LoginResponse> response = new Response<LoginResponse>();

            User u =await _UserRepository.Login(userRequest);

            if (u == null)
            {
                response.Message = "Usuario no encontrado";
                response.Success = false;
                response.StatusCode = (int)EnumStatusCode.InternalServer;
                return response;
            }
            var jwt = _configuration.GetSection("Jwt").Get<Jwt>();


            response.Data = Mapper.Map<LoginResponse>(u);

            var clamis = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,jwt.Subject),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),
                new Claim("Id",u.Id.ToString()),
                new Claim("Email",u.Email),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));

            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                jwt.Issuer,
                jwt.Audience,
                clamis,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: signIn
                );

            response.Data.Token = new JwtSecurityTokenHandler().WriteToken(token);

            return response;//minuto 44 ->https://www.youtube.com/watch?v=PR5XM-SNcm8
        }
        public Response<EmailReponse> GetEmailFromToken(EmailRequest request)
        {
            Response<EmailReponse> response = new Response<EmailReponse>();

            try
            {
                var handler = new JwtSecurityTokenHandler();
                var tokenS = handler.ReadToken(request.Token) as JwtSecurityToken;
                var email = tokenS.Claims.First(claim => claim.Type == "Email").Value;
                response.Data = new EmailReponse { Email = email };
            }
            catch (Exception ex) { }


            return response;
        }
        public async Task<Response<ProfileResponse>> GetProfileInfoByToken(ClaimsIdentity claims) 
        {
            Response<ProfileResponse> response = new Response<ProfileResponse>();

            User userResponse =await ValidarToken(claims);

            if (userResponse == null)
            {
                response.Success = false;
                response.Message = "Verificar token enviado";
                response.StatusCode = (int)EnumStatusCode.InternalServer;

                return response;
            }
            response.Data = Mapper.Map<ProfileResponse>(userResponse);
            return response;

        }
        public async Task<User> ValidarToken(ClaimsIdentity identity)
        {
            User response = null;
            try
            {
                if (identity.Claims.Count() == 0)
                {
                    return response;
                }
                int id = int.Parse(identity.Claims.First(x => x.Type == "Id").Value);

                response = await _UserRepository.GetById(id);
                
                return response;

            }
            catch (Exception ex)
            {
                return response;
            }


        }
        public async Task<Response<bool>> CheckPermissionControllerActionForUser(ClaimsIdentity claims, string control, string action) {
            
            Response<bool> response = new Response<bool>();
            
            User userResponse = await ValidarToken(claims);
            
            if (userResponse == null)
            {
                response.Success = false;
                response.Message = "Verificar token enviado";
                response.StatusCode = (int)EnumStatusCode.InternalServer;

                return response;
            }

            IEnumerable<RoleUser> roles = _RoleUserRepository.GetIncludesListById(userResponse.Id);
            
            if(roles.Count() == 0)
            {
                response.Success = false;
                response.Message = "Sin roles asignados";
                response.StatusCode = (int)EnumStatusCode.InternalServer;
                return response;
            }
            bool hasPermission = false;
            
            hasPermission = roles
                .SelectMany(role => _PermissionRolRepository.ReadIncludesListByRoleId(role.RoleId))
                .Where(pr => pr.Permission.Controller.Name.Equals(control) && pr.Permission.Action.Name.Equals(action))
                .Any();

            if (!hasPermission)
            {
                response.Success = false;
                response.Message = "Sin permiso para realzar esta acción";
                response.StatusCode = (int)EnumStatusCode.Forbidden;
            }
            return response;
        }
    }
}
