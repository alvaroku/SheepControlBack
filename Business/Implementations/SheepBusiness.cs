using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Implementations;
using Entities;
using Entities.DTOs;
using Shared;

namespace Business.Implementations
{
    public class SheepBusiness : ISheepBusiness
    {
        ISheepRepository _Repository;
        ISheepHistoricWeightRepository _HistoricWeightRepository;
        IFileManager fileManager;
        public SheepBusiness(SheepControlDbContext context, IFileManager _fileManager, ISheepRepository sheepRepository,ISheepHistoricWeightRepository sheepHistoricWeightRepository)
        {
            _Repository = sheepRepository;
            _HistoricWeightRepository = sheepHistoricWeightRepository;
            fileManager = _fileManager;
        }

        public async Task<Response<SheepResponse>> Create(SheepRequest sheepRequest)
        {
            Response<SheepResponse> response = new Response<SheepResponse>();

            try
            {
                Sheep newSheep = Mapper.Map<Sheep>(sheepRequest);

                newSheep.CreationDate = DateTime.Now;
                newSheep.ModificationDate = newSheep.CreationDate;
                newSheep.Active = true;

                newSheep.Photo = fileManager.UploadImage(PathConstants.SHEEPIMAGEPATH, sheepRequest.ImageFile);

                await _Repository.Add(newSheep);

                SheepHistoricWeight sheepHistoricWeight = new SheepHistoricWeight
                {
                    Active = true,
                    CreationDate = newSheep.CreationDate,
                    ModificationDate = newSheep.ModificationDate,
                    NewWeight = newSheep.Weight,
                    SheepId = newSheep.Id,
                    WeighingDate = newSheep.CreationDate,
                };

                await _HistoricWeightRepository.Add(sheepHistoricWeight);

                response.Data = Mapper.Map<SheepResponse>(newSheep);
                response.Message = MessageConstants.CreateSuccesMessage;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                response.StatusCode = (int)EnumStatusCode.InternalServer;
            }

            return response;
        }

        public async Task<IEnumerable<SheepResponse>> Read()
        {
            var respuesta = await _Repository.GetAll();

            var mapeo = Mapper.Map<IEnumerable<SheepResponse>>(respuesta);

            return mapeo.ToList();
        }
        public async Task<IEnumerable<SheepResponse>>  GetSheepsWithFinalWeight()
        {
            List<Sheep> respuesta = _Repository.GetAll().Result.ToList();

            for (int i = 0; i < respuesta.Count(); i++)
            {
                if (_HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == respuesta[i].Id).Count() > 0)
                {
                    respuesta[i].Weight = _HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == respuesta[i].Id).OrderByDescending(x => x.Id).First().NewWeight;
                }
            }

            var mapeo = Mapper.Map<IEnumerable<SheepResponse>>(respuesta);

            return mapeo.ToList();
        }
        public async Task<Response<SheepResponse>> Update(int id, SheepRequest sheepRequest)
        {
            Response<SheepResponse> response = new Response<SheepResponse>();

            try
            {
                Sheep sheep = await _Repository.GetById(id);

                if (sheep.Sold)
                {
                    throw new Exception("No se puede modificar un ejemplar vendido.");
                }

                if (sheepRequest.ImageFile != null)
                {
                    fileManager.DeleteFile(PathConstants.SHEEPIMAGEPATH, sheepRequest.Photo);
                    sheep.Photo = fileManager.UploadImage(PathConstants.SHEEPIMAGEPATH, sheepRequest.ImageFile); ;
                }

                sheep.ModificationDate = DateTime.Now;
                sheep.BirthDate = sheepRequest.BirthDate;
                sheep.Weight = sheepRequest.Weight;
                sheep.Description = sheepRequest.Description;
                sheep.Sex = sheepRequest.Sex;
                sheep.AcquisitionCost = sheepRequest.AcquisitionCost;
                sheep.KiloPrice = sheepRequest.KiloPrice;
                sheep.IsAcquisition = sheepRequest.IsAcquisition;

               await _Repository.Update(sheep);

                SheepHistoricWeight sheepHistoricWeight = _HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == sheep.Id).First();

                if (sheepHistoricWeight.NewWeight != sheep.Weight)
                {
                    sheepHistoricWeight.NewWeight = sheep.Weight;
                    sheepHistoricWeight.ModificationDate = DateTime.Now;
                    await _HistoricWeightRepository.Update(sheepHistoricWeight);
                }
                response.Data = Mapper.Map<SheepResponse>(sheep);
                response.Message = MessageConstants.UpdateSuccesMessage;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                response.StatusCode = (int)EnumStatusCode.BadRequest;
            }
            return response;
        }
        public async Task<Response<bool>> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            Sheep sh =await _Repository.GetById(id);
            fileManager.DeleteFile(PathConstants.SHEEPIMAGEPATH, sh.Photo);
            await _Repository.Delete(sh.Id);
            response.Message = MessageConstants.DeleteSuccesMessage;
            return response;
        }
        public async Task<Response<SheepResponse>> GetById(int id)
        {
            Response<SheepResponse> response = new Response<SheepResponse>();
            Sheep she = await _Repository.GetById(id);
            response.Data = Mapper.Map<SheepResponse>(she);
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
            return fileManager.GetImage(PathConstants.SHEEPIMAGEPATH, imageName);
        }
    }
}
