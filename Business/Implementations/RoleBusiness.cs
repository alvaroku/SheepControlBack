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

namespace Business.Implementations
{
    public class RoleBusiness : IRoleBusiness
    {
        RoleRepository _RoleRepository;
        public RoleBusiness(SheepControlDbContext context) {
            _RoleRepository = new RoleRepository(context);
        }

        public Response<RoleResponse> Create(RoleRequest Request)
        {
            Response<RoleResponse> response = new Response<RoleResponse>();


            Role newP = Mapper.Map<Role>(Request);

            newP.CreationDate = DateTime.Now;
            newP.ModificationDate = newP.CreationDate;
            newP.Active = true;
            _RoleRepository.Create(newP);
            response.Data = Mapper.Map<RoleResponse>(newP);
            return response;
        }

        public IEnumerable<RoleResponse> Read()
        {
            var respuesta = _RoleRepository.Read();

            var mapeo = Mapper.Map<IEnumerable<RoleResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<RoleResponse> Update(int id, RoleRequest request)
        {
            Response<RoleResponse> response = new Response<RoleResponse>();

            Role vaccine = _RoleRepository.GetById(id);

            vaccine.ModificationDate = DateTime.Now;
            vaccine.Name = request.Name;

            _RoleRepository.Update(vaccine);

            response.Data = Mapper.Map<RoleResponse>(vaccine);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            response.Data = true;
            Role sh = _RoleRepository.GetById(id);
            _RoleRepository.Delete(sh);
            return response;
        }
    }
}
