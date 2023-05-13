﻿using Entities.DTOs;

namespace Business.Definitions
{
    public interface ISheepBusiness
    {
        public Response<SheepResponse> Create(SheepRequest sheepRequest);
        public IEnumerable<SheepResponse> Read();
        public Response<SheepResponse> GetById(int id);
        public Response<SheepResponse> Update(int id, SheepRequest sheepRequest, string fullPathImage);
        public Response<bool> Delete(int id, string _fullPathImage);
    }
}
