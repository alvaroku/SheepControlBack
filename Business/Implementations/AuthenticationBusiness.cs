using AutoMapper;
using Business.Definitions;
using DataAccess.Implementations;
using Entities.DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Business.Implementations
{
    public class AuthenticationBusiness : IAuthenticationBusiness
    {
        UserRepository _UserRepository;
        PermissionUserRepository _PermissionUserRepository;
        public AuthenticationBusiness(SheepControlDbContext dbContext)
        {
            _UserRepository = new UserRepository(dbContext);
            _PermissionUserRepository = new PermissionUserRepository(dbContext);
        }
        public UserResponse ValidarToken(ClaimsIdentity identity)
        {
            UserResponse response = null;
            try
            {
                if (identity.Claims.Count() == 0)
                {
                    return response;
                }
                int id = int.Parse(identity.Claims.First(x => x.Type == "Id").Value);

                User user = _UserRepository.GetById(id);
                response = Mapper.Map<UserResponse>(user);
                
                return response;

            }
            catch (Exception ex)
            {
                return response;
            }


        }
        public Response<bool> CheckPermissionControllerActionForUser(ClaimsIdentity claims, string control, string action) {
            
            Response<bool> response = new Response<bool>();
            
            UserResponse userResponse = ValidarToken(claims);
            
            if (userResponse == null)
            {
                response.Success = false;
                response.Message = "Verificar token enviado";
                response.StatusCode = (int)EnumStatusCode.InternalServer;

                return response;
            }

            IEnumerable<PermissionUser> permissions = _PermissionUserRepository.GetPermissionByUserIncludes(userResponse.Id);
            if(permissions.Count() == 0)
            {
                response.Success = false;
                response.Message = "Sin permisos asignados";
                response.StatusCode = (int)EnumStatusCode.InternalServer;
                return response;
            }

            bool hasPermission = permissions.Where(p => p.Permission.Controller.Name.Equals(control) && p.Permission.Action.Name.Equals(action)).Any();
         
            if(!hasPermission)
            {
                response.Success = false;
                response.Message = "Sin permiso para realzar esta acción";
                response.StatusCode = (int)EnumStatusCode.Forbidden;
            }
            return response;
        }
    }
}
