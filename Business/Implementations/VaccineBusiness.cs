using AutoMapper;
using Business.Definitions;
using Business.Utils;
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
    public class VaccineBusiness:IVaccineBusiness
    {
        VaccineRepository _VaccineRepository;
        public VaccineBusiness(SheepControlDbContext context)
        {
            _VaccineRepository = new VaccineRepository(context);
        }

        public Response<VaccineResponse> Create(VaccineRequest request)
        {
            Response<VaccineResponse> response = new Response<VaccineResponse>();

            try
            {
                Vaccine newData = Mapper.Map<Vaccine>(request);

                newData.CreationDate = DateTime.Now;
                newData.ModificationDate = newData.CreationDate;
                newData.Active = true;



                _VaccineRepository.Create(newData);

                response.Data = Mapper.Map<VaccineResponse>(newData);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                response.StatusCode = (int)EnumStatusCode.InternalServer;
            }

            return response; 
        }

        public IEnumerable<VaccineResponse> Read()
        {
            var respuesta = _VaccineRepository.Read();

            var mapeo = Mapper.Map<IEnumerable<VaccineResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<VaccineResponse> Update(int id, VaccineRequest request,string fullPathImage)
        {
            Response<VaccineResponse> response = new Response<VaccineResponse>();

            Vaccine vaccine = _VaccineRepository.GetById(id);

            if (request.ImageFile != null)
            {
                FileManager.DeleteFile(Path.Combine(fullPathImage,request.Photo));
                request.Photo = FileManager.UploadImage(fullPathImage, request.ImageFile); ;
            }

            vaccine.ModificationDate = DateTime.Now;
            vaccine.Description = request.Description;
            vaccine.Name = request.Name;
            vaccine.IndicatedDose = request.IndicatedDose;

            if (request.ImageFile != null)
            {
                vaccine.Photo = request.Photo;
            }

            _VaccineRepository.Update(vaccine);

            response.Data = Mapper.Map<VaccineResponse>(vaccine);

            return response;
        }
        public Response<bool> Delete(int id,string _fullPathImage)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Vaccine sh = _VaccineRepository.GetById(id);
            FileManager.DeleteFile(Path.Combine(_fullPathImage, sh.Photo));
            _VaccineRepository.Delete(sh);
            return response;
        }
        public Response<VaccineResponse> GetById(int id)
        {
            Response<VaccineResponse> response = new Response<VaccineResponse>();
            Vaccine she = _VaccineRepository.GetById(id);
            response.Data = Mapper.Map <VaccineResponse>(she);
            return response;
        }
    }
}
