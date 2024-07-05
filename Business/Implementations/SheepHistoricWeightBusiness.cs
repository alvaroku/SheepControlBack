using AutoMapper;
using Business.Definitions;
using DataAccess.Repositories.Definitions;
using Entities;
using Entities.DTOs;
using Shared;

namespace Business.Implementations
{
    public class SheepHistoricWeightBusiness : ISheepHistoricWeightBusiness
    {
        ISheepHistoricWeightRepository _Repository;
        public SheepHistoricWeightBusiness(ISheepHistoricWeightRepository sheepHistoricWeightRepository)
        {
            _Repository = sheepHistoricWeightRepository;
        }
        public async Task<Response<SheepHistoricWeightResponse>> Create(SheepHistoricWeightRequest request)
        {
            Response<SheepHistoricWeightResponse> response = new Response<SheepHistoricWeightResponse>();


            SheepHistoricWeight sheepHistoricWeight = Mapper.Map<SheepHistoricWeight>(request);

            sheepHistoricWeight.CreationDate = DateTime.Now;
            sheepHistoricWeight.Active = true;
            sheepHistoricWeight.ModificationDate = DateTime.Now;

            await _Repository.Add(sheepHistoricWeight);
            response.Message = MessageConstants.CreateSuccesMessage;
            response.Data = Mapper.Map<SheepHistoricWeightResponse>(sheepHistoricWeight);
            return response;
        }

        public async Task<Response<IEnumerable<SheepHistoricWeightResponse>>> Read()
        {
            Response<IEnumerable<SheepHistoricWeightResponse>> response = new Response<IEnumerable<SheepHistoricWeightResponse>>();
            var respuesta =await _Repository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<SheepHistoricWeightResponse>>(respuesta);

            response.Data = mapeo.ToList().OrderBy(x => x.Id).OrderBy(x => x.SheepId);
            return response;
        }
        public async Task<Response<SheepHistoricWeightResponse>> Update(int id, SheepHistoricWeightRequest request)
        {
            Response<SheepHistoricWeightResponse> response = new Response<SheepHistoricWeightResponse>();


            SheepHistoricWeight sheepHistoricWeight = await _Repository.GetById(id);

            sheepHistoricWeight.ModificationDate = DateTime.Now;
            sheepHistoricWeight.NewWeight = request.NewWeight;
            sheepHistoricWeight.WeighingDate = request.WeighingDate;

           await _Repository.Update(sheepHistoricWeight);

            response.Data = Mapper.Map<SheepHistoricWeightResponse>(sheepHistoricWeight);
            response.Message = MessageConstants.UpdateSuccesMessage;
            return response;
        }
        public async Task<Response<bool>> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            SheepHistoricWeight sh =await _Repository.GetById(id);

            SheepHistoricWeight sheepHistoricWeight = _Repository.GetAll().Result.Where(x => x.SheepId == sh.SheepId).First();
            if (sh.Id == sheepHistoricWeight.Id)
            {
                response.Data = false;
                response.Success = false;
                response.Message = "El primer registro de pesado no se puede eliminar.";
                response.StatusCode = (int)EnumStatusCode.BadRequest;
                return response;
            }

            await _Repository.Delete(sh.Id);
            response.Message = MessageConstants.DeleteSuccesMessage;
            return response;
        }
        public async Task<Response<bool>> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = await _Repository.GetById(id);
            data.Active = !data.Active;
            await _Repository.Update(data);
            response.Data = data.Active;
            response.Message = data.Active ? MessageConstants.ActiveSuccesMessage : MessageConstants.InactiveSuccesMessage;
            return response;
        }
    }
}
