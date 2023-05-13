using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;

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
        public Response<ControllerResponse> Update(int id, ControllerRequest request)
        {
            Response<ControllerResponse> response = new Response<ControllerResponse>();

            Controller a = _ControllerRepository.GetById(id);

            a.ModificationDate = DateTime.Now;
            a.Name = request.Name;

            _ControllerRepository.Update(a);

            response.Data = Mapper.Map<ControllerResponse>(a);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Controller a = _ControllerRepository.GetById(id);
            _ControllerRepository.Delete(a);
            return response;
        }
    }
}
