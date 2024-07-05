using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Repositories.Definitions;
using Entities.DTOs;
using Shared;

namespace Business.Implementations
{
    public class ActionBusiness : IActionBusiness
    {
        IActionRepository _Repository;
        public ActionBusiness(SheepControlDbContext context, IActionRepository actionRepository)
        {

            _Repository = actionRepository;
        }

        public async Task<Response<ActionResponse>> Create(ActionRequest actionRequest)
        {
            Response<ActionResponse> response = new Response<ActionResponse>();

            Entities.Action newAction = Mapper.Map<Entities.Action>(actionRequest);

            newAction.CreationDate = DateTime.Now;
            newAction.ModificationDate = newAction.CreationDate;

            await _Repository.Add(newAction);

            response.Message = MessageConstants.CreateSuccesMessage;
            response.Data = Mapper.Map<ActionResponse>(newAction);
            return response;
        }

        public  async Task<IEnumerable<ActionResponse>> Read()
        {
            var respuesta = await _Repository.GetAll();

            var mapeo = Mapper.Map<IEnumerable<ActionResponse>>(respuesta);

            return mapeo.ToList();
        }
        public async Task<Response<ActionResponse>> Update(int id, ActionRequest request)
        {
            Response<ActionResponse> response = new Response<ActionResponse>();

            Entities.Action a = await _Repository.GetById(id);

            a.ModificationDate = DateTime.Now;
            a.Name = request.Name;

            await _Repository.Update(a);
            response.Message = MessageConstants.UpdateSuccesMessage;
            response.Data = Mapper.Map<ActionResponse>(a);

            return response;
        }
        public async Task<Response<bool>> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            await _Repository.Delete(id);
            response.Message = MessageConstants.DeleteSuccesMessage;
            return response;
        }
        public async Task<Response<bool>> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data =await _Repository.GetById(id);
            data.Active = !data.Active;
            await _Repository.Update(data);

            response.Message = data.Active ? MessageConstants.ActiveSuccesMessage : MessageConstants.InactiveSuccesMessage;
            response.Data = data.Active;

            return response;
        }
    }
}
