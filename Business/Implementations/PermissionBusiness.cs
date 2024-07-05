using AutoMapper;
using Business.Definitions;
using Business.Utils;
using DataAccess;
using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Implementations;
using Entities;
using Entities.DTOs;
using Shared;

namespace Business.Implementations
{
    public class PermissionBusiness : IPermissionBusiness
    {
        IPermissionRepository _Repository;
        IControllerRepository _ControllerRepository;
        IActionRepository _ActionRepository;
        public PermissionBusiness(IPermissionRepository permissionRepository, IControllerRepository controllerRepository, IActionRepository actionRepository)
        {
            _Repository = permissionRepository;
            _ControllerRepository = controllerRepository;
            _ActionRepository = actionRepository;
        }

        public async Task<Response<IEnumerable<PermissionResponse>>> Create(PermissionCreateRequest permissionRequest)
        {
            Response<IEnumerable<PermissionResponse>> response = new Response<IEnumerable<PermissionResponse>>();

            var controllers = await _ControllerRepository.GetAll();
            var actions = await _ActionRepository.GetAll();
            IEnumerable<Permission> permisionRoles = from idsPer in permissionRequest.ActionIds
                                                     join c in controllers on permissionRequest.ControllerId equals c.Id
                                                     join a in actions on idsPer equals a.Id
                                                     select new Permission
                                                     {
                                                         ActionId = idsPer,
                                                         Active = true,
                                                         Clave = Utilities.GenerateKeyForPermission(c.Name, a.Name),
                                                         ControllerId = permissionRequest.ControllerId,
                                                         Description = Utilities.GenerateDescriptionForPermission(c.Name, a.Name),
                                                         ModificationDate = DateTime.Now,
                                                         CreationDate = DateTime.Now,
                                                     };
            //Borrar todas las acciones del controlador

            await _Repository.DeleteAllActionsByControllerId(permissionRequest.ControllerId);

            await _Repository.CreateRange(permisionRoles);

            var newP = await _Repository.ReadIncludesByControllerId(permissionRequest.ControllerId);
            response.Message = MessageConstants.CreateSuccesMessage;
            response.Data = Mapper.Map<IEnumerable<PermissionResponse>>(newP);
            return response;
        }

        public async Task<IEnumerable<PermissionResponse>> Read()
        {
            var respuesta = await _Repository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<PermissionResponse>>(respuesta);

            return mapeo.ToList();
        }
        public async Task<Response<PermissionResponse>> Update(int id, PermissionRequest request)
        {
            Response<PermissionResponse> response = new Response<PermissionResponse>();

            Permission vaccine =await _Repository.GetIncludesById(id);

            vaccine.ModificationDate = DateTime.Now;
            vaccine.Clave =Utilities.GenerateKeyForPermission(vaccine.Controller.Name,vaccine.Action.Name);
            vaccine.Description =Utilities.GenerateDescriptionForPermission(vaccine.Controller.Name, vaccine.Action.Name);
            vaccine.ControllerId = request.ControllerId;
            vaccine.ActionId = request.ActionId;

            await _Repository.Update(vaccine);

            vaccine =await _Repository.GetIncludesById(vaccine.Id);
            response.Data = Mapper.Map<PermissionResponse>(vaccine);
            response.Message = MessageConstants.UpdateSuccesMessage;
            return response;
        }
        public async Task<Response<bool>> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            await _Repository.Delete(id);
            return response;
        }
        public async Task<Response<bool>> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = await _Repository.GetById(id);
            data.Active = !data.Active;
            await _Repository.Update(data);
            response.Data = data.Active;
            response.Message = data.Active ? MessageConstants.ActiveSuccesMessage : MessageConstants.InactiveSuccesMessage;
            return response;
        }
    }
}
