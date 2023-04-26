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
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Hosting;
namespace Business.Implementations
{
    public class SheepBusiness:ISheepBusiness
    {
        SheepRepository _SheepRepository;

        public SheepBusiness(SheepControlDbContext context) { 
        
            _SheepRepository = new SheepRepository(context);
 
        }

        public Response<SheepResponse> Create(SheepRequest sheepRequest)
        {
            Response<SheepResponse> response = new Response<SheepResponse>();

            try
            {
                Sheep newSheep = Mapper.Map<Sheep>(sheepRequest);

                newSheep.CreationDate = DateTime.Now;
                newSheep.ModificationDate = newSheep.CreationDate;
                newSheep.Active = true;

                

                _SheepRepository.Create(newSheep);

                response.Data = Mapper.Map<SheepResponse>(newSheep);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                response.StatusCode = (int)EnumStatusCode.InternalServer;
            }

            return response;
        }

        public IEnumerable<SheepResponse> Read()
        {
            var respuesta = _SheepRepository.Read();

            var mapeo = Mapper.Map<IEnumerable<SheepResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<SheepResponse> Update(int id,SheepRequest sheepRequest)
        {
            Response<SheepResponse> response = new Response<SheepResponse>();

            Sheep sheep = _SheepRepository.GetById(id);

            sheep.ModificationDate = DateTime.Now;
            sheep.BirthDate = sheepRequest.BirthDate;
            sheep.Weight = sheepRequest.Weight;
            sheep.Description = sheepRequest.Description;
            sheep.Sex = sheepRequest.Sex;
            if(sheepRequest.ImageFile != null)
            {
                sheep.Photo = sheepRequest.Photo;
            }

            _SheepRepository.Update(sheep);

            response.Data = Mapper.Map<SheepResponse>(sheep);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            Sheep sh = _SheepRepository.GetById(id);
            _SheepRepository.Delete(sh);
            return response;
        }
        public Response<SheepResponse> GetById(int id)
        {
            Response<SheepResponse> response = new Response<SheepResponse>();
            Sheep she = _SheepRepository.GetById(id);
            response.Data = Mapper.Map<SheepResponse>(she);
            return response;
        }
    }
}
