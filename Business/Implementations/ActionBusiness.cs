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
    }
}
