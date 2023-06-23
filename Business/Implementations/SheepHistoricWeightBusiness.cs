using AutoMapper;
using Business.Definitions;
using Business.Utils;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;

namespace Business.Implementations
{
    public class SheepHistoricWeightBusiness : ISheepHistoricWeightBusiness
    {
        SheepHistoricWeightRepository _Repository;
        public SheepHistoricWeightBusiness(SheepControlDbContext context) {
            _Repository = new SheepHistoricWeightRepository(context);
        }
        public Response<SheepHistoricWeightResponse> Create(SheepHistoricWeightRequest request)
        {
            Response<SheepHistoricWeightResponse> response = new Response<SheepHistoricWeightResponse>();


            SheepHistoricWeight sheepHistoricWeight = Mapper.Map<SheepHistoricWeight>(request);

            sheepHistoricWeight.CreationDate = DateTime.Now;
            sheepHistoricWeight.Active = true;
            sheepHistoricWeight.ModificationDate = DateTime.Now;

            if (_Repository.Read().Where(z=>z.SheepId==request.SheepId).Count() == 0)
            {
                Sheep s = _Repository._context.Sheeps.Where(s => s.Id == request.SheepId).First();
                sheepHistoricWeight.PreviousWeight = s.Weight;
                sheepHistoricWeight.DifferenceWithPreviousWeight = sheepHistoricWeight.NewWeight - s.Weight;
            }
            else if(_Repository.Read().Where(z => z.SheepId == request.SheepId).Count() == 1)
            {
                float prevWeight = _Repository.Read().Where(x => x.SheepId == request.SheepId).OrderByDescending(x => x.Id).Take(1).First().NewWeight;
                sheepHistoricWeight.PreviousWeight = prevWeight;
                sheepHistoricWeight.DifferenceWithPreviousWeight = sheepHistoricWeight.NewWeight - prevWeight;
            }
            else
            {
                float prevWeight = _Repository.Read().Where(x => x.SheepId == request.SheepId).OrderByDescending(x => x.Id).First().NewWeight;
                sheepHistoricWeight.PreviousWeight = prevWeight;
                sheepHistoricWeight.DifferenceWithPreviousWeight = sheepHistoricWeight.NewWeight - prevWeight;
            }


            _Repository.Create(sheepHistoricWeight);
            response.Message = Constants.CreateSuccesMessage;
            response.Data = Mapper.Map<SheepHistoricWeightResponse>(sheepHistoricWeight);
            return response;
        }

        public Response<IEnumerable<SheepHistoricWeightResponse>> Read()
        {
            Response<IEnumerable<SheepHistoricWeightResponse>> response = new Response<IEnumerable<SheepHistoricWeightResponse>>();
            var respuesta = _Repository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<SheepHistoricWeightResponse>>(respuesta);

             response.Data = mapeo.ToList().OrderBy(x=>x.Id).OrderBy(x=>x.SheepId);
            return response;
        }
        public Response<SheepHistoricWeightResponse> Update(int id,SheepHistoricWeightRequest request)
        {
            Response<SheepHistoricWeightResponse> response = new Response<SheepHistoricWeightResponse>();


            SheepHistoricWeight sheepHistoricWeight = _Repository.GetById(id);

            sheepHistoricWeight.ModificationDate = DateTime.Now;
            sheepHistoricWeight.NewWeight = request.NewWeight;
            sheepHistoricWeight.WeighingDate = request.WeighingDate;

            if (_Repository.Read().Where(z => z.SheepId == request.SheepId).Count() == 1)
            {
                Sheep s = _Repository._context.Sheeps.Where(s=>s.Id == request.SheepId).First();
                sheepHistoricWeight.PreviousWeight = s.Weight;
                sheepHistoricWeight.DifferenceWithPreviousWeight = sheepHistoricWeight.NewWeight - s.Weight;
            }
            else
            {
                float prevWeight = _Repository.Read().Where(x=>x.SheepId==request.SheepId).OrderByDescending(x=>x.Id).Skip(1).First().NewWeight;
                sheepHistoricWeight.PreviousWeight = prevWeight;
                sheepHistoricWeight.DifferenceWithPreviousWeight = sheepHistoricWeight.NewWeight - prevWeight;
            }

            _Repository.Update(sheepHistoricWeight);

            response.Data = Mapper.Map<SheepHistoricWeightResponse>(sheepHistoricWeight);
            response.Message = Constants.UpdateSuccesMessage;
            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            SheepHistoricWeight sh = _Repository.GetById(id);
            _Repository.Delete(sh);
            response.Message = Constants.DeleteSuccesMessage;
            return response;
        }
        public Response<bool> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = _Repository.GetById(id);
            data.Active = !data.Active;
            _Repository.Update(data);
            response.Data = data.Active;
            response.Message = data.Active ? Constants.ActiveSuccesMessage : Constants.InactiveSuccesMessage;
            return response;
        }
    }
}
