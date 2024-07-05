using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Repositories.Definitions;
using Entities;
using Entities.DTOs;
using Shared;

namespace Business.Implementations
{
    public class VaccineBusiness : IVaccineBusiness
    {
        IVaccineRepository _Repository;
        IVaccineStockRepository _VaccineStockRepository;
        IFileManager _fileManager { get; set; }
        public VaccineBusiness(SheepControlDbContext context, IFileManager fileManager, IVaccineRepository vaccineRepository, IVaccineStockRepository vaccineStockRepository)
        {
            _Repository = vaccineRepository;
            _VaccineStockRepository = vaccineStockRepository;
            _fileManager = fileManager;
        }

        public async Task<Response<VaccineResponse>> Create(VaccineRequest request)
        {
            Response<VaccineResponse> response = new Response<VaccineResponse>();

            try
            {
                Vaccine newData = Mapper.Map<Vaccine>(request);

                newData.CreationDate = DateTime.Now;
                newData.ModificationDate = newData.CreationDate;
                newData.Active = true;

                newData.Photo = _fileManager.UploadImage(PathConstants.VACCINEIMAGEPATH, request.ImageFile);

                await _Repository.Add(newData);

                VaccineStock newD = Mapper.Map<VaccineStock>(request.VaccineStock);
                newD.VaccineId = newData.Id;
                newD.CreationDate = newData.CreationDate;
                newD.ModificationDate = newData.CreationDate;
                newD.Active = true;
                await _VaccineStockRepository.Add(newD);
                response.Message = MessageConstants.CreateSuccesMessage;
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

        public async Task<IEnumerable<VaccineResponse>> Read()
        {
            var respuesta = await _Repository.GetAll();

            var mapeo = Mapper.Map<IEnumerable<VaccineResponse>>(respuesta);

            return mapeo.ToList();
        }
        public async Task<Response<VaccineResponse>> Update(int id, VaccineUpdateRequest request)
        {
            Response<VaccineResponse> response = new Response<VaccineResponse>();

            Vaccine vaccine = await _Repository.GetById(id);

            if (request.ImageFile != null)
            {
                _fileManager.DeleteFile(PathConstants.VACCINEIMAGEPATH, request.Photo);
                vaccine.Photo = _fileManager.UploadImage(PathConstants.VACCINEIMAGEPATH, request.ImageFile); ;
            }

            vaccine.ModificationDate = DateTime.Now;
            vaccine.Observations = request.Observations;
            vaccine.Name = request.Name;
            vaccine.IndicatedDose = request.IndicatedDose;

            await _Repository.Update(vaccine);
            response.Message = MessageConstants.UpdateSuccesMessage;
            response.Data = Mapper.Map<VaccineResponse>(vaccine);

            return response;
        }
        public async Task<Response<bool>> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Vaccine sh = await _Repository.GetById(id);
            _fileManager.DeleteFile(PathConstants.VACCINEIMAGEPATH, sh.Photo);
            await _Repository.Delete(sh.Id);
            response.Message = MessageConstants.DeleteSuccesMessage;
            return response;
        }
        public async Task<Response<VaccineResponse>> GetById(int id)
        {
            Response<VaccineResponse> response = new Response<VaccineResponse>();
            Vaccine she = await _Repository.GetById(id);
            response.Data = Mapper.Map<VaccineResponse>(she);
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
        public FileStream GetImage(string imageName)
        {
            return _fileManager.GetImage(PathConstants.VACCINEIMAGEPATH, imageName);
        }
    }
}
