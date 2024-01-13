using Entities.DTOs;

namespace Business.Definitions
{
    public interface ISheepBusiness
    {
        public Response<SheepResponse> Create(SheepRequest sheepRequest);
        public IEnumerable<SheepResponse> Read();
        public IEnumerable<SheepResponse> GetSheepsWithFinalWeight();
        public Response<SheepResponse> GetById(int id);
        public Response<SheepResponse> Update(int id, SheepRequest sheepRequest);
        public Response<bool> Delete(int id);
        public Response<bool> ToggleActive(int id);
        FileStream GetImage(string imageName);
    }
}
