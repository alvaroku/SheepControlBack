using AutoMapper;
using Business.Definitions;
using Business.Utils;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;

namespace Business.Implementations
{
    public class VaccineStockBusiness : IVaccineStockBusiness
    {
        VaccineStockRepository _Repository;
        public VaccineStockBusiness(SheepControlDbContext context)
        {
            _Repository = new VaccineStockRepository(context);
        }

        public Response<VaccineStockResponse> Create(VaccineStockRequest controllerRequest)
        {
            Response<VaccineStockResponse> response = new Response<VaccineStockResponse>();


            VaccineStock newAction = Mapper.Map<VaccineStock>(controllerRequest);
            newAction.ModificationDate = DateTime.Now;
            newAction.CreationDate = DateTime.Now;
            _Repository.Create(newAction);
            response.Message = Constants.CreateSuccesMessage;
            response.Data = Mapper.Map<VaccineStockResponse>(_Repository.GetByIdIncludes(newAction.Id));
            return response;
        }

        public Response<IEnumerable<VaccineStockResponse>> Read()
        {
            Response<IEnumerable<VaccineStockResponse>> response = new Response<IEnumerable<VaccineStockResponse>>();
            var respuesta = _Repository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<VaccineStockResponse>>(respuesta);

            response.Data = mapeo.ToList().OrderBy(x => x.Id).OrderBy(x => x.VaccineId);

            return response;
        }
        public Response<VaccineStockResponse> Update(int id, VaccineStockRequest request)
        {
            Response<VaccineStockResponse> response = new Response<VaccineStockResponse>();

            VaccineStock a = _Repository.GetById(id);

            a.ModificationDate = DateTime.Now;
            a.NetContent = request.NetContent;
            a.Unities = request.Unities;
            a.UnitPrice = request.UnitPrice;
            a.AcquisitionCost = request.AcquisitionCost;
            a.AcquisitionDate = request.AcquisitionDate;
           

            _Repository.Update(a);
            response.Message = Constants.UpdateSuccesMessage;
            response.Data = Mapper.Map<VaccineStockResponse>(_Repository.GetByIdIncludes(a.Id));

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            VaccineStock a = _Repository.GetById(id);
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
