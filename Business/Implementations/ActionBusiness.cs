using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Business.Implementations
{
   public class ActionBusiness:IActionBusiness
    {
        ActionRepository _Repository;
        public ActionBusiness(SheepControlDbContext context) {
        
            _Repository = new ActionRepository(context);
        }

        public Response<ActionResponse> Create(ActionRequest actionRequest)
        {
            Response<ActionResponse> response = new Response<ActionResponse>();


            Entities.Action newAction = Mapper.Map<Entities.Action>(actionRequest);

            newAction.CreationDate = DateTime.Now;
            newAction.ModificationDate = newAction.CreationDate;

            _Repository.Create(newAction);

            response.Data = Mapper.Map<ActionResponse>(newAction);
            return response;
        }

        public IEnumerable<ActionResponse> Read()
        {
            var respuesta = _Repository.Read();

            var mapeo = Mapper.Map<IEnumerable<ActionResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<ActionResponse> Update(int id, ActionRequest request)
        {
            Response<ActionResponse> response = new Response<ActionResponse>();

            Entities.Action a = _Repository.GetById(id);

            a.ModificationDate = DateTime.Now;
            a.Name = request.Name;
            
            _Repository.Update(a);

            response.Data = Mapper.Map<ActionResponse>(a);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Entities.Action a = _Repository.GetById(id);
            _Repository.Delete(a);
            return response;
        }
        public Response<bool> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();
            
            var data = _Repository.GetById(id);
            data.Active = !data.Active;
            _Repository.Update(data);

            response.Data = data.Active;

            return response;
        }
    }
}
