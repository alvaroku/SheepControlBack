using AutoMapper;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Definitions
{
    public interface IVaccineBusiness
    {
        public Response<VaccineResponse> Create(VaccineRequest vaccineRequest);
        public IEnumerable<VaccineResponse> Read();
        public Response<VaccineResponse> Update(int id, VaccineRequest request, string fullPathImage);
        public Response<bool> Delete(int id, string _fullPathImage);
        public Response<VaccineResponse> GetById(int id);
    }
}
