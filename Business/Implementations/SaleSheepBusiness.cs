using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Business.Implementations
{
   public class SaleSheepBusiness : ISaleSheepBusiness
    {
        SaleSheepRepository _Repository;
        SheepRepository _SheepRepository;
        SheepHistoricWeightRepository _HistoricWeightRepository;
        public SaleSheepBusiness(SheepControlDbContext context) {
        
            _Repository = new SaleSheepRepository(context);
            _SheepRepository = new SheepRepository(context);
            _HistoricWeightRepository = new SheepHistoricWeightRepository(context);
        }

        public Response<SaleSheepResponse> Create(SaleSheepRequest SaleSheepRequest)
        {
            Response<SaleSheepResponse> response = new Response<SaleSheepResponse>();

            Sheep s = _SheepRepository.GetById(SaleSheepRequest.SheepId);

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
            
            _SheepRepository.Update(s);
            _Repository.Create(newSaleSheep);

            if (_HistoricWeightRepository.Read().Where(x => x.SheepId == newSaleSheep.SheepId).Count() > 0)
            {
                newSaleSheep.Sheep.Weight = _HistoricWeightRepository.Read().Where(x => x.SheepId == newSaleSheep.SheepId).OrderByDescending(x => x.Id).First().NewWeight;
            }

            response.Data = Mapper.Map<SaleSheepResponse>(newSaleSheep);
            return response;
        }
        public Response<IEnumerable<SaleSheepResponse>> CreateMultiple(SaleMultipleSheepRequest SaleSheepRequest)
        {
            Response<IEnumerable<SaleSheepResponse>> response = new Response<IEnumerable<SaleSheepResponse>>();

            List<Sheep> sheepsToSale = new List<Sheep>();
            List<SaleSheep> dataToInsert = new List<SaleSheep>();

            foreach (int sheepId in SaleSheepRequest.SheepIds)
            {
                Sheep s = _SheepRepository.GetById(sheepId);
                s.Sold = true;
                sheepsToSale.Add(s);
            }
            _SheepRepository.UpdateRange(sheepsToSale);

            foreach (int sheepId in SaleSheepRequest.SheepIds)
            {
                Sheep s = _SheepRepository.GetById(sheepId);

                if (_HistoricWeightRepository.Read().Where(x => x.SheepId == s.Id).Count() > 0)
                {
                    s.Weight = _HistoricWeightRepository.Read().Where(x => x.SheepId == s.Id).OrderByDescending(x => x.Id).First().NewWeight;
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
            
            _Repository.CreateRange(dataToInsert);

            for (int i = 0; i < dataToInsert.Count(); i++)
            {
                if (_HistoricWeightRepository.Read().Where(x => x.SheepId == dataToInsert[i].SheepId).Count() > 0)
                {
                    dataToInsert[i].Sheep.Weight = _HistoricWeightRepository.Read().Where(x => x.SheepId == dataToInsert[i].SheepId).OrderByDescending(x => x.Id).First().NewWeight;
                }
            }

            response.Message = $"Se vendieron {dataToInsert.Count} carneros a ${SaleSheepRequest.KiloPrice} el kg,total kg = {sheepsToSale.Sum(x => x.Weight)}, total a cobrar = ${dataToInsert.Sum(x=>x.TotalCharged)}";
            response.Data = Mapper.Map<IEnumerable<SaleSheepResponse>>(dataToInsert);
            return response;
        }

        public Response<IEnumerable<SaleSheepResponse>> Read()
        {
            Response<IEnumerable<SaleSheepResponse>> response = new Response<IEnumerable<SaleSheepResponse>>();

            var respuesta = _Repository.ReadIncludes().ToList();

            for (int i = 0; i < respuesta.Count(); i++)
            {
                if (_HistoricWeightRepository.Read().Where(x => x.SheepId == respuesta[i].SheepId).Count() > 0)
                {
                    respuesta[i].Sheep.Weight = _HistoricWeightRepository.Read().Where(x => x.SheepId == respuesta[i].SheepId).OrderByDescending(x => x.Id).First().NewWeight;
                }
            }

            var mapeo = Mapper.Map<IEnumerable<SaleSheepResponse>>(respuesta);

            response.Data = mapeo;
            return response;
        }
        public Response<IEnumerable<SaleSheepResponse>> ReadWithFilters(FilterSaleSheepRequest request)
        {
            Response<IEnumerable<SaleSheepResponse>> response = new Response<IEnumerable<SaleSheepResponse>>();
            var dataFiltered = _Repository.ReadIncludes();
            dataFiltered = dataFiltered.Where(vs => vs.SaleDate >= request.StartDate && vs.SaleDate <= request.FinishDate);
            var mapeo = Mapper.Map<IEnumerable<SaleSheepResponse>>(dataFiltered);

            response.Data = mapeo.ToList();
            return response;
        }
        public Response<SaleSheepResponse> Update(int id, SaleSheepRequest request)
        {
            Response<SaleSheepResponse> response = new Response<SaleSheepResponse>();

            Entities.SaleSheep newSaleSheep = _Repository.GetById(id);

            Sheep s = _SheepRepository.GetById(newSaleSheep.SheepId);
            s.Sold = false;
            _SheepRepository.Update(s);
            s = null;

            s = _SheepRepository.GetById(request.SheepId);
            s.Sold = true;
            _SheepRepository.Update(s);

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

            _Repository.Update(newSaleSheep);

            response.Data = Mapper.Map<SaleSheepResponse>(newSaleSheep);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Entities.SaleSheep a = _Repository.GetById(id);

            Sheep s = _SheepRepository.GetById(a.SheepId);
            s.Sold = false;
            _SheepRepository.Update(s);

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
