using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;
using Business.Utils;

namespace Business.Implementations
{
    public class SheepBusiness:ISheepBusiness
    {
        SheepRepository _Repository;

        public SheepBusiness(SheepControlDbContext context) 
        { 
            _Repository = new SheepRepository(context);
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

                

                _Repository.Create(newSheep);

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
            var respuesta = _Repository.Read();

            var mapeo = Mapper.Map<IEnumerable<SheepResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<SheepResponse> Update(int id,SheepRequest sheepRequest, string fullPathImage)
        {
            Response<SheepResponse> response = new Response<SheepResponse>();

            Sheep sheep = _Repository.GetById(id);

            if (sheepRequest.ImageFile != null)
            {
                FileManager.DeleteFile(Path.Combine(fullPathImage, sheepRequest.Photo));
                sheepRequest.Photo = FileManager.UploadImage(fullPathImage, sheepRequest.ImageFile); ;
            }

            sheep.ModificationDate = DateTime.Now;
            sheep.BirthDate = sheepRequest.BirthDate;
            sheep.Weight = sheepRequest.Weight;
            sheep.Description = sheepRequest.Description;
            sheep.Sex = sheepRequest.Sex;
            if(sheepRequest.ImageFile != null)
            {
                sheep.Photo = sheepRequest.Photo;
            }

            _Repository.Update(sheep);

            response.Data = Mapper.Map<SheepResponse>(sheep);

            return response;
        }
        public Response<bool> Delete(int id,string _fullPathImage)
        {
            Response<bool> response = new Response<bool>();
            Sheep sh = _Repository.GetById(id);
            FileManager.DeleteFile(Path.Combine(_fullPathImage,sh.Photo));
            _Repository.Delete(sh);
            return response;
        }
        public Response<SheepResponse> GetById(int id)
        {
            Response<SheepResponse> response = new Response<SheepResponse>();
            Sheep she = _Repository.GetById(id);
            response.Data = Mapper.Map<SheepResponse>(she);
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
