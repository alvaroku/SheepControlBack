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
    public class ControllerBusiness:IControllerBusiness
    {
        IControllerRepository _Repository;
        public ControllerBusiness(IControllerRepository controllerRepository)
        {
            _Repository = controllerRepository;
        }

        public async Task<Response<ControllerResponse>> Create(ControllerRequest controllerRequest)
        {
            Response<ControllerResponse> response = new Response<ControllerResponse>();


            Controller newAction = Mapper.Map<Controller>(controllerRequest);

            await _Repository.Add(newAction);
            response.Message = MessageConstants.CreateSuccesMessage;
            response.Data = Mapper.Map<ControllerResponse>(newAction);
            return response;
        }

        public async Task<IEnumerable<ControllerResponse>> Read()
        {
            var respuesta = await _Repository.GetAll();

            var mapeo = Mapper.Map<IEnumerable<ControllerResponse>>(respuesta);

            return mapeo.ToList();
        }
        public async Task<Response<ControllerResponse>> Update(int id, ControllerRequest request)
        {
            Response<ControllerResponse> response = new Response<ControllerResponse>();

            Controller a =await _Repository.GetById(id);

            a.ModificationDate = DateTime.Now;
            a.Name = request.Name;

            await _Repository.Update(a);
            response.Message = MessageConstants.UpdateSuccesMessage;
            response.Data = Mapper.Map<ControllerResponse>(a);

            return response;
        }
        public async Task<Response<bool>> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Controller a = await _Repository.GetById(id);
            await _Repository.Delete(a.Id);
            response.Message = MessageConstants.DeleteSuccesMessage;
            return response;
        }
        public async Task<Response<bool>> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = await _Repository.GetById(id);
            data.Active = !data.Active;
            await _Repository.Update(data);
            response.Message = data.Active ? MessageConstants.ActiveSuccesMessage : MessageConstants.InactiveSuccesMessage;
            response.Data = data.Active;
            return response;
        }
    }
}
