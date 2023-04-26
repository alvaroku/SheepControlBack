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
    public class PermissionBusiness:IPermissionBusiness
    {
        PermissionRepository _PermissionRepository;
        public PermissionBusiness(SheepControlDbContext context) {
            _PermissionRepository = new PermissionRepository(context);
        }

        public Response<PermissionResponse> Create(PermissionRequest permissionRequest)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PermissionResponse> Read()
        {
            var respuesta = _PermissionRepository.Read();

            var mapeo = Mapper.Map<IEnumerable<PermissionResponse>>(respuesta);

            return mapeo.ToList();
        }
    }
}
