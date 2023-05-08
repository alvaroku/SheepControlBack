using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
   public class ActionBusiness:IActionBusiness
    {
        ActionRepository _ActionRepository;
        public ActionBusiness(SheepControlDbContext context) {
        
            _ActionRepository = new ActionRepository(context);
        }

        public Response<ActionResponse> Create(ActionRequest actionRequest)
        {
            Response<ActionResponse> response = new Response<ActionResponse>();


            Entities.Action newAction = Mapper.Map<Entities.Action>(actionRequest);

            newAction.CreationDate = DateTime.Now;
            newAction.ModificationDate = newAction.CreationDate;

            _ActionRepository.Create(newAction);

            response.Data = Mapper.Map<ActionResponse>(newAction);
            return response;
        }

        public IEnumerable<ActionResponse> Read()
        {
            var respuesta = _ActionRepository.Read();

            var mapeo = Mapper.Map<IEnumerable<ActionResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<ActionResponse> Update(int id, ActionRequest request)
        {
            Response<ActionResponse> response = new Response<ActionResponse>();

            Entities.Action a = _ActionRepository.GetById(id);

            a.ModificationDate = DateTime.Now;
            a.Name = request.Name;
            
            _ActionRepository.Update(a);

            response.Data = Mapper.Map<ActionResponse>(a);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Entities.Action a = _ActionRepository.GetById(id);
            _ActionRepository.Delete(a);
            return response;
        }
    }
}
