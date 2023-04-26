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
    public class ControllerBusiness:IControllerBusiness
    {
        ControllerRepository _ControllerRepository;
        public ControllerBusiness(SheepControlDbContext context)
        {
            _ControllerRepository = new ControllerRepository(context);
        }

        public Response<ControllerResponse> Create(ControllerRequest controllerRequest)
        {
            Response<ControllerResponse> response = new Response<ControllerResponse>();


            Controller newAction = Mapper.Map<Controller>(controllerRequest);

            _ControllerRepository.Create(newAction);

            response.Data = Mapper.Map<ControllerResponse>(newAction);
            return response;
        }

        public IEnumerable<ControllerResponse> Read()
        {
            var respuesta = _ControllerRepository.Read();

            var mapeo = Mapper.Map<IEnumerable<ControllerResponse>>(respuesta);

            return mapeo.ToList();
        }
    }
}
