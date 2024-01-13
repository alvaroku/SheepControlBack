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
        VaccineStockRepository _VaccineStockRepository;
        IFileManager _fileManager { get; set; }
        string ResourcePath = string.Empty;
        public VaccineBusiness(SheepControlDbContext context, IFileManager fileManager)
        {
            _Repository = new VaccineRepository(context);
            _VaccineStockRepository = new VaccineStockRepository(context);
            _fileManager = fileManager;
            ResourcePath = Constants.VACCINEIMAGEPATH;
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

                newData.Photo = _fileManager.UploadImage(ResourcePath, request.ImageFile);

                _Repository.Create(newData);

                VaccineStock newD = Mapper.Map<VaccineStock>(request.VaccineStock);
                newD.VaccineId = newData.Id;
                newD.CreationDate = newData.CreationDate;
                newD.ModificationDate = newData.CreationDate;
                newD.Active = true;
                _VaccineStockRepository.Create(newD);
                response.Message = Constants.CreateSuccesMessage;
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
        public Response<VaccineResponse> Update(int id, VaccineUpdateRequest request)
        {
            Response<VaccineResponse> response = new Response<VaccineResponse>();

            Vaccine vaccine = _Repository.GetById(id);

            if (request.ImageFile != null)
            {
                _fileManager.DeleteFile(ResourcePath, request.Photo);
                vaccine.Photo = _fileManager.UploadImage(ResourcePath, request.ImageFile); ;
            }

            vaccine.ModificationDate = DateTime.Now;
            vaccine.Observations = request.Observations;
            vaccine.Name = request.Name;
            vaccine.IndicatedDose = request.IndicatedDose;
        
            _Repository.Update(vaccine);
            response.Message = Constants.UpdateSuccesMessage;
            response.Data = Mapper.Map<VaccineResponse>(vaccine);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Vaccine sh = _Repository.GetById(id);
            _fileManager.DeleteFile(ResourcePath, sh.Photo);
            _Repository.Delete(sh);
            response.Message = Constants.DeleteSuccesMessage;
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
            response.Message = data.Active ? Constants.ActiveSuccesMessage : Constants.InactiveSuccesMessage;
            return response;
        }
        public FileStream GetImage(string imageName)
        {
            return _fileManager.GetImage(ResourcePath, imageName);
        }
    }
}
