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
        public SaleSheepBusiness(SheepControlDbContext context) {
        
            _Repository = new SaleSheepRepository(context);
            _SheepRepository = new SheepRepository(context);
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

            response.Data = Mapper.Map<SaleSheepResponse>(newSaleSheep);
            return response;
        }

        public IEnumerable<SaleSheepResponse> Read()
        {
            var respuesta = _Repository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<SaleSheepResponse>>(respuesta);

            return mapeo.ToList();
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
