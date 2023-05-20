using AutoMapper;
using Business.Definitions;
using Business.Utils;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;

namespace Business.Implementations
{
    public class VaccineBusiness:IVaccineBusiness
    {
        VaccineRepository _Repository;
        public VaccineBusiness(SheepControlDbContext context)
        {
            _Repository = new VaccineRepository(context);
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



                _Repository.Create(newData);

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
            var respuesta = _Repository.Read();

            var mapeo = Mapper.Map<IEnumerable<VaccineResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<VaccineResponse> Update(int id, VaccineRequest request,string fullPathImage)
        {
            Response<VaccineResponse> response = new Response<VaccineResponse>();

            Vaccine vaccine = _Repository.GetById(id);

            if (request.ImageFile != null)
            {
                FileManager.DeleteFile(Path.Combine(fullPathImage,request.Photo));
                request.Photo = FileManager.UploadImage(fullPathImage, request.ImageFile); ;
            }

            vaccine.ModificationDate = DateTime.Now;
            vaccine.Observations = request.Observations;
            vaccine.Name = request.Name;
            vaccine.IndicatedDose = request.IndicatedDose;

            if (request.ImageFile != null)
            {
                vaccine.Photo = request.Photo;
            }

            vaccine.NetContent = request.NetContent;
            vaccine.Unities = request.Unities;
            vaccine.UnitPrice = request.UnitPrice;
            vaccine.AcquisitionCost = request.AcquisitionCost;

            _Repository.Update(vaccine);

            response.Data = Mapper.Map<VaccineResponse>(vaccine);

            return response;
        }
        public Response<bool> Delete(int id,string _fullPathImage)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Vaccine sh = _Repository.GetById(id);
            FileManager.DeleteFile(Path.Combine(_fullPathImage, sh.Photo));
            _Repository.Delete(sh);
            return response;
        }
        public Response<VaccineResponse> GetById(int id)
        {
            Response<VaccineResponse> response = new Response<VaccineResponse>();
            Vaccine she = _Repository.GetById(id);
            response.Data = Mapper.Map <VaccineResponse>(she);
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
