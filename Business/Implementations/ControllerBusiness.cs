using AutoMapper;
using Business.Definitions;
using Business.Utils;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;

namespace Business.Implementations
{
    public class ControllerBusiness:IControllerBusiness
    {
        ControllerRepository _Repository;
        public ControllerBusiness(SheepControlDbContext context)
        {
            _Repository = new ControllerRepository(context);
        }

        public Response<ControllerResponse> Create(ControllerRequest controllerRequest)
        {
            Response<ControllerResponse> response = new Response<ControllerResponse>();


            Controller newAction = Mapper.Map<Controller>(controllerRequest);

            _Repository.Create(newAction);
            response.Message = Constants.CreateSuccesMessage;
            response.Data = Mapper.Map<ControllerResponse>(newAction);
            return response;
        }

        public IEnumerable<ControllerResponse> Read()
        {
            var respuesta = _Repository.Read();

            var mapeo = Mapper.Map<IEnumerable<ControllerResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<ControllerResponse> Update(int id, ControllerRequest request)
        {
            Response<ControllerResponse> response = new Response<ControllerResponse>();

            Controller a = _Repository.GetById(id);

            a.ModificationDate = DateTime.Now;
            a.Name = request.Name;

            _Repository.Update(a);
            response.Message = Constants.UpdateSuccesMessage;
            response.Data = Mapper.Map<ControllerResponse>(a);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Controller a = _Repository.GetById(id);
            _Repository.Delete(a);
            response.Message = Constants.DeleteSuccesMessage;
            return response;
        }
        public Response<bool> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = _Repository.GetById(id);
            data.Active = !data.Active;
            _Repository.Update(data);
            response.Message = data.Active ? Constants.ActiveSuccesMessage : Constants.InactiveSuccesMessage;
            response.Data = data.Active;
            return response;
        }
    }
}
