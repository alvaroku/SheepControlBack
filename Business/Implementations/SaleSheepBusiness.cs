using AutoMapper;
using Business.Definitions;
using DataAccess.Repositories.Definitions;
using Entities;
using Entities.DTOs;
using Shared;

namespace Business.Implementations
{
    public class SaleSheepBusiness : ISaleSheepBusiness
    {
        ISaleSheepRepository _Repository;
        ISheepRepository _SheepRepository;
        ISheepHistoricWeightRepository _HistoricWeightRepository;
        public SaleSheepBusiness(ISaleSheepRepository saleSheepRepository, ISheepRepository sheepRepository, ISheepHistoricWeightRepository sheepHistoricWeightRepository)
        {

            _Repository = saleSheepRepository;
            _SheepRepository = sheepRepository;
            _HistoricWeightRepository = sheepHistoricWeightRepository;
        }

        public async Task<Response<SaleSheepResponse>> Create(SaleSheepRequest SaleSheepRequest)
        {
            Response<SaleSheepResponse> response = new Response<SaleSheepResponse>();

            Sheep s = await _SheepRepository.GetById(SaleSheepRequest.SheepId);

            Entities.SaleSheep newSaleSheep = Mapper.Map<Entities.SaleSheep>(SaleSheepRequest);

            newSaleSheep.CreationDate = DateTime.Now;
            newSaleSheep.ModificationDate = newSaleSheep.CreationDate;

            newSaleSheep.TotalCharged = s.Weight * SaleSheepRequest.KiloPrice;

            if (s.IsAcquisition)
            {
                newSaleSheep.SaleProfit = newSaleSheep.TotalCharged - s.AcquisitionCost;
            }
            else
            {
                newSaleSheep.SaleProfit = newSaleSheep.TotalCharged;
            }

            s.Sold = true;

            await _SheepRepository.Update(s);
            await _Repository.Add(newSaleSheep);

            if (_HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == newSaleSheep.SheepId).Count() > 0)
            {
                newSaleSheep.Sheep.Weight = _HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == newSaleSheep.SheepId).OrderByDescending(x => x.Id).First().NewWeight;
            }
            response.Message = MessageConstants.CreateSuccesMessage;
            response.Data = Mapper.Map<SaleSheepResponse>(newSaleSheep);
            return response;
        }
        public async Task<Response<IEnumerable<SaleSheepResponse>>> CreateMultiple(SaleMultipleSheepRequest SaleSheepRequest)
        {
            Response<IEnumerable<SaleSheepResponse>> response = new Response<IEnumerable<SaleSheepResponse>>();

            List<Sheep> sheepsToSale = new List<Sheep>();
            List<SaleSheep> dataToInsert = new List<SaleSheep>();

            foreach (int sheepId in SaleSheepRequest.SheepIds)
            {
                Sheep s = await _SheepRepository.GetById(sheepId);
                s.Sold = true;
                sheepsToSale.Add(s);
            }
            await _SheepRepository.UpdateRange(sheepsToSale);

            foreach (int sheepId in SaleSheepRequest.SheepIds)
            {
                Sheep s = await _SheepRepository.GetById(sheepId);

                if (_HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == s.Id).Count() > 0)
                {
                    s.Weight = _HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == s.Id).OrderByDescending(x => x.Id).First().NewWeight;
                }


                float precioCobrado = s.Weight * SaleSheepRequest.KiloPrice;
                float ganancia = 0;
                if (s.IsAcquisition)
                {
                    ganancia = precioCobrado - s.AcquisitionCost;
                }
                else
                {
                    ganancia = precioCobrado;
                }

                dataToInsert.Add(
                        new SaleSheep
                        {
                            Active = true,
                            CreationDate = DateTime.Now,
                            ModificationDate = DateTime.Now,
                            TotalCharged = precioCobrado,
                            SaleProfit = ganancia,
                            KiloPrice = SaleSheepRequest.KiloPrice,
                            SheepId = s.Id,
                            SaleDate = SaleSheepRequest.SaleDate
                        }
                    );
            }

            await _Repository.CreateRange(dataToInsert);

            for (int i = 0; i < dataToInsert.Count(); i++)
            {
                if (_HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == dataToInsert[i].SheepId).Count() > 0)
                {
                    dataToInsert[i].Sheep.Weight = _HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == dataToInsert[i].SheepId).OrderByDescending(x => x.Id).First().NewWeight;
                }
            }

            response.Message = $"Se vendieron {dataToInsert.Count} carneros a ${SaleSheepRequest.KiloPrice} el kg, total kg = {sheepsToSale.Sum(x => x.Weight)}, total a cobrar = ${dataToInsert.Sum(x => x.TotalCharged)}";
            response.Data = Mapper.Map<IEnumerable<SaleSheepResponse>>(dataToInsert);
            return response;
        }

        public async Task<Response<IEnumerable<SaleSheepResponse>>> Read()
        {
            Response<IEnumerable<SaleSheepResponse>> response = new Response<IEnumerable<SaleSheepResponse>>();

            var respuesta = _Repository.ReadIncludes().Result.ToList();

            for (int i = 0; i < respuesta.Count(); i++)
            {
                if (_HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == respuesta[i].SheepId).Count() > 0)
                {
                    respuesta[i].Sheep.Weight = _HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == respuesta[i].SheepId).OrderByDescending(x => x.Id).First().NewWeight;
                }
            }

            var mapeo = Mapper.Map<IEnumerable<SaleSheepResponse>>(respuesta);

            response.Data = mapeo;
            return response;
        }
        public async Task<Response<IEnumerable<SaleSheepResponse>>> ReadWithFilters(FilterSaleSheepRequest request)
        {
            Response<IEnumerable<SaleSheepResponse>> response = new Response<IEnumerable<SaleSheepResponse>>();
            var dataFiltered = await _Repository.ReadIncludes();
            dataFiltered = dataFiltered.Where(vs => vs.SaleDate >= request.StartDate && vs.SaleDate <= request.FinishDate);
            var mapeo = Mapper.Map<IEnumerable<SaleSheepResponse>>(dataFiltered);

            response.Data = mapeo.ToList();
            return response;
        }
        public async Task<Response<SaleSheepResponse>> Update(int id, SaleSheepRequest request)
        {
            Response<SaleSheepResponse> response = new Response<SaleSheepResponse>();

            Entities.SaleSheep newSaleSheep = await _Repository.GetById(id);

            Sheep s = await _SheepRepository.GetById(newSaleSheep.SheepId);
            s.Sold = false;
            await _SheepRepository.Update(s);
            s = null;

            s = await _SheepRepository.GetById(request.SheepId);
            s.Sold = true;
            await _SheepRepository.Update(s);

            newSaleSheep.ModificationDate = DateTime.Now;
            newSaleSheep.SheepId = request.SheepId;
            newSaleSheep.KiloPrice = request.KiloPrice;
            newSaleSheep.SaleDate = request.SaleDate;
            //recalcular TotalCharged SaleProfit 

            newSaleSheep.TotalCharged = s.Weight * request.KiloPrice;

            if (s.IsAcquisition)
            {
                newSaleSheep.SaleProfit = newSaleSheep.TotalCharged - s.AcquisitionCost;
            }
            else
            {
                newSaleSheep.SaleProfit = newSaleSheep.TotalCharged;
            }

            await _Repository.Update(newSaleSheep);
            response.Message = MessageConstants.UpdateSuccesMessage;
            response.Data = Mapper.Map<SaleSheepResponse>(newSaleSheep);

            return response;
        }
        public async Task<Response<bool>> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Entities.SaleSheep a = await _Repository.GetById(id);

            Sheep s = await _SheepRepository.GetById(a.SheepId);
            s.Sold = false;
            await _SheepRepository.Update(s);

            await _Repository.Delete(a.Id);
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
