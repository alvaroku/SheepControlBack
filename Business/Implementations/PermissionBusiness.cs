using AutoMapper;
using Business.Definitions;
using Business.Utils;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;

namespace Business.Implementations
{
    public class PermissionBusiness : IPermissionBusiness
    {
        PermissionRepository _Repository;
        public PermissionBusiness(SheepControlDbContext context) {
            _Repository = new PermissionRepository(context);
        }

        public Response<IEnumerable<PermissionResponse>> Create(PermissionCreateRequest permissionRequest)
        {
            Response<IEnumerable<PermissionResponse>> response = new Response<IEnumerable<PermissionResponse>>();

            IEnumerable<Permission> permisionRoles = from idsPer in permissionRequest.ActionIds 
                                                     join c in _Repository._context.Controllers on permissionRequest.ControllerId equals c.Id
                                                     join a in _Repository._context.Actions on idsPer equals a.Id
                                                         select new Permission
                                                         {
                                                             ActionId = idsPer,
                                                             Active = true,
                                                             Clave = Utils.Utils.GenerateKeyForPermission(c.Name, a.Name),
                                                             ControllerId = permissionRequest.ControllerId,
                                                             Description = Utils.Utils.GenerateDescriptionForPermission(c.Name,a.Name), 
                                                             ModificationDate = DateTime.Now,
                                                             CreationDate = DateTime.Now,
                                                         };
            //Borrar todas las acciones del controlador

            _Repository.DeleteAllActionsByControllerId(permissionRequest.ControllerId);

            _Repository.CreateRange(permisionRoles);

            var newP = _Repository.ReadIncludesByControllerId(permissionRequest.ControllerId);
            response.Message = Constants.CreateSuccesMessage;
            response.Data = Mapper.Map<IEnumerable<PermissionResponse>>(newP);
            return response;
        }

        public IEnumerable<PermissionResponse> Read()
        {
            var respuesta = _Repository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<PermissionResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<PermissionResponse> Update(int id, PermissionRequest request)
        {
            Response<PermissionResponse> response = new Response<PermissionResponse>();

            Permission vaccine = _Repository.GetIncludesById(id);

            vaccine.ModificationDate = DateTime.Now;
            vaccine.Clave = Utils.Utils.GenerateKeyForPermission(vaccine.Controller.Name,vaccine.Action.Name);
            vaccine.Description = Utils.Utils.GenerateDescriptionForPermission(vaccine.Controller.Name, vaccine.Action.Name);
            vaccine.ControllerId = request.ControllerId;
            vaccine.ActionId = request.ActionId;

            _Repository.Update(vaccine);

            vaccine = _Repository.GetIncludesById(vaccine.Id);
            response.Data = Mapper.Map<PermissionResponse>(vaccine);
            response.Message = Constants.UpdateSuccesMessage;
            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Permission sh = _Repository.GetById(id);
            _Repository.Delete(sh);
            return response;
        }
        public Response<bool> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = _Repository.GetById(id);
            data.Active = !data.Active;
            _Repository.Update(data);
            response.Data = data.Active;
            response.Message = data.Active ? Constants.ActiveSuccesMessage : Constants.InactiveSuccesMessage;
            return response;
        }
    }
}
