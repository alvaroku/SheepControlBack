using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Implementations;
using Entities;
using Entities.DTOs;
using Shared;

namespace Business.Implementations
{
    public class VaccineStockBusiness : IVaccineStockBusiness
    {
        IVaccineStockRepository _Repository;
        public VaccineStockBusiness(IVaccineStockRepository vaccineStockRepository)
        {
            _Repository = vaccineStockRepository;
        }

        public async Task<Response<VaccineStockResponse>> Create(VaccineStockRequest controllerRequest)
        {
            Response<VaccineStockResponse> response = new Response<VaccineStockResponse>();


            VaccineStock newAction = Mapper.Map<VaccineStock>(controllerRequest);
            newAction.ModificationDate = DateTime.Now;
            newAction.CreationDate = DateTime.Now;
           await _Repository.Add(newAction);
            response.Message = MessageConstants.CreateSuccesMessage;
            response.Data = Mapper.Map<VaccineStockResponse>(_Repository.GetByIdIncludes(newAction.Id));
            return response;
        }

        public async Task<Response<IEnumerable<VaccineStockResponse>>> Read()
        {
            Response<IEnumerable<VaccineStockResponse>> response = new Response<IEnumerable<VaccineStockResponse>>();
            var respuesta =await _Repository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<VaccineStockResponse>>(respuesta);

            response.Data = mapeo.ToList().OrderBy(x => x.Id).OrderBy(x => x.VaccineId);

            return response;
        }
        public async Task<Response<VaccineStockResponse>> Update(int id, VaccineStockRequest request)
        {
            Response<VaccineStockResponse> response = new Response<VaccineStockResponse>();

            VaccineStock a = await _Repository.GetById(id);

            a.ModificationDate = DateTime.Now;
            a.NetContent = request.NetContent;
            a.Unities = request.Unities;
            a.UnitPrice = request.UnitPrice;
            a.AcquisitionCost = request.AcquisitionCost;
            a.AcquisitionDate = request.AcquisitionDate;


            await _Repository.Update(a);
            response.Message = MessageConstants.UpdateSuccesMessage;
            response.Data = Mapper.Map<VaccineStockResponse>(_Repository.GetByIdIncludes(a.Id));

            return response;
        }
        public async Task<Response<bool>> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            VaccineStock a =await _Repository.GetById(id);
            await _Repository.Delete(a.Id);
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
