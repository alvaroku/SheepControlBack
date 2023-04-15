
using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;
using Microsoft.Extensions.Configuration;

using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
 
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class UserBusiness : IUserBusiness
    {
        IConfiguration _configuration;
        UserRepository _UserRepository { get; set; }
        public UserBusiness(IConfiguration configuration,SheepControlDbContext context) {

            _configuration = configuration;
            _UserRepository = new UserRepository(context);

        }
        public Response<UserResponse> Create(UserRequest userRequest)
        {
            Response<UserResponse> response = new Response<UserResponse>();

            try
            {
                User newUser = Mapper.Map<User>(userRequest);

                _UserRepository.Create(newUser);

                response.Data = Mapper.Map<UserResponse>(newUser);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                response.StatusCode = (int)EnumStatusCode.InternalServer;
            }

            return response;
            
        }
        public IEnumerable<UserResponse> Read() {
            
            var respuesta = _UserRepository.Read();

            var mapeo = Mapper.Map<IEnumerable<UserResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<bool> Delete(int id)
        {
             
            Response<bool> response = new Response<bool>();
            return response;
        }

        public Response<LoginResponse> Login(LoginRequest userRequest)
        {
            userRequest.Email = "alvaro@gmail.com";
            userRequest.Password = "222";

            Response<LoginResponse> response = new Response<LoginResponse>();

            User u = _UserRepository.Login(userRequest);
            
            if(u == null)
            {
                response.Message = "Usuario no encontrado";
                response.Success = false;
                response.StatusCode= (int)EnumStatusCode.InternalServer;
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

            var signIn = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                jwt.Issuer,
                jwt.Audience,
                clamis,
                expires:DateTime.Now.AddMinutes(60),
                signingCredentials:signIn
                );

            response.Data.Token = new JwtSecurityTokenHandler().WriteToken(token);

            return response;//minuto 44 ->https://www.youtube.com/watch?v=PR5XM-SNcm8
        }
        public Response<UserResponse> ValidarToken(ClaimsIdentity identity)
        {
            Response<UserResponse> response = new Response<UserResponse>();
            try
            {
                if (identity.Claims.Count() == 0)
                {
                    response.Success = false;
                    response.Message = "Verificar token";
                    response.StatusCode = (int)EnumStatusCode.InternalServer;
                    return response;
                }
                int id = int.Parse(identity.Claims.First(x => x.Type == "Id").Value);

                User user = _UserRepository.GetById(id);
                response.Success = true;
                response.StatusCode = (int)EnumStatusCode.Ok;
                response.Data = Mapper.Map<UserResponse>(user);
                return response;

            }
            catch (Exception ex)
            {

                response.Success = false;
                response.Message = ex.Message;
                response.StatusCode = (int)EnumStatusCode.InternalServer;
                return response;
            }
            

        }
    }
}
