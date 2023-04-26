using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class RoleBusiness:IRoleBusiness
    {
        RoleRepository _RoleRepository;
        public RoleBusiness(SheepControlDbContext context) { 
        
            _RoleRepository = new RoleRepository(context);
        }

        public Response<RoleResponse> Create(RoleRequest roleRequest)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoleResponse> Read()
        {
            var respuesta = _RoleRepository.Read();

            var mapeo = Mapper.Map<IEnumerable<RoleResponse>>(respuesta);

            return mapeo.ToList();
        }
    }
}
